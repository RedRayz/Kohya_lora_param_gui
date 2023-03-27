using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kohya_lora_trainer {
    public partial class TrainForm : Form {
        private Process process;
        private string TrainArgs;

        public TrainForm() {
            InitializeComponent();
        }

        private void TrainForm_Load(object sender, EventArgs e) {

            btnStop.Enabled = true;
            btnClose.Enabled = false;

            StringBuilder sb = new StringBuilder();
            StringBuilder sbCmd = new StringBuilder();

            sbCmd.Append(@"/k cd ");
            if (!string.IsNullOrEmpty(Form1.ScriptPath)) {
                sbCmd.Append("/d ").Append(Form1.ScriptPath);
            }
            else {
                sbCmd.Append("..\\");
            }

            sbCmd.Append(" && .\\venv\\Scripts\\activate && ");


            sb.Append("accelerate launch --num_cpu_threads_per_process ").Append(TrainParams.Current.CpuThreads);
            sb.Append(" train_network.py  --pretrained_model_name_or_path=\"").Append(TrainParams.Current.ModelPath).Append("\"").Append("  --train_data_dir=\"")
                .Append(TrainParams.Current.TrainImagePath).Append("\"  --output_dir=\"").Append(TrainParams.Current.OutputPath).Append("\"");
            //Optional(RegImage)
            if (!string.IsNullOrEmpty(TrainParams.Current.RegImagePath)) {
                sb.Append("  --reg_data_dir=\"").Append(TrainParams.Current.RegImagePath).Append("\"");
            }

            switch (TrainParams.Current.ModuleType) {
                    case ModuleType.LoRA: {
                        sb.Append("  --network_module=\"").Append("networks.lora").Append("\"");
                        if (TrainParams.Current.UseConv2dExtend) {
                            bool di = TrainParams.Current.ConvDim > 0;
                            bool al = TrainParams.Current.ConvAlpha > 0;
                            if (di || al) {
                                sb.Append("  --network_args");
                                if (di)
                                    sb.Append(" \"conv_dim=").Append(TrainParams.Current.ConvDim.ToString()).Append("\"");
                                if (al)
                                    sb.Append(" \"conv_alpha=").Append(TrainParams.Current.ConvAlpha.ToString()).Append("\"");
                            }
                        }

                    }
                    break;
                    case ModuleType.LoCon: {
                        sb.Append("  --network_module=").Append("locon.locon_kohya");
                        bool di = TrainParams.Current.ConvDim > 0;
                        bool al = TrainParams.Current.ConvAlpha > 0;
                        if (di || al) {
                            sb.Append("  --network_args");
                            if (di)
                                sb.Append(" \"conv_dim=").Append(TrainParams.Current.ConvDim.ToString()).Append("\"");
                            if (al)
                                sb.Append(" \"conv_alpha=").Append(TrainParams.Current.ConvAlpha.ToString()).Append("\"");
                        }
                    }
                    break;
                    case ModuleType.LyCORIS: {
                        sb.Append("  --network_module=").Append("lycoris.kohya");
                        sb.Append("  --network_args \"algo=").Append(TrainParams.Current.AlgoType.ToString()).Append("\"");
                        bool di = TrainParams.Current.ConvDim > 0;
                        bool al = TrainParams.Current.ConvAlpha > 0;
                        if (di || al) {
                            if (di)
                                sb.Append(" \"conv_dim=").Append(TrainParams.Current.ConvDim.ToString()).Append("\"");
                            if (al)
                                sb.Append(" \"conv_alpha=").Append(TrainParams.Current.ConvAlpha.ToString()).Append("\"");
                        }
                    }
                    break;
            }

            switch (TrainParams.Current.CrossAttenType) {
                case CrossAttenType.xformers:
                    sb.Append("  --xformers");
                    break;
                    case CrossAttenType.mem_eff_attn:
                    sb.Append("  --mem_eff_attn");
                    break;
            }

            if (TrainParams.Current.UseGradient) {
                sb.Append("  --gradient_checkpointing");
            }

            //Automatic
            sb.Append("  --persistent_data_loader_workers  --color_aug  --enable_bucket")
                .Append("  --save_model_as=safetensors  --lr_scheduler_num_cycles=4  --mixed_precision=fp16");

            //Main
            sb.Append("  --learning_rate=").Append(TrainParams.Current.LearningRate.ToString("g"))
                .Append("  --resolution=").Append(TrainParams.Current.Resolution).Append(",").Append(TrainParams.Current.Resolution)
                .Append("  --train_batch_size=").Append(TrainParams.Current.BatchSize)
                .Append("  --max_train_epochs=").Append(TrainParams.Current.Epochs);

            sb.Append("  --network_dim=").Append(TrainParams.Current.NetworkDim)
            .Append("  --network_alpha=").Append(TrainParams.Current.NetworkAlpha);

            //Optional Main
            if (TrainParams.Current.ShuffleCaptions) {
                sb.Append("  --shuffle_caption");
                if (TrainParams.Current.KeepTokenCount > 0) {
                    sb.Append("  --keep_tokens=").Append(TrainParams.Current.KeepTokenCount);
                }
            }

            if (TrainParams.Current.SaveEveryNEpochs > 0) {
                sb.Append("  --save_every_n_epochs=").Append(TrainParams.Current.SaveEveryNEpochs);
            }

            sb.Append("  --optimizer_type=\"").Append(TrainParams.Current.OptimizerType.ToString()).Append("\"");
            //AdaFactorなら引数追加
            if (TrainParams.Current.OptimizerType == OptimizerType.AdaFactor) {
                sb.Append("  --optimizer_args \"relative_step=True\" \"scale_parameter=True\" \"warmup_init=").Append(TrainParams.Current.UseWarmupInit.ToString()).Append("\"");
            }else if(TrainParams.Current.OptimizerType == OptimizerType.SGDNesterov || TrainParams.Current.OptimizerType == OptimizerType.SGDNesterov8bit) {
                sb.Append("  --optimizer_args \"momentum=").Append(TrainParams.Current.Momentum.ToString()).Append("\"");
            }

            if (TrainParams.Current.WarmupSteps > 0) {
                sb.Append("  --lr_warmup_steps=").Append(TrainParams.Current.WarmupSteps);
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.OutputName)) {
                sb.Append("  --output_name=\"").Append(TrainParams.Current.OutputName).Append("\"");
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.VAEPath)) {
                sb.Append("  --vae=\"").Append(TrainParams.Current.VAEPath).Append("\"");
            }

            //Advanced
            if (!string.IsNullOrEmpty(TrainParams.Current.LoraModelPath)) {
                sb.Append("  --network_weights=").Append("\"").Append(TrainParams.Current.LoraModelPath).Append("\"");
            }


            if (TrainParams.Current.NoBucketUpscaling) {
                sb.Append("  --bucket_no_upscale");
            }

            sb.Append("  --clip_skip=").Append(TrainParams.Current.ClipSkip)
                .Append("  --seed=").Append(TrainParams.Current.Seed)
                .Append("  --save_precision=").Append(TrainParams.Current.SavePrecision.ToString())
                .Append("  --lr_scheduler=").Append(TrainParams.Current.SchedulerType.ToString())
                .Append("  --min_bucket_reso=").Append(TrainParams.Current.MinBucketResolution)
                .Append("  --max_bucket_reso=").Append(TrainParams.Current.MaxBucketResolution)
                .Append("  --caption_extension=\"").Append(TrainParams.Current.CaptionFileExtension).Append("\"");

            switch (TrainParams.Current.advancedTrainType) {
                case AdvancedTrainType.TextEncoderOnly:
                    sb.Append("  --network_train_text_encoder_only");
                    break;
                case AdvancedTrainType.UNetOnly:
                    sb.Append("  --network_train_unet_only");
                    break;
                default:
                    break;
            }


            if (TrainParams.Current.TextEncoderLR > 0) {
                sb.Append("  --text_encoder_lr=").Append(TrainParams.Current.TextEncoderLR.ToString("g"));
            }

            if (TrainParams.Current.UnetLR > 0) {
                sb.Append("  --unet_lr=").Append(TrainParams.Current.UnetLR.ToString("g"));
            }

            if(TrainParams.Current.NoiseOffset > 0f) {
                sb.Append("  --noise_offset=").Append(TrainParams.Current.NoiseOffset.ToString());
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.TensorBoardLogPath)) {
                sb.Append("  --logging_dir=\"").Append(TrainParams.Current.TensorBoardLogPath).Append("\"");
            }

            TrainArgs = sb.ToString();

            sbCmd.Append(TrainArgs);

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = sbCmd.ToString();
            process = new Process();
            process.SynchronizingObject = this;
            process.StartInfo = ps;
            process.Exited += new EventHandler(TrainExited);
            process.EnableRaisingEvents = true;
            process.Start();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnStop_Click(object sender, EventArgs e) {
            if (process != null && !process.HasExited) {
                DialogResult result = MessageBox.Show("学習中に閉じると学習は中止されます。よろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    process.Kill();
                    process.Dispose();
                    btnStop.Enabled = false;
                    btnClose.Enabled = true;
                    process = null;
                }
            }
        }

        private void TrainExited(object sender, EventArgs e) {
            process.Dispose();
            process = null;
            btnStop.Enabled = false;
            btnClose.Enabled = true;
        }

        private void TrainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (process != null && !process.HasExited) {
                process.Kill();
                process.Dispose();
                process = null;
            }
        }

        private void btnCopyCmd_Click(object sender, EventArgs e) {
            Clipboard.SetText(TrainArgs);
        }
    }
}

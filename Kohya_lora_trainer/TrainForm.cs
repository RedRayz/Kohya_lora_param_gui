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

namespace Kohya_lora_trainer
{
    public partial class TrainForm : Form
    {
        private Process process;
        private string TrainArgs;
        private bool BenchMarkMode, ShutdownAfterComplete, ShutdownOnly;
        private Stopwatch stopwatch;
        private int Duration = 60;

        public TrainForm(bool benchMarkMode, bool shutdownAfterComplete, bool shutdownOnly)
        {
            InitializeComponent();
            BenchMarkMode = benchMarkMode;
            ShutdownAfterComplete = shutdownAfterComplete;
            ShutdownOnly = shutdownOnly;
        }

        private void TrainForm_Load(object sender, EventArgs e)
        {
            if (ShutdownOnly && ShutdownAfterComplete)
            {
                btnCopyCmd.Enabled = false;
                btnStop.Enabled = false;
                btnClose.Enabled = true;
                lblCountdown.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
                lblCountdown.Text = Duration.ToString() + "秒後にシャットダウンします \n しない場合はこのウィンドウを閉じてください";
                return;
            }

            btnStop.Enabled = true;
            btnClose.Enabled = false;
            if (BatchProcess.IsRunning)
                btnStop.Text = "バッチ処理の中止";

            StringBuilder sb = new StringBuilder();
            StringBuilder sbCmd = new StringBuilder();

            if (BenchMarkMode || ShutdownAfterComplete || BatchProcess.IsRunning)
            {
                sbCmd.Append(@"/c ");
            }
            else
            {
                sbCmd.Append(@"/k ");
            }

            sbCmd.Append("cd ");
            if (!string.IsNullOrEmpty(Form1.ScriptPath))
            {
                sbCmd.Append("/d ").Append(Form1.ScriptPath);
            }
            else
            {
                sbCmd.Append("..\\");
            }

            sbCmd.Append(" && .\\venv\\Scripts\\activate && ");


            sb.Append("accelerate launch --num_cpu_threads_per_process ").Append(TrainParams.Current.CpuThreads);
            sb.Append(" train_network.py --pretrained_model_name_or_path \"").Append(TrainParams.Current.ModelPath).Append("\"").Append(" --train_data_dir \"")
                .Append(TrainParams.Current.TrainImagePath).Append("\" --output_dir \"").Append(TrainParams.Current.OutputPath).Append("\"");
            //Optional(RegImage)
            if (!string.IsNullOrEmpty(TrainParams.Current.RegImagePath))
            {
                sb.Append(" --reg_data_dir \"").Append(TrainParams.Current.RegImagePath).Append("\"");
            }

            string lbw = GetBlockWeightCmd();

            switch (TrainParams.Current.ModuleType)
            {
                case ModuleType.LoRA:
                    {
                        sb.Append(" --network_module \"").Append("networks.lora").Append("\"");
                        if (TrainParams.Current.UseConv2dExtend)
                        {
                            bool di = TrainParams.Current.ConvDim > 0;
                            bool al = TrainParams.Current.ConvAlpha > 0;
                            if (di || al)
                            {
                                sb.Append(" --network_args");
                                if (di)
                                    sb.Append(" \"conv_dim=").Append(TrainParams.Current.ConvDim.ToString()).Append("\"");
                                if (al)
                                    sb.Append(" \"conv_alpha=").Append(TrainParams.Current.ConvAlpha.ToString()).Append("\"");
                                if (TrainParams.Current.UseBlockWeight || TrainParams.Current.UseBlockDim)
                                    sb.Append(" ").Append(lbw);
                            }
                        }
                        else if (TrainParams.Current.UseBlockWeight || TrainParams.Current.UseBlockDim)
                        {
                            sb.Append(" --network_args").Append(" ").Append(lbw);
                        }

                    }
                    break;
                case ModuleType.LyCORIS:
                    {
                        sb.Append(" --network_module \"").Append("lycoris.kohya\"");
                        sb.Append(" --network_args \"algo=").Append(TrainParams.Current.AlgoType.ToString()).Append("\"");
                        bool di = TrainParams.Current.ConvDim > 0;
                        bool al = TrainParams.Current.ConvAlpha > 0;
                        if (di || al)
                        {
                            if (di)
                                sb.Append(" \"conv_dim=").Append(TrainParams.Current.ConvDim.ToString()).Append("\"");
                            if (al)
                                sb.Append(" \"conv_alpha=").Append(TrainParams.Current.ConvAlpha.ToString()).Append("\"");
                            if (TrainParams.Current.UseBlockWeight || TrainParams.Current.UseBlockDim)
                                sb.Append(" ").Append(lbw);
                        }
                    }
                    break;
                case ModuleType.DyLoRA:
                    {
                        sb.Append(" --network_module \"").Append("networks.dylora").Append("\"");
                        sb.Append(" --network_args");
                        sb.Append(" \"unit ").Append(TrainParams.Current.DyLoRAUnit.ToString()).Append("\"");

                        if (TrainParams.Current.UseConv2dExtend)
                        {
                            bool di = TrainParams.Current.ConvDim > 0;
                            bool al = TrainParams.Current.ConvAlpha > 0;
                            if (di || al)
                            {
                                if (di)
                                    sb.Append(" \"conv_dim=").Append(TrainParams.Current.ConvDim.ToString()).Append("\"");
                                if (al)
                                    sb.Append(" \"conv_alpha=").Append(TrainParams.Current.ConvAlpha.ToString()).Append("\"");
                                if (TrainParams.Current.UseBlockWeight || TrainParams.Current.UseBlockDim)
                                    sb.Append(" ").Append(lbw);
                            }
                        }
                        else if (TrainParams.Current.UseBlockWeight || TrainParams.Current.UseBlockDim)
                        {
                            sb.Append(" ").Append(lbw);
                        }
                    }
                    break;
            }

            switch (TrainParams.Current.CrossAttenType)
            {
                case CrossAttenType.xformers:
                    sb.Append(" --xformers");
                    break;
                case CrossAttenType.mem_eff_attn:
                    sb.Append(" --mem_eff_attn");
                    break;
            }

            if (TrainParams.Current.UseGradient)
            {
                sb.Append(" --gradient_checkpointing");
            }

            if (TrainParams.Current.UseColorAug)
            {
                sb.Append(" --color_aug");
            }

            if (TrainParams.Current.UseFlipAug)
            {
                sb.Append(" --flip_aug");
            }

            if (TrainParams.Current.CropRandomly)
            {
                sb.Append(" --random_crop");
            }

            if (TrainParams.Current.UseFastLoading)
            {
                sb.Append(" --persistent_data_loader_workers");
            }

            if (TrainParams.Current.DontSaveMetadata)
            {
                sb.Append(" --no_metadata");
            }

            if (TrainParams.Current.UseSDV2)
            {
                sb.Append(" --v2");
                if (TrainParams.Current.UseParameterization)
                    sb.Append(" --v_parameterization");
            }

            if (TrainParams.Current.CacheLatents)
            {
                sb.Append(" --cache_latents");

                if (TrainParams.Current.CacheLatentsToDisk)
                {
                    sb.Append(" --cache_latents_to_disk");
                }

            }

            if(TrainParams.Current.AdaptiveNoiseScale != 0)
            {
                sb.Append(" --adaptive_noise_scale ").Append(TrainParams.Current.AdaptiveNoiseScale.ToString());
            }

            if (TrainParams.Current.MaxTokens > 75)
                sb.Append(" --max_token_length ").Append(TrainParams.Current.MaxTokens);

            sb.Append(" --max_data_loader_n_workers ").Append(TrainParams.Current.DataLoaderThreads);

            //Automatic
            sb.Append(" --enable_bucket --save_model_as \"safetensors\" --lr_scheduler_num_cycles ").Append(TrainParams.Current.LRSchedulerCycle);

            if (TrainParams.Current.mixedPrecisionType != MixedPrecisionType.None)
                sb.Append(" --mixed_precision \"").Append(TrainParams.Current.mixedPrecisionType.ToString()).Append("\"");

            //Main
            sb.Append(" --learning_rate ").Append(TrainParams.Current.LearningRate.ToString("g"))
                .Append(" --resolution ").Append(TrainParams.Current.Resolution)
                .Append(" --train_batch_size ").Append(TrainParams.Current.BatchSize)
                .Append(" --max_train_epochs ").Append(TrainParams.Current.Epochs);

            sb.Append(" --network_dim ").Append(TrainParams.Current.NetworkDim)
            .Append(" --network_alpha ").Append(TrainParams.Current.NetworkAlpha);

            //Optional Main
            if (TrainParams.Current.ShuffleCaptions)
            {
                sb.Append(" --shuffle_caption");
                if (TrainParams.Current.KeepTokenCount > 0)
                {
                    sb.Append(" --keep_tokens ").Append(TrainParams.Current.KeepTokenCount);
                }
            }

            if (TrainParams.Current.SaveEveryNEpochs > 0)
            {
                sb.Append(" --save_every_n_epochs ").Append(TrainParams.Current.SaveEveryNEpochs);
            }

            sb.Append(" --optimizer_type \"").Append(TrainParams.Current.OptimizerType.ToString()).Append("\"");

            //Optimizerの引数
            switch (TrainParams.Current.OptimizerType)
            {
                case OptimizerType.AdaFactor:
                    {
                        sb.Append(" --optimizer_args \"relative_step=True\" \"scale_parameter=True\" \"warmup_init=").Append(TrainParams.Current.UseWarmupInit.ToString()).Append("\"");
                    }
                    break;
                case OptimizerType.SGDNesterov:
                case OptimizerType.SGDNesterov8bit:
                    {
                        sb.Append(" --optimizer_args \"momentum=").Append(TrainParams.Current.Momentum.ToString()).Append("\"");
                    }
                    break;
                case OptimizerType.DAdaptAdaGrad:
                    {
                        sb.Append(" --optimizer_args \"eps=").Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
                            .Append(TrainParams.Current.D0.ToString("g")).Append("\"");

                        if (TrainParams.Current.GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append("\"");
                        }
                    }
                    break;
                case OptimizerType.DAdaptAdam:
                    {
                        sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(",").Append(TrainParams.Current.Betas1.ToString("g")).Append("\" \"eps=")
                            .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
                            .Append(TrainParams.Current.D0.ToString("g")).Append("\"");

                        if (TrainParams.Current.GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append("\"");
                        }

                    }
                    break;
                case OptimizerType.DAdaptAdan:
                    {
                        sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(",").Append(TrainParams.Current.Betas1.ToString("g")).Append(",").Append(TrainParams.Current.Betas2.ToString("g")).Append("\" \"eps=")
    .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
    .Append(TrainParams.Current.D0.ToString("g")).Append("\"");

                        if (TrainParams.Current.GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append("\"");
                        }
                    }
                    break;
                case OptimizerType.DAdaptLion:
                    {
                        sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(",").Append(TrainParams.Current.Betas1.ToString("g"))
                            .Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
                            .Append(TrainParams.Current.D0.ToString("g")).Append("\"");
                    }
                    break;
                case OptimizerType.DAdaptSGD:
                    {
                        sb.Append(" --optimizer_args \"momentum=").Append(TrainParams.Current.DAdaptMomentum.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
                            .Append(TrainParams.Current.D0.ToString("g")).Append("\"");

                        if (TrainParams.Current.GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append("\"");
                        }
                    }
                    break;
                //dadapt_adam_preprint.pyの説明にはmomontumが書いてあるが実際にはない
                case OptimizerType.DAdaptation:
                    {
                        sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(",").Append(TrainParams.Current.Betas1.ToString("g")).Append("\" \"eps=")
    .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
    .Append(TrainParams.Current.D0.ToString("g")).Append("\"");

                        if (TrainParams.Current.GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append("\"");
                        }
                    }
                    break;
                case OptimizerType.DAdaptAdanIP:
                    {
                        sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(",").Append(TrainParams.Current.Betas1.ToString("g")).Append(",").Append(TrainParams.Current.Betas2.ToString("g")).Append("\" \"eps=")
    .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
    .Append(TrainParams.Current.D0.ToString("g")).Append("\"");

                        if (TrainParams.Current.GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append("\"");
                        }
                    }
                    break;
            }

            if (TrainParams.Current.WarmupSteps > 0)
            {
                sb.Append(" --lr_warmup_steps ").Append(TrainParams.Current.WarmupSteps);
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.OutputName))
            {
                sb.Append(" --output_name \"").Append(TrainParams.Current.OutputName).Append("\"");
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.VAEPath))
            {
                sb.Append(" --vae \"").Append(TrainParams.Current.VAEPath).Append("\"");
            }

            //Advanced
            if (!string.IsNullOrEmpty(TrainParams.Current.LoraModelPath))
            {
                sb.Append(" --network_weights ").Append("\"").Append(TrainParams.Current.LoraModelPath).Append("\"");
            }


            if (TrainParams.Current.NoBucketUpscaling)
            {
                sb.Append(" --bucket_no_upscale");
            }

            sb.Append(" --clip_skip ").Append(TrainParams.Current.ClipSkip)
                .Append(" --seed ").Append(TrainParams.Current.Seed)
                .Append(" --save_precision \"").Append(TrainParams.Current.SavePrecision.ToString()).Append("\"")
                .Append(" --lr_scheduler \"").Append(TrainParams.Current.SchedulerType.ToString()).Append("\"")
                .Append(" --min_bucket_reso ").Append(TrainParams.Current.MinBucketResolution)
                .Append(" --max_bucket_reso ").Append(TrainParams.Current.MaxBucketResolution)
                .Append(" --caption_extension \"").Append(TrainParams.Current.CaptionFileExtension).Append("\"");

            switch (TrainParams.Current.advancedTrainType)
            {
                case AdvancedTrainType.TextEncoderOnly:
                    sb.Append(" --network_train_text_encoder_only");
                    break;
                case AdvancedTrainType.UNetOnly:
                    sb.Append(" --network_train_unet_only");
                    break;
                default:
                    break;
            }


            if (TrainParams.Current.TextEncoderLR > 0)
            {
                sb.Append(" --text_encoder_lr ").Append(TrainParams.Current.TextEncoderLR.ToString("g"));
            }

            if (TrainParams.Current.UnetLR > 0)
            {
                sb.Append(" --unet_lr ").Append(TrainParams.Current.UnetLR.ToString("g"));
            }

            if (TrainParams.Current.NoiseOffset > 0f)
            {
                sb.Append(" --noise_offset ").Append(TrainParams.Current.NoiseOffset.ToString());
            }

            if(TrainParams.Current.MultiresNoiseIterations > 0)
            {
                sb.Append(" --multires_noise_iterations ").Append(TrainParams.Current.MultiresNoiseIterations.ToString());
            }

            if (TrainParams.Current.MultiresNoiseDiscount > 0)
            {
                sb.Append(" --multires_noise_discount ").Append(TrainParams.Current.MultiresNoiseDiscount.ToString());
            }

            if (TrainParams.Current.MinSNRGamma > 0)
            {
                sb.Append(" --min_snr_gamma ").Append(TrainParams.Current.MinSNRGamma.ToString());
            }


            if (TrainParams.Current.UseWeightedCaptions)
            {
                sb.Append(" --weighted_captions");
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.TensorBoardLogPath))
            {
                sb.Append(" --logging_dir \"").Append(TrainParams.Current.TensorBoardLogPath).Append("\"");
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.DatasetConfigPath))
            {
                sb.Append(" --dataset_config \"").Append(TrainParams.Current.DatasetConfigPath).Append("\"");
            }

            TrainArgs = sb.ToString();
            lblCountdown.Text = string.Empty;
            sbCmd.Append(TrainArgs);

            if (BenchMarkMode)
            {
                stopwatch = Stopwatch.StartNew();
            }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ShutdownAfterComplete)
            {
                Duration = 60;
                timer1.Stop();
            }
            Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (process != null && !process.HasExited)
            {
                DialogResult result = MessageBox.Show("学習中に閉じると学習は中止されます。よろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (process == null || process.HasExited)
                        return;
                    process.Kill();
                    process.Dispose();
                    btnStop.Enabled = false;
                    btnClose.Enabled = true;
                    process = null;
                    BatchProcess.SkippedCount += BatchProcess.BatchStack.Count + 1;
                    BatchProcess.IsCancel = true;
                    BatchProcess.BatchStack.Clear();
                    BatchProcess.IsRunning = false;
                }
            }
        }

        private void TrainExited(object sender, EventArgs e)
        {
            if (process != null)
            {
                process.Dispose();
                process = null;
                btnStop.Enabled = false;
                btnClose.Enabled = true;
            }


            if(BatchProcess.IsRunning)
            {
                Close();
                return;
            }

            if (BenchMarkMode && stopwatch != null)
            {
                stopwatch.Stop();
                double tos = stopwatch.Elapsed.TotalSeconds;

                double sec = tos % 60;
                double min = tos / 60;
                double hour = min / 60;
                min = Math.Floor(min);
                hour = Math.Floor(hour);
                min -= hour * 60;

                MessageBox.Show("経過時間: " + $"{hour}h{min}m" + sec.ToString("0.000s"), "結果", MessageBoxButtons.OK);
            }

            if (ShutdownAfterComplete)
            {
                lblCountdown.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
                lblCountdown.Text = Duration.ToString() + "秒後にシャットダウンします \n しない場合はこのウィンドウを閉じてください";
            }
        }

        private void TrainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (process != null && !process.HasExited)
            {
                process.Kill();
                process.Dispose();
                process = null;
            }
        }

        private void btnCopyCmd_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TrainArgs);
        }

        private string GetBlockWeightCmd()
        {
            StringBuilder sb = new StringBuilder();
            if (TrainParams.Current.UseBlockWeight)
            {
                switch (TrainParams.Current.BlockWeightPresetTypeIn)
                {
                    case BlockWeightPresetType.none:
                        {
                            sb.Append(" \"down_lr_weight=");
                            for (int i = 0; i < 12; i++)
                            {
                                sb.Append((0.05f * TrainParams.Current.BlockWeightIn[i]).ToString());
                                if (i < 11)
                                    sb.Append(",");
                            }
                            sb.Append("\"");
                        }
                        break;
                    default:
                        {
                            sb.Append(" \"down_lr_weight=").Append(TrainParams.Current.BlockWeightPresetTypeIn.ToString());
                            if (TrainParams.Current.BlockWeightOffsetIn >= 0.25m)
                            {
                                sb.Append("+").Append(TrainParams.Current.BlockWeightOffsetIn.ToString());
                            }

                            sb.Append("\"");
                        }
                        break;
                }

                sb.Append(" \"mid_lr_weight=").Append((0.05f * TrainParams.Current.BlockWeightMid).ToString()).Append("\"");

                switch (TrainParams.Current.BlockWeightPresetTypeOut)
                {
                    case BlockWeightPresetType.none:
                        {
                            sb.Append(" \"up_lr_weight=");
                            for (int i = 0; i < 12; i++)
                            {
                                sb.Append((0.05f * TrainParams.Current.BlockWeightOut[i]).ToString());
                                if (i < 11)
                                    sb.Append(",");
                            }
                            sb.Append("\"");
                        }
                        break;
                    default:
                        {
                            sb.Append(" \"up_lr_weight=").Append(TrainParams.Current.BlockWeightPresetTypeOut.ToString());
                            if (TrainParams.Current.BlockWeightOffsetOut >= 0.25m)
                            {
                                sb.Append("+").Append(TrainParams.Current.BlockWeightOffsetOut.ToString());
                            }

                            sb.Append("\"");
                        }
                        break;
                }

                if (TrainParams.Current.BlockWeightZeroThreshold > 0)
                {
                    sb.Append(" \"block_lr_zero_threshold=").Append((0.05f * TrainParams.Current.BlockWeightZeroThreshold).ToString()).Append("\"");
                }
            }

            if (TrainParams.Current.UseBlockDim)
            {
                sb.Append(TrainParams.Current.UseConv2dExtend ? " \"conv_block_dims=" : " \"block_dims=");
                //DIM IN
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockDimIn[i]);
                    sb.Append(",");
                }
                //DIM MID
                sb.Append(TrainParams.Current.BlockDimMid).Append(",");

                //DIM OUT
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockDimOut[i]);
                    if (i < 11)
                        sb.Append(",");
                }
                sb.Append("\"");

                sb.Append(TrainParams.Current.UseConv2dExtend ? " \"conv_block_alphas=" : " \"block_alphas=");
                //ALPHA IN
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockAlphaInM[i]);
                    sb.Append(",");
                }
                //ALPHA MID
                sb.Append(TrainParams.Current.BlockAlphaMidM).Append(",");

                //ALPHA OUT
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockAlphaOutM[i]);
                    if (i < 11)
                        sb.Append(",");
                }
                sb.Append("\"");
            }

            return sb.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Duration == 0)
            {
                Duration = -1;
                if (timer1.Enabled)
                    timer1.Stop();
                ShutdownPC();
                Close();
                //MessageBox.Show("ここでシャットダウンする", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Duration > 0)
            {
                Duration--;
                lblCountdown.Text = Duration.ToString() + "秒後にシャットダウンします \n しない場合はこのウィンドウを閉じてください";
            }
        }

        private void ShutdownPC()
        {
            ProcessStartInfo ps = new ProcessStartInfo()
            {
                FileName = "shutdown.exe",
                Arguments = "/s /t 1",
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process.Start(ps);
        }
    }
}

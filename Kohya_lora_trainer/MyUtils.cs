using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Data.Common;
using Microsoft.Win32;
using Windows.Storage;

namespace Kohya_lora_trainer
{
    internal static class MyUtils
    {
        private static Dictionary<string, string> DefaultDirs = new Dictionary<string, string>();
        private static readonly List<string> NetworkArgs = new List<string>();
        private static readonly Regex WeightExtensionRegex = new Regex(@"\.pt|\.pth|\.ckpt|\.safetensors|\.sft", RegexOptions.Compiled, TimeSpan.FromMilliseconds(50));
        //private static Dictionary<string, string> DictSettings = new Dictionary<string, string>();

        internal static void SaveSettings()
        {
            try
            {
                string json = JsonSerializer.Serialize(DefaultDirs, GetOption());
                if (!string.IsNullOrEmpty(json))
                {
                    string saveto = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\lora-gui\settings.json";
                    File.WriteAllText(saveto, json);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
        }

        //internal static void LoadSettings()
        //{
        //    try
        //    {
        //        CheckAndCreateWorkDir();
        //        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\lora-gui\settings.json";

        //        if (File.Exists(path))
        //        {
        //            string json = File.ReadAllText(path);
        //            DictSettings = JsonSerializer.Deserialize<Dictionary<string, string>>(json, GetOption());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("Error: " + ex.Message);
        //    }
        //}

        internal static void SaveDefaultDirSettings()
        {
            try
            {
                CheckAndCreateWorkDir();
                string json = JsonSerializer.Serialize(DefaultDirs, GetOption());
                if (!string.IsNullOrEmpty(json))
                {
                    string saveto = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\lora-gui\lora-gui-default-dir.json";
                    File.WriteAllText(saveto, json);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
        }

        internal static void LoadDefaultDirSettings()
        {
            try
            {
                string document = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                //新しい場所に引っ越し
                CheckAndCreateWorkDir();
                string oldFile = document + @"\lora-gui-default-dir.json";
                string newFile = document + @"\lora-gui\lora-gui-default-dir.json";
                if (File.Exists(oldFile) && !File.Exists(newFile))
                {
                    File.Move(oldFile, newFile);
                }

                if (File.Exists(newFile))
                {
                    string json = File.ReadAllText(newFile);
                    DefaultDirs = JsonSerializer.Deserialize<Dictionary<string, string>>(json, GetOption());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// デフォルトディレクトリの設定を取得する。キーがない場合はstring.Emptyとなる。
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        internal static string GetDefaultDir(string key)
        {
            if (DefaultDirs.ContainsKey(key))
            {
                return DefaultDirs[key];
            }
            else
            {
                Debug.WriteLine("Warning: Missing key " + key);

                return string.Empty;
            }
        }

        internal static void SetDefaultDir(string key, string value)
        {
            DefaultDirs[key] = value;
        }

        private static JsonSerializerOptions GetOption()
        {
            // ユニコードのレンジ指定で日本語も正しく表示、インデントされるように指定
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true,
            };
            return options;
        }

        /// <summary>
        /// コマンド生成。
        /// </summary>
        /// <returns>コマンド</returns>
        internal static string GenerateCommands()
        {
            if (TrainParams.Current == null)
            {
                Debug.WriteLine("TrainParams is NULL");

                return string.Empty;
            }

            string command = TrainParams.Current.CustomCommands.Trim();
            command = command.Replace("\r\n", string.Empty);
            command = command.Trim();
            if (!string.IsNullOrWhiteSpace(command))
            {
                return command;
            }

            StringBuilder sb = new StringBuilder();
            NetworkArgs.Clear();

            sb.Append("accelerate launch --num_cpu_threads_per_process ").Append(TrainParams.Current.CpuThreads);
            switch (TrainParams.Current.StableDiffusionType)
            {
                case ModelArchitecture.Legacy:
                    sb.Append(" train_network.py");
                    break;
                case ModelArchitecture.XL:
                    sb.Append(" sdxl_train_network.py");
                    break;
                case ModelArchitecture.Flux1:
                    sb.Append(" flux_train_network.py");
                    break;
                case ModelArchitecture.SD3:
                    sb.Append(" sd3_train_network.py");
                    break;
            }
            sb.Append(" --pretrained_model_name_or_path \"").Append(TrainParams.Current.ModelPath).Append('"').Append(" --train_data_dir \"")
                .Append(TrainParams.Current.TrainImagePath).Append("\" --output_dir \"").Append(TrainParams.Current.OutputPath).Append('"');
            //Optional(RegImage)
            if (!string.IsNullOrEmpty(TrainParams.Current.RegImagePath))
            {
                sb.Append(" --reg_data_dir \"").Append(TrainParams.Current.RegImagePath).Append('"');
            }

            switch (TrainParams.Current.ModuleType)
            {
                case NetworkModule.LoRA:
                case NetworkModule.LoRAFA:
                    {
                        switch (TrainParams.Current.StableDiffusionType)
                        {
                            case ModelArchitecture.Flux1:
                                sb.Append(" --network_module \"").Append("networks.lora_flux").Append('"');
                                break;
                            case ModelArchitecture.Legacy:
                            case ModelArchitecture.XL:
                                sb.Append(" --network_module \"").Append(TrainParams.Current.ModuleType == NetworkModule.LoRA ? "networks.lora" : "networks.lora_fa").Append('"');
                                break;
                            case ModelArchitecture.SD3:
                                sb.Append(" --network_module \"").Append("networks.lora_sd3").Append('"');
                                break;
                        }


                        if (TrainParams.Current.UseConv2dExtend)
                        {
                            bool di = TrainParams.Current.ConvDim > 0;
                            bool al = TrainParams.Current.ConvAlpha > 0;
                            if (di || al)
                            {
                                if (di)
                                    NetworkArgs.Add("conv_dim=" + TrainParams.Current.ConvDim.ToString());
                                if (al)
                                    NetworkArgs.Add("conv_alpha=" + TrainParams.Current.ConvAlpha.ToString());
                            }
                        }
                    }
                    break;
                case NetworkModule.LyCORIS:
                    {
                        string algo = TrainParams.Current.AlgoType == LycoAlgo.diag_oft ? "diag-oft" : TrainParams.Current.AlgoType.ToString();

                        sb.Append(" --network_module \"").Append("lycoris.kohya\"");
                        NetworkArgs.Add("algo=" + algo);

                        if (TrainParams.Current.WeightDocomposition)
                            NetworkArgs.Add("dora_wd=True");

                        if (TrainParams.Current.TrainNorm)
                            NetworkArgs.Add("train_norm=True");

                        if (TrainParams.Current.RescaledOFT)
                            NetworkArgs.Add("rescaled=True");

                        if (TrainParams.Current.ConstrainedOFT)
                            NetworkArgs.Add("constrain=FLOAT");

                        if (TrainParams.Current.UseTucker)
                            NetworkArgs.Add("use_tucker=True");

                        if (TrainParams.Current.UseScalar)
                            NetworkArgs.Add("use_scalar=True");

                        if (TrainParams.Current.UseConv2dExtend)
                        {
                            bool di = TrainParams.Current.ConvDim > 0;
                            bool al = TrainParams.Current.ConvAlpha > 0;
                            if (di || al)
                            {
                                if (di)
                                    NetworkArgs.Add("conv_dim=" + TrainParams.Current.ConvDim.ToString());
                                if (al)
                                    NetworkArgs.Add("conv_alpha=" + TrainParams.Current.ConvAlpha.ToString());
                            }
                        }
                        else
                        {
                            NetworkArgs.Add("conv_dim=0");
                            NetworkArgs.Add("conv_alpha=0");
                        }
                    }
                    break;
                case NetworkModule.DyLoRA:
                    {
                        sb.Append(" --network_module \"").Append("networks.dylora").Append('"');
                        NetworkArgs.Add("unit=" + TrainParams.Current.DyLoRAUnit.ToString());
                        if (TrainParams.Current.UseConv2dExtend)
                        {
                            bool di = TrainParams.Current.ConvDim > 0;
                            bool al = TrainParams.Current.ConvAlpha > 0;
                            if (di || al)
                            {
                                if (di)
                                    NetworkArgs.Add("conv_dim=" + TrainParams.Current.ConvDim.ToString());
                                if (al)
                                    NetworkArgs.Add("conv_alpha=" + TrainParams.Current.ConvAlpha.ToString());
                            }
                        }
                    }
                    break;
            }

            GenerateBlockWeightCmmands();

            if (TrainParams.Current.RankDropout > 0)
                NetworkArgs.Add("rank_dropout=" + TrainParams.Current.RankDropout.ToString());
            if (TrainParams.Current.ModuleDropout > 0)
                NetworkArgs.Add("module_dropout=" + TrainParams.Current.ModuleDropout.ToString());

            if (TrainParams.Current.LoRAPlusLRRatio > 0)
            {
                NetworkArgs.Add("loraplus_lr_ratio=" + TrainParams.Current.LoRAPlusLRRatio.ToString());
            }

            if (TrainParams.Current.LoRAPlusUnetLRRatio > 0)
            {
                NetworkArgs.Add("loraplus_unet_lr_ratio=" + TrainParams.Current.LoRAPlusUnetLRRatio.ToString());
            }

            if (TrainParams.Current.LoRAPlusTELRRatio > 0)
            {
                NetworkArgs.Add("loraplus_text_encoder_lr_ratio=" + TrainParams.Current.LoRAPlusTELRRatio.ToString());
            }



            switch (TrainParams.Current.CrossAttenType)
            {
                case CrossAtten.xformers:
                    sb.Append(" --xformers");
                    break;
                case CrossAtten.mem_eff_attn:
                    sb.Append(" --mem_eff_attn");
                    break;
                case CrossAtten.sdpa:
                    sb.Append(" --sdpa");
                    break;
                default:
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

            if (TrainParams.Current.UseFullFP16)
            {
                sb.Append(" --full_fp16");
            }

            if (TrainParams.Current.CacheLatents)
            {
                sb.Append(" --cache_latents");

                if (TrainParams.Current.CacheLatentsToDisk)
                {
                    sb.Append(" --cache_latents_to_disk");
                }

            }

            if (TrainParams.Current.AdaptiveNoiseScale != 0)
            {
                sb.Append(" --adaptive_noise_scale ").Append(TrainParams.Current.AdaptiveNoiseScale.ToString());
            }

            if (TrainParams.Current.MaxTokens > 75)
                sb.Append(" --max_token_length ").Append(TrainParams.Current.MaxTokens);

            sb.Append(" --max_data_loader_n_workers ").Append(TrainParams.Current.DataLoaderThreads);

            //Automatic
            sb.Append(" --enable_bucket --save_model_as \"safetensors\"");

            switch (TrainParams.Current.SchedulerType)
            {
                case Scheduler.polynomial:
                    sb.Append(" --lr_scheduler_power ").Append(TrainParams.Current.LRSchedulerCycle.ToString("0.###"));
                    break;
                case Scheduler.cosine_with_restarts:
                    sb.Append(" --lr_scheduler_num_cycles ").Append(TrainParams.Current.LRSchedulerCycle.ToString("0.###"));
                    break;
                default:
                    break;
            }


            if (TrainParams.Current.mixedPrecisionType != MixedPrecision.None)
                sb.Append(" --mixed_precision \"").Append(TrainParams.Current.mixedPrecisionType.ToString()).Append('"');

            //Main
            sb.Append(" --learning_rate ").Append(TrainParams.Current.LearningRate.ToString("g"))
                .Append(" --resolution ").Append(TrainParams.Current.Resolution)
                .Append(" --train_batch_size ").Append(TrainParams.Current.BatchSize);

            if (TrainParams.Current.IsEpoch)
            {
                sb.Append(" --max_train_epochs ").Append(TrainParams.Current.Epochs);
            }
            else
            {
                sb.Append(" --max_train_steps ").Append(TrainParams.Current.Epochs);
            }


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
                sb.Append(TrainParams.Current.SaveWeightEveryEpoch ? " --save_every_n_epochs " : " --save_every_n_steps ").Append(TrainParams.Current.SaveEveryNEpochs);
            }

            string opt = string.Empty;
            switch (TrainParams.Current.OptimizerType)
            {
                case Optimizer.AdEMAMix8bit:
                    opt = "bitsandbytes.optim.AdEMAMix8bit";
                    break;
                case Optimizer.PagedAdEMAMix8bit:
                    opt = "bitsandbytes.optim.PagedAdEMAMix8bit";
                    break;
                case Optimizer.Came:
                    opt = "pytorch_optimizer.CAME";
                    break;
                default:
                    opt = TrainParams.Current.OptimizerType.ToString();
                    break;
            }

            

            //Optimizerの引数
            if(TrainParams.Current.OptimizerType == Optimizer.Custom)
            {
                sb.Append(" --optimizer_type \"").Append(TrainParams.Current.CustomOptName.Trim()).Append('"');
                string str1 = TrainParams.Current.CustomOptArgs.Trim();
                str1 = str1.Replace("\r\n", string.Empty);
                if (!string.IsNullOrEmpty(str1))
                {
                    sb.Append(" --optimizer_args ").Append(str1);
                }
            }
            else
            {
                sb.Append(" --optimizer_type \"").Append(opt).Append('"');
                switch (TrainParams.Current.OptimizerType)
                {
                    case Optimizer.AdaFactor:
                        {
                            sb.Append(" --optimizer_args \"relative_step=").Append(TrainParams.Current.RelativeStep.ToString()).Append("\" \"scale_parameter=").Append(TrainParams.Current.ScaleParameter.ToString()).Append("\" \"warmup_init=").Append(TrainParams.Current.UseWarmupInit.ToString()).Append('"');
                        }
                        break;
                    case Optimizer.SGDNesterov:
                    case Optimizer.SGDNesterov8bit:
                        {
                            sb.Append(" --optimizer_args \"momentum=").Append(TrainParams.Current.Momentum.ToString()).Append('"');
                        }
                        break;
                    case Optimizer.DAdaptAdaGrad:
                        {
                            sb.Append(" --optimizer_args \"eps=").Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
                                .Append(TrainParams.Current.D0.ToString("g")).Append('"');

                            if (TrainParams.Current.GrowthRate > 0f)
                            {
                                sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append('"');
                            }
                        }
                        break;
                    case Optimizer.DAdaptAdam:
                        {
                            sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g")).Append("\" \"eps=")
                                .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
                                .Append(TrainParams.Current.D0.ToString("g")).Append("\" \"decouple=").Append(TrainParams.Current.Decouple.ToString()).Append('"');

                            if (TrainParams.Current.GrowthRate > 0f)
                            {
                                sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append('"');
                            }

                        }
                        break;
                    case Optimizer.DAdaptAdan:
                        {
                            sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g")).Append(',').Append(TrainParams.Current.Betas2.ToString("g")).Append("\" \"eps=")
        .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
        .Append(TrainParams.Current.D0.ToString("g")).Append("\" \"no_prox=").Append(TrainParams.Current.NoProx.ToString()).Append('"');

                            if (TrainParams.Current.GrowthRate > 0f)
                            {
                                sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append('"');
                            }
                        }
                        break;
                    case Optimizer.DAdaptLion:
                        {
                            sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g"))
                                .Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
                                .Append(TrainParams.Current.D0.ToString("g")).Append('"');
                        }
                        break;
                    case Optimizer.DAdaptSGD:
                        {
                            sb.Append(" --optimizer_args \"momentum=").Append(TrainParams.Current.DAdaptMomentum.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
                                .Append(TrainParams.Current.D0.ToString("g")).Append('"');

                            if (TrainParams.Current.GrowthRate > 0f)
                            {
                                sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append('"');
                            }
                        }
                        break;
                    //dadapt_adam_preprint.pyの説明にはmomontumが書いてあるが実際にはない
                    //DAdaptAdamPreprint
                    case Optimizer.DAdaptation:
                        {
                            sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g")).Append("\" \"eps=")
        .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
        .Append(TrainParams.Current.D0.ToString("g")).Append("\" \"decouple=").Append(TrainParams.Current.Decouple.ToString()).Append('"');

                            if (TrainParams.Current.GrowthRate > 0f)
                            {
                                sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append('"');
                            }
                        }
                        break;
                    case Optimizer.DAdaptAdanIP:
                        {
                            sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g")).Append(',').Append(TrainParams.Current.Betas2.ToString("g")).Append("\" \"eps=")
        .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
        .Append(TrainParams.Current.D0.ToString("g")).Append("\" \"no_prox=").Append(TrainParams.Current.NoProx.ToString()).Append('"');

                            if (TrainParams.Current.GrowthRate > 0f)
                            {
                                sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append('"');
                            }
                        }
                        break;
                    case Optimizer.prodigy:
                        {
                            sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g")).Append("\" \"eps=")
        .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
        .Append(TrainParams.Current.D0.ToString("g")).Append("\" \"decouple=").Append(TrainParams.Current.Decouple.ToString()).Append("\" \"d_coef=").Append(TrainParams.Current.DCoef.ToString("g"))
        .Append("\" \"use_bias_correction=").Append(TrainParams.Current.UseBiasCorrection.ToString()).Append("\" \"safeguard_warmup=").Append(TrainParams.Current.SafeguardWarmup.ToString()).Append('"');

                            if (TrainParams.Current.GrowthRate > 0f)
                            {
                                sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append('"');
                            }

                            if (TrainParams.Current.ProdigyBeta3 > 0f)
                            {
                                sb.Append(" \"beta3=").Append(TrainParams.Current.ProdigyBeta3.ToString("g")).Append('"');
                            }
                        }
                        break;
                    case Optimizer.AdamW:
                    case Optimizer.AdamW8bit:
                    case Optimizer.AdamWScheduleFree:
                        {
                            if (TrainParams.Current.UseAdditionalOptArgs)
                            {
                                sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g")).Append("\" \"eps=")
        .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append('"');
                            }
                        }
                        break;
                    case Optimizer.Lion:
                    case Optimizer.Lion8bit:
                        {
                            if (TrainParams.Current.UseAdditionalOptArgs)
                            {
                                sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g")).
                                    Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append('"');
                            }
                        }
                        break;
                    case Optimizer.Came:
                        {
                            if (TrainParams.Current.UseAdditionalOptArgs)
                            {
                                sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g")).Append(',').Append(TrainParams.Current.Betas2.ToString("g")).Append("\" \"eps1=")
        .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"eps2=").Append(TrainParams.Current.Eps1.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append('"');
                            }
                        }
                        break;
                }
            }

            if (TrainParams.Current.WarmupSteps > 0m)
            {
                sb.Append(" --lr_warmup_steps ").Append(TrainParams.Current.WarmupSteps.ToString("0.##"));
            }

            if (TrainParams.Current.LRDecaySteps > 0m && TrainParams.Current.SchedulerType == Scheduler.warmup_stable_decay)
            {
                sb.Append(" --lr_decay_steps ").Append(TrainParams.Current.LRDecaySteps.ToString("0.##"));
            }

            if (TrainParams.Current.MinLRRatio > 0m && (TrainParams.Current.SchedulerType == Scheduler.warmup_stable_decay || TrainParams.Current.SchedulerType == Scheduler.cosine_with_min_lr))
            {
                sb.Append(" --lr_scheduler_min_lr_ratio ").Append(TrainParams.Current.MinLRRatio);
            }

            if (TrainParams.Current.SchedulerTimescale > 0m && TrainParams.Current.SchedulerType == Scheduler.inverse_sqrt)
            {
                sb.Append(" --lr_scheduler_timescale ").Append(TrainParams.Current.SchedulerTimescale);
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.OutputName))
            {
                sb.Append(" --output_name \"").Append(TrainParams.Current.OutputName.Replace("\r\n", string.Empty)).Append('"');
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.VAEPath))
            {

                switch (TrainParams.Current.StableDiffusionType)
                {
                    case ModelArchitecture.Flux1:
                        sb.Append(" --ae \"").Append(TrainParams.Current.VAEPath).Append('"');
                        break;
                    default:
                        sb.Append(" --vae \"").Append(TrainParams.Current.VAEPath).Append('"');
                        break;
                }
            }

            //Advanced
            if (!string.IsNullOrEmpty(TrainParams.Current.LoraModelPath))
            {
                sb.Append(" --network_weights ").Append('"').Append(TrainParams.Current.LoraModelPath).Append('"');
            }


            if (TrainParams.Current.NoBucketUpscaling)
            {
                sb.Append(" --bucket_no_upscale");
            }


            if (TrainParams.Current.StableDiffusionType == ModelArchitecture.Legacy)
            {
                sb.Append(" --clip_skip ").Append(TrainParams.Current.ClipSkip);
            }

            sb.Append(" --save_precision \"").Append(TrainParams.Current.SavePrecision.ToString()).Append('"')
            .Append(" --lr_scheduler \"").Append(TrainParams.Current.SchedulerType.ToString()).Append('"')
            .Append(" --min_bucket_reso ").Append(TrainParams.Current.MinBucketResolution)
            .Append(" --max_bucket_reso ").Append(TrainParams.Current.MaxBucketResolution)
            .Append(" --caption_extension \"").Append(TrainParams.Current.CaptionFileExtension).Append('"');

            if (TrainParams.Current.Seed >= 0)
            {
                sb.Append(" --seed ").Append(TrainParams.Current.Seed);
            }

            switch (TrainParams.Current.advancedTrainType)
            {
                case AdvancedTrain.TextEncoderOnly:
                    sb.Append(" --network_train_text_encoder_only");
                    break;
                case AdvancedTrain.UNetOnly:
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
                if (TrainParams.Current.RandomNoiseOffset)
                {
                    sb.Append(" --noise_offset_random_strength");
                }
            }

            if (TrainParams.Current.IpNoiseGamma > 0)
            {
                sb.Append(" --ip_noise_gamma ").Append(TrainParams.Current.IpNoiseGamma.ToString());
                if (TrainParams.Current.RandomIpNoiseGamma)
                {
                    sb.Append(" --ip_noise_gamma_random_strength");
                }
            }

            if (TrainParams.Current.MultiresNoiseIterations > 0)
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
                sb.Append(" --logging_dir \"").Append(TrainParams.Current.TensorBoardLogPath).Append('"');
                sb.Append(" --log_tracker_name \"").Append(TrainParams.Current.OutputName).Append('"');
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.DatasetConfigPath))
            {
                sb.Append(" --dataset_config \"").Append(TrainParams.Current.DatasetConfigPath).Append('"');
            }

            if (TrainParams.Current.NetworkDropout > 0)
            {
                sb.Append(" --network_dropout ").Append(TrainParams.Current.NetworkDropout.ToString());
            }

            if (TrainParams.Current.CaptionDropout > 0)
            {
                sb.Append(" --caption_dropout_rate ").Append(TrainParams.Current.CaptionDropout.ToString());
            }

            if (TrainParams.Current.CaptionTagDropout > 0)
            {
                sb.Append(" --caption_tag_dropout_rate ").Append(TrainParams.Current.CaptionTagDropout.ToString());
            }

            if (TrainParams.Current.NoHalfVAE)
            {
                sb.Append(" --no_half_vae");
            }

            if (TrainParams.Current.CacheTextencoder)
            {
                sb.Append(" --cache_text_encoder_outputs");
                if (TrainParams.Current.CacheTextencoderToDisk)
                {
                    sb.Append(" --cache_text_encoder_outputs_to_disk");
                }
            }

            if (TrainParams.Current.UseFP8Base)
            {
                sb.Append(" --fp8_base");
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.TokensSeparator))
            {
                sb.Append(" --keep_tokens_separator \"").Append(TrainParams.Current.TokensSeparator).Append('"');
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.Comment))
            {
                sb.Append(" --training_comment \"").Append(TrainParams.Current.Comment).Append('"');
            }

            if (TrainParams.Current.HighVRAM)
            {
                sb.Append(" --highvram");
            }

            if (TrainParams.Current.AlphaMask)
            {
                sb.Append(" --alpha_mask");
            }

            sb.Append(" --loss_type \"");

            switch (TrainParams.Current.LossType)
            {
                case LossType.LTwo:
                    {
                        sb.Append("l2\"");
                    }
                    break;
                case LossType.Huber:
                    {
                        sb.Append("huber\"");

                        sb.Append(" --huber_c ").Append(TrainParams.Current.HuberC.ToString());
                    }
                    break;
                case LossType.SmoothLOne:
                    {
                        sb.Append("smooth_l1\"");
                        sb.Append(" --huber_c ").Append(TrainParams.Current.HuberC.ToString());
                    }
                    break;
            }

            sb.Append(" --huber_schedule \"").Append(TrainParams.Current.HuberScheduleType.ToString().ToLower()).Append('"');

            if (TrainParams.Current.SaveState)
            {
                sb.Append(" --save_state_on_train_end");
            }

            if (TrainParams.Current.MaskLoss)
            {
                sb.Append(" --masked_loss");
            }

            if (TrainParams.Current.DebiasedEstimation)
            {
                sb.Append(" --debiased_estimation");
            }

            if (TrainParams.Current.DisableMmapLoadSafetensors)
            {
                sb.Append(" --disable_mmap_load_safetensors");
            }

            if (TrainParams.Current.GradAccSteps > 1m)
            {
                sb.Append(" --gradient_accumulation_steps ").Append(TrainParams.Current.GradAccSteps.ToString());
            }

            if (TrainParams.Current.ScaleWeightNorms > 0)
            {
                sb.Append(" --scale_weight_norms ").Append(TrainParams.Current.ScaleWeightNorms.ToString());
            }

            if (TrainParams.Current.TEBatchSize > 0)
                sb.Append(" --text_encoder_batch_size ").Append(TrainParams.Current.TEBatchSize.ToString("0"));

            switch (TrainParams.Current.StableDiffusionType)
            {
                case ModelArchitecture.Flux1:
                    {
                        sb.Append(" --model_prediction_type \"").Append(TrainParams.Current.ModelPredictionType.ToString().ToLower()).Append('"');
                        sb.Append(" --discrete_flow_shift ").Append(TrainParams.Current.DiscreteFlowShift.ToString());
                        NetworkArgs.Add("train_blocks=" + TrainParams.Current.TrainBlockType.ToString().ToLower());
                        sb.Append(" --timestep_sampling \"").Append(TrainParams.Current.TimestepSamplingType.ToString().ToLower()).Append('"');
                        if (TrainParams.Current.TimestepSamplingType == TimestepSampling.Sigmoid)
                            sb.Append(" --sigmoid_scale ").Append(TrainParams.Current.Sigmoidscale.ToString());
                        if (TrainParams.Current.SplitMode)
                            sb.Append(" --split_mode");
                        if (TrainParams.Current.ApplyT5AttnMask)
                            sb.Append(" --apply_t5_attn_mask");
                        if (TrainParams.Current.GuidanceScale > 0m)
                            sb.Append(" --guidance_scale ").Append(TrainParams.Current.GuidanceScale.ToString());
                        if (TrainParams.Current.TrainT5XXL)
                            NetworkArgs.Add("train_t5xxl=True");
                        if (TrainParams.Current.BlocksToSwap > 0m)
                            sb.Append(" --blocks_to_swap ").Append(TrainParams.Current.BlocksToSwap.ToString("0"));
                    }
                    break;
                case ModelArchitecture.SD3:
                    {
                        if (TrainParams.Current.ApplyT5AttnMask)
                            sb.Append(" --apply_t5_attn_mask");
                        if (TrainParams.Current.ApplyClipAttnMask)
                            sb.Append(" --apply_lg_attn_mask");

                        if (TrainParams.Current.ClipLDropoutRate > 0m)
                            sb.Append(" --clip_l_dropout_rate ").Append(TrainParams.Current.ClipLDropoutRate.ToString());
                        if (TrainParams.Current.ClipGDropoutRate > 0m)
                            sb.Append(" --clip_g_dropout_rate ").Append(TrainParams.Current.ClipGDropoutRate.ToString());
                        if (TrainParams.Current.ClipLDropoutRate > 0m)
                            sb.Append(" --t5_dropout_rate ").Append(TrainParams.Current.T5DropoutRate.ToString());

                        if (TrainParams.Current.MaxTokensT5 != 256)
                            sb.Append(" --t5xxl_max_token_length ").Append(TrainParams.Current.MaxTokensT5.ToString("0"));

                        if(TrainParams.Current.DiscreteFlowShift != 1m)
                            sb.Append(" --training_shift ").Append(TrainParams.Current.DiscreteFlowShift.ToString());

                        if (TrainParams.Current.BlocksToSwap > 0m)
                            sb.Append(" --blocks_to_swap ").Append(TrainParams.Current.BlocksToSwap.ToString("0"));
                    }
                    break;
                default:
                    break;
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.ClipLPath))
            {
                sb.Append(" --clip_l \"").Append(TrainParams.Current.ClipLPath).Append('"');
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.ClipGPath))
            {
                sb.Append(" --clip_g \"").Append(TrainParams.Current.ClipGPath).Append('"');
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.T5XXLPath))
            {
                sb.Append(" --t5xxl \"").Append(TrainParams.Current.T5XXLPath).Append('"');
            }

            if (TrainParams.Current.CpuOffloadCheckpointing)
            {
                sb.Append(" --cpu_offload_checkpointing");
            }

            if (TrainParams.Current.VParameterization)
            {
                sb.Append(" --v_parameterization");
            }

            if (TrainParams.Current.ZeroTerminalSNR)
            {
                sb.Append(" --zero_terminal_snr");
            }

            if (TrainParams.Current.ResizeInterpolationType != ResizeInterpolation.None)
            {
                sb.Append(" --resize_interpolation \"").Append(TrainParams.Current.ResizeInterpolationType.ToString().ToLower()).Append('"');
            }

            string str = TrainParams.Current.AdditionalArgs.Trim();
            str = str.Replace("\r\n", string.Empty);
            if (!string.IsNullOrEmpty(str))
            {
                sb.Append(' ').Append(str);
            }

            sb.Append(GetNetworkArgsCommands());
            return sb.ToString();
        }

        private static string GetNetworkArgsCommands()
        {
            string str = TrainParams.Current.AdditionalNetworkArgs.Trim();
            str = str.Replace("\r\n", string.Empty);
            if (NetworkArgs.Count == 0 && string.IsNullOrEmpty(str))
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            sb.Append(" --network_args ");
            for (int i = 0; i < NetworkArgs.Count; i++)
            {
                sb.Append('"').Append(NetworkArgs[i]).Append('"');
                if (i < NetworkArgs.Count - 1)
                {
                    sb.Append(' ');
                }
            }

            if (!string.IsNullOrEmpty(str))
            {
                sb.Append(' ').Append(str);
            }

            return sb.ToString();
        }

        private static void GenerateBlockWeightCmmands()
        {
            int loopNum = TrainParams.Current.StableDiffusionType == ModelArchitecture.Legacy ? 12 : 9;
            if (TrainParams.Current.UseBlockWeight)
            {
                switch (TrainParams.Current.BlockWeightPresetTypeIn)
                {
                    case BlockWeightPreset.none:
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.Append("down_lr_weight=");
                            for (int i = 0; i < loopNum; i++)
                            {
                                sb.Append((0.05m * TrainParams.Current.BlockWeightIn[i]).ToString());
                                if (i < loopNum - 1)
                                    sb.Append(',');
                            }
                            NetworkArgs.Add(sb.ToString());
                        }
                        break;
                    default:
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.Append(" down_lr_weight=").Append(TrainParams.Current.BlockWeightPresetTypeIn.ToString());
                            if (TrainParams.Current.BlockWeightOffsetIn >= 0.25m)
                            {
                                sb.Append('+').Append(TrainParams.Current.BlockWeightOffsetIn.ToString());
                            }
                            NetworkArgs.Add(sb.ToString());
                        }
                        break;
                }
                if (TrainParams.Current.StableDiffusionType == ModelArchitecture.XL)
                {
                    NetworkArgs.Add("mid_lr_weight=" + (0.05m * TrainParams.Current.BlockWeightMid).ToString() + ',' + (0.05m * TrainParams.Current.BlockWeightMid01).ToString() + ',' + (0.05m * TrainParams.Current.BlockWeightMid02).ToString());
                }
                else
                {
                    NetworkArgs.Add("mid_lr_weight=" + (0.05m * TrainParams.Current.BlockWeightMid).ToString());
                }


                switch (TrainParams.Current.BlockWeightPresetTypeOut)
                {
                    case BlockWeightPreset.none:
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.Append("up_lr_weight=");
                            for (int i = 0; i < loopNum; i++)
                            {
                                sb.Append((0.05m * TrainParams.Current.BlockWeightOut[i]).ToString());
                                if (i < loopNum - 1)
                                    sb.Append(',');
                            }
                            NetworkArgs.Add(sb.ToString());
                        }
                        break;
                    default:
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.Append("up_lr_weight=").Append(TrainParams.Current.BlockWeightPresetTypeOut.ToString());
                            if (TrainParams.Current.BlockWeightOffsetOut >= 0.25m)
                            {
                                sb.Append('+').Append(TrainParams.Current.BlockWeightOffsetOut.ToString());
                            }
                            NetworkArgs.Add(sb.ToString());
                        }
                        break;
                }

                if (TrainParams.Current.BlockWeightZeroThreshold > 0)
                {
                    NetworkArgs.Add("block_lr_zero_threshold=" + (0.05m * TrainParams.Current.BlockWeightZeroThreshold).ToString());
                }
            }

            if (TrainParams.Current.UseBlockDim)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(TrainParams.Current.UseConv2dExtend ? "conv_block_dims=" : "block_dims=");
                if (TrainParams.Current.StableDiffusionType == ModelArchitecture.XL)
                {
                    sb.Append(TrainParams.Current.BlockDimBase).Append(',');
                }
                //DIM IN
                for (int i = 0; i < loopNum; i++)
                {
                    sb.Append(TrainParams.Current.BlockDimIn[i]);
                    sb.Append(',');
                }
                //DIM MID

                if (TrainParams.Current.StableDiffusionType == ModelArchitecture.XL)
                {
                    sb.Append(TrainParams.Current.BlockDimMid).Append(',').Append(TrainParams.Current.BlockDimMid01).Append(',').Append(TrainParams.Current.BlockDimMid02).Append(',');
                }
                else
                {
                    sb.Append(TrainParams.Current.BlockDimMid).Append(',');
                }

                //DIM OUT
                for (int i = 0; i < loopNum; i++)
                {
                    sb.Append(TrainParams.Current.BlockDimOut[i]);
                    if (i < loopNum - 1)
                        sb.Append(',');
                }

                if (TrainParams.Current.StableDiffusionType == ModelArchitecture.XL)
                {
                    sb.Append(',').Append(TrainParams.Current.BlockDimOutSDXL);
                }

                StringBuilder sbalpha = new StringBuilder();
                sbalpha.Append(TrainParams.Current.UseConv2dExtend ? "conv_block_alphas=" : "block_alphas=");
                if (TrainParams.Current.StableDiffusionType == ModelArchitecture.XL)
                {
                    sbalpha.Append(TrainParams.Current.BlockAlphaBase).Append(',');
                }
                //ALPHA IN
                for (int i = 0; i < loopNum; i++)
                {
                    sbalpha.Append(TrainParams.Current.BlockAlphaInM[i]);
                    sbalpha.Append(',');
                }
                //ALPHA MID
                if (TrainParams.Current.StableDiffusionType == ModelArchitecture.XL)
                {
                    sbalpha.Append(TrainParams.Current.BlockAlphaMidM).Append(',').Append(TrainParams.Current.BlockAlphaMid01).Append(',').Append(TrainParams.Current.BlockAlphaMid02).Append(',');
                }
                else
                {
                    sbalpha.Append(TrainParams.Current.BlockAlphaMidM).Append(',');
                }


                //ALPHA OUT
                for (int i = 0; i < loopNum; i++)
                {
                    sbalpha.Append(TrainParams.Current.BlockAlphaOutM[i]);
                    if (i < loopNum - 1)
                        sbalpha.Append(',');
                }

                if (TrainParams.Current.StableDiffusionType == ModelArchitecture.XL)
                {
                    sbalpha.Append(',').Append(TrainParams.Current.BlockAlphaOutSDXL);
                }

                NetworkArgs.Add(sb.ToString());
                NetworkArgs.Add(sbalpha.ToString());
            }
        }




        /// <summary>
        /// Dimリサイズコマンドの実行。
        /// </summary>
        /// <param name="inputPath">変換元LoRA</param>
        /// <param name="outputPath">変換後の保存先</param>
        /// <param name="dim">このDimする</param>
        /// <param name="cudaConversion">CUDAで変換</param>
        internal static void ResizeLora(string inputPath, string outputPath, decimal dim, decimal convDim, bool cudaConversion)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"/c cd ");
            if (!string.IsNullOrEmpty(Form1.ScriptPath))
            {
                sb.Append("/d ").Append(Form1.ScriptPath);
            }
            else
            {
                sb.Append(Constants.CurrentSdScriptsPath);
            }

            sb.Append(" && .\\venv\\Scripts\\activate && ");

            sb.Append("python .\\networks\\resize_lora.py").Append("  --model \"").Append(inputPath).Append('"')
                .Append("  --save_to \"").Append(outputPath).Append('"').Append("  --save_precision \"fp16\"")
                .Append("  --new_rank ").Append(dim.ToString());

            if (convDim > 0)
            {
                sb.Append("  --new_conv_rank ").Append(convDim.ToString());
            }

            if (cudaConversion)
            {
                sb.Append("  --device \"cuda\"");
            }

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = sb.ToString();
            var process = new Process();
            process.StartInfo = ps;
            process.Start();
        }

        /// <summary>
        /// Formにドロップされたアイテムのファイル名を取得する。ファイル以外/複数ドロップなら空文字を返す。
        /// </summary>
        /// <param name="e"></param>
        /// <param name="fileExtension">受け付けるファイルの拡張子(任意)。指定時に一致しないなら空文字を返す</param>
        /// <returns></returns>
        internal static string GetDroppedFileName(DragEventArgs e, string fileExtension = "")
        {
            if (e == null || e.Data == null)
            {
                return string.Empty;
            }
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length == 1)
            {
                string fileName = files[0];
                if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
                {
                    if (!string.IsNullOrEmpty(fileExtension) && Path.GetExtension(fileName) != fileExtension)
                    {
                        return string.Empty;
                    }

                    return fileName;
                }
                else
                {
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        internal static string GetDroppedWeightName(DragEventArgs e)
        {
            if (e == null || e.Data == null)
            {
                return string.Empty;
            }
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length == 1)
            {
                string fileName = files[0];
                if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
                {
                    if (WeightExtensionRegex.IsMatch(Path.GetExtension(fileName)))
                    {
                        return fileName;
                    }
                    return string.Empty;
                }
                else
                {
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// ファイルがドラッグされた時の汎用メソッド。ファイル以外/複数ドロップならカーソルをバツにする
        /// </summary>
        /// <param name="e"></param>
        /// <param name="fileExtension">受け付けるファイルの拡張子(任意)。指定時に一致しないならカーソルをバツにする</param>
        internal static void CommonFileDragEnterEvent(DragEventArgs e, string fileExtension = "")
        {
            if (e == null || e.Data == null)
            {
                return;
            }
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length == 1)
            {
                string fileName = files[0];
                if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
                {
                    if (!string.IsNullOrEmpty(fileExtension) && Path.GetExtension(fileName) != fileExtension)
                    {
                        e.Effect = DragDropEffects.None;
                        return;
                    }

                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }

            e.Effect = DragDropEffects.None;
        }

        internal static void WeightFileDragEnterEvent(DragEventArgs e)
        {
            if (e == null || e.Data == null)
            {
                return;
            }
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length == 1)
            {
                string fileName = files[0];
                if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
                {
                    if (WeightExtensionRegex.IsMatch(Path.GetExtension(fileName)))
                    {
                        e.Effect = DragDropEffects.Copy;
                        return;
                    }
                    e.Effect = DragDropEffects.None;
                    return;
                }
            }

            e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Formにドロップされたアイテムのディレクトリ名を取得する。ディレクトリ以外/複数ドロップなら空文字を返す。
        /// </summary>
        /// <param name="e"></param>
        /// <returns>ディレクトリ名(フルパス)</returns>
        internal static string GetDroppedDirectoryName(DragEventArgs e)
        {
            if (e == null || e.Data == null)
            {
                return string.Empty;
            }

            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length == 1)
            {
                string fileName = files[0];
                if (!string.IsNullOrEmpty(fileName) && Directory.Exists(fileName))
                {
                    Debug.WriteLine(fileName);
                    return fileName;
                }
                else
                {
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// ディレクトリがドラッグされた時の汎用メソッド。ディレクトリ以外/複数ドロップならカーソルをバツにする
        /// </summary>
        /// <param name="e"></param>
        internal static void CommonDirectoryDragEvent(DragEventArgs e)
        {
            if (e == null || e.Data == null)
            {
                return;
            }
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length == 1)
            {
                string fileName = files[0];
                if (!string.IsNullOrEmpty(fileName) && Directory.Exists(fileName))
                {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                    return;
                }
            }
            e.Effect = DragDropEffects.None;
        }

        internal static void CheckAndCreateWorkDir()
        {
            string document = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (!Directory.Exists(document + @"\lora-gui"))
            {
                Directory.CreateDirectory(document + @"\lora-gui");
            }
        }

        /// <summary>
        /// キャプションのシャッフル
        /// </summary>
        /// <param name="targetDir">シャッフルするキャプションが入ったディレクトリ</param>
        /// <param name="keepTokenCount">トークン保持数。コンマスペース区切り</param>
        /// <param name="showMsg">メッセージボックスを表示</param>
        /// <returns></returns>
        internal static bool ShuffleCaptions(string targetDir, int keepTokenCount, bool showMsg)
        {
            if (!Directory.Exists(targetDir))
            {
                if (showMsg)
                    MessageBox.Show("ディレクトリが見つかりません", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (IsSystemDirectory(targetDir))
            {
                if (showMsg)
                    MessageBox.Show("データ破損防止のため、OS関連のディレクトリは指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (keepTokenCount < 0)
            {
                if (showMsg)
                    MessageBox.Show("トークン保持数に0以下は指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            string[] files = Directory.GetFiles(targetDir);
            foreach (string file in files)
            {
                try
                {
                    string extension = Path.GetExtension(file);
                    if (string.IsNullOrEmpty(extension) || extension != ".txt")
                        continue;
                    string txt = File.ReadAllText(file);

                    List<string> tags = new List<string>(txt.Split(", "));
                    if (tags.Count <= keepTokenCount)
                    {
                        return false;
                    }


                    if (tags.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < keepTokenCount; i++)
                        {
                            sb.Append(tags[0]).Append(", ");
                            tags.RemoveAt(0);
                        }

                        tags = tags.OrderBy(a => Guid.NewGuid()).ToList();

                        for (int i = 0; i < tags.Count; i++)
                        {
                            sb.Append(tags[i]);
                            if (i < tags.Count - 1)
                            {
                                sb.Append(", ");
                            }
                        }
                        File.WriteAllText(file, sb.ToString());
                    }
                }
                catch
                {
                    Debug.WriteLine("Shuffle errored!");
                }

            }

            return true;
        }

        public static bool IsSystemDirectory(string path)
        {
            string pth = path.ToLower();

            if (pth.Contains(@"c:\windows") || pth.Contains("system"))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// PNGまたはJPEGのサイズを取得する。ファイルがないか破損している場合はSize.Emptyとなる。
        /// </summary>
        /// <param name="filePath">画像のパス。pngまたはjpg(jpeg)のみ</param>
        /// <returns></returns>
        public static Size GetImageSize(string filePath)
        {
            if (!File.Exists(filePath))
                return Size.Empty;

            string extension = Path.GetExtension(filePath).ToLower();

            if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
            {
                try
                {
                    int height = 0;
                    int width = 0;

                    using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (var image = Image.FromStream(fileStream, false, false))
                        {
                            height = image.Height;
                            width = image.Width;
                        }
                    }

                    return new Size(height, width);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return Size.Empty;
                }
            }

            return Size.Empty;

        }

        /// <summary>
        /// レジストリの初期化。アプリケーションの起動時に呼び出してください。
        /// </summary>
        public static void InitRegistry()
        {
            int? num = (int?)Registry.GetValue("HKEY_CURRENT_USER\\Software\\kohya_lora_gui", "UpdateCheckInterval", 7);
            if (num == null)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\kohya_lora_gui", "UpdateCheckInterval", 7);
            }
            string? text = (string?)Registry.GetValue("HKEY_CURRENT_USER\\Software\\kohya_lora_gui", "LastUpdateCheckDate", string.Empty);
            if (string.IsNullOrEmpty(text))
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\kohya_lora_gui", "LastUpdateCheckDate", "2023-01-01T12:00:00.0000000+09:00");
            }

            string? scriptPath = (string?)Registry.GetValue(@"HKEY_CURRENT_USER\Software\kohya_lora_gui", "ScriptPath", string.Empty);
            if (scriptPath == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\kohya_lora_gui", "ScriptPath", string.Empty);
            }
        }

        /// <summary>
        /// 最小限のPythonパッケージのインストールコマンド(torch,xformers,依存パッケージ)生成。
        /// </summary>
        /// <param name="UseLatestTorch">最新のTorchをインストールするか</param>
        /// <returns>pip installコマンドの文字列</returns>
        internal static string GenerateMinInstallCommands(bool UseLatestTorch)
        {
            string torch = UseLatestTorch ? Constants.LATEST_TORCH_VERSION : Constants.TORCH_VERSION;
            string vision = UseLatestTorch ? Constants.LATEST_TORCHVISION_VERSION : Constants.TORCHVISION_VERSION;
            string index = UseLatestTorch ? Constants.LATEST_INDEX_URL : Constants.INDEX_URL;
            string xformers = UseLatestTorch ? Constants.LATEST_XFORMERS_VERSION : Constants.XFORMERS_VERSION;
            StringBuilder sb = new StringBuilder();
            sb.Append("pip install torch==")
            .Append(torch).Append(" torchvision==").Append(vision)
            .Append(" xformers==").Append(xformers)
            .Append(" --index-url ").Append(index)
            .Append(" && pip install --upgrade -r requirements.txt");

            if (UseLatestTorch)
            {
                sb.Append(" && pip install bitsandbytes==0.45.5");
            }
            return sb.ToString();
        }

    }
}

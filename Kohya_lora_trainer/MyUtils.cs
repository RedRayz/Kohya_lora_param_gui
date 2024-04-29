using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Kohya_lora_trainer
{
    public static class MyUtils
    {
        private static Dictionary<string, string> DefaultDirs = new Dictionary<string, string>();
        private static List<string> NetworkArgs = new List<string>();

        public static void SaveDefaultDirSettings()
        {
            try
            {
                string json = JsonSerializer.Serialize(DefaultDirs, GetOption());
                if (!string.IsNullOrEmpty(json))
                {
                    string saveto = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\lora-gui-default-dir.json";
                    File.WriteAllText(saveto, json);
                }
            }catch(Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
        }

        public static void LoadDefaultDirSettings()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\lora-gui-default-dir.json";
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    DefaultDirs = JsonSerializer.Deserialize<Dictionary<string, string>>(json, GetOption());
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// デフォルトディレクトリの設定を取得する。キーがない場合はstring.Emptyとなる。
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetDefaultDir(string key)
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

        public static void SetDefaultDir(string key, string value)
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
        /// accelerateのコマンド生成。
        /// </summary>
        /// <returns>accelerateのコマンド</returns>
        public static string GenerateCommands()
        {
            StringBuilder sb = new StringBuilder();
            NetworkArgs.Clear();

            sb.Append("accelerate launch --num_cpu_threads_per_process ").Append(TrainParams.Current.CpuThreads);
            switch (TrainParams.Current.StableDiffusionType)
            {
                case SDType.Legacy:
                    sb.Append(" train_network.py");
                    break;
                case SDType.XL:
                    sb.Append(" sdxl_train_network.py");
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
                case ModuleType.LoRA:
                case ModuleType.LoRAFA:
                    {
                        sb.Append(" --network_module \"").Append(TrainParams.Current.ModuleType == ModuleType.LoRA ? "networks.lora" : "networks.lora_fa").Append('"');
                        
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
                case ModuleType.LyCORIS:
                    {
                        string algo = TrainParams.Current.AlgoType == AlgoType.diag_oft ? "diag-oft" : TrainParams.Current.AlgoType.ToString();

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
                case ModuleType.DyLoRA:
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

            sb.Append(GetNetworkArgsCommands());

            switch (TrainParams.Current.CrossAttenType)
            {
                case CrossAttenType.xformers:
                    sb.Append(" --xformers");
                    break;
                case CrossAttenType.mem_eff_attn:
                    sb.Append(" --mem_eff_attn");
                    break;
                case CrossAttenType.sdpa:
                    sb.Append(" --sdpa");
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
                case SchedulerType.polynomial:
                    sb.Append(" --lr_scheduler_power ").Append(TrainParams.Current.LRSchedulerCycle);
                    break;
                default:
                    sb.Append(" --lr_scheduler_num_cycles ").Append(TrainParams.Current.LRSchedulerCycle);
                    break;
            }


            if (TrainParams.Current.mixedPrecisionType != MixedPrecisionType.None)
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
                sb.Append(TrainParams.Current.IsEpoch ? " --save_every_n_epochs " : " --save_every_n_steps ").Append(TrainParams.Current.SaveEveryNEpochs);
            }

            sb.Append(" --optimizer_type \"").Append(TrainParams.Current.OptimizerType.ToString()).Append('"');

            //Optimizerの引数
            switch (TrainParams.Current.OptimizerType)
            {
                case OptimizerType.AdaFactor:
                    {
                        sb.Append(" --optimizer_args \"relative_step=").Append(TrainParams.Current.RelativeStep.ToString()).Append("\" \"scale_parameter=").Append(TrainParams.Current.ScaleParameter.ToString()).Append("\" \"warmup_init=").Append(TrainParams.Current.UseWarmupInit.ToString()).Append('"');
                    }
                    break;
                case OptimizerType.SGDNesterov:
                case OptimizerType.SGDNesterov8bit:
                    {
                        sb.Append(" --optimizer_args \"momentum=").Append(TrainParams.Current.Momentum.ToString()).Append('"');
                    }
                    break;
                case OptimizerType.DAdaptAdaGrad:
                    {
                        sb.Append(" --optimizer_args \"eps=").Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
                            .Append(TrainParams.Current.D0.ToString("g")).Append('"');

                        if (TrainParams.Current.GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(TrainParams.Current.GrowthRate.ToString("g")).Append('"');
                        }
                    }
                    break;
                case OptimizerType.DAdaptAdam:
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
                case OptimizerType.DAdaptAdan:
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
                case OptimizerType.DAdaptLion:
                    {
                        sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g"))
                            .Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append("\" \"d0=")
                            .Append(TrainParams.Current.D0.ToString("g")).Append('"');
                    }
                    break;
                case OptimizerType.DAdaptSGD:
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
                case OptimizerType.DAdaptation:
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
                case OptimizerType.DAdaptAdanIP:
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
                case OptimizerType.prodigy:
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
                case OptimizerType.AdamW:
                case OptimizerType.AdamW8bit:
                    {
                        if (TrainParams.Current.UseAdditionalOptArgs)
                        {
                            sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g")).Append("\" \"eps=")
    .Append(TrainParams.Current.Eps.ToString("g")).Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append('"');
                        }
                    }
                    break;
                case OptimizerType.Lion:
                case OptimizerType.Lion8bit:
                    {
                        if (TrainParams.Current.UseAdditionalOptArgs)
                        {
                            sb.Append(" --optimizer_args \"betas=").Append(TrainParams.Current.Betas0.ToString("g")).Append(',').Append(TrainParams.Current.Betas1.ToString("g")).
                                Append("\" \"weight_decay=").Append(TrainParams.Current.WeightDecay.ToString("g")).Append('"');
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
                sb.Append(" --output_name \"").Append(TrainParams.Current.OutputName).Append('"');
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.VAEPath))
            {
                sb.Append(" --vae \"").Append(TrainParams.Current.VAEPath).Append('"');
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


            if (TrainParams.Current.StableDiffusionType != SDType.XL)
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
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.DatasetConfigPath))
            {
                sb.Append(" --dataset_config \"").Append(TrainParams.Current.DatasetConfigPath).Append('"');
            }

            if (TrainParams.Current.MaxNormReg > 0)
            {
                sb.Append(" --scale_weight_norms ").Append(TrainParams.Current.MaxNormReg.ToString());
            }

            if (TrainParams.Current.NetworkDropout > 0)
            {
                sb.Append(" --network_dropout ").Append(TrainParams.Current.NetworkDropout.ToString());
            }

            if (TrainParams.Current.CaptionDropout > 0)
            {
                sb.Append(" --caption_dropout_rate ").Append(TrainParams.Current.CaptionDropout.ToString());
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

            if (TrainParams.Current.GradAccSteps > 1m)
            {
                sb.Append(" --gradient_accumulation_steps ").Append(TrainParams.Current.GradAccSteps.ToString());
            }


            return sb.ToString();
        }

        private static string GetNetworkArgsCommands()
        {
            if (NetworkArgs.Count == 0)
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            sb.Append(" --network_args ");
            for(int i = 0; i < NetworkArgs.Count; i++)
            {
                sb.Append('"').Append(NetworkArgs[i]).Append('"');
                if(i < NetworkArgs.Count - 1)
                {
                    sb.Append(' ');
                }
            }
            return sb.ToString();
        }

        private static void GenerateBlockWeightCmmands()
        {
            if (TrainParams.Current.UseBlockWeight)
            {
                switch (TrainParams.Current.BlockWeightPresetTypeIn)
                {
                    case BlockWeightPresetType.none:
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.Append("down_lr_weight=");
                            for (int i = 0; i < 12; i++)
                            {
                                sb.Append((0.05f * TrainParams.Current.BlockWeightIn[i]).ToString());
                                if (i < 11)
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

                NetworkArgs.Add("mid_lr_weight=" + (0.05f * TrainParams.Current.BlockWeightMid).ToString());

                switch (TrainParams.Current.BlockWeightPresetTypeOut)
                {
                    case BlockWeightPresetType.none:
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.Append("up_lr_weight=");
                            for (int i = 0; i < 12; i++)
                            {
                                sb.Append((0.05f * TrainParams.Current.BlockWeightOut[i]).ToString());
                                if (i < 11)
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
                    NetworkArgs.Add("block_lr_zero_threshold=" + (0.05f * TrainParams.Current.BlockWeightZeroThreshold).ToString());
                }
            }

            if (TrainParams.Current.UseBlockDim)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(TrainParams.Current.UseConv2dExtend ? "conv_block_dims=" : "block_dims=");
                //DIM IN
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockDimIn[i]);
                    sb.Append(',');
                }
                //DIM MID
                sb.Append(TrainParams.Current.BlockDimMid).Append(',');

                //DIM OUT
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockDimOut[i]);
                    if (i < 11)
                        sb.Append(',');
                }

                sb.Append(TrainParams.Current.UseConv2dExtend ? "conv_block_alphas=" : "block_alphas=");
                //ALPHA IN
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockAlphaInM[i]);
                    sb.Append(',');
                }
                //ALPHA MID
                sb.Append(TrainParams.Current.BlockAlphaMidM).Append(',');

                //ALPHA OUT
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockAlphaOutM[i]);
                    if (i < 11)
                        sb.Append(',');
                }
            }
        }




        /// <summary>
        /// Dimリサイズコマンドの実行。
        /// </summary>
        /// <param name="inputPath">変換元LoRA</param>
        /// <param name="outputPath">変換後の保存先</param>
        /// <param name="dim">このDimする</param>
        /// <param name="cudaConversion">CUDAで変換</param>
        public static void ResizeLora(string inputPath, string outputPath, decimal dim, decimal convDim, bool cudaConversion)
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

    }
}

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohya_lora_trainer
{
    public static class MyUtils
    {
        /// <summary>
        /// accelerateのコマンド生成。
        /// </summary>
        /// <returns>accelerateのコマンド</returns>
        public static string GenerateCommands()
        {
            StringBuilder sb = new StringBuilder();

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

            string lbw = GetBlockWeightCmd();

            switch (TrainParams.Current.ModuleType)
            {
                case ModuleType.LoRA:
                case ModuleType.LoRAFA:
                    {
                        sb.Append(" --network_module \"").Append(TrainParams.Current.ModuleType == ModuleType.LoRA ? "networks.lora": "networks.lora_fa").Append('"');
                        if (TrainParams.Current.UseConv2dExtend)
                        {
                            bool di = TrainParams.Current.ConvDim > 0;
                            bool al = TrainParams.Current.ConvAlpha > 0;
                            if (di || al)
                            {
                                sb.Append(" --network_args");
                                if (di)
                                    sb.Append(" \"conv_dim=").Append(TrainParams.Current.ConvDim.ToString()).Append('"');
                                if (al)
                                    sb.Append(" \"conv_alpha=").Append(TrainParams.Current.ConvAlpha.ToString()).Append('"');
                                if (TrainParams.Current.UseBlockWeight || TrainParams.Current.UseBlockDim)
                                    sb.Append(' ').Append(lbw);
                                sb.Append(GenerateDropoutCommands());
                            }
                        }
                        else if (TrainParams.Current.UseBlockWeight || TrainParams.Current.UseBlockDim)
                        {
                            sb.Append(" --network_args").Append(' ').Append(lbw);
                            sb.Append(GenerateDropoutCommands());
                        }else if(TrainParams.Current.RankDropout > 0 || TrainParams.Current.ModuleDropout > 0)
                        {
                            sb.Append(" --network_args").Append(' ').Append(GenerateDropoutCommands());
                        }

                    }
                    break;
                case ModuleType.LyCORIS:
                    {
                        string algo = TrainParams.Current.AlgoType == AlgoType.diag_oft ? "diag-oft" : TrainParams.Current.AlgoType.ToString();

                        sb.Append(" --network_module \"").Append("lycoris.kohya\"");
                        sb.Append(" --network_args \"algo=").Append(algo).Append('"');

                        if (TrainParams.Current.WeightDocomposition)
                            sb.Append(" \"dora_wd=True\"");

                        if (TrainParams.Current.TrainNorm)
                            sb.Append(" \"train_norm=True\"");

                        if (TrainParams.Current.RescaledOFT)
                            sb.Append(" \"rescaled=True\"");

                        if (TrainParams.Current.ConstrainedOFT)
                            sb.Append(" \"constrain=FLOAT\"");

                        if (TrainParams.Current.UseTucker)
                            sb.Append(" \"use_tucker=True\"");

                        if (TrainParams.Current.UseScalar)
                            sb.Append(" \"use_scalar=True\"");

                        if (TrainParams.Current.UseConv2dExtend)
                        {
                            bool di = TrainParams.Current.ConvDim > 0;
                            bool al = TrainParams.Current.ConvAlpha > 0;
                            if (di || al)
                            {
                                if (di)
                                    sb.Append(" \"conv_dim=").Append(TrainParams.Current.ConvDim.ToString()).Append('"');
                                if (al)
                                    sb.Append(" \"conv_alpha=").Append(TrainParams.Current.ConvAlpha.ToString()).Append('"');
                                if (TrainParams.Current.UseBlockWeight || TrainParams.Current.UseBlockDim)
                                    sb.Append(' ').Append(lbw);
                            }
                        }



                        sb.Append(GenerateDropoutCommands());
                    }
                    break;
                case ModuleType.DyLoRA:
                    {
                        sb.Append(" --network_module \"").Append("networks.dylora").Append('"');
                        //sd-scriptsの仕様上network_argsの引数名と値の区切りに=以外はエラーになるので注意
                        sb.Append(" --network_args");
                        sb.Append(" \"unit=").Append(TrainParams.Current.DyLoRAUnit.ToString()).Append('"');
                        sb.Append(GenerateDropoutCommands());
                        if (TrainParams.Current.UseConv2dExtend)
                        {
                            bool di = TrainParams.Current.ConvDim > 0;
                            bool al = TrainParams.Current.ConvAlpha > 0;
                            if (di || al)
                            {
                                if (di)
                                    sb.Append(" \"conv_dim=").Append(TrainParams.Current.ConvDim.ToString()).Append('"');
                                if (al)
                                    sb.Append(" \"conv_alpha=").Append(TrainParams.Current.ConvAlpha.ToString()).Append('"');
                                if (TrainParams.Current.UseBlockWeight || TrainParams.Current.UseBlockDim)
                                    sb.Append(' ').Append(lbw);
                            }
                        }
                        else if (TrainParams.Current.UseBlockWeight || TrainParams.Current.UseBlockDim)
                        {
                            sb.Append(' ').Append(lbw);
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

            if (TrainParams.Current.UseSDV2)
            {
                sb.Append(" --v2");
            }

            if (TrainParams.Current.UseFullFP16)
            {
                sb.Append(" --full_fp16");
            }

            if (TrainParams.Current.UseParameterization)
                sb.Append(" --v_parameterization");

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
            sb.Append(" --enable_bucket --save_model_as \"safetensors\" --lr_scheduler_num_cycles ").Append(TrainParams.Current.LRSchedulerCycle);

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

            
            if(TrainParams.Current.StableDiffusionType != SDType.XL)
            {
                sb.Append(" --clip_skip ").Append(TrainParams.Current.ClipSkip);
            }

                sb.Append(" --save_precision \"").Append(TrainParams.Current.SavePrecision.ToString()).Append('"')
                .Append(" --lr_scheduler \"").Append(TrainParams.Current.SchedulerType.ToString()).Append('"')
                .Append(" --min_bucket_reso ").Append(TrainParams.Current.MinBucketResolution)
                .Append(" --max_bucket_reso ").Append(TrainParams.Current.MaxBucketResolution)
                .Append(" --caption_extension \"").Append(TrainParams.Current.CaptionFileExtension).Append('"');

            if(TrainParams.Current.Seed >= 0)
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

            if (TrainParams.Current.ScaleVPredLoss)
            {
                sb.Append(" --scale_v_pred_loss_like_noise_pred");
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

            if(TrainParams.Current.UseFP8Base)
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

            return sb.ToString();
        }

        private static string GenerateDropoutCommands()
        {
            StringBuilder sb = new StringBuilder();

            if(TrainParams.Current.RankDropout > 0)
            {
                sb.Append(" \"rank_dropout=").Append(TrainParams.Current.RankDropout.ToString()).Append('"');
            }

            if (TrainParams.Current.ModuleDropout > 0)
            {
                sb.Append(" \"module_dropout=").Append(TrainParams.Current.ModuleDropout.ToString()).Append('"');
            }

            return sb.ToString();
        }

        /// <summary>
        /// 層別ウェイトの引数生成。
        /// </summary>
        /// <returns>層別ウェイトのコマンド</returns>
        public static string GetBlockWeightCmd()
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
                                    sb.Append(',');
                            }
                            sb.Append('"');
                        }
                        break;
                    default:
                        {
                            sb.Append(" \"down_lr_weight=").Append(TrainParams.Current.BlockWeightPresetTypeIn.ToString());
                            if (TrainParams.Current.BlockWeightOffsetIn >= 0.25m)
                            {
                                sb.Append("+").Append(TrainParams.Current.BlockWeightOffsetIn.ToString());
                            }

                            sb.Append('"');
                        }
                        break;
                }

                sb.Append(" \"mid_lr_weight=").Append((0.05f * TrainParams.Current.BlockWeightMid).ToString()).Append('"');

                switch (TrainParams.Current.BlockWeightPresetTypeOut)
                {
                    case BlockWeightPresetType.none:
                        {
                            sb.Append(" \"up_lr_weight=");
                            for (int i = 0; i < 12; i++)
                            {
                                sb.Append((0.05f * TrainParams.Current.BlockWeightOut[i]).ToString());
                                if (i < 11)
                                    sb.Append(',');
                            }
                            sb.Append('"');
                        }
                        break;
                    default:
                        {
                            sb.Append(" \"up_lr_weight=").Append(TrainParams.Current.BlockWeightPresetTypeOut.ToString());
                            if (TrainParams.Current.BlockWeightOffsetOut >= 0.25m)
                            {
                                sb.Append('+').Append(TrainParams.Current.BlockWeightOffsetOut.ToString());
                            }

                            sb.Append('"');
                        }
                        break;
                }

                if (TrainParams.Current.BlockWeightZeroThreshold > 0)
                {
                    sb.Append(" \"block_lr_zero_threshold=").Append((0.05f * TrainParams.Current.BlockWeightZeroThreshold).ToString()).Append('"');
                }
            }

            if (TrainParams.Current.UseBlockDim)
            {
                sb.Append(TrainParams.Current.UseConv2dExtend ? " \"conv_block_dims=" : " \"block_dims=");
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
                sb.Append('"');

                sb.Append(TrainParams.Current.UseConv2dExtend ? " \"conv_block_alphas=" : " \"block_alphas=");
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
                sb.Append('"');
            }

            return sb.ToString();
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

        /// <summary>
        /// パスからファイル名を除去する。実際には最後のスラッシュより後ろを消す
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        [Obsolete("This function will be removed. Use Path.GetDirectoryName instead")]
        public static string RemoveFileName(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            int last = str.LastIndexOf("\\");
            if (last == -1)
            {
                last = str.LastIndexOf("/");
            }

            if (last == -1)
            {
                return string.Empty;
            }

            return str.Remove(last + 1);
        }
    }
}

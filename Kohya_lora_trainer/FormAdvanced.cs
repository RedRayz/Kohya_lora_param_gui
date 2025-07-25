﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Shell;
using System.IO;

namespace Kohya_lora_trainer
{
    public partial class FormAdvanced : Form
    {
        public FormAdvanced()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsValid = true;
            float telr = -1;
            float unetlr = -1;
            float weightdecay = 0;
            float eps = 0;
            float eps1 = 0;
            float dzero = 0;
            float growthrate = 0;
            float betas0 = 0;
            float betas1 = 0;
            float betas2 = 0;
            float momentum = 0;
            float beta3 = 0;
            float dcoef = 0;

            if (!string.IsNullOrEmpty(tbxTextEncoLR.Text))
            {
                float lr = -1f;
                if (float.TryParse(tbxTextEncoLR.Text, out lr))
                {
                    if (!CheckUtil.IsValidNum(lr))
                    {
                        MessageBox.Show("TextEncoder LRに0以下、NaN、無限は指定できません", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        IsValid = false;
                    }
                    else
                    {
                        telr = lr;
                    }
                }
                else
                {
                    MessageBox.Show("TextEncoder LRの値が間違っています", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
            }
            else
            {
                telr = -1;
            }

            if (!string.IsNullOrEmpty(tbxUnetLR.Text))
            {
                float lr = -1f;
                if (float.TryParse(tbxUnetLR.Text, out lr))
                {
                    if (!CheckUtil.IsValidNum(lr))
                    {
                        MessageBox.Show("UNet LRに0以下、NaN、無限は指定できません", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        IsValid = false;
                    }
                    else
                    {
                        unetlr = lr;
                    }
                }
                else
                {
                    MessageBox.Show("UNet LRの値が間違っています", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
            }
            else
            {
                unetlr = -1;
            }

            if (nudMinBucketReso.Value % 64 != 0)
            {
                MessageBox.Show("最小バケット解像度の値が間違っています。\n64で割り切れる必要があります。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (nudMaxBucketReso.Value % 64 != 0)
            {
                MessageBox.Show("最大バケット解像度の値が間違っています。\n64で割り切れる必要があります。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            float val = 0;
            if (float.TryParse(tbxWeightDecay.Text, out val))
            {
                if (val < 0f || float.IsNaN(val) || float.IsInfinity(val))
                {
                    MessageBox.Show("Weight Decayの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
                weightdecay = val;
            }
            else
            {
                MessageBox.Show("Weight Decayの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (float.TryParse(tbxEps.Text, out val))
            {
                if (val < 0f || float.IsNaN(val) || float.IsInfinity(val))
                {
                    MessageBox.Show("epsの第一の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
                eps = val;
            }
            else
            {
                MessageBox.Show("epsの第一の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (float.TryParse(tbxEps1.Text, out val))
            {
                if (val < 0f || float.IsNaN(val) || float.IsInfinity(val))
                {
                    MessageBox.Show("epsの第二の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
                eps1 = val;
            }
            else
            {
                MessageBox.Show("epsの第二の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (float.TryParse(tbxD0.Text, out val))
            {
                if (val < 0f || float.IsNaN(val) || float.IsInfinity(val))
                {
                    MessageBox.Show("d0の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
                dzero = val;
            }
            else
            {
                MessageBox.Show("d0の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (float.TryParse(tbxGrowthRate.Text, out val))
            {
                if (val < 0f || float.IsNaN(val) || float.IsInfinity(val))
                {
                    MessageBox.Show("growth_rateの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
                growthrate = val;
            }
            else
            {
                MessageBox.Show("growth_rateの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (float.TryParse(tbxBetas0.Text, out val))
            {
                if (val < 0f || float.IsNaN(val) || float.IsInfinity(val))
                {
                    MessageBox.Show("betasの一番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
                betas0 = val;
            }
            else
            {
                MessageBox.Show("betasの一番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (float.TryParse(tbxBetas1.Text, out val))
            {
                if (val < 0f || float.IsNaN(val) || float.IsInfinity(val))
                {
                    MessageBox.Show("betasの二番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
                betas1 = val;
            }
            else
            {
                MessageBox.Show("betasの二番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (float.TryParse(tbxBetas2.Text, out val))
            {
                if (val < 0f || float.IsNaN(val) || float.IsInfinity(val))
                {
                    MessageBox.Show("betasの三番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
                betas2 = val;
            }
            else
            {
                MessageBox.Show("betasの三番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (float.TryParse(tbxMomentum.Text, out val))
            {
                if (val < 0f || float.IsNaN(val) || float.IsInfinity(val))
                {
                    MessageBox.Show("DAdaptationのmomentumの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
                momentum = val;
            }
            else
            {
                MessageBox.Show("DAdaptationのmomentumの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (float.TryParse(tbxProdigyBeta3.Text, out val))
            {
                if (val < 0f || float.IsNaN(val) || float.IsInfinity(val))
                {
                    MessageBox.Show("beta3の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
                beta3 = val;
            }
            else
            {
                MessageBox.Show("beta3の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (float.TryParse(tbxDCoef.Text, out val))
            {
                if (val < 0f || float.IsNaN(val) || float.IsInfinity(val))
                {
                    MessageBox.Show("d coefの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsValid = false;
                }
                dcoef = val;
            }
            else
            {
                MessageBox.Show("d coefの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (nudGuidanceScale.Value > 0m && nudGuidanceScale.Value < 1m)
            {
                MessageBox.Show("ガイダンススケールを使用する場合に1未満は使用できません。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }


            Regex regex = new Regex("[&:/\\\\\\?\\*<>\\|\"'`]");
            if (regex.IsMatch(tbxComment.Text))
            {
                MessageBox.Show("コメント欄に使用できない文字が含まれています。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (!IsValid)
                return;

            TrainParams.Current.Comment = tbxComment.Text;
            TrainParams.Current.TextEncoderLR = telr;
            TrainParams.Current.UnetLR = unetlr;
            TrainParams.Current.WeightDecay = weightdecay;
            TrainParams.Current.Eps = eps;
            TrainParams.Current.Eps1 = eps1;
            TrainParams.Current.D0 = dzero;
            TrainParams.Current.GrowthRate = growthrate;
            TrainParams.Current.Betas0 = betas0;
            TrainParams.Current.Betas1 = betas1;
            TrainParams.Current.Betas2 = betas2;
            TrainParams.Current.DAdaptMomentum = momentum;
            TrainParams.Current.ProdigyBeta3 = beta3;
            TrainParams.Current.DCoef = dcoef;

            TrainParams.Current.CpuThreads = tbrCpuThreads.Value;
            TrainParams.Current.SchedulerType = (Scheduler)Enum.ToObject(typeof(Scheduler), cbxScheduler.SelectedIndex);
            TrainParams.Current.SavePrecision = (SavePrecision)Enum.ToObject(typeof(SavePrecision), cbxPrecision.SelectedIndex);
            TrainParams.Current.advancedTrainType = (AdvancedTrain)Enum.ToObject(typeof(AdvancedTrain), cbxAdvancedTrain.SelectedIndex);
            TrainParams.Current.CrossAttenType = (CrossAtten)Enum.ToObject(typeof(CrossAtten), cbxCrossAttenType.SelectedIndex);
            TrainParams.Current.MinBucketResolution = (int)nudMinBucketReso.Value;
            TrainParams.Current.MaxBucketResolution = (int)nudMaxBucketReso.Value;
            TrainParams.Current.NoBucketUpscaling = cbxNoUpscale.Checked;
            TrainParams.Current.UseWarmupInit = cbxUseWarmupInit.Checked;
            TrainParams.Current.ClipSkip = (int)nudClipSkip.Value;
            TrainParams.Current.Seed = (long)nudSeed.Value;
            TrainParams.Current.CaptionFileExtension = tbxExtension.Text;
            TrainParams.Current.UseGradient = cbxUseGradient.Checked;
            TrainParams.Current.LoraModelPath = lblLoRAmodelPath.Text;
            TrainParams.Current.NoiseOffset = (float)nudNoiseOffset.Value;
            TrainParams.Current.Momentum = (float)nudMomentum.Value;
            TrainParams.Current.VAEPath = lblVAEPath.Text;
            TrainParams.Current.UseWeightedCaptions = cbxUseWeightedCaption.Checked;
            TrainParams.Current.AdaptiveNoiseScale = nudAdaptiveNoiseScale.Value;
            TrainParams.Current.MinSNRGamma = nudMinSNRGamma.Value;
            TrainParams.Current.MultiresNoiseIterations = nudMultiresNoiseIterations.Value;
            TrainParams.Current.MultiresNoiseDiscount = nudMultiresNoiseDiscount.Value;

            TrainParams.Current.ConvDim = (int)nudConvDim.Value;
            TrainParams.Current.ConvAlpha = nudConvAlpha.Value;
            TrainParams.Current.UseConv2dExtend = cbxUseConv2d.Checked;
            TrainParams.Current.DyLoRAUnit = nudDyLoRAUnit.Value;
            TrainParams.Current.DatasetConfigPath = lblConfigPath.Text;

            TrainParams.Current.AlgoType = (LycoAlgo)Enum.ToObject(typeof(LycoAlgo), cbxAlgoType.SelectedIndex);

            TrainParams.Current.UseColorAug = cbxUseColorAug.Checked;
            TrainParams.Current.UseFastLoading = cbxUseFastLoading.Checked;

            TrainParams.Current.UseFlipAug = cbxFlipAug.Checked;
            TrainParams.Current.CropRandomly = cbxCropRandomly.Checked;
            TrainParams.Current.DontSaveMetadata = cbxDontSaveMetadata.Checked;
            TrainParams.Current.CacheLatents = cbxCacheLatents.Checked;
            TrainParams.Current.CacheLatentsToDisk = cbxCacheLatentsToDisk.Checked;

            TrainParams.Current.mixedPrecisionType = (MixedPrecision)Enum.ToObject(typeof(MixedPrecision), cbxMixedPrecision.SelectedIndex);

            TrainParams.Current.LRSchedulerCycle = nudLRSchedulerCycle.Value;
            TrainParams.Current.DataLoaderThreads = (int)nudDataLoaderThreads.Value;
            TrainParams.Current.MaxTokens = (int)nudMaxTokens.Value;

            TrainParams.Current.CaptionDropout = nudCaptionDropout.Value;
            TrainParams.Current.CaptionTagDropout = nudCaptionTagDropout.Value;
            TrainParams.Current.NetworkDropout = nudNetworkDropout.Value;
            TrainParams.Current.RankDropout = nudRankDropout.Value;
            TrainParams.Current.ModuleDropout = nudModuleDropout.Value;

            TrainParams.Current.Decouple = cbxDecouple.Checked;
            TrainParams.Current.NoProx = cbxNoProx.Checked;

            TrainParams.Current.SafeguardWarmup = cbxUseSafeguard.Checked;
            TrainParams.Current.UseBiasCorrection = cbxUseBiasCorrection.Checked;
            TrainParams.Current.NoHalfVAE = cbxNoHalfVae.Checked;
            TrainParams.Current.CacheTextencoder = cbxCacheTextEncoder.Checked;
            TrainParams.Current.CacheTextencoderToDisk = cbxCacheTextencoderToDisk.Checked;
            TrainParams.Current.UseFullFP16 = cbxUseFullFp16.Checked;
            TrainParams.Current.TokensSeparator = tbxTokensSeparator.Text;
            TrainParams.Current.UseFP8Base = cbxUseFP8.Checked;

            TrainParams.Current.RelativeStep = cbxRelativeStep.Checked;
            TrainParams.Current.ScaleParameter = cbxScaleParameter.Checked;

            TrainParams.Current.WeightDocomposition = cbxWeightDecomposition.Checked;
            TrainParams.Current.TrainNorm = cbxTrainNorm.Checked;
            TrainParams.Current.RescaledOFT = cbxRescaledOFT.Checked;
            TrainParams.Current.ConstrainedOFT = cbxConstrainedOFT.Checked;
            TrainParams.Current.UseTucker = cbxUseTucker.Checked;
            TrainParams.Current.UseScalar = cbxUseScalar.Checked;

            TrainParams.Current.HighVRAM = cbxHighVRAM.Checked;

            TrainParams.Current.LossType = (LossType)Enum.ToObject(typeof(LossType), cbxLossType.SelectedIndex);
            TrainParams.Current.HuberScheduleType = (HuberSchedule)Enum.ToObject(typeof(HuberSchedule), cbxHuberSchedule.SelectedIndex);
            TrainParams.Current.HuberC = nudHuberC.Value;
            TrainParams.Current.SaveState = cbxSaveState.Checked;
            TrainParams.Current.MaskLoss = cbxMaskLoss.Checked;
            TrainParams.Current.GradAccSteps = nudGradAccSteps.Value;
            TrainParams.Current.LoRAPlusLRRatio = nudLoRAPlusLRRatio.Value;
            TrainParams.Current.LoRAPlusUnetLRRatio = nudLoRAPlusUnetLRRatio.Value;
            TrainParams.Current.LoRAPlusTELRRatio = nudLoRAPlusTELRRatio.Value;
            TrainParams.Current.UseAdditionalOptArgs = cbxUseAdditionalOptArgs.Checked;
            TrainParams.Current.IpNoiseGamma = nudIpNoiseGamma.Value;
            TrainParams.Current.RandomNoiseOffset = cbxRandomNoiseOffset.Checked;
            TrainParams.Current.RandomIpNoiseGamma = cbxRandomIpNoiseGamma.Checked;
            TrainParams.Current.AlphaMask = cbxAlphaMask.Checked;

            TrainParams.Current.Sigmoidscale = nudSigmoidScale.Value;
            TrainParams.Current.DiscreteFlowShift = nudDiscreteFlowShift.Value;
            TrainParams.Current.GuidanceScale = nudGuidanceScale.Value;
            TrainParams.Current.ModelPredictionType = (ModelPrediction)Enum.ToObject(typeof(ModelPrediction), cbxModelPredictionType.SelectedIndex);
            TrainParams.Current.TimestepSamplingType = (TimestepSampling)Enum.ToObject(typeof(TimestepSampling), cbxTimestepSampling.SelectedIndex);
            TrainParams.Current.TrainBlockType = (TrainBlock)Enum.ToObject(typeof(TrainBlock), cbxTrainBlock.SelectedIndex);
            TrainParams.Current.SplitMode = cbxSplitMode.Checked;

            TrainParams.Current.ClipLPath = lblClipLPath.Text;
            TrainParams.Current.ClipGPath = lblClipGPath.Text;
            TrainParams.Current.T5XXLPath = lblT5XXLPath.Text;
            TrainParams.Current.ApplyT5AttnMask = cbxApplyT5AttnMask.Checked;
            TrainParams.Current.ApplyClipAttnMask = cbxApplyClipAttnMask.Checked;
            TrainParams.Current.TrainT5XXL = cbxTrainT5XXL.Checked;
            TrainParams.Current.CpuOffloadCheckpointing = cbxCpuOffloadCheckpointing.Checked;
            TrainParams.Current.SchedulerTimescale = nudSchedulerTimescale.Value;
            TrainParams.Current.LRDecaySteps = nudLRDecaySteps.Value;
            TrainParams.Current.MinLRRatio = nudMinLRRatio.Value;
            TrainParams.Current.ClipLDropoutRate = nudClipLDropoutRate.Value;
            TrainParams.Current.ClipGDropoutRate = nudClipGDropoutRate.Value;
            TrainParams.Current.T5DropoutRate = nudT5DropoutRate.Value;
            TrainParams.Current.DisableMmapLoadSafetensors = cbxDisableMmapLoadSafetensors.Checked;
            TrainParams.Current.TEBatchSize = nudTEBatchSize.Value;
            TrainParams.Current.MaxTokensT5 = nudMaxTokensT5.Value;
            TrainParams.Current.VParameterization = cbxVParameterization.Checked;
            TrainParams.Current.ZeroTerminalSNR = cbxZeroTerminalSNR.Checked;
            TrainParams.Current.BlocksToSwap = nudBlocksToSwap.Value;
            TrainParams.Current.DebiasedEstimation = cbxDebiasedEstimation.Checked;
            TrainParams.Current.ScaleWeightNorms = nudScaleWeightNorms.Value;

            TrainParams.Current.ResizeInterpolationType = (ResizeInterpolation)Enum.ToObject(typeof(ResizeInterpolation), cbxResizeInterpolation.SelectedIndex);

            Close();
        }

        private void Form_Advanced_Load(object sender, EventArgs e)
        {
            tbrCpuThreads.Value = TrainParams.Current.CpuThreads;
            lblCpuThreadsCounter.Text = TrainParams.Current.CpuThreads.ToString();
            cbxScheduler.SelectedIndex = (int)TrainParams.Current.SchedulerType;
            tbxUnetLR.Text = TrainParams.Current.UnetLR < 0f ? string.Empty : TrainParams.Current.UnetLR.ToString();
            tbxTextEncoLR.Text = TrainParams.Current.TextEncoderLR < 0f ? string.Empty : TrainParams.Current.TextEncoderLR.ToString();
            nudMinBucketReso.Value = TrainParams.Current.MinBucketResolution;
            nudMaxBucketReso.Value = TrainParams.Current.MaxBucketResolution;
            cbxNoUpscale.Checked = TrainParams.Current.NoBucketUpscaling;
            cbxUseWarmupInit.Checked = TrainParams.Current.UseWarmupInit;
            cbxAdvancedTrain.SelectedIndex = (int)TrainParams.Current.advancedTrainType;
            cbxCrossAttenType.SelectedIndex = (int)TrainParams.Current.CrossAttenType;
            cbxUseWeightedCaption.Checked = TrainParams.Current.UseWeightedCaptions;
            nudAdaptiveNoiseScale.Value = TrainParams.Current.AdaptiveNoiseScale;

            nudClipSkip.Value = TrainParams.Current.ClipSkip;
            nudSeed.Value = TrainParams.Current.Seed;
            tbxExtension.Text = TrainParams.Current.CaptionFileExtension;
            cbxPrecision.SelectedIndex = (int)TrainParams.Current.SavePrecision;

            lblTBoardPath.Text = TrainParams.Current.TensorBoardLogPath;
            cbxUseGradient.Checked = TrainParams.Current.UseGradient;
            nudMinSNRGamma.Value = TrainParams.Current.MinSNRGamma;
            nudMultiresNoiseIterations.Value = TrainParams.Current.MultiresNoiseIterations;
            nudMultiresNoiseDiscount.Value = TrainParams.Current.MultiresNoiseDiscount;
            bool valid = nudMinBucketReso.Value % 64 == 0;
            lblMinBucketReso.ForeColor = valid ? Color.Black : Color.Red;

            valid = nudMaxBucketReso.Value % 64 == 0;
            lblMaxBucketReso.ForeColor = valid ? Color.Black : Color.Red;

            lblLoRAmodelPath.Text = TrainParams.Current.LoraModelPath;
            nudNoiseOffset.Value = (decimal)TrainParams.Current.NoiseOffset;
            nudMomentum.Value = (decimal)TrainParams.Current.Momentum;
            lblVAEPath.Text = TrainParams.Current.VAEPath;

            cbxAlgoType.SelectedIndex = (int)TrainParams.Current.AlgoType;

            nudConvDim.Value = TrainParams.Current.ConvDim;
            nudConvAlpha.Value = TrainParams.Current.ConvAlpha;
            cbxUseConv2d.Checked = TrainParams.Current.UseConv2dExtend;
            nudDyLoRAUnit.Value = TrainParams.Current.DyLoRAUnit;

            lblConfigPath.Text = TrainParams.Current.DatasetConfigPath;

            cbxUseColorAug.Checked = TrainParams.Current.UseColorAug;
            cbxUseFastLoading.Checked = TrainParams.Current.UseFastLoading;
            cbxFlipAug.Checked = TrainParams.Current.UseFlipAug;
            cbxCropRandomly.Checked = TrainParams.Current.CropRandomly;
            cbxDontSaveMetadata.Checked = TrainParams.Current.DontSaveMetadata;
            cbxCacheLatentsToDisk.Checked = TrainParams.Current.CacheLatentsToDisk;
            cbxCacheLatents.Checked = TrainParams.Current.CacheLatents;

            cbxMixedPrecision.SelectedIndex = (int)TrainParams.Current.mixedPrecisionType;

            nudLRSchedulerCycle.Value = TrainParams.Current.LRSchedulerCycle;
            nudDataLoaderThreads.Value = TrainParams.Current.DataLoaderThreads;
            nudMaxTokens.Value = TrainParams.Current.MaxTokens;


            tbxWeightDecay.Text = TrainParams.Current.WeightDecay.ToString("g");
            tbxEps.Text = TrainParams.Current.Eps.ToString("g");
            tbxEps1.Text = TrainParams.Current.Eps1.ToString("g");
            tbxD0.Text = TrainParams.Current.D0.ToString("g");
            tbxGrowthRate.Text = TrainParams.Current.GrowthRate.ToString("g");
            tbxBetas0.Text = TrainParams.Current.Betas0.ToString("g");
            tbxBetas1.Text = TrainParams.Current.Betas1.ToString("g");
            tbxBetas2.Text = TrainParams.Current.Betas2.ToString("g");
            tbxMomentum.Text = TrainParams.Current.DAdaptMomentum.ToString("g");

            nudCaptionDropout.Value = TrainParams.Current.CaptionDropout;
            nudCaptionTagDropout.Value = TrainParams.Current.CaptionTagDropout;
            nudRankDropout.Value = TrainParams.Current.RankDropout;
            nudModuleDropout.Value = TrainParams.Current.ModuleDropout;
            nudNetworkDropout.Value = TrainParams.Current.NetworkDropout;

            cbxDecouple.Checked = TrainParams.Current.Decouple;
            cbxNoProx.Checked = TrainParams.Current.NoProx;
            tbxComment.Text = TrainParams.Current.Comment;

            cbxUseSafeguard.Checked = TrainParams.Current.SafeguardWarmup;
            cbxUseBiasCorrection.Checked = TrainParams.Current.UseBiasCorrection;

            tbxProdigyBeta3.Text = TrainParams.Current.ProdigyBeta3.ToString("g");
            tbxDCoef.Text = TrainParams.Current.DCoef.ToString("g");

            cbxNoHalfVae.Checked = TrainParams.Current.NoHalfVAE;
            cbxCacheTextEncoder.Checked = TrainParams.Current.CacheTextencoder;
            cbxCacheTextencoderToDisk.Checked = TrainParams.Current.CacheTextencoderToDisk;
            cbxUseFullFp16.Checked = TrainParams.Current.UseFullFP16;
            tbxTokensSeparator.Text = TrainParams.Current.TokensSeparator;
            cbxUseFP8.Checked = TrainParams.Current.UseFP8Base;
            cbxRelativeStep.Checked = TrainParams.Current.RelativeStep;
            cbxScaleParameter.Checked = TrainParams.Current.ScaleParameter;

            cbxWeightDecomposition.Checked = TrainParams.Current.WeightDocomposition;
            cbxTrainNorm.Checked = TrainParams.Current.TrainNorm;
            cbxRescaledOFT.Checked = TrainParams.Current.RescaledOFT;
            cbxConstrainedOFT.Checked = TrainParams.Current.ConstrainedOFT;
            cbxUseTucker.Checked = TrainParams.Current.UseTucker;
            cbxUseScalar.Checked = TrainParams.Current.UseScalar;
            cbxHighVRAM.Checked = TrainParams.Current.HighVRAM;

            cbxLossType.SelectedIndex = (int)TrainParams.Current.LossType;
            cbxHuberSchedule.SelectedIndex = (int)TrainParams.Current.HuberScheduleType;
            nudHuberC.Value = TrainParams.Current.HuberC;

            cbxSaveState.Checked = TrainParams.Current.SaveState;
            cbxMaskLoss.Checked = TrainParams.Current.MaskLoss;

            nudGradAccSteps.Value = TrainParams.Current.GradAccSteps;

            nudLoRAPlusLRRatio.Value = TrainParams.Current.LoRAPlusLRRatio;
            nudLoRAPlusUnetLRRatio.Value = TrainParams.Current.LoRAPlusUnetLRRatio;
            nudLoRAPlusTELRRatio.Value = TrainParams.Current.LoRAPlusTELRRatio;

            cbxUseAdditionalOptArgs.Checked = TrainParams.Current.UseAdditionalOptArgs;

            nudIpNoiseGamma.Value = TrainParams.Current.IpNoiseGamma;

            cbxRandomNoiseOffset.Checked = TrainParams.Current.RandomNoiseOffset;
            cbxRandomIpNoiseGamma.Checked = TrainParams.Current.RandomIpNoiseGamma;
            cbxAlphaMask.Checked = TrainParams.Current.AlphaMask;

            nudSigmoidScale.Value = TrainParams.Current.Sigmoidscale;
            nudDiscreteFlowShift.Value = TrainParams.Current.DiscreteFlowShift;
            nudGuidanceScale.Value = TrainParams.Current.GuidanceScale;
            cbxTimestepSampling.SelectedIndex = (int)TrainParams.Current.TimestepSamplingType;
            cbxModelPredictionType.SelectedIndex = (int)TrainParams.Current.ModelPredictionType;
            cbxTrainBlock.SelectedIndex = (int)TrainParams.Current.TrainBlockType;
            cbxSplitMode.Checked = TrainParams.Current.SplitMode;

            lblClipLPath.Text = TrainParams.Current.ClipLPath;
            lblClipGPath.Text = TrainParams.Current.ClipGPath;
            lblT5XXLPath.Text = TrainParams.Current.T5XXLPath;
            cbxApplyT5AttnMask.Checked = TrainParams.Current.ApplyT5AttnMask;
            cbxApplyClipAttnMask.Checked = TrainParams.Current.ApplyClipAttnMask;
            cbxDisableMmapLoadSafetensors.Checked = TrainParams.Current.DisableMmapLoadSafetensors;

            nudClipLDropoutRate.Value = TrainParams.Current.ClipLDropoutRate;
            nudClipGDropoutRate.Value = TrainParams.Current.ClipGDropoutRate;
            nudT5DropoutRate.Value = TrainParams.Current.T5DropoutRate;
            nudDiscreteFlowShift.Value = TrainParams.Current.DiscreteFlowShift;
            nudTEBatchSize.Value = TrainParams.Current.TEBatchSize;

            cbxTrainT5XXL.Checked = TrainParams.Current.TrainT5XXL;
            cbxCpuOffloadCheckpointing.Checked = TrainParams.Current.CpuOffloadCheckpointing;

            nudSchedulerTimescale.Value = TrainParams.Current.SchedulerTimescale;
            nudLRDecaySteps.Value = TrainParams.Current.LRDecaySteps;
            nudMinLRRatio.Value = TrainParams.Current.MinLRRatio;
            nudMaxTokensT5.Value = TrainParams.Current.MaxTokensT5;
            cbxVParameterization.Checked = TrainParams.Current.VParameterization;
            cbxZeroTerminalSNR.Checked = TrainParams.Current.ZeroTerminalSNR;
            nudBlocksToSwap.Value = TrainParams.Current.BlocksToSwap;
            cbxDebiasedEstimation.Checked = TrainParams.Current.DebiasedEstimation;
            nudScaleWeightNorms.Value = TrainParams.Current.ScaleWeightNorms;

            cbxResizeInterpolation.SelectedIndex = (int)TrainParams.Current.ResizeInterpolationType;
        }

        private void tbrCpuThreads_Scroll(object sender, EventArgs e)
        {
            lblCpuThreadsCounter.Text = tbrCpuThreads.Value.ToString();
        }

        private void btnDiscardAndClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select Image Folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (Directory.Exists(TrainParams.Current.TensorBoardLogPath))
            {
                cof.InitialDirectory = TrainParams.Current.TensorBoardLogPath;
            }
            else if (Directory.Exists(MyUtils.GetDefaultDir("TensorboardDir")))
            {
                cof.InitialDirectory = MyUtils.GetDefaultDir("TensorboardDir");
            }

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TrainParams.Current.TensorBoardLogPath = cof.FileName;
                lblTBoardPath.Text = cof.FileName;
            }
        }

        private void btnClearTBoardPath_Click(object sender, EventArgs e)
        {
            lblTBoardPath.Text = string.Empty;
            TrainParams.Current.TensorBoardLogPath = string.Empty;
        }

        private void nudMinBucketReso_ValueChanged(object sender, EventArgs e)
        {
            bool valid = nudMinBucketReso.Value % 64 == 0;
            lblMinBucketReso.ForeColor = valid ? Color.Black : Color.Red;
        }

        private void nudMaxBucketReso_ValueChanged(object sender, EventArgs e)
        {
            bool valid = nudMaxBucketReso.Value % 64 == 0;
            lblMaxBucketReso.ForeColor = valid ? Color.Black : Color.Red;
        }

        private void btnSelectLoRAmodel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Constants.WEIGHT_EXTENSION_FILTER;
            ofd.Title = "Select a lora";
            ofd.RestoreDirectory = true;

            if (File.Exists(TrainParams.Current.LoraModelPath))
            {
                ofd.InitialDirectory = Path.GetDirectoryName(TrainParams.Current.LoraModelPath);
            }
            else if (Directory.Exists(MyUtils.GetDefaultDir("LoRADir")))
            {
                ofd.InitialDirectory = MyUtils.GetDefaultDir("LoRAtDir");
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblLoRAmodelPath.Text = ofd.FileName;
            }
        }

        private void btnClearLoRAmodel_Click(object sender, EventArgs e)
        {
            lblLoRAmodelPath.Text = string.Empty;
        }

        private void btnSelectVAE_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Constants.WEIGHT_EXTENSION_FILTER;
            ofd.Title = "Select a VAE";
            ofd.RestoreDirectory = true;

            if (File.Exists(TrainParams.Current.VAEPath))
            {
                ofd.InitialDirectory = Path.GetDirectoryName(TrainParams.Current.VAEPath);
            }
            else if (Directory.Exists(MyUtils.GetDefaultDir("VAEDir")))
            {
                ofd.InitialDirectory = MyUtils.GetDefaultDir("VAEDir");
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblVAEPath.Text = ofd.FileName;
            }
        }

        private void btnClearVAE_Click(object sender, EventArgs e)
        {
            lblVAEPath.Text = string.Empty;
        }

        private void tbxUnetLR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectConfigPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TOML(*.toml)|*.toml";
            ofd.Title = "Select a dataset config";
            ofd.RestoreDirectory = true;

            if (File.Exists(TrainParams.Current.DatasetConfigPath))
            {
                ofd.InitialDirectory = Path.GetDirectoryName(TrainParams.Current.DatasetConfigPath);
            }
            else if (Directory.Exists(MyUtils.GetDefaultDir("ConfigDir")))
            {
                ofd.InitialDirectory = MyUtils.GetDefaultDir("ConfigDir");
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblConfigPath.Text = ofd.FileName;
            }
        }

        private void btnClearConfigPath_Click(object sender, EventArgs e)
        {
            lblConfigPath.Text = string.Empty;
        }

        private void btnShowTipsAboutOpts_Click(object sender, EventArgs e)
        {
            Form tips = new FormOptTips();
            tips.ShowDialog();
            tips.Dispose();
        }

        private void btnClipLPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Constants.WEIGHT_EXTENSION_FILTER;
            ofd.Title = "Select a CLIP L";
            ofd.RestoreDirectory = true;

            if (File.Exists(TrainParams.Current.ClipLPath))
            {
                ofd.InitialDirectory = Path.GetDirectoryName(TrainParams.Current.ClipLPath);
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblClipLPath.Text = ofd.FileName;
            }
        }

        private void btnClearClipLPath_Click(object sender, EventArgs e)
        {
            lblClipLPath.Text = string.Empty;
        }

        private void btnT5XXLPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Constants.WEIGHT_EXTENSION_FILTER;
            ofd.Title = "Select a T5XXL";
            ofd.RestoreDirectory = true;

            if (File.Exists(TrainParams.Current.T5XXLPath))
            {
                ofd.InitialDirectory = Path.GetDirectoryName(TrainParams.Current.T5XXLPath);
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblT5XXLPath.Text = ofd.FileName;
            }
        }

        private void btnClearT5XXLPath_Click(object sender, EventArgs e)
        {
            lblT5XXLPath.Text = string.Empty;
        }

        private void btnClipGPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Constants.WEIGHT_EXTENSION_FILTER;
            ofd.Title = "Select a CLIP G";
            ofd.RestoreDirectory = true;

            if (File.Exists(TrainParams.Current.ClipGPath))
            {
                ofd.InitialDirectory = Path.GetDirectoryName(TrainParams.Current.ClipGPath);
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblClipGPath.Text = ofd.FileName;
            }
        }

        private void btnClearClipGPath_Click(object sender, EventArgs e)
        {
            lblClipGPath.Text = string.Empty;
        }
    }
}

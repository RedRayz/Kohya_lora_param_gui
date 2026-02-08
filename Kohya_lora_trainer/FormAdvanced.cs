using System;
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
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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




            Regex regex = new Regex("[&:/\\\\\\?\\*<>\\|\"'`]");
            if (regex.IsMatch(tbxComment.Text))
            {
                MessageBox.Show("コメント欄に使用できない文字が含まれています。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsValid = false;
            }

            if (!IsValid)
                return;

            para.Comment = tbxComment.Text;
            para.TextEncoderLR = telr;
            para.UnetLR = unetlr;
            para.WeightDecay = weightdecay;
            para.Eps = eps;
            para.Eps1 = eps1;
            para.D0 = dzero;
            para.GrowthRate = growthrate;
            para.Betas0 = betas0;
            para.Betas1 = betas1;
            para.Betas2 = betas2;
            para.DAdaptMomentum = momentum;
            para.ProdigyBeta3 = beta3;
            para.DCoef = dcoef;

            para.CpuThreads = tbrCpuThreads.Value;
            para.SchedulerType = (Scheduler)Enum.ToObject(typeof(Scheduler), cbxScheduler.SelectedIndex);
            para.SavePrecision = (SavePrecision)Enum.ToObject(typeof(SavePrecision), cbxPrecision.SelectedIndex);
            para.advancedTrainType = (AdvancedTrain)Enum.ToObject(typeof(AdvancedTrain), cbxAdvancedTrain.SelectedIndex);
            para.CrossAttenType = (CrossAtten)Enum.ToObject(typeof(CrossAtten), cbxCrossAttenType.SelectedIndex);
            para.MinBucketResolution = (int)nudMinBucketReso.Value;
            para.MaxBucketResolution = (int)nudMaxBucketReso.Value;
            para.NoBucketUpscaling = cbxNoUpscale.Checked;
            para.ClipSkip = (int)nudClipSkip.Value;
            para.Seed = (long)nudSeed.Value;
            para.CaptionFileExtension = tbxExtension.Text;
            para.UseGradient = cbxUseGradient.Checked;
            para.LoraModelPath = lblLoRAmodelPath.Text;
            para.NoiseOffset = (float)nudNoiseOffset.Value;
            para.VAEPath = lblVAEPath.Text;
            para.UseWeightedCaptions = cbxUseWeightedCaption.Checked;
            para.AdaptiveNoiseScale = nudAdaptiveNoiseScale.Value;
            para.MinSNRGamma = nudMinSNRGamma.Value;
            para.MultiresNoiseIterations = nudMultiresNoiseIterations.Value;
            para.MultiresNoiseDiscount = nudMultiresNoiseDiscount.Value;

            para.ConvDim = (int)nudConvDim.Value;
            para.ConvAlpha = nudConvAlpha.Value;
            para.UseConv2dExtend = cbxUseConv2d.Checked;
            para.DyLoRAUnit = nudDyLoRAUnit.Value;
            para.DatasetConfigPath = lblConfigPath.Text;

            para.AlgoType = (LycoAlgo)Enum.ToObject(typeof(LycoAlgo), cbxAlgoType.SelectedIndex);

            para.UseColorAug = cbxUseColorAug.Checked;
            para.UseFastLoading = cbxUseFastLoading.Checked;

            para.UseFlipAug = cbxFlipAug.Checked;
            para.CropRandomly = cbxCropRandomly.Checked;
            para.DontSaveMetadata = cbxDontSaveMetadata.Checked;
            para.CacheLatents = cbxCacheLatents.Checked;
            para.CacheLatentsToDisk = cbxCacheLatentsToDisk.Checked;

            para.mixedPrecisionType = (MixedPrecision)Enum.ToObject(typeof(MixedPrecision), cbxMixedPrecision.SelectedIndex);

            para.LRSchedulerCycle = nudLRSchedulerCycle.Value;
            para.DataLoaderThreads = (int)nudDataLoaderThreads.Value;
            para.MaxTokens = (int)nudMaxTokens.Value;

            para.CaptionDropout = nudCaptionDropout.Value;
            para.CaptionTagDropout = nudCaptionTagDropout.Value;
            para.NetworkDropout = nudNetworkDropout.Value;
            para.RankDropout = nudRankDropout.Value;
            para.ModuleDropout = nudModuleDropout.Value;

            para.Decouple = cbxDecouple.Checked;

            para.SafeguardWarmup = cbxUseSafeguard.Checked;
            para.UseBiasCorrection = cbxUseBiasCorrection.Checked;
            para.NoHalfVAE = cbxNoHalfVae.Checked;
            para.CacheTextencoder = cbxCacheTextEncoder.Checked;
            para.CacheTextencoderToDisk = cbxCacheTextencoderToDisk.Checked;
            para.UseFullBf16 = cbxUseFullBf16.Checked;
            para.TokensSeparator = tbxTokensSeparator.Text;
            para.UseFP8Base = cbxUseFP8.Checked;

            para.WeightDocomposition = cbxWeightDecomposition.Checked;
            para.TrainNorm = cbxTrainNorm.Checked;
            para.RescaledOFT = cbxRescaledOFT.Checked;
            para.ConstrainedOFT = cbxConstrainedOFT.Checked;
            para.UseTucker = cbxUseTucker.Checked;
            para.UseScalar = cbxUseScalar.Checked;

            para.HighVRAM = cbxHighVRAM.Checked;

            para.LossType = (LossType)Enum.ToObject(typeof(LossType), cbxLossType.SelectedIndex);
            para.HuberScheduleType = (HuberSchedule)Enum.ToObject(typeof(HuberSchedule), cbxHuberSchedule.SelectedIndex);
            para.HuberC = nudHuberC.Value;
            para.SaveState = cbxSaveState.Checked;
            para.MaskLoss = cbxMaskLoss.Checked;
            para.GradAccSteps = nudGradAccSteps.Value;
            para.LoRAPlusLRRatio = nudLoRAPlusLRRatio.Value;
            para.LoRAPlusUnetLRRatio = nudLoRAPlusUnetLRRatio.Value;
            para.LoRAPlusTELRRatio = nudLoRAPlusTELRRatio.Value;
            para.UseAdditionalOptArgs = cbxUseAdditionalOptArgs.Checked;
            para.IpNoiseGamma = nudIpNoiseGamma.Value;
            para.RandomNoiseOffset = cbxRandomNoiseOffset.Checked;
            para.RandomIpNoiseGamma = cbxRandomIpNoiseGamma.Checked;
            para.AlphaMask = cbxAlphaMask.Checked;

            para.SchedulerTimescale = nudSchedulerTimescale.Value;
            para.LRDecaySteps = nudLRDecaySteps.Value;
            para.MinLRRatio = nudMinLRRatio.Value;
            para.DisableMmapLoadSafetensors = cbxDisableMmapLoadSafetensors.Checked;
            para.TEBatchSize = nudTEBatchSize.Value;
            para.VParameterization = cbxVParameterization.Checked;
            para.ZeroTerminalSNR = cbxZeroTerminalSNR.Checked;
            para.DebiasedEstimation = cbxDebiasedEstimation.Checked;
            para.ScaleWeightNorms = nudScaleWeightNorms.Value;

            para.ResizeInterpolationType = (ResizeInterpolation)Enum.ToObject(typeof(ResizeInterpolation), cbxResizeInterpolation.SelectedIndex);

            para.TokenWarmupMin = nudTokenWarmupMin.Value;
            para.TokenWarmupStep = nudTokenWarmupStep.Value;

            para.BlocksToSwap = nudBlocksToSwap.Value;
            para.CpuOffloadCheckpointing = cbxCpuOffloadCheckpointing.Checked;
            para.Sigmoidscale = nudSigmoidScale.Value;
            para.DiscreteFlowShift = nudDiscreteFlowShift.Value;
            para.DitPath = lblDitPath.Text;
            para.Qwen3Path = lblQwen3Path.Text;

            Close();
        }

        private void Form_Advanced_Load(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbrCpuThreads.Value = para.CpuThreads;
            lblCpuThreadsCounter.Text = para.CpuThreads.ToString();
            cbxScheduler.SelectedIndex = (int)para.SchedulerType;
            tbxUnetLR.Text = para.UnetLR < 0f ? string.Empty : para.UnetLR.ToString();
            tbxTextEncoLR.Text = para.TextEncoderLR < 0f ? string.Empty : para.TextEncoderLR.ToString();
            nudMinBucketReso.Value = para.MinBucketResolution;
            nudMaxBucketReso.Value = para.MaxBucketResolution;
            cbxNoUpscale.Checked = para.NoBucketUpscaling;
            cbxAdvancedTrain.SelectedIndex = (int)para.advancedTrainType;
            cbxCrossAttenType.SelectedIndex = (int)para.CrossAttenType;
            cbxUseWeightedCaption.Checked = para.UseWeightedCaptions;
            nudAdaptiveNoiseScale.Value = para.AdaptiveNoiseScale;

            nudClipSkip.Value = para.ClipSkip;
            nudSeed.Value = para.Seed;
            tbxExtension.Text = para.CaptionFileExtension;
            cbxPrecision.SelectedIndex = (int)para.SavePrecision;

            lblTBoardPath.Text = para.TensorBoardLogPath;
            cbxUseGradient.Checked = para.UseGradient;
            nudMinSNRGamma.Value = para.MinSNRGamma;
            nudMultiresNoiseIterations.Value = para.MultiresNoiseIterations;
            nudMultiresNoiseDiscount.Value = para.MultiresNoiseDiscount;
            bool valid = nudMinBucketReso.Value % 64 == 0;
            lblMinBucketReso.ForeColor = valid ? Color.Black : Color.Red;

            valid = nudMaxBucketReso.Value % 64 == 0;
            lblMaxBucketReso.ForeColor = valid ? Color.Black : Color.Red;

            lblLoRAmodelPath.Text = para.LoraModelPath;
            nudNoiseOffset.Value = (decimal)para.NoiseOffset;
            lblVAEPath.Text = para.VAEPath;

            cbxAlgoType.SelectedIndex = (int)para.AlgoType;

            nudConvDim.Value = para.ConvDim;
            nudConvAlpha.Value = para.ConvAlpha;
            cbxUseConv2d.Checked = para.UseConv2dExtend;
            nudDyLoRAUnit.Value = para.DyLoRAUnit;

            lblConfigPath.Text = para.DatasetConfigPath;

            cbxUseColorAug.Checked = para.UseColorAug;
            cbxUseFastLoading.Checked = para.UseFastLoading;
            cbxFlipAug.Checked = para.UseFlipAug;
            cbxCropRandomly.Checked = para.CropRandomly;
            cbxDontSaveMetadata.Checked = para.DontSaveMetadata;
            cbxCacheLatentsToDisk.Checked = para.CacheLatentsToDisk;
            cbxCacheLatents.Checked = para.CacheLatents;

            cbxMixedPrecision.SelectedIndex = (int)para.mixedPrecisionType;

            nudLRSchedulerCycle.Value = para.LRSchedulerCycle;
            nudDataLoaderThreads.Value = para.DataLoaderThreads;
            nudMaxTokens.Value = para.MaxTokens;


            tbxWeightDecay.Text = para.WeightDecay.ToString("g");
            tbxEps.Text = para.Eps.ToString("g");
            tbxEps1.Text = para.Eps1.ToString("g");
            tbxD0.Text = para.D0.ToString("g");
            tbxGrowthRate.Text = para.GrowthRate.ToString("g");
            tbxBetas0.Text = para.Betas0.ToString("g");
            tbxBetas1.Text = para.Betas1.ToString("g");
            tbxBetas2.Text = para.Betas2.ToString("g");
            tbxMomentum.Text = para.DAdaptMomentum.ToString("g");

            nudCaptionDropout.Value = para.CaptionDropout;
            nudCaptionTagDropout.Value = para.CaptionTagDropout;
            nudRankDropout.Value = para.RankDropout;
            nudModuleDropout.Value = para.ModuleDropout;
            nudNetworkDropout.Value = para.NetworkDropout;

            cbxDecouple.Checked = para.Decouple;
            tbxComment.Text = para.Comment;

            cbxUseSafeguard.Checked = para.SafeguardWarmup;
            cbxUseBiasCorrection.Checked = para.UseBiasCorrection;

            tbxProdigyBeta3.Text = para.ProdigyBeta3.ToString("g");
            tbxDCoef.Text = para.DCoef.ToString("g");

            cbxNoHalfVae.Checked = para.NoHalfVAE;
            cbxCacheTextEncoder.Checked = para.CacheTextencoder;
            cbxCacheTextencoderToDisk.Checked = para.CacheTextencoderToDisk;
            cbxUseFullBf16.Checked = para.UseFullBf16;
            tbxTokensSeparator.Text = para.TokensSeparator;
            cbxUseFP8.Checked = para.UseFP8Base;

            cbxWeightDecomposition.Checked = para.WeightDocomposition;
            cbxTrainNorm.Checked = para.TrainNorm;
            cbxRescaledOFT.Checked = para.RescaledOFT;
            cbxConstrainedOFT.Checked = para.ConstrainedOFT;
            cbxUseTucker.Checked = para.UseTucker;
            cbxUseScalar.Checked = para.UseScalar;
            cbxHighVRAM.Checked = para.HighVRAM;

            cbxLossType.SelectedIndex = (int)para.LossType;
            cbxHuberSchedule.SelectedIndex = (int)para.HuberScheduleType;
            nudHuberC.Value = para.HuberC;

            cbxSaveState.Checked = para.SaveState;
            cbxMaskLoss.Checked = para.MaskLoss;

            nudGradAccSteps.Value = para.GradAccSteps;

            nudLoRAPlusLRRatio.Value = para.LoRAPlusLRRatio;
            nudLoRAPlusUnetLRRatio.Value = para.LoRAPlusUnetLRRatio;
            nudLoRAPlusTELRRatio.Value = para.LoRAPlusTELRRatio;

            cbxUseAdditionalOptArgs.Checked = para.UseAdditionalOptArgs;

            nudIpNoiseGamma.Value = para.IpNoiseGamma;

            cbxRandomNoiseOffset.Checked = para.RandomNoiseOffset;
            cbxRandomIpNoiseGamma.Checked = para.RandomIpNoiseGamma;
            cbxAlphaMask.Checked = para.AlphaMask;

            cbxDisableMmapLoadSafetensors.Checked = para.DisableMmapLoadSafetensors;

            nudTEBatchSize.Value = para.TEBatchSize;


            nudSchedulerTimescale.Value = para.SchedulerTimescale;
            nudLRDecaySteps.Value = para.LRDecaySteps;
            nudMinLRRatio.Value = para.MinLRRatio;
            cbxVParameterization.Checked = para.VParameterization;
            cbxZeroTerminalSNR.Checked = para.ZeroTerminalSNR;

            cbxDebiasedEstimation.Checked = para.DebiasedEstimation;
            nudScaleWeightNorms.Value = para.ScaleWeightNorms;

            cbxResizeInterpolation.SelectedIndex = (int)para.ResizeInterpolationType;

            nudTokenWarmupMin.Value = para.TokenWarmupMin;
            nudTokenWarmupStep.Value = para.TokenWarmupStep;

            nudBlocksToSwap.Value = para.BlocksToSwap;
            cbxCpuOffloadCheckpointing.Checked = para.CpuOffloadCheckpointing;
            nudSigmoidScale.Value = para.Sigmoidscale;
            nudDiscreteFlowShift.Value = para.DiscreteFlowShift;

            lblDitPath.Text = para.DitPath;
            lblQwen3Path.Text = para.Qwen3Path;
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
            if (TrainParams.Current == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (TrainParams.Current == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (TrainParams.Current == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (TrainParams.Current == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (TrainParams.Current == null) 
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

        private void btnDitPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Constants.WEIGHT_EXTENSION_FILTER;
            ofd.Title = "Select a Diffuion Model weight";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblDitPath.Text = ofd.FileName;
            }
        }

        private void btnClearDitPath_Click(object sender, EventArgs e)
        {
            lblDitPath.Text = string.Empty;
        }

        private void btnQwen3Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Constants.WEIGHT_EXTENSION_FILTER;
            ofd.Title = "Select Qwen3-0.6B weight";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblQwen3Path.Text = ofd.FileName;
            }
        }

        private void btnClearQwen3Path_Click(object sender, EventArgs e)
        {
            lblQwen3Path.Text = string.Empty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Kohya_lora_trainer
{
    public class TrainParams
    {
        //Required
        public string ModelPath = string.Empty, TrainImagePath = string.Empty, OutputPath = string.Empty, TensorBoardLogPath = string.Empty, LoraModelPath = string.Empty;
        public float LearningRate = 0.0001f;
        public int Resolution = 512, BatchSize = 2, Epochs = 5, NetworkDim = 4;
        public decimal NetworkAlpha = 4;

        //Optional
        public string RegImagePath = string.Empty;
        public bool ShuffleCaptions = true;
        public int KeepTokenCount = 1, SaveEveryNEpochs = 0;
        [XmlIgnore]
        public Optimizer OptimizerTypeEnum;
        public decimal WarmupSteps = 0m, LRDecaySteps = 0m;
        public string OutputName = string.Empty, Comment = string.Empty;

        //Advanced
        public int CpuThreads = 1;
        public bool NoBucketUpscaling = false, UseWarmupInit = false;
        public int ClipSkip = 2;
        public long Seed = -1;
        public SavePrecision SavePrecision = SavePrecision.fp16;
        public Scheduler SchedulerType = Scheduler.cosine_with_restarts;
        public int MinBucketResolution = 256, MaxBucketResolution = 1024;
        public string CaptionFileExtension = ".txt", VAEPath = string.Empty;
        public float UnetLR = -1, TextEncoderLR = -1, NoiseOffset = 0, Momentum = 0.9f;
        public AdvancedTrain advancedTrainType = AdvancedTrain.None;
        public CrossAtten CrossAttenType = CrossAtten.xformers;
        public bool UseGradient = false, UseWeightedCaptions = false, DisableMmapLoadSafetensors = false, VParameterization = false, ZeroTerminalSNR = false;
        public decimal AdaptiveNoiseScale = 0, MinSNRGamma = 0, MultiresNoiseIterations = 0, MultiresNoiseDiscount = 0, NetworkDropout = 0, RankDropout = 0, ModuleDropout = 0, CaptionDropout = 0, IpNoiseGamma = 0, CaptionTagDropout = 0m;
        public decimal ClipLDropoutRate = 0, ClipGDropoutRate = 0, T5DropoutRate = 0, TEBatchSize = 0, ScaleWeightNorms = 0;
        public ResizeInterpolation ResizeInterpolationType = ResizeInterpolation.None;

        //Addtional(KohakuBlueleaf氏作成拡張スクリプト用)
        public NetworkModule ModuleType = NetworkModule.LoRA;
        public LycoAlgo AlgoType = LycoAlgo.lora;
        public int ConvDim = 4;
        public decimal ConvAlpha = 4;
        //Additional(LoRA)
        public bool UseConv2dExtend = false;
        public decimal DyLoRAUnit = 4;
        public string DatasetConfigPath = string.Empty;
        public bool TrainNorm = false, RescaledOFT = false, ConstrainedOFT = false, UseScalar = false, UseTucker = false, WeightDocomposition = false;

        //Block Weight
        public bool UseBlockWeight = false;
        public int[] BlockWeightIn = { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
        public int BlockWeightMid = 20, BlockWeightMid01 = 20, BlockWeightMid02 = 20;
        public int[] BlockWeightOut = { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
        public decimal BlockWeightOffsetIn = 0, BlockWeightOffsetOut = 0;
        public BlockWeightPreset BlockWeightPresetTypeIn = BlockWeightPreset.none;
        public BlockWeightPreset BlockWeightPresetTypeOut = BlockWeightPreset.none;
        public int BlockWeightZeroThreshold = 0;

        //Block Dim,Alpha
        public bool UseBlockDim = false;
        public int[] BlockDimIn = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
        public int BlockDimMid = 4, BlockDimMid01 = 4, BlockDimMid02 = 4, BlockDimBase = 4, BlockDimOutSDXL = 4;
        public int[] BlockDimOut = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };

        public decimal[] BlockAlphaInM = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
        public decimal BlockAlphaMidM = 4, BlockAlphaMid01 = 4, BlockAlphaMid02 = 4, BlockAlphaBase = 4, BlockAlphaOutSDXL = 4;
        public decimal[] BlockAlphaOutM = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };

        //Advanced1
        public bool UseColorAug = false, UseFastLoading = true, DontSaveMetadata = false, UseFlipAug = false, CropRandomly = false, CacheLatents = false, CacheLatentsToDisk = false, HighVRAM = false, UseAdditionalOptArgs = false;
        //public string ModelConfigPath = string.Empty;
        public bool DebiasedEstimation = false;
        public decimal LRSchedulerCycle = 4m, GradAccSteps = 1m;
        public int DataLoaderThreads = 1, MaxTokens = 75;
        public MixedPrecision mixedPrecisionType = MixedPrecision.fp16;

        //Optimizer関連
        public float WeightDecay = 0, Eps = 1e-06f, Eps1 = 1e-16f, D0 = 1e-06f, GrowthRate = 0, Betas0 = 0.9f, Betas1 = 0.999f, Betas2 = 0.999f, DAdaptMomentum = 0.9f, ProdigyBeta3 = 0, DCoef = 1;
        public bool Decouple = false, NoProx = false, SafeguardWarmup = false, UseBiasCorrection = false;

        [XmlIgnore]
        public ModelArchitecture ModelArchitectureEnum = ModelArchitecture.Legacy;

        public bool NoHalfVAE = false, CacheTextencoder = false, CacheTextencoderToDisk = false, IsEpoch = true, UseFullBf16 = false, UseFP8Base = false, RelativeStep = true, ScaleParameter = true, SaveState = false, MaskLoss = false, AlphaMask = false;
        public bool RandomNoiseOffset = false, RandomIpNoiseGamma = false, SaveWeightEveryEpoch = true;
        public string TokensSeparator = string.Empty;

        //Huber関連
        public LossType LossType;
        public HuberSchedule HuberScheduleType;
        public decimal HuberC = 0.1m;

        //LoRA+
        public decimal LoRAPlusLRRatio = 0, LoRAPlusUnetLRRatio = 0, LoRAPlusTELRRatio = 0;

        public string CustomCommands = string.Empty, AdditionalArgs = string.Empty, AdditionalNetworkArgs = string.Empty, CustomOptName = string.Empty, CustomOptArgs = string.Empty;

        //Diffusion Transformer関連
        public decimal Sigmoidscale = 1m, DiscreteFlowShift = 3m, GuidanceScale = 0, MaxTokensT5 = 256, BlocksToSwap = 0;
        public ModelPrediction ModelPredictionType;
        public TimestepSampling TimestepSamplingType;
        public TrainBlock TrainBlockType;
        public bool SplitMode = false, ApplyT5AttnMask = false, TrainT5XXL = false, CpuOffloadCheckpointing = false, ApplyClipAttnMask = false;
        public string ClipLPath = string.Empty, T5XXLPath = string.Empty, ClipGPath = string.Empty;

        //Scheduler
        public decimal SchedulerTimescale = 0m, MinLRRatio = 0m;

        //Token warmup
        public decimal TokenWarmupMin = 0m, TokenWarmupStep = 0m;

        private string CustomOptNameXmlIgnored = string.Empty;
        private Optimizer OptimizerTypeEnumUnmodified;

        [XmlIgnore]
        public bool IsOptimizerUnknown { get; private set; }
        [XmlIgnore]
        public bool IsModelArchitectureUnkown { get; private set; }

        /// <summary>
        /// OptimizerのString版。主にXMLシリアライザで使用する。
        /// </summary>
        public string OptimizerType
        {
            get
            {
                return OptimizerTypeEnum.ToString();
            }
            set
            {
                var result = Optimizer.AdamW8bit;
                if (Enum.TryParse(value, out result))
                {
                    IsOptimizerUnknown = false;
                    OptimizerTypeEnumUnmodified = result;
                    //需要のないOptimizerは全部カスタムにする
                    switch (result)
                    {
                        case Optimizer.AdaFactor:
                        case Optimizer.SGDNesterov:
                        case Optimizer.SGDNesterov8bit:
                        case Optimizer.DAdaptation:
                        case Optimizer.DAdaptAdaGrad:
                        case Optimizer.DAdaptAdam:
                        case Optimizer.DAdaptAdan:
                        case Optimizer.DAdaptSGD:
                        case Optimizer.DAdaptAdanIP:
                        case Optimizer.PagedAdamW8bit:
                        case Optimizer.PagedLion8bit:
                        case Optimizer.SGDScheduleFree:
                            CustomOptNameXmlIgnored = result.ToString();
                            result = Optimizer.Custom;
                            break;
                        case Optimizer.AdEMAMix8bit:
                            CustomOptNameXmlIgnored = "bitsandbytes.optim.AdEMAMix8bit";
                            result = Optimizer.Custom;
                            break;
                        case Optimizer.PagedAdEMAMix8bit:
                            CustomOptNameXmlIgnored = "bitsandbytes.optim.PagedAdEMAMix8bit";
                            result = Optimizer.Custom;
                            break;
                    }
                    OptimizerTypeEnum = result;
                }
                else
                {
                    IsOptimizerUnknown = true;
                }
            }
        }

        public string StableDiffusionType
        {
            get
            {
                return ModelArchitectureEnum.ToString();
            }
            set
            {
                var result = ModelArchitecture.Legacy;
                if (Enum.TryParse(value, out result))
                {
                    IsModelArchitectureUnkown = false;
                    //廃止モデルまたは不明であればSD1にする
                    switch (result)
                    {
                        case ModelArchitecture.Flux1:
                        case ModelArchitecture.SD3:
                            //次のリリースでアンコメントして有効にする
                            result = ModelArchitecture.Legacy;
                            IsModelArchitectureUnkown = true;
                            break;
                    }
                    ModelArchitectureEnum = result;
                }
                else
                {
                    IsModelArchitectureUnkown = true;
                }
            }
        }

        [NonSerialized]
        public static TrainParams? Current;

        public TrainParams()
        {
            Current = this;
        }

        /// <summary>
        /// 読み込んだプリセットのOptimizerが廃止ならカスタムに変換する。Xmlデシリアライズ後に呼び出す。
        /// </summary>
        public void OverwriteCustomOptName()
        {
            if (!string.IsNullOrEmpty(CustomOptNameXmlIgnored))
                CustomOptName = CustomOptNameXmlIgnored;
        }

        /// <summary>
        /// 廃止したOptimizer指定時に自動で引数を追加する
        /// </summary>
        public void OverwriteCustomOptArgs()
        {
            StringBuilder sb = new StringBuilder();
            switch (OptimizerTypeEnumUnmodified)
            {
                case Optimizer.AdaFactor:
                    {
                        sb.Append("\"relative_step=").Append(RelativeStep.ToString()).Append("\" \"scale_parameter=").Append(ScaleParameter.ToString()).Append("\" \"warmup_init=").Append(UseWarmupInit.ToString()).Append('"');
                    }
                    break;
                case Optimizer.SGDNesterov:
                case Optimizer.SGDNesterov8bit:
                    {
                        sb.Append("\"momentum=").Append(Momentum.ToString()).Append('"');
                    }
                    break;
                case Optimizer.DAdaptAdaGrad:
                    {
                        sb.Append("\"eps=").Append(Eps.ToString("g")).Append("\" \"weight_decay=").Append(WeightDecay.ToString("g")).Append("\" \"d0=")
                            .Append(D0.ToString("g")).Append('"');

                        if (GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(GrowthRate.ToString("g")).Append('"');
                        }
                    }
                    break;
                case Optimizer.DAdaptAdam:
                    {
                        sb.Append("\"betas=").Append(Betas0.ToString("g")).Append(',').Append(Betas1.ToString("g")).Append("\" \"eps=")
                            .Append(Eps.ToString("g")).Append("\" \"weight_decay=").Append(WeightDecay.ToString("g")).Append("\" \"d0=")
                            .Append(D0.ToString("g")).Append("\" \"decouple=").Append(Decouple.ToString()).Append('"');

                        if (GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(GrowthRate.ToString("g")).Append('"');
                        }

                    }
                    break;
                case Optimizer.DAdaptAdan:
                    {
                        sb.Append("\"betas=").Append(Betas0.ToString("g")).Append(',').Append(Betas1.ToString("g")).Append(',').Append(Betas2.ToString("g")).Append("\" \"eps=")
    .Append(Eps.ToString("g")).Append("\" \"weight_decay=").Append(WeightDecay.ToString("g")).Append("\" \"d0=")
    .Append(D0.ToString("g")).Append("\" \"no_prox=").Append(NoProx.ToString()).Append('"');

                        if (GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(GrowthRate.ToString("g")).Append('"');
                        }
                    }
                    break;
                case Optimizer.DAdaptSGD:
                    {
                        sb.Append("\"momentum=").Append(DAdaptMomentum.ToString("g")).Append("\" \"weight_decay=").Append(WeightDecay.ToString("g")).Append("\" \"d0=")
                            .Append(D0.ToString("g")).Append('"');

                        if (GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(GrowthRate.ToString("g")).Append('"');
                        }
                    }
                    break;
                //dadapt_adam_preprint.pyの説明にはmomontumが書いてあるが実際にはない
                //DAdaptAdamPreprint
                case Optimizer.DAdaptation:
                    {
                        sb.Append("\"betas=").Append(Betas0.ToString("g")).Append(',').Append(Betas1.ToString("g")).Append("\" \"eps=")
    .Append(Eps.ToString("g")).Append("\" \"weight_decay=").Append(WeightDecay.ToString("g")).Append("\" \"d0=")
    .Append(D0.ToString("g")).Append("\" \"decouple=").Append(Decouple.ToString()).Append('"');

                        if (GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(GrowthRate.ToString("g")).Append('"');
                        }
                    }
                    break;
                case Optimizer.DAdaptAdanIP:
                    {
                        sb.Append("\"betas=").Append(Betas0.ToString("g")).Append(',').Append(Betas1.ToString("g")).Append(',').Append(Betas2.ToString("g")).Append("\" \"eps=")
    .Append(Eps.ToString("g")).Append("\" \"weight_decay=").Append(WeightDecay.ToString("g")).Append("\" \"d0=")
    .Append(D0.ToString("g")).Append("\" \"no_prox=").Append(NoProx.ToString()).Append('"');

                        if (GrowthRate > 0f)
                        {
                            sb.Append(" \"growth_rate=").Append(GrowthRate.ToString("g")).Append('"');
                        }
                    }
                    break;
            }

            string str = sb.ToString();
            if (!string.IsNullOrEmpty(str)) 
            {
                CustomOptArgs = str;
            }
        }

        public void CheckBrokenBlockDim()
        {
            bool broken = false;

            if (BlockDimIn.Length < 12)
            {
                BlockDimIn = new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
                broken = true;
            }

            if (BlockDimBase <= 0 || BlockDimBase > 1280)
            {
                BlockDimBase = 4;
            }

            if (BlockAlphaBase < 0.0001m || BlockAlphaBase > 1280)
            {
                BlockAlphaBase = 1;
            }

            if (BlockDimMid < 0 || BlockDimMid > 1280)
            {
                BlockDimMid = 32;
                broken = true;
            }

            if (BlockDimMid01 < 0 || BlockDimMid01 > 1280)
            {
                BlockDimMid01 = 4;
                broken = true;
            }

            if (BlockDimMid02 < 0 || BlockDimMid02 > 1280)
            {
                BlockDimMid02 = 4;
                broken = true;
            }

            if (BlockAlphaMid01 < 0 || BlockAlphaMid01 > 1280)
            {
                BlockAlphaMid01 = 1;
                broken = true;
            }

            if (BlockAlphaMid02 < 0 || BlockAlphaMid02 > 1280)
            {
                BlockAlphaMid02 = 1;
                broken = true;
            }

            if (BlockDimOut.Length < 12)
            {
                BlockDimOut = new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
                broken = true;
            }

            if (BlockAlphaInM.Length < 12)
            {
                BlockAlphaInM = new decimal[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
                broken = true;
            }

            if (BlockAlphaMidM < 0)
            {
                BlockAlphaMidM = 4;
                broken = true;
            }

            if (BlockAlphaOutM.Length < 12)
            {
                BlockAlphaOutM = new decimal[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
                broken = true;
            }

            for (int i = 0; i < 12; i++)
            {
                if (BlockDimIn[i] < 0 || BlockDimIn[i] > 1280)
                {
                    BlockDimIn[i] = 1;
                    broken = true;
                }

                if (BlockDimOut[i] < 0 || BlockDimOut[i] > 1280)
                {
                    BlockDimOut[i] = 1;
                    broken = true;
                }

                if (BlockAlphaInM[i] < 0)
                {
                    BlockAlphaInM[i] = 1;
                    broken = true;
                }

                if (BlockAlphaOutM[i] < 0)
                {
                    BlockAlphaOutM[i] = 1;
                    broken = true;
                }

            }

            if (broken)
            {
                MessageBox.Show("層別Dim/Alphaの設定が破損しています。破損箇所はリセットされました。", "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public enum Optimizer
    {
        AdamW8bit,
        AdamW,
        Lion,
        Lion8bit,
        DAdaptLion,
        prodigy,
        AdamWScheduleFree,
        RAdamScheduleFree,
        Came,
        Custom,
        //Deprecated optimizer
        AdaFactor,
        SGDNesterov,
        SGDNesterov8bit,
        DAdaptation,
        DAdaptAdaGrad,
        DAdaptAdam,
        DAdaptAdan,
        DAdaptSGD,
        DAdaptAdanIP,
        PagedAdamW8bit,
        PagedLion8bit,
        SGDScheduleFree,
        AdEMAMix8bit,
        PagedAdEMAMix8bit,
    }

    public enum SavePrecision
    {
        fp16,
        bf16,
        fp32
    }

    public enum Scheduler
    {
        cosine_with_restarts,
        cosine,
        linear,
        polynomial,
        constant,
        constant_with_warmup,
        inverse_sqrt,
        cosine_with_min_lr,
        warmup_stable_decay
    }

    public enum AdvancedTrain
    {
        None,
        TextEncoderOnly,
        UNetOnly,
    }

    public enum NetworkModule
    {
        LoRA,
        LyCORIS,
        DyLoRA,
        LoRAFA
    }

    public enum LycoAlgo
    {
        lora,
        loha,
        ia3,
        lokr,
        full,
        glora,
        diag_oft,
        boft
    }

    public enum CrossAtten
    {
        xformers,
        mem_eff_attn,
        sdpa,
        None
    }

    public enum BlockWeightPreset
    {
        none,
        sine,
        cosine,
        linear,
        reverse_linear,
        zeros
    }

    public enum MixedPrecision
    {
        None,
        fp16,
        bf16
    }

    public enum ModelArchitecture
    {
        Legacy,
        XL,
        Flux1,
        SD3,
    }

    public enum TrainCompleteAction
    {
        None,
        ShowTimetaken,
        Shutdown,
        Suspend
    }

    public enum LossType
    {
        LTwo,
        Huber,
        SmoothLOne
    }

    public enum HuberSchedule
    {
        SNR,
        Exponential,
        Constant
    }

    public enum ModelPrediction
    {
        Raw,
        Additive,
        Sigma_Scaled
    }

    public enum TimestepSampling
    {
        Sigma,
        Uniform,
        Sigmoid,
        Shift,
        Flux_Shift
    }

    public enum TrainBlock
    {
        All,
        Double,
        Single
    }

    public enum ResizeInterpolation
    {
        None,
        Bicubic,
        Bilinear,
        Nearest,
        Lanczos
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kohya_lora_trainer {
    public  class TrainParams {
        //Required
        public  string ModelPath = string.Empty, TrainImagePath = string.Empty, OutputPath = string.Empty, TensorBoardLogPath = string.Empty, LoraModelPath = string.Empty;
        public  float LearningRate = 0.0001f;
        public  int Resolution = 512, BatchSize = 2, Epochs = 5, NetworkDim = 64;
        public decimal NetworkAlpha = 16;

        //Optional
        public  string RegImagePath = string.Empty;
        public  bool ShuffleCaptions = true;
        public  int KeepTokenCount = 1, SaveEveryNEpochs = 0;
        public  Optimizer OptimizerType = Optimizer.AdamW;
        public  int WarmupSteps = 250;
        public  string OutputName = string.Empty, Comment = string.Empty;

        //Advanced
        public  int CpuThreads = 4;
        public  bool NoBucketUpscaling = false, UseWarmupInit = false;
        public  int ClipSkip = 2;
        public long Seed = 42;
        public  SavePrecision SavePrecision = SavePrecision.fp16;
        public  Scheduler SchedulerType = Scheduler.cosine_with_restarts;
        public  int MinBucketResolution = 320, MaxBucketResolution = 1024;
        public  string CaptionFileExtension = ".txt", VAEPath = string.Empty;
        public  float UnetLR = -1, TextEncoderLR = -1, NoiseOffset = 0, Momentum = 0.9f;
        public AdvancedTrain advancedTrainType = AdvancedTrain.None;
        public CrossAtten CrossAttenType = CrossAtten.xformers;
        public bool UseGradient = false, UseWeightedCaptions = false;
        public decimal AdaptiveNoiseScale = 0, MinSNRGamma = 0, MultiresNoiseIterations = 0, MultiresNoiseDiscount = 0, NetworkDropout = 0, RankDropout = 0, ModuleDropout = 0, MaxNormReg = 0, CaptionDropout = 0, IpNoiseGamma = 0;

        //Addtional(KohakuBlueleaf氏作成拡張スクリプト用)
        public NetworkModule ModuleType = NetworkModule.LoRA;
        public LycoAlgo AlgoType = LycoAlgo.lora;
        public int ConvDim = 64;
        public decimal ConvAlpha = 16;
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
        public int[] BlockDimIn = { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64 };
        public int BlockDimMid = 64, BlockDimMid01 = 4, BlockDimMid02 = 4, BlockDimBase = 4, BlockDimOutSDXL = 4;
        public int[] BlockDimOut = { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64 };

        //現在未使用。互換性維持のため残してある
        public int[] BlockAlphaIn = Array.Empty<int>();
        public int BlockAlphaMid = -1;
        public int[] BlockAlphaOut = Array.Empty<int>();

        public decimal[] BlockAlphaInM = { 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
        public decimal BlockAlphaMidM = 16, BlockAlphaMid01 = 4, BlockAlphaMid02 = 4, BlockAlphaBase = 4, BlockAlphaOutSDXL = 4;
        public decimal[] BlockAlphaOutM = { 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16 };

        //Advanced1
        public bool UseColorAug = false, UseFastLoading = true, DontSaveMetadata = false, UseFlipAug = false, CropRandomly = false, CacheLatents = false, CacheLatentsToDisk = false, HighVRAM = false, UseAdditionalOptArgs = false;
        //public string ModelConfigPath = string.Empty;
        public decimal LRSchedulerCycle = 4m, GradAccSteps = 1m;
        public int DataLoaderThreads = 1, MaxTokens = 75;
        public MixedPrecision mixedPrecisionType = MixedPrecision.fp16;

        //DAdaptation関連
        public float WeightDecay = 0, Eps = 1e-06f, D0 = 1e-06f, GrowthRate = 0, Betas0 = 0.9f, Betas1 = 0.999f, Betas2 = 0.999f, DAdaptMomentum = 0.9f, ProdigyBeta3 = 0, DCoef = 1;
        public bool Decouple = false, NoProx = false, SafeguardWarmup = false, UseBiasCorrection = false;

        public ModelArchitecture StableDiffusionType = ModelArchitecture.Legacy;

        public bool NoHalfVAE = false, CacheTextencoder = false, CacheTextencoderToDisk = false, IsEpoch = true, UseFullFP16 = false, UseFP8Base = false, RelativeStep = true, ScaleParameter = true, SaveState = false, MaskLoss = false, AlphaMask = false;
        public bool RandomNoiseOffset = false, RandomIpNoiseGamma = false;
        public string TokensSeparator = string.Empty;

        //Huber関連
        public LossType LossType;
        public HuberSchedule HuberScheduleType;
        public decimal HuberC = 0.1m;

        //LoRA+
        public decimal LoRAPlusLRRatio = 0, LoRAPlusUnetLRRatio = 0, LoRAPlusTELRRatio = 0;

        public decimal ImmiscibleNoise = 0;

        public string CustomCommands = string.Empty;

        //Diffusion Transformer関連
        public decimal Sigmoidscale = 1m, DiscreteFlowShift = 3m, GuidanceScale = 0;
        public ModelPrediction ModelPredictionType;
        public TimestepSampling TimestepSamplingType;
        public TrainBlock TrainBlockType;
        public bool SplitMode = false, ApplyT5AttnMask = false, TrainT5XXL = false, CpuOffloadCheckpointing = false;
        public string ClipLPath = string.Empty, T5XXLPath = string.Empty;

        [NonSerialized]
        public static TrainParams? Current;

        public TrainParams() {
            Current = this;
        }

        public void ConvertBlockAlpha()
        {
            if(BlockAlphaIn.Length > 0)
            {
                Console.WriteLine("Converting BlockAlphaIn...");
                for (int i =0; i < BlockAlphaIn.Length; i++)
                {
                    if (i < BlockAlphaInM.Length)
                        BlockAlphaInM[i] = BlockAlphaIn[i];
                    else
                    {
                        Console.WriteLine("Found Missing Array Element in BlockAlphaInM!");
                        BlockAlphaInM = new decimal[] { 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
                        break;
                    }
                }

                BlockAlphaIn = Array.Empty<int>();
            }

            if (BlockAlphaOut.Length > 0)
            {
                Console.WriteLine("Converting BlockAlphaOut...");
                for (int i = 0; i < BlockAlphaOut.Length; i++)
                {
                    if (i < BlockAlphaOutM.Length)
                        BlockAlphaOutM[i] = BlockAlphaOut[i];
                    else
                    {
                        Console.WriteLine("Found Missing Array Element in BlockAlphaOutM!");
                        BlockAlphaOutM = new decimal[] { 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
                        break;
                    }

                }

                BlockAlphaOut = Array.Empty<int>();
            }

            if (BlockAlphaMid > 0)
            {
                Console.WriteLine("Converting BlockAlphaMid...");
                BlockAlphaMidM = BlockAlphaMid;
                BlockAlphaMid = -1;
            }
        }

        public void CheckBrokenBlockDim()
        {
            bool broken = false;

            if(BlockDimIn.Length < 12)
            {
                BlockDimIn = new int[] { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64 };
                broken = true;
            }

            if(BlockDimMid <= 0 || BlockDimMid > 512)
            {
                BlockDimMid = 32;
                broken = true;
            }

            if(BlockDimOut.Length < 12)
            {
                BlockDimOut = new int[] { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64 };
                broken = true;
            }

            if(BlockAlphaInM.Length < 12)
            {
                BlockAlphaInM = new decimal[] { 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
                broken = true;
            }

            if(BlockAlphaMidM <= 0)
            {
                BlockAlphaMidM = 16;
                broken = true;
            }

            if(BlockAlphaOutM.Length < 12)
            {
                BlockAlphaOutM = new decimal[] { 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
                broken = true;
            }

            for(int i = 0; i< 12; i++)
            {
                if (BlockDimIn[i] <= 0 || BlockDimIn[i] > 512)
                {
                    BlockDimIn[i] = 64;
                    broken = true;
                }

                if (BlockDimOut[i] <= 0 || BlockDimOut[i] > 512)
                {
                    BlockDimOut[i] = 64;
                    broken = true;
                }

                if (BlockAlphaInM[i] <= 0)
                {
                    BlockAlphaInM[i] = 16;
                    broken = true;
                }

                if (BlockAlphaOutM[i] <= 0)
                {
                    BlockAlphaOutM[i] = 16;
                    broken = true;
                }

            }

            if (broken)
            {
                MessageBox.Show("層別Dim/Alphaの設定が破損しています。破損箇所はリセットされました。", "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ResetObsoleteOptions()
        {
            //IA3Network will be removed but ia3 still available
            //if(AlgoType == AlgoType.ia3)
            //{
            //    AlgoType = AlgoType.lora;
            //}
        }
    }

    public enum Optimizer {
        AdamW8bit,
        AdamW,
        AdaFactor,
        Lion,
        SGDNesterov,
        SGDNesterov8bit,
        DAdaptation,
        Lion8bit,
        DAdaptAdaGrad,
        DAdaptAdam,
        DAdaptAdan,
        DAdaptSGD,
        DAdaptAdanIP,
        DAdaptLion,
        prodigy,
        PagedAdamW8bit,
        PagedLion8bit,
        AdamWScheduleFree,
        SGDScheduleFree
    }

    public enum SavePrecision {
        fp16,
        bf16,
        fp32
    }

    public enum Scheduler {
        cosine_with_restarts,
        cosine,
        linear,
        polynomial,
        constant,
        constant_with_warmup
    }

    public enum AdvancedTrain {
        None,
        TextEncoderOnly,
        UNetOnly,
    }

    public enum NetworkModule {
        LoRA,
        LyCORIS,
        DyLoRA,
        LoRAFA
    }

    public enum LycoAlgo {
        lora,
        loha,
        ia3,
        lokr,
        full,
        glora,
        diag_oft,
        boft
    }

    public enum CrossAtten {
        xformers,
        mem_eff_attn,
        sdpa
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
        Flux1
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
}

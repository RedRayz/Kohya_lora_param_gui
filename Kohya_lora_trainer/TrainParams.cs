using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kohya_lora_trainer {
    public  class TrainParams {
        //Required
        public  string ModelPath, TrainImagePath, OutputPath, TensorBoardLogPath, LoraModelPath;
        public  float LearningRate = 0.0001f;
        public  int Resolution = 512, BatchSize = 1, Epochs = 5, NetworkDim = 64;
        public decimal NetworkAlpha = 32;

        //Optional
        public  string RegImagePath;
        public  bool ShuffleCaptions = true;
        public  int KeepTokenCount = 1, SaveEveryNEpochs = 0;
        public  OptimizerType OptimizerType = OptimizerType.AdamW;
        public  int WarmupSteps = 500;
        public  string OutputName;

        //Advanced
        public  int CpuThreads = 8;
        public  bool NoBucketUpscaling = false, UseWarmupInit = false;
        public  int ClipSkip = 2, Seed = 42;
        public  SavePrecision SavePrecision = SavePrecision.fp16;
        public  SchedulerType SchedulerType = SchedulerType.cosine_with_restarts;
        public  int MinBucketResolution = 320, MaxBucketResolution = 1024;
        public  string CaptionFileExtension = ".txt", VAEPath = string.Empty;
        public  float UnetLR = -1, TextEncoderLR = -1, NoiseOffset = 0, Momentum = 0.9f;
        public AdvancedTrainType advancedTrainType = AdvancedTrainType.None;
        public CrossAttenType CrossAttenType = CrossAttenType.xformers;
        public bool UseGradient = false, UseWeightedCaptions = false;
        public decimal AdaptiveNoiseScale = 0, MinSNRGamma = 0, MultiresNoiseIterations = 0, MultiresNoiseDiscount = 0;

        //Addtional(KohakuBlueleaf氏作成拡張スクリプト用)
        public ModuleType ModuleType = ModuleType.LoRA;
        public AlgoType AlgoType = AlgoType.lora;
        public int ConvDim = 0;
        public decimal ConvAlpha = 0;
        //Additional(LoRA)
        public bool UseConv2dExtend = false;
        public decimal DyLoRAUnit = 4;
        public string DatasetConfigPath = string.Empty;

        //Block Weight
        public bool UseBlockWeight = false;
        public int[] BlockWeightIn = { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
        public int BlockWeightMid = 20;
        public int[] BlockWeightOut = { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
        public decimal BlockWeightOffsetIn = 0, BlockWeightOffsetOut = 0;
        public BlockWeightPresetType BlockWeightPresetTypeIn = BlockWeightPresetType.none;
        public BlockWeightPresetType BlockWeightPresetTypeOut = BlockWeightPresetType.none;
        public int BlockWeightZeroThreshold = 0;

        //Block Dim,Alpha
        public bool UseBlockDim = false;
        public int[] BlockDimIn = { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64 };
        public int BlockDimMid = 32;
        public int[] BlockDimOut = { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64 };

        //現在未使用。互換性維持のため残してある
        public int[] BlockAlphaIn = Array.Empty<int>();
        public int BlockAlphaMid = -1;
        public int[] BlockAlphaOut = Array.Empty<int>();

        public decimal[] BlockAlphaInM = { 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32 };
        public decimal BlockAlphaMidM = 32;
        public decimal[] BlockAlphaOutM = { 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32 };

        //Advanced1
        public bool UseColorAug = false, UseFastLoading = true, UseSDV2 = false, DontSaveMetadata = false, UseFlipAug = false, CropRandomly = false, UseParameterization = false, CacheLatents = false, CacheLatentsToDisk = false;
        //public string ModelConfigPath = string.Empty;
        public int LRSchedulerCycle = 4, DataLoaderThreads = 4, MaxTokens = 75;
        public MixedPrecisionType mixedPrecisionType = MixedPrecisionType.fp16;

        //DAdaption関連
        public float WeightDecay = 0, Eps = 1e-06f, D0 = 1e-06f, GrowthRate = 0, Betas0 = 0.9f, Betas1 = 0.999f, Betas2 = 0.999f, DAdaptMomentum = 0.9f;


        [NonSerialized]
        public static TrainParams Current;

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
                        BlockAlphaInM = new decimal[] { 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32 };
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
                        BlockAlphaOutM = new decimal[] { 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32 };
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
                BlockAlphaInM = new decimal[] { 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32 };
                broken = true;
            }

            if(BlockAlphaMidM <= 0)
            {
                BlockAlphaMidM = 32;
                broken = true;
            }

            if(BlockAlphaOutM.Length < 12)
            {
                BlockAlphaOutM = new decimal[] { 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32 };
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
                    BlockAlphaInM[i] = 32;
                    broken = true;
                }

                if (BlockAlphaOutM[i] <= 0)
                {
                    BlockAlphaOutM[i] = 32;
                    broken = true;
                }

            }

            if (broken)
            {
                MessageBox.Show("層別Dim/Alphaの設定が破損しています。破損箇所はリセットされました。", "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public enum OptimizerType {
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
        DAdaptLion
    }

    public enum SavePrecision {
        fp16,
        bf16,
        fp32
    }

    public enum SchedulerType {
        cosine_with_restarts,
        cosine,
        linear,
        polynomial,
        constant,
        constant_with_warmup
    }

    public enum AdvancedTrainType {
        None,
        TextEncoderOnly,
        UNetOnly,
    }

    public enum ModuleType {
        LoRA,
        LyCORIS,
        DyLoRA
    }

    public enum AlgoType {
        lora,
        loha,
        ia3,
        lokr
    }

    public enum CrossAttenType {
        xformers,
        mem_eff_attn
    }

    public enum BlockWeightPresetType
    {
        none,
        sine,
        cosine,
        linear,
        reverse_linear,
        zeros
    }

    public enum MixedPrecisionType
    {
        None,
        fp16,
        bf16
    }
}

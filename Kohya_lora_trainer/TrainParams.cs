using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohya_lora_trainer {
    public  class TrainParams {
        //Required
        public  string ModelPath, TrainImagePath, OutputPath, TensorBoardLogPath, LoraModelPath;
        public  float LearningRate = 0.0001f;
        public  int Resolution = 512, BatchSize = 1, Epochs = 5, NetworkDim = 128, NetworkAlpha = 128;

        //Optional
        public  string RegImagePath;
        public  bool ShuffleCaptions = false;
        public  int KeepTokenCount = 0, SaveEveryNEpochs = 0;
        public  OptimizerType OptimizerType = OptimizerType.AdamW8bit;
        public  int WarmupSteps = 500;
        public  string OutputName;

        //Advanced
        public  int CpuThreads = 12;
        public  bool NoBucketUpscaling, UseWarmupInit;
        public  int ClipSkip = 2, Seed = 42;
        public  SavePrecision SavePrecision = SavePrecision.fp16;
        public  SchedulerType SchedulerType = SchedulerType.cosine_with_restarts;
        public  int MinBucketResolution = 320, MaxBucketResolution = 960;
        public  string CaptionFileExtension = ".txt", VAEPath = string.Empty;
        public  float UnetLR = -1, TextEncoderLR = -1, NoiseOffset = 0, Momentum = 0.9f;
        public AdvancedTrainType advancedTrainType = AdvancedTrainType.None;
        public CrossAttenType CrossAttenType = CrossAttenType.xformers;
        public bool UseGradient = false;

        //Addtional(KohakuBlueleaf氏作成拡張スクリプト用)
        public ModuleType ModuleType = ModuleType.LoRA;
        public AlgoType AlgoType = AlgoType.lora;
        public int ConvDim = 0, ConvAlpha = 0;
        //Additional(LoRA)
        public bool UseConv2dExtend = false;

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

        public int[] BlockAlphaIn = { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64 };
        public int BlockAlphaMid = 32;
        public int[] BlockAlphaOut = { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64 };

        [NonSerialized]
        public static TrainParams Current;

        public TrainParams() {
            Current = this;
        }
    }

    public enum OptimizerType {
        AdamW8bit,
        AdamW,
        AdaFactor,
        Lion,
        SGDNesterov,
        SGDNesterov8bit,
        DAdaptation
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
        //LyCORISの統合・最適化に伴い削除予定
        LoCon
    }

    public enum AlgoType {
        lora,
        loha
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
}

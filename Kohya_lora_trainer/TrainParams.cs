using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohya_lora_trainer {
    public  class TrainParams {
        //Required
        public  string ModelPath, TrainImagePath, OutputPath, TensorBoardLogPath;
        public  float LearningRate = 0.0001f;
        public  int Resolution = 512, BatchSize = 1, Epochs = 5, NetworkDim = 128, NetworkAlpha = 128;

        //Optional
        public  string RegImagePath;
        public  bool ShuffleCaptions = false;
        public  int KeepTokenCount = 0, SaveEveryNEpochs = 0;
        public  OptimizerType OptimizerType = OptimizerType.AdamW8bit;
        public  int WarmupSteps = 500;
        public  string OutputName;
        /// <summary>
        /// 互換性維持のために残しています。通常はModuleTypeを使用してください
        /// </summary>
        public bool UseLoCon = false;

        //Advanced
        public  int CpuThreads = 12;
        public  bool NoBucketUpscaling, UseWarmupInit;
        public  int ClipSkip = 2, Seed = 42;
        public  SavePrecision SavePrecision = SavePrecision.fp16;
        public  SchedulerType SchedulerType = SchedulerType.cosine_with_restarts;
        public  int MinBucketResolution = 320, MaxBucketResolution = 960;
        public  string CaptionFileExtension = ".txt";
        public  float UnetLR = -1, TextEncoderLR = -1;
        public AdvancedTrainType advancedTrainType = AdvancedTrainType.None;
        public AlgoType AlgoType = AlgoType.lora;
        public CrossAttenType CrossAttenType = CrossAttenType.xformers;
        public bool UseGradient = false;

        //Addtional(KohakuBlueleaf氏作成拡張スクリプト用)
        public ModuleType ModuleType = ModuleType.LoRA;
        public float ConvDim = -1, ConvAlpha = -1;

        [NonSerialized]
        public static TrainParams Current;

        public TrainParams() {
            Current = this;
        }
    }

    public enum OptimizerType {
        AdamW8bit,
        AdamW,
        AdaFactor
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
        LoCon,
        LyCORIS
    }

    public enum AlgoType {
        lora,
        loha
    }

    public enum CrossAttenType {
        xformers,
        mem_eff_attn
    }
}

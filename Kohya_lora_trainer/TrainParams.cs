using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohya_lora_trainer {
    public static class TrainParams {
        //Required
        public static string ModelPath, TrainImagePath, OutputPath;
        public static float LearningRate = 0.0001f;
        public static int Resolution = 512, BatchSize = 1, Epochs = 5, NetworkDim = 128, NetworkAlpha = 128;

        //Optional
        public static string RegImagePath;
        public static bool ShuffleCaptions = false;
        public static int KeepTokenCount = 0, SaveEveryNEpochs = 0;
        public static OptimizerType OptimizerType = OptimizerType.AdamW8bit;
        public static int WarmupSteps = 500;
        public static string OutputName;

        //Advanced
        public static int CpuThreads = 12;
        public static bool NoBucketUpscaling, UseWarmupInit;
        public static int ClipSkip = 2, Seed = 42;
        public static SavePrecision SavePrecision = SavePrecision.fp16;
        public static SchedulerType SchedulerType = SchedulerType.cosine_with_restarts;
        public static int MinBucketResolution = 320, MaxBucketResolution = 960;
        public static string CaptionFileExtension = ".txt";
        public static float UnetLR = -1, TextEncoderLR = -1;
    }

    public enum OptimizerType {
        AdamW,
        AdamW8bit,
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
}

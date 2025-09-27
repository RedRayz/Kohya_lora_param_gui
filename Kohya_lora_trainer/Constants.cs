namespace Kohya_lora_trainer
{
    public class Constants
    {

        public static string CurrentSdScriptsPath = string.Empty;

        public const string TORCH_VERSION = "2.4.1+cu124";
        public const string TORCHVISION_VERSION = "0.19.1+cu124";
        public const string XFORMERS_VERSION = "0.0.28.post1";
        public const string INDEX_URL = "https://download.pytorch.org/whl/cu124";
        public const string WEIGHT_EXTENSION_FILTER = "Weight(*.pt;*.ckpt;*.pth;*.safetensors;*.sft)|*.pt;*.ckpt;*.pth;*.safetensors;*.sft";

        public const string LATEST_TORCH_VERSION = "2.7.0+cu128";
        public const string LATEST_TORCHVISION_VERSION = "0.22.0+cu128";
        public const string LATEST_INDEX_URL = "https://download.pytorch.org/whl/cu128";
        public const string LATEST_XFORMERS_VERSION = "0.0.30";
    }
}

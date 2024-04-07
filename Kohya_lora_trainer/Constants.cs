using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohya_lora_trainer
{
    public class Constants
    {

        public const string LecoPath = @"..\LECO\";

        public static string CurrentSdScriptsPath = string.Empty;

        public const string TORCH_VERSION = "2.1.2+cu121";
        public const string TORCHVISION_VERSION = "0.16.2+cu121";
        public const string XFORMERS_VERSION = "0.0.23.post1";
        public const string INDEX_URL = "https://download.pytorch.org/whl/cu121";
    }
}

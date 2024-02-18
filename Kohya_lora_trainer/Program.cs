using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kohya_lora_trainer
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if NET5_0_OR_GREATER
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
#endif
            Application.Run(new Form1());
        }
    }
}

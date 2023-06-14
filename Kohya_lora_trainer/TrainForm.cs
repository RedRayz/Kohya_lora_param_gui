using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kohya_lora_trainer
{
    public partial class TrainForm : Form
    {
        private Process process;
        private bool BenchMarkMode, ShutdownAfterComplete, ShutdownOnly;
        private Stopwatch stopwatch;
        private int Duration = 60;

        public TrainForm(bool benchMarkMode, bool shutdownAfterComplete, bool shutdownOnly)
        {
            InitializeComponent();
            BenchMarkMode = benchMarkMode;
            ShutdownAfterComplete = shutdownAfterComplete;
            ShutdownOnly = shutdownOnly;
        }

        private void TrainForm_Load(object sender, EventArgs e)
        {
            if (ShutdownOnly && ShutdownAfterComplete)
            {
                btnCopyCmd.Enabled = false;
                btnStop.Enabled = false;
                btnClose.Enabled = true;
                lblCountdown.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
                lblCountdown.Text = Duration.ToString() + "秒後にシャットダウンします \n しない場合はこのウィンドウを閉じてください";
                return;
            }

            if (BatchProcess.LogResultText && BatchProcess.IsRunning)
            {
                StringBuilder ssb = new StringBuilder();
                ssb.Append(TrainParams.Current.OutputPath).Append("\\").Append(TrainParams.Current.OutputName).Append(".safetensors\r\n").Append("開始時刻: ").Append(DateTime.Now.ToString());

                BatchProcess.LogText += ssb.ToString();
            }

            btnStop.Enabled = true;
            btnClose.Enabled = false;
            if (BatchProcess.IsRunning)
                btnStop.Text = "バッチ処理の中止";

            
            StringBuilder sbCmd = new StringBuilder();

            if (BenchMarkMode || ShutdownAfterComplete || BatchProcess.IsRunning)
            {
                sbCmd.Append(@"/c ");
            }
            else
            {
                sbCmd.Append(@"/k ");
            }

            sbCmd.Append("cd ");
            if (!string.IsNullOrEmpty(Form1.ScriptPath))
            {
                sbCmd.Append("/d ").Append(Form1.ScriptPath);
            }
            else
            {
                sbCmd.Append("..\\");
            }

            sbCmd.Append(" && .\\venv\\Scripts\\activate && ");

            lblCountdown.Text = string.Empty;
            sbCmd.Append(MyUtils.GenerateCommands());

            if (BenchMarkMode || (BatchProcess.IsRunning && BatchProcess.LogResultText))
            {
                stopwatch = Stopwatch.StartNew();
            }

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = sbCmd.ToString();
            process = new Process();
            process.SynchronizingObject = this;
            process.StartInfo = ps;
            process.Exited += new EventHandler(TrainExited);
            process.EnableRaisingEvents = true;
            process.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ShutdownAfterComplete)
            {
                Duration = 60;
                timer1.Stop();
            }
            Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (process != null && !process.HasExited)
            {
                DialogResult result = MessageBox.Show("学習中に閉じると学習は中止されます。よろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //メッセージボックスが出ている間に閉じたかもしれないので再度確認
                    if (process != null && !process.HasExited)
                    {
                        //Killしても閉じない・・・Win11の仕様変更?
                        Console.WriteLine("Try kill terminal: " + process.ProcessName);
                        process.Kill();
                        process.Dispose();
                    }

                    btnStop.Enabled = false;
                    btnClose.Enabled = true;
                    process = null;
                    BatchProcess.SkippedCount += BatchProcess.BatchStack.Count + 1;
                    BatchProcess.IsCancel = true;
                    BatchProcess.BatchStack.Clear();
                    BatchProcess.IsRunning = false;
                    BatchProcess.CompletedCount--;
                }
            }
        }

        private void TrainExited(object sender, EventArgs e)
        {
            if (process != null)
            {
                process.Dispose();
                process = null;
                btnStop.Enabled = false;
                btnClose.Enabled = true;
            }
            bool failed = !File.Exists(TrainParams.Current.OutputPath + "\\" + TrainParams.Current.OutputName + ".safetensors");

            if (BatchProcess.IsRunning && BatchProcess.LogResultText && stopwatch != null)
            {
                stopwatch.Stop();
                double tos = stopwatch.Elapsed.TotalSeconds;

                double sec = tos % 60;
                double min = tos / 60;
                double hour = min / 60;
                min = Math.Floor(min);
                hour = Math.Floor(hour);
                min -= hour * 60;
                BatchProcess.LogText += ", 終了時刻:" + DateTime.Now.ToString() + ", 経過時間: " + $"{hour}時間{min}分" + sec.ToString("0.000秒");
                if (failed)
                {
                    BatchProcess.LogText += "\r\n出力物がないためエラー落ちの可能性あり。";
                }
                else
                {
                    BatchProcess.LogText += "\r\n学習は正常に終了。";
                }
                BatchProcess.LogText += "\r\n\r\n";
            }



            if (BatchProcess.IsRunning)
            {
                if (failed)
                {
                    BatchProcess.FailCount++;
                }
                Close();
                return;
            }

            if (BenchMarkMode && stopwatch != null)
            {
                stopwatch.Stop();
                double tos = stopwatch.Elapsed.TotalSeconds;

                double sec = tos % 60;
                double min = tos / 60;
                double hour = min / 60;
                min = Math.Floor(min);
                hour = Math.Floor(hour);
                min -= hour * 60;

                MessageBox.Show("Time taken: " + $"{hour}h{min}m" + sec.ToString("0.000s"), "Result", MessageBoxButtons.OK);
            }



            if (ShutdownAfterComplete)
            {
                lblCountdown.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
                lblCountdown.Text = Duration.ToString() + "秒後にシャットダウンします \n しない場合はこのウィンドウを閉じてください";
            }
        }

        private void TrainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (process != null && !process.HasExited)
            {
                process.Kill();
                process.Dispose();
                process = null;
            }
        }

        private void btnCopyCmd_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MyUtils.GenerateCommands());
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Duration == 0)
            {
                Duration = -1;
                if (timer1.Enabled)
                    timer1.Stop();
                ShutdownPC();
                Close();
                //MessageBox.Show("ここでシャットダウンする", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Duration > 0)
            {
                Duration--;
                lblCountdown.Text = Duration.ToString() + "秒後にシャットダウンします \n しない場合はこのウィンドウを閉じてください";
            }
        }

        private void ShutdownPC()
        {
            ProcessStartInfo ps = new ProcessStartInfo()
            {
                FileName = "shutdown.exe",
                Arguments = "/s /t 1",
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process.Start(ps);
        }
    }
}

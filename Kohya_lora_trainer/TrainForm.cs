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
        private Process? process;
        private bool ShutdownOnly;
        private Stopwatch? stopwatch;
        private int Duration = 60;
        private TrainCompleteAction TrainCompletedAction;

        public TrainForm(TrainCompleteAction act, bool shutdownOnly)
        {
            InitializeComponent();
            ShutdownOnly = shutdownOnly;
            TrainCompletedAction = act;
        }

        private void TrainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (TrainCompletedAction == TrainCompleteAction.Shutdown || TrainCompletedAction == TrainCompleteAction.Suspend)
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
                DialogResult result = MessageBox.Show("学習中のデータは失われます。よろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //メッセージボックスが出ている間に閉じたかもしれないので再度確認
                    if (process != null && !process.HasExited)
                    {
                        //Killしても閉じない・・・が.NET6.0にして解決
                        Debug.WriteLine("Try kill terminal: " + process.ProcessName);
                        process.Kill(true);
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
                if (!string.IsNullOrWhiteSpace(TrainParams.Current.CustomCommands))
                {
                    BatchProcess.LogText += "\r\nコマンド実行のみ。";
                }
                else if (failed)
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
                if (failed && string.IsNullOrWhiteSpace(TrainParams.Current.CustomCommands))
                {
                    BatchProcess.FailCount++;
                }
                Close();
                return;
            }

            if (TrainCompletedAction == TrainCompleteAction.ShowTimetaken && stopwatch != null)
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



            if (TrainCompletedAction == TrainCompleteAction.Shutdown || TrainCompletedAction == TrainCompleteAction.Suspend)
            {
                lblCountdown.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
                UpdateCountdownText();
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
                ShutdownOrSuspendPC();
                Close();
                //MessageBox.Show("ここでシャットダウンする", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Duration > 0)
            {
                Duration--;
                UpdateCountdownText();
            }
        }

        private void UpdateCountdownText()
        {
            switch (TrainCompletedAction)
            {
                case TrainCompleteAction.Shutdown:
                    lblCountdown.Text = Duration.ToString() + "秒後にシャットダウンします \n しない場合はこのウィンドウを閉じてください";
                    break;
                case TrainCompleteAction.Suspend:
                    lblCountdown.Text = Duration.ToString() + "秒後にスリープします \n しない場合はこのウィンドウを閉じてください";
                    break;
            }
        }

        private void ShutdownOrSuspendPC()
        {
            switch (TrainCompletedAction)
            {
                case TrainCompleteAction.Shutdown:
                    ProcessStartInfo ps = new ProcessStartInfo()
                    {
                        FileName = "shutdown.exe",
                        Arguments = "/s /t 1",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    Process.Start(ps);
                    break;
                case TrainCompleteAction.Suspend:
                    Application.SetSuspendState(PowerState.Suspend, false, false);
                    break;
            }
        }

        private void TrainForm_Shown(object sender, EventArgs e)
        {
            lblProcessingCaptions.Visible = false;

            if (ShutdownOnly && (TrainCompletedAction == TrainCompleteAction.Shutdown || TrainCompletedAction == TrainCompleteAction.Suspend))
            {
                btnCopyCmd.Enabled = false;
                btnStop.Enabled = false;
                btnClose.Enabled = true;
                lblCountdown.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
                UpdateCountdownText();
                return;
            }

            string tboard = MyUtils.GetDefaultDir("TensorboardDir");
            if (Directory.Exists(tboard))
            {
                btnTensorboard.Visible = true;
            }

            if (BatchProcess.LogResultText && BatchProcess.IsRunning)
            {
                StringBuilder ssb = new StringBuilder();
                ssb.Append(TrainParams.Current.OutputPath).Append("\\").Append(TrainParams.Current.OutputName).Append(".safetensors\r\n").Append("開始時刻: ").Append(DateTime.Now.ToString());

                BatchProcess.LogText += ssb.ToString();
            }
            if (BatchProcess.ShuffleCaptionsBeforeTraining && BatchProcess.IsRunning)
            {
                lblProcessingCaptions.Visible = true;
                Update();
            }

            BatchProcess.ShuffleCaptions();
            lblProcessingCaptions.Visible = false;
            btnStop.Enabled = true;
            btnClose.Enabled = false;
            if (BatchProcess.IsRunning)
                btnStop.Text = "バッチ処理の中止";


            StringBuilder sbCmd = new StringBuilder();

            if (TrainCompletedAction != TrainCompleteAction.None || BatchProcess.IsRunning)
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
                sbCmd.Append(Constants.CurrentSdScriptsPath);
            }

            sbCmd.Append(" && .\\venv\\Scripts\\activate && ");

            lblCountdown.Text = string.Empty;
            sbCmd.Append(MyUtils.GenerateCommands());

            if (TrainCompletedAction == TrainCompleteAction.ShowTimetaken || (BatchProcess.IsRunning && BatchProcess.LogResultText))
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

        private void btnTensorboard_Click(object sender, EventArgs e)
        {
            string tboard = MyUtils.GetDefaultDir("TensorboardDir");
            if (!Directory.Exists(tboard))
                return;
            StringBuilder sb = new StringBuilder();
            sb.Append("/k cd ");
            if (!string.IsNullOrEmpty(Form1.ScriptPath))
            {
                sb.Append("/d ").Append(Form1.ScriptPath);
            }
            else
            {
                sb.Append(Constants.CurrentSdScriptsPath);
            }

            sb.Append(" && .\\venv\\Scripts\\activate && tensorboard --logdir=\"").Append(tboard).Append("\"");

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = sb.ToString();

            Process.Start(ps);
        }
    }
}

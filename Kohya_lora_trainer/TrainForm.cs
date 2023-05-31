using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

            if (BenchMarkMode)
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
                    if (process == null || process.HasExited)
                        return;
                    process.Kill();
                    process.Dispose();
                    btnStop.Enabled = false;
                    btnClose.Enabled = true;
                    process = null;
                    BatchProcess.SkippedCount += BatchProcess.BatchStack.Count + 1;
                    BatchProcess.IsCancel = true;
                    BatchProcess.BatchStack.Clear();
                    BatchProcess.IsRunning = false;
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


            if(BatchProcess.IsRunning)
            {
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

                MessageBox.Show("経過時間: " + $"{hour}h{min}m" + sec.ToString("0.000s"), "結果", MessageBoxButtons.OK);
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
            Clipboard.SetText(TrainArgs);
        }

        private string GetBlockWeightCmd()
        {
            StringBuilder sb = new StringBuilder();
            if (TrainParams.Current.UseBlockWeight)
            {
                switch (TrainParams.Current.BlockWeightPresetTypeIn)
                {
                    case BlockWeightPresetType.none:
                        {
                            sb.Append(" \"down_lr_weight=");
                            for (int i = 0; i < 12; i++)
                            {
                                sb.Append((0.05f * TrainParams.Current.BlockWeightIn[i]).ToString());
                                if (i < 11)
                                    sb.Append(",");
                            }
                            sb.Append("\"");
                        }
                        break;
                    default:
                        {
                            sb.Append(" \"down_lr_weight=").Append(TrainParams.Current.BlockWeightPresetTypeIn.ToString());
                            if (TrainParams.Current.BlockWeightOffsetIn >= 0.25m)
                            {
                                sb.Append("+").Append(TrainParams.Current.BlockWeightOffsetIn.ToString());
                            }

                            sb.Append("\"");
                        }
                        break;
                }

                sb.Append(" \"mid_lr_weight=").Append((0.05f * TrainParams.Current.BlockWeightMid).ToString()).Append("\"");

                switch (TrainParams.Current.BlockWeightPresetTypeOut)
                {
                    case BlockWeightPresetType.none:
                        {
                            sb.Append(" \"up_lr_weight=");
                            for (int i = 0; i < 12; i++)
                            {
                                sb.Append((0.05f * TrainParams.Current.BlockWeightOut[i]).ToString());
                                if (i < 11)
                                    sb.Append(",");
                            }
                            sb.Append("\"");
                        }
                        break;
                    default:
                        {
                            sb.Append(" \"up_lr_weight=").Append(TrainParams.Current.BlockWeightPresetTypeOut.ToString());
                            if (TrainParams.Current.BlockWeightOffsetOut >= 0.25m)
                            {
                                sb.Append("+").Append(TrainParams.Current.BlockWeightOffsetOut.ToString());
                            }

                            sb.Append("\"");
                        }
                        break;
                }

                if (TrainParams.Current.BlockWeightZeroThreshold > 0)
                {
                    sb.Append(" \"block_lr_zero_threshold=").Append((0.05f * TrainParams.Current.BlockWeightZeroThreshold).ToString()).Append("\"");
                }
            }

            if (TrainParams.Current.UseBlockDim)
            {
                sb.Append(TrainParams.Current.UseConv2dExtend ? " \"conv_block_dims=" : " \"block_dims=");
                //DIM IN
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockDimIn[i]);
                    sb.Append(",");
                }
                //DIM MID
                sb.Append(TrainParams.Current.BlockDimMid).Append(",");

                //DIM OUT
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockDimOut[i]);
                    if (i < 11)
                        sb.Append(",");
                }
                sb.Append("\"");

                sb.Append(TrainParams.Current.UseConv2dExtend ? " \"conv_block_alphas=" : " \"block_alphas=");
                //ALPHA IN
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockAlphaInM[i]);
                    sb.Append(",");
                }
                //ALPHA MID
                sb.Append(TrainParams.Current.BlockAlphaMidM).Append(",");

                //ALPHA OUT
                for (int i = 0; i < 12; i++)
                {
                    sb.Append(TrainParams.Current.BlockAlphaOutM[i]);
                    if (i < 11)
                        sb.Append(",");
                }
                sb.Append("\"");
            }

            return sb.ToString();
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

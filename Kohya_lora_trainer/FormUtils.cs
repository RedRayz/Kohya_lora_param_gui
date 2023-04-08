using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Shell;

namespace Kohya_lora_trainer {
    public partial class FormUtils : Form {
        private delegate void UpdateUIEventHandler(string text);
        private delegate void DelegateEnableButton();

        private event UpdateUIEventHandler UpdateUI = null;
        private Process process = null;

        public FormUtils() {
            InitializeComponent();
        }

        private void btnCheckCorrupt_Click(object sender, EventArgs e) {
            string path = string.IsNullOrEmpty(Form1.ScriptPath) ? "..\\" : Form1.ScriptPath + "\\";
            if (!Directory.Exists(path + "venv")) {
                MessageBox.Show("venvのあるsd-scriptsフォルダが見つかりません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if(!File.Exists(path + "fix_position_ids.py")) {
                MessageBox.Show("fix_position_ids.pyが見つかりません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SD Model(*.ckpt;*.safetensors)|*.ckpt;*.safetensors";
            ofd.Title = "確認するモデルの選択";
            ofd.RestoreDirectory = true;
            if(ofd.ShowDialog() == DialogResult.OK) {
                if (ofd.FileName.Contains(" ")) {
                    MessageBox.Show("空白を含むパスは使用できません。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                StringBuilder sb = new StringBuilder();
                sb.Append("/c cd ");
                if (!string.IsNullOrEmpty(Form1.ScriptPath)) {
                    sb.Append("/d ").Append(Form1.ScriptPath);
                }
                else {
                    sb.Append(@"..\");
                }

                sb.Append(" && .\\venv\\Scripts\\activate && python fix_position_ids.py --model \"").Append(ofd.FileName).Append("\"");
                btnCheckCorrupt.Enabled = false;
                btnRunTensorboard.Enabled = false;
                lblTipNeedScript.Text = "読込中...";
                tbxConsoleOutput.Text = string.Empty;
                UpdateUI = new UpdateUIEventHandler(UpdateConsoleText);


                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd";
                ps.Arguments = sb.ToString();
                ps.UseShellExecute = false;
                ps.RedirectStandardOutput = true;
                ps.CreateNoWindow = true;
                process = new Process();
                process.SynchronizingObject = this;
                process.EnableRaisingEvents = true;
                process.Exited += ProcessExited;
                process.StartInfo = ps;
                process.OutputDataReceived += OnGetStdOut;
                process.Start();
                process.BeginOutputReadLine();
            }

        }

        private void btnRunTensorboard_Click(object sender, EventArgs e) {
            string path = string.IsNullOrEmpty(Form1.ScriptPath) ? "..\\" : Form1.ScriptPath + "\\";
            if (!Directory.Exists(path + "venv")) {
                MessageBox.Show("venvのあるsd-scriptsフォルダが見つかりません。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "ログディレクトリの選択";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;
            if(cof.ShowDialog() == CommonFileDialogResult.Ok) {
                StringBuilder sb = new StringBuilder();
                sb.Append("/c cd ");
                if (!string.IsNullOrEmpty(Form1.ScriptPath)) {
                    sb.Append("/d ").Append(Form1.ScriptPath);
                }
                else {
                    sb.Append(@"..\");
                }

                sb.Append(" && .\\venv\\Scripts\\activate && tensorboard --logdir=\"").Append(cof.FileName).Append("\"");

                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd";
                ps.Arguments = sb.ToString();

                Process.Start(ps);
            }
        }

        private void FormUtils_Load(object sender, EventArgs e) {
            tbxConsoleOutput.Text = string.Empty;
        }

        private void OnGetStdOut(object sender, DataReceivedEventArgs e) {
            Invoke(UpdateUI, e.Data);
        }

        private void UpdateConsoleText(string text) {
            //テキストボックスでの改行コードは\r\nなので注意
            tbxConsoleOutput.Text += text + "\r\n";
        }

        private void FormUtils_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                if(process != null) {
                    if(!process.HasExited)
                        process.Kill();
                    process.Close();
                    process.Dispose();
                }
            }catch { 

            }
        }

        private void ProcessExited(object sender, EventArgs e) {
            if (process != null) {
                process.Close();
                process.Dispose();
                process = null;
            }

            if (InvokeRequired) {
                Invoke(new DelegateEnableButton(EnableButtons));
            }
            else {
                EnableButtons();
            }
        }
        private void EnableButtons() {
            btnCheckCorrupt.Enabled = true;
            btnRunTensorboard.Enabled = true;
            lblTipNeedScript.Text = "sd-scripts内にfix_position_ids.pyが必要です";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://note.com/bbcmc/n/n12c05bf109cc");
        }
    }
}

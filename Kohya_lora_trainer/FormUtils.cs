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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Shell;

namespace Kohya_lora_trainer
{
    public partial class FormUtils : Form
    {
        private delegate void UpdateUIEventHandler(string text);
        private delegate void DelegateEnableButton();

        private event UpdateUIEventHandler? UpdateUI = null;
        private Process? process = null;

        public FormUtils()
        {
            InitializeComponent();
        }


        private void btnRunTensorboard_Click(object sender, EventArgs e)
        {
            string path = string.IsNullOrEmpty(Form1.ScriptPath) ? Constants.CurrentSdScriptsPath : Form1.ScriptPath + "\\";
            if (!Directory.Exists(path + "venv"))
            {
                MessageBox.Show("venvのあるsd-scriptsフォルダが見つかりません。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "ログディレクトリの選択";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;
            if (Directory.Exists(MyUtils.GetDefaultDir("TensorboardDir")))
            {
                cof.InitialDirectory = MyUtils.GetDefaultDir("TensorboardDir");
            }

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
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

                sb.Append(" && .\\venv\\Scripts\\activate && tensorboard --logdir=\"").Append(cof.FileName).Append("\"");

                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd";
                ps.Arguments = sb.ToString();

                Process.Start(ps);
            }
        }

        private void btnSelectModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Safetensors(*.safetensors)|*.safetensors";
            ofd.Title = "Select a LoRA model";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblLoraPath.Text = ofd.FileName;
            }
        }

        private void btnResizeDim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblLoraPath.Text))
            {
                MessageBox.Show("変更するLoRAを指定してください", "おしらせ", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(lblOutputPath.Text))
            {
                var res = MessageBox.Show("リサイズ後に変換元を上書きします。よろしいですか。", "確認", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    MyUtils.ResizeLora(lblLoraPath.Text, lblLoraPath.Text, nudTargetDim.Value, 0, cbxCudaConversion.Checked);
                }

            }
            else
            {
                MyUtils.ResizeLora(lblLoraPath.Text, lblOutputPath.Text, nudTargetDim.Value, 0, cbxCudaConversion.Checked);
            }

        }



        private void btnSelectOutputPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "NewLoRA.safetensors";
            sfd.Filter = "Safetensors(*.safetensors)|*.safetensors";
            sfd.Title = "Path to save a lora";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                lblOutputPath.Text = sfd.FileName;
            }
        }

        private void FormUtils_Load(object sender, EventArgs e)
        {
            lblOutputPath.Text = string.Empty;
            lblLoraPath.Text = string.Empty;
            cbxPythonVersion.SelectedIndex = 0;
            cbxPythonVersion.Update();
        }

        private void btnUpdateRepo_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("sd-scriptsの更新をします。よろしいですか。", "確認", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string path = string.IsNullOrEmpty(Form1.ScriptPath) ? Constants.CurrentSdScriptsPath : Form1.ScriptPath + "\\";
                if (!Directory.Exists(path + "venv"))
                {
                    MessageBox.Show("venvのあるsd-scriptsフォルダが見つかりません。", "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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

                if (!cbxUpdateOnlyPackage.Checked)
                {
                    sb.Append(" && git pull");
                }


                sb.Append(" && .\\venv\\Scripts\\activate && pip install --use-pep517 --upgrade -r requirements.txt");

                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd";
                ps.Arguments = sb.ToString();

                Process.Start(ps);
            }
        }

        private void btnInstallExtension_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("LyCORISなどのインストールをします。よろしいですか。", "確認", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string path = string.IsNullOrEmpty(Form1.ScriptPath) ? Constants.CurrentSdScriptsPath : Form1.ScriptPath + "\\";
                if (!Directory.Exists(path + "venv"))
                {
                    MessageBox.Show("venvのあるsd-scriptsフォルダが見つかりません。", "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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

                sb.Append(" && .\\venv\\Scripts\\activate && pip install -U dadaptation lycoris_lora came-pytorch scipy prodigy-plus-schedule-free && pip install numpy==1.26.4");

                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd";
                ps.Arguments = sb.ToString();

                Process.Start(ps);
            }
        }

        private void btnRegenVenv_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("vnevの再生成をします。よろしいですか。", "確認", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (Directory.Exists(Constants.CurrentSdScriptsPath + @"venv"))
                {
                    MessageBox.Show("Pythonの仮想環境(venv)がすでに存在します。\r\n先にvenvフォルダを消去してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StringBuilder sb = new StringBuilder();
                sb.Append(@"/k cd ").Append(Constants.CurrentSdScriptsPath);

                string py = cbxPythonVersion.SelectedIndex == 0 ? "py -3.10" : "py -3.11";
                sb.Append(@" && ").Append(cbxUsePy.Checked ? py : "python").Append(" -m venv venv && .\\venv\\Scripts\\activate && ").Append(MyUtils.GenerateMinInstallCommands(cbxUseLatestTorch.Checked));
                sb.Append(" && ");

                sb.Append("pip install dadaptation lycoris_lora && pip install numpy==1.26.4");
                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd";
                ps.Arguments = sb.ToString();
                var process = new Process();
                process.StartInfo = ps;
                process.Start();
            }
        }

        private void btnClearResizeOutput_Click(object sender, EventArgs e)
        {
            lblOutputPath.Text = string.Empty;
        }

        private void btnDeleteNpz_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "npzが入ったディレクトリの選択";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;
            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lblProcessingNpz.Visible = true;
                Update();
                int removedCnt = 0;
                int errorCount = 0;
                string? path = cof.FileName;

                if (string.IsNullOrEmpty(path))
                    return;

                if (MyUtils.IsSystemDirectory(path))
                {
                    MessageBox.Show("OS関連のディレクトリは指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string[] files = Directory.GetFiles(path);
                //直下にあるnpzの消去
                foreach (string file in files)
                {
                    try
                    {
                        string ext = Path.GetExtension(file).ToLower();
                        if (ext == ".npz")
                        {
                            File.Delete(file);
                            removedCnt++;
                        }
                    }
                    catch
                    {
                        errorCount++;
                    }
                }

                //サブディレクトリ内のnpzの消去
                string[] subDirs = Directory.GetDirectories(path);
                foreach (string dir in subDirs)
                {
                    files = Directory.GetFiles(dir);
                    foreach (string file in files)
                    {
                        try
                        {
                            string ext = Path.GetExtension(file).ToLower();
                            if (ext == ".npz")
                            {
                                File.Delete(file);
                                removedCnt++;
                            }
                        }
                        catch
                        {
                            errorCount++;
                        }
                    }
                }

                lblProcessingNpz.Visible = false;

                if (removedCnt > 0)
                {
                    if (errorCount == 0)
                    {
                        MessageBox.Show($"{removedCnt}件のキャッシュを消去しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show($"{removedCnt}件のキャッシュを消去し、\n{errorCount}件がエラーで失敗しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                    MessageBox.Show("対象のファイルはありません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbxUsePy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSwitchBranch_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Constants.CurrentSdScriptsPath))
            {
                MessageBox.Show("sd-scriptsがみつかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string branch = tbxBranchName.Text.Trim();
            Regex regex = new Regex(@"^[-A-Za-z0-9_]*$");
            if (string.IsNullOrEmpty(branch))
            {
                MessageBox.Show("ブランチ名を指定してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (branch.Contains(' ') || !regex.IsMatch(branch))
            {
                MessageBox.Show("英字、数字と-_以外は使用できません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show("ブランチを変更します。よろしいですか。", "確認", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                btnSwitchBranch.Enabled = false;
                lblSwitching.Visible = true;
                Update();
                //GUI側でブランチは確認しないので常にリモートから引っ張ってくる
                //エラーになるとその後ろのコマンドがスルーされるので、別プロセスでgit switchする
                StringBuilder sb = new StringBuilder();
                sb.Append(@"/c cd ").Append(Constants.CurrentSdScriptsPath);

                sb.Append(@" && git fetch && git branch ")
                    .Append(branch)
                    .Append(" origin/").Append(branch);
                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd";
                ps.Arguments = sb.ToString();
                var process = new Process();
                process.StartInfo = ps;
                process.SynchronizingObject = this;
                process.EnableRaisingEvents = true;
                process.Exited += GitBranchExited;
                process.Start();
            }
        }

        private void GitBranchExited(object? sender, EventArgs e)
        {
            Thread.Sleep(200);
            StringBuilder sb = new StringBuilder();
            sb.Append(@"/c cd ").Append(Constants.CurrentSdScriptsPath)
                .Append(@" && git switch ").Append(tbxBranchName.Text);
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = sb.ToString();
            var process = new Process();
            process.StartInfo = ps;
            process.SynchronizingObject = this;
            process.EnableRaisingEvents = true;
            process.Exited += GitSwitchExited;
            process.Start();
        }

        private void GitSwitchExited(object? sender, EventArgs e)
        {
            btnSwitchBranch.Enabled = true;
            lblSwitching.Visible = false;
            Update();
            MessageBox.Show("切り替えが終了しました。\n切り替わらない場合は手動で切り替えてください。");
        }

    }
}

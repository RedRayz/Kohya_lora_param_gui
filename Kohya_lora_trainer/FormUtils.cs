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


        private void btnRunTensorboard_Click(object sender, EventArgs e) {
            string path = string.IsNullOrEmpty(Form1.ScriptPath) ? Constants.CurrentSdScriptsPath : Form1.ScriptPath + "\\";
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
            if (string.IsNullOrEmpty(lblLoraPath.Text) || string.IsNullOrEmpty(lblOutputPath.Text))
            {
                MessageBox.Show("変更するモデルと出力先の両方を指定してください", "おしらせ", MessageBoxButtons.OK);
                return;
            }

            MyUtils.ResizeLora(lblLoraPath.Text, lblOutputPath.Text, nudTargetDim.Value, cbxCudaConversion.Checked);
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
        }

        private void btnUpdateRepo_Click(object sender, EventArgs e)
        {
            string path = string.IsNullOrEmpty(Form1.ScriptPath) ? Constants.CurrentSdScriptsPath : Form1.ScriptPath + "\\";
            if (!Directory.Exists(path + "venv"))
            {
                MessageBox.Show("venvのあるsd-scriptsフォルダが見つかりません。", "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("/c cd ");
            if (!string.IsNullOrEmpty(Form1.ScriptPath))
            {
                sb.Append("/d ").Append(Form1.ScriptPath);
            }
            else
            {
                sb.Append(Constants.CurrentSdScriptsPath);
            }

            sb.Append(" && git pull && .\\venv\\Scripts\\activate && pip install --use-pep517 --upgrade -r requirements.txt");

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = sb.ToString();

            Process.Start(ps);
        }

        private void btnInstallExtension_Click(object sender, EventArgs e)
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

            sb.Append(" && .\\venv\\Scripts\\activate && pip install -U prodigyopt dadaptation lion-pytorch lycoris_lora");

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = sb.ToString();

            Process.Start(ps);
        }

        private void btnInstallLeco_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("LECOのインストールをします。よろしいですか。", "確認", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                if (Directory.Exists(Constants.LecoPath))
                {
                    MessageBox.Show("すでにLECOフォルダがあります。\n再インストールする場合はLECOフォルダを削除してください。", "確認", MessageBoxButtons.OK);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(@"/c cd ..\");


                    sb.Append(@" && git clone https://github.com/p1atdev/LECO.git && cd .\LECO && python -m venv venv && .\venv\Scripts\activate && pip install torch torchvision --index-url https://download.pytorch.org/whl/cu118");
                    sb.Append(@" && pip install xformers omegaconf && pip install --upgrade -r requirements.txt");

                    ProcessStartInfo ps = new ProcessStartInfo();
                    ps.FileName = "cmd";
                    ps.Arguments = sb.ToString();

                    Process.Start(ps);
                }


            }
        }

        private void btnRunLeco_Click(object sender, EventArgs e)
        {
            string path = Constants.LecoPath;
            if (!Directory.Exists(path + "venv"))
            {
                MessageBox.Show("venvのあるLECOフォルダが見つかりません。", "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "YAML(*.yaml)|*.yaml";
            ofd.Title = "Select a config";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("/k cd ").Append(Constants.LecoPath);


                sb.Append(" && .\\venv\\Scripts\\activate && python .\\train_lora.py --config_file \"").Append(ofd.FileName).Append("\"");

                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd";
                ps.Arguments = sb.ToString();

                Process.Start(ps);
            }

        }

        private void btnUpdateLeco_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("LECOの更新をします。よろしいですか。", "確認", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (!Directory.Exists(Constants.LecoPath + "venv"))
                {
                    MessageBox.Show("venvのあるLECOフォルダが見つかりません。", "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                StringBuilder sb = new StringBuilder();
                sb.Append("/c cd ").Append(Constants.LecoPath);


                sb.Append(" && git pull && .\\venv\\Scripts\\activate && pip install --use-pep517 --upgrade -r requirements.txt");

                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd";
                ps.Arguments = sb.ToString();

                Process.Start(ps);
            }
        }
    }
}

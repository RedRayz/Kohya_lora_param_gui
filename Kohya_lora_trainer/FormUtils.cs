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

namespace Kohya_lora_trainer
{
    public partial class FormUtils : Form
    {
        private delegate void UpdateUIEventHandler(string text);
        private delegate void DelegateEnableButton();

        private event UpdateUIEventHandler UpdateUI = null;
        private Process process = null;

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
            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
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

        private void btnRunTagger_Click(object sender, EventArgs e)
        {
            string path = string.IsNullOrEmpty(Form1.ScriptPath) ? Constants.CurrentSdScriptsPath : Form1.ScriptPath + "\\";
            if (!Directory.Exists(path + "venv"))
            {
                MessageBox.Show("venvのあるsd-scriptsフォルダが見つかりません。", "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!Directory.Exists(lblTaggerDir.Text))
            {
                MessageBox.Show("尋問するディレクトリが見つかりません。", "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //.Append(nudTaggerBatchSize.Value.ToString())
            sb.Append(" && .\\venv\\Scripts\\activate && python .\\finetune\\tag_images_by_wd14_tagger.py --remove_underscore --undesired_tags \"").Append(tbxTaggerExclude.Text).Append("\" --thresh ").Append(nudThresh.Value.ToString())
                .Append(" --batch_size ").Append(nudTaggerBatchSize.Value.ToString()).Append(" ").Append(lblTaggerDir.Text);

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = sb.ToString();

            Process.Start(ps);
        }

        private void btnTaggetSelectDir_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "ログディレクトリの選択";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;
            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lblTaggerDir.Text = cof.FileName;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Kohya_lora_trainer
{
    public partial class FormLECO : Form
    {
        public FormLECO()
        {
            InitializeComponent();
        }

        private void FormLECO_Load(object sender, EventArgs e)
        {
            cbxAction.SelectedIndex = 0;
            cbxNoiseScheduler.SelectedIndex = 0;
            cbxSavePrecision.SelectedIndex = 0;
            cbxTrainPrecision.SelectedIndex = 0;
            cbxType.SelectedIndex = 0;
            cbxMethod.SelectedIndex = 0;
        }

        //ポンコツWinDefenderにマルウェア判定食らってるっぽい？
        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            float lr = 0;
            if (!float.TryParse(tbxLR.Text, out lr))
            {
                MessageBox.Show("LRが不適切です。正しい値を入力してください。", "おしらせ", MessageBoxButtons.OK);
                return;
            }


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "config.yaml";
            sfd.Filter = "YAML(*.yaml)|*.yaml";
            sfd.Title = "Save a config.yaml";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("prompts_file: \"").Append(tbxPromptPath.Text).Append("\"\r\n\r\npretrained_model:\r\n")
    .Append("  name_or_path: \"").Append(tbxModelPath.Text).Append("\"\r\n")
    .Append("  v2: ").Append(cbxUseSDV2.Checked.ToString().ToLower()).Append("\r\n")
    .Append("  v_pred: ").Append(cbxUseVPrediction.Checked.ToString().ToLower()).Append("\r\n\r\nnetwork:\r\n")
    .Append("  type: \"").Append(cbxType.SelectedIndex == 0 ? "lierla" : "c3lier").Append("\"\r\n")
    .Append("  rank: ").Append(nudDim.Value.ToString()).Append("\r\n")
    .Append("  alpha: ").Append(nudAlpha.Value.ToString()).Append("\r\n")
    .Append("  training_method: \"");

                switch (cbxMethod.SelectedIndex)
                {
                    case 0:
                        sb.Append("full\"");
                        break;
                    case 1:
                        sb.Append("selfattn\"");
                        break;
                    case 2:
                        sb.Append("xattn\"");
                        break;
                    case 3:
                        sb.Append("noxattn\"");
                        break;
                    case 4:
                        sb.Append("innoxattn\"");
                        break;
                }

                sb.Append("\r\n\r\ntrain:\r\n");

                sb.Append("  precision: \"");

                switch (cbxTrainPrecision.SelectedIndex)
                {
                    case 0:
                        sb.Append("float32\"");
                        break;
                    case 1:
                        sb.Append("bfloat16\"");
                        break;
                    case 2:
                        sb.Append("float16\"");
                        break;
                }
                sb.Append("\r\n  noise_scheduler: \"");

                switch (cbxNoiseScheduler.SelectedIndex)
                {
                    case 0:
                        sb.Append("ddim\"");
                        break;
                    case 1:
                        sb.Append("ddpm\"");
                        break;
                    case 2:
                        sb.Append("lms\"");
                        break;
                    case 3:
                        sb.Append("euler_a\"");
                        break;
                }

                sb.Append("\r\n");

                sb.Append("  iterations: ").Append(nudSteps.Value.ToString()).Append("\r\n")
                    .Append("  lr: ").Append(lr.ToString("g")).Append("\r\n")
                    .Append("  optimizer: \"").Append(tbxOptimizer.Text).Append("\"\r\n")
                    .Append("  lr_scheduler: \"").Append(tbxLRScheduler.Text).Append("\"\r\n")
                    .Append("  max_denoising_steps: ").Append(nudMaxDenoiseSteps.Value.ToString()).Append("\r\n\r\nsave:\r\n")
                    .Append("  name: \"").Append(tbxOutputName.Text).Append("\"\r\n")
                    .Append("  path: \"").Append(tbxOutputPath.Text).Append("\"\r\n")
                    .Append("  per_steps: ").Append(nudSaveEveryNSteps.Value.ToString()).Append("\r\n")
                    .Append("  precision: \"");

                switch (cbxSavePrecision.SelectedIndex)
                {
                    case 0:
                        sb.Append("float16\"");
                        break;
                    case 1:
                        sb.Append("float32\"");
                        break;
                    case 2:
                        sb.Append("bfloat16\"");
                        break;
                }
                sb.Append("\r\n\r\nlogging:\r\n")
                    .Append("  use_wandb: ").Append(cbxUseWandb.Checked.ToString().ToLower()).Append("\r\n")
                    .Append("  verbose: ").Append(cbxVerbose.Checked.ToString().ToLower()).Append("\r\n\r\nother:\r\n")
                    .Append("  use_xformers: ").Append(cbxUseXformers.Checked.ToString().ToLower());

                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(false)))
                    {
                        sw.WriteLine(sb.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("エラーで保存できません。\r\n" + ex.Message, "おしらせ", MessageBoxButtons.OK);
                }
            }
        }

        private void btnSavePrompts_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "prompts.yaml";
            sfd.Filter = "YAML(*.yaml)|*.yaml";
            sfd.Title = "Save a prompts.yaml";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("- target: \"").Append(tbxTarget.Text).Append("\"\r\n")
                    .Append("  positive: \"").Append(tbxPositive.Text).Append("\"\r\n")
                    .Append("  unconditional: \"").Append(tbxNegative.Text).Append("\"\r\n")
                    .Append("  neutral: \"").Append(tbxNegative.Text).Append("\"\r\n")
                    .Append("  action: \"").Append(cbxAction.SelectedIndex == 0 ? "erase" : "enhance").Append("\"\r\n")
                    .Append("  guidance_scale: ").Append(nudGuidanceScale.Value.ToString()).Append("\r\n")
                    .Append("  resolution: ").Append(nudResolution.Value.ToString()).Append("\r\n")
                    .Append("  batch_size: ").Append(nudBatchSize.Value.ToString());

                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(false)))
                    {
                        sw.WriteLine(sb.ToString());
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("エラーで保存できません。\r\n" + ex.Message, "おしらせ", MessageBoxButtons.OK);
                }
            }
        }

        private void btnInstallLECO_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("LECOのインストールをします。よろしいですか。", "確認", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (Directory.Exists(Constants.LecoPath))
                {
                    MessageBox.Show("すでにLECOフォルダがあります。\n再インストールする場合はLECOフォルダを削除してください。", "確認", MessageBoxButtons.OK);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(@"/c cd ..\");


                    sb.Append(@" && git clone https://github.com/p1atdev/LECO.git && cd .\LECO && python -m venv venv && .\venv\Scripts\activate && pip install torch==2.0.1+cu118 torchvision==0.15.2+cu118 --index-url https://download.pytorch.org/whl/cu118");
                    sb.Append(@" && pip install xformers==0.0.20 omegaconf && pip install --upgrade -r requirements.txt");

                    ProcessStartInfo ps = new ProcessStartInfo();
                    ps.FileName = "cmd";
                    ps.Arguments = sb.ToString();

                    Process.Start(ps);
                }
            }
        }

        private void btnTrainLECO_Click(object sender, EventArgs e)
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

        private void btnUpdateLECO_Click(object sender, EventArgs e)
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

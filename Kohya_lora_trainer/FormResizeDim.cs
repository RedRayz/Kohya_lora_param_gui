using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Kohya_lora_trainer
{
    public partial class FormResizeDim : Form
    {
        public FormResizeDim()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblModelPath.Text) || string.IsNullOrEmpty(lblOutputPath.Text))
            {
                MessageBox.Show("変更するモデルと出力先の両方を指定してください", "おしらせ", MessageBoxButtons.OK);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(@"/c cd ");
            if (!string.IsNullOrEmpty(Form1.ScriptPath))
            {
                sb.Append("/d ").Append(Form1.ScriptPath);
            }
            else
            {
                sb.Append("..\\");
            }

            sb.Append(" && .\\venv\\Scripts\\activate && ");

            sb.Append("python .\\networks\\resize_lora.py").Append("  --model=\"").Append(lblModelPath.Text).Append("\"")
                .Append("  --save_to=\"").Append(lblOutputPath.Text).Append("\"").Append("  --save_precision=\"fp16\"")
                .Append("  --new_rank=").Append(nudDimSize.Value.ToString());

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = sb.ToString();
            var process = new Process();
            process.StartInfo = ps;
            process.Start();
        }

        private void btnSelectModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Safetensors(*.safetensors)|*.safetensors";
            ofd.Title = "Select a LoRA model";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblModelPath.Text = ofd.FileName;
            }
        }

        private void btnPathToSave_Click(object sender, EventArgs e)
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
    }
}

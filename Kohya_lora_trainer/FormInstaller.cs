using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Kohya_lora_trainer
{
    public partial class FormInstaller : Form
    {
        public FormInstaller()
        {
            InitializeComponent();
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select install directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;
            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                btnInstall.Enabled = false;

                RunInstall(cof.FileName);
            }
        }

        private void RunInstall(string path)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"/k cd /d ").Append(path);
            string py = cbxPythonVersion.SelectedIndex == 0 ? "py -3.10" : "py -3.11";
            sb.Append(@" && git clone https://github.com/kohya-ss/sd-scripts.git && cd sd-scripts && git checkout -b sd3 origin/sd3 && ")
                .Append(cbxUsePy.Checked ? py : "python").Append(" -m venv venv && .\\venv\\Scripts\\activate && ").Append(MyUtils.GenerateMinInstallCommands(cbxUseLatestTorch.Checked));

            sb.Append(" && ");

            sb.Append("pip install dadaptation lycoris_lora came-pytorch prodigy-plus-schedule-free && pip install numpy==1.26.4 && ").Append("accelerate config");
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = sb.ToString();
            var process = new Process();
            process.StartInfo = ps;
            process.Start();
        }

        private void FormInstaller_Load(object sender, EventArgs e)
        {
            cbxPythonVersion.SelectedIndex = 0;
            cbxPythonVersion.Update();
        }
    }
}

﻿using System;
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

            sb.Append(@" && git clone https://github.com/kohya-ss/sd-scripts.git && cd sd-scripts && python -m venv venv && .\venv\Scripts\activate && pip install torch==2.0.1+cu118 torchvision==0.15.2+cu118 --index-url https://download.pytorch.org/whl/cu118 && pip install bitsandbytes==0.41.1 --prefer-binary --extra-index-url=https://jllllll.github.io/bitsandbytes-windows-webui && pip install --upgrade -r requirements.txt && pip install xformers==0.0.20 && ");
            sb.Append("pip install prodigyopt dadaptation lion-pytorch lycoris_lora && ").Append("accelerate config");
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = sb.ToString();
            var process = new Process();
            process.StartInfo = ps;
            process.Start();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

#pragma warning disable CA1416
namespace Kohya_lora_trainer
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnSelectModel_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select a directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbxModel.Text = cof.FileName;
            }
        }

        private void brnClearModel_Click(object sender, EventArgs e)
        {
            tbxModel.Text = string.Empty;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select a directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbxImage.Text = cof.FileName;
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            tbxImage.Text = string.Empty;
        }

        private void btnSelectRegImage_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select a directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbxRegImage.Text = cof.FileName;
            }
        }

        private void btnClearRegImage_Click(object sender, EventArgs e)
        {
            tbxRegImage.Text = string.Empty;
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select a directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbxOutput.Text = cof.FileName;
            }
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            tbxOutput.Text = string.Empty;
        }

        private void btnSelectPreset_Click(object sender, EventArgs e)
        {

        }

        private void btnClearPreset_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelectVAE_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select a directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbxVAE.Text = cof.FileName;
            }
        }

        private void btnClearVAE_Click(object sender, EventArgs e)
        {
            tbxVAE.Text = string.Empty;
        }

        private void btnSelectTensorboard_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select a directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbxTensorboard.Text = cof.FileName;
            }
        }

        private void btnClearTensorboard_Click(object sender, EventArgs e)
        {
            tbxTensorboard.Text = string.Empty;
        }

        private void btnSelectConfig_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select a directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbxConfig.Text = cof.FileName;
            }
        }

        private void btnClearConfig_Click(object sender, EventArgs e)
        {
            tbxConfig.Text = string.Empty;
        }

        private void btnDiscardAndClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApplyAndClose_Click(object sender, EventArgs e)
        {
            MyUtils.SetDefaultDir("ModelDir", tbxModel.Text);
            MyUtils.SetDefaultDir("ImageDir", tbxImage.Text);
            MyUtils.SetDefaultDir("RegImageDir", tbxRegImage.Text);
            MyUtils.SetDefaultDir("OutputDir", tbxOutput.Text);
            MyUtils.SetDefaultDir("LoadPresetDir", tbxLoadPreset.Text);
            MyUtils.SetDefaultDir("SavePresetDir", tbxSavePreset.Text);
            MyUtils.SetDefaultDir("VAEDir", tbxVAE.Text);
            MyUtils.SetDefaultDir("TensorboardDir", tbxTensorboard.Text);
            MyUtils.SetDefaultDir("ConfigDir", tbxConfig.Text);
            MyUtils.SetDefaultDir("LoRADir", tbxLoRA.Text);

            MyUtils.SaveDefaultDirSettings();

            Properties.Settings.Default.Save();
            Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            tbxModel.Text = MyUtils.GetDefaultDir("ModelDir");
            tbxImage.Text = MyUtils.GetDefaultDir("ImageDir");
            tbxRegImage.Text = MyUtils.GetDefaultDir("RegImageDir");
            tbxOutput.Text = MyUtils.GetDefaultDir("OutputDir");
            tbxLoadPreset.Text = MyUtils.GetDefaultDir("LoadPresetDir");
            tbxSavePreset.Text = MyUtils.GetDefaultDir("SavePresetDir");
            tbxVAE.Text = MyUtils.GetDefaultDir("VAEDir");
            tbxTensorboard.Text = MyUtils.GetDefaultDir("TensorboardDir");
            tbxConfig.Text = MyUtils.GetDefaultDir("ConfigDir");
            tbxLoRA.Text = MyUtils.GetDefaultDir("LoRADir");
        }

        private void btnLoRA_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select a directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbxLoRA.Text = cof.FileName;
            }
        }

        private void btnClearLoRA_Click(object sender, EventArgs e)
        {
            tbxLoRA.Text = string.Empty;
        }

        private void btnSelectSavePreset_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select a directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbxSavePreset.Text = cof.FileName;
            }
        }

        private void btnClearSavePreset_Click(object sender, EventArgs e)
        {
            tbxSavePreset.Text = string.Empty;
        }

        private void btnSelectLoadPreset_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select a directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbxLoadPreset.Text = cof.FileName;
            }
        }

        private void btnClearLoadPreset_Click(object sender, EventArgs e)
        {
            tbxLoadPreset.Text = string.Empty;
        }
    }
}

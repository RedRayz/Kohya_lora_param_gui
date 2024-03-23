using System;
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
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select a directory";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbxPreset.Text = cof.FileName;
            }
        }

        private void btnClearPreset_Click(object sender, EventArgs e)
        {
            tbxPreset.Text = string.Empty;
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
            Properties.Settings.Default.DefaultModelDir = tbxModel.Text;
            Properties.Settings.Default.DefaultImageDir = tbxImage.Text;
            Properties.Settings.Default.DefaultRegImageDir = tbxRegImage.Text;
            Properties.Settings.Default.DefaultOutputDir = tbxOutput.Text;
            Properties.Settings.Default.DefaultPresetDir = tbxPreset.Text;
            Properties.Settings.Default.DefaultVAEDir = tbxVAE.Text;
            Properties.Settings.Default.DefaultTensorboardDir = tbxTensorboard.Text;
            Properties.Settings.Default.DefaultConfigDir = tbxConfig.Text;

            Properties.Settings.Default.Save();
            Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            tbxModel.Text = Properties.Settings.Default.DefaultModelDir;
            tbxImage.Text = Properties.Settings.Default.DefaultImageDir;
            tbxRegImage.Text = Properties.Settings.Default.DefaultRegImageDir;
            tbxOutput.Text = Properties.Settings.Default.DefaultOutputDir;
            tbxPreset.Text = Properties.Settings.Default.DefaultPresetDir;
            tbxVAE.Text = Properties.Settings.Default.DefaultVAEDir;
            tbxTensorboard.Text = Properties.Settings.Default.DefaultTensorboardDir;
            tbxConfig.Text = Properties.Settings.Default.DefaultConfigDir;
        }
    }
}

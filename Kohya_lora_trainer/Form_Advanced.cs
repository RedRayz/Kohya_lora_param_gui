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
using Microsoft.WindowsAPICodePack.Shell;

namespace Kohya_lora_trainer {
    public partial class Form_Advanced : Form {
        public Form_Advanced() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(tbxTextEncoLR.Text)) {
                float lr = -1f;
                if (float.TryParse(tbxTextEncoLR.Text, out lr)) {
                    if (lr <= 0f || float.IsNaN(lr) || float.IsInfinity(lr)) {
                        MessageBox.Show("TextEncoder LRに0以下、NaN、無限は指定できません", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else {
                        TrainParams.Current.TextEncoderLR = lr;
                    }
                }
                else {
                    MessageBox.Show("TextEncoder LRの値が間違っています", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else {
                TrainParams.Current.TextEncoderLR = -1;
            }

            if (!string.IsNullOrEmpty(tbxUnetLR.Text)) {
                float lr = -1f;
                if (float.TryParse(tbxUnetLR.Text, out lr)) {
                    if (lr <= 0f || float.IsNaN(lr) || float.IsInfinity(lr)) {
                        MessageBox.Show("UNet LRに0以下、NaN、無限は指定できません", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else {
                        TrainParams.Current.UnetLR = lr;
                    }
                }
                else {
                    MessageBox.Show("UNet LRの値が間違っています", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else {
                TrainParams.Current.UnetLR -= 1;
            }


            TrainParams.Current.CpuThreads = tbrCpuThreads.Value;
            TrainParams.Current.SchedulerType = (SchedulerType)Enum.ToObject(typeof(SchedulerType), cbxScheduler.SelectedIndex);
            TrainParams.Current.SavePrecision = (SavePrecision)Enum.ToObject(typeof(SavePrecision), cbxPrecision.SelectedIndex);
            TrainParams.Current.MinBucketResolution = (int)nudMinBucketReso.Value;
            TrainParams.Current.MaxBucketResolution = (int)nudMaxBucketReso.Value;
            TrainParams.Current.NoBucketUpscaling = cbxNoUpscale.Checked;
            TrainParams.Current.UseWarmupInit = cbxUseWarmupInit.Checked;
            TrainParams.Current.ClipSkip = (int)nudClipSkip.Value;
            TrainParams.Current.Seed = (int)nudSeed.Value;
            TrainParams.Current.CaptionFileExtension = tbxExtension.Text;

            Close();
        }

        private void Form_Advanced_Load(object sender, EventArgs e) {
            tbrCpuThreads.Value = TrainParams.Current.CpuThreads;
            lblCpuThreadsCounter.Text = TrainParams.Current.CpuThreads.ToString();
            cbxScheduler.SelectedIndex = (int)TrainParams.Current.SchedulerType;
            tbxUnetLR.Text = TrainParams.Current.UnetLR < 0f ? string.Empty : TrainParams.Current.UnetLR.ToString();
            tbxTextEncoLR.Text = TrainParams.Current.TextEncoderLR < 0f ? string.Empty : TrainParams.Current.TextEncoderLR.ToString();
            nudMinBucketReso.Value = TrainParams.Current.MinBucketResolution;
            nudMaxBucketReso.Value = TrainParams.Current.MaxBucketResolution;
            cbxNoUpscale.Checked = TrainParams.Current.NoBucketUpscaling;
            cbxUseWarmupInit.Checked = TrainParams.Current.UseWarmupInit;

            nudClipSkip.Value = TrainParams.Current.ClipSkip;
            nudSeed.Value = TrainParams.Current.Seed;
            tbxExtension.Text = TrainParams.Current.CaptionFileExtension;
            cbxPrecision.SelectedIndex = (int)TrainParams.Current.SavePrecision;

            lblTBoardPath.Text = TrainParams.Current.TensorBoardLogPath;
        }

        private void tbrCpuThreads_Scroll(object sender, EventArgs e) {
            lblCpuThreadsCounter.Text = tbrCpuThreads.Value.ToString();
        }

        private void btnDiscardAndClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select Image Folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;
            if (cof.ShowDialog() == CommonFileDialogResult.Ok) {
                TrainParams.Current.TensorBoardLogPath = cof.FileName;
                lblTBoardPath.Text = cof.FileName;
            }
        }

        private void btnClearTBoardPath_Click(object sender, EventArgs e) {
            lblTBoardPath.Text = string.Empty;
            TrainParams.Current.TensorBoardLogPath = string.Empty;
        }
    }
}

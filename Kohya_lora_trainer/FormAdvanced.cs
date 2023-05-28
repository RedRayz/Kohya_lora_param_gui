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
    public partial class FormAdvanced : Form {
        public FormAdvanced() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(tbxTextEncoLR.Text)) {
                float lr = -1f;
                if (float.TryParse(tbxTextEncoLR.Text, out lr)) {
                    if (!CheckUtil.IsValidNum(lr)) {
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
                    if (!CheckUtil.IsValidNum(lr)) {
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
                TrainParams.Current.UnetLR = -1;
            }

            if(nudMinBucketReso.Value % 64 != 0) {
                MessageBox.Show("最小バケット解像度の値が間違っています。\n64で割り切れる必要があります。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudMaxBucketReso.Value % 64 != 0) {
                MessageBox.Show("最大バケット解像度の値が間違っています。\n64で割り切れる必要があります。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            TrainParams.Current.CpuThreads = tbrCpuThreads.Value;
            TrainParams.Current.SchedulerType = (SchedulerType)Enum.ToObject(typeof(SchedulerType), cbxScheduler.SelectedIndex);
            TrainParams.Current.SavePrecision = (SavePrecision)Enum.ToObject(typeof(SavePrecision), cbxPrecision.SelectedIndex);
            TrainParams.Current.advancedTrainType = (AdvancedTrainType)Enum.ToObject(typeof(AdvancedTrainType), cbxAdvancedTrain.SelectedIndex);
            TrainParams.Current.CrossAttenType = (CrossAttenType)Enum.ToObject(typeof(CrossAttenType), cbxCrossAttenType.SelectedIndex);
            TrainParams.Current.MinBucketResolution = (int)nudMinBucketReso.Value;
            TrainParams.Current.MaxBucketResolution = (int)nudMaxBucketReso.Value;
            TrainParams.Current.NoBucketUpscaling = cbxNoUpscale.Checked;
            TrainParams.Current.UseWarmupInit = cbxUseWarmupInit.Checked;
            TrainParams.Current.ClipSkip = (int)nudClipSkip.Value;
            TrainParams.Current.Seed = (int)nudSeed.Value;
            TrainParams.Current.CaptionFileExtension = tbxExtension.Text;
            TrainParams.Current.UseGradient = cbxUseGradient.Checked;
            TrainParams.Current.LoraModelPath = lblLoRAmodelPath.Text;
            TrainParams.Current.NoiseOffset = (float)nudNoiseOffset.Value;
            TrainParams.Current.Momentum = (float)nudMomentum.Value;
            TrainParams.Current.VAEPath = lblVAEPath.Text;
            TrainParams.Current.UseWeightedCaptions = cbxUseWeightedCaption.Checked;
            TrainParams.Current.AdaptiveNoiseScale = nudAdaptiveNoiseScale.Value;
            TrainParams.Current.MinSNRGamma = nudMinSNRGamma.Value;
            TrainParams.Current.MultiresNoiseIterations = nudMultiresNoiseIterations.Value;
            TrainParams.Current.MultiresNoiseDiscount = nudMultiresNoiseDiscount.Value;

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
            cbxAdvancedTrain.SelectedIndex = (int)TrainParams.Current.advancedTrainType;
            cbxCrossAttenType.SelectedIndex = (int)TrainParams.Current.CrossAttenType;
            cbxUseWeightedCaption.Checked = TrainParams.Current.UseWeightedCaptions;
            nudAdaptiveNoiseScale.Value = TrainParams.Current.AdaptiveNoiseScale;

            nudClipSkip.Value = TrainParams.Current.ClipSkip;
            nudSeed.Value = TrainParams.Current.Seed;
            tbxExtension.Text = TrainParams.Current.CaptionFileExtension;
            cbxPrecision.SelectedIndex = (int)TrainParams.Current.SavePrecision;

            lblTBoardPath.Text = TrainParams.Current.TensorBoardLogPath;
            cbxUseGradient.Checked = TrainParams.Current.UseGradient;
            nudMinSNRGamma.Value = TrainParams.Current.MinSNRGamma;
            nudMultiresNoiseIterations.Value = TrainParams.Current.MultiresNoiseIterations;
            nudMultiresNoiseDiscount.Value = TrainParams.Current.MultiresNoiseDiscount;
            bool valid = nudMinBucketReso.Value % 64 == 0;
            lblMinBucketReso.ForeColor = valid ? Color.Black : Color.Red;

            valid = nudMaxBucketReso.Value % 64 == 0;
            lblMaxBucketReso.ForeColor = valid ? Color.Black : Color.Red;

            lblLoRAmodelPath.Text = TrainParams.Current.LoraModelPath;
            nudNoiseOffset.Value = (decimal)TrainParams.Current.NoiseOffset;
            nudMomentum.Value = (decimal)TrainParams.Current.Momentum;
            lblVAEPath.Text = TrainParams.Current.VAEPath;
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

        private void nudMinBucketReso_ValueChanged(object sender, EventArgs e) {
            bool valid = nudMinBucketReso.Value % 64 == 0;
            lblMinBucketReso.ForeColor = valid ? Color.Black : Color.Red;
        }

        private void nudMaxBucketReso_ValueChanged(object sender, EventArgs e) {
            bool valid = nudMaxBucketReso.Value % 64 == 0;
            lblMaxBucketReso.ForeColor = valid ? Color.Black : Color.Red;
        }

        private void btnSelectLoRAmodel_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SD Model(*.safetensors)|*.safetensors";
            ofd.Title = "Select a lora";
            ofd.RestoreDirectory = true;
            if(ofd.ShowDialog() == DialogResult.OK) {
                lblLoRAmodelPath.Text = ofd.FileName;
            }
        }

        private void btnClearLoRAmodel_Click(object sender, EventArgs e) {
            lblLoRAmodelPath.Text = string.Empty;
        }

        private void btnSelectVAE_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SD VAE(*.safetensors;*.pt)|*.safetensors;*.pt";
            ofd.Title = "Select a VAE";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK) {
                lblVAEPath.Text = ofd.FileName;
            }
        }

        private void btnClearVAE_Click(object sender, EventArgs e) {
            lblVAEPath.Text = string.Empty;
        }

        private void tbxUnetLR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

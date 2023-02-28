using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kohya_lora_trainer
{
    public partial class Form_Advanced : Form
    {
        public Form_Advanced()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxTextEncoLR.Text)) {
                float lr = -1f;
                if (float.TryParse(tbxTextEncoLR.Text, out lr)) {
                    if (lr <= 0f || float.IsNaN(lr) || float.IsInfinity(lr)) {
                        MessageBox.Show("TextEncoder LRに0以下、NaN、無限は指定できません", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else {
                        TrainParams.TextEncoderLR = lr;
                    }
                }
                else {
                    MessageBox.Show("TextEncoder LRの値が間違っています", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else {
                TrainParams.TextEncoderLR = -1;
            }

            if (!string.IsNullOrEmpty(tbxUnetLR.Text)) {
                float lr = -1f;
                if(float.TryParse(tbxUnetLR.Text, out lr)) {
                    if(lr <= 0f || float.IsNaN(lr) || float.IsInfinity(lr)) {
                        MessageBox.Show("UNet LRに0以下、NaN、無限は指定できません", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else {
                        TrainParams.UnetLR = lr;
                    }
                }
                else {
                    MessageBox.Show("UNet LRの値が間違っています", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else {
                TrainParams.UnetLR -= 1;
            }


            TrainParams.CpuThreads = tbrCpuThreads.Value;
            TrainParams.SchedulerType = (SchedulerType)Enum.ToObject(typeof(SchedulerType), cbxScheduler.SelectedIndex);
            TrainParams.SavePrecision = (SavePrecision)Enum.ToObject(typeof(SavePrecision), cbxPrecision.SelectedIndex);
            TrainParams.MinBucketResolution = (int)nudMinBucketReso.Value;
            TrainParams.MaxBucketResolution = (int)nudMaxBucketReso.Value;
            TrainParams.NoBucketUpscaling = cbxNoUpscale.Checked;
            TrainParams.UseWarmupInit = cbxUseWarmupInit.Checked;
            TrainParams.ClipSkip = (int)nudClipSkip.Value;
            TrainParams.Seed = (int)nudSeed.Value;
            TrainParams.CaptionFileExtension = tbxExtension.Text;

            Close();
        }

        private void Form_Advanced_Load(object sender, EventArgs e) {
            tbrCpuThreads.Value = TrainParams.CpuThreads;
            lblCpuThreadsCounter.Text = TrainParams.CpuThreads.ToString();
            cbxScheduler.SelectedIndex = (int)TrainParams.SchedulerType;
            tbxUnetLR.Text = TrainParams.UnetLR < 0f ? string.Empty : TrainParams.UnetLR.ToString();
            tbxTextEncoLR.Text = TrainParams.TextEncoderLR < 0f ? string.Empty : TrainParams.TextEncoderLR.ToString();
            nudMinBucketReso.Value = TrainParams.MinBucketResolution;
            nudMaxBucketReso.Value = TrainParams.MaxBucketResolution;
            cbxNoUpscale.Checked = TrainParams.NoBucketUpscaling;
            cbxUseWarmupInit.Checked = TrainParams.UseWarmupInit;

            nudClipSkip.Value = TrainParams.ClipSkip;
            nudSeed.Value = TrainParams.Seed;
            tbxExtension.Text = TrainParams.CaptionFileExtension;
            cbxPrecision.SelectedIndex = (int)TrainParams.SavePrecision;
        }

        private void tbrCpuThreads_Scroll(object sender, EventArgs e) {
            lblCpuThreadsCounter.Text = tbrCpuThreads.Value.ToString();
        }

        private void btnDiscardAndClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}

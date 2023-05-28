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
    public partial class FormAdvanced1 : Form
    {
        public FormAdvanced1()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            TrainParams.Current.UseColorAug = cbxUseColorAug.Checked;
            TrainParams.Current.UseFastLoading = cbxUseFastLoading.Checked;
            TrainParams.Current.UseSDV2 = cbxUseV2.Checked;
            TrainParams.Current.UseParameterization = cbxUseParametarization.Checked;
            TrainParams.Current.UseFlipAug = cbxFlipAug.Checked;
            TrainParams.Current.CropRandomly = cbxCropRandomly.Checked;
            TrainParams.Current.DontSaveMetadata = cbxDontSaveMetadata.Checked;
            TrainParams.Current.CacheLatents = cbxCacheLatents.Checked;
            TrainParams.Current.CacheLatentsToDisk = cbxCacheLatentsToDisk.Checked;

            //TrainParams.Current.ModelConfigPath = tbxModelConfigPath.Text;

            TrainParams.Current.mixedPrecisionType = (MixedPrecisionType)Enum.ToObject(typeof(MixedPrecisionType), cbxMixedPrecision.SelectedIndex);

            TrainParams.Current.LRSchedulerCycle = (int)nudLRSchedulerCycle.Value;
            TrainParams.Current.DataLoaderThreads = (int)nudDataLoaderThreads.Value;
            TrainParams.Current.MaxTokens = (int)nudMaxTokens.Value;

            float val = 0;
            if (float.TryParse(tbxWeightDecay.Text, out val))
            {
                TrainParams.Current.WeightDecay = val;
                if (val < 0f)
                {
                    MessageBox.Show("Weight Decayの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Weight Decayの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (float.TryParse(tbxEps.Text, out val))
            {
                TrainParams.Current.Eps = val;
                if (val < 0f)
                {
                    MessageBox.Show("epsの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("epsの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (float.TryParse(tbxD0.Text, out val))
            {
                TrainParams.Current.D0 = val;
                if (val < 0f)
                {
                    MessageBox.Show("d0の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("d0の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (float.TryParse(tbxGrowthRate.Text, out val))
            {
                TrainParams.Current.GrowthRate = val;
                if (val < 0f)
                {
                    MessageBox.Show("growth_rateの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("growth_rateの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (float.TryParse(tbxBetas0.Text, out val))
            {
                TrainParams.Current.Betas0 = val;
                if (val < 0f)
                {
                    MessageBox.Show("betasの一番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("betasの一番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (float.TryParse(tbxBetas1.Text, out val))
            {
                TrainParams.Current.Betas1 = val;
                if (val < 0f)
                {
                    MessageBox.Show("betasの二番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("betasの二番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (float.TryParse(tbxBetas2.Text, out val))
            {
                TrainParams.Current.Betas2 = val;
                if (val < 0f)
                {
                    MessageBox.Show("betasの三番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("betasの三番目の値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (float.TryParse(tbxMomentum.Text, out val))
            {
                TrainParams.Current.DAdaptMomentum = val;
                if (val < 0f)
                {
                    MessageBox.Show("momentumの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("momentumの値が不適切です。正しい値を入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Close();
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdvanced1_Load(object sender, EventArgs e)
        {
            cbxUseColorAug.Checked = TrainParams.Current.UseColorAug;
            cbxUseFastLoading.Checked = TrainParams.Current.UseFastLoading;
            cbxUseV2.Checked = TrainParams.Current.UseSDV2;
            cbxUseParametarization.Checked = TrainParams.Current.UseParameterization;
            cbxFlipAug.Checked = TrainParams.Current.UseFlipAug;
            cbxCropRandomly.Checked = TrainParams.Current.CropRandomly;
            cbxDontSaveMetadata.Checked = TrainParams.Current.DontSaveMetadata;
            cbxCacheLatentsToDisk.Checked = TrainParams.Current.CacheLatentsToDisk;
            cbxCacheLatents.Checked = TrainParams.Current.CacheLatents;

            cbxMixedPrecision.SelectedIndex = (int)TrainParams.Current.mixedPrecisionType;

            nudLRSchedulerCycle.Value = TrainParams.Current.LRSchedulerCycle;
            nudDataLoaderThreads.Value = TrainParams.Current.DataLoaderThreads;
            nudMaxTokens.Value = TrainParams.Current.MaxTokens;


            tbxWeightDecay.Text = TrainParams.Current.WeightDecay.ToString("g");
            tbxEps.Text = TrainParams.Current.Eps.ToString("g");
            tbxD0.Text = TrainParams.Current.D0.ToString("g");
            tbxGrowthRate.Text = TrainParams.Current.GrowthRate.ToString("g");
            tbxBetas0.Text = TrainParams.Current.Betas0.ToString("g");
            tbxBetas1.Text = TrainParams.Current.Betas1.ToString("g");
            tbxBetas2.Text = TrainParams.Current.Betas2.ToString("g");
            tbxMomentum.Text = TrainParams.Current.DAdaptMomentum.ToString("g");
        }
    }
}

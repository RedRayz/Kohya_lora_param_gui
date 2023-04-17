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

        }
    }
}

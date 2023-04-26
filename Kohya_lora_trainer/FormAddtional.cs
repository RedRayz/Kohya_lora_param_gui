using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kohya_lora_trainer {
    public partial class FormAddtional : Form {
        public FormAddtional() {
            InitializeComponent();
        }

        private void FormAddtional_Load(object sender, EventArgs e) {
            cbxAlgoType.SelectedIndex = (int)TrainParams.Current.AlgoType;

            nudConvDim.Value = TrainParams.Current.ConvDim;
            nudConvAlpha.Value = TrainParams.Current.ConvAlpha;
            cbxUseConv2d.Checked = TrainParams.Current.UseConv2dExtend;
            nudDyLoRAUnit.Value = TrainParams.Current.DyLoRAUnit;

            lblConfigPath.Text = TrainParams.Current.DatasetConfigPath;
        }

        private void btnDiscardChangesAndClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e) {
            TrainParams.Current.ConvDim = (int)nudConvDim.Value;
            TrainParams.Current.ConvAlpha = nudConvAlpha.Value;
            TrainParams.Current.UseConv2dExtend = cbxUseConv2d.Checked;
            TrainParams.Current.DyLoRAUnit = nudDyLoRAUnit.Value;
            TrainParams.Current.DatasetConfigPath = lblConfigPath.Text;

            TrainParams.Current.AlgoType = (AlgoType)Enum.ToObject(typeof(AlgoType), cbxAlgoType.SelectedIndex);

            Close();
        }

        private void btnSelectConfigPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TOML(*.toml)|*.toml";
            ofd.Title = "Select a dataset config";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblConfigPath.Text = ofd.FileName;
            }
        }

        private void btnClearConfigPath_Click(object sender, EventArgs e)
        {
            lblConfigPath.Text = string.Empty;
        }
    }
}

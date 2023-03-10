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
        }

        private void btnDiscardChangesAndClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e) {
            TrainParams.Current.ConvDim = (int)nudConvDim.Value;
            TrainParams.Current.ConvAlpha = (int)nudConvAlpha.Value;

            TrainParams.Current.AlgoType = (AlgoType)Enum.ToObject(typeof(AlgoType), cbxAlgoType.SelectedIndex);

            Close();
        }
    }
}

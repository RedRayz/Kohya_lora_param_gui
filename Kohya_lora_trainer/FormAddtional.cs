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
            cbxAlgo.SelectedIndex = (int)TrainParams.Current.AlgoType;
        }

        private void btnDiscardChangesAndClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e) {

        }
    }
}

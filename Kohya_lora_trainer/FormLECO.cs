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
    public partial class FormLECO : Form
    {
        public FormLECO()
        {
            InitializeComponent();
        }

        private void FormLECO_Load(object sender, EventArgs e)
        {
            cbxAction.SelectedIndex = 0;
            cbxNoiseScheduler.SelectedIndex = 0;
            cbxSavePrecision.SelectedIndex = 0;
            cbxTrainPrecision.SelectedIndex = 0;
            cbxType.SelectedIndex = 0;
        }
    }
}

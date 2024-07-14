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
    public partial class FormDatasetTools : Form
    {
        public FormDatasetTools()
        {
            InitializeComponent();
        }

        private void cbxUseRegEx_CheckedChanged(object sender, EventArgs e)
        {
            btnAddTag.Enabled = !cbxUseRegEx.Checked;
        }
    }
}

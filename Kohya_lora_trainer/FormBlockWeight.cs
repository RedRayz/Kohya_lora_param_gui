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
    public partial class FormBlockWeight : Form {
        public FormBlockWeight() {
            InitializeComponent();
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e) {
            Close();
        }
    }
}

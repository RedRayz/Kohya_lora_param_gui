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

namespace Kohya_lora_trainer
{
    public partial class FormBatchProcess : Form
    {
        private static string PresetListText;

        public FormBatchProcess()
        {
            InitializeComponent();
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            BatchProcess.LogResultText = cbxGenerateLogText.Checked;
            if (string.IsNullOrEmpty(tbxPrestList.Text))
            {
                BatchProcess.BatchStack.Clear();
                PresetListText = string.Empty;
                Close();
                return;
            }
            PresetListText = tbxPrestList.Text;

            BatchProcess.LoadBatchPresetText(tbxPrestList.Text);
            
            Close();
        }

        private void btnAddPreset_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "LoRA Preset(*.xmlora)|*.xmlora";
            ofd.Title = "Select a preset";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(tbxPrestList.Text))
                {
                    tbxPrestList.Text += "\r\n";
                }

                tbxPrestList.Text += ofd.FileName;
            }
        }

        private void FormBatchProcess_Load(object sender, EventArgs e)
        {
            tbxPrestList.Text = PresetListText;
            cbxGenerateLogText.Checked = BatchProcess.LogResultText;
        }
    }
}

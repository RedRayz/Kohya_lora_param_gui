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
            BatchProcess.ShuffleCaptionsBeforeTraining = cbxShuffleCaptionsBefore.Checked;
            BatchProcess.KeepTokensCount = (int)nudKeepTokens.Value;

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
                if (!string.IsNullOrEmpty(tbxPrestList.Text) && !tbxPrestList.Text.EndsWith("\r\n"))
                {
                    tbxPrestList.Text += "\r\n";
                }

                tbxPrestList.Text += ofd.FileName;
                tbxPrestList.Text += "\r\n";
            }
        }

        private void FormBatchProcess_Load(object sender, EventArgs e)
        {
            tbxPrestList.Text = PresetListText;
            cbxGenerateLogText.Checked = BatchProcess.LogResultText;
            cbxShuffleCaptionsBefore.Checked = BatchProcess.ShuffleCaptionsBeforeTraining;
            nudKeepTokens.Value = BatchProcess.KeepTokensCount;
        }

        private void tbxPrestList_DragEnter(object sender, DragEventArgs e)
        {
            MyUtils.CommonFileDragEnterEvent(e, ".xmlora");
        }

        private void tbxPrestList_DragDrop(object sender, DragEventArgs e)
        {
            string dropped = MyUtils.GetDroppedFileName(e, ".xmlora");
            if (!string.IsNullOrEmpty(dropped))
            {
                if (!string.IsNullOrEmpty(tbxPrestList.Text) && !tbxPrestList.Text.EndsWith("\r\n"))
                {
                    tbxPrestList.Text += "\r\n";
                }
                tbxPrestList.Text += dropped;
                tbxPrestList.Text += "\r\n";
            }
        }
    }
}

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

        private void btnShuffleCaptions_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("シャッフルしますか。\r\nこの操作はもとに戻せません。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblProcessing.Visible = true;
                Update();
                MyUtils.ShuffleCaptions(tbxTargetDir.Text, (int)nudKeepTokens.Value, true);
                lblProcessing.Visible = false;
                ShowDoneMsg();
            }
        }

        private void ShowDoneMsg()
        {
            MessageBox.Show("完了しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

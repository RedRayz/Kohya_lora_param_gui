using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS8602

namespace Kohya_lora_trainer {
    public partial class FormBlockWeight : Form
    {
        private TrackBar[] tbrIn = new TrackBar[12];
        private TrackBar[] tbrOut = new TrackBar[12];
        private Label[] lblIn = new Label[12];
        private Label[] lblOut = new Label[12];

        public FormBlockWeight()
        {
            InitializeComponent();
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                TrainParams.Current.BlockWeightIn[i] = tbrIn[i].Value;
                TrainParams.Current.BlockWeightOut[i] = tbrOut[i].Value;
            }

            TrainParams.Current.BlockWeightMid = tbrMid.Value;
            TrainParams.Current.BlockWeightMid01 = tbrMid01.Value;
            TrainParams.Current.BlockWeightMid02 = tbrMid02.Value;
            TrainParams.Current.BlockWeightOffsetIn = nudOffsetIn.Value;
            TrainParams.Current.BlockWeightOffsetOut = nudOffsetOut.Value;
            TrainParams.Current.UseBlockWeight = cbxEnableBlockWeight.Checked;
            TrainParams.Current.BlockWeightZeroThreshold = tbrThreshold.Value;
            TrainParams.Current.BlockWeightPresetTypeIn = (BlockWeightPreset)Enum.ToObject(typeof(BlockWeightPreset), cbxPresetIn.SelectedIndex);
            TrainParams.Current.BlockWeightPresetTypeOut = (BlockWeightPreset)Enum.ToObject(typeof(BlockWeightPreset), cbxPresetOut.SelectedIndex);
            Close();
        }

        private void FormBlockWeight_Load(object sender, EventArgs e)
        {
            cbxPresetIn.SelectedIndex = 0;

            tbrIn[0] = tbrIn00;
            tbrIn[1] = tbrIn01;
            tbrIn[2] = tbrIn02;
            tbrIn[3] = tbrIn03;
            tbrIn[4] = tbrIn04;
            tbrIn[5] = tbrIn05;
            tbrIn[6] = tbrIn06;
            tbrIn[7] = tbrIn07;
            tbrIn[8] = tbrIn08;
            tbrIn[9] = tbrIn09;
            tbrIn[10] = tbrIn10;
            tbrIn[11] = tbrIn11;

            tbrOut[0] = tbrOut00;
            tbrOut[1] = tbrOut01;
            tbrOut[2] = tbrOut02;
            tbrOut[3] = tbrOut03;
            tbrOut[4] = tbrOut04;
            tbrOut[5] = tbrOut05;
            tbrOut[6] = tbrOut06;
            tbrOut[7] = tbrOut07;
            tbrOut[8] = tbrOut08;
            tbrOut[9] = tbrOut09;
            tbrOut[10] = tbrOut10;
            tbrOut[11] = tbrOut11;

            lblIn[0] = lblIn00;
            lblIn[1] = lblIn01;
            lblIn[2] = lblIn02;
            lblIn[3] = lblIn03;
            lblIn[4] = lblIn04;
            lblIn[5] = lblIn05;
            lblIn[6] = lblIn06;
            lblIn[7] = lblIn07;
            lblIn[8] = lblIn08;
            lblIn[9] = lblIn09;
            lblIn[10] = lblIn10;
            lblIn[11] = lblIn11;

            lblOut[0] = lblOut00;
            lblOut[1] = lblOut01;
            lblOut[2] = lblOut02;
            lblOut[3] = lblOut03;
            lblOut[4] = lblOut04;
            lblOut[5] = lblOut05;
            lblOut[6] = lblOut06;
            lblOut[7] = lblOut07;
            lblOut[8] = lblOut08;
            lblOut[9] = lblOut09;
            lblOut[10] = lblOut10;
            lblOut[11] = lblOut11;

            for (int i = 0; i < 12; i++)
            {
                tbrIn[i].Value = TrainParams.Current.BlockWeightIn[i];
                lblIn[i].Text = (0.05m * TrainParams.Current.BlockWeightIn[i]).ToString();

                tbrOut[i].Value = TrainParams.Current.BlockWeightOut[i];
                lblOut[i].Text = (0.05m * TrainParams.Current.BlockWeightOut[i]).ToString();
            }

            tbrMid01.Value = TrainParams.Current.BlockWeightMid01;
            lblMid01.Text = (0.05m * TrainParams.Current.BlockWeightMid01).ToString();
            tbrMid02.Value = TrainParams.Current.BlockWeightMid02;
            lblMid02.Text = (0.05m * TrainParams.Current.BlockWeightMid02).ToString();

            tbrMid.Value = TrainParams.Current.BlockWeightMid;
            lblMId.Text = (0.05m * TrainParams.Current.BlockWeightMid).ToString();
            tbrThreshold.Value = TrainParams.Current.BlockWeightZeroThreshold;
            lblThreshold.Text = (0.05m * TrainParams.Current.BlockWeightZeroThreshold).ToString();

            nudOffsetIn.Value = TrainParams.Current.BlockWeightOffsetIn;
            nudOffsetOut.Value = TrainParams.Current.BlockWeightOffsetOut;

            cbxEnableBlockWeight.Checked = TrainParams.Current.UseBlockWeight;

            cbxPresetIn.SelectedIndex = (int)TrainParams.Current.BlockWeightPresetTypeIn;
            cbxPresetOut.SelectedIndex = (int)TrainParams.Current.BlockWeightPresetTypeOut;
            if (TrainParams.Current.StableDiffusionType == ModelArchitecture.XL)
            {
                tbrIn09.Enabled = false;
                tbrIn10.Enabled = false;
                tbrIn11.Enabled = false;

                tbrOut09.Enabled = false;
                tbrOut10.Enabled = false;
                tbrOut11.Enabled = false;
            }
            else
            {
                tbrMid01.Enabled = false;
                tbrMid02.Enabled = false;

                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
                panel3.BackColor = Color.Transparent;
                panel4.BackColor = Color.Transparent;
                panel5.BackColor = Color.Transparent;
                groupBox1.Visible = false;
            }
        }

        private void tbrIn00_Scroll(object sender, EventArgs e)
        {
            lblIn00.Text = (0.05m * tbrIn[0].Value).ToString();
        }

        private void tbrIn01_Scroll(object sender, EventArgs e)
        {
            lblIn01.Text = (0.05m * tbrIn[1].Value).ToString();
        }

        private void tbrIn02_Scroll(object sender, EventArgs e)
        {
            lblIn02.Text = (0.05m * tbrIn[2].Value).ToString();
        }

        private void tbrIn03_Scroll(object sender, EventArgs e)
        {
            lblIn03.Text = (0.05m * tbrIn[3].Value).ToString();
        }

        private void tbrIn04_Scroll(object sender, EventArgs e)
        {
            lblIn04.Text = (0.05m * tbrIn[4].Value).ToString();
        }

        private void tbrIn05_Scroll(object sender, EventArgs e)
        {
            lblIn05.Text = (0.05m * tbrIn[5].Value).ToString();
        }

        private void tbrIn06_Scroll(object sender, EventArgs e)
        {
            lblIn06.Text = (0.05m * tbrIn[6].Value).ToString();
        }

        private void tbrIn07_Scroll(object sender, EventArgs e)
        {
            lblIn07.Text = (0.05m * tbrIn[7].Value).ToString();
        }

        private void tbrIn08_Scroll(object sender, EventArgs e)
        {
            lblIn08.Text = (0.05m * tbrIn[8].Value).ToString();
        }

        private void tbrIn09_Scroll(object sender, EventArgs e)
        {
            lblIn09.Text = (0.05m * tbrIn[9].Value).ToString();
        }

        private void tbrIn10_Scroll(object sender, EventArgs e)
        {
            lblIn10.Text = (0.05m * tbrIn[10].Value).ToString();
        }

        private void tbrIn11_Scroll(object sender, EventArgs e)
        {
            lblIn11.Text = (0.05m * tbrIn[11].Value).ToString();
        }

        private void tbrMid_Scroll(object sender, EventArgs e)
        {
            lblMId.Text = (0.05m * tbrMid.Value).ToString();
        }

        private void tbrOut00_Scroll(object sender, EventArgs e)
        {
            lblOut00.Text = (0.05m * tbrOut[0].Value).ToString();
        }

        private void tbrOut01_Scroll(object sender, EventArgs e)
        {
            lblOut01.Text = (0.05m * tbrOut[1].Value).ToString();
        }

        private void tbrOut02_Scroll(object sender, EventArgs e)
        {
            lblOut02.Text = (0.05m * tbrOut[2].Value).ToString();
        }

        private void tbrOut03_Scroll(object sender, EventArgs e)
        {
            lblOut03.Text = (0.05m * tbrOut[3].Value).ToString();
        }

        private void tbrOut04_Scroll(object sender, EventArgs e)
        {
            lblOut04.Text = (0.05m * tbrOut[4].Value).ToString();
        }

        private void tbrOut05_Scroll(object sender, EventArgs e)
        {
            lblOut05.Text = (0.05m * tbrOut[5].Value).ToString();
        }

        private void tbrOut06_Scroll(object sender, EventArgs e)
        {
            lblOut06.Text = (0.05m * tbrOut[6].Value).ToString();
        }

        private void tbrOut07_Scroll(object sender, EventArgs e)
        {
            lblOut07.Text = (0.05m * tbrOut[7].Value).ToString();
        }

        private void tbrOut08_Scroll(object sender, EventArgs e)
        {
            lblOut08.Text = (0.05m * tbrOut[8].Value).ToString();
        }

        private void tbrOut09_Scroll(object sender, EventArgs e)
        {
            lblOut09.Text = (0.05m * tbrOut[9].Value).ToString();
        }

        private void tbrOut10_Scroll(object sender, EventArgs e)
        {
            lblOut10.Text = (0.05m * tbrOut[10].Value).ToString();
        }

        private void tbrOut11_Scroll(object sender, EventArgs e)
        {
            lblOut11.Text = (0.05m * tbrOut[11].Value).ToString();
        }

        private void tbrThreshold_Scroll(object sender, EventArgs e)
        {
            lblThreshold.Text = (0.05m * tbrThreshold.Value).ToString();
        }

        private void tbrMid01_Scroll(object sender, EventArgs e)
        {
            lblMid01.Text = (0.05m * tbrMid01.Value).ToString();
        }

        private void tbrMid02_Scroll(object sender, EventArgs e)
        {
            lblMid02.Text = (0.05m * tbrMid02.Value).ToString();
        }
    }
}

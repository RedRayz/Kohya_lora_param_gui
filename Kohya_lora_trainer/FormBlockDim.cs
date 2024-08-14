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
    public partial class FormBlockDim : Form {
        private NumericUpDown[] NudDimIn = new NumericUpDown[12];
        private NumericUpDown[] NudDimOut = new NumericUpDown[12];
        private NumericUpDown[] NudAlphaIn = new NumericUpDown[12];
        private NumericUpDown[] NudAlphaOut = new NumericUpDown[12];

        public FormBlockDim() {
            InitializeComponent();
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e) {
            Close();
        }

        private void FormBlockDim_Load(object sender, EventArgs e)
        {
            //配列の設定
            NudDimIn[0] = nudDimIn00;
            NudDimIn[1] = nudDimIn01;
            NudDimIn[2] = nudDimIn02;
            NudDimIn[3] = nudDimIn03;
            NudDimIn[4] = nudDimIn04;
            NudDimIn[5] = nudDimIn05;
            NudDimIn[6] = nudDimIn06;
            NudDimIn[7] = nudDimIn07;
            NudDimIn[8] = nudDimIn08;
            NudDimIn[9] = nudDimIn09;
            NudDimIn[10] = nudDimIn10;
            NudDimIn[11] = nudDimIn11;

            NudDimOut[0] = nudDimOut00;
            NudDimOut[1] = nudDimOut01;
            NudDimOut[2] = nudDimOut02;
            NudDimOut[3] = nudDimOut03;
            NudDimOut[4] = nudDimOut04;
            NudDimOut[5] = nudDimOut05;
            NudDimOut[6] = nudDimOut06;
            NudDimOut[7] = nudDimOut07;
            NudDimOut[8] = nudDimOut08;
            NudDimOut[9] = nudDimOut09;
            NudDimOut[10] = nudDimOut10;
            NudDimOut[11] = nudDimOut11;

            NudAlphaIn[0] = nudAlphaIn00;
            NudAlphaIn[1] = nudAlphaIn01;
            NudAlphaIn[2] = nudAlphaIn02;
            NudAlphaIn[3] = nudAlphaIn03;
            NudAlphaIn[4] = nudAlphaIn04;
            NudAlphaIn[5] = nudAlphaIn05;
            NudAlphaIn[6] = nudAlphaIn06;
            NudAlphaIn[7] = nudAlphaIn07;
            NudAlphaIn[8] = nudAlphaIn08;
            NudAlphaIn[9] = nudAlphaIn09;
            NudAlphaIn[10] = nudAlphaIn10;
            NudAlphaIn[11] = nudAlphaIn11;

            NudAlphaOut[0] = nudAlphaOut00;
            NudAlphaOut[1] = nudAlphaOut01;
            NudAlphaOut[2] = nudAlphaOut02;
            NudAlphaOut[3] = nudAlphaOut03;
            NudAlphaOut[4] = nudAlphaOut04;
            NudAlphaOut[5] = nudAlphaOut05;
            NudAlphaOut[6] = nudAlphaOut06;
            NudAlphaOut[7] = nudAlphaOut07;
            NudAlphaOut[8] = nudAlphaOut08;
            NudAlphaOut[9] = nudAlphaOut09;
            NudAlphaOut[10] = nudAlphaOut10;
            NudAlphaOut[11] = nudAlphaOut11;

            //値の読込
            for(int i=0; i< 12; i++)
            {
                NudDimIn[i].Value = TrainParams.Current.BlockDimIn[i];
            }

            for (int i = 0; i < 12; i++)
            {
                NudDimOut[i].Value = TrainParams.Current.BlockDimOut[i];
            }

            for(int i = 0; i< 12; i++)
            {
                NudAlphaIn[i].Value = TrainParams.Current.BlockAlphaInM[i];
            }

            for (int i = 0; i < 12; i++)
            {
                NudAlphaOut[i].Value = TrainParams.Current.BlockAlphaOutM[i];
            }

            nudDimMid.Value = TrainParams.Current.BlockDimMid;
            nudAlphaMid.Value = TrainParams.Current.BlockAlphaMidM;

            nudDimMid01.Value = TrainParams.Current.BlockDimMid01;
            nudAlphaMid01.Value = TrainParams.Current.BlockAlphaMid01;
            nudDimMid02.Value = TrainParams.Current.BlockDimMid02;
            nudAlphaMid02.Value = TrainParams.Current.BlockAlphaMid02;

            nudDimBase.Value = TrainParams.Current.BlockDimBase;
            nudAlphaBase.Value = TrainParams.Current.BlockAlphaBase;

            nudDimOut.Value = TrainParams.Current.BlockDimOutSDXL;
            nudAlphaOut.Value = TrainParams.Current.BlockAlphaOutSDXL;

            cbxEnableBlockDim.Checked = TrainParams.Current.UseBlockDim;

            if(TrainParams.Current.StableDiffusionType == ModelArchitecture.XL)
            {
                for (int i = 9; i < 12; i++)
                {
                    NudDimIn[i].Enabled = false;
                    NudAlphaIn[i].Enabled = false;
                    NudDimOut[i].Enabled = false;
                    NudAlphaOut[i].Enabled = false;
                }

            }
            else
            {
                nudDimMid01.Enabled = false;
                nudAlphaMid01.Enabled = false;
                nudDimMid02.Enabled = false;
                nudAlphaMid02.Enabled = false;
                nudDimOut.Enabled = false;
                nudAlphaOut.Enabled = false;
                nudDimBase.Enabled = false;
                nudAlphaBase.Enabled = false;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //値の読込
            for (int i = 0; i < 12; i++)
            {
                TrainParams.Current.BlockDimIn[i] = (int)NudDimIn[i].Value;
            }

            for (int i = 0; i < 12; i++)
            {
                TrainParams.Current.BlockDimOut[i] = (int)NudDimOut[i].Value;
            }

            for(int i = 0; i< 12; i++)
            {
                TrainParams.Current.BlockAlphaInM[i] = NudAlphaIn[i].Value;
            }

            for (int i = 0; i < 12; i++)
            {
                TrainParams.Current.BlockAlphaOutM[i] = NudAlphaOut[i].Value;
            }

            TrainParams.Current.BlockDimMid = (int)nudDimMid.Value;
            TrainParams.Current.BlockAlphaMidM = nudAlphaMid.Value;
            TrainParams.Current.BlockDimMid01 = (int)nudDimMid01.Value;
            TrainParams.Current.BlockDimMid02 = (int)nudDimMid02.Value;
            TrainParams.Current.BlockAlphaMid01 = nudAlphaMid01.Value;
            TrainParams.Current.BlockAlphaMid02 = nudAlphaMid02.Value;

            TrainParams.Current.BlockDimBase = (int)nudDimBase.Value;
            TrainParams.Current.BlockAlphaBase = nudAlphaBase.Value;

            TrainParams.Current.BlockDimOutSDXL = (int)nudDimOut.Value;
            TrainParams.Current.BlockAlphaOutSDXL = nudAlphaOut.Value;

            TrainParams.Current.UseBlockDim = cbxEnableBlockDim.Checked;

            Close();
        }
    }
}

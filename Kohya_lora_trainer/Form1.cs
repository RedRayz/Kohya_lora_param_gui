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
using Microsoft.WindowsAPICodePack.Shell;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics.SymbolStore;

namespace Kohya_lora_trainer {
    public partial class Form1 : Form {
        private bool IsInvalidOutputName, IsInvalidImageFolder = true, IsInvalidRegFolder = false, IsInvalidLR = false;
        private int StepsPerEpoch, TotalSteps, TotalStepsBatch1;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lblModelPath.Text = string.Empty;
            lblImagePath.Text = string.Empty;
            lblRegImgPath.Text = string.Empty;
            lblOutputPath.Text = string.Empty;
            cbxOptimizer.SelectedIndex = 0;
            lblNumSteps.Text = "?";
            lblNumStepsBatch1.Text = "?";
        }

        private void button4_Click(object sender, EventArgs e) {
            Form adv = new Form_Advanced();
            adv.ShowDialog();

            adv.Dispose();
        }

        private void btnModel_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SD Model(*.ckpt;*.safetensors)|*.ckpt;*.safetensors";
            ofd.Title = "Select the base model";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK) {
                TrainParams.ModelPath = ofd.FileName;
                lblModelPath.Text = ofd.FileName;
            }
        }

        private void btnImage_Click(object sender, EventArgs e) {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select Image Folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok) {
                TrainParams.TrainImagePath = cof.FileName;
                lblImagePath.Text = cof.FileName;
                IsInvalidImageFolder = !ValidateImageFolder(cof.FileName, out StepsPerEpoch);
                if (IsInvalidImageFolder) {
                    MessageBox.Show("教師画像フォルダの指定を間違えている可能性があります。\n「繰り返し数_プロンプト」の名前のフォルダが1つ以上入ったフォルダを指定する必要があります。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                UpdateTotalStepCount();
                lblImagePath.ForeColor = IsInvalidImageFolder ? Color.Red : Color.Black;
            }
        }

        private void btnRegImage_Click(object sender, EventArgs e) {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select Reg Image Folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;
            if (cof.ShowDialog() == CommonFileDialogResult.Ok) {
                TrainParams.RegImagePath = cof.FileName;
                lblRegImgPath.Text = cof.FileName;
                int num = 0;
                IsInvalidRegFolder = !ValidateImageFolder(cof.FileName, out num);
                if (IsInvalidRegFolder) {
                    MessageBox.Show("正則化画像フォルダの指定を間違えている可能性があります。\n「繰り返し数_プロンプト」の名前のフォルダが1つ以上入ったフォルダを指定する必要があります。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                lblRegImgPath.ForeColor = IsInvalidRegFolder ? Color.Red : Color.Black;
            }
        }

        private void btnOutputPath_Click(object sender, EventArgs e) {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select Output Folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;
            if (cof.ShowDialog() == CommonFileDialogResult.Ok) {
                TrainParams.OutputPath = cof.FileName;
                lblOutputPath.Text = cof.FileName;
            }
        }

        private void btnClearRegImagePath_Click(object sender, EventArgs e) {
            TrainParams.RegImagePath = string.Empty;
            lblRegImgPath.Text = string.Empty;
            IsInvalidRegFolder = false;
        }

        private void nudEpochs_ValueChanged(object sender, EventArgs e) {
            TrainParams.Epochs = (int)nudEpochs.Value;
            UpdateTotalStepCount();
        }

        private void tbxLR_TextChanged(object sender, EventArgs e) {
            float lr = 0.0001f;
            if (float.TryParse(tbxLR.Text, out lr)) {
                if (lr <= 0f || lr >= 0.1f || float.IsNaN(lr)) {
                    lblLR.ForeColor = Color.Red;
                    IsInvalidLR = true;
                }
                else {
                    lblLR.ForeColor = Color.Black;
                    TrainParams.LearningRate = lr;
                    IsInvalidLR = false;
                }
            }
            else {
                lblLR.ForeColor = Color.Red;
                IsInvalidLR = true;
            }
        }

        private void nudResolution_ValueChanged(object sender, EventArgs e) {
            TrainParams.Resolution = (int)nudResolution.Value;
        }

        private void nudBatchSize_ValueChanged(object sender, EventArgs e) {
            TrainParams.BatchSize = (int)nudBatchSize.Value;
            UpdateTotalStepCount();
        }

        private void nudNetworkDim_ValueChanged(object sender, EventArgs e) {
            TrainParams.NetworkDim = (int)nudNetworkDim.Value;
        }

        private void nudNetworkAlpha_ValueChanged(object sender, EventArgs e) {
            TrainParams.NetworkAlpha = (int)nudNetworkAlpha.Value;
        }

        private void cbxShuffle_CheckedChanged(object sender, EventArgs e) {
            TrainParams.ShuffleCaptions = cbxShuffle.Checked;
        }

        private void nudKeepTokens_ValueChanged(object sender, EventArgs e) {
            TrainParams.KeepTokenCount = (int)nudKeepTokens.Value;
        }

        private void nudSaveEpoch_ValueChanged(object sender, EventArgs e) {
            TrainParams.SaveEveryNEpochs = (int)nudSaveEpoch.Value;
        }

        private void btnStartTraining_Click(object sender, EventArgs e) {
            if(!IsInvalidImageFolder && !IsInvalidRegFolder && !IsInvalidOutputName && !IsInvalidLR) {
                if (!File.Exists(TrainParams.ModelPath)) {
                    MessageBox.Show("学習元モデルが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Directory.Exists(TrainParams.TrainImagePath)) {
                    MessageBox.Show("教師画像フォルダが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrEmpty(TrainParams.RegImagePath) && !Directory.Exists(TrainParams.RegImagePath)) {
                    MessageBox.Show("正則化画像フォルダが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Directory.Exists(TrainParams.OutputPath)) {
                    MessageBox.Show("出力先フォルダが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (!File.Exists("../train_network.py")) {
                    MessageBox.Show("学習用スクリプト(train_network.py)が見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else {
                MessageBox.Show("設定が間違っています。設定を見直してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbxOptimizer_SelectedIndexChanged(object sender, EventArgs e) {
            TrainParams.OptimizerType = (OptimizerType)Enum.ToObject(typeof(OptimizerType), cbxOptimizer.SelectedIndex);
        }

        private void tbxFileName_TextChanged(object sender, EventArgs e) {
            TrainParams.OutputName = tbxFileName.Text;
            Regex regex = new Regex("[:/\\\\\\?\\*<>\\|\"]");
            if (regex.IsMatch(tbxFileName.Text)) {
                lblFileName.ForeColor = Color.Red;
                IsInvalidOutputName = true;
            }
            else {
                lblFileName.ForeColor = Color.Black;
                IsInvalidOutputName = false;
            }
        }

        private void UpdateTotalStepCount() {
            if (StepsPerEpoch <= 0) {
                lblNumSteps.Text = "?";
                lblNumStepsBatch1.Text = "?";
            }
            else {
                TotalSteps = StepsPerEpoch * TrainParams.Epochs;
                TotalStepsBatch1 = TotalSteps * TrainParams.BatchSize;
                lblNumSteps.Text = TotalSteps.ToString();
                lblNumStepsBatch1.Text = TotalStepsBatch1.ToString();
            }

        }

        private bool ValidateImageFolder(string path, out int ccnt) {
            string[] dc = Directory.GetDirectories(path);
            ccnt = 0;
            if (dc.Length == 0) {
                return false;
            }
            else {
                foreach (string dc2 in dc) {
                    string str = dc2.Remove(0, dc2.LastIndexOf('\\') + 1);
                    int idx = str.IndexOf("_");
                    if (idx > 0) {
                        str = str.Remove(idx);
                        int num = 0;
                        if (int.TryParse(str, out num) && num > 0) {
                            string[] files = Directory.GetFiles(dc2);
                            int fileCnt = 0;
                            foreach (string file in files) {
                                if (!Path.GetExtension(file).Equals(".txt") && !Path.GetExtension(file).Equals(".caption")) {
                                    fileCnt++;
                                }
                            }
                            ccnt += num * fileCnt;

                        }
                        else {
                            return false;
                        }
                    }
                    else {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

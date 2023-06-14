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
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Diagnostics;

namespace Kohya_lora_trainer
{
    public partial class Form1 : Form
    {
        private bool IsInvalidOutputName, IsInvalidImageFolder = true, IsInvalidRegFolder = false, IsInvalidLR = false, IsInvalidResolution;
        private bool HaveNonAscillInOutputName, HaveNonAscillInImageFolder, HaveNonAscillInRegFolder, HaveNonAscillInModelPath, HaveNonAscillInOutputPath;
        private int StepsPerEpoch;
        private decimal TotalSteps, TotalStepsBatch1;
        public static string ScriptPath = string.Empty;

        public Form1()
        {
            InitializeComponent();

            var ins = new TrainParams();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //レジストリからsd-scriptsの場所を取ってくる
            tbxModelPath.Text = string.Empty;
            tbxImagePath.Text = string.Empty;
            tbxRegImgPath.Text = string.Empty;
            tbxOutputPath.Text = string.Empty;
            cbxOptimizer.SelectedIndex = 0;
            cbxModuleType.SelectedIndex = 0;
            lblNumSteps.Text = "?";
            lblNumStepsBatch1.Text = "?";

            btnCustomScriptPath.Visible = false;
            lblScriptPathDesc.Visible = false;
            btnInstaller.Visible = false;

            //先に親フォルダにpyがあるか確認する。
            //なければボタンを表示する
            //ない状態でカスタムパスにもpyがないなら赤字で設定するよう促す(デバッグ環境のみ)
            if (!File.Exists(@"..\train_network.py"))
            {
                btnInstaller.Visible = true;
#if DEBUG
                btnCustomScriptPath.Visible = true;
                lblScriptPathDesc.Visible = true;
                ScriptPath = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\kohya_lora_gui", "ScriptPath", string.Empty);
                if (string.IsNullOrEmpty(ScriptPath) || !File.Exists(ScriptPath + "\\train_network.py"))
                {
                    lblScriptPathDesc.ForeColor = Color.Red;
                    lblScriptPathDesc.Text = "sd-scriptsの場所選択";
                }
                else
                {
                    lblScriptPathDesc.ForeColor = Color.Black;
                    lblScriptPathDesc.Text = "sd-scriptsの場所変更";
                }
#else
                    lblScriptPathDesc.Visible = true;
                    lblScriptPathDesc.ForeColor = Color.Red;
                    lblScriptPathDesc.Text = "train_network.pyがみつかりません";
#endif
            }

            string str = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\autosave.xmlora";
            if (File.Exists(str))
            {
                try
                {
                    XmlSerializer se = new XmlSerializer(typeof(TrainParams));
                    using (StreamReader sr = new StreamReader(str, new System.Text.UTF8Encoding(false)))
                    {
                        TrainParams.Current = (TrainParams)se.Deserialize(sr);
                    }
                }
                catch
                {
                    MessageBox.Show("自動保存プリセットを読み込めません。破損しているか、権限がありません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            TrainParams.Current.ConvertBlockAlpha();
            TrainParams.Current.CheckBrokenBlockDim();

            UpdateAllContents();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form adv = new FormAdvanced();
            adv.ShowDialog();

            adv.Dispose();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SD Model(*.ckpt;*.safetensors)|*.ckpt;*.safetensors";
            ofd.Title = "Select a base model";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TrainParams.Current.ModelPath = ofd.FileName;
                tbxModelPath.Text = ofd.FileName;
                if (CheckUtil.HaveNonAsciiOrSpace(ofd.FileName))
                {
                    tbxModelPath.ForeColor = Color.OrangeRed;
                    HaveNonAscillInModelPath = true;
                }
                else
                {
                    HaveNonAscillInModelPath = false;
                    tbxModelPath.ForeColor = Color.Black;
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select an image folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                HaveNonAscillInImageFolder = false;
                TrainParams.Current.TrainImagePath = cof.FileName;
                tbxImagePath.Text = TrainParams.Current.TrainImagePath;
                IsInvalidImageFolder = !CheckUtil.IsValidImageFolder(cof.FileName, out StepsPerEpoch);
                if (IsInvalidImageFolder)
                {
                    MessageBox.Show("教師画像フォルダの指定を間違えている可能性があります。\n「繰り返し数_プロンプト」の名前のフォルダが1つ以上入ったフォルダを指定する必要があります。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UpdateTotalStepCount();
                tbxImagePath.ForeColor = IsInvalidImageFolder ? Color.Red : Color.Black;
                if (CheckUtil.HaveNonAsciiOrSpace(cof.FileName) && !IsInvalidImageFolder)
                {
                    tbxImagePath.ForeColor = Color.Orange;
                    HaveNonAscillInImageFolder = true;
                }

            }
        }

        private void btnRegImage_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select Reg Image Folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;
            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TrainParams.Current.RegImagePath = cof.FileName;
                tbxRegImgPath.Text = TrainParams.Current.RegImagePath;
                int num = 0;
                HaveNonAscillInRegFolder = false;
                IsInvalidRegFolder = !CheckUtil.IsValidImageFolder(TrainParams.Current.RegImagePath, out num);
                if (IsInvalidRegFolder)
                {
                    MessageBox.Show("正則化画像フォルダの指定を間違えている可能性があります。\n「繰り返し数_プロンプト」の名前のフォルダが1つ以上入ったフォルダを指定する必要があります。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                tbxRegImgPath.ForeColor = IsInvalidRegFolder ? Color.Red : Color.Black;
                if (CheckUtil.HaveNonAsciiOrSpace(TrainParams.Current.RegImagePath) && !IsInvalidRegFolder)
                {
                    tbxRegImgPath.ForeColor = Color.Orange;
                    HaveNonAscillInRegFolder = true;
                }
            }
            UpdateTotalStepCount();
        }

        private void btnOutputPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select Output Folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;
            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TrainParams.Current.OutputPath = cof.FileName;
                tbxOutputPath.Text = TrainParams.Current.OutputPath;
                HaveNonAscillInRegFolder = false;
                if (CheckUtil.HaveNonAsciiOrSpace(TrainParams.Current.OutputPath))
                {
                    tbxOutputPath.ForeColor = Color.Orange;
                    HaveNonAscillInRegFolder = true;
                }
                else
                {
                    tbxOutputPath.ForeColor = Color.Black;
                }
            }
        }

        private void btnClearRegImagePath_Click(object sender, EventArgs e)
        {
            TrainParams.Current.RegImagePath = string.Empty;
            tbxRegImgPath.Text = string.Empty;
            IsInvalidRegFolder = false;
            UpdateTotalStepCount();
        }

        private void nudEpochs_ValueChanged(object sender, EventArgs e)
        {
            TrainParams.Current.Epochs = (int)nudEpochs.Value;
            UpdateTotalStepCount();
        }

        private void tbxLR_TextChanged(object sender, EventArgs e)
        {
            CheckLR(true);
        }

        private void CheckLR(bool changeParam = false)
        {
            float lr = 0.0001f;
            if (float.TryParse(tbxLR.Text, out lr))
            {
                if (lr < 0f || lr > 10f || float.IsNaN(lr))
                {
                    lblLR.ForeColor = Color.Red;
                    IsInvalidLR = true;
                }
                else
                {
                    lblLR.ForeColor = Color.Black;
                    if (changeParam)
                        TrainParams.Current.LearningRate = lr;
                    IsInvalidLR = false;
                }
            }
            else
            {
                lblLR.ForeColor = Color.Red;
                IsInvalidLR = true;
            }
        }

        private void nudResolution_ValueChanged(object sender, EventArgs e)
        {
            TrainParams.Current.Resolution = (int)nudResolution.Value;
            IsInvalidResolution = nudResolution.Value % 64 != 0;
            lblResolution.ForeColor = IsInvalidResolution ? Color.Red : Color.Black;
        }

        private void nudBatchSize_ValueChanged(object sender, EventArgs e)
        {
            TrainParams.Current.BatchSize = (int)nudBatchSize.Value;
            UpdateTotalStepCount();
        }

        private void nudNetworkDim_ValueChanged(object sender, EventArgs e)
        {
            TrainParams.Current.NetworkDim = (int)nudNetworkDim.Value;
        }

        private void nudNetworkAlpha_ValueChanged(object sender, EventArgs e)
        {
            TrainParams.Current.NetworkAlpha = nudNetworkAlpha.Value;
        }

        private void cbxShuffle_CheckedChanged(object sender, EventArgs e)
        {
            TrainParams.Current.ShuffleCaptions = cbxShuffle.Checked;
        }

        private void nudKeepTokens_ValueChanged(object sender, EventArgs e)
        {
            TrainParams.Current.KeepTokenCount = (int)nudKeepTokens.Value;
        }

        private void nudSaveEpoch_ValueChanged(object sender, EventArgs e)
        {
            TrainParams.Current.SaveEveryNEpochs = (int)nudSaveEpoch.Value;
        }

        private void btnSavePreset_Click(object sender, EventArgs e)
        {
            if (IsInvalidOutputName)
            {
                MessageBox.Show("出力ファイル名が間違った状態では\nプリセットの保存はできません", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "New Preset.xmlora";
            sfd.Filter = "LoRA Preset(*.xmlora)|*.xmlora";
            sfd.Title = "Save a preset";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlSerializer se = new XmlSerializer(typeof(TrainParams));
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, new System.Text.UTF8Encoding(false)))
                    {
                        se.Serialize(sw, TrainParams.Current);
                    }
                }
                catch
                {
                    MessageBox.Show("プリセットを保存できません。他のアプリが開いているか、権限がありません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnStartTraining_Click(object sender, EventArgs e)
        {
            string str = string.IsNullOrEmpty(ScriptPath) ? "..\\" : ScriptPath + "\\";

            if (!HasScriptFile(str, true))
                return;

            if (NotifyBadParams() != DialogResult.Yes)
                return;

            if (BatchProcess.BatchStack.Count > 0)
            {
                BatchProcess.IsCancel = false;
                BatchProcess.IsRunning = true;
                BatchProcess.SkippedCount = 0;
                BatchProcess.CompletedCount = 0;
                BatchProcess.FailCount = 0;
                while (BatchProcess.BatchStack.Count > 0)
                {
                    if (!HasScriptFile(str, false))
                    {
                        Console.WriteLine("Skipping training. train_network.py not found");
                        BatchProcess.LogText += TrainParams.Current.OutputPath + "\\" + TrainParams.Current.OutputName + ".safetensors\r\ntrain_network.pyがないためスキップ\r\n\r\n";

                        BatchProcess.SkippedCount++;
                        continue;
                    }

                    string pth = BatchProcess.BatchStack.Pop();
                    if (!File.Exists(pth))
                    {
                        Console.WriteLine("Skipping training. Invalid path: " + pth);
                        if (!string.IsNullOrEmpty(pth))
                        {
                            BatchProcess.LogText += pth + "\r\nプリセットがないためスキップ\r\n\r\n";
                        }
              
                        BatchProcess.SkippedCount++;
                        continue;
                    }

                    LoadPreset(pth, false);
                    if (!IsTrainingAvailable(false))
                    {
                        Console.WriteLine("Skipping training. Invalid params in: " + pth);
                        BatchProcess.LogText += pth + "\r\nプリセットの設定が不適切なためスキップ\r\n\r\n";
                        BatchProcess.SkippedCount++;
                        continue;
                    }
                    Console.WriteLine("Start training: " + pth);
                    Form train0 = new TrainForm(rbtBenckmark.Checked, rbtShutdown.Checked, false);
                    train0.ShowDialog();
                    train0.Dispose();
                    BatchProcess.CompletedCount++;
                }

                if (!BatchProcess.IsCancel && !string.IsNullOrWhiteSpace(BatchProcess.LogText))
                {
                    string sstr = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\batchlog-" + DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss") + ".txt";
                    using(StreamWriter sw = new StreamWriter(sstr, false, new UTF8Encoding(false)))
                    {
                        sw.WriteLine(BatchProcess.LogText);
                    }
                }

                if (rbtShutdown.Checked && !BatchProcess.IsCancel)
                {
                    Form train0 = new TrainForm(false, rbtShutdown.Checked, true);
                    train0.ShowDialog();
                    train0.Dispose();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("バッチ処理が終了しました。\n").Append(BatchProcess.CompletedCount).Append("件が完了し");
                    if(BatchProcess.SkippedCount > 0)
                    {
                        sb.Append("、").Append(BatchProcess.SkippedCount).Append("件がスキップされました。");
                    }
                    else
                    {
                        sb.Append("ました。");
                    }

                    if(BatchProcess.FailCount > 0)
                    {
                        sb.Append("\n完了したものの内").Append(BatchProcess.FailCount).Append("件が失敗した可能性があります。");
                    }

                    sb.Append("\nもう一度バッチ処理をする場合はバッチ処理ウィンドウを開いて反映ボタンを押してください。");
                    MessageBox.Show(sb.ToString(), "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                BatchProcess.IsRunning = false;
                BatchProcess.SkippedCount = 0;
                BatchProcess.CompletedCount = 0;
                BatchProcess.FailCount = 0;
                BatchProcess.IsCancel = false;
                BatchProcess.LogText = string.Empty;
                return;
            }

            if (!IsTrainingAvailable(true))
                return;

            Form train = new TrainForm(rbtBenckmark.Checked, rbtShutdown.Checked, false);
            train.ShowDialog();
            train.Dispose();
        }

        private bool HasScriptFile(string str, bool showMsg)
        {
            if (!File.Exists(str + "train_network.py"))
            {
                if (showMsg)
                    MessageBox.Show("train_network.pyが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsTrainingAvailable(bool showMsg)
        {
            if (IsInvalidImageFolder || IsInvalidRegFolder || IsInvalidOutputName || IsInvalidLR || IsInvalidResolution)
            {
                if (showMsg)
                {
                    MessageBox.Show("設定が間違っています。設定を見直してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }

            if (!File.Exists(TrainParams.Current.ModelPath))
            {
                if (showMsg)
                    MessageBox.Show("学習元モデルが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Directory.Exists(TrainParams.Current.TrainImagePath))
            {
                if (showMsg)
                    MessageBox.Show("教師画像フォルダが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.RegImagePath) && !Directory.Exists(TrainParams.Current.RegImagePath))
            {
                if (showMsg)
                    MessageBox.Show("正則化画像フォルダが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Directory.Exists(TrainParams.Current.OutputPath))
            {
                if (showMsg)
                    MessageBox.Show("出力先フォルダが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.TensorBoardLogPath) && !Directory.Exists(TrainParams.Current.TensorBoardLogPath))
            {
                if (showMsg)
                    MessageBox.Show("TensorBoard用ログフォルダが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (showMsg && (HaveNonAscillInImageFolder || HaveNonAscillInModelPath || HaveNonAscillInOutputName || HaveNonAscillInRegFolder || HaveNonAscillInOutputPath))
            {
                DialogResult res = MessageBox.Show("パスに日本語などのマルチバイト文字または空白文字が含まれています。\n不具合/エラーの原因となるため、それらの文字の使用は推奨しません。\n続けてもよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res != DialogResult.Yes)
                    return false;
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.LoraModelPath) && !File.Exists(TrainParams.Current.LoraModelPath))
            {
                if (showMsg)
                    MessageBox.Show("追加学習するLoRAモデルが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrEmpty(TrainParams.Current.VAEPath) && !File.Exists(TrainParams.Current.VAEPath))
            {
                if (showMsg)
                    MessageBox.Show("VAEが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnLoadPreset_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "LoRA Preset(*.xmlora)|*.xmlora";
            ofd.Title = "Select a preset";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadPreset(ofd.FileName, true);
            }
        }

        private void LoadPreset(string path, bool ShowMsg)
        {
            try
            {
                XmlSerializer se = new XmlSerializer(typeof(TrainParams));
                using (StreamReader sr = new StreamReader(path, new System.Text.UTF8Encoding(false)))
                {
                    TrainParams.Current = (TrainParams)se.Deserialize(sr);
                }

            }
            catch
            {
                Console.WriteLine("Failed to load preset");
                if (ShowMsg)
                    MessageBox.Show("プリセットを読み込めません。破損しているか、権限がありません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TrainParams.Current.ConvertBlockAlpha();
            TrainParams.Current.CheckBrokenBlockDim();
            UpdateAllContents();
        }


        private void btnUtilities_Click(object sender, EventArgs e)
        {
            Form frm = new FormUtils();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void tbxOutputPath_TextChanged(object sender, EventArgs e)
        {
            string str = tbxOutputPath.Text.Trim();
            if (str.EndsWith("\\"))
            {
                str = str.Remove(str.Length - 1, 1);
            }


            TrainParams.Current.OutputPath = str;
            if (!Directory.Exists(TrainParams.Current.OutputPath))
            {
                tbxOutputPath.ForeColor = Color.Red;
                HaveNonAscillInOutputPath = false;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(TrainParams.Current.OutputPath))
            {
                tbxOutputPath.ForeColor = Color.Orange;
                HaveNonAscillInOutputPath = true;
            }
            else
            {
                tbxOutputPath.ForeColor = Color.Black;
                HaveNonAscillInOutputPath = false;
            }
        }

        private void nudWarmupSteps_ValueChanged(object sender, EventArgs e)
        {
            TrainParams.Current.WarmupSteps = (int)nudWarmupSteps.Value;
        }

        private void btnBlockWeight_Click(object sender, EventArgs e)
        {
            Form frm = new FormBlockWeight();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnBlockDim_Click(object sender, EventArgs e)
        {
            Form frm = new FormBlockDim();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnBatchProcess_Click(object sender, EventArgs e)
        {
            Form frm = new FormBatchProcess();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnInstaller_Click(object sender, EventArgs e)
        {
            Form frm = new FormInstaller();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void cbxModuleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrainParams.Current.ModuleType = (ModuleType)Enum.ToObject(typeof(ModuleType), cbxModuleType.SelectedIndex);
        }

        private void btnGenerateCommands_Click(object sender, EventArgs e)
        {
            if (IsTrainingAvailable(true))
                Clipboard.SetText(MyUtils.GenerateCommands());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsInvalidOutputName)
                return;

            string str = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\autosave.xmlora";
            try
            {
                XmlSerializer se = new XmlSerializer(typeof(TrainParams));
                using (StreamWriter sw = new StreamWriter(str, false, new UTF8Encoding(false)))
                {
                    se.Serialize(sw, TrainParams.Current);
                }
            }
            catch
            {
                Console.WriteLine("自動保存書き込みできない");
            }
        }

        private void btnCustomScriptPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select SD-Scripts Folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ScriptPath = cof.FileName;
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\kohya_lora_gui", "ScriptPath", ScriptPath);
            }
        }

        private void cbxOptimizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrainParams.Current.OptimizerType = (OptimizerType)Enum.ToObject(typeof(OptimizerType), cbxOptimizer.SelectedIndex);
        }

        private void tbxModelPath_TextChanged(object sender, EventArgs e)
        {
            TrainParams.Current.ModelPath = tbxModelPath.Text.Trim();
            if (!File.Exists(TrainParams.Current.ModelPath))
            {
                tbxModelPath.ForeColor = Color.Red;
                HaveNonAscillInModelPath = false;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(TrainParams.Current.ModelPath))
            {
                tbxModelPath.ForeColor = Color.OrangeRed;
                HaveNonAscillInModelPath = true;
            }
            else
            {
                tbxModelPath.ForeColor = Color.Black;
                HaveNonAscillInModelPath = false;
            }
        }

        private void tbxImagePath_TextChanged(object sender, EventArgs e)
        {

            string str = tbxImagePath.Text.Trim();
            if (str.EndsWith("\\"))
            {
                str = str.Remove(str.Length - 1, 1);
            }


            TrainParams.Current.TrainImagePath = str;
            if (!Directory.Exists(TrainParams.Current.TrainImagePath))
            {
                tbxImagePath.ForeColor = Color.Red;
                IsInvalidImageFolder = true;
                HaveNonAscillInImageFolder = false;
                StepsPerEpoch = 0;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(TrainParams.Current.TrainImagePath))
            {
                tbxImagePath.ForeColor = Color.Orange;
                HaveNonAscillInImageFolder = true;
                IsInvalidImageFolder = !CheckUtil.IsValidImageFolder(TrainParams.Current.TrainImagePath, out StepsPerEpoch);
            }
            else
            {
                IsInvalidImageFolder = !CheckUtil.IsValidImageFolder(TrainParams.Current.TrainImagePath, out StepsPerEpoch);
                tbxImagePath.ForeColor = IsInvalidImageFolder ? Color.Red : Color.Black;
                HaveNonAscillInImageFolder = false;
            }
            UpdateTotalStepCount();

        }

        private void tbxRegImgPath_TextChanged(object sender, EventArgs e)
        {
            string str = tbxRegImgPath.Text.Trim();
            if (str.EndsWith("\\"))
            {
                str = str.Remove(str.Length - 1, 1);
            }

            TrainParams.Current.RegImagePath = str;
            if (string.IsNullOrEmpty(TrainParams.Current.RegImagePath))
            {
                UpdateTotalStepCount();
                tbxRegImgPath.ForeColor = IsInvalidRegFolder ? Color.Red : Color.Black;
                HaveNonAscillInRegFolder = false;
                return;
            }

            if (!Directory.Exists(TrainParams.Current.RegImagePath))
            {
                tbxRegImgPath.ForeColor = Color.Red;
                IsInvalidRegFolder = true;
                HaveNonAscillInRegFolder = false;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(TrainParams.Current.RegImagePath))
            {
                tbxRegImgPath.ForeColor = Color.Orange;
                HaveNonAscillInRegFolder = true;
                int num = 0;
                IsInvalidRegFolder = !CheckUtil.IsValidImageFolder(TrainParams.Current.RegImagePath, out num);
            }
            else
            {
                int num = 0;
                IsInvalidRegFolder = !CheckUtil.IsValidImageFolder(TrainParams.Current.RegImagePath, out num);
                tbxRegImgPath.ForeColor = IsInvalidRegFolder ? Color.Red : Color.Black;
                HaveNonAscillInRegFolder = false;
            }
            UpdateTotalStepCount();
        }

        private void tbxFileName_TextChanged(object sender, EventArgs e)
        {
            TrainParams.Current.OutputName = tbxFileName.Text.Trim();
            HaveNonAscillInOutputName = false;
            Regex regex = new Regex("[&:/\\\\\\?\\*<>\\|\"]");
            if (regex.IsMatch(TrainParams.Current.OutputName))
            {
                lblFileName.ForeColor = Color.Red;
                tbxFileName.ForeColor = Color.Red;
                IsInvalidOutputName = true;
                return;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(TrainParams.Current.OutputName))
            {
                lblFileName.ForeColor = Color.Orange;
                tbxFileName.ForeColor = Color.Orange;
                HaveNonAscillInOutputName = true;
            }
            else
            {
                lblFileName.ForeColor = Color.Black;
                tbxFileName.ForeColor = Color.Black;
            }
            IsInvalidOutputName = false;
        }

        private void UpdateTotalStepCount()
        {
            if (StepsPerEpoch <= 0 || (!string.IsNullOrEmpty(TrainParams.Current.RegImagePath) && !Directory.Exists(TrainParams.Current.RegImagePath)))
            {
                lblNumSteps.Text = "?";
                lblNumStepsBatch1.Text = "?";
            }
            else
            {
                //sd-scriptsに近い計算式でもずれるときはずれる。accelerateとかの影響?
                decimal eps = (decimal)StepsPerEpoch / TrainParams.Current.BatchSize;

                TotalSteps = TrainParams.Current.Epochs * Math.Ceiling(eps);
                
                TotalStepsBatch1 = TotalSteps * TrainParams.Current.BatchSize;
                if (!string.IsNullOrEmpty(TrainParams.Current.RegImagePath))
                {
                    TotalSteps *= 2;
                    TotalStepsBatch1 *= 2;
                }


                lblNumSteps.Text = TotalSteps.ToString();
                lblNumStepsBatch1.Text = TotalStepsBatch1.ToString();
            }

        }

        private void UpdateAllContents()
        {
            HaveNonAscillInImageFolder = false;
            HaveNonAscillInModelPath = false;
            HaveNonAscillInOutputName = false;
            HaveNonAscillInRegFolder = false;
            HaveNonAscillInOutputPath = false;
            //ModelPath
            tbxModelPath.Text = TrainParams.Current.ModelPath;
            tbxModelPath.ForeColor = Color.Black;
            if (!File.Exists(TrainParams.Current.ModelPath))
            {
                tbxModelPath.ForeColor = Color.Red;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(TrainParams.Current.ModelPath))
            {
                tbxModelPath.ForeColor = Color.Orange;
                HaveNonAscillInModelPath = true;
            }

            //TrainImage
            tbxImagePath.Text = TrainParams.Current.TrainImagePath;
            IsInvalidImageFolder = !CheckUtil.IsValidImageFolder(TrainParams.Current.TrainImagePath, out StepsPerEpoch);
            tbxImagePath.ForeColor = IsInvalidImageFolder ? Color.Red : Color.Black;
            if (CheckUtil.HaveNonAsciiOrSpace(TrainParams.Current.TrainImagePath))
            {
                tbxImagePath.ForeColor = Color.Orange;
                HaveNonAscillInImageFolder = true;
            }

            //RegImage
            tbxRegImgPath.Text = TrainParams.Current.RegImagePath;
            if (!string.IsNullOrEmpty(TrainParams.Current.RegImagePath))
            {
                int num = 0;
                IsInvalidRegFolder = !CheckUtil.IsValidImageFolder(TrainParams.Current.RegImagePath, out num);
            }
            else
            {
                IsInvalidRegFolder = false;
            }
            tbxRegImgPath.ForeColor = IsInvalidRegFolder ? Color.Red : Color.Black;

            if (CheckUtil.HaveNonAsciiOrSpace(TrainParams.Current.RegImagePath))
            {
                tbxRegImgPath.ForeColor = Color.Orange;
                HaveNonAscillInRegFolder = true;
            }

            //OutputPath
            tbxOutputPath.ForeColor = Color.Black;
            tbxOutputPath.Text = TrainParams.Current.OutputPath;
            if (CheckUtil.HaveNonAsciiOrSpace(TrainParams.Current.OutputPath))
            {
                tbxOutputPath.ForeColor = Color.Orange;
                HaveNonAscillInOutputPath = true;
            }

            if (!Directory.Exists(TrainParams.Current.OutputPath))
            {
                tbxOutputPath.ForeColor = Color.Red;
            }
            //Epochs
            nudEpochs.Value = TrainParams.Current.Epochs;
            //LR
            tbxLR.Text = TrainParams.Current.LearningRate.ToString("g");
            CheckLR();
            //Reso
            nudResolution.Value = TrainParams.Current.Resolution;
            IsInvalidResolution = TrainParams.Current.Resolution % 64 != 0;
            lblResolution.ForeColor = IsInvalidResolution ? Color.Red : Color.Black;
            //BatchSize
            nudBatchSize.Value = TrainParams.Current.BatchSize;
            //NetworkDim
            nudNetworkDim.Value = TrainParams.Current.NetworkDim;
            //NetworkAlpha
            nudNetworkAlpha.Value = TrainParams.Current.NetworkAlpha;
            //Shuffle
            cbxShuffle.Checked = TrainParams.Current.ShuffleCaptions;
            //KeepTokens
            nudKeepTokens.Value = TrainParams.Current.KeepTokenCount;
            //SaveEveryNEpoch
            nudSaveEpoch.Value = TrainParams.Current.SaveEveryNEpochs;
            //Optimizer
            cbxOptimizer.SelectedIndex = (int)TrainParams.Current.OptimizerType;
            //ModuleType
            cbxModuleType.SelectedIndex = (int)TrainParams.Current.ModuleType;
            //OutputName
            tbxFileName.Text = TrainParams.Current.OutputName;
            tbxFileName.ForeColor = Color.Black;
            if (CheckUtil.HaveNonAsciiOrSpace(tbxFileName.Text))
            {
                tbxFileName.ForeColor = Color.Orange;
                HaveNonAscillInOutputName = true;
            }
            //WarmupSteps
            nudWarmupSteps.Value = TrainParams.Current.WarmupSteps;

            UpdateTotalStepCount();
        }

        private DialogResult NotifyBadParams()
        {
            switch (TrainParams.Current.OptimizerType)
            {
                case OptimizerType.AdamW8bit:
                case OptimizerType.AdamW:
                case OptimizerType.AdaFactor:
                    {
                        if (TrainParams.Current.LearningRate > 0.02f)
                            return MessageBox.Show("現在のOptimizerに対するLRが高すぎます(推奨値:0.00005-0.001)。\n発散して失敗する可能性が高いですが、開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    break;
                case OptimizerType.DAdaptation:
                case OptimizerType.DAdaptAdaGrad:
                case OptimizerType.DAdaptAdam:
                case OptimizerType.DAdaptAdan:
                case OptimizerType.DAdaptSGD:
                case OptimizerType.DAdaptAdanIP:
                case OptimizerType.DAdaptLion:
                    {
                        if (TrainParams.Current.LearningRate > 3)
                            return MessageBox.Show("現在のOptimizerに対するLRが高すぎます(推奨値:1)。\n発散して失敗する可能性が高いですが、開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        else if (TrainParams.Current.LearningRate < 0.1f)
                            return MessageBox.Show("現在のOptimizerに対するLRが低すぎます(推奨値:1)。\n何も学習しない可能性が高いですが、開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    break;
            }

            return DialogResult.Yes;
        }

    }
}

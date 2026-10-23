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
        internal static string? ScriptPath = string.Empty;
        private string? LastOpenPresetPath = string.Empty;
        private bool IsReady = false;
        internal static bool TrainingClosedWithNonZeroExit = false;

        private bool PrevCustomCmdActiveFlag = false, PrevAddArgActiveFlag = false, PrevCustomOptActiveFlag = false;
        private bool LogGenerated = true;

        internal static TrainCompleteAction CompleteAction = TrainCompleteAction.None;

        public Form1()
        {
            InitializeComponent();
            new TrainParams();
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
            cbxCompleteAction.SelectedIndex = 0;
            MyUtils.InitRegistry();
            //一応LoRAEasyTrainingのフォルダ名にも対応させる
            if (Directory.Exists(@"..\sd-scripts\"))
            {
                Constants.CurrentSdScriptsPath = @"..\sd-scripts\";
            }
            else if (Directory.Exists(@"..\sd_scripts\"))
            {
                Constants.CurrentSdScriptsPath = @"..\sd_scripts\";
            }

            //先に親フォルダにpyがあるか確認する。
            //なければボタンを表示する
            //ない状態でカスタムパスにもpyがないなら赤字で設定するよう促す(デバッグ環境のみ)
            if (!File.Exists(Constants.CurrentSdScriptsPath + @"train_network.py"))
            {
                btnInstaller.Visible = true;
#if DEBUG
                btnCustomScriptPath.Visible = true;
                lblScriptPathDesc.Visible = true;
                ScriptPath = (string?)Registry.GetValue(@"HKEY_CURRENT_USER\Software\kohya_lora_gui", "ScriptPath", string.Empty);
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
                ScriptPath = string.Empty;
#endif
            }
            else
            {
                btnCustomScriptPath.Visible = false;
                lblScriptPathDesc.Visible = false;
                btnInstaller.Visible = false;
            }

            MyUtils.CheckAndCreateWorkDir();
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string document = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string oldPath = document + @"\autosave.xmlora";
            string newPath = document + @"\lora-gui\autosave.xmlora";

            if (File.Exists(oldPath) && !File.Exists(newPath))
            {
                File.Move(oldPath, newPath);
            }

            if (File.Exists(newPath))
            {
                try
                {
                    XmlSerializer se = new XmlSerializer(typeof(TrainParams));
                    using (StreamReader sr = new StreamReader(newPath, new UTF8Encoding(false)))
                    {
                        para = TrainParams.Current = (TrainParams?)se.Deserialize(sr);
                    }
                }
                catch
                {
                    MessageBox.Show("自動保存プリセットを読み込めません。破損しているか、権限がありません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    new TrainParams();
                }
            }

            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (para.IsOptimizerUnknown)
            {
                MessageBox.Show("プリセットファイルで指定されたOptimizerが不明なため、\r\nAdamW8bitに変更しました。", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (para.IsModuleTypeUnkown)
            {
                MessageBox.Show("プリセットファイルで指定されたモジュールの種類が不明なため、\r\nLoRAに変更しました。", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (para.IsModelArchitectureUnkown)
            {
                MessageBox.Show("プリセットファイルで指定されたモデルの種類が不明かサポート終了済みのため、\r\nSD1に変更しました。", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            para.OverwriteCustomOptName();
            para.OverwriteCustomOptArgs();
            para.CheckBrokenBlockDim();
            para.FixDeprecatedParams(true);

            MyUtils.LoadDefaultDirSettings();

            UpdateAllContents();

            UpdateChecker.AutomaticCheckUpdate();

            IsReady = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form adv = new FormAdvanced();
            adv.ShowDialog();

            adv.Dispose();

            UpdateAllContents();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Constants.WEIGHT_EXTENSION_FILTER;
            ofd.Title = "Select a base model";
            ofd.RestoreDirectory = true;


            if (File.Exists(para.ModelPath))
            {
                ofd.InitialDirectory = Path.GetDirectoryName(para.ModelPath);
            }
            else if (Directory.Exists(MyUtils.GetDefaultDir("ModelDir")))
            {
                ofd.InitialDirectory = MyUtils.GetDefaultDir("ModelDir");
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                para.ModelPath = ofd.FileName;
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

        private void ShowDatasetDocument()
        {
            try
            {
                //.NET CoreではUseShellExecute=trueにしないとファイルがないと怒る
                Process.Start(new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = "https://github.com/kohya-ss/sd-scripts/blob/main/docs/train_README-ja.md",
                });
            }
            catch
            {
                MessageBox.Show("ブラウザを開けません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select an image folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;
            if (Directory.Exists(para.TrainImagePath))
            {
                cof.InitialDirectory = para.TrainImagePath;
            }
            else if (Directory.Exists(MyUtils.GetDefaultDir("ImageDir")))
            {
                cof.InitialDirectory = MyUtils.GetDefaultDir("ImageDir");
            }

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                HaveNonAscillInImageFolder = false;
                para.TrainImagePath = cof.FileName;
                tbxImagePath.Text = para.TrainImagePath;
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
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select Reg Image Folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (Directory.Exists(para.RegImagePath))
            {
                cof.InitialDirectory = para.RegImagePath;
            }
            else if (Directory.Exists(MyUtils.GetDefaultDir("RegImageDir")))
            {
                cof.InitialDirectory = MyUtils.GetDefaultDir("RegImageDir");
            }

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {

                para.RegImagePath = cof.FileName;
                tbxRegImgPath.Text = para.RegImagePath;
                HaveNonAscillInRegFolder = false;


                tbxRegImgPath.ForeColor = IsInvalidRegFolder ? Color.Red : Color.Black;
                if (CheckUtil.HaveNonAsciiOrSpace(para.RegImagePath) && !IsInvalidRegFolder)
                {
                    tbxRegImgPath.ForeColor = Color.Orange;
                    HaveNonAscillInRegFolder = true;
                }
            }
            UpdateTotalStepCount();
        }

        private void btnOutputPath_Click(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CommonOpenFileDialog cof = new CommonOpenFileDialog();
            cof.Title = "Select Output Folder";
            cof.IsFolderPicker = true;
            cof.RestoreDirectory = true;

            if (Directory.Exists(para.OutputPath))
            {
                cof.InitialDirectory = para.OutputPath;
            }
            else if (Directory.Exists(MyUtils.GetDefaultDir("OutputDir")))
            {
                cof.InitialDirectory = MyUtils.GetDefaultDir("OutputDir");
            }

            if (cof.ShowDialog() == CommonFileDialogResult.Ok)
            {
                para.OutputPath = cof.FileName;
                tbxOutputPath.Text = para.OutputPath;
                HaveNonAscillInRegFolder = false;
                if (CheckUtil.HaveNonAsciiOrSpace(para.OutputPath))
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
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            para.RegImagePath = string.Empty;
            tbxRegImgPath.Text = string.Empty;
            IsInvalidRegFolder = false;
            UpdateTotalStepCount();
        }

        private void nudEpochs_ValueChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            para.Epochs = (int)nudEpochs.Value;
            UpdateTotalStepCount();
        }

        private void tbxLR_TextChanged(object sender, EventArgs e)
        {
            CheckLR(true);
        }

        private void CheckLR(bool changeParam = false)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
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
                        para.LearningRate = lr;
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
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.Resolution = (int)nudResolution.Value;
            IsInvalidResolution = nudResolution.Value % 64 != 0;
            lblResolution.ForeColor = IsInvalidResolution ? Color.Red : Color.Black;
        }

        private void nudBatchSize_ValueChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.BatchSize = (int)nudBatchSize.Value;
            UpdateTotalStepCount();
        }

        private void nudNetworkDim_ValueChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.NetworkDim = (int)nudNetworkDim.Value;
            PredictLoraFilesize();
        }

        private void nudNetworkAlpha_ValueChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.NetworkAlpha = nudNetworkAlpha.Value;
        }

        private void cbxShuffle_CheckedChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.ShuffleCaptions = cbxShuffle.Checked;
        }

        private void nudKeepTokens_ValueChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.KeepTokenCount = (int)nudKeepTokens.Value;
        }

        private void nudSaveEpoch_ValueChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.SaveEveryNEpochs = (int)nudSaveEpoch.Value;
        }

        private void btnSavePreset_Click(object sender, EventArgs e)
        {
            ShowSavePresetDialog();
        }

        private void ShowSavePresetDialog()
        {
            if (IsInvalidOutputName)
            {
                MessageBox.Show("出力ファイル名が間違った状態では\nプリセットの保存はできません", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxOverwrite.Checked && File.Exists(LastOpenPresetPath))
            {
                try
                {
                    XmlSerializer se = new XmlSerializer(typeof(TrainParams));
                    using (StreamWriter sw = new StreamWriter(LastOpenPresetPath, false, new UTF8Encoding(false)))
                    {
                        se.Serialize(sw, TrainParams.Current);
                    }
                    MessageBox.Show("保存しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("プリセットを保存できません。他のアプリが開いているか、権限がありません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "New Preset.xmlora";
                sfd.Filter = "LoRA Preset(*.xmlora)|*.xmlora";
                sfd.Title = "Save a preset";
                sfd.RestoreDirectory = true;
                if (File.Exists(LastOpenPresetPath))
                {
                    sfd.InitialDirectory = Path.GetDirectoryName(LastOpenPresetPath);
                }
                else if (Directory.Exists(MyUtils.GetDefaultDir("SavePresetDir")))
                {
                    sfd.InitialDirectory = MyUtils.GetDefaultDir("SavePresetDir");
                }


                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XmlSerializer se = new XmlSerializer(typeof(TrainParams));
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(false)))
                        {
                            se.Serialize(sw, TrainParams.Current);
                        }
                        LastOpenPresetPath = sfd.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("プリセットを保存できません。他のアプリが開いているか、権限がありません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnStartTraining_Click(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TrainingClosedWithNonZeroExit = false;
            LogGenerated = true;
            string str = string.IsNullOrEmpty(ScriptPath) ? Constants.CurrentSdScriptsPath : ScriptPath + "\\";

            if (!HasScriptFile(str, true) || !IsCommandAvailable(true) || !IsAdditionalArgsAvailable(true))
                return;

            if (NotifyBadParams() != DialogResult.Yes)
                return;

            if (File.Exists(para.OutputPath + "\\" + para.OutputName + ".safetensors"))
            {
                var res = MessageBox.Show("出力先に同名のファイルが存在します。学習完了時に上書きされますがよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No) return;
            }



            if (BatchProcess.BatchStack.Count > 0)
            {
                BatchProcess.IsCancel = false;
                BatchProcess.IsRunning = true;
                BatchProcess.SkippedCount = 0;
                BatchProcess.CompletedCount = 0;
                BatchProcess.FailCount = 0;
                BatchProcess.CountTrainingCrashed = 0;
                LogGenerated = !BatchProcess.LogResultText;
                BatchProcess.LogText += "開始時刻: " + DateTime.Now.ToString() + "\r\n";

                while (BatchProcess.BatchStack.Count > 0)
                {
                    string pth = BatchProcess.BatchStack.Pop();
                    //必須のファイルがない
                    if (!HasScriptFile(str, false))
                    {
                        Debug.WriteLine("Skip training. required files are not found");
                        BatchProcess.LogText += para.OutputPath + "\\" + para.OutputName + ".safetensors\r\ntrain_network.pyがないためスキップ\r\n\r\n";

                        BatchProcess.SkippedCount++;
                        continue;
                    }

                    //空文字はスルー
                    if (string.IsNullOrWhiteSpace(pth))
                    {
                        continue;
                    }

                    //プリセットなし
                    if (!File.Exists(pth))
                    {
                        Debug.WriteLine("Skipping training. Invalid path: " + pth);
                        if (!string.IsNullOrWhiteSpace(pth))
                        {
                            BatchProcess.LogText += pth + "\r\nプリセットがないためスキップ\r\n\r\n";
                        }

                        BatchProcess.SkippedCount++;
                        continue;
                    }


                    if (!LoadPreset(pth, false))
                    {
                        Debug.WriteLine("Skipped. Errored.");
                        if (!string.IsNullOrWhiteSpace(pth))
                        {
                            BatchProcess.LogText += pth + "\r\nプリセット読込失敗のためスキップ\r\n\r\n";
                        }

                        BatchProcess.SkippedCount++;
                        continue;
                    }

                    //コマンドがおかしい
                    if (!IsCommandAvailable(false))
                    {
                        Debug.WriteLine("Skipped. Invalid commands");
                        if (!string.IsNullOrWhiteSpace(pth))
                        {
                            BatchProcess.LogText += pth + "\r\nコマンドが不適切なためスキップ\r\n\r\n";
                        }

                        BatchProcess.SkippedCount++;
                        continue;
                    }

                    //コマンドがおかしい
                    if (!IsAdditionalArgsAvailable(false))
                    {
                        Debug.WriteLine("Skipped. Invalid additional args");
                        if (!string.IsNullOrWhiteSpace(pth))
                        {
                            BatchProcess.LogText += pth + "\r\n追加引数が不適切なためスキップ\r\n\r\n";
                        }

                        BatchProcess.SkippedCount++;
                        continue;
                    }

                    if (para.IsOptimizerUnknown || para.IsModelArchitectureUnkown || para.IsModuleTypeUnkown)
                    {
                        Debug.WriteLine("Skipped. Unknown model or optimizer");
                        if (!string.IsNullOrWhiteSpace(pth))
                        {
                            BatchProcess.LogText += pth + "\r\nオプティマイザ、モデル、モジュールのいずれかの種類が不明なためスキップ\r\n\r\n";
                        }

                        BatchProcess.SkippedCount++;
                        continue;
                    }

                    //コマンド未指定かつLoRAパラメータがおかしい
                    if (!IsTrainingAvailable(false) && IsCommandEmpty())
                    {
                        Debug.WriteLine("Skipping training. Invalid params in: " + pth);
                        BatchProcess.LogText += pth + "\r\nプリセットの設定が不適切なためスキップ\r\n\r\n";
                        BatchProcess.SkippedCount++;
                        continue;
                    }
                    Debug.WriteLine("Start training: " + pth);
                    Form train0 = new TrainForm(false, LastOpenPresetPath);
                    train0.ShowDialog();
                    train0.Dispose();
                    BatchProcess.CompletedCount++;
                }

                if (!BatchProcess.IsCancel && BatchProcess.LogResultText && !string.IsNullOrWhiteSpace(BatchProcess.LogText))
                {
                    string sstr = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\batchlog-" + DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss") + ".txt";
                    using (StreamWriter sw = new StreamWriter(sstr, false, new UTF8Encoding(false)))
                    {
                        sw.WriteLine(BatchProcess.LogText);
                    }
                }
                LogGenerated = true;
                if ((CompleteAction == TrainCompleteAction.Shutdown || CompleteAction == TrainCompleteAction.Suspend) && !BatchProcess.IsCancel)
                {
                    Form train0 = new TrainForm(true);
                    train0.ShowDialog();
                    train0.Dispose();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("バッチ処理が終了しました。\n").Append(BatchProcess.CompletedCount).Append("件が終了し");
                    if (BatchProcess.SkippedCount > 0)
                    {
                        sb.Append("、").Append(BatchProcess.SkippedCount).Append("件がスキップされました。");
                    }
                    else
                    {
                        sb.Append("ました。");
                    }

                    if (BatchProcess.CountTrainingCrashed > 0)
                    {
                        sb.Append("\n終了したものの内").Append(BatchProcess.CountTrainingCrashed).Append("件がエラーで失敗したか手動で停止されました。");
                    }

                    if (BatchProcess.FailCount > 0)
                    {
                        sb.Append("\n終了したものの内").Append(BatchProcess.FailCount).Append("件が失敗した可能性があります。");
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
                cbxCompleteAction.SelectedIndex = (int)CompleteAction;
                return;
            }
            if (!IsTrainingAvailable(true))
            {
                DialogResult res = MessageBox.Show("設定が正しくない可能性がありますが、\n続けてもよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
            }


            Debug.WriteLine("Execute the command");

            Form train = new TrainForm(false);
            train.ShowDialog();
            train.Dispose();
            cbxCompleteAction.SelectedIndex = (int)CompleteAction;
            if (CompleteAction == TrainCompleteAction.CloseTerminal)
            {
                StringBuilder sb = new StringBuilder();
                bool failed = !File.Exists(para.OutputPath + "\\" + para.OutputName + ".safetensors") && string.IsNullOrWhiteSpace(para.CustomCommands);
                if (TrainingClosedWithNonZeroExit)
                {
                    sb.Append("コマンド実行(学習)がクラッシュしたか、手動で強制終了されました。");
                }
                else if(failed)
                {
                    sb.Append("コマンド実行(学習)が終了しましたが失敗した可能性があります。");
                }
                else
                {
                    sb.Append("コマンド実行(学習)が終了しました。");
                }

                MessageBox.Show(sb.ToString(), "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool HasScriptFile(string str, bool showMsg)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return false;
            }
            switch (para.ModelArchitectureEnum)
            {
                case ModelArchitecture.Legacy:
                    if (!File.Exists(str + "train_network.py"))
                    {
                        if (showMsg)
                            MessageBox.Show("train_network.pyが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    break;
                case ModelArchitecture.XL:
                    if (!File.Exists(str + @"sdxl_train_network.py"))
                    {
                        if (showMsg)
                            MessageBox.Show("sdxl_train_network.pyが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    break;
                case ModelArchitecture.Anima:
                    if (!File.Exists(str + "anima_train_network.py"))
                    {
                        if (showMsg)
                            MessageBox.Show("anima_train_network.pyが見つかりません。\r\nsd-scriptsのアップデートをお試しください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    break;
                case ModelArchitecture.MossImage:
                    if (!File.Exists(str + "moss_image_train_network.py"))
                    {
                        if (showMsg)
                            MessageBox.Show("moss_image_train_network.pyが見つかりません。\r\nsd-scriptsのアップデートをお試しください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    break;
            }
            if (!Directory.Exists(str + "venv"))
            {
                if (showMsg)
                    MessageBox.Show("Pythonの仮想環境(venv)が見つかりません。\r\nユーティリティからvenvの再生成ができます。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// カスタムコマンドは適切または未指定ですか？
        /// </summary>
        /// <param name="showMsg">適切でない場合にメッセージボックスを表示する。</param>
        /// <returns></returns>
        private bool IsCommandAvailable(bool showMsg)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return false;
            }
            string command = para.CustomCommands.Trim();
            command = command.Replace("\r\n", string.Empty);
            command = command.Trim();
            if (string.IsNullOrWhiteSpace(command))
            {
                return true;
            }
            else
            {
                if ((!command.StartsWith("python") && !command.StartsWith("accelerate")) || command.Contains("&&"))
                {
                    if (showMsg)
                        MessageBox.Show("そのカスタムコマンドは使用できません。\r\n「カスタムコマンド」タブを確認してください。\r\n不要であればカスタムコマンドを空にしてください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
        }

        private bool IsCommandEmpty()
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return true;
            }
            string command = para.CustomCommands.Trim();
            command = command.Replace("\r\n", string.Empty);
            command = command.Trim();
            return string.IsNullOrWhiteSpace(command);
        }

        private bool IsAdditionalArgsAvailable(bool showMsg)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return false;
            }
            if (!string.IsNullOrEmpty(para.AdditionalArgs))
            {
                string str = para.AdditionalArgs.Trim();
                if (str.Contains("&&"))
                {
                    if (showMsg)
                        MessageBox.Show("追加の引数に&&は使用できません。\r\n「追加の引数」タブを確認してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(para.AdditionalNetworkArgs))
            {
                string str = para.AdditionalNetworkArgs.Trim();
                if (str.Contains("&&"))
                {
                    if (showMsg)
                        MessageBox.Show("追加のnetwork_argsに&&は使用できません。\r\n「追加の引数」タブを確認してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// 学習を開始できる設定ですか？
        /// </summary>
        /// <param name="showMsg">適切でない設定についてメッセージボックスを表示する。</param>
        /// <returns></returns>
        private bool IsTrainingAvailable(bool showMsg)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string command = para.CustomCommands.Trim();
            command = command.Replace("\r\n", string.Empty);
            if (!string.IsNullOrWhiteSpace(command))
            {
                return true;
            }

            if (IsInvalidImageFolder)
            {
                if (showMsg)
                {
                    MessageBox.Show("教師画像フォルダが存在しないか不適切な文字があります。\r\n正しいパスを指定してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }

            if (IsInvalidRegFolder)
            {
                if (showMsg)
                {
                    MessageBox.Show("正則化画像フォルダが存在しないか不適切な文字があります。\r\n正しいパスを指定してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }

            if (IsInvalidOutputName)
            {
                if (showMsg)
                {
                    MessageBox.Show("出力ファイル名が未指定か不適切です。\r\n使用できない文字を含まない適切な名前を設定してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }

            if (IsInvalidLR)
            {
                if (showMsg)
                {
                    MessageBox.Show("学習率(LR)が不適切です。\r\n正しい値を指定してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }

            if (IsInvalidResolution)
            {
                if (showMsg)
                {
                    MessageBox.Show("解像度が不適切です。\r\n64で割り切れる値を指定してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }

            if (!File.Exists(para.ModelPath))
            {
                if (showMsg)
                    MessageBox.Show("学習元モデルが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Directory.Exists(para.TrainImagePath))
            {
                if (showMsg)
                    MessageBox.Show("教師画像フォルダが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrEmpty(para.RegImagePath) && !Directory.Exists(para.RegImagePath))
            {
                if (showMsg)
                    MessageBox.Show("正則化画像フォルダが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Directory.Exists(para.OutputPath))
            {
                if (showMsg)
                    MessageBox.Show("出力先フォルダが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrEmpty(para.TensorBoardLogPath) && !Directory.Exists(para.TensorBoardLogPath))
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

            if (!string.IsNullOrEmpty(para.LoraModelPath) && !File.Exists(para.LoraModelPath))
            {
                if (showMsg)
                    MessageBox.Show("追加学習するLoRAモデルが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrEmpty(para.VAEPath) && !File.Exists(para.VAEPath))
            {
                if (showMsg)
                    MessageBox.Show("VAEが見つかりません。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (para.OptimizerTypeEnum == Optimizer.Custom && string.IsNullOrWhiteSpace(para.CustomOptName))
            {
                if (showMsg)
                    MessageBox.Show("オプティマイザにカスタムが指定されていますが、\r\nオプティマイザの名称が指定されていません。\r\nカスタムオプティマイザで指定してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (para.ModelArchitectureEnum == ModelArchitecture.Anima)
            {
                if (!File.Exists(para.VAEPath))
                {
                    if (showMsg)
                        MessageBox.Show("AnimaはVAEが必須ですが、ファイルが見つかりません(または未指定)。\r\n詳細設定->パスにて正しいファイルを指定してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (!File.Exists(para.Qwen3Path))
                {
                    if (showMsg)
                        MessageBox.Show("AnimaはQwen3 TEが必須ですが、ファイルが見つかりません(または未指定)。\r\n詳細設定->パスにて正しいファイルを指定してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (para.ModelArchitectureEnum == ModelArchitecture.MossImage)
            {
                if (!File.Exists(para.VAEPath))
                {
                    if (showMsg)
                        MessageBox.Show("MOSS-ImageはVAEが必須ですが、ファイルが見つかりません(または未指定)。\r\n詳細設定->パスにて正しいファイルを指定してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (!File.Exists(para.TextEncoderPath))
                {
                    if (showMsg)
                        MessageBox.Show("AnimaはText Encoderが必須ですが、ファイルが見つかりません(または未指定)。\r\n詳細設定->パスにて正しいファイルを指定してください。", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void ShowLoadPresetDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "LoRA Preset(*.xmlora)|*.xmlora";
            ofd.Title = "Select a preset";
            ofd.RestoreDirectory = true;
            if (Directory.Exists(MyUtils.GetDefaultDir("LoadPresetDir")))
            {
                ofd.InitialDirectory = MyUtils.GetDefaultDir("LoadPresetDir");
            }
            else if (File.Exists(LastOpenPresetPath))
            {
                ofd.InitialDirectory = Path.GetDirectoryName(LastOpenPresetPath);
            }


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadPreset(ofd.FileName, true);
            }
        }

        private void btnLoadPreset_Click(object sender, EventArgs e)
        {
            ShowLoadPresetDialog();
        }

        private bool LoadPreset(string path, bool ShowMsg)
        {
            if (!File.Exists(path))
            {
                if (ShowMsg)
                    MessageBox.Show("プリセットファイルが見つかりません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastOpenPresetPath = string.Empty;
                return false;
            }
            var para = TrainParams.Current;
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                XmlSerializer se = new XmlSerializer(typeof(TrainParams));
                using (StreamReader sr = new StreamReader(path, new System.Text.UTF8Encoding(false)))
                {
                    para = TrainParams.Current = (TrainParams?)se.Deserialize(sr);
                }

            }
            catch
            {
                Debug.WriteLine("Failed to load preset");
                if (ShowMsg)
                    MessageBox.Show("プリセットを読み込めません。破損しているか、権限がありません。\r\nあるいは、より新しいバージョンのGUIで作成された可能性があります。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastOpenPresetPath = string.Empty;
                return false;
            }
            if (para == null)
            {
                MessageBox.Show("エラーが発生しました。アプリを再起動してください。", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (para.IsOptimizerUnknown && ShowMsg)
            {
                MessageBox.Show("プリセットファイルで指定されたOptimizerが不明なため、\r\nAdamW8bitに変更しました。", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (para.IsModelArchitectureUnkown && ShowMsg)
            {
                MessageBox.Show("プリセットファイルで指定されたモデルの種類が不明かサポート終了済みのため、\r\nSD1に変更しました。", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (para.IsModuleTypeUnkown && ShowMsg)
            {
                MessageBox.Show("プリセットファイルで指定されたモジュールの種類が不明なため、\r\nLoRAに変更しました。", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LastOpenPresetPath = path;

            para.OverwriteCustomOptName();
            para.OverwriteCustomOptArgs();
            para.FixDeprecatedParams(true);
            para.CheckBrokenBlockDim();
            UpdateAllContents();
            return true;
        }

        private void tbxOutputPath_TextChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            string str = tbxOutputPath.Text.Trim();
            if (str.EndsWith("\\"))
            {
                str = str.Remove(str.Length - 1, 1);
            }


            para.OutputPath = str;
            if (!Directory.Exists(para.OutputPath))
            {
                tbxOutputPath.ForeColor = Color.Red;
                HaveNonAscillInOutputPath = false;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(para.OutputPath))
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
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.WarmupSteps = nudWarmupSteps.Value;
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

            if (!File.Exists(Constants.CurrentSdScriptsPath + @"train_network.py"))
            {
                btnInstaller.Visible = true;
                lblScriptPathDesc.Visible = true;
                lblScriptPathDesc.ForeColor = Color.Red;
                lblScriptPathDesc.Text = "train_network.pyがみつかりません";

            }
            else
            {
                btnCustomScriptPath.Visible = false;
                lblScriptPathDesc.Visible = false;
                btnInstaller.Visible = false;
            }

        }

        private void cbxModuleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.ModuleTypeEnum = (NetworkModule)Enum.ToObject(typeof(NetworkModule), cbxModuleType.SelectedIndex);
            PredictLoraFilesize();
        }

        private void btnGenerateCommands_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MyUtils.GenerateCommands());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!LogGenerated && BatchProcess.LogResultText && !BatchProcess.IsCancel && !string.IsNullOrWhiteSpace(BatchProcess.LogText))
            {
                BatchProcess.LogText += "\r\n" + DateTime.Now.ToString() + ": 上記ファイルを出力する前にGUIが終了。Windows Updateや特定ソフトウェアによる再起動の可能性あり。以下実行予定だったプリセット:\r\n\r\n";
                while (BatchProcess.BatchStack.Count > 0)
                {
                    string pth = BatchProcess.BatchStack.Pop();
                    BatchProcess.LogText += pth + "\r\n";

                }

                string sstr = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\batchlog-" + DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss") + ".txt";
                using (StreamWriter sw = new StreamWriter(sstr, false, new UTF8Encoding(false)))
                {
                    sw.WriteLine(BatchProcess.LogText);
                }
                LogGenerated = true;
            }

            if (IsInvalidOutputName)
                return;
            string document = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            MyUtils.CheckAndCreateWorkDir();

            string str = document + @"\lora-gui\autosave.xmlora";
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
                Debug.WriteLine("自動保存書き込みできない");
            }
        }

        private void cbxSDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.ModelArchitectureEnum = (ModelArchitecture)Enum.ToObject(typeof(ModelArchitecture), cbxSDType.SelectedIndex);
            PredictLoraFilesize();
        }

        private void cbxEpochOrStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.IsEpoch = cbxEpochOrStep.SelectedIndex == 0;
            UpdateTotalStepCount();
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
                if (!Directory.Exists(ScriptPath))
                {
                    ScriptPath = string.Empty;
                }

                Registry.SetValue(@"HKEY_CURRENT_USER\Software\kohya_lora_gui", "ScriptPath", ScriptPath);
            }
        }

        private void cbxOptimizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.OptimizerTypeEnum = (Optimizer)Enum.ToObject(typeof(Optimizer), cbxOptimizer.SelectedIndex);
        }

        private void tbxModelPath_TextChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.ModelPath = tbxModelPath.Text.Trim();
            if (!File.Exists(para.ModelPath))
            {
                tbxModelPath.ForeColor = Color.Red;
                HaveNonAscillInModelPath = false;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(para.ModelPath))
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
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            string str = tbxImagePath.Text.Trim();
            if (str.EndsWith("\\"))
            {
                str = str.Remove(str.Length - 1, 1);
            }


            para.TrainImagePath = str;
            if (!Directory.Exists(para.TrainImagePath))
            {
                tbxImagePath.ForeColor = Color.Red;
                IsInvalidImageFolder = true;
                HaveNonAscillInImageFolder = false;
                StepsPerEpoch = 0;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(para.TrainImagePath))
            {
                tbxImagePath.ForeColor = Color.Orange;
                HaveNonAscillInImageFolder = true;
                IsInvalidImageFolder = !CheckUtil.IsImageDirectoryValid(para.TrainImagePath, out StepsPerEpoch);
            }
            else
            {
                IsInvalidImageFolder = !CheckUtil.IsImageDirectoryValid(para.TrainImagePath, out StepsPerEpoch);
                tbxImagePath.ForeColor = IsInvalidImageFolder ? Color.Red : Color.Black;
                HaveNonAscillInImageFolder = false;
            }
            UpdateTotalStepCount();

        }

        private void tbxRegImgPath_TextChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            string str = tbxRegImgPath.Text.Trim();
            if (str.EndsWith("\\"))
            {
                str = str.Remove(str.Length - 1, 1);
            }

            para.RegImagePath = str;
            if (string.IsNullOrEmpty(para.RegImagePath))
            {
                UpdateTotalStepCount();
                tbxRegImgPath.ForeColor = IsInvalidRegFolder ? Color.Red : Color.Black;
                HaveNonAscillInRegFolder = false;
                return;
            }

            if (!Directory.Exists(para.RegImagePath))
            {
                tbxRegImgPath.ForeColor = Color.Red;
                IsInvalidRegFolder = true;
                HaveNonAscillInRegFolder = false;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(para.RegImagePath))
            {
                tbxRegImgPath.ForeColor = Color.Orange;
                HaveNonAscillInRegFolder = true;
                int num = 0;
                IsInvalidRegFolder = !CheckUtil.IsImageDirectoryValid(para.RegImagePath, out num);
            }
            else
            {
                int num = 0;
                IsInvalidRegFolder = !CheckUtil.IsImageDirectoryValid(para.RegImagePath, out num);
                tbxRegImgPath.ForeColor = IsInvalidRegFolder ? Color.Red : Color.Black;
                HaveNonAscillInRegFolder = false;
            }
            UpdateTotalStepCount();
        }

        private void tbxFileName_TextChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.OutputName = tbxFileName.Text.Trim();
            HaveNonAscillInOutputName = false;
            Regex regex = new Regex("[&:/\\\\\\?\\*<>\\|\"'`]");
            if (regex.IsMatch(para.OutputName))
            {
                lblFileName.ForeColor = Color.Red;
                tbxFileName.ForeColor = Color.Red;
                IsInvalidOutputName = true;
                return;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(para.OutputName))
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
            var para = TrainParams.Current;
            if (para == null)
            {
                lblNumSteps.Text = "エラー";
                lblNumStepsBatch1.Text = "エラー";
                return;
            }
            try
            {
                if (para.IsEpoch)
                {
                    if (StepsPerEpoch <= 0 || (!string.IsNullOrEmpty(para.RegImagePath) && !Directory.Exists(para.RegImagePath)))
                    {
                        lblNumSteps.Text = "?";
                        lblNumStepsBatch1.Text = "?";
                    }
                    else
                    {
                        //sd-scriptsに近い計算式でもずれるときはずれる。Bucketingの影響らしい
                        decimal eps = (decimal)StepsPerEpoch / para.BatchSize / para.GradAccSteps;

                        TotalSteps = para.Epochs * Math.Ceiling(eps);

                        TotalStepsBatch1 = StepsPerEpoch * para.Epochs;
                        if (!string.IsNullOrEmpty(para.RegImagePath))
                        {
                            TotalSteps *= 2;
                            TotalStepsBatch1 *= 2;
                        }


                        lblNumSteps.Text = TotalSteps.ToString("#,0");
                        lblNumStepsBatch1.Text = TotalStepsBatch1.ToString("#,0");
                    }
                }
                else
                {
                    lblNumSteps.Text = para.Epochs.ToString("#,0");
                    lblNumStepsBatch1.Text = (para.Epochs * para.BatchSize * para.GradAccSteps).ToString("#,0");
                }
            }
            catch (Exception ex)
            {
                lblNumSteps.Text = "エラー";
                lblNumStepsBatch1.Text = "エラー";
                Debug.WriteLine("Error checking steps: " + ex.Message);
            }

        }

        private void UpdateAllContents()
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            HaveNonAscillInImageFolder = false;
            HaveNonAscillInModelPath = false;
            HaveNonAscillInOutputName = false;
            HaveNonAscillInRegFolder = false;
            HaveNonAscillInOutputPath = false;
            //ModelPath
            tbxModelPath.Text = para.ModelPath;
            tbxModelPath.ForeColor = Color.Black;
            if (!File.Exists(para.ModelPath))
            {
                tbxModelPath.ForeColor = Color.Red;
            }
            else if (CheckUtil.HaveNonAsciiOrSpace(para.ModelPath))
            {
                tbxModelPath.ForeColor = Color.Orange;
                HaveNonAscillInModelPath = true;
            }

            //TrainImage
            tbxImagePath.Text = para.TrainImagePath;
            IsInvalidImageFolder = !CheckUtil.IsImageDirectoryValid(para.TrainImagePath, out StepsPerEpoch);
            tbxImagePath.ForeColor = IsInvalidImageFolder ? Color.Red : Color.Black;
            if (CheckUtil.HaveNonAsciiOrSpace(para.TrainImagePath))
            {
                tbxImagePath.ForeColor = Color.Orange;
                HaveNonAscillInImageFolder = true;
            }

            //RegImage
            tbxRegImgPath.Text = para.RegImagePath;
            if (!string.IsNullOrEmpty(para.RegImagePath))
            {
                int num = 0;
                IsInvalidRegFolder = !CheckUtil.IsImageDirectoryValid(para.RegImagePath, out num);
            }
            else
            {
                IsInvalidRegFolder = false;
            }
            tbxRegImgPath.ForeColor = IsInvalidRegFolder ? Color.Red : Color.Black;

            if (CheckUtil.HaveNonAsciiOrSpace(para.RegImagePath))
            {
                tbxRegImgPath.ForeColor = Color.Orange;
                HaveNonAscillInRegFolder = true;
            }

            //OutputPath
            tbxOutputPath.ForeColor = Color.Black;
            tbxOutputPath.Text = para.OutputPath;
            if (CheckUtil.HaveNonAsciiOrSpace(para.OutputPath))
            {
                tbxOutputPath.ForeColor = Color.Orange;
                HaveNonAscillInOutputPath = true;
            }

            if (!Directory.Exists(para.OutputPath))
            {
                tbxOutputPath.ForeColor = Color.Red;
            }
            //Epochs
            nudEpochs.Value = para.Epochs;
            //LR
            tbxLR.Text = para.LearningRate.ToString("g");
            CheckLR();
            //Reso
            nudResolution.Value = para.Resolution;
            IsInvalidResolution = para.Resolution % 64 != 0;
            lblResolution.ForeColor = IsInvalidResolution ? Color.Red : Color.Black;
            //BatchSize
            nudBatchSize.Value = para.BatchSize;
            //NetworkDim
            nudNetworkDim.Value = para.NetworkDim;
            //NetworkAlpha
            nudNetworkAlpha.Value = para.NetworkAlpha;
            //Shuffle
            cbxShuffle.Checked = para.ShuffleCaptions;
            //KeepTokens
            nudKeepTokens.Value = para.KeepTokenCount;
            //SaveEveryNEpoch
            nudSaveEpoch.Value = para.SaveEveryNEpochs;
            //Optimizer
            cbxOptimizer.SelectedIndex = (int)para.OptimizerTypeEnum;
            //ModuleType
            cbxModuleType.SelectedIndex = (int)para.ModuleTypeEnum;
            //OutputName
            tbxFileName.Text = para.OutputName;
            tbxFileName.ForeColor = Color.Black;
            if (CheckUtil.HaveNonAsciiOrSpace(tbxFileName.Text))
            {
                tbxFileName.ForeColor = Color.Orange;
                HaveNonAscillInOutputName = true;
            }

            cbxSDType.SelectedIndex = (int)para.ModelArchitectureEnum;

            //WarmupSteps
            nudWarmupSteps.Value = para.WarmupSteps;

            cbxEpochOrStep.SelectedIndex = para.IsEpoch ? 0 : 1;
            cbxSaveEveryEpoch.SelectedIndex = para.SaveWeightEveryEpoch ? 0 : 1;

            tbxCommand.Text = para.CustomCommands;

            tbxAdditionalArgs.Text = para.AdditionalArgs;
            tbxAdditionalNetworkArgs.Text = para.AdditionalNetworkArgs;

            tbxCustomOptName.Text = para.CustomOptName;
            tbxCustomOptArgs.Text = para.CustomOptArgs;

            PrevCustomCmdActiveFlag = string.IsNullOrEmpty(para.CustomCommands);
            tabPageCustomCommands.Text = PrevCustomCmdActiveFlag ? "カスタムコマンド" : "カスタムコマンド(使用中)";

            PrevAddArgActiveFlag = string.IsNullOrEmpty(para.AdditionalArgs) && string.IsNullOrEmpty(para.AdditionalNetworkArgs);
            tabPageAddArgs.Text = PrevAddArgActiveFlag ? "追加の引数" : "追加の引数(使用中)";

            PrevCustomOptActiveFlag = string.IsNullOrEmpty(para.CustomOptName);
            tabPageCustomOpt.Text = PrevCustomOptActiveFlag ? "カスタムオプティマイザ" : "カスタムオプティマイザ(使用中)";

            PredictLoraFilesize();

            UpdateTotalStepCount();

            btnBlockWeight.BackColor = para.UseBlockWeight ? Color.MistyRose : Color.White;
            btnBlockDim.BackColor = para.UseBlockDim ? Color.MistyRose : Color.White;
        }

        private DialogResult NotifyBadParams()
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return DialogResult.No;
            }
            switch (para.OptimizerTypeEnum)
            {
                case Optimizer.AdaFactor:
                    {
                        if (para.LearningRate > 0.01f)
                            return MessageBox.Show("現在のOptimizerに対するLRが高すぎます(推奨値:0.001)。\r\n発散して失敗する可能性が高いですが、開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (para.WarmupSteps > 0m || para.LRDecaySteps > 0m)
                            return MessageBox.Show("Adafactorは完全自動のため、LR上昇/減衰は使用できません。\r\nそれでも開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    break;
                case Optimizer.AdamW:
                case Optimizer.AdamW8bit:
                case Optimizer.Lion:
                    {
                        if (para.LearningRate > 0.001f)
                            return MessageBox.Show("現在のOptimizerに対するLRが高すぎます(推奨値:0.0001)。\n発散して失敗する可能性が高いですが、開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    break;
                case Optimizer.DAdaptation:
                case Optimizer.DAdaptAdaGrad:
                case Optimizer.DAdaptAdam:
                case Optimizer.DAdaptAdan:
                case Optimizer.DAdaptSGD:
                case Optimizer.DAdaptAdanIP:
                case Optimizer.DAdaptLion:
                case Optimizer.prodigy:
                    {
                        if (para.LearningRate > 3)
                            return MessageBox.Show("現在のOptimizerに対するLRが高すぎます(推奨値:1)。\n発散して失敗する可能性が高いですが、開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        else if (para.LearningRate < 0.1f)
                            return MessageBox.Show("現在のOptimizerに対するLRが低すぎます(推奨値:1)。\n何も学習しない可能性が高いですが、開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (para.LoRAPlusLRRatio > 0 || para.LoRAPlusTELRRatio > 0 || para.LoRAPlusUnetLRRatio > 0)
                            return MessageBox.Show("現在のOptimizerでLoRA+は使用できませんが、開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    break;
            }

            if (para.ShuffleCaptions && para.CacheTextencoder)
            {
                return MessageBox.Show("Text Encoderのキャッシュとキャプションのシャッフルは併用できません。\r\nそれでも開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (para.CacheTextencoder && para.TokenWarmupMin > 0)
            {
                return MessageBox.Show("Text EncoderのキャッシュとToken warmup最小タグ数は併用できません。\r\nそれでも開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (para.advancedTrainType != AdvancedTrain.UNetOnly && para.CacheTextencoder)
            {
                return MessageBox.Show("Text Encoderの学習(or両方学習)とTEのキャッシュは併用できません。\r\nそれでも開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            switch (para.ModelArchitectureEnum)
            {
                case ModelArchitecture.Anima:
                case ModelArchitecture.MossImage:
                    {
                        if (para.UseBlockWeight || para.UseBlockDim)
                        {
                            return MessageBox.Show("層別学習が有効になっていますがDiTモデルでは非対応のため、\r\n層別学習を使用せず開始します。よろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        if (para.UseFP8Base)
                        {
                            return MessageBox.Show("FP8読み込みが有効になっていますがDiTモデルでは非対応のため、\r\nFP8を使用せず開始します。よろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }

                        if (para.CpuOffloadAsync && para.BlocksToSwap > 0)
                        {
                            return MessageBox.Show("Unsloth offload checkpointingとブロックスワップは併用できません。\r\nそれでも開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }

                        if (para.HuberScheduleType == HuberSchedule.SNR && para.LossType != LossType.LTwo)
                        {
                            return MessageBox.Show("DiTモデルはHuber ScheduleにSNRは使用できません。\r\nそれでも開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        int maxblocks = para.ModelArchitectureEnum == ModelArchitecture.Anima ? 26 : 40;
                        if(para.BlocksToSwap > maxblocks)
                        {
                            return MessageBox.Show("スワップするブロック数が現在のモデルの上限を超えています(最大値:Anima=26,MOSS=40)。\r\nそれでも開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                    }
                    break;
                default:
                    {
                        if ((para.NoiseOffset > 0 || para.MultiresNoiseIterations > 0) && para.ZeroTerminalSNR)
                        {
                            return MessageBox.Show("ノイズオフセットまたはMultires noiseとZero Terminal SNRの併用は望ましくありません。\r\nそれでも開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }

                        if (!para.VParameterization && para.ZeroTerminalSNR)
                        {
                            return MessageBox.Show("Zero Terminal SNRはV Parameterizationが有効でないと動作しません(NaN演算の原因)。\r\nそれでも開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                    }
                    break;
            }

            if (para.CrossAttenType == CrossAtten.xformers)
            {
                return MessageBox.Show("詳細設定>パフォーマンスの「Attentionの最適化」にxformersが選択されています。\r\nxformersは別途インストールが必要な上、sdpaに対する優位性はありません。\r\nそれでも開始してよろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            return DialogResult.Yes;
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings frm = new FormSettings();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void 終了ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void プリセットを開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLoadPresetDialog();
        }

        private void プリセットを保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSavePresetDialog();
        }

        private void ヒントToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //.NET CoreではUseShellExecute=trueにしないとファイルがないと怒る
                Process.Start(new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = "https://github.com/RedRayz/Kohya_lora_param_gui/blob/master/docs/tips.md",
                });
            }
            catch
            {
                MessageBox.Show("ブラウザを開けません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 配布ページToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //.NET CoreではUseShellExecute=trueにしないとファイルがないと怒る
                Process.Start(new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = "https://github.com/RedRayz/Kohya_lora_param_gui/releases",
                });
            }
            catch
            {
                MessageBox.Show("ブラウザを開けません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxModelPath_DragDrop(object sender, DragEventArgs e)
        {
            string dropped = MyUtils.GetDroppedWeightName(e);
            if (!string.IsNullOrEmpty(dropped))
            {
                tbxModelPath.Text = dropped;
            }
        }

        private void tbxModelPath_DragEnter(object sender, DragEventArgs e)
        {
            MyUtils.WeightFileDragEnterEvent(e);
        }

        private void tbxImagePath_DragDrop(object sender, DragEventArgs e)
        {
            string dropped = MyUtils.GetDroppedDirectoryName(e);
            if (!string.IsNullOrEmpty(dropped))
            {
                tbxImagePath.Text = dropped;
            }
        }

        private void tbxImagePath_DragEnter(object sender, DragEventArgs e)
        {
            MyUtils.CommonDirectoryDragEvent(e);
        }

        private void tbxRegImgPath_DragDrop(object sender, DragEventArgs e)
        {
            string dropped = MyUtils.GetDroppedDirectoryName(e);
            if (!string.IsNullOrEmpty(dropped))
            {
                tbxRegImgPath.Text = dropped;
            }
        }

        private void tbxRegImgPath_DragEnter(object sender, DragEventArgs e)
        {
            MyUtils.CommonDirectoryDragEvent(e);
        }

        private void tbxOutputPath_DragDrop(object sender, DragEventArgs e)
        {
            string dropped = MyUtils.GetDroppedDirectoryName(e);
            if (!string.IsNullOrEmpty(dropped))
            {
                tbxOutputPath.Text = dropped;
            }
        }

        private void tbxOutputPath_DragEnter(object sender, DragEventArgs e)
        {
            MyUtils.CommonDirectoryDragEvent(e);
        }

        private void btnLoadPreset_DragDrop(object sender, DragEventArgs e)
        {
            string dropped = MyUtils.GetDroppedFileName(e, ".xmlora");
            if (!string.IsNullOrEmpty(dropped))
            {
                LoadPreset(dropped, true);
            }
        }

        private void btnLoadPreset_DragEnter(object sender, DragEventArgs e)
        {
            MyUtils.CommonFileDragEnterEvent(e, ".xmlora");
        }

        private void tbxCommand_TextChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.CustomCommands = tbxCommand.Text.Replace("\r\n", string.Empty).Trim();

            bool hasNoTxt = string.IsNullOrEmpty(para.CustomCommands);
            if (hasNoTxt != PrevCustomCmdActiveFlag)
            {
                tabPageCustomCommands.Text = hasNoTxt ? "カスタムコマンド" : "カスタムコマンド(使用中)";
                PrevCustomCmdActiveFlag = hasNoTxt;
            }
        }

        private void ユーティリティToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormUtils();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void データセット編集選別ツールToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormDatasetTools();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void tbxAdditionalArgs_TextChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.AdditionalArgs = tbxAdditionalArgs.Text.Trim();

            bool hasNoTxt = string.IsNullOrEmpty(para.AdditionalArgs) && string.IsNullOrEmpty(para.AdditionalNetworkArgs);
            if (hasNoTxt != PrevAddArgActiveFlag)
            {
                tabPageAddArgs.Text = hasNoTxt ? "追加の引数" : "追加の引数(使用中)";
                PrevAddArgActiveFlag = hasNoTxt;
            }
        }

        private void tbxAdditionalNetworkArgs_TextChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.AdditionalNetworkArgs = tbxAdditionalNetworkArgs.Text.Trim();

            bool hasNoTxt = string.IsNullOrEmpty(para.AdditionalArgs) && string.IsNullOrEmpty(para.AdditionalNetworkArgs);
            if (hasNoTxt != PrevAddArgActiveFlag)
            {
                tabPageAddArgs.Text = hasNoTxt ? "追加の引数" : "追加の引数(使用中)";
                PrevAddArgActiveFlag = hasNoTxt;
            }
        }

        private void cbxSaveEveryEpoch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.SaveWeightEveryEpoch = cbxSaveEveryEpoch.SelectedIndex == 0;
        }

        private void cbxCompleteAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompleteAction = (TrainCompleteAction)Enum.ToObject(typeof(TrainCompleteAction), cbxCompleteAction.SelectedIndex);
        }

        private void 学習パラメータ初期化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("学習設定を初期化します。よろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new TrainParams();
                LastOpenPresetPath = string.Empty;
                UpdateAllContents();
            }
        }

        private void tbxCustomOptName_TextChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.CustomOptName = tbxCustomOptName.Text.Trim();
            bool hasNoTxt = string.IsNullOrEmpty(para.CustomOptName);
            if (hasNoTxt != PrevCustomOptActiveFlag)
            {
                tabPageCustomOpt.Text = hasNoTxt ? "カスタムオプティマイザ" : "カスタムオプティマイザ(使用中)";
                PrevCustomOptActiveFlag = hasNoTxt;
            }
        }

        private void tbxCustomOptArgs_TextChanged(object sender, EventArgs e)
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }
            para.CustomOptArgs = tbxCustomOptArgs.Text.Trim();
        }

        private void btnShowTipsDatasetDir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("「数字_名前」のフォルダが1つ以上入ったフォルダを指定する必要があります。\n詳細は、sd-scriptsのドキュメントをご覧ください。", "ヒント", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowTipsRegImageDir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("「数字_名前」のフォルダが1つ以上入ったフォルダを指定する必要があります。\n詳細は、sd-scriptsのドキュメントをご覧ください。", "ヒント", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sdscriptsリポジトリToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //.NET CoreではUseShellExecute=trueにしないとファイルがないと怒る
                Process.Start(new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = "https://github.com/kohya-ss/sd-scripts",
                });
            }
            catch
            {
                MessageBox.Show("ブラウザを開けません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshPath_Click(object sender, EventArgs e)
        {
            UpdateAllContents();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (IsReady)
            {
                UpdateAllContents();
            }
        }

        private void PredictLoraFilesize()
        {
            var para = TrainParams.Current;
            if (para == null)
            {
                return;
            }

            if (para.ModuleTypeEnum != NetworkModule.LoRA)
            {
                lblPredictedLoraFilesizeTitle.Enabled = false;
                lblPredictedLoraFilesize.Text = string.Empty;
                return;
            }

            decimal filesize = 0;

            switch (para.ModelArchitectureEnum)
            {
                case ModelArchitecture.XL:
                    {
                        //両方学習 or Unetオンリー
                        if (para.advancedTrainType == AdvancedTrain.None || para.advancedTrainType == AdvancedTrain.UNetOnly)
                        {
                            //層別WeightとDimの両方使わない
                            if (!para.UseBlockWeight && !para.UseBlockDim)
                            {
                                for (int i = 0; i < 9; i++) //IN
                                {
                                    //Attn Depth=2
                                    if (i == 4 || i == 5)
                                    {
                                        filesize += 99.793m;
                                    }
                                    //Attn depth=10
                                    if (i == 7 || i == 8)
                                    {
                                        filesize += 831.3633m;
                                    }
                                }
                                //MID01 Attn depth10
                                filesize += 831.3633m;

                                for (int i = 0; i < 9; i++) //OUT
                                {
                                    //Attn depth=10
                                    if (i >= 0 && i <= 2)
                                    {
                                        filesize += 831.3633m;
                                    }

                                    //Attn depth=2
                                    if (i >= 3 && i <= 5)
                                    {
                                        filesize += 99.793m;
                                    }
                                }


                                filesize *= para.NetworkDim;
                                //畳み込み層
                                if (para.UseConv2dExtend)
                                {
                                    filesize += 264.4531m * para.ConvDim;
                                }
                            }
                            else //Block WeightまたはBlock Dim有効
                            {
                                for (int i = 0; i < 9; i++) //IN
                                {
                                    if (para.BlockWeightIn[i] > 0 || (para.UseBlockDim && para.BlockDimIn[i] > 0))
                                    {
                                        //Attn Depth=2
                                        if ((i == 4 || i == 5))
                                        {
                                            filesize += 99.793m * (para.UseBlockDim ? para.BlockDimIn[i] : para.NetworkDim);
                                        }
                                        //Attn depth=10
                                        else if (i == 7 || i == 8)
                                        {
                                            filesize += 831.3633m * (para.UseBlockDim ? para.BlockDimIn[i] : para.NetworkDim);
                                        }
                                        else if (para.UseConv2dExtend)
                                        {
                                            filesize += 26.4453m * (para.UseBlockDim ? para.BlockDimIn[i] : para.NetworkDim);
                                        }
                                    }

                                }

                                //MID
                                if (para.BlockWeightMid > 0 || (para.UseBlockDim && para.BlockDimMid > 0))
                                    filesize += 26.4453m * (para.UseBlockDim ? para.BlockDimMid : para.NetworkDim);
                                if (para.BlockWeightMid01 > 0 || (para.UseBlockDim && para.BlockDimMid01 > 0))
                                    filesize += 831.3633m * (para.UseBlockDim ? para.BlockDimMid01 : para.NetworkDim);
                                if (para.BlockWeightMid02 > 0 || (para.UseBlockDim && para.BlockDimMid02 > 0))
                                    filesize += 26.4453m * (para.UseBlockDim ? para.BlockDimMid02 : para.NetworkDim);

                                for (int i = 0; i < 9; i++) //OUT
                                {
                                    if (para.BlockWeightOut[i] > 0 || (para.UseBlockDim && para.BlockDimOut[i] > 0))
                                    {
                                        //Attn depth=10
                                        if (i >= 0 && i <= 2)
                                        {
                                            filesize += 831.3633m * (para.UseBlockDim ? para.BlockDimOut[i] : para.NetworkDim);
                                        }
                                        //Attn depth=2
                                        else if (i >= 3 && i <= 5)
                                        {
                                            filesize += 99.793m * (para.UseBlockDim ? para.BlockDimOut[i] : para.NetworkDim);
                                        }
                                        else if (para.UseConv2dExtend)
                                        {
                                            filesize += 26.4453m * (para.UseBlockDim ? para.BlockDimOut[i] : para.NetworkDim);
                                        }
                                    }

                                }
                            }

                        }



                        if (para.advancedTrainType == AdvancedTrain.None || para.advancedTrainType == AdvancedTrain.TextEncoderOnly)
                        {
                            filesize += 1864.3828m * para.NetworkDim;
                        }
                    }
                    break;
                case ModelArchitecture.Anima:
                    {
                        switch (para.advancedTrainType)
                        {
                            case AdvancedTrain.None:
                                filesize = 4144.1484m * para.NetworkDim;
                                break;
                            case AdvancedTrain.UNetOnly:
                                filesize = 2895.215m * para.NetworkDim;
                                break;
                            case AdvancedTrain.TextEncoderOnly:
                                filesize = 1249.0234m * para.NetworkDim;
                                break;
                        }
                    }
                    break;
                default:
                    lblPredictedLoraFilesizeTitle.Enabled = false;
                    lblPredictedLoraFilesize.Text = string.Empty;
                    return;
            }


            string scale = "KiB";

            if (para.SavePrecision == SavePrecision.fp32)
            {
                filesize *= 2m;
            }

            if (filesize > 1024m)
            {
                filesize /= 1024m;
                scale = "MiB";
            }

            if (filesize > 1024m)
            {
                filesize /= 1024m;
                scale = "GiB";
            }

            lblPredictedLoraFilesizeTitle.Enabled = true;
            if (filesize >= 0)
            {
                lblPredictedLoraFilesize.Text = filesize.ToString("#,0.00" + scale);
            }
            else
            {
                lblPredictedLoraFilesize.Text = "オーバーフロー";
            }

        }

        private void btnShowModelTips_Click(object sender, EventArgs e)
        {
            Form frm = new FormModelTypeTips();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}

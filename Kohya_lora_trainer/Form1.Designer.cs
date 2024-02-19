
namespace Kohya_lora_trainer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnModel = new Button();
            btnImage = new Button();
            label2 = new Label();
            label3 = new Label();
            btnRegImage = new Button();
            label4 = new Label();
            tbxLR = new TextBox();
            lblLR = new Label();
            cbxOptimizer = new ComboBox();
            label10 = new Label();
            label17 = new Label();
            btnAdvanced = new Button();
            btnStartTraining = new Button();
            label7 = new Label();
            cbxShuffle = new CheckBox();
            label12 = new Label();
            toolTip1 = new ToolTip(components);
            nudNetworkAlpha = new NumericUpDown();
            nudNetworkDim = new NumericUpDown();
            nudResolution = new NumericUpDown();
            nudKeepTokens = new NumericUpDown();
            nudBatchSize = new NumericUpDown();
            nudWarmupSteps = new NumericUpDown();
            cbxSDType = new ComboBox();
            tbxFileName = new TextBox();
            cbxModuleType = new ComboBox();
            nudSaveEpoch = new NumericUpDown();
            tbxRegImgPath = new TextBox();
            btnBlockWeight = new Button();
            btnBlockDim = new Button();
            btnSavePreset = new Button();
            btnLoadPreset = new Button();
            lblResolution = new Label();
            lblFileName = new Label();
            label16 = new Label();
            label18 = new Label();
            label20 = new Label();
            label21 = new Label();
            nudEpochs = new NumericUpDown();
            label1 = new Label();
            lblNumSteps = new Label();
            label9 = new Label();
            btnClearRegImagePath = new Button();
            lblNumStepsBatch1 = new Label();
            label5 = new Label();
            label8 = new Label();
            label11 = new Label();
            btnOutputPath = new Button();
            btnCustomScriptPath = new Button();
            lblScriptPathDesc = new Label();
            btnUtilities = new Button();
            tbxModelPath = new TextBox();
            tbxImagePath = new TextBox();
            tbxOutputPath = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            rbtShutdown = new RadioButton();
            rbtBenckmark = new RadioButton();
            rbtDoNothing = new RadioButton();
            btnBatchProcess = new Button();
            btnInstaller = new Button();
            btnGenerateCommands = new Button();
            btnLeco = new Button();
            label13 = new Label();
            cbxEpochOrStep = new ComboBox();
            rbtSleep = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nudNetworkAlpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNetworkDim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudResolution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKeepTokens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBatchSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWarmupSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSaveEpoch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEpochs).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnModel
            // 
            btnModel.Location = new Point(112, 54);
            btnModel.Margin = new Padding(3, 4, 3, 4);
            btnModel.Name = "btnModel";
            btnModel.Size = new Size(108, 28);
            btnModel.TabIndex = 1;
            btnModel.Text = "選択";
            btnModel.UseVisualStyleBackColor = true;
            btnModel.Click += btnModel_Click;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(364, 54);
            btnImage.Margin = new Padding(3, 4, 3, 4);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(108, 28);
            btnImage.TabIndex = 1;
            btnImage.Text = "選択";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 59);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "学習元モデル*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 61);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 3;
            label3.Text = "教師画像フォルダ*";
            // 
            // btnRegImage
            // 
            btnRegImage.Location = new Point(642, 54);
            btnRegImage.Margin = new Padding(3, 4, 3, 4);
            btnRegImage.Name = "btnRegImage";
            btnRegImage.Size = new Size(51, 28);
            btnRegImage.TabIndex = 1;
            btnRegImage.Text = "選択";
            btnRegImage.UseVisualStyleBackColor = true;
            btnRegImage.Click += btnRegImage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(534, 61);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "正則化画像フォルダ";
            // 
            // tbxLR
            // 
            tbxLR.Location = new Point(100, 122);
            tbxLR.Name = "tbxLR";
            tbxLR.Size = new Size(85, 23);
            tbxLR.TabIndex = 4;
            tbxLR.Text = "1e-4";
            toolTip1.SetToolTip(tbxLR, "AdamW系は0.0001、AdaFactorは0.001、DAdaptation系は1推奨");
            tbxLR.TextChanged += tbxLR_TextChanged;
            // 
            // lblLR
            // 
            lblLR.AutoSize = true;
            lblLR.ForeColor = SystemColors.ControlText;
            lblLR.Location = new Point(24, 125);
            lblLR.Name = "lblLR";
            lblLR.Size = new Size(69, 15);
            lblLR.TabIndex = 5;
            lblLR.Text = "学習率(LR)*";
            // 
            // cbxOptimizer
            // 
            cbxOptimizer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOptimizer.ForeColor = SystemColors.WindowText;
            cbxOptimizer.FormattingEnabled = true;
            cbxOptimizer.Items.AddRange(new object[] { "AdamW8bit", "AdamW", "AdaFactor", "Lion", "SGDNesterov", "SGDNesterov8bit", "DAdaptAdamPreprint", "Lion8bit", "DAdaptAdaGrad", "DAdaptAdam", "DAdaptAdan", "DAdaptSGD", "DAdaptAdanIP", "DAdaptLion", "Prodigy", "PagedAdamW8bit", "PagedLion8bit" });
            cbxOptimizer.Location = new Point(100, 211);
            cbxOptimizer.Name = "cbxOptimizer";
            cbxOptimizer.Size = new Size(139, 23);
            cbxOptimizer.TabIndex = 6;
            toolTip1.SetToolTip(cbxOptimizer, "AdamWとDAdaptLionがおすすめ\r\nDAdaptation系はCPUボトルネックが大きい傾向");
            cbxOptimizer.SelectedIndexChanged += cbxOptimizer_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 214);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 14;
            label10.Text = "オプティマイザ*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 155);
            label17.Name = "label17";
            label17.Size = new Size(82, 15);
            label17.TabIndex = 23;
            label17.Text = "epochs/steps*";
            // 
            // btnAdvanced
            // 
            btnAdvanced.Location = new Point(18, 390);
            btnAdvanced.Name = "btnAdvanced";
            btnAdvanced.Size = new Size(78, 27);
            btnAdvanced.TabIndex = 26;
            btnAdvanced.Text = "詳細設定";
            btnAdvanced.UseVisualStyleBackColor = true;
            btnAdvanced.Click += button4_Click;
            // 
            // btnStartTraining
            // 
            btnStartTraining.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartTraining.Location = new Point(627, 423);
            btnStartTraining.Name = "btnStartTraining";
            btnStartTraining.Size = new Size(132, 39);
            btnStartTraining.TabIndex = 27;
            btnStartTraining.Text = "学習開始";
            btnStartTraining.UseVisualStyleBackColor = true;
            btnStartTraining.Click += btnStartTraining_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 14);
            label7.Name = "label7";
            label7.Size = new Size(274, 15);
            label7.TabIndex = 29;
            label7.Text = "*がつく項目は必須。#がつく項目は0を指定すると無効化";
            // 
            // cbxShuffle
            // 
            cbxShuffle.AutoSize = true;
            cbxShuffle.Location = new Point(102, 184);
            cbxShuffle.Name = "cbxShuffle";
            cbxShuffle.Size = new Size(131, 19);
            cbxShuffle.TabIndex = 30;
            cbxShuffle.Text = "キャプションのシャッフル";
            toolTip1.SetToolTip(cbxShuffle, "カンマ区切りでシャッフルする");
            cbxShuffle.UseVisualStyleBackColor = true;
            cbxShuffle.CheckedChanged += cbxShuffle_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(310, 187);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 33;
            label12.Text = "トークン保持数#";
            // 
            // nudNetworkAlpha
            // 
            nudNetworkAlpha.DecimalPlaces = 2;
            nudNetworkAlpha.Location = new Point(668, 151);
            nudNetworkAlpha.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudNetworkAlpha.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudNetworkAlpha.Name = "nudNetworkAlpha";
            nudNetworkAlpha.Size = new Size(80, 23);
            nudNetworkAlpha.TabIndex = 51;
            toolTip1.SetToolTip(nudNetworkAlpha, "dimの半分以下の値が望ましい\r\ndimに近い値では生成時に崩壊しやすい");
            nudNetworkAlpha.Value = new decimal(new int[] { 16, 0, 0, 0 });
            nudNetworkAlpha.ValueChanged += nudNetworkAlpha_ValueChanged;
            // 
            // nudNetworkDim
            // 
            nudNetworkDim.Location = new Point(400, 155);
            nudNetworkDim.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudNetworkDim.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNetworkDim.Name = "nudNetworkDim";
            nudNetworkDim.Size = new Size(72, 23);
            nudNetworkDim.TabIndex = 52;
            toolTip1.SetToolTip(nudNetworkDim, "上げると学習能力が上昇するが、速度低下と生成時の不安定化を招く");
            nudNetworkDim.Value = new decimal(new int[] { 64, 0, 0, 0 });
            nudNetworkDim.ValueChanged += nudNetworkDim_ValueChanged;
            // 
            // nudResolution
            // 
            nudResolution.Increment = new decimal(new int[] { 64, 0, 0, 0 });
            nudResolution.Location = new Point(400, 122);
            nudResolution.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            nudResolution.Minimum = new decimal(new int[] { 128, 0, 0, 0 });
            nudResolution.Name = "nudResolution";
            nudResolution.Size = new Size(72, 23);
            nudResolution.TabIndex = 54;
            toolTip1.SetToolTip(nudResolution, "SD1.Xが512、2.Xが768、XLが1024推奨\r\n解像度を上げると細部が若干改善することがある");
            nudResolution.Value = new decimal(new int[] { 512, 0, 0, 0 });
            nudResolution.ValueChanged += nudResolution_ValueChanged;
            // 
            // nudKeepTokens
            // 
            nudKeepTokens.Location = new Point(400, 184);
            nudKeepTokens.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            nudKeepTokens.Name = "nudKeepTokens";
            nudKeepTokens.Size = new Size(72, 23);
            nudKeepTokens.TabIndex = 55;
            toolTip1.SetToolTip(nudKeepTokens, "先頭nトークンをシャッフルの対象外にする。\r\n1トークン=カンマ区切り");
            nudKeepTokens.ValueChanged += nudKeepTokens_ValueChanged;
            // 
            // nudBatchSize
            // 
            nudBatchSize.Location = new Point(668, 122);
            nudBatchSize.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudBatchSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudBatchSize.Name = "nudBatchSize";
            nudBatchSize.Size = new Size(80, 23);
            nudBatchSize.TabIndex = 57;
            toolTip1.SetToolTip(nudBatchSize, "高batchでは学習効率が低下するので、LRかエポック数を多めにする");
            nudBatchSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudBatchSize.ValueChanged += nudBatchSize_ValueChanged;
            // 
            // nudWarmupSteps
            // 
            nudWarmupSteps.Location = new Point(400, 211);
            nudWarmupSteps.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            nudWarmupSteps.Name = "nudWarmupSteps";
            nudWarmupSteps.Size = new Size(72, 23);
            nudWarmupSteps.TabIndex = 62;
            toolTip1.SetToolTip(nudWarmupSteps, "nステップ数まで徐々にLRを上げる");
            nudWarmupSteps.Value = new decimal(new int[] { 500, 0, 0, 0 });
            nudWarmupSteps.ValueChanged += nudWarmupSteps_ValueChanged;
            // 
            // cbxSDType
            // 
            cbxSDType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSDType.FormattingEnabled = true;
            cbxSDType.Items.AddRange(new object[] { "1.x/2.x", "XL" });
            cbxSDType.Location = new Point(100, 244);
            cbxSDType.Name = "cbxSDType";
            cbxSDType.Size = new Size(139, 23);
            cbxSDType.TabIndex = 85;
            toolTip1.SetToolTip(cbxSDType, "SDXLは要求スペックもXLサイズ\r\nVRAM12GB以上、メインメモリ32GB以上必要\r\nVRAM8GBでもかろうじて動く");
            cbxSDType.SelectedIndexChanged += cbxSDType_SelectedIndexChanged;
            // 
            // tbxFileName
            // 
            tbxFileName.Location = new Point(100, 276);
            tbxFileName.Name = "tbxFileName";
            tbxFileName.Size = new Size(322, 23);
            tbxFileName.TabIndex = 38;
            toolTip1.SetToolTip(tbxFileName, "空白、マルチバイト文字(日本語など)は非推奨");
            tbxFileName.TextChanged += tbxFileName_TextChanged;
            // 
            // cbxModuleType
            // 
            cbxModuleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxModuleType.FormattingEnabled = true;
            cbxModuleType.Items.AddRange(new object[] { "LoRA", "LyCORIS", "DyLoRA", "LoRA-FA" });
            cbxModuleType.Location = new Point(668, 211);
            cbxModuleType.Name = "cbxModuleType";
            cbxModuleType.Size = new Size(80, 23);
            cbxModuleType.TabIndex = 6;
            toolTip1.SetToolTip(cbxModuleType, "LyCORISは品質面でのメリットなし\r\nLoRA-FAはメモリ消費が減少するが減少量は雀の涙");
            cbxModuleType.SelectedIndexChanged += cbxModuleType_SelectedIndexChanged;
            // 
            // nudSaveEpoch
            // 
            nudSaveEpoch.Location = new Point(668, 180);
            nudSaveEpoch.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            nudSaveEpoch.Name = "nudSaveEpoch";
            nudSaveEpoch.Size = new Size(80, 23);
            nudSaveEpoch.TabIndex = 56;
            toolTip1.SetToolTip(nudSaveEpoch, "指定した間隔で成果物を書き出す\r\nエポックかステップのどちらを使用するかは\r\nepochs/stepsの設定に従う");
            nudSaveEpoch.ValueChanged += nudSaveEpoch_ValueChanged;
            // 
            // tbxRegImgPath
            // 
            tbxRegImgPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxRegImgPath.Location = new Point(534, 86);
            tbxRegImgPath.Name = "tbxRegImgPath";
            tbxRegImgPath.Size = new Size(214, 22);
            tbxRegImgPath.TabIndex = 71;
            toolTip1.SetToolTip(tbxRegImgPath, "特定のものだけ\r\n出てくればいいなら不要");
            tbxRegImgPath.TextChanged += tbxRegImgPath_TextChanged;
            // 
            // btnBlockWeight
            // 
            btnBlockWeight.Location = new Point(18, 423);
            btnBlockWeight.Name = "btnBlockWeight";
            btnBlockWeight.Size = new Size(78, 27);
            btnBlockWeight.TabIndex = 75;
            btnBlockWeight.Text = "層別学習率";
            toolTip1.SetToolTip(btnBlockWeight, "SDXLは非対応(sd-scriptsの仕様)");
            btnBlockWeight.UseVisualStyleBackColor = true;
            btnBlockWeight.Click += btnBlockWeight_Click;
            // 
            // btnBlockDim
            // 
            btnBlockDim.Location = new Point(102, 423);
            btnBlockDim.Name = "btnBlockDim";
            btnBlockDim.Size = new Size(78, 27);
            btnBlockDim.TabIndex = 76;
            btnBlockDim.Text = "層別dim";
            toolTip1.SetToolTip(btnBlockDim, "SDXLは非対応(sd-scriptsの仕様)");
            btnBlockDim.UseVisualStyleBackColor = true;
            btnBlockDim.Click += btnBlockDim_Click;
            // 
            // btnSavePreset
            // 
            btnSavePreset.Location = new Point(521, 423);
            btnSavePreset.Name = "btnSavePreset";
            btnSavePreset.Size = new Size(100, 27);
            btnSavePreset.TabIndex = 34;
            btnSavePreset.Text = "プリセットの保存";
            btnSavePreset.UseVisualStyleBackColor = true;
            btnSavePreset.Click += btnSavePreset_Click;
            // 
            // btnLoadPreset
            // 
            btnLoadPreset.Location = new Point(418, 423);
            btnLoadPreset.Name = "btnLoadPreset";
            btnLoadPreset.Size = new Size(100, 27);
            btnLoadPreset.TabIndex = 35;
            btnLoadPreset.Text = "プリセットの読込";
            btnLoadPreset.UseVisualStyleBackColor = true;
            btnLoadPreset.Click += btnLoadPreset_Click;
            // 
            // lblResolution
            // 
            lblResolution.AutoSize = true;
            lblResolution.Location = new Point(346, 125);
            lblResolution.Name = "lblResolution";
            lblResolution.Size = new Size(48, 15);
            lblResolution.TabIndex = 36;
            lblResolution.Text = "解像度*";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(24, 279);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(77, 15);
            lblFileName.TabIndex = 39;
            lblFileName.Text = "出力ファイル名";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(521, 182);
            label16.Name = "label16";
            label16.Size = new Size(141, 15);
            label16.TabIndex = 42;
            label16.Text = "保存頻度(Epochs/Steps)#";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(595, 124);
            label18.Name = "label18";
            label18.Size = new Size(67, 15);
            label18.TabIndex = 44;
            label18.Text = "バッチサイズ*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(294, 156);
            label20.Name = "label20";
            label20.Size = new Size(100, 15);
            label20.TabIndex = 48;
            label20.Text = "ネットワーク次元数*";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(564, 153);
            label21.Name = "label21";
            label21.Size = new Size(98, 15);
            label21.TabIndex = 50;
            label21.Text = "ネットワークアルファ*";
            // 
            // nudEpochs
            // 
            nudEpochs.Location = new Point(100, 153);
            nudEpochs.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            nudEpochs.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudEpochs.Name = "nudEpochs";
            nudEpochs.Size = new Size(85, 23);
            nudEpochs.TabIndex = 53;
            nudEpochs.Value = new decimal(new int[] { 4, 0, 0, 0 });
            nudEpochs.ValueChanged += nudEpochs_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(539, 340);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 60;
            label1.Text = "総ステップ数(目安):";
            // 
            // lblNumSteps
            // 
            lblNumSteps.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumSteps.Location = new Point(642, 338);
            lblNumSteps.Name = "lblNumSteps";
            lblNumSteps.Size = new Size(106, 24);
            lblNumSteps.TabIndex = 61;
            lblNumSteps.Text = "999,999,999";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(273, 214);
            label9.Name = "label9";
            label9.Size = new Size(121, 15);
            label9.TabIndex = 63;
            label9.Text = "ウォームアップステップ数#";
            // 
            // btnClearRegImagePath
            // 
            btnClearRegImagePath.Location = new Point(699, 54);
            btnClearRegImagePath.Name = "btnClearRegImagePath";
            btnClearRegImagePath.Size = new Size(49, 28);
            btnClearRegImagePath.TabIndex = 64;
            btnClearRegImagePath.Text = "クリア";
            btnClearRegImagePath.UseVisualStyleBackColor = true;
            btnClearRegImagePath.Click += btnClearRegImagePath_Click;
            // 
            // lblNumStepsBatch1
            // 
            lblNumStepsBatch1.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumStepsBatch1.Location = new Point(642, 362);
            lblNumStepsBatch1.Name = "lblNumStepsBatch1";
            lblNumStepsBatch1.Size = new Size(106, 22);
            lblNumStepsBatch1.TabIndex = 61;
            lblNumStepsBatch1.Text = "999,999,999";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(538, 364);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 60;
            label5.Text = "batch1相当(目安):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(100, 312);
            label8.Name = "label8";
            label8.Size = new Size(203, 15);
            label8.TabIndex = 65;
            label8.Text = "次の文字は使用できません /\\?:*<>|\"＆'`\r\n";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(553, 275);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 3;
            label11.Text = "出力先フォルダ*";
            // 
            // btnOutputPath
            // 
            btnOutputPath.Location = new Point(646, 266);
            btnOutputPath.Name = "btnOutputPath";
            btnOutputPath.Size = new Size(102, 33);
            btnOutputPath.TabIndex = 66;
            btnOutputPath.Text = "選択";
            btnOutputPath.UseVisualStyleBackColor = true;
            btnOutputPath.Click += btnOutputPath_Click;
            // 
            // btnCustomScriptPath
            // 
            btnCustomScriptPath.Location = new Point(646, 10);
            btnCustomScriptPath.Name = "btnCustomScriptPath";
            btnCustomScriptPath.Size = new Size(82, 26);
            btnCustomScriptPath.TabIndex = 67;
            btnCustomScriptPath.Text = "選択";
            btnCustomScriptPath.UseVisualStyleBackColor = true;
            btnCustomScriptPath.Click += btnCustomScriptPath_Click;
            // 
            // lblScriptPathDesc
            // 
            lblScriptPathDesc.AutoSize = true;
            lblScriptPathDesc.ForeColor = Color.Black;
            lblScriptPathDesc.Location = new Point(462, 14);
            lblScriptPathDesc.Name = "lblScriptPathDesc";
            lblScriptPathDesc.Size = new Size(106, 15);
            lblScriptPathDesc.TabIndex = 68;
            lblScriptPathDesc.Text = "sd-scripts場所選択";
            // 
            // btnUtilities
            // 
            btnUtilities.Location = new Point(310, 423);
            btnUtilities.Name = "btnUtilities";
            btnUtilities.Size = new Size(85, 27);
            btnUtilities.TabIndex = 69;
            btnUtilities.Text = "ユーティリティ";
            btnUtilities.UseVisualStyleBackColor = true;
            btnUtilities.Click += btnUtilities_Click;
            // 
            // tbxModelPath
            // 
            tbxModelPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxModelPath.Location = new Point(12, 89);
            tbxModelPath.Name = "tbxModelPath";
            tbxModelPath.Size = new Size(208, 22);
            tbxModelPath.TabIndex = 71;
            tbxModelPath.TextChanged += tbxModelPath_TextChanged;
            // 
            // tbxImagePath
            // 
            tbxImagePath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxImagePath.Location = new Point(270, 86);
            tbxImagePath.Name = "tbxImagePath";
            tbxImagePath.Size = new Size(202, 22);
            tbxImagePath.TabIndex = 71;
            tbxImagePath.TextChanged += tbxImagePath_TextChanged;
            // 
            // tbxOutputPath
            // 
            tbxOutputPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxOutputPath.Location = new Point(543, 305);
            tbxOutputPath.Name = "tbxOutputPath";
            tbxOutputPath.Size = new Size(205, 22);
            tbxOutputPath.TabIndex = 71;
            tbxOutputPath.TextChanged += tbxOutputPath_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(571, 214);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 72;
            label6.Text = "モジュールの種類*";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtSleep);
            groupBox1.Controls.Add(rbtShutdown);
            groupBox1.Controls.Add(rbtBenckmark);
            groupBox1.Controls.Add(rbtDoNothing);
            groupBox1.Location = new Point(20, 338);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 46);
            groupBox1.TabIndex = 79;
            groupBox1.TabStop = false;
            groupBox1.Text = "学習終了後の動作";
            // 
            // rbtShutdown
            // 
            rbtShutdown.AutoSize = true;
            rbtShutdown.Location = new Point(171, 21);
            rbtShutdown.Name = "rbtShutdown";
            rbtShutdown.Size = new Size(86, 19);
            rbtShutdown.TabIndex = 2;
            rbtShutdown.Text = "シャットダウン";
            rbtShutdown.UseVisualStyleBackColor = true;
            // 
            // rbtBenckmark
            // 
            rbtBenckmark.AutoSize = true;
            rbtBenckmark.Location = new Point(58, 21);
            rbtBenckmark.Name = "rbtBenckmark";
            rbtBenckmark.Size = new Size(107, 19);
            rbtBenckmark.TabIndex = 1;
            rbtBenckmark.Text = "経過時間の表示";
            rbtBenckmark.UseVisualStyleBackColor = true;
            // 
            // rbtDoNothing
            // 
            rbtDoNothing.AutoSize = true;
            rbtDoNothing.Checked = true;
            rbtDoNothing.Location = new Point(6, 21);
            rbtDoNothing.Name = "rbtDoNothing";
            rbtDoNothing.Size = new Size(45, 19);
            rbtDoNothing.TabIndex = 0;
            rbtDoNothing.TabStop = true;
            rbtDoNothing.Text = "無し";
            rbtDoNothing.UseVisualStyleBackColor = true;
            // 
            // btnBatchProcess
            // 
            btnBatchProcess.Location = new Point(100, 390);
            btnBatchProcess.Name = "btnBatchProcess";
            btnBatchProcess.Size = new Size(78, 27);
            btnBatchProcess.TabIndex = 80;
            btnBatchProcess.Text = "バッチ処理";
            btnBatchProcess.UseVisualStyleBackColor = true;
            btnBatchProcess.Click += btnBatchProcess_Click;
            // 
            // btnInstaller
            // 
            btnInstaller.Location = new Point(332, 10);
            btnInstaller.Name = "btnInstaller";
            btnInstaller.Size = new Size(111, 26);
            btnInstaller.TabIndex = 82;
            btnInstaller.Text = "簡易インストーラー";
            btnInstaller.UseVisualStyleBackColor = true;
            btnInstaller.Click += btnInstaller_Click;
            // 
            // btnGenerateCommands
            // 
            btnGenerateCommands.Location = new Point(627, 390);
            btnGenerateCommands.Name = "btnGenerateCommands";
            btnGenerateCommands.Size = new Size(132, 27);
            btnGenerateCommands.TabIndex = 83;
            btnGenerateCommands.Text = "コマンドの生成とコピー";
            btnGenerateCommands.UseVisualStyleBackColor = true;
            btnGenerateCommands.Click += btnGenerateCommands_Click;
            // 
            // btnLeco
            // 
            btnLeco.Location = new Point(218, 423);
            btnLeco.Name = "btnLeco";
            btnLeco.Size = new Size(85, 27);
            btnLeco.TabIndex = 84;
            btnLeco.Text = "LECO";
            btnLeco.UseVisualStyleBackColor = true;
            btnLeco.Click += btnLeco_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 247);
            label13.Name = "label13";
            label13.Size = new Size(75, 15);
            label13.TabIndex = 14;
            label13.Text = "SDのバージョン";
            // 
            // cbxEpochOrStep
            // 
            cbxEpochOrStep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEpochOrStep.FormattingEnabled = true;
            cbxEpochOrStep.Items.AddRange(new object[] { "エポック", "ステップ" });
            cbxEpochOrStep.Location = new Point(191, 153);
            cbxEpochOrStep.Name = "cbxEpochOrStep";
            cbxEpochOrStep.Size = new Size(76, 23);
            cbxEpochOrStep.TabIndex = 86;
            cbxEpochOrStep.SelectedIndexChanged += cbxEpochOrStep_SelectedIndexChanged;
            // 
            // rbtSleep
            // 
            rbtSleep.AutoSize = true;
            rbtSleep.Location = new Point(263, 21);
            rbtSleep.Name = "rbtSleep";
            rbtSleep.Size = new Size(59, 19);
            rbtSleep.TabIndex = 2;
            rbtSleep.Text = "スリープ";
            rbtSleep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(772, 470);
            Controls.Add(cbxEpochOrStep);
            Controls.Add(cbxSDType);
            Controls.Add(btnLeco);
            Controls.Add(btnGenerateCommands);
            Controls.Add(btnInstaller);
            Controls.Add(btnBatchProcess);
            Controls.Add(groupBox1);
            Controls.Add(btnBlockDim);
            Controls.Add(btnBlockWeight);
            Controls.Add(label6);
            Controls.Add(tbxOutputPath);
            Controls.Add(tbxRegImgPath);
            Controls.Add(tbxImagePath);
            Controls.Add(tbxModelPath);
            Controls.Add(btnUtilities);
            Controls.Add(lblScriptPathDesc);
            Controls.Add(btnCustomScriptPath);
            Controls.Add(btnOutputPath);
            Controls.Add(label8);
            Controls.Add(btnClearRegImagePath);
            Controls.Add(label9);
            Controls.Add(lblNumStepsBatch1);
            Controls.Add(nudWarmupSteps);
            Controls.Add(label5);
            Controls.Add(lblNumSteps);
            Controls.Add(label1);
            Controls.Add(nudBatchSize);
            Controls.Add(nudSaveEpoch);
            Controls.Add(nudKeepTokens);
            Controls.Add(nudResolution);
            Controls.Add(nudEpochs);
            Controls.Add(nudNetworkDim);
            Controls.Add(nudNetworkAlpha);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(lblFileName);
            Controls.Add(tbxFileName);
            Controls.Add(lblResolution);
            Controls.Add(btnLoadPreset);
            Controls.Add(btnSavePreset);
            Controls.Add(label12);
            Controls.Add(cbxShuffle);
            Controls.Add(label7);
            Controls.Add(btnStartTraining);
            Controls.Add(btnAdvanced);
            Controls.Add(label17);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(cbxModuleType);
            Controls.Add(cbxOptimizer);
            Controls.Add(lblLR);
            Controls.Add(tbxLR);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegImage);
            Controls.Add(btnImage);
            Controls.Add(btnModel);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoRA Training GUI";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudNetworkAlpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNetworkDim).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudResolution).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKeepTokens).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBatchSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWarmupSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSaveEpoch).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEpochs).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnModel;
        private Button btnImage;
        private Label label2;
        private Label label3;
        private Button btnRegImage;
        private Label label4;
        private TextBox tbxLR;
        private Label lblLR;
        private ComboBox cbxOptimizer;
        private Label label10;
        private Label label17;
        private Button btnAdvanced;
        private Button btnStartTraining;
        private Label label7;
        private CheckBox cbxShuffle;
        private Label label12;
        private ToolTip toolTip1;
        private Button btnSavePreset;
        private Button btnLoadPreset;
        private Label lblResolution;
        private TextBox tbxFileName;
        private Label lblFileName;
        private Label label16;
        private Label label18;
        private Label label20;
        private Label label21;
        private NumericUpDown nudNetworkAlpha;
        private NumericUpDown nudNetworkDim;
        private NumericUpDown nudEpochs;
        private NumericUpDown nudResolution;
        private NumericUpDown nudKeepTokens;
        private NumericUpDown nudSaveEpoch;
        private NumericUpDown nudBatchSize;
        private Label label1;
        private Label lblNumSteps;
        private NumericUpDown nudWarmupSteps;
        private Label label9;
        private Button btnClearRegImagePath;
        private Label lblNumStepsBatch1;
        private Label label5;
        private Label label8;
        private Label label11;
        private Button btnOutputPath;
        private Button btnCustomScriptPath;
        private Label lblScriptPathDesc;
        private Button btnUtilities;
        private TextBox tbxModelPath;
        private TextBox tbxImagePath;
        private TextBox tbxRegImgPath;
        private TextBox tbxOutputPath;
        private ComboBox cbxModuleType;
        private Label label6;
        private Button btnBlockWeight;
        private Button btnBlockDim;
        private GroupBox groupBox1;
        private RadioButton rbtBenckmark;
        private RadioButton rbtDoNothing;
        private RadioButton rbtShutdown;
        private Button btnBatchProcess;
        private Button btnInstaller;
        private Button btnGenerateCommands;
        private Button btnLeco;
        private ComboBox cbxSDType;
        private Label label13;
        private ComboBox cbxEpochOrStep;
        private RadioButton rbtSleep;
    }
}


﻿
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
            tbxModelPath = new TextBox();
            tbxImagePath = new TextBox();
            tbxOutputPath = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            rbtSleep = new RadioButton();
            rbtShutdown = new RadioButton();
            rbtBenckmark = new RadioButton();
            rbtDoNothing = new RadioButton();
            btnBatchProcess = new Button();
            btnInstaller = new Button();
            btnGenerateCommands = new Button();
            label13 = new Label();
            cbxEpochOrStep = new ComboBox();
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            設定ToolStripMenuItem = new ToolStripMenuItem();
            プリセットを開くToolStripMenuItem = new ToolStripMenuItem();
            プリセットを保存ToolStripMenuItem = new ToolStripMenuItem();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            ヘルプToolStripMenuItem = new ToolStripMenuItem();
            ヒントToolStripMenuItem = new ToolStripMenuItem();
            配布ページToolStripMenuItem = new ToolStripMenuItem();
            ツールToolStripMenuItem = new ToolStripMenuItem();
            ユーティリティToolStripMenuItem = new ToolStripMenuItem();
            データセット編集選別ツールToolStripMenuItem = new ToolStripMenuItem();
            lECOToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label14 = new Label();
            label15 = new Label();
            tbxCommand = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudNetworkAlpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNetworkDim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudResolution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKeepTokens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBatchSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWarmupSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSaveEpoch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEpochs).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btnModel
            // 
            btnModel.Location = new Point(112, 7);
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
            btnImage.Location = new Point(364, 7);
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
            label2.Location = new Point(30, 12);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "学習元モデル*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 14);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 3;
            label3.Text = "教師画像フォルダ*";
            // 
            // btnRegImage
            // 
            btnRegImage.Location = new Point(642, 7);
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
            label4.Location = new Point(534, 14);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "正則化画像フォルダ";
            // 
            // tbxLR
            // 
            tbxLR.Location = new Point(100, 75);
            tbxLR.Name = "tbxLR";
            tbxLR.Size = new Size(85, 23);
            tbxLR.TabIndex = 4;
            tbxLR.Text = "1e-4";
            toolTip1.SetToolTip(tbxLR, "AdamW/Lionは0.0001、AdaFactorは0.001、DAdaptation系は1推奨");
            tbxLR.TextChanged += tbxLR_TextChanged;
            // 
            // lblLR
            // 
            lblLR.AutoSize = true;
            lblLR.ForeColor = SystemColors.ControlText;
            lblLR.Location = new Point(33, 78);
            lblLR.Name = "lblLR";
            lblLR.Size = new Size(64, 15);
            lblLR.TabIndex = 5;
            lblLR.Text = "学習率(LR)";
            // 
            // cbxOptimizer
            // 
            cbxOptimizer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOptimizer.ForeColor = SystemColors.WindowText;
            cbxOptimizer.FormattingEnabled = true;
            cbxOptimizer.Items.AddRange(new object[] { "AdamW8bit", "AdamW", "AdaFactor", "Lion", "SGDNesterov", "SGDNesterov8bit", "DAdaptAdamPreprint", "Lion8bit", "DAdaptAdaGrad", "DAdaptAdam", "DAdaptAdan", "DAdaptSGD", "DAdaptAdanIP", "DAdaptLion", "Prodigy", "PagedAdamW8bit", "PagedLion8bit" });
            cbxOptimizer.Location = new Point(100, 164);
            cbxOptimizer.Name = "cbxOptimizer";
            cbxOptimizer.Size = new Size(139, 23);
            cbxOptimizer.TabIndex = 6;
            toolTip1.SetToolTip(cbxOptimizer, "LionとProdigyがおすすめ\r\nDAdaptation系(Prodigy含む)はCPUボトルネックが大きい\r\nPonyDiffusionでDAdapt系を使うならLRを下げるべき");
            cbxOptimizer.SelectedIndexChanged += cbxOptimizer_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 167);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 14;
            label10.Text = "オプティマイザ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(20, 110);
            label17.Name = "label17";
            label17.Size = new Size(77, 15);
            label17.TabIndex = 23;
            label17.Text = "epochs/steps";
            // 
            // btnAdvanced
            // 
            btnAdvanced.Location = new Point(22, 437);
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
            btnStartTraining.Location = new Point(647, 467);
            btnStartTraining.Name = "btnStartTraining";
            btnStartTraining.Size = new Size(132, 39);
            btnStartTraining.TabIndex = 27;
            btnStartTraining.Text = "開始";
            btnStartTraining.UseVisualStyleBackColor = true;
            btnStartTraining.Click += btnStartTraining_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 39);
            label7.Name = "label7";
            label7.Size = new Size(177, 15);
            label7.TabIndex = 29;
            label7.Text = "#がつく項目は0を指定すると無効化";
            // 
            // cbxShuffle
            // 
            cbxShuffle.AutoSize = true;
            cbxShuffle.Location = new Point(102, 137);
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
            label12.Location = new Point(310, 140);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 33;
            label12.Text = "トークン保持数#";
            // 
            // nudNetworkAlpha
            // 
            nudNetworkAlpha.DecimalPlaces = 4;
            nudNetworkAlpha.Location = new Point(668, 104);
            nudNetworkAlpha.Maximum = new decimal(new int[] { 1280, 0, 0, 0 });
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
            nudNetworkDim.Location = new Point(400, 108);
            nudNetworkDim.Maximum = new decimal(new int[] { 1280, 0, 0, 0 });
            nudNetworkDim.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNetworkDim.Name = "nudNetworkDim";
            nudNetworkDim.Size = new Size(72, 23);
            nudNetworkDim.TabIndex = 52;
            toolTip1.SetToolTip(nudNetworkDim, "上げると学習能力が上昇するが、速度低下と生成時の不安定化を招く\r\nファイルサイズの目安(SDXL,MiB):dim*6.817\r\nconvをオンにするとさらに増加");
            nudNetworkDim.Value = new decimal(new int[] { 64, 0, 0, 0 });
            nudNetworkDim.ValueChanged += nudNetworkDim_ValueChanged;
            // 
            // nudResolution
            // 
            nudResolution.Increment = new decimal(new int[] { 64, 0, 0, 0 });
            nudResolution.Location = new Point(400, 75);
            nudResolution.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            nudResolution.Minimum = new decimal(new int[] { 128, 0, 0, 0 });
            nudResolution.Name = "nudResolution";
            nudResolution.Size = new Size(72, 23);
            nudResolution.TabIndex = 54;
            toolTip1.SetToolTip(nudResolution, "SD1.Xが512、2.Xが768、XLが1024推奨\r\n解像度を上げると細部が若干改善することがある\r\n上記の推奨未満の解像度にすると胴体分裂などの悪影響あり");
            nudResolution.Value = new decimal(new int[] { 512, 0, 0, 0 });
            nudResolution.ValueChanged += nudResolution_ValueChanged;
            // 
            // nudKeepTokens
            // 
            nudKeepTokens.Location = new Point(400, 137);
            nudKeepTokens.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            nudKeepTokens.Name = "nudKeepTokens";
            nudKeepTokens.Size = new Size(72, 23);
            nudKeepTokens.TabIndex = 55;
            toolTip1.SetToolTip(nudKeepTokens, "先頭nトークンをシャッフルの対象外にする。\r\n1トークン=カンマ区切り(デフォルト)");
            nudKeepTokens.ValueChanged += nudKeepTokens_ValueChanged;
            // 
            // nudBatchSize
            // 
            nudBatchSize.Location = new Point(668, 75);
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
            nudWarmupSteps.Location = new Point(400, 164);
            nudWarmupSteps.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            nudWarmupSteps.Name = "nudWarmupSteps";
            nudWarmupSteps.Size = new Size(72, 23);
            nudWarmupSteps.TabIndex = 62;
            toolTip1.SetToolTip(nudWarmupSteps, "指定ステップ数まで徐々にLRを上げる");
            nudWarmupSteps.Value = new decimal(new int[] { 500, 0, 0, 0 });
            nudWarmupSteps.ValueChanged += nudWarmupSteps_ValueChanged;
            // 
            // cbxSDType
            // 
            cbxSDType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSDType.FormattingEnabled = true;
            cbxSDType.Items.AddRange(new object[] { "SD1.X", "SDXL", "FLUX.1" });
            cbxSDType.Location = new Point(100, 197);
            cbxSDType.Name = "cbxSDType";
            cbxSDType.Size = new Size(139, 23);
            cbxSDType.TabIndex = 85;
            toolTip1.SetToolTip(cbxSDType, "SDXLは要求スペックもXLサイズ\r\nFLUXはそれの3倍以上");
            cbxSDType.SelectedIndexChanged += cbxSDType_SelectedIndexChanged;
            // 
            // tbxFileName
            // 
            tbxFileName.Location = new Point(100, 229);
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
            cbxModuleType.Location = new Point(668, 164);
            cbxModuleType.Name = "cbxModuleType";
            cbxModuleType.Size = new Size(80, 23);
            cbxModuleType.TabIndex = 6;
            toolTip1.SetToolTip(cbxModuleType, "LoRA-FAはメモリ消費が減少するが、LoRAの仕様上、減少量は雀の涙\r\nFLUX.1ではLoRAのみ使用可能(LoRA-FAにしてもLoRAになる)");
            cbxModuleType.SelectedIndexChanged += cbxModuleType_SelectedIndexChanged;
            // 
            // nudSaveEpoch
            // 
            nudSaveEpoch.Location = new Point(668, 133);
            nudSaveEpoch.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            nudSaveEpoch.Name = "nudSaveEpoch";
            nudSaveEpoch.Size = new Size(80, 23);
            nudSaveEpoch.TabIndex = 56;
            toolTip1.SetToolTip(nudSaveEpoch, "指定した間隔で成果物を書き出す\r\nエポックかステップのどちらを使用するかは\r\nepochs/stepsの設定に従う");
            nudSaveEpoch.ValueChanged += nudSaveEpoch_ValueChanged;
            // 
            // tbxRegImgPath
            // 
            tbxRegImgPath.AllowDrop = true;
            tbxRegImgPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxRegImgPath.Location = new Point(534, 39);
            tbxRegImgPath.Name = "tbxRegImgPath";
            tbxRegImgPath.Size = new Size(214, 22);
            tbxRegImgPath.TabIndex = 71;
            toolTip1.SetToolTip(tbxRegImgPath, "特定のものだけ\r\n出てくればいいなら不要");
            tbxRegImgPath.TextChanged += tbxRegImgPath_TextChanged;
            tbxRegImgPath.DragDrop += tbxRegImgPath_DragDrop;
            tbxRegImgPath.DragEnter += tbxRegImgPath_DragEnter;
            // 
            // btnBlockWeight
            // 
            btnBlockWeight.Location = new Point(22, 470);
            btnBlockWeight.Name = "btnBlockWeight";
            btnBlockWeight.Size = new Size(78, 27);
            btnBlockWeight.TabIndex = 75;
            btnBlockWeight.Text = "層別学習率";
            toolTip1.SetToolTip(btnBlockWeight, "XLは1.Xと層の数が異なる");
            btnBlockWeight.UseVisualStyleBackColor = true;
            btnBlockWeight.Click += btnBlockWeight_Click;
            // 
            // btnBlockDim
            // 
            btnBlockDim.Location = new Point(106, 470);
            btnBlockDim.Name = "btnBlockDim";
            btnBlockDim.Size = new Size(78, 27);
            btnBlockDim.TabIndex = 76;
            btnBlockDim.Text = "層別dim";
            toolTip1.SetToolTip(btnBlockDim, "XLは1.Xと層の数が異なる\r\n");
            btnBlockDim.UseVisualStyleBackColor = true;
            btnBlockDim.Click += btnBlockDim_Click;
            // 
            // btnSavePreset
            // 
            btnSavePreset.Location = new Point(525, 470);
            btnSavePreset.Name = "btnSavePreset";
            btnSavePreset.Size = new Size(100, 27);
            btnSavePreset.TabIndex = 34;
            btnSavePreset.Text = "プリセットの保存";
            btnSavePreset.UseVisualStyleBackColor = true;
            btnSavePreset.Click += btnSavePreset_Click;
            // 
            // btnLoadPreset
            // 
            btnLoadPreset.AllowDrop = true;
            btnLoadPreset.Location = new Point(422, 470);
            btnLoadPreset.Name = "btnLoadPreset";
            btnLoadPreset.Size = new Size(100, 27);
            btnLoadPreset.TabIndex = 35;
            btnLoadPreset.Text = "プリセットの読込";
            btnLoadPreset.UseVisualStyleBackColor = true;
            btnLoadPreset.Click += btnLoadPreset_Click;
            btnLoadPreset.DragDrop += btnLoadPreset_DragDrop;
            btnLoadPreset.DragEnter += btnLoadPreset_DragEnter;
            // 
            // lblResolution
            // 
            lblResolution.AutoSize = true;
            lblResolution.Location = new Point(352, 78);
            lblResolution.Name = "lblResolution";
            lblResolution.Size = new Size(43, 15);
            lblResolution.TabIndex = 36;
            lblResolution.Text = "解像度";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(20, 232);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(77, 15);
            lblFileName.TabIndex = 39;
            lblFileName.Text = "出力ファイル名";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(521, 135);
            label16.Name = "label16";
            label16.Size = new Size(141, 15);
            label16.TabIndex = 42;
            label16.Text = "保存頻度(Epochs/Steps)#";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(600, 77);
            label18.Name = "label18";
            label18.Size = new Size(62, 15);
            label18.TabIndex = 44;
            label18.Text = "バッチサイズ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(299, 110);
            label20.Name = "label20";
            label20.Size = new Size(95, 15);
            label20.TabIndex = 48;
            label20.Text = "ネットワーク次元数";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(569, 106);
            label21.Name = "label21";
            label21.Size = new Size(93, 15);
            label21.TabIndex = 50;
            label21.Text = "ネットワークアルファ";
            // 
            // nudEpochs
            // 
            nudEpochs.Location = new Point(100, 106);
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
            label1.Location = new Point(570, 387);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 60;
            label1.Text = "総ステップ数(目安):";
            // 
            // lblNumSteps
            // 
            lblNumSteps.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumSteps.Location = new Point(673, 385);
            lblNumSteps.Name = "lblNumSteps";
            lblNumSteps.Size = new Size(106, 24);
            lblNumSteps.TabIndex = 61;
            lblNumSteps.Text = "999,999,999";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(273, 167);
            label9.Name = "label9";
            label9.Size = new Size(121, 15);
            label9.TabIndex = 63;
            label9.Text = "ウォームアップステップ数#";
            // 
            // btnClearRegImagePath
            // 
            btnClearRegImagePath.Location = new Point(699, 7);
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
            lblNumStepsBatch1.Location = new Point(673, 409);
            lblNumStepsBatch1.Name = "lblNumStepsBatch1";
            lblNumStepsBatch1.Size = new Size(106, 22);
            lblNumStepsBatch1.TabIndex = 61;
            lblNumStepsBatch1.Text = "999,999,999";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(569, 411);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 60;
            label5.Text = "batch1相当(目安):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(102, 255);
            label8.Name = "label8";
            label8.Size = new Size(203, 15);
            label8.TabIndex = 65;
            label8.Text = "次の文字は使用できません /\\?:*<>|\"＆'`\r\n";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(553, 228);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 3;
            label11.Text = "出力先フォルダ*";
            // 
            // btnOutputPath
            // 
            btnOutputPath.Location = new Point(646, 219);
            btnOutputPath.Name = "btnOutputPath";
            btnOutputPath.Size = new Size(102, 33);
            btnOutputPath.TabIndex = 66;
            btnOutputPath.Text = "選択";
            btnOutputPath.UseVisualStyleBackColor = true;
            btnOutputPath.Click += btnOutputPath_Click;
            // 
            // btnCustomScriptPath
            // 
            btnCustomScriptPath.Location = new Point(650, 33);
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
            lblScriptPathDesc.Location = new Point(466, 37);
            lblScriptPathDesc.Name = "lblScriptPathDesc";
            lblScriptPathDesc.Size = new Size(106, 15);
            lblScriptPathDesc.TabIndex = 68;
            lblScriptPathDesc.Text = "sd-scripts場所選択";
            // 
            // tbxModelPath
            // 
            tbxModelPath.AllowDrop = true;
            tbxModelPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxModelPath.Location = new Point(12, 39);
            tbxModelPath.Name = "tbxModelPath";
            tbxModelPath.Size = new Size(208, 22);
            tbxModelPath.TabIndex = 71;
            tbxModelPath.TextChanged += tbxModelPath_TextChanged;
            tbxModelPath.DragDrop += tbxModelPath_DragDrop;
            tbxModelPath.DragEnter += tbxModelPath_DragEnter;
            // 
            // tbxImagePath
            // 
            tbxImagePath.AllowDrop = true;
            tbxImagePath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxImagePath.Location = new Point(270, 39);
            tbxImagePath.Name = "tbxImagePath";
            tbxImagePath.Size = new Size(202, 22);
            tbxImagePath.TabIndex = 71;
            tbxImagePath.TextChanged += tbxImagePath_TextChanged;
            tbxImagePath.DragDrop += tbxImagePath_DragDrop;
            tbxImagePath.DragEnter += tbxImagePath_DragEnter;
            // 
            // tbxOutputPath
            // 
            tbxOutputPath.AllowDrop = true;
            tbxOutputPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxOutputPath.Location = new Point(543, 258);
            tbxOutputPath.Name = "tbxOutputPath";
            tbxOutputPath.Size = new Size(205, 22);
            tbxOutputPath.TabIndex = 71;
            tbxOutputPath.TextChanged += tbxOutputPath_TextChanged;
            tbxOutputPath.DragDrop += tbxOutputPath_DragDrop;
            tbxOutputPath.DragEnter += tbxOutputPath_DragEnter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 167);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 72;
            label6.Text = "モジュールの種類";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtSleep);
            groupBox1.Controls.Add(rbtShutdown);
            groupBox1.Controls.Add(rbtBenckmark);
            groupBox1.Controls.Add(rbtDoNothing);
            groupBox1.Location = new Point(24, 385);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 46);
            groupBox1.TabIndex = 79;
            groupBox1.TabStop = false;
            groupBox1.Text = "学習終了後の動作";
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
            btnBatchProcess.Location = new Point(104, 437);
            btnBatchProcess.Name = "btnBatchProcess";
            btnBatchProcess.Size = new Size(78, 27);
            btnBatchProcess.TabIndex = 80;
            btnBatchProcess.Text = "バッチ処理";
            btnBatchProcess.UseVisualStyleBackColor = true;
            btnBatchProcess.Click += btnBatchProcess_Click;
            // 
            // btnInstaller
            // 
            btnInstaller.Location = new Point(336, 33);
            btnInstaller.Name = "btnInstaller";
            btnInstaller.Size = new Size(111, 26);
            btnInstaller.TabIndex = 82;
            btnInstaller.Text = "簡易インストーラー";
            btnInstaller.UseVisualStyleBackColor = true;
            btnInstaller.Click += btnInstaller_Click;
            // 
            // btnGenerateCommands
            // 
            btnGenerateCommands.Location = new Point(647, 434);
            btnGenerateCommands.Name = "btnGenerateCommands";
            btnGenerateCommands.Size = new Size(132, 27);
            btnGenerateCommands.TabIndex = 83;
            btnGenerateCommands.Text = "コマンドの生成とコピー";
            btnGenerateCommands.UseVisualStyleBackColor = true;
            btnGenerateCommands.Click += btnGenerateCommands_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 200);
            label13.Name = "label13";
            label13.Size = new Size(69, 15);
            label13.TabIndex = 14;
            label13.Text = "モデルの種類";
            // 
            // cbxEpochOrStep
            // 
            cbxEpochOrStep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEpochOrStep.FormattingEnabled = true;
            cbxEpochOrStep.Items.AddRange(new object[] { "エポック", "ステップ" });
            cbxEpochOrStep.Location = new Point(191, 106);
            cbxEpochOrStep.Name = "cbxEpochOrStep";
            cbxEpochOrStep.Size = new Size(76, 23);
            cbxEpochOrStep.TabIndex = 86;
            cbxEpochOrStep.SelectedIndexChanged += cbxEpochOrStep_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, ヘルプToolStripMenuItem, ツールToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 25);
            menuStrip1.TabIndex = 87;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 設定ToolStripMenuItem, プリセットを開くToolStripMenuItem, プリセットを保存ToolStripMenuItem, 終了ToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(63, 21);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new Size(160, 22);
            設定ToolStripMenuItem.Text = "設定";
            設定ToolStripMenuItem.Click += 設定ToolStripMenuItem_Click;
            // 
            // プリセットを開くToolStripMenuItem
            // 
            プリセットを開くToolStripMenuItem.Name = "プリセットを開くToolStripMenuItem";
            プリセットを開くToolStripMenuItem.Size = new Size(160, 22);
            プリセットを開くToolStripMenuItem.Text = "プリセットを開く";
            プリセットを開くToolStripMenuItem.Click += プリセットを開くToolStripMenuItem_Click;
            // 
            // プリセットを保存ToolStripMenuItem
            // 
            プリセットを保存ToolStripMenuItem.Name = "プリセットを保存ToolStripMenuItem";
            プリセットを保存ToolStripMenuItem.Size = new Size(160, 22);
            プリセットを保存ToolStripMenuItem.Text = "プリセットを保存";
            プリセットを保存ToolStripMenuItem.Click += プリセットを保存ToolStripMenuItem_Click;
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(160, 22);
            終了ToolStripMenuItem.Text = "終了";
            終了ToolStripMenuItem.Click += 終了ToolStripMenuItem_Click_1;
            // 
            // ヘルプToolStripMenuItem
            // 
            ヘルプToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ヒントToolStripMenuItem, 配布ページToolStripMenuItem });
            ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            ヘルプToolStripMenuItem.Size = new Size(55, 21);
            ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // ヒントToolStripMenuItem
            // 
            ヒントToolStripMenuItem.Name = "ヒントToolStripMenuItem";
            ヒントToolStripMenuItem.Size = new Size(167, 22);
            ヒントToolStripMenuItem.Text = "LoRA学習のヒント";
            ヒントToolStripMenuItem.Click += ヒントToolStripMenuItem_Click;
            // 
            // 配布ページToolStripMenuItem
            // 
            配布ページToolStripMenuItem.Name = "配布ページToolStripMenuItem";
            配布ページToolStripMenuItem.Size = new Size(167, 22);
            配布ページToolStripMenuItem.Text = "GUI配布ページ";
            配布ページToolStripMenuItem.Click += 配布ページToolStripMenuItem_Click;
            // 
            // ツールToolStripMenuItem
            // 
            ツールToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ユーティリティToolStripMenuItem, データセット編集選別ツールToolStripMenuItem, lECOToolStripMenuItem });
            ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
            ツールToolStripMenuItem.Size = new Size(54, 21);
            ツールToolStripMenuItem.Text = "ツール";
            // 
            // ユーティリティToolStripMenuItem
            // 
            ユーティリティToolStripMenuItem.Name = "ユーティリティToolStripMenuItem";
            ユーティリティToolStripMenuItem.Size = new Size(227, 22);
            ユーティリティToolStripMenuItem.Text = "ユーティリティ";
            ユーティリティToolStripMenuItem.Click += ユーティリティToolStripMenuItem_Click;
            // 
            // データセット編集選別ツールToolStripMenuItem
            // 
            データセット編集選別ツールToolStripMenuItem.Name = "データセット編集選別ツールToolStripMenuItem";
            データセット編集選別ツールToolStripMenuItem.Size = new Size(227, 22);
            データセット編集選別ツールToolStripMenuItem.Text = "データセット編集/選別ツール";
            データセット編集選別ツールToolStripMenuItem.Click += データセット編集選別ツールToolStripMenuItem_Click;
            // 
            // lECOToolStripMenuItem
            // 
            lECOToolStripMenuItem.Name = "lECOToolStripMenuItem";
            lECOToolStripMenuItem.Size = new Size(227, 22);
            lECOToolStripMenuItem.Text = "LECO";
            lECOToolStripMenuItem.Click += lECOToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 63);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(771, 316);
            tabControl1.TabIndex = 88;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnModel);
            tabPage1.Controls.Add(cbxEpochOrStep);
            tabPage1.Controls.Add(btnImage);
            tabPage1.Controls.Add(cbxSDType);
            tabPage1.Controls.Add(btnRegImage);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(tbxLR);
            tabPage1.Controls.Add(lblLR);
            tabPage1.Controls.Add(cbxOptimizer);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(cbxModuleType);
            tabPage1.Controls.Add(tbxOutputPath);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(tbxRegImgPath);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(tbxImagePath);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(tbxModelPath);
            tabPage1.Controls.Add(cbxShuffle);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(lblResolution);
            tabPage1.Controls.Add(tbxFileName);
            tabPage1.Controls.Add(btnOutputPath);
            tabPage1.Controls.Add(lblFileName);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(btnClearRegImagePath);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(nudWarmupSteps);
            tabPage1.Controls.Add(nudNetworkAlpha);
            tabPage1.Controls.Add(nudNetworkDim);
            tabPage1.Controls.Add(nudEpochs);
            tabPage1.Controls.Add(nudResolution);
            tabPage1.Controls.Add(nudBatchSize);
            tabPage1.Controls.Add(nudKeepTokens);
            tabPage1.Controls.Add(nudSaveEpoch);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(763, 288);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "学習";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(tbxCommand);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(763, 286);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "カスタムコマンド";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 184);
            label14.Name = "label14";
            label14.Size = new Size(527, 30);
            label14.TabIndex = 3;
            label14.Text = "上のテキストボックスにコマンドを入力すると学習の代わりに実行します。空欄にすると通常のLoRA学習をします。\r\nバッチ処理での使用を想定しており単一処理ではあまり使い道はありません。";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(20, 214);
            label15.Name = "label15";
            label15.Size = new Size(393, 60);
            label15.TabIndex = 2;
            label15.Text = "注意:\r\npythonまたはaccelerateコマンドのみ使用できます。&&は使用できません。\r\n安全のため信頼できるpythonコード/コマンドのみ実行してください！\r\n改行は自動的に削除されます。コマンド実行前に自動的にvenvを有効化します。";
            label15.UseMnemonic = false;
            // 
            // tbxCommand
            // 
            tbxCommand.BackColor = Color.FromArgb(64, 0, 0);
            tbxCommand.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxCommand.ForeColor = Color.White;
            tbxCommand.Location = new Point(20, 6);
            tbxCommand.Multiline = true;
            tbxCommand.Name = "tbxCommand";
            tbxCommand.Size = new Size(714, 175);
            tbxCommand.TabIndex = 0;
            tbxCommand.TextChanged += tbxCommand_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(804, 521);
            Controls.Add(tabControl1);
            Controls.Add(btnGenerateCommands);
            Controls.Add(btnInstaller);
            Controls.Add(btnBatchProcess);
            Controls.Add(groupBox1);
            Controls.Add(btnBlockDim);
            Controls.Add(btnBlockWeight);
            Controls.Add(lblScriptPathDesc);
            Controls.Add(btnCustomScriptPath);
            Controls.Add(lblNumStepsBatch1);
            Controls.Add(label5);
            Controls.Add(lblNumSteps);
            Controls.Add(label1);
            Controls.Add(btnLoadPreset);
            Controls.Add(btnSavePreset);
            Controls.Add(label7);
            Controls.Add(btnStartTraining);
            Controls.Add(btnAdvanced);
            Controls.Add(menuStrip1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kohya_lora_param_gui";
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private ComboBox cbxSDType;
        private Label label13;
        private ComboBox cbxEpochOrStep;
        private RadioButton rbtSleep;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ToolStripMenuItem プリセットを開くToolStripMenuItem;
        private ToolStripMenuItem プリセットを保存ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripMenuItem ヘルプToolStripMenuItem;
        private ToolStripMenuItem ヒントToolStripMenuItem;
        private ToolStripMenuItem 配布ページToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox tbxCommand;
        private Label label15;
        private Label label14;
        private ToolStripMenuItem ツールToolStripMenuItem;
        private ToolStripMenuItem ユーティリティToolStripMenuItem;
        private ToolStripMenuItem データセット編集選別ツールToolStripMenuItem;
        private ToolStripMenuItem lECOToolStripMenuItem;
    }
}


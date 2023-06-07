
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnModel = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxLR = new System.Windows.Forms.TextBox();
            this.lblLR = new System.Windows.Forms.Label();
            this.cbxOptimizer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.btnStartTraining = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxShuffle = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSavePreset = new System.Windows.Forms.Button();
            this.btnLoadPreset = new System.Windows.Forms.Button();
            this.lblResolution = new System.Windows.Forms.Label();
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.nudNetworkAlpha = new System.Windows.Forms.NumericUpDown();
            this.nudNetworkDim = new System.Windows.Forms.NumericUpDown();
            this.nudEpochs = new System.Windows.Forms.NumericUpDown();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.nudKeepTokens = new System.Windows.Forms.NumericUpDown();
            this.nudSaveEpoch = new System.Windows.Forms.NumericUpDown();
            this.nudBatchSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumSteps = new System.Windows.Forms.Label();
            this.nudWarmupSteps = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearRegImagePath = new System.Windows.Forms.Button();
            this.lblNumStepsBatch1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCustomScriptPath = new System.Windows.Forms.Button();
            this.lblScriptPathDesc = new System.Windows.Forms.Label();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.btnUtilities = new System.Windows.Forms.Button();
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.tbxModelPath = new System.Windows.Forms.TextBox();
            this.tbxImagePath = new System.Windows.Forms.TextBox();
            this.tbxRegImgPath = new System.Windows.Forms.TextBox();
            this.tbxOutputPath = new System.Windows.Forms.TextBox();
            this.cbxModuleType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBlockWeight = new System.Windows.Forms.Button();
            this.btnBlockDim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtShutdown = new System.Windows.Forms.RadioButton();
            this.rbtBenckmark = new System.Windows.Forms.RadioButton();
            this.rbtDoNothing = new System.Windows.Forms.RadioButton();
            this.btnBatchProcess = new System.Windows.Forms.Button();
            this.btnInstaller = new System.Windows.Forms.Button();
            this.btnGenerateCommands = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetworkAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetworkDim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKeepTokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaveEpoch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarmupSteps)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(176, 114);
            this.btnModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(166, 46);
            this.btnModel.TabIndex = 1;
            this.btnModel.Text = "選択";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(560, 114);
            this.btnImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(166, 46);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "選択";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "学習元モデル*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "教師画像フォルダ*";
            // 
            // btnRegImage
            // 
            this.btnRegImage.Location = new System.Drawing.Point(971, 114);
            this.btnRegImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegImage.Name = "btnRegImage";
            this.btnRegImage.Size = new System.Drawing.Size(166, 46);
            this.btnRegImage.TabIndex = 1;
            this.btnRegImage.Text = "選択";
            this.btnRegImage.UseVisualStyleBackColor = true;
            this.btnRegImage.Click += new System.EventHandler(this.btnRegImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(810, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "正則化画像フォルダ";
            // 
            // tbxLR
            // 
            this.tbxLR.Location = new System.Drawing.Point(162, 218);
            this.tbxLR.Name = "tbxLR";
            this.tbxLR.Size = new System.Drawing.Size(120, 31);
            this.tbxLR.TabIndex = 4;
            this.tbxLR.Text = "1e-4";
            this.toolTip2.SetToolTip(this.tbxLR, "AdamWでは1e-4、AdaFactorでは1e-3を推奨");
            this.tbxLR.TextChanged += new System.EventHandler(this.tbxLR_TextChanged);
            // 
            // lblLR
            // 
            this.lblLR.AutoSize = true;
            this.lblLR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLR.Location = new System.Drawing.Point(57, 221);
            this.lblLR.Name = "lblLR";
            this.lblLR.Size = new System.Drawing.Size(103, 25);
            this.lblLR.TabIndex = 5;
            this.lblLR.Text = "学習率(LR)*";
            // 
            // cbxOptimizer
            // 
            this.cbxOptimizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOptimizer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxOptimizer.FormattingEnabled = true;
            this.cbxOptimizer.Items.AddRange(new object[] {
            "AdamW8bit",
            "AdamW",
            "AdaFactor",
            "Lion",
            "SGDNesterov",
            "SGDNesterov8bit",
            "DAdaptAdamPreprint",
            "Lion8bit",
            "DAdaptAdaGrad",
            "DAdaptAdam",
            "DAdaptAdan",
            "DAdaptSGD",
            "DAdaptAdanIP",
            "DAdaptLion"});
            this.cbxOptimizer.Location = new System.Drawing.Point(166, 347);
            this.cbxOptimizer.Name = "cbxOptimizer";
            this.cbxOptimizer.Size = new System.Drawing.Size(208, 33);
            this.cbxOptimizer.TabIndex = 6;
            this.cbxOptimizer.SelectedIndexChanged += new System.EventHandler(this.cbxOptimizer_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "オプティマイザ*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(57, 263);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 25);
            this.label17.TabIndex = 23;
            this.label17.Text = "エポック数*";
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(24, 584);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(112, 45);
            this.btnAdvanced.TabIndex = 26;
            this.btnAdvanced.Text = "詳細設定";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnStartTraining
            // 
            this.btnStartTraining.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStartTraining.Location = new System.Drawing.Point(951, 619);
            this.btnStartTraining.Name = "btnStartTraining";
            this.btnStartTraining.Size = new System.Drawing.Size(192, 58);
            this.btnStartTraining.TabIndex = 27;
            this.btnStartTraining.Text = "学習開始";
            this.btnStartTraining.UseVisualStyleBackColor = true;
            this.btnStartTraining.Click += new System.EventHandler(this.btnStartTraining_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(417, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "*がつく項目は必須。#がつく項目は0を指定すると無効化";
            // 
            // cbxShuffle
            // 
            this.cbxShuffle.AutoSize = true;
            this.cbxShuffle.Location = new System.Drawing.Point(91, 306);
            this.cbxShuffle.Name = "cbxShuffle";
            this.cbxShuffle.Size = new System.Drawing.Size(194, 29);
            this.cbxShuffle.TabIndex = 30;
            this.cbxShuffle.Text = "キャプションのシャッフル";
            this.cbxShuffle.UseVisualStyleBackColor = true;
            this.cbxShuffle.CheckedChanged += new System.EventHandler(this.cbxShuffle_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(475, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "トークン保持数#";
            // 
            // btnSavePreset
            // 
            this.btnSavePreset.Location = new System.Drawing.Point(790, 628);
            this.btnSavePreset.Name = "btnSavePreset";
            this.btnSavePreset.Size = new System.Drawing.Size(146, 46);
            this.btnSavePreset.TabIndex = 34;
            this.btnSavePreset.Text = "プリセットの保存";
            this.toolTip3.SetToolTip(this.btnSavePreset, "すべての項目を保存します");
            this.btnSavePreset.UseVisualStyleBackColor = true;
            this.btnSavePreset.Click += new System.EventHandler(this.btnSavePreset_Click);
            // 
            // btnLoadPreset
            // 
            this.btnLoadPreset.Location = new System.Drawing.Point(624, 627);
            this.btnLoadPreset.Name = "btnLoadPreset";
            this.btnLoadPreset.Size = new System.Drawing.Size(160, 46);
            this.btnLoadPreset.TabIndex = 35;
            this.btnLoadPreset.Text = "プリセットの読込";
            this.btnLoadPreset.UseVisualStyleBackColor = true;
            this.btnLoadPreset.Click += new System.EventHandler(this.btnLoadPreset_Click);
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(526, 220);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(74, 25);
            this.lblResolution.TabIndex = 36;
            this.lblResolution.Text = "解像度*";
            // 
            // tbxFileName
            // 
            this.tbxFileName.Location = new System.Drawing.Point(162, 404);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(474, 31);
            this.tbxFileName.TabIndex = 38;
            this.tbxFileName.TextChanged += new System.EventHandler(this.tbxFileName_TextChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(39, 407);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(117, 25);
            this.lblFileName.TabIndex = 39;
            this.lblFileName.Text = "出力ファイル名";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(847, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 25);
            this.label16.TabIndex = 42;
            this.label16.Text = "nエポックごとに保存#";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(909, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 25);
            this.label18.TabIndex = 44;
            this.label18.Text = "バッチサイズ*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(449, 264);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 25);
            this.label20.TabIndex = 48;
            this.label20.Text = "ネットワーク次元数*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(862, 260);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(150, 25);
            this.label21.TabIndex = 50;
            this.label21.Text = "ネットワークアルファ*";
            // 
            // nudNetworkAlpha
            // 
            this.nudNetworkAlpha.DecimalPlaces = 2;
            this.nudNetworkAlpha.Location = new System.Drawing.Point(1017, 258);
            this.nudNetworkAlpha.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudNetworkAlpha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudNetworkAlpha.Name = "nudNetworkAlpha";
            this.nudNetworkAlpha.Size = new System.Drawing.Size(120, 31);
            this.nudNetworkAlpha.TabIndex = 51;
            this.toolTip5.SetToolTip(this.nudNetworkAlpha, "下げるとアンダーフローを抑えますが学習能力が低下します");
            this.nudNetworkAlpha.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudNetworkAlpha.ValueChanged += new System.EventHandler(this.nudNetworkAlpha_ValueChanged);
            // 
            // nudNetworkDim
            // 
            this.nudNetworkDim.Location = new System.Drawing.Point(607, 261);
            this.nudNetworkDim.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudNetworkDim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNetworkDim.Name = "nudNetworkDim";
            this.nudNetworkDim.Size = new System.Drawing.Size(120, 31);
            this.nudNetworkDim.TabIndex = 52;
            this.toolTip4.SetToolTip(this.nudNetworkDim, "学習能力、ファイルサイズ、生成速度に影響します");
            this.nudNetworkDim.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudNetworkDim.ValueChanged += new System.EventHandler(this.nudNetworkDim_ValueChanged);
            // 
            // nudEpochs
            // 
            this.nudEpochs.Location = new System.Drawing.Point(162, 261);
            this.nudEpochs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEpochs.Name = "nudEpochs";
            this.nudEpochs.Size = new System.Drawing.Size(120, 31);
            this.nudEpochs.TabIndex = 53;
            this.nudEpochs.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudEpochs.ValueChanged += new System.EventHandler(this.nudEpochs_ValueChanged);
            // 
            // nudResolution
            // 
            this.nudResolution.Increment = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudResolution.Location = new System.Drawing.Point(606, 218);
            this.nudResolution.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(120, 31);
            this.nudResolution.TabIndex = 54;
            this.toolTip7.SetToolTip(this.nudResolution, "64で割り切れる必要があります");
            this.nudResolution.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudResolution.ValueChanged += new System.EventHandler(this.nudResolution_ValueChanged);
            // 
            // nudKeepTokens
            // 
            this.nudKeepTokens.Location = new System.Drawing.Point(606, 304);
            this.nudKeepTokens.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudKeepTokens.Name = "nudKeepTokens";
            this.nudKeepTokens.Size = new System.Drawing.Size(120, 31);
            this.nudKeepTokens.TabIndex = 55;
            this.toolTip6.SetToolTip(this.nudKeepTokens, "1トークン=カンマ区切り");
            this.nudKeepTokens.ValueChanged += new System.EventHandler(this.nudKeepTokens_ValueChanged);
            // 
            // nudSaveEpoch
            // 
            this.nudSaveEpoch.Location = new System.Drawing.Point(1017, 301);
            this.nudSaveEpoch.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSaveEpoch.Name = "nudSaveEpoch";
            this.nudSaveEpoch.Size = new System.Drawing.Size(120, 31);
            this.nudSaveEpoch.TabIndex = 56;
            this.nudSaveEpoch.ValueChanged += new System.EventHandler(this.nudSaveEpoch_ValueChanged);
            // 
            // nudBatchSize
            // 
            this.nudBatchSize.Location = new System.Drawing.Point(1017, 217);
            this.nudBatchSize.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudBatchSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBatchSize.Name = "nudBatchSize";
            this.nudBatchSize.Size = new System.Drawing.Size(120, 31);
            this.nudBatchSize.TabIndex = 57;
            this.nudBatchSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBatchSize.ValueChanged += new System.EventHandler(this.nudBatchSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(895, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "総ステップ数(目安):";
            // 
            // lblNumSteps
            // 
            this.lblNumSteps.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumSteps.Location = new System.Drawing.Point(1053, 496);
            this.lblNumSteps.Name = "lblNumSteps";
            this.lblNumSteps.Size = new System.Drawing.Size(84, 25);
            this.lblNumSteps.TabIndex = 61;
            this.lblNumSteps.Text = "16384";
            // 
            // nudWarmupSteps
            // 
            this.nudWarmupSteps.Location = new System.Drawing.Point(606, 345);
            this.nudWarmupSteps.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWarmupSteps.Name = "nudWarmupSteps";
            this.nudWarmupSteps.Size = new System.Drawing.Size(120, 31);
            this.nudWarmupSteps.TabIndex = 62;
            this.nudWarmupSteps.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudWarmupSteps.ValueChanged += new System.EventHandler(this.nudWarmupSteps_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 25);
            this.label9.TabIndex = 63;
            this.label9.Text = "ウォームアップステップ数#";
            // 
            // btnClearRegImagePath
            // 
            this.btnClearRegImagePath.Location = new System.Drawing.Point(971, 72);
            this.btnClearRegImagePath.Name = "btnClearRegImagePath";
            this.btnClearRegImagePath.Size = new System.Drawing.Size(166, 35);
            this.btnClearRegImagePath.TabIndex = 64;
            this.btnClearRegImagePath.Text = "クリア";
            this.btnClearRegImagePath.UseVisualStyleBackColor = true;
            this.btnClearRegImagePath.Click += new System.EventHandler(this.btnClearRegImagePath_Click);
            // 
            // lblNumStepsBatch1
            // 
            this.lblNumStepsBatch1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumStepsBatch1.Location = new System.Drawing.Point(1053, 534);
            this.lblNumStepsBatch1.Name = "lblNumStepsBatch1";
            this.lblNumStepsBatch1.Size = new System.Drawing.Size(84, 25);
            this.lblNumStepsBatch1.TabIndex = 61;
            this.lblNumStepsBatch1.Text = "16384";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(895, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "batch1相当(目安):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(298, 25);
            this.label8.TabIndex = 65;
            this.label8.Text = "次の文字は使用できません /\\?:*<>|\"＆\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(849, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "出力先フォルダ*";
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Location = new System.Drawing.Point(982, 404);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(159, 44);
            this.btnOutputPath.TabIndex = 66;
            this.btnOutputPath.Text = "選択";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // btnCustomScriptPath
            // 
            this.btnCustomScriptPath.Location = new System.Drawing.Point(971, 13);
            this.btnCustomScriptPath.Name = "btnCustomScriptPath";
            this.btnCustomScriptPath.Size = new System.Drawing.Size(166, 37);
            this.btnCustomScriptPath.TabIndex = 67;
            this.btnCustomScriptPath.Text = "選択";
            this.btnCustomScriptPath.UseVisualStyleBackColor = true;
            this.btnCustomScriptPath.Click += new System.EventHandler(this.btnCustomScriptPath_Click);
            // 
            // lblScriptPathDesc
            // 
            this.lblScriptPathDesc.AutoSize = true;
            this.lblScriptPathDesc.ForeColor = System.Drawing.Color.Black;
            this.lblScriptPathDesc.Location = new System.Drawing.Point(804, 19);
            this.lblScriptPathDesc.Name = "lblScriptPathDesc";
            this.lblScriptPathDesc.Size = new System.Drawing.Size(161, 25);
            this.lblScriptPathDesc.TabIndex = 68;
            this.lblScriptPathDesc.Text = "sd-scripts場所選択";
            // 
            // btnUtilities
            // 
            this.btnUtilities.Location = new System.Drawing.Point(480, 631);
            this.btnUtilities.Name = "btnUtilities";
            this.btnUtilities.Size = new System.Drawing.Size(117, 40);
            this.btnUtilities.TabIndex = 69;
            this.btnUtilities.Text = "ユーティリティ";
            this.btnUtilities.UseVisualStyleBackColor = true;
            this.btnUtilities.Click += new System.EventHandler(this.btnUtilities_Click);
            // 
            // tbxModelPath
            // 
            this.tbxModelPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxModelPath.Location = new System.Drawing.Point(58, 167);
            this.tbxModelPath.Name = "tbxModelPath";
            this.tbxModelPath.Size = new System.Drawing.Size(284, 29);
            this.tbxModelPath.TabIndex = 71;
            this.tbxModelPath.TextChanged += new System.EventHandler(this.tbxModelPath_TextChanged);
            // 
            // tbxImagePath
            // 
            this.tbxImagePath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxImagePath.Location = new System.Drawing.Point(414, 166);
            this.tbxImagePath.Name = "tbxImagePath";
            this.tbxImagePath.Size = new System.Drawing.Size(312, 29);
            this.tbxImagePath.TabIndex = 71;
            this.tbxImagePath.TextChanged += new System.EventHandler(this.tbxImagePath_TextChanged);
            // 
            // tbxRegImgPath
            // 
            this.tbxRegImgPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxRegImgPath.Location = new System.Drawing.Point(813, 166);
            this.tbxRegImgPath.Name = "tbxRegImgPath";
            this.tbxRegImgPath.Size = new System.Drawing.Size(324, 29);
            this.tbxRegImgPath.TabIndex = 71;
            this.tbxRegImgPath.TextChanged += new System.EventHandler(this.tbxRegImgPath_TextChanged);
            // 
            // tbxOutputPath
            // 
            this.tbxOutputPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxOutputPath.Location = new System.Drawing.Point(815, 454);
            this.tbxOutputPath.Name = "tbxOutputPath";
            this.tbxOutputPath.Size = new System.Drawing.Size(328, 29);
            this.tbxOutputPath.TabIndex = 71;
            this.tbxOutputPath.TextChanged += new System.EventHandler(this.tbxOutputPath_TextChanged);
            // 
            // cbxModuleType
            // 
            this.cbxModuleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModuleType.FormattingEnabled = true;
            this.cbxModuleType.Items.AddRange(new object[] {
            "LoRA",
            "LyCORIS",
            "DyLoRA"});
            this.cbxModuleType.Location = new System.Drawing.Point(1017, 344);
            this.cbxModuleType.Name = "cbxModuleType";
            this.cbxModuleType.Size = new System.Drawing.Size(120, 33);
            this.cbxModuleType.TabIndex = 6;
            this.cbxModuleType.SelectedIndexChanged += new System.EventHandler(this.cbxModuleType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(873, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "モジュールの種類*";
            // 
            // btnBlockWeight
            // 
            this.btnBlockWeight.Location = new System.Drawing.Point(24, 635);
            this.btnBlockWeight.Name = "btnBlockWeight";
            this.btnBlockWeight.Size = new System.Drawing.Size(112, 42);
            this.btnBlockWeight.TabIndex = 75;
            this.btnBlockWeight.Text = "層別学習率";
            this.btnBlockWeight.UseVisualStyleBackColor = true;
            this.btnBlockWeight.Click += new System.EventHandler(this.btnBlockWeight_Click);
            // 
            // btnBlockDim
            // 
            this.btnBlockDim.Location = new System.Drawing.Point(142, 636);
            this.btnBlockDim.Name = "btnBlockDim";
            this.btnBlockDim.Size = new System.Drawing.Size(113, 41);
            this.btnBlockDim.TabIndex = 76;
            this.btnBlockDim.Text = "層別dim";
            this.btnBlockDim.UseVisualStyleBackColor = true;
            this.btnBlockDim.Click += new System.EventHandler(this.btnBlockDim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtShutdown);
            this.groupBox1.Controls.Add(this.rbtBenckmark);
            this.groupBox1.Controls.Add(this.rbtDoNothing);
            this.groupBox1.Location = new System.Drawing.Point(24, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 68);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学習終了後の動作";
            // 
            // rbtShutdown
            // 
            this.rbtShutdown.AutoSize = true;
            this.rbtShutdown.Location = new System.Drawing.Point(318, 27);
            this.rbtShutdown.Name = "rbtShutdown";
            this.rbtShutdown.Size = new System.Drawing.Size(126, 29);
            this.rbtShutdown.TabIndex = 2;
            this.rbtShutdown.Text = "シャットダウン";
            this.rbtShutdown.UseVisualStyleBackColor = true;
            // 
            // rbtBenckmark
            // 
            this.rbtBenckmark.AutoSize = true;
            this.rbtBenckmark.Location = new System.Drawing.Point(132, 28);
            this.rbtBenckmark.Name = "rbtBenckmark";
            this.rbtBenckmark.Size = new System.Drawing.Size(160, 29);
            this.rbtBenckmark.TabIndex = 1;
            this.rbtBenckmark.Text = "経過時間の表示";
            this.rbtBenckmark.UseVisualStyleBackColor = true;
            // 
            // rbtDoNothing
            // 
            this.rbtDoNothing.AutoSize = true;
            this.rbtDoNothing.Checked = true;
            this.rbtDoNothing.Location = new System.Drawing.Point(20, 29);
            this.rbtDoNothing.Name = "rbtDoNothing";
            this.rbtDoNothing.Size = new System.Drawing.Size(68, 29);
            this.rbtDoNothing.TabIndex = 0;
            this.rbtDoNothing.TabStop = true;
            this.rbtDoNothing.Text = "無し";
            this.rbtDoNothing.UseVisualStyleBackColor = true;
            // 
            // btnBatchProcess
            // 
            this.btnBatchProcess.Location = new System.Drawing.Point(143, 586);
            this.btnBatchProcess.Name = "btnBatchProcess";
            this.btnBatchProcess.Size = new System.Drawing.Size(112, 41);
            this.btnBatchProcess.TabIndex = 80;
            this.btnBatchProcess.Text = "バッチ処理";
            this.btnBatchProcess.UseVisualStyleBackColor = true;
            this.btnBatchProcess.Click += new System.EventHandler(this.btnBatchProcess_Click);
            // 
            // btnInstaller
            // 
            this.btnInstaller.Location = new System.Drawing.Point(538, 13);
            this.btnInstaller.Name = "btnInstaller";
            this.btnInstaller.Size = new System.Drawing.Size(189, 42);
            this.btnInstaller.TabIndex = 82;
            this.btnInstaller.Text = "簡易インストーラー";
            this.btnInstaller.UseVisualStyleBackColor = true;
            this.btnInstaller.Click += new System.EventHandler(this.btnInstaller_Click);
            // 
            // btnGenerateCommands
            // 
            this.btnGenerateCommands.Location = new System.Drawing.Point(951, 575);
            this.btnGenerateCommands.Name = "btnGenerateCommands";
            this.btnGenerateCommands.Size = new System.Drawing.Size(192, 38);
            this.btnGenerateCommands.TabIndex = 83;
            this.btnGenerateCommands.Text = "コマンドの生成とコピー";
            this.btnGenerateCommands.UseVisualStyleBackColor = true;
            this.btnGenerateCommands.Click += new System.EventHandler(this.btnGenerateCommands_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 694);
            this.Controls.Add(this.btnGenerateCommands);
            this.Controls.Add(this.btnInstaller);
            this.Controls.Add(this.btnBatchProcess);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBlockDim);
            this.Controls.Add(this.btnBlockWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxOutputPath);
            this.Controls.Add(this.tbxRegImgPath);
            this.Controls.Add(this.tbxImagePath);
            this.Controls.Add(this.tbxModelPath);
            this.Controls.Add(this.btnUtilities);
            this.Controls.Add(this.lblScriptPathDesc);
            this.Controls.Add(this.btnCustomScriptPath);
            this.Controls.Add(this.btnOutputPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClearRegImagePath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNumStepsBatch1);
            this.Controls.Add(this.nudWarmupSteps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumSteps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudBatchSize);
            this.Controls.Add(this.nudSaveEpoch);
            this.Controls.Add(this.nudKeepTokens);
            this.Controls.Add(this.nudResolution);
            this.Controls.Add(this.nudEpochs);
            this.Controls.Add(this.nudNetworkDim);
            this.Controls.Add(this.nudNetworkAlpha);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.tbxFileName);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.btnLoadPreset);
            this.Controls.Add(this.btnSavePreset);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxShuffle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStartTraining);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxModuleType);
            this.Controls.Add(this.cbxOptimizer);
            this.Controls.Add(this.lblLR);
            this.Controls.Add(this.tbxLR);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegImage);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnModel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoRA Training GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNetworkAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetworkDim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKeepTokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaveEpoch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarmupSteps)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLR;
        private System.Windows.Forms.Label lblLR;
        private System.Windows.Forms.ComboBox cbxOptimizer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Button btnStartTraining;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxShuffle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnSavePreset;
        private System.Windows.Forms.Button btnLoadPreset;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.TextBox tbxFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nudNetworkAlpha;
        private System.Windows.Forms.NumericUpDown nudNetworkDim;
        private System.Windows.Forms.NumericUpDown nudEpochs;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.NumericUpDown nudKeepTokens;
        private System.Windows.Forms.NumericUpDown nudSaveEpoch;
        private System.Windows.Forms.NumericUpDown nudBatchSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumSteps;
        private System.Windows.Forms.NumericUpDown nudWarmupSteps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClearRegImagePath;
        private System.Windows.Forms.Label lblNumStepsBatch1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button btnCustomScriptPath;
        private System.Windows.Forms.Label lblScriptPathDesc;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.Button btnUtilities;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.TextBox tbxModelPath;
        private System.Windows.Forms.TextBox tbxImagePath;
        private System.Windows.Forms.TextBox tbxRegImgPath;
        private System.Windows.Forms.TextBox tbxOutputPath;
        private System.Windows.Forms.ComboBox cbxModuleType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBlockWeight;
        private System.Windows.Forms.Button btnBlockDim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtBenckmark;
        private System.Windows.Forms.RadioButton rbtDoNothing;
        private System.Windows.Forms.RadioButton rbtShutdown;
        private System.Windows.Forms.Button btnBatchProcess;
        private System.Windows.Forms.Button btnInstaller;
        private System.Windows.Forms.Button btnGenerateCommands;
    }
}


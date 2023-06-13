
namespace Kohya_lora_trainer
{
    partial class FormAdvanced
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbxUnetLR = new System.Windows.Forms.TextBox();
            this.tbxTextEncoLR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinBucketReso = new System.Windows.Forms.Label();
            this.lblMaxBucketReso = new System.Windows.Forms.Label();
            this.cbxNoUpscale = new System.Windows.Forms.CheckBox();
            this.tbrCpuThreads = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCpuThreadsCounter = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbxUseWarmupInit = new System.Windows.Forms.CheckBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tbxExtension = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.nudMinBucketReso = new System.Windows.Forms.NumericUpDown();
            this.nudMaxBucketReso = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxScheduler = new System.Windows.Forms.ComboBox();
            this.nudClipSkip = new System.Windows.Forms.NumericUpDown();
            this.cbxPrecision = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDiscardAndClose = new System.Windows.Forms.Button();
            this.btnTensorBoardPath = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTBoardPath = new System.Windows.Forms.Label();
            this.btnClearTBoardPath = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxAdvancedTrain = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxCrossAttenType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxUseGradient = new System.Windows.Forms.CheckBox();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectLoRAmodel = new System.Windows.Forms.Button();
            this.btnClearLoRAmodel = new System.Windows.Forms.Button();
            this.lblLoRAmodelPath = new System.Windows.Forms.Label();
            this.nudNoiseOffset = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nudMomentum = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSelectVAE = new System.Windows.Forms.Button();
            this.btnClearVAE = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lblVAEPath = new System.Windows.Forms.Label();
            this.cbxUseWeightedCaption = new System.Windows.Forms.CheckBox();
            this.nudAdaptiveNoiseScale = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.nudMinSNRGamma = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nudMultiresNoiseIterations = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.nudMultiresNoiseDiscount = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblConfigPath = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnClearConfigPath = new System.Windows.Forms.Button();
            this.btnSelectConfigPath = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbxScaleVPredLoss = new System.Windows.Forms.CheckBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.nudMaxNormReg = new System.Windows.Forms.NumericUpDown();
            this.nudModuleDropout = new System.Windows.Forms.NumericUpDown();
            this.nudRankDropout = new System.Windows.Forms.NumericUpDown();
            this.nudDropout = new System.Windows.Forms.NumericUpDown();
            this.cbxUseColorAug = new System.Windows.Forms.CheckBox();
            this.cbxCacheLatentsToDisk = new System.Windows.Forms.CheckBox();
            this.cbxUseFastLoading = new System.Windows.Forms.CheckBox();
            this.cbxCacheLatents = new System.Windows.Forms.CheckBox();
            this.cbxUseV2 = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cbxUseParametarization = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cbxDontSaveMetadata = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbxCropRandomly = new System.Windows.Forms.CheckBox();
            this.nudMaxTokens = new System.Windows.Forms.NumericUpDown();
            this.cbxFlipAug = new System.Windows.Forms.CheckBox();
            this.nudDataLoaderThreads = new System.Windows.Forms.NumericUpDown();
            this.cbxMixedPrecision = new System.Windows.Forms.ComboBox();
            this.nudLRSchedulerCycle = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbxNoProx = new System.Windows.Forms.CheckBox();
            this.cbxDecouple = new System.Windows.Forms.CheckBox();
            this.tbxMomentum = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbxWeightDecay = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbxBetas0 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbxBetas1 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tbxBetas2 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tbxEps = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tbxD0 = new System.Windows.Forms.TextBox();
            this.tbxGrowthRate = new System.Windows.Forms.TextBox();
            this.pageConv = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.nudDyLoRAUnit = new System.Windows.Forms.NumericUpDown();
            this.cbxUseConv2d = new System.Windows.Forms.CheckBox();
            this.nudConvAlpha = new System.Windows.Forms.NumericUpDown();
            this.nudConvDim = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cbxAlgoType = new System.Windows.Forms.ComboBox();
            this.pageMisc = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbrCpuThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinBucketReso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxBucketReso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClipSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoiseOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMomentum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdaptiveNoiseScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSNRGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiresNoiseIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiresNoiseDiscount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxNormReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModuleDropout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRankDropout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataLoaderThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLRSchedulerCycle)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.pageConv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDyLoRAUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvDim)).BeginInit();
            this.pageMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxUnetLR
            // 
            this.tbxUnetLR.Location = new System.Drawing.Point(203, 70);
            this.tbxUnetLR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxUnetLR.Name = "tbxUnetLR";
            this.tbxUnetLR.Size = new System.Drawing.Size(100, 31);
            this.tbxUnetLR.TabIndex = 0;
            this.tbxUnetLR.TextChanged += new System.EventHandler(this.tbxUnetLR_TextChanged);
            // 
            // tbxTextEncoLR
            // 
            this.tbxTextEncoLR.Location = new System.Drawing.Point(539, 67);
            this.tbxTextEncoLR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxTextEncoLR.Name = "tbxTextEncoLR";
            this.tbxTextEncoLR.Size = new System.Drawing.Size(100, 31);
            this.tbxTextEncoLR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "UNet LR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text encoder LR";
            // 
            // lblMinBucketReso
            // 
            this.lblMinBucketReso.AutoSize = true;
            this.lblMinBucketReso.Location = new System.Drawing.Point(37, 111);
            this.lblMinBucketReso.Name = "lblMinBucketReso";
            this.lblMinBucketReso.Size = new System.Drawing.Size(163, 25);
            this.lblMinBucketReso.TabIndex = 4;
            this.lblMinBucketReso.Text = "最小バケット解像度*";
            // 
            // lblMaxBucketReso
            // 
            this.lblMaxBucketReso.AutoSize = true;
            this.lblMaxBucketReso.Location = new System.Drawing.Point(370, 111);
            this.lblMaxBucketReso.Name = "lblMaxBucketReso";
            this.lblMaxBucketReso.Size = new System.Drawing.Size(163, 25);
            this.lblMaxBucketReso.TabIndex = 7;
            this.lblMaxBucketReso.Text = "最大バケット解像度*";
            // 
            // cbxNoUpscale
            // 
            this.cbxNoUpscale.AutoSize = true;
            this.cbxNoUpscale.Location = new System.Drawing.Point(42, 157);
            this.cbxNoUpscale.Name = "cbxNoUpscale";
            this.cbxNoUpscale.Size = new System.Drawing.Size(283, 29);
            this.cbxNoUpscale.TabIndex = 8;
            this.cbxNoUpscale.Text = "バケットのアップスケーリングをしない";
            this.cbxNoUpscale.UseVisualStyleBackColor = true;
            // 
            // tbrCpuThreads
            // 
            this.tbrCpuThreads.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbrCpuThreads.Location = new System.Drawing.Point(158, 41);
            this.tbrCpuThreads.Maximum = 32;
            this.tbrCpuThreads.Minimum = 1;
            this.tbrCpuThreads.Name = "tbrCpuThreads";
            this.tbrCpuThreads.Size = new System.Drawing.Size(470, 69);
            this.tbrCpuThreads.TabIndex = 9;
            this.tbrCpuThreads.Value = 12;
            this.tbrCpuThreads.Scroll += new System.EventHandler(this.tbrCpuThreads_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPUスレッド数*";
            // 
            // lblCpuThreadsCounter
            // 
            this.lblCpuThreadsCounter.AutoSize = true;
            this.lblCpuThreadsCounter.Location = new System.Drawing.Point(645, 41);
            this.lblCpuThreadsCounter.Name = "lblCpuThreadsCounter";
            this.lblCpuThreadsCounter.Size = new System.Drawing.Size(32, 25);
            this.lblCpuThreadsCounter.TabIndex = 11;
            this.lblCpuThreadsCounter.Text = "12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Clip Skip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Seed";
            // 
            // cbxUseWarmupInit
            // 
            this.cbxUseWarmupInit.AutoSize = true;
            this.cbxUseWarmupInit.Location = new System.Drawing.Point(37, 288);
            this.cbxUseWarmupInit.Name = "cbxUseWarmupInit";
            this.cbxUseWarmupInit.Size = new System.Drawing.Size(302, 29);
            this.cbxUseWarmupInit.TabIndex = 18;
            this.cbxUseWarmupInit.Text = "AdaFactor: warmup_initを使用する";
            this.toolTip2.SetToolTip(this.cbxUseWarmupInit, "使用すると、学習が遅くなります。");
            this.cbxUseWarmupInit.UseVisualStyleBackColor = true;
            // 
            // tbxExtension
            // 
            this.tbxExtension.Location = new System.Drawing.Point(190, 134);
            this.tbxExtension.Name = "tbxExtension";
            this.tbxExtension.Size = new System.Drawing.Size(126, 31);
            this.tbxExtension.TabIndex = 19;
            this.tbxExtension.Text = ".txt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 50);
            this.label9.TabIndex = 20;
            this.label9.Text = "キャプションファイルの\r\n拡張子";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(829, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "設定を反映して閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudSeed
            // 
            this.nudSeed.Location = new System.Drawing.Point(501, 85);
            this.nudSeed.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(120, 31);
            this.nudSeed.TabIndex = 23;
            this.nudSeed.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            // 
            // nudMinBucketReso
            // 
            this.nudMinBucketReso.Increment = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudMinBucketReso.Location = new System.Drawing.Point(203, 109);
            this.nudMinBucketReso.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudMinBucketReso.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudMinBucketReso.Name = "nudMinBucketReso";
            this.nudMinBucketReso.Size = new System.Drawing.Size(120, 31);
            this.nudMinBucketReso.TabIndex = 24;
            this.nudMinBucketReso.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.nudMinBucketReso.ValueChanged += new System.EventHandler(this.nudMinBucketReso_ValueChanged);
            // 
            // nudMaxBucketReso
            // 
            this.nudMaxBucketReso.Increment = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudMaxBucketReso.Location = new System.Drawing.Point(539, 109);
            this.nudMaxBucketReso.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.nudMaxBucketReso.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudMaxBucketReso.Name = "nudMaxBucketReso";
            this.nudMaxBucketReso.Size = new System.Drawing.Size(120, 31);
            this.nudMaxBucketReso.TabIndex = 25;
            this.nudMaxBucketReso.Value = new decimal(new int[] {
            960,
            0,
            0,
            0});
            this.nudMaxBucketReso.ValueChanged += new System.EventHandler(this.nudMaxBucketReso_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "スケジューラ";
            // 
            // cbxScheduler
            // 
            this.cbxScheduler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxScheduler.FormattingEnabled = true;
            this.cbxScheduler.Items.AddRange(new object[] {
            "cosine_with_restarts",
            "cosine",
            "linear",
            "polynomial",
            "constant",
            "constant_with_warmup"});
            this.cbxScheduler.Location = new System.Drawing.Point(203, 27);
            this.cbxScheduler.Name = "cbxScheduler";
            this.cbxScheduler.Size = new System.Drawing.Size(212, 33);
            this.cbxScheduler.TabIndex = 27;
            // 
            // nudClipSkip
            // 
            this.nudClipSkip.Location = new System.Drawing.Point(189, 85);
            this.nudClipSkip.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudClipSkip.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClipSkip.Name = "nudClipSkip";
            this.nudClipSkip.Size = new System.Drawing.Size(120, 31);
            this.nudClipSkip.TabIndex = 28;
            this.nudClipSkip.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cbxPrecision
            // 
            this.cbxPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrecision.FormattingEnabled = true;
            this.cbxPrecision.Items.AddRange(new object[] {
            "fp16",
            "bf16",
            "float"});
            this.cbxPrecision.Location = new System.Drawing.Point(501, 136);
            this.cbxPrecision.Name = "cbxPrecision";
            this.cbxPrecision.Size = new System.Drawing.Size(121, 33);
            this.cbxPrecision.TabIndex = 29;
            this.toolTip3.SetToolTip(this.cbxPrecision, "fp16にするとファイルサイズを小さくします");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(379, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "保存時の精度";
            // 
            // btnDiscardAndClose
            // 
            this.btnDiscardAndClose.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDiscardAndClose.Location = new System.Drawing.Point(561, 459);
            this.btnDiscardAndClose.Name = "btnDiscardAndClose";
            this.btnDiscardAndClose.Size = new System.Drawing.Size(257, 44);
            this.btnDiscardAndClose.TabIndex = 31;
            this.btnDiscardAndClose.Text = "設定を反映せずに閉じる";
            this.btnDiscardAndClose.UseVisualStyleBackColor = true;
            this.btnDiscardAndClose.Click += new System.EventHandler(this.btnDiscardAndClose_Click);
            // 
            // btnTensorBoardPath
            // 
            this.btnTensorBoardPath.Location = new System.Drawing.Point(158, 229);
            this.btnTensorBoardPath.Name = "btnTensorBoardPath";
            this.btnTensorBoardPath.Size = new System.Drawing.Size(110, 46);
            this.btnTensorBoardPath.TabIndex = 32;
            this.btnTensorBoardPath.Text = "選択";
            this.btnTensorBoardPath.UseVisualStyleBackColor = true;
            this.btnTensorBoardPath.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 50);
            this.label12.TabIndex = 33;
            this.label12.Text = "Tensorboard用\r\nログ出力先";
            // 
            // lblTBoardPath
            // 
            this.lblTBoardPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTBoardPath.Location = new System.Drawing.Point(36, 279);
            this.lblTBoardPath.Name = "lblTBoardPath";
            this.lblTBoardPath.Size = new System.Drawing.Size(320, 46);
            this.lblTBoardPath.TabIndex = 34;
            this.lblTBoardPath.Text = "D:\\Sample\\Please stop using Super Long Naming\\RegImage\\1_1girl";
            // 
            // btnClearTBoardPath
            // 
            this.btnClearTBoardPath.Location = new System.Drawing.Point(274, 229);
            this.btnClearTBoardPath.Name = "btnClearTBoardPath";
            this.btnClearTBoardPath.Size = new System.Drawing.Size(101, 46);
            this.btnClearTBoardPath.TabIndex = 35;
            this.btnClearTBoardPath.Text = "クリア";
            this.btnClearTBoardPath.UseVisualStyleBackColor = true;
            this.btnClearTBoardPath.Click += new System.EventHandler(this.btnClearTBoardPath_Click);
            // 
            // cbxAdvancedTrain
            // 
            this.cbxAdvancedTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAdvancedTrain.FormattingEnabled = true;
            this.cbxAdvancedTrain.Items.AddRange(new object[] {
            "しない",
            "TextEncoderのみ学習",
            "UNetのみ学習"});
            this.cbxAdvancedTrain.Location = new System.Drawing.Point(539, 27);
            this.cbxAdvancedTrain.Name = "cbxAdvancedTrain";
            this.cbxAdvancedTrain.Size = new System.Drawing.Size(205, 33);
            this.cbxAdvancedTrain.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(434, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 25);
            this.label13.TabIndex = 37;
            this.label13.Text = "特殊な学習";
            // 
            // cbxCrossAttenType
            // 
            this.cbxCrossAttenType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCrossAttenType.FormattingEnabled = true;
            this.cbxCrossAttenType.Items.AddRange(new object[] {
            "xformers",
            "mem_eff_attn"});
            this.cbxCrossAttenType.Location = new System.Drawing.Point(373, 195);
            this.cbxCrossAttenType.Name = "cbxCrossAttenType";
            this.cbxCrossAttenType.Size = new System.Drawing.Size(207, 33);
            this.cbxCrossAttenType.TabIndex = 38;
            this.toolTip5.SetToolTip(this.cbxCrossAttenType, "mem_eff_attnは遅いが省メモリ");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "クロスアテンションの種類";
            // 
            // cbxUseGradient
            // 
            this.cbxUseGradient.AutoSize = true;
            this.cbxUseGradient.Location = new System.Drawing.Point(41, 192);
            this.cbxUseGradient.Name = "cbxUseGradient";
            this.cbxUseGradient.Size = new System.Drawing.Size(301, 29);
            this.cbxUseGradient.TabIndex = 18;
            this.cbxUseGradient.Text = "gradient_checkpointingを使用する";
            this.toolTip6.SetToolTip(this.cbxUseGradient, "速度低下と引き換えにメモリ消費量を減らす");
            this.cbxUseGradient.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 50);
            this.label3.TabIndex = 41;
            this.label3.Text = "追加学習する\r\nLoRAモデル";
            // 
            // btnSelectLoRAmodel
            // 
            this.btnSelectLoRAmodel.Location = new System.Drawing.Point(158, 116);
            this.btnSelectLoRAmodel.Name = "btnSelectLoRAmodel";
            this.btnSelectLoRAmodel.Size = new System.Drawing.Size(110, 45);
            this.btnSelectLoRAmodel.TabIndex = 42;
            this.btnSelectLoRAmodel.Text = "選択";
            this.btnSelectLoRAmodel.UseVisualStyleBackColor = true;
            this.btnSelectLoRAmodel.Click += new System.EventHandler(this.btnSelectLoRAmodel_Click);
            // 
            // btnClearLoRAmodel
            // 
            this.btnClearLoRAmodel.Location = new System.Drawing.Point(274, 116);
            this.btnClearLoRAmodel.Name = "btnClearLoRAmodel";
            this.btnClearLoRAmodel.Size = new System.Drawing.Size(110, 45);
            this.btnClearLoRAmodel.TabIndex = 42;
            this.btnClearLoRAmodel.Text = "クリア";
            this.btnClearLoRAmodel.UseVisualStyleBackColor = true;
            this.btnClearLoRAmodel.Click += new System.EventHandler(this.btnClearLoRAmodel_Click);
            // 
            // lblLoRAmodelPath
            // 
            this.lblLoRAmodelPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLoRAmodelPath.Location = new System.Drawing.Point(50, 180);
            this.lblLoRAmodelPath.Name = "lblLoRAmodelPath";
            this.lblLoRAmodelPath.Size = new System.Drawing.Size(334, 46);
            this.lblLoRAmodelPath.TabIndex = 43;
            this.lblLoRAmodelPath.Text = "C:\\Sample\\SuperLong\\Multibyte\\and\\spaces\\日本語.safetensors";
            // 
            // nudNoiseOffset
            // 
            this.nudNoiseOffset.DecimalPlaces = 4;
            this.nudNoiseOffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudNoiseOffset.Location = new System.Drawing.Point(918, 29);
            this.nudNoiseOffset.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoiseOffset.Name = "nudNoiseOffset";
            this.nudNoiseOffset.Size = new System.Drawing.Size(120, 31);
            this.nudNoiseOffset.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(786, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 25);
            this.label14.TabIndex = 45;
            this.label14.Text = "ノイズオフセット#";
            // 
            // nudMomentum
            // 
            this.nudMomentum.DecimalPlaces = 4;
            this.nudMomentum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMomentum.Location = new System.Drawing.Point(918, 66);
            this.nudMomentum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMomentum.Name = "nudMomentum";
            this.nudMomentum.Size = new System.Drawing.Size(120, 31);
            this.nudMomentum.TabIndex = 44;
            this.nudMomentum.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(790, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 50);
            this.label15.TabIndex = 45;
            this.label15.Text = "Nesterovの\r\nmomentum#";
            // 
            // btnSelectVAE
            // 
            this.btnSelectVAE.Location = new System.Drawing.Point(527, 120);
            this.btnSelectVAE.Name = "btnSelectVAE";
            this.btnSelectVAE.Size = new System.Drawing.Size(101, 45);
            this.btnSelectVAE.TabIndex = 46;
            this.btnSelectVAE.Text = "選択";
            this.btnSelectVAE.UseVisualStyleBackColor = true;
            this.btnSelectVAE.Click += new System.EventHandler(this.btnSelectVAE_Click);
            // 
            // btnClearVAE
            // 
            this.btnClearVAE.Location = new System.Drawing.Point(634, 119);
            this.btnClearVAE.Name = "btnClearVAE";
            this.btnClearVAE.Size = new System.Drawing.Size(101, 45);
            this.btnClearVAE.TabIndex = 46;
            this.btnClearVAE.Text = "クリア";
            this.btnClearVAE.UseVisualStyleBackColor = true;
            this.btnClearVAE.Click += new System.EventHandler(this.btnClearVAE_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(452, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 25);
            this.label16.TabIndex = 47;
            this.label16.Text = "VAE";
            // 
            // lblVAEPath
            // 
            this.lblVAEPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblVAEPath.Location = new System.Drawing.Point(418, 168);
            this.lblVAEPath.Name = "lblVAEPath";
            this.lblVAEPath.Size = new System.Drawing.Size(334, 46);
            this.lblVAEPath.TabIndex = 43;
            this.lblVAEPath.Text = "C:\\Sample\\SuperLong\\Multibyte\\and\\spaces\\日本語.safetensors";
            // 
            // cbxUseWeightedCaption
            // 
            this.cbxUseWeightedCaption.AutoSize = true;
            this.cbxUseWeightedCaption.Location = new System.Drawing.Point(42, 228);
            this.cbxUseWeightedCaption.Name = "cbxUseWeightedCaption";
            this.cbxUseWeightedCaption.Size = new System.Drawing.Size(242, 54);
            this.cbxUseWeightedCaption.TabIndex = 48;
            this.cbxUseWeightedCaption.Text = "キャプションに重みづけを使用\r\n(weighted_captions)";
            this.cbxUseWeightedCaption.UseVisualStyleBackColor = true;
            // 
            // nudAdaptiveNoiseScale
            // 
            this.nudAdaptiveNoiseScale.DecimalPlaces = 1;
            this.nudAdaptiveNoiseScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudAdaptiveNoiseScale.Location = new System.Drawing.Point(918, 134);
            this.nudAdaptiveNoiseScale.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudAdaptiveNoiseScale.Name = "nudAdaptiveNoiseScale";
            this.nudAdaptiveNoiseScale.Size = new System.Drawing.Size(120, 31);
            this.nudAdaptiveNoiseScale.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(790, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 50);
            this.label17.TabIndex = 50;
            this.label17.Text = "適応\r\nノイズスケール#";
            // 
            // nudMinSNRGamma
            // 
            this.nudMinSNRGamma.Location = new System.Drawing.Point(918, 202);
            this.nudMinSNRGamma.Name = "nudMinSNRGamma";
            this.nudMinSNRGamma.Size = new System.Drawing.Size(120, 31);
            this.nudMinSNRGamma.TabIndex = 51;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(751, 204);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 25);
            this.label18.TabIndex = 52;
            this.label18.Text = "Min-SNR Gamma#";
            // 
            // nudMultiresNoiseIterations
            // 
            this.nudMultiresNoiseIterations.Location = new System.Drawing.Point(918, 240);
            this.nudMultiresNoiseIterations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMultiresNoiseIterations.Name = "nudMultiresNoiseIterations";
            this.nudMultiresNoiseIterations.Size = new System.Drawing.Size(120, 31);
            this.nudMultiresNoiseIterations.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(782, 242);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 50);
            this.label19.TabIndex = 54;
            this.label19.Text = "Multires Noise\r\nIterations#";
            // 
            // nudMultiresNoiseDiscount
            // 
            this.nudMultiresNoiseDiscount.DecimalPlaces = 2;
            this.nudMultiresNoiseDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMultiresNoiseDiscount.Location = new System.Drawing.Point(499, 240);
            this.nudMultiresNoiseDiscount.Name = "nudMultiresNoiseDiscount";
            this.nudMultiresNoiseDiscount.Size = new System.Drawing.Size(120, 31);
            this.nudMultiresNoiseDiscount.TabIndex = 55;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(368, 242);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 50);
            this.label20.TabIndex = 56;
            this.label20.Text = "Multires Noise\r\nDiscount#";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.pageConv);
            this.tabControl1.Controls.Add(this.pageMisc);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 431);
            this.tabControl1.TabIndex = 57;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.tbxUnetLR);
            this.tabPage1.Controls.Add(this.nudMultiresNoiseDiscount);
            this.tabPage1.Controls.Add(this.tbxTextEncoLR);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nudMultiresNoiseIterations);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.lblMinBucketReso);
            this.tabPage1.Controls.Add(this.nudMinSNRGamma);
            this.tabPage1.Controls.Add(this.lblMaxBucketReso);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.cbxNoUpscale);
            this.tabPage1.Controls.Add(this.nudAdaptiveNoiseScale);
            this.tabPage1.Controls.Add(this.cbxUseWeightedCaption);
            this.tabPage1.Controls.Add(this.cbxUseWarmupInit);
            this.tabPage1.Controls.Add(this.cbxUseGradient);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.nudMinBucketReso);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.nudMaxBucketReso);
            this.tabPage1.Controls.Add(this.nudMomentum);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cbxScheduler);
            this.tabPage1.Controls.Add(this.nudNoiseOffset);
            this.tabPage1.Controls.Add(this.cbxAdvancedTrain);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.cbxCrossAttenType);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1072, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ページ1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblConfigPath);
            this.tabPage2.Controls.Add(this.lblVAEPath);
            this.tabPage2.Controls.Add(this.tbrCpuThreads);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.lblCpuThreadsCounter);
            this.tabPage2.Controls.Add(this.btnClearTBoardPath);
            this.tabPage2.Controls.Add(this.btnClearConfigPath);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnSelectLoRAmodel);
            this.tabPage2.Controls.Add(this.btnSelectConfigPath);
            this.tabPage2.Controls.Add(this.lblTBoardPath);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnClearLoRAmodel);
            this.tabPage2.Controls.Add(this.btnTensorBoardPath);
            this.tabPage2.Controls.Add(this.lblLoRAmodelPath);
            this.tabPage2.Controls.Add(this.btnClearVAE);
            this.tabPage2.Controls.Add(this.btnSelectVAE);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1072, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ページ2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblConfigPath
            // 
            this.lblConfigPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConfigPath.Location = new System.Drawing.Point(523, 289);
            this.lblConfigPath.Name = "lblConfigPath";
            this.lblConfigPath.Size = new System.Drawing.Size(281, 50);
            this.lblConfigPath.TabIndex = 25;
            this.lblConfigPath.Text = "C:\\Users\\Test\\Desktop\\long name\\aaaaa.toml";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(417, 235);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 50);
            this.label21.TabIndex = 26;
            this.label21.Text = "dataset\r\nconfigのパス";
            // 
            // btnClearConfigPath
            // 
            this.btnClearConfigPath.Location = new System.Drawing.Point(634, 229);
            this.btnClearConfigPath.Name = "btnClearConfigPath";
            this.btnClearConfigPath.Size = new System.Drawing.Size(106, 46);
            this.btnClearConfigPath.TabIndex = 23;
            this.btnClearConfigPath.Text = "クリア";
            this.btnClearConfigPath.UseVisualStyleBackColor = true;
            this.btnClearConfigPath.Click += new System.EventHandler(this.btnClearConfigPath_Click);
            // 
            // btnSelectConfigPath
            // 
            this.btnSelectConfigPath.Location = new System.Drawing.Point(527, 229);
            this.btnSelectConfigPath.Name = "btnSelectConfigPath";
            this.btnSelectConfigPath.Size = new System.Drawing.Size(101, 46);
            this.btnSelectConfigPath.TabIndex = 24;
            this.btnSelectConfigPath.Text = "選択";
            this.btnSelectConfigPath.UseVisualStyleBackColor = true;
            this.btnSelectConfigPath.Click += new System.EventHandler(this.btnSelectConfigPath_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbxScaleVPredLoss);
            this.tabPage4.Controls.Add(this.label39);
            this.tabPage4.Controls.Add(this.label38);
            this.tabPage4.Controls.Add(this.label37);
            this.tabPage4.Controls.Add(this.label36);
            this.tabPage4.Controls.Add(this.nudMaxNormReg);
            this.tabPage4.Controls.Add(this.nudModuleDropout);
            this.tabPage4.Controls.Add(this.nudRankDropout);
            this.tabPage4.Controls.Add(this.nudDropout);
            this.tabPage4.Controls.Add(this.cbxUseColorAug);
            this.tabPage4.Controls.Add(this.cbxCacheLatentsToDisk);
            this.tabPage4.Controls.Add(this.cbxUseFastLoading);
            this.tabPage4.Controls.Add(this.cbxCacheLatents);
            this.tabPage4.Controls.Add(this.cbxUseV2);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.cbxUseParametarization);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.cbxDontSaveMetadata);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.cbxCropRandomly);
            this.tabPage4.Controls.Add(this.nudMaxTokens);
            this.tabPage4.Controls.Add(this.cbxFlipAug);
            this.tabPage4.Controls.Add(this.nudDataLoaderThreads);
            this.tabPage4.Controls.Add(this.cbxMixedPrecision);
            this.tabPage4.Controls.Add(this.nudLRSchedulerCycle);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1072, 393);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "ページ3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbxScaleVPredLoss
            // 
            this.cbxScaleVPredLoss.AutoSize = true;
            this.cbxScaleVPredLoss.Location = new System.Drawing.Point(39, 218);
            this.cbxScaleVPredLoss.Name = "cbxScaleVPredLoss";
            this.cbxScaleVPredLoss.Size = new System.Drawing.Size(265, 29);
            this.cbxScaleVPredLoss.TabIndex = 26;
            this.cbxScaleVPredLoss.Text = "v-prediction lossのスケーリング";
            this.cbxScaleVPredLoss.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(556, 299);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(224, 25);
            this.label39.TabIndex = 25;
            this.label39.Text = "Max Norm Regularization#";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(569, 262);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(211, 25);
            this.label38.TabIndex = 25;
            this.label38.Text = "moduleドロップアウト確率#";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(596, 225);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(184, 25);
            this.label37.TabIndex = 25;
            this.label37.Text = "rankドロップアウト確率#";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(630, 188);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(150, 25);
            this.label36.TabIndex = 25;
            this.label36.Text = "ドロップアウト確率#";
            // 
            // nudMaxNormReg
            // 
            this.nudMaxNormReg.DecimalPlaces = 2;
            this.nudMaxNormReg.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudMaxNormReg.Location = new System.Drawing.Point(786, 297);
            this.nudMaxNormReg.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxNormReg.Name = "nudMaxNormReg";
            this.nudMaxNormReg.Size = new System.Drawing.Size(120, 31);
            this.nudMaxNormReg.TabIndex = 24;
            // 
            // nudModuleDropout
            // 
            this.nudModuleDropout.DecimalPlaces = 2;
            this.nudModuleDropout.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudModuleDropout.Location = new System.Drawing.Point(786, 260);
            this.nudModuleDropout.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudModuleDropout.Name = "nudModuleDropout";
            this.nudModuleDropout.Size = new System.Drawing.Size(120, 31);
            this.nudModuleDropout.TabIndex = 24;
            // 
            // nudRankDropout
            // 
            this.nudRankDropout.DecimalPlaces = 2;
            this.nudRankDropout.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudRankDropout.Location = new System.Drawing.Point(786, 223);
            this.nudRankDropout.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRankDropout.Name = "nudRankDropout";
            this.nudRankDropout.Size = new System.Drawing.Size(120, 31);
            this.nudRankDropout.TabIndex = 24;
            // 
            // nudDropout
            // 
            this.nudDropout.DecimalPlaces = 2;
            this.nudDropout.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDropout.Location = new System.Drawing.Point(786, 186);
            this.nudDropout.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDropout.Name = "nudDropout";
            this.nudDropout.Size = new System.Drawing.Size(120, 31);
            this.nudDropout.TabIndex = 24;
            // 
            // cbxUseColorAug
            // 
            this.cbxUseColorAug.AutoSize = true;
            this.cbxUseColorAug.Checked = true;
            this.cbxUseColorAug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUseColorAug.Location = new System.Drawing.Point(39, 42);
            this.cbxUseColorAug.Name = "cbxUseColorAug";
            this.cbxUseColorAug.Size = new System.Drawing.Size(165, 29);
            this.cbxUseColorAug.TabIndex = 7;
            this.cbxUseColorAug.Text = "color_augを使用";
            this.cbxUseColorAug.UseVisualStyleBackColor = true;
            // 
            // cbxCacheLatentsToDisk
            // 
            this.cbxCacheLatentsToDisk.AutoSize = true;
            this.cbxCacheLatentsToDisk.Location = new System.Drawing.Point(39, 182);
            this.cbxCacheLatentsToDisk.Name = "cbxCacheLatentsToDisk";
            this.cbxCacheLatentsToDisk.Size = new System.Drawing.Size(227, 29);
            this.cbxCacheLatentsToDisk.TabIndex = 23;
            this.cbxCacheLatentsToDisk.Text = "latentをディスクにキャッシュ";
            this.cbxCacheLatentsToDisk.UseVisualStyleBackColor = true;
            // 
            // cbxUseFastLoading
            // 
            this.cbxUseFastLoading.AutoSize = true;
            this.cbxUseFastLoading.Checked = true;
            this.cbxUseFastLoading.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUseFastLoading.Location = new System.Drawing.Point(39, 77);
            this.cbxUseFastLoading.Name = "cbxUseFastLoading";
            this.cbxUseFastLoading.Size = new System.Drawing.Size(143, 29);
            this.cbxUseFastLoading.TabIndex = 12;
            this.cbxUseFastLoading.Text = "読込の高速化";
            this.cbxUseFastLoading.UseVisualStyleBackColor = true;
            // 
            // cbxCacheLatents
            // 
            this.cbxCacheLatents.AutoSize = true;
            this.cbxCacheLatents.Location = new System.Drawing.Point(343, 147);
            this.cbxCacheLatents.Name = "cbxCacheLatents";
            this.cbxCacheLatents.Size = new System.Drawing.Size(161, 29);
            this.cbxCacheLatents.TabIndex = 22;
            this.cbxCacheLatents.Text = "latentのキャッシュ";
            this.cbxCacheLatents.UseVisualStyleBackColor = true;
            // 
            // cbxUseV2
            // 
            this.cbxUseV2.AutoSize = true;
            this.cbxUseV2.Location = new System.Drawing.Point(39, 112);
            this.cbxUseV2.Name = "cbxUseV2";
            this.cbxUseV2.Size = new System.Drawing.Size(243, 29);
            this.cbxUseV2.TabIndex = 13;
            this.cbxUseV2.Text = "Stable Diffusion 2.Xを使用";
            this.cbxUseV2.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(663, 151);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(117, 25);
            this.label26.TabIndex = 19;
            this.label26.Text = "最大トークン数";
            // 
            // cbxUseParametarization
            // 
            this.cbxUseParametarization.AutoSize = true;
            this.cbxUseParametarization.Location = new System.Drawing.Point(39, 147);
            this.cbxUseParametarization.Name = "cbxUseParametarization";
            this.cbxUseParametarization.Size = new System.Drawing.Size(221, 29);
            this.cbxUseParametarization.TabIndex = 10;
            this.cbxUseParametarization.Text = "パラメタリゼーションの使用";
            this.cbxUseParametarization.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(571, 114);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(209, 25);
            this.label27.TabIndex = 20;
            this.label27.Text = "データローダのCPUスレッド数";
            // 
            // cbxDontSaveMetadata
            // 
            this.cbxDontSaveMetadata.AutoSize = true;
            this.cbxDontSaveMetadata.Location = new System.Drawing.Point(344, 112);
            this.cbxDontSaveMetadata.Name = "cbxDontSaveMetadata";
            this.cbxDontSaveMetadata.Size = new System.Drawing.Size(198, 29);
            this.cbxDontSaveMetadata.TabIndex = 11;
            this.cbxDontSaveMetadata.Text = "メタデータを保存しない";
            this.cbxDontSaveMetadata.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(599, 73);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(181, 25);
            this.label28.TabIndex = 21;
            this.label28.Text = "LRスケジューラのサイクル";
            // 
            // cbxCropRandomly
            // 
            this.cbxCropRandomly.AutoSize = true;
            this.cbxCropRandomly.Location = new System.Drawing.Point(344, 77);
            this.cbxCropRandomly.Name = "cbxCropRandomly";
            this.cbxCropRandomly.Size = new System.Drawing.Size(206, 29);
            this.cbxCropRandomly.TabIndex = 9;
            this.cbxCropRandomly.Text = "画像をランダムにクロップ";
            this.cbxCropRandomly.UseVisualStyleBackColor = true;
            // 
            // nudMaxTokens
            // 
            this.nudMaxTokens.Increment = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudMaxTokens.Location = new System.Drawing.Point(786, 149);
            this.nudMaxTokens.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.nudMaxTokens.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudMaxTokens.Name = "nudMaxTokens";
            this.nudMaxTokens.Size = new System.Drawing.Size(120, 31);
            this.nudMaxTokens.TabIndex = 17;
            this.nudMaxTokens.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // cbxFlipAug
            // 
            this.cbxFlipAug.AutoSize = true;
            this.cbxFlipAug.Location = new System.Drawing.Point(344, 42);
            this.cbxFlipAug.Name = "cbxFlipAug";
            this.cbxFlipAug.Size = new System.Drawing.Size(160, 29);
            this.cbxFlipAug.TabIndex = 8;
            this.cbxFlipAug.Text = "反転画像を使用";
            this.cbxFlipAug.UseVisualStyleBackColor = true;
            // 
            // nudDataLoaderThreads
            // 
            this.nudDataLoaderThreads.Location = new System.Drawing.Point(786, 112);
            this.nudDataLoaderThreads.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudDataLoaderThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDataLoaderThreads.Name = "nudDataLoaderThreads";
            this.nudDataLoaderThreads.Size = new System.Drawing.Size(120, 31);
            this.nudDataLoaderThreads.TabIndex = 18;
            this.nudDataLoaderThreads.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cbxMixedPrecision
            // 
            this.cbxMixedPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMixedPrecision.FormattingEnabled = true;
            this.cbxMixedPrecision.Items.AddRange(new object[] {
            "なし",
            "fp16",
            "bf16"});
            this.cbxMixedPrecision.Location = new System.Drawing.Point(786, 32);
            this.cbxMixedPrecision.Name = "cbxMixedPrecision";
            this.cbxMixedPrecision.Size = new System.Drawing.Size(120, 33);
            this.cbxMixedPrecision.TabIndex = 14;
            // 
            // nudLRSchedulerCycle
            // 
            this.nudLRSchedulerCycle.Location = new System.Drawing.Point(786, 71);
            this.nudLRSchedulerCycle.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudLRSchedulerCycle.Name = "nudLRSchedulerCycle";
            this.nudLRSchedulerCycle.Size = new System.Drawing.Size(120, 31);
            this.nudLRSchedulerCycle.TabIndex = 16;
            this.nudLRSchedulerCycle.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(696, 35);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 25);
            this.label29.TabIndex = 15;
            this.label29.Text = "混合精度";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cbxNoProx);
            this.tabPage5.Controls.Add(this.cbxDecouple);
            this.tabPage5.Controls.Add(this.tbxMomentum);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.tbxWeightDecay);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.tbxBetas0);
            this.tabPage5.Controls.Add(this.label32);
            this.tabPage5.Controls.Add(this.tbxBetas1);
            this.tabPage5.Controls.Add(this.label33);
            this.tabPage5.Controls.Add(this.tbxBetas2);
            this.tabPage5.Controls.Add(this.label34);
            this.tabPage5.Controls.Add(this.tbxEps);
            this.tabPage5.Controls.Add(this.label35);
            this.tabPage5.Controls.Add(this.tbxD0);
            this.tabPage5.Controls.Add(this.tbxGrowthRate);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1072, 393);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "DAdaption";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbxNoProx
            // 
            this.cbxNoProx.AutoSize = true;
            this.cbxNoProx.Location = new System.Drawing.Point(79, 263);
            this.cbxNoProx.Name = "cbxNoProx";
            this.cbxNoProx.Size = new System.Drawing.Size(201, 29);
            this.cbxNoProx.TabIndex = 24;
            this.cbxNoProx.Text = "no prox(Adan系のみ)";
            this.cbxNoProx.UseVisualStyleBackColor = true;
            // 
            // cbxDecouple
            // 
            this.cbxDecouple.AutoSize = true;
            this.cbxDecouple.Location = new System.Drawing.Point(79, 228);
            this.cbxDecouple.Name = "cbxDecouple";
            this.cbxDecouple.Size = new System.Drawing.Size(286, 29);
            this.cbxDecouple.TabIndex = 24;
            this.cbxDecouple.Text = "decoupleを有効化(Adam系のみ)";
            this.cbxDecouple.UseVisualStyleBackColor = true;
            // 
            // tbxMomentum
            // 
            this.tbxMomentum.Location = new System.Drawing.Point(401, 79);
            this.tbxMomentum.Name = "tbxMomentum";
            this.tbxMomentum.Size = new System.Drawing.Size(94, 31);
            this.tbxMomentum.TabIndex = 10;
            this.tbxMomentum.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(289, 82);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(106, 25);
            this.label30.TabIndex = 18;
            this.label30.Text = "momentum";
            // 
            // tbxWeightDecay
            // 
            this.tbxWeightDecay.Location = new System.Drawing.Point(158, 42);
            this.tbxWeightDecay.Name = "tbxWeightDecay";
            this.tbxWeightDecay.Size = new System.Drawing.Size(100, 31);
            this.tbxWeightDecay.TabIndex = 11;
            this.tbxWeightDecay.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(45, 160);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(106, 50);
            this.label31.TabIndex = 19;
            this.label31.Text = "growth_rate\r\n0で無制限";
            // 
            // tbxBetas0
            // 
            this.tbxBetas0.Location = new System.Drawing.Point(401, 36);
            this.tbxBetas0.Name = "tbxBetas0";
            this.tbxBetas0.Size = new System.Drawing.Size(73, 31);
            this.tbxBetas0.TabIndex = 12;
            this.tbxBetas0.Text = "0.9";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(111, 119);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(33, 25);
            this.label32.TabIndex = 20;
            this.label32.Text = "d0";
            // 
            // tbxBetas1
            // 
            this.tbxBetas1.Location = new System.Drawing.Point(489, 36);
            this.tbxBetas1.Name = "tbxBetas1";
            this.tbxBetas1.Size = new System.Drawing.Size(77, 31);
            this.tbxBetas1.TabIndex = 13;
            this.tbxBetas1.Text = "0.999";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(111, 82);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(40, 25);
            this.label33.TabIndex = 21;
            this.label33.Text = "eps";
            // 
            // tbxBetas2
            // 
            this.tbxBetas2.Location = new System.Drawing.Point(584, 36);
            this.tbxBetas2.Name = "tbxBetas2";
            this.tbxBetas2.Size = new System.Drawing.Size(77, 31);
            this.tbxBetas2.TabIndex = 14;
            this.tbxBetas2.Text = "0.999";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(340, 39);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(55, 25);
            this.label34.TabIndex = 22;
            this.label34.Text = "betas";
            // 
            // tbxEps
            // 
            this.tbxEps.Location = new System.Drawing.Point(158, 79);
            this.tbxEps.Name = "tbxEps";
            this.tbxEps.Size = new System.Drawing.Size(100, 31);
            this.tbxEps.TabIndex = 15;
            this.tbxEps.Text = "1E-06";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(33, 42);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(118, 25);
            this.label35.TabIndex = 23;
            this.label35.Text = "weight_decay";
            // 
            // tbxD0
            // 
            this.tbxD0.Location = new System.Drawing.Point(158, 116);
            this.tbxD0.Name = "tbxD0";
            this.tbxD0.Size = new System.Drawing.Size(100, 31);
            this.tbxD0.TabIndex = 16;
            this.tbxD0.Text = "1E-06";
            // 
            // tbxGrowthRate
            // 
            this.tbxGrowthRate.Location = new System.Drawing.Point(158, 157);
            this.tbxGrowthRate.Name = "tbxGrowthRate";
            this.tbxGrowthRate.Size = new System.Drawing.Size(100, 31);
            this.tbxGrowthRate.TabIndex = 17;
            this.tbxGrowthRate.Text = "0";
            // 
            // pageConv
            // 
            this.pageConv.Controls.Add(this.label22);
            this.pageConv.Controls.Add(this.nudDyLoRAUnit);
            this.pageConv.Controls.Add(this.cbxUseConv2d);
            this.pageConv.Controls.Add(this.nudConvAlpha);
            this.pageConv.Controls.Add(this.nudConvDim);
            this.pageConv.Controls.Add(this.label23);
            this.pageConv.Controls.Add(this.label24);
            this.pageConv.Controls.Add(this.label25);
            this.pageConv.Controls.Add(this.cbxAlgoType);
            this.pageConv.Location = new System.Drawing.Point(4, 34);
            this.pageConv.Name = "pageConv";
            this.pageConv.Size = new System.Drawing.Size(1072, 393);
            this.pageConv.TabIndex = 3;
            this.pageConv.Text = "Conv関連";
            this.pageConv.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(480, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 25);
            this.label22.TabIndex = 22;
            this.label22.Text = "DyLoRAのunit";
            // 
            // nudDyLoRAUnit
            // 
            this.nudDyLoRAUnit.Location = new System.Drawing.Point(607, 100);
            this.nudDyLoRAUnit.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudDyLoRAUnit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDyLoRAUnit.Name = "nudDyLoRAUnit";
            this.nudDyLoRAUnit.Size = new System.Drawing.Size(120, 31);
            this.nudDyLoRAUnit.TabIndex = 21;
            this.nudDyLoRAUnit.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cbxUseConv2d
            // 
            this.cbxUseConv2d.AutoSize = true;
            this.cbxUseConv2d.Location = new System.Drawing.Point(209, 162);
            this.cbxUseConv2d.Name = "cbxUseConv2d";
            this.cbxUseConv2d.Size = new System.Drawing.Size(242, 29);
            this.cbxUseConv2d.TabIndex = 20;
            this.cbxUseConv2d.Text = "LoRAでConv2d拡張を使用";
            this.cbxUseConv2d.UseVisualStyleBackColor = true;
            // 
            // nudConvAlpha
            // 
            this.nudConvAlpha.DecimalPlaces = 2;
            this.nudConvAlpha.Location = new System.Drawing.Point(607, 42);
            this.nudConvAlpha.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudConvAlpha.Name = "nudConvAlpha";
            this.nudConvAlpha.Size = new System.Drawing.Size(120, 31);
            this.nudConvAlpha.TabIndex = 19;
            this.nudConvAlpha.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // nudConvDim
            // 
            this.nudConvDim.Location = new System.Drawing.Point(331, 40);
            this.nudConvDim.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudConvDim.Name = "nudConvDim";
            this.nudConvDim.Size = new System.Drawing.Size(120, 31);
            this.nudConvDim.TabIndex = 18;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(139, 100);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(176, 25);
            this.label23.TabIndex = 17;
            this.label23.Text = "LyCORISのアルゴリズム";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(496, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(104, 50);
            this.label24.TabIndex = 16;
            this.label24.Text = "Conv Alpha\r\n0で無効";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(224, 40);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 50);
            this.label25.TabIndex = 15;
            this.label25.Text = "Conv Dim\r\n0で無効";
            // 
            // cbxAlgoType
            // 
            this.cbxAlgoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlgoType.FormattingEnabled = true;
            this.cbxAlgoType.Items.AddRange(new object[] {
            "lora",
            "loha",
            "ia3",
            "lokr"});
            this.cbxAlgoType.Location = new System.Drawing.Point(330, 97);
            this.cbxAlgoType.Name = "cbxAlgoType";
            this.cbxAlgoType.Size = new System.Drawing.Size(121, 33);
            this.cbxAlgoType.TabIndex = 14;
            // 
            // pageMisc
            // 
            this.pageMisc.Controls.Add(this.label8);
            this.pageMisc.Controls.Add(this.nudSeed);
            this.pageMisc.Controls.Add(this.cbxPrecision);
            this.pageMisc.Controls.Add(this.tbxExtension);
            this.pageMisc.Controls.Add(this.label9);
            this.pageMisc.Controls.Add(this.label7);
            this.pageMisc.Controls.Add(this.label11);
            this.pageMisc.Controls.Add(this.label6);
            this.pageMisc.Controls.Add(this.nudClipSkip);
            this.pageMisc.Location = new System.Drawing.Point(4, 34);
            this.pageMisc.Name = "pageMisc";
            this.pageMisc.Size = new System.Drawing.Size(1072, 393);
            this.pageMisc.TabIndex = 2;
            this.pageMisc.Text = "その他";
            this.pageMisc.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(40, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 30);
            this.label8.TabIndex = 31;
            this.label8.Text = "通常編集する必要のない設定";
            // 
            // FormAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 530);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDiscardAndClose);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdvanced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "詳細設定";
            this.Load += new System.EventHandler(this.Form_Advanced_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbrCpuThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinBucketReso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxBucketReso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClipSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoiseOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMomentum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdaptiveNoiseScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSNRGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiresNoiseIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiresNoiseDiscount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxNormReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModuleDropout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRankDropout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataLoaderThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLRSchedulerCycle)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.pageConv.ResumeLayout(false);
            this.pageConv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDyLoRAUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvDim)).EndInit();
            this.pageMisc.ResumeLayout(false);
            this.pageMisc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUnetLR;
        private System.Windows.Forms.TextBox tbxTextEncoLR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMinBucketReso;
        private System.Windows.Forms.Label lblMaxBucketReso;
        private System.Windows.Forms.CheckBox cbxNoUpscale;
        private System.Windows.Forms.TrackBar tbrCpuThreads;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCpuThreadsCounter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxUseWarmupInit;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox tbxExtension;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.NumericUpDown nudMinBucketReso;
        private System.Windows.Forms.NumericUpDown nudMaxBucketReso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxScheduler;
        private System.Windows.Forms.NumericUpDown nudClipSkip;
        private System.Windows.Forms.ComboBox cbxPrecision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDiscardAndClose;
        private System.Windows.Forms.Button btnTensorBoardPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTBoardPath;
        private System.Windows.Forms.Button btnClearTBoardPath;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ComboBox cbxAdvancedTrain;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ComboBox cbxCrossAttenType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.CheckBox cbxUseGradient;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectLoRAmodel;
        private System.Windows.Forms.Button btnClearLoRAmodel;
        private System.Windows.Forms.Label lblLoRAmodelPath;
        private System.Windows.Forms.NumericUpDown nudNoiseOffset;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudMomentum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSelectVAE;
        private System.Windows.Forms.Button btnClearVAE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblVAEPath;
        private System.Windows.Forms.CheckBox cbxUseWeightedCaption;
        private System.Windows.Forms.NumericUpDown nudAdaptiveNoiseScale;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudMinSNRGamma;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nudMultiresNoiseIterations;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nudMultiresNoiseDiscount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage pageMisc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage pageConv;
        private System.Windows.Forms.Label lblConfigPath;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnClearConfigPath;
        private System.Windows.Forms.Button btnSelectConfigPath;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown nudDyLoRAUnit;
        private System.Windows.Forms.CheckBox cbxUseConv2d;
        private System.Windows.Forms.NumericUpDown nudConvAlpha;
        private System.Windows.Forms.NumericUpDown nudConvDim;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbxAlgoType;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox cbxUseColorAug;
        private System.Windows.Forms.CheckBox cbxCacheLatentsToDisk;
        private System.Windows.Forms.CheckBox cbxUseFastLoading;
        private System.Windows.Forms.CheckBox cbxCacheLatents;
        private System.Windows.Forms.CheckBox cbxUseV2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox cbxUseParametarization;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox cbxDontSaveMetadata;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox cbxCropRandomly;
        private System.Windows.Forms.NumericUpDown nudMaxTokens;
        private System.Windows.Forms.CheckBox cbxFlipAug;
        private System.Windows.Forms.NumericUpDown nudDataLoaderThreads;
        private System.Windows.Forms.ComboBox cbxMixedPrecision;
        private System.Windows.Forms.NumericUpDown nudLRSchedulerCycle;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbxMomentum;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbxWeightDecay;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbxBetas0;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbxBetas1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbxBetas2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbxEps;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tbxD0;
        private System.Windows.Forms.TextBox tbxGrowthRate;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown nudModuleDropout;
        private System.Windows.Forms.NumericUpDown nudRankDropout;
        private System.Windows.Forms.NumericUpDown nudDropout;
        private System.Windows.Forms.CheckBox cbxScaleVPredLoss;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown nudMaxNormReg;
        private System.Windows.Forms.CheckBox cbxDecouple;
        private System.Windows.Forms.CheckBox cbxNoProx;
    }
}
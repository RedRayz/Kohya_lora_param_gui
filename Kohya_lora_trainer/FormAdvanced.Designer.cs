
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
            components = new System.ComponentModel.Container();
            tbxUnetLR = new TextBox();
            tbxTextEncoLR = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblMinBucketReso = new Label();
            lblMaxBucketReso = new Label();
            cbxNoUpscale = new CheckBox();
            tbrCpuThreads = new TrackBar();
            label5 = new Label();
            lblCpuThreadsCounter = new Label();
            label7 = new Label();
            toolTip1 = new ToolTip(components);
            cbxPrecision = new ComboBox();
            cbxCrossAttenType = new ComboBox();
            cbxUseColorAug = new CheckBox();
            cbxCacheLatents = new CheckBox();
            cbxMixedPrecision = new ComboBox();
            nudLRSchedulerCycle = new NumericUpDown();
            cbxAlgoType = new ComboBox();
            cbxUseWarmupInit = new CheckBox();
            cbxUseGradient = new CheckBox();
            nudNoiseOffset = new NumericUpDown();
            nudCaptionDropout = new NumericUpDown();
            cbxDontSaveMetadata = new CheckBox();
            nudDataLoaderThreads = new NumericUpDown();
            tbxExtension = new TextBox();
            nudClipSkip = new NumericUpDown();
            cbxUseWeightedCaption = new CheckBox();
            cbxCacheTextEncoder = new CheckBox();
            nudSeed = new NumericUpDown();
            nudMaxTokens = new NumericUpDown();
            cbxUseConv2d = new CheckBox();
            nudConvDim = new NumericUpDown();
            cbxCacheLatentsToDisk = new CheckBox();
            cbxCropRandomly = new CheckBox();
            cbxNoHalfVae = new CheckBox();
            cbxFlipAug = new CheckBox();
            cbxUseFullFp16 = new CheckBox();
            cbxUseFP8 = new CheckBox();
            cbxUseFastLoading = new CheckBox();
            cbxScheduler = new ComboBox();
            nudMinSNRGamma = new NumericUpDown();
            cbxWeightDecomposition = new CheckBox();
            cbxHighVRAM = new CheckBox();
            label28 = new Label();
            nudGradAccSteps = new NumericUpDown();
            nudLoRAPlusLRRatio = new NumericUpDown();
            nudLoRAPlusUnetLRRatio = new NumericUpDown();
            nudLoRAPlusTELRRatio = new NumericUpDown();
            tbxWeightDecay = new TextBox();
            cbxAdvancedTrain = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            button1 = new Button();
            nudMinBucketReso = new NumericUpDown();
            nudMaxBucketReso = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            btnDiscardAndClose = new Button();
            btnTensorBoardPath = new Button();
            label12 = new Label();
            lblTBoardPath = new Label();
            btnClearTBoardPath = new Button();
            label13 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnSelectLoRAmodel = new Button();
            btnClearLoRAmodel = new Button();
            lblLoRAmodelPath = new Label();
            label14 = new Label();
            nudMomentum = new NumericUpDown();
            label15 = new Label();
            btnSelectVAE = new Button();
            btnClearVAE = new Button();
            label16 = new Label();
            lblVAEPath = new Label();
            nudAdaptiveNoiseScale = new NumericUpDown();
            label17 = new Label();
            label18 = new Label();
            nudMultiresNoiseIterations = new NumericUpDown();
            label19 = new Label();
            nudMultiresNoiseDiscount = new NumericUpDown();
            label20 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label22 = new Label();
            label45 = new Label();
            nudDyLoRAUnit = new NumericUpDown();
            nudConvAlpha = new NumericUpDown();
            label25 = new Label();
            label24 = new Label();
            tabPage4 = new TabPage();
            cbxMaskLoss = new CheckBox();
            tbxTokensSeparator = new TextBox();
            label46 = new Label();
            label39 = new Label();
            cbxScaleParameter = new CheckBox();
            cbxRelativeStep = new CheckBox();
            label44 = new Label();
            label38 = new Label();
            label37 = new Label();
            label36 = new Label();
            nudMaxNormReg = new NumericUpDown();
            nudNetworkDropout = new NumericUpDown();
            nudModuleDropout = new NumericUpDown();
            nudRankDropout = new NumericUpDown();
            label26 = new Label();
            page3 = new TabPage();
            label55 = new Label();
            label54 = new Label();
            label53 = new Label();
            label52 = new Label();
            nudHuberC = new NumericUpDown();
            label50 = new Label();
            cbxHuberSchedule = new ComboBox();
            label49 = new Label();
            cbxLossType = new ComboBox();
            label48 = new Label();
            tabPage7 = new TabPage();
            label51 = new Label();
            label29 = new Label();
            label27 = new Label();
            tabPage5 = new TabPage();
            btnShowTipsAboutOpts = new Button();
            cbxUseAdditionalOptArgs = new CheckBox();
            label43 = new Label();
            label42 = new Label();
            cbxUseSafeguard = new CheckBox();
            cbxUseBiasCorrection = new CheckBox();
            cbxNoProx = new CheckBox();
            cbxDecouple = new CheckBox();
            tbxMomentum = new TextBox();
            label30 = new Label();
            label31 = new Label();
            tbxBetas0 = new TextBox();
            label32 = new Label();
            tbxBetas1 = new TextBox();
            label33 = new Label();
            tbxDCoef = new TextBox();
            tbxProdigyBeta3 = new TextBox();
            tbxBetas2 = new TextBox();
            label34 = new Label();
            tbxEps = new TextBox();
            label35 = new Label();
            tbxD0 = new TextBox();
            tbxGrowthRate = new TextBox();
            tabPage2 = new TabPage();
            lblConfigPath = new Label();
            label21 = new Label();
            btnClearConfigPath = new Button();
            btnSelectConfigPath = new Button();
            pageMisc = new TabPage();
            label41 = new Label();
            cbxSaveState = new CheckBox();
            label40 = new Label();
            tbxComment = new TextBox();
            label8 = new Label();
            tabPage6 = new TabPage();
            pageXL = new TabPage();
            cbxCacheTextencoderToDisk = new CheckBox();
            tabPage3 = new TabPage();
            label47 = new Label();
            cbxUseTucker = new CheckBox();
            cbxConstrainedOFT = new CheckBox();
            cbxUseScalar = new CheckBox();
            cbxRescaledOFT = new CheckBox();
            cbxTrainNorm = new CheckBox();
            label23 = new Label();
            label56 = new Label();
            cbxRandomNoiseOffset = new CheckBox();
            cbxRandomIpNoiseGamma = new CheckBox();
            nudIpNoiseGamma = new NumericUpDown();
            label57 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbrCpuThreads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLRSchedulerCycle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNoiseOffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCaptionDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDataLoaderThreads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClipSkip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxTokens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudConvDim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinSNRGamma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGradAccSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLoRAPlusLRRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLoRAPlusUnetLRRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLoRAPlusTELRRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBucketReso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBucketReso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMomentum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdaptiveNoiseScale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseIterations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseDiscount).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDyLoRAUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudConvAlpha).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxNormReg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNetworkDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudModuleDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRankDropout).BeginInit();
            page3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHuberC).BeginInit();
            tabPage7.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage2.SuspendLayout();
            pageMisc.SuspendLayout();
            tabPage6.SuspendLayout();
            pageXL.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIpNoiseGamma).BeginInit();
            SuspendLayout();
            // 
            // tbxUnetLR
            // 
            tbxUnetLR.Location = new Point(129, 45);
            tbxUnetLR.Margin = new Padding(3, 4, 3, 4);
            tbxUnetLR.Name = "tbxUnetLR";
            tbxUnetLR.Size = new Size(100, 23);
            tbxUnetLR.TabIndex = 0;
            toolTip1.SetToolTip(tbxUnetLR, "一部のDADaptation系では使用不可");
            tbxUnetLR.TextChanged += tbxUnetLR_TextChanged;
            // 
            // tbxTextEncoLR
            // 
            tbxTextEncoLR.Location = new Point(369, 45);
            tbxTextEncoLR.Margin = new Padding(3, 4, 3, 4);
            tbxTextEncoLR.Name = "tbxTextEncoLR";
            tbxTextEncoLR.Size = new Size(100, 23);
            tbxTextEncoLR.TabIndex = 1;
            toolTip1.SetToolTip(tbxTextEncoLR, "一部のDADaptation系では使用不可");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 48);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "UNet LR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 48);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Text encoder LR";
            // 
            // lblMinBucketReso
            // 
            lblMinBucketReso.AutoSize = true;
            lblMinBucketReso.Location = new Point(21, 78);
            lblMinBucketReso.Name = "lblMinBucketReso";
            lblMinBucketReso.Size = new Size(102, 15);
            lblMinBucketReso.TabIndex = 4;
            lblMinBucketReso.Text = "最小バケット解像度";
            // 
            // lblMaxBucketReso
            // 
            lblMaxBucketReso.AutoSize = true;
            lblMaxBucketReso.Location = new Point(261, 78);
            lblMaxBucketReso.Name = "lblMaxBucketReso";
            lblMaxBucketReso.Size = new Size(102, 15);
            lblMaxBucketReso.TabIndex = 7;
            lblMaxBucketReso.Text = "最大バケット解像度";
            // 
            // cbxNoUpscale
            // 
            cbxNoUpscale.AutoSize = true;
            cbxNoUpscale.Location = new Point(61, 211);
            cbxNoUpscale.Name = "cbxNoUpscale";
            cbxNoUpscale.Size = new Size(186, 19);
            cbxNoUpscale.TabIndex = 8;
            cbxNoUpscale.Text = "バケットのアップスケーリングをしない";
            toolTip1.SetToolTip(cbxNoUpscale, "バケットの解像度は自動設定になる");
            cbxNoUpscale.UseVisualStyleBackColor = true;
            // 
            // tbrCpuThreads
            // 
            tbrCpuThreads.BackColor = Color.WhiteSmoke;
            tbrCpuThreads.Location = new Point(103, 17);
            tbrCpuThreads.Maximum = 32;
            tbrCpuThreads.Minimum = 1;
            tbrCpuThreads.Name = "tbrCpuThreads";
            tbrCpuThreads.Size = new Size(343, 45);
            tbrCpuThreads.TabIndex = 9;
            toolTip1.SetToolTip(tbrCpuThreads, "ほとんどの処理がシングルスレッドで動くため上げても速くならない\r\nメインメモリ使用量増加");
            tbrCpuThreads.Value = 12;
            tbrCpuThreads.Scroll += tbrCpuThreads_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 17);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 10;
            label5.Text = "CPUスレッド数*";
            // 
            // lblCpuThreadsCounter
            // 
            lblCpuThreadsCounter.AutoSize = true;
            lblCpuThreadsCounter.Location = new Point(452, 17);
            lblCpuThreadsCounter.Name = "lblCpuThreadsCounter";
            lblCpuThreadsCounter.Size = new Size(19, 15);
            lblCpuThreadsCounter.TabIndex = 11;
            lblCpuThreadsCounter.Text = "12";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 144);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 13;
            label7.Text = "Clip Skip";
            // 
            // cbxPrecision
            // 
            cbxPrecision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPrecision.FormattingEnabled = true;
            cbxPrecision.Items.AddRange(new object[] { "fp16", "bf16", "float" });
            cbxPrecision.Location = new Point(371, 180);
            cbxPrecision.Name = "cbxPrecision";
            cbxPrecision.Size = new Size(79, 23);
            cbxPrecision.TabIndex = 29;
            toolTip1.SetToolTip(cbxPrecision, "fp16にするとファイルサイズ半減\r\nbf16は互換性の観点から非推奨");
            // 
            // cbxCrossAttenType
            // 
            cbxCrossAttenType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCrossAttenType.FormattingEnabled = true;
            cbxCrossAttenType.Items.AddRange(new object[] { "xformers", "mem_eff_attn", "sdpa" });
            cbxCrossAttenType.Location = new Point(160, 101);
            cbxCrossAttenType.Name = "cbxCrossAttenType";
            cbxCrossAttenType.Size = new Size(135, 23);
            cbxCrossAttenType.TabIndex = 38;
            toolTip1.SetToolTip(cbxCrossAttenType, "最適化アルゴリズムの種類\r\nmef_eff_attenは省メモリだが遅い\r\nxformersは高速だがNVIDIAのみ対応\r\nsdpaは高速だがtorchのエラーで動かないかも(原因不明)");
            // 
            // cbxUseColorAug
            // 
            cbxUseColorAug.AutoSize = true;
            cbxUseColorAug.Location = new Point(283, 211);
            cbxUseColorAug.Name = "cbxUseColorAug";
            cbxUseColorAug.Size = new Size(147, 19);
            cbxUseColorAug.TabIndex = 7;
            cbxUseColorAug.Text = "画像の色をランダムに調整";
            toolTip1.SetToolTip(cbxUseColorAug, "毎回ランダムに画像の色を変える\r\nlatentのキャッシュとの併用は不可");
            cbxUseColorAug.UseVisualStyleBackColor = true;
            // 
            // cbxCacheLatents
            // 
            cbxCacheLatents.AutoSize = true;
            cbxCacheLatents.Location = new Point(45, 137);
            cbxCacheLatents.Name = "cbxCacheLatents";
            cbxCacheLatents.Size = new Size(109, 19);
            cbxCacheLatents.TabIndex = 22;
            cbxCacheLatents.Text = "latentのキャッシュ";
            toolTip1.SetToolTip(cbxCacheLatents, "VRAM消費削減および速度改善\r\n画像反転以外のaugmentationは利用不可\r\nあらかじめ画像をVAEでlatentに変換しておくことで高速化するもの");
            cbxCacheLatents.UseVisualStyleBackColor = true;
            // 
            // cbxMixedPrecision
            // 
            cbxMixedPrecision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMixedPrecision.FormattingEnabled = true;
            cbxMixedPrecision.Items.AddRange(new object[] { "なし", "fp16", "bf16" });
            cbxMixedPrecision.Location = new Point(381, 101);
            cbxMixedPrecision.Name = "cbxMixedPrecision";
            cbxMixedPrecision.Size = new Size(74, 23);
            cbxMixedPrecision.TabIndex = 14;
            toolTip1.SetToolTip(cbxMixedPrecision, "bf16はNVIDIA Ampere世代以降のみ対応");
            // 
            // nudLRSchedulerCycle
            // 
            nudLRSchedulerCycle.DecimalPlaces = 1;
            nudLRSchedulerCycle.Location = new Point(413, 13);
            nudLRSchedulerCycle.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            nudLRSchedulerCycle.Name = "nudLRSchedulerCycle";
            nudLRSchedulerCycle.Size = new Size(78, 23);
            nudLRSchedulerCycle.TabIndex = 16;
            toolTip1.SetToolTip(nudLRSchedulerCycle, "一度の学習のLR調整の回数\r\ncosine_with_restartsの場合はコサイン波の数(整数のみ)\r\npolynomialの場合は減衰の乗数");
            nudLRSchedulerCycle.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // cbxAlgoType
            // 
            cbxAlgoType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAlgoType.FormattingEnabled = true;
            cbxAlgoType.Items.AddRange(new object[] { "lora", "loha", "ia3", "lokr", "full", "glora", "diag-oft", "boft" });
            cbxAlgoType.Location = new Point(146, 46);
            cbxAlgoType.Name = "cbxAlgoType";
            cbxAlgoType.Size = new Size(121, 23);
            cbxAlgoType.TabIndex = 14;
            toolTip1.SetToolTip(cbxAlgoType, "loha、lokrやia3の実質的なdimは2乗になる");
            // 
            // cbxUseWarmupInit
            // 
            cbxUseWarmupInit.AutoSize = true;
            cbxUseWarmupInit.Location = new Point(24, 17);
            cbxUseWarmupInit.Name = "cbxUseWarmupInit";
            cbxUseWarmupInit.Size = new Size(202, 19);
            cbxUseWarmupInit.TabIndex = 18;
            cbxUseWarmupInit.Text = "AdaFactor: warmup_initを使用する";
            toolTip1.SetToolTip(cbxUseWarmupInit, "必要なステップ数がだいたい1万以上になる");
            cbxUseWarmupInit.UseVisualStyleBackColor = true;
            // 
            // cbxUseGradient
            // 
            cbxUseGradient.AutoSize = true;
            cbxUseGradient.Location = new Point(45, 212);
            cbxUseGradient.Name = "cbxUseGradient";
            cbxUseGradient.Size = new Size(203, 19);
            cbxUseGradient.TabIndex = 18;
            cbxUseGradient.Text = "gradient_checkpointingを使用する";
            toolTip1.SetToolTip(cbxUseGradient, "VRAM消費削減および増加を強く抑制\r\n速度がやや低下する");
            cbxUseGradient.UseVisualStyleBackColor = true;
            // 
            // nudNoiseOffset
            // 
            nudNoiseOffset.DecimalPlaces = 4;
            nudNoiseOffset.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudNoiseOffset.Location = new Point(170, 19);
            nudNoiseOffset.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudNoiseOffset.Name = "nudNoiseOffset";
            nudNoiseOffset.Size = new Size(94, 23);
            nudNoiseOffset.TabIndex = 44;
            toolTip1.SetToolTip(nudNoiseOffset, "暗い部分の改善効果があるかも");
            // 
            // nudCaptionDropout
            // 
            nudCaptionDropout.DecimalPlaces = 2;
            nudCaptionDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudCaptionDropout.Location = new Point(413, 82);
            nudCaptionDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCaptionDropout.Name = "nudCaptionDropout";
            nudCaptionDropout.Size = new Size(78, 23);
            nudCaptionDropout.TabIndex = 24;
            toolTip1.SetToolTip(nudCaptionDropout, "一定確率でキャプションを切り落とす");
            // 
            // cbxDontSaveMetadata
            // 
            cbxDontSaveMetadata.AutoSize = true;
            cbxDontSaveMetadata.Location = new Point(85, 70);
            cbxDontSaveMetadata.Name = "cbxDontSaveMetadata";
            cbxDontSaveMetadata.Size = new Size(130, 19);
            cbxDontSaveMetadata.TabIndex = 11;
            cbxDontSaveMetadata.Text = "メタデータを保存しない";
            toolTip1.SetToolTip(cbxDontSaveMetadata, "1111のiボタンで出る学習情報に最小限の情報のみ書き込む\r\nnetwork_dim/alphaやSDバージョンなどのみでデータセット関連は書き込まない");
            cbxDontSaveMetadata.UseVisualStyleBackColor = true;
            // 
            // nudDataLoaderThreads
            // 
            nudDataLoaderThreads.Location = new Point(160, 63);
            nudDataLoaderThreads.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            nudDataLoaderThreads.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDataLoaderThreads.Name = "nudDataLoaderThreads";
            nudDataLoaderThreads.Size = new Size(135, 23);
            nudDataLoaderThreads.TabIndex = 18;
            toolTip1.SetToolTip(nudDataLoaderThreads, "ほとんどの処理がシングルスレッドで動くため上げても速くならない\r\nメインメモリの使用量増加");
            nudDataLoaderThreads.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // tbxExtension
            // 
            tbxExtension.Location = new Point(123, 180);
            tbxExtension.Name = "tbxExtension";
            tbxExtension.Size = new Size(126, 23);
            tbxExtension.TabIndex = 19;
            tbxExtension.Text = ".txt";
            toolTip1.SetToolTip(tbxExtension, "ピリオド込みで入力する");
            // 
            // nudClipSkip
            // 
            nudClipSkip.Location = new Point(123, 142);
            nudClipSkip.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            nudClipSkip.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudClipSkip.Name = "nudClipSkip";
            nudClipSkip.Size = new Size(78, 23);
            nudClipSkip.TabIndex = 28;
            toolTip1.SetToolTip(nudClipSkip, "イラストは2、実写は1が良いとされる\r\nSD1.X/2.X専用でSDXLでは使用されない");
            nudClipSkip.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // cbxUseWeightedCaption
            // 
            cbxUseWeightedCaption.AutoSize = true;
            cbxUseWeightedCaption.Location = new Point(61, 236);
            cbxUseWeightedCaption.Name = "cbxUseWeightedCaption";
            cbxUseWeightedCaption.Size = new Size(161, 19);
            cbxUseWeightedCaption.TabIndex = 48;
            cbxUseWeightedCaption.Text = "キャプションに重みづけを使用";
            toolTip1.SetToolTip(cbxUseWeightedCaption, "キャプションでカッコなどを強調として使用する\r\nAUTOMATIC1111 WebUIと同様の記法");
            cbxUseWeightedCaption.UseVisualStyleBackColor = true;
            // 
            // cbxCacheTextEncoder
            // 
            cbxCacheTextEncoder.AutoSize = true;
            cbxCacheTextEncoder.Location = new Point(18, 44);
            cbxCacheTextEncoder.Name = "cbxCacheTextEncoder";
            cbxCacheTextEncoder.Size = new Size(180, 19);
            cbxCacheTextEncoder.TabIndex = 18;
            cbxCacheTextEncoder.Text = "Text Encoderの出力のキャッシュ";
            toolTip1.SetToolTip(cbxCacheTextEncoder, "キャプション関連のオプションは使用不可");
            cbxCacheTextEncoder.UseVisualStyleBackColor = true;
            // 
            // nudSeed
            // 
            nudSeed.Location = new Point(371, 136);
            nudSeed.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            nudSeed.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            nudSeed.Name = "nudSeed";
            nudSeed.Size = new Size(79, 23);
            nudSeed.TabIndex = 23;
            toolTip1.SetToolTip(nudSeed, "特定のシードが良いとされるが真偽不明");
            nudSeed.Value = new decimal(new int[] { 42, 0, 0, 0 });
            // 
            // nudMaxTokens
            // 
            nudMaxTokens.Increment = new decimal(new int[] { 75, 0, 0, 0 });
            nudMaxTokens.Location = new Point(413, 53);
            nudMaxTokens.Maximum = new decimal(new int[] { 225, 0, 0, 0 });
            nudMaxTokens.Minimum = new decimal(new int[] { 75, 0, 0, 0 });
            nudMaxTokens.Name = "nudMaxTokens";
            nudMaxTokens.Size = new Size(78, 23);
            nudMaxTokens.TabIndex = 17;
            toolTip1.SetToolTip(nudMaxTokens, "コンマ区切りではなくCLIPのトークン数\r\nSDXLでは機能しないかも");
            nudMaxTokens.Value = new decimal(new int[] { 75, 0, 0, 0 });
            // 
            // cbxUseConv2d
            // 
            cbxUseConv2d.AutoSize = true;
            cbxUseConv2d.Location = new Point(61, 186);
            cbxUseConv2d.Name = "cbxUseConv2d";
            cbxUseConv2d.Size = new Size(161, 19);
            cbxUseConv2d.TabIndex = 20;
            cbxUseConv2d.Text = "LoRAでConv2d拡張を使用";
            toolTip1.SetToolTip(cbxUseConv2d, "畳み込み層も学習する\r\nキャラLoRAはオフでよい");
            cbxUseConv2d.UseVisualStyleBackColor = true;
            // 
            // nudConvDim
            // 
            nudConvDim.Location = new Point(128, 104);
            nudConvDim.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudConvDim.Name = "nudConvDim";
            nudConvDim.Size = new Size(101, 23);
            nudConvDim.TabIndex = 18;
            toolTip1.SetToolTip(nudConvDim, "畳み込み層(Attnが無い層)の次元数");
            // 
            // cbxCacheLatentsToDisk
            // 
            cbxCacheLatentsToDisk.AutoSize = true;
            cbxCacheLatentsToDisk.Location = new Point(45, 162);
            cbxCacheLatentsToDisk.Name = "cbxCacheLatentsToDisk";
            cbxCacheLatentsToDisk.Size = new Size(151, 19);
            cbxCacheLatentsToDisk.TabIndex = 23;
            cbxCacheLatentsToDisk.Text = "latentをディスクにキャッシュ";
            toolTip1.SetToolTip(cbxCacheLatentsToDisk, "latentのキャッシュもオンにする必要あり\r\n2回目以降の学習開始が高速化");
            cbxCacheLatentsToDisk.UseVisualStyleBackColor = true;
            // 
            // cbxCropRandomly
            // 
            cbxCropRandomly.AutoSize = true;
            cbxCropRandomly.Location = new Point(283, 236);
            cbxCropRandomly.Name = "cbxCropRandomly";
            cbxCropRandomly.Size = new Size(136, 19);
            cbxCropRandomly.TabIndex = 9;
            cbxCropRandomly.Text = "画像をランダムにクロップ";
            toolTip1.SetToolTip(cbxCropRandomly, "latentキャッシュとの併用不可");
            cbxCropRandomly.UseVisualStyleBackColor = true;
            // 
            // cbxNoHalfVae
            // 
            cbxNoHalfVae.AutoSize = true;
            cbxNoHalfVae.Location = new Point(18, 19);
            cbxNoHalfVae.Name = "cbxNoHalfVae";
            cbxNoHalfVae.Size = new Size(126, 19);
            cbxNoHalfVae.TabIndex = 18;
            cbxNoHalfVae.Text = "VAEを32ビットで使用";
            toolTip1.SetToolTip(cbxNoHalfVae, "no-half VAE\r\nVAEのNaN演算をなくす\r\nStabilityAIのVAEはこの設定が必須");
            cbxNoHalfVae.UseVisualStyleBackColor = true;
            // 
            // cbxFlipAug
            // 
            cbxFlipAug.AutoSize = true;
            cbxFlipAug.Location = new Point(283, 186);
            cbxFlipAug.Name = "cbxFlipAug";
            cbxFlipAug.Size = new Size(107, 19);
            cbxFlipAug.TabIndex = 8;
            cbxFlipAug.Text = "反転画像を使用";
            toolTip1.SetToolTip(cbxFlipAug, "反転画像でデータセットを水増し");
            cbxFlipAug.UseVisualStyleBackColor = true;
            // 
            // cbxUseFullFp16
            // 
            cbxUseFullFp16.AutoSize = true;
            cbxUseFullFp16.Location = new Point(320, 162);
            cbxUseFullFp16.Name = "cbxUseFullFp16";
            cbxUseFullFp16.Size = new Size(149, 19);
            cbxUseFullFp16.TabIndex = 41;
            cbxUseFullFp16.Text = "Full FP16を使用(非推奨)";
            toolTip1.SetToolTip(cbxUseFullFp16, "学習能力が低下するため非推奨\r\n特にSDXLでは学習能力を完全に失うほどの悪影響あり");
            cbxUseFullFp16.UseVisualStyleBackColor = true;
            // 
            // cbxUseFP8
            // 
            cbxUseFP8.AutoSize = true;
            cbxUseFP8.Location = new Point(320, 187);
            cbxUseFP8.Name = "cbxUseFP8";
            cbxUseFP8.Size = new Size(135, 19);
            cbxUseFP8.TabIndex = 42;
            cbxUseFP8.Text = "モデルをfp8で読み込む";
            toolTip1.SetToolTip(cbxUseFP8, "若干の速度低下と引き換えにモデルによるVRAM消費が半減する\r\nVRAM10GB以下では使用を推奨");
            cbxUseFP8.UseVisualStyleBackColor = true;
            // 
            // cbxUseFastLoading
            // 
            cbxUseFastLoading.AutoSize = true;
            cbxUseFastLoading.Checked = true;
            cbxUseFastLoading.CheckState = CheckState.Checked;
            cbxUseFastLoading.Location = new Point(320, 137);
            cbxUseFastLoading.Name = "cbxUseFastLoading";
            cbxUseFastLoading.Size = new Size(96, 19);
            cbxUseFastLoading.TabIndex = 12;
            cbxUseFastLoading.Text = "読込の高速化";
            toolTip1.SetToolTip(cbxUseFastLoading, "次のエポックへの移行が速くなる");
            cbxUseFastLoading.UseVisualStyleBackColor = true;
            // 
            // cbxScheduler
            // 
            cbxScheduler.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxScheduler.FormattingEnabled = true;
            cbxScheduler.Items.AddRange(new object[] { "cosine_with_restarts", "cosine", "linear", "polynomial", "constant", "constant_with_warmup" });
            cbxScheduler.Location = new Point(129, 15);
            cbxScheduler.Name = "cbxScheduler";
            cbxScheduler.Size = new Size(140, 23);
            cbxScheduler.TabIndex = 27;
            toolTip1.SetToolTip(cbxScheduler, "LR調整アルゴリズム");
            // 
            // nudMinSNRGamma
            // 
            nudMinSNRGamma.Location = new Point(170, 106);
            nudMinSNRGamma.Name = "nudMinSNRGamma";
            nudMinSNRGamma.Size = new Size(94, 23);
            nudMinSNRGamma.TabIndex = 51;
            toolTip1.SetToolTip(nudMinSNRGamma, "設定するとLoRA重ね掛けしたときに不安定になる？");
            // 
            // cbxWeightDecomposition
            // 
            cbxWeightDecomposition.AutoSize = true;
            cbxWeightDecomposition.Location = new Point(26, 92);
            cbxWeightDecomposition.Name = "cbxWeightDecomposition";
            cbxWeightDecomposition.Size = new Size(185, 19);
            cbxWeightDecomposition.TabIndex = 18;
            cbxWeightDecomposition.Text = "Weight Decomposition(DoRA)";
            toolTip1.SetToolTip(cbxWeightDecomposition, "directionをファインチューンすることでLoRAの安定性と精度問題を改善する\r\n実際には安定性が改善し、より低いランク(dim)で性能を維持しやすい");
            cbxWeightDecomposition.UseVisualStyleBackColor = true;
            // 
            // cbxHighVRAM
            // 
            cbxHighVRAM.AutoSize = true;
            cbxHighVRAM.Location = new Point(45, 187);
            cbxHighVRAM.Name = "cbxHighVRAM";
            cbxHighVRAM.Size = new Size(198, 19);
            cbxHighVRAM.TabIndex = 18;
            cbxHighVRAM.Text = "高VRAM(latentキャッシュの高速化)";
            toolTip1.SetToolTip(cbxHighVRAM, "現時点でlatentのキャッシュのみに影響\r\n高VRAMといっても8GB未満の使用量で済む");
            cbxHighVRAM.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(286, 17);
            label28.Name = "label28";
            label28.Size = new Size(125, 30);
            label28.TabIndex = 21;
            label28.Text = "LRスケジューラのサイクル/\r\npolynomialの減衰";
            toolTip1.SetToolTip(label28, "polynomialの場合はpowerとして使用される");
            // 
            // nudGradAccSteps
            // 
            nudGradAccSteps.Location = new Point(123, 246);
            nudGradAccSteps.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudGradAccSteps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGradAccSteps.Name = "nudGradAccSteps";
            nudGradAccSteps.Size = new Size(96, 23);
            nudGradAccSteps.TabIndex = 8;
            toolTip1.SetToolTip(nudGradAccSteps, "勾配を合計するステップ数\r\nバッチサイズに似た効果がある");
            nudGradAccSteps.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudLoRAPlusLRRatio
            // 
            nudLoRAPlusLRRatio.Location = new Point(139, 143);
            nudLoRAPlusLRRatio.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            nudLoRAPlusLRRatio.Name = "nudLoRAPlusLRRatio";
            nudLoRAPlusLRRatio.Size = new Size(120, 23);
            nudLoRAPlusLRRatio.TabIndex = 8;
            toolTip1.SetToolTip(nudLoRAPlusLRRatio, "適切に設定すると2倍ほど収束が早くなる\r\nこの項目はUnetとTEの両方のratio\r\n");
            // 
            // nudLoRAPlusUnetLRRatio
            // 
            nudLoRAPlusUnetLRRatio.Location = new Point(139, 172);
            nudLoRAPlusUnetLRRatio.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            nudLoRAPlusUnetLRRatio.Name = "nudLoRAPlusUnetLRRatio";
            nudLoRAPlusUnetLRRatio.Size = new Size(120, 23);
            nudLoRAPlusUnetLRRatio.TabIndex = 8;
            toolTip1.SetToolTip(nudLoRAPlusUnetLRRatio, "個別指定時はLoRA+ LR比率を0にすること");
            // 
            // nudLoRAPlusTELRRatio
            // 
            nudLoRAPlusTELRRatio.Location = new Point(139, 201);
            nudLoRAPlusTELRRatio.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            nudLoRAPlusTELRRatio.Name = "nudLoRAPlusTELRRatio";
            nudLoRAPlusTELRRatio.Size = new Size(120, 23);
            nudLoRAPlusTELRRatio.TabIndex = 8;
            toolTip1.SetToolTip(nudLoRAPlusTELRRatio, "個別指定時はLoRA+ LR比率を0にすること");
            // 
            // tbxWeightDecay
            // 
            tbxWeightDecay.Location = new Point(93, 13);
            tbxWeightDecay.Name = "tbxWeightDecay";
            tbxWeightDecay.Size = new Size(64, 23);
            tbxWeightDecay.TabIndex = 11;
            tbxWeightDecay.Text = "0";
            toolTip1.SetToolTip(tbxWeightDecay, "過学習を抑える設定。高くすると学習が遅くなる");
            // 
            // cbxAdvancedTrain
            // 
            cbxAdvancedTrain.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAdvancedTrain.FormattingEnabled = true;
            cbxAdvancedTrain.Items.AddRange(new object[] { "両方学習", "TextEncoderのみ学習", "UNetのみ学習" });
            cbxAdvancedTrain.Location = new Point(369, 15);
            cbxAdvancedTrain.Name = "cbxAdvancedTrain";
            cbxAdvancedTrain.Size = new Size(141, 23);
            cbxAdvancedTrain.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(302, 135);
            label6.Name = "label6";
            label6.Size = new Size(61, 30);
            label6.TabIndex = 16;
            label6.Text = "Seed\r\n-1でランダム";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 183);
            label9.Name = "label9";
            label9.Size = new Size(102, 30);
            label9.TabIndex = 20;
            label9.Text = "キャプションファイルの\r\n拡張子";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(457, 389);
            button1.Name = "button1";
            button1.Size = new Size(171, 31);
            button1.TabIndex = 22;
            button1.Text = "設定を反映して閉じる";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nudMinBucketReso
            // 
            nudMinBucketReso.Increment = new decimal(new int[] { 64, 0, 0, 0 });
            nudMinBucketReso.Location = new Point(129, 75);
            nudMinBucketReso.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudMinBucketReso.Minimum = new decimal(new int[] { 64, 0, 0, 0 });
            nudMinBucketReso.Name = "nudMinBucketReso";
            nudMinBucketReso.Size = new Size(100, 23);
            nudMinBucketReso.TabIndex = 24;
            nudMinBucketReso.Value = new decimal(new int[] { 320, 0, 0, 0 });
            nudMinBucketReso.ValueChanged += nudMinBucketReso_ValueChanged;
            // 
            // nudMaxBucketReso
            // 
            nudMaxBucketReso.Increment = new decimal(new int[] { 64, 0, 0, 0 });
            nudMaxBucketReso.Location = new Point(369, 75);
            nudMaxBucketReso.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            nudMaxBucketReso.Minimum = new decimal(new int[] { 128, 0, 0, 0 });
            nudMaxBucketReso.Name = "nudMaxBucketReso";
            nudMaxBucketReso.Size = new Size(100, 23);
            nudMaxBucketReso.TabIndex = 25;
            nudMaxBucketReso.Value = new decimal(new int[] { 960, 0, 0, 0 });
            nudMaxBucketReso.ValueChanged += nudMaxBucketReso_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(64, 18);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 26;
            label10.Text = "スケジューラ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(286, 183);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 30;
            label11.Text = "保存時の精度";
            // 
            // btnDiscardAndClose
            // 
            btnDiscardAndClose.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiscardAndClose.Location = new Point(286, 389);
            btnDiscardAndClose.Name = "btnDiscardAndClose";
            btnDiscardAndClose.Size = new Size(165, 31);
            btnDiscardAndClose.TabIndex = 31;
            btnDiscardAndClose.Text = "設定を反映せずに閉じる";
            btnDiscardAndClose.UseVisualStyleBackColor = true;
            btnDiscardAndClose.Click += btnDiscardAndClose_Click;
            // 
            // btnTensorBoardPath
            // 
            btnTensorBoardPath.Location = new Point(112, 120);
            btnTensorBoardPath.Name = "btnTensorBoardPath";
            btnTensorBoardPath.Size = new Size(64, 30);
            btnTensorBoardPath.TabIndex = 32;
            btnTensorBoardPath.Text = "選択";
            btnTensorBoardPath.UseVisualStyleBackColor = true;
            btnTensorBoardPath.Click += button2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 120);
            label12.Name = "label12";
            label12.Size = new Size(84, 30);
            label12.TabIndex = 33;
            label12.Text = "Tensorboard用\r\nログ出力先";
            // 
            // lblTBoardPath
            // 
            lblTBoardPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTBoardPath.Location = new Point(27, 166);
            lblTBoardPath.Name = "lblTBoardPath";
            lblTBoardPath.Size = new Size(240, 48);
            lblTBoardPath.TabIndex = 34;
            lblTBoardPath.Text = "D:\\Sample\\Please stop using Super Long Naming\\RegImage\\1_1girl";
            // 
            // btnClearTBoardPath
            // 
            btnClearTBoardPath.Location = new Point(182, 120);
            btnClearTBoardPath.Name = "btnClearTBoardPath";
            btnClearTBoardPath.Size = new Size(64, 30);
            btnClearTBoardPath.TabIndex = 35;
            btnClearTBoardPath.Text = "クリア";
            btnClearTBoardPath.UseVisualStyleBackColor = true;
            btnClearTBoardPath.Click += btnClearTBoardPath_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(278, 18);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 37;
            label13.Text = "UNet/TEの学習";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 104);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 40;
            label4.Text = "クロスアテンションの種類";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 22);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 41;
            label3.Text = "追加学習する\r\nLoRAモデル";
            // 
            // btnSelectLoRAmodel
            // 
            btnSelectLoRAmodel.Location = new Point(112, 22);
            btnSelectLoRAmodel.Name = "btnSelectLoRAmodel";
            btnSelectLoRAmodel.Size = new Size(64, 30);
            btnSelectLoRAmodel.TabIndex = 42;
            btnSelectLoRAmodel.Text = "選択";
            btnSelectLoRAmodel.UseVisualStyleBackColor = true;
            btnSelectLoRAmodel.Click += btnSelectLoRAmodel_Click;
            // 
            // btnClearLoRAmodel
            // 
            btnClearLoRAmodel.Location = new Point(182, 22);
            btnClearLoRAmodel.Name = "btnClearLoRAmodel";
            btnClearLoRAmodel.Size = new Size(64, 30);
            btnClearLoRAmodel.TabIndex = 42;
            btnClearLoRAmodel.Text = "クリア";
            btnClearLoRAmodel.UseVisualStyleBackColor = true;
            btnClearLoRAmodel.Click += btnClearLoRAmodel_Click;
            // 
            // lblLoRAmodelPath
            // 
            lblLoRAmodelPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoRAmodelPath.Location = new Point(27, 58);
            lblLoRAmodelPath.Name = "lblLoRAmodelPath";
            lblLoRAmodelPath.Size = new Size(240, 48);
            lblLoRAmodelPath.TabIndex = 43;
            lblLoRAmodelPath.Text = "C:\\Sample\\SuperLong\\Multibyte\\and\\spaces\\日本語.safetensors";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(81, 21);
            label14.Name = "label14";
            label14.Size = new Size(83, 15);
            label14.TabIndex = 45;
            label14.Text = "ノイズオフセット#";
            // 
            // nudMomentum
            // 
            nudMomentum.DecimalPlaces = 4;
            nudMomentum.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudMomentum.Location = new Point(413, 228);
            nudMomentum.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMomentum.Name = "nudMomentum";
            nudMomentum.Size = new Size(78, 23);
            nudMomentum.TabIndex = 44;
            nudMomentum.Value = new decimal(new int[] { 9, 0, 0, 65536 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(330, 228);
            label15.Name = "label15";
            label15.Size = new Size(75, 30);
            label15.TabIndex = 45;
            label15.Text = "Nesterovの\r\nmomentum#";
            // 
            // btnSelectVAE
            // 
            btnSelectVAE.Location = new Point(344, 22);
            btnSelectVAE.Name = "btnSelectVAE";
            btnSelectVAE.Size = new Size(64, 30);
            btnSelectVAE.TabIndex = 46;
            btnSelectVAE.Text = "選択";
            btnSelectVAE.UseVisualStyleBackColor = true;
            btnSelectVAE.Click += btnSelectVAE_Click;
            // 
            // btnClearVAE
            // 
            btnClearVAE.Location = new Point(414, 22);
            btnClearVAE.Name = "btnClearVAE";
            btnClearVAE.Size = new Size(64, 30);
            btnClearVAE.TabIndex = 46;
            btnClearVAE.Text = "クリア";
            btnClearVAE.UseVisualStyleBackColor = true;
            btnClearVAE.Click += btnClearVAE_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(310, 30);
            label16.Name = "label16";
            label16.Size = new Size(28, 15);
            label16.TabIndex = 47;
            label16.Text = "VAE";
            // 
            // lblVAEPath
            // 
            lblVAEPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblVAEPath.Location = new Point(310, 59);
            lblVAEPath.Name = "lblVAEPath";
            lblVAEPath.Size = new Size(240, 48);
            lblVAEPath.TabIndex = 43;
            lblVAEPath.Text = "C:\\Sample\\SuperLong\\Multibyte\\and\\spaces\\日本語.safetensors";
            // 
            // nudAdaptiveNoiseScale
            // 
            nudAdaptiveNoiseScale.DecimalPlaces = 1;
            nudAdaptiveNoiseScale.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudAdaptiveNoiseScale.Location = new Point(170, 77);
            nudAdaptiveNoiseScale.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudAdaptiveNoiseScale.Name = "nudAdaptiveNoiseScale";
            nudAdaptiveNoiseScale.Size = new Size(94, 23);
            nudAdaptiveNoiseScale.TabIndex = 49;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(64, 79);
            label17.Name = "label17";
            label17.Size = new Size(100, 15);
            label17.TabIndex = 50;
            label17.Text = "適応ノイズスケール#";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(59, 108);
            label18.Name = "label18";
            label18.Size = new Size(105, 15);
            label18.TabIndex = 52;
            label18.Text = "Min-SNR Gamma#";
            // 
            // nudMultiresNoiseIterations
            // 
            nudMultiresNoiseIterations.Location = new Point(170, 135);
            nudMultiresNoiseIterations.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMultiresNoiseIterations.Name = "nudMultiresNoiseIterations";
            nudMultiresNoiseIterations.Size = new Size(94, 23);
            nudMultiresNoiseIterations.TabIndex = 53;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(22, 137);
            label19.Name = "label19";
            label19.Size = new Size(142, 15);
            label19.TabIndex = 54;
            label19.Text = "Multires Noise Iterations#";
            // 
            // nudMultiresNoiseDiscount
            // 
            nudMultiresNoiseDiscount.DecimalPlaces = 2;
            nudMultiresNoiseDiscount.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudMultiresNoiseDiscount.Location = new Point(170, 164);
            nudMultiresNoiseDiscount.Name = "nudMultiresNoiseDiscount";
            nudMultiresNoiseDiscount.Size = new Size(94, 23);
            nudMultiresNoiseDiscount.TabIndex = 55;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(24, 166);
            label20.Name = "label20";
            label20.Size = new Size(140, 15);
            label20.TabIndex = 56;
            label20.Text = "Multires Noise Discount#";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(page3);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(pageMisc);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(pageXL);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(620, 371);
            tabControl1.TabIndex = 57;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(label45);
            tabPage1.Controls.Add(cbxUseConv2d);
            tabPage1.Controls.Add(tbxUnetLR);
            tabPage1.Controls.Add(nudDyLoRAUnit);
            tabPage1.Controls.Add(tbxTextEncoLR);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cbxFlipAug);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(nudConvAlpha);
            tabPage1.Controls.Add(cbxCropRandomly);
            tabPage1.Controls.Add(nudConvDim);
            tabPage1.Controls.Add(lblMinBucketReso);
            tabPage1.Controls.Add(cbxUseColorAug);
            tabPage1.Controls.Add(label25);
            tabPage1.Controls.Add(lblMaxBucketReso);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(cbxNoUpscale);
            tabPage1.Controls.Add(cbxUseWeightedCaption);
            tabPage1.Controls.Add(nudMinBucketReso);
            tabPage1.Controls.Add(nudMaxBucketReso);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(cbxScheduler);
            tabPage1.Controls.Add(cbxAdvancedTrain);
            tabPage1.Controls.Add(label13);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(612, 343);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ページ1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(283, 136);
            label22.Name = "label22";
            label22.Size = new Size(80, 15);
            label22.TabIndex = 22;
            label22.Text = "DyLoRAのunit";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(283, 168);
            label45.Name = "label45";
            label45.Size = new Size(105, 15);
            label45.TabIndex = 27;
            label45.Text = "augmentation関連";
            // 
            // nudDyLoRAUnit
            // 
            nudDyLoRAUnit.Location = new Point(369, 133);
            nudDyLoRAUnit.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudDyLoRAUnit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDyLoRAUnit.Name = "nudDyLoRAUnit";
            nudDyLoRAUnit.Size = new Size(100, 23);
            nudDyLoRAUnit.TabIndex = 21;
            nudDyLoRAUnit.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nudConvAlpha
            // 
            nudConvAlpha.DecimalPlaces = 2;
            nudConvAlpha.Location = new Point(369, 104);
            nudConvAlpha.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudConvAlpha.Name = "nudConvAlpha";
            nudConvAlpha.Size = new Size(100, 23);
            nudConvAlpha.TabIndex = 19;
            nudConvAlpha.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(64, 108);
            label25.Name = "label25";
            label25.Size = new Size(58, 15);
            label25.TabIndex = 15;
            label25.Text = "Conv Dim";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(295, 106);
            label24.Name = "label24";
            label24.Size = new Size(68, 15);
            label24.TabIndex = 16;
            label24.Text = "Conv Alpha";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(cbxMaskLoss);
            tabPage4.Controls.Add(tbxTokensSeparator);
            tabPage4.Controls.Add(label46);
            tabPage4.Controls.Add(label39);
            tabPage4.Controls.Add(cbxScaleParameter);
            tabPage4.Controls.Add(cbxRelativeStep);
            tabPage4.Controls.Add(cbxUseWarmupInit);
            tabPage4.Controls.Add(nudMomentum);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label44);
            tabPage4.Controls.Add(label38);
            tabPage4.Controls.Add(label37);
            tabPage4.Controls.Add(label36);
            tabPage4.Controls.Add(nudMaxNormReg);
            tabPage4.Controls.Add(nudNetworkDropout);
            tabPage4.Controls.Add(nudModuleDropout);
            tabPage4.Controls.Add(nudRankDropout);
            tabPage4.Controls.Add(nudCaptionDropout);
            tabPage4.Controls.Add(label26);
            tabPage4.Controls.Add(label28);
            tabPage4.Controls.Add(nudMaxTokens);
            tabPage4.Controls.Add(nudLRSchedulerCycle);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(612, 341);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "ページ2";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbxMaskLoss
            // 
            cbxMaskLoss.AutoSize = true;
            cbxMaskLoss.Location = new Point(24, 89);
            cbxMaskLoss.Name = "cbxMaskLoss";
            cbxMaskLoss.Size = new Size(113, 19);
            cbxMaskLoss.TabIndex = 7;
            cbxMaskLoss.Text = "Mask Lossを使用";
            cbxMaskLoss.UseVisualStyleBackColor = true;
            // 
            // tbxTokensSeparator
            // 
            tbxTokensSeparator.Location = new Point(24, 164);
            tbxTokensSeparator.Name = "tbxTokensSeparator";
            tbxTokensSeparator.Size = new Size(170, 23);
            tbxTokensSeparator.TabIndex = 47;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(24, 146);
            label46.Name = "label46";
            label46.Size = new Size(97, 15);
            label46.TabIndex = 46;
            label46.Text = "トークンのセパレータ";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(259, 201);
            label39.Name = "label39";
            label39.Size = new Size(148, 15);
            label39.TabIndex = 25;
            label39.Text = "Max Norm Regularization#";
            // 
            // cbxScaleParameter
            // 
            cbxScaleParameter.AutoSize = true;
            cbxScaleParameter.Location = new Point(24, 64);
            cbxScaleParameter.Name = "cbxScaleParameter";
            cbxScaleParameter.Size = new Size(221, 19);
            cbxScaleParameter.TabIndex = 18;
            cbxScaleParameter.Text = "AdaFactor: scale_parameterを使用する";
            cbxScaleParameter.UseVisualStyleBackColor = true;
            // 
            // cbxRelativeStep
            // 
            cbxRelativeStep.AutoSize = true;
            cbxRelativeStep.Location = new Point(24, 42);
            cbxRelativeStep.Name = "cbxRelativeStep";
            cbxRelativeStep.Size = new Size(202, 19);
            cbxRelativeStep.TabIndex = 18;
            cbxRelativeStep.Text = "AdaFactor: relative_stepを使用する";
            cbxRelativeStep.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(264, 172);
            label44.Name = "label44";
            label44.Size = new Size(141, 15);
            label44.TabIndex = 25;
            label44.Text = "networkドロップアウト確率#";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(269, 142);
            label38.Name = "label38";
            label38.Size = new Size(138, 15);
            label38.TabIndex = 25;
            label38.Text = "moduleドロップアウト確率#";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(286, 113);
            label37.Name = "label37";
            label37.Size = new Size(121, 15);
            label37.TabIndex = 25;
            label37.Text = "rankドロップアウト確率#";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(268, 84);
            label36.Name = "label36";
            label36.Size = new Size(139, 15);
            label36.TabIndex = 25;
            label36.Text = "Captionドロップアウト確率#";
            // 
            // nudMaxNormReg
            // 
            nudMaxNormReg.DecimalPlaces = 2;
            nudMaxNormReg.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudMaxNormReg.Location = new Point(413, 199);
            nudMaxNormReg.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMaxNormReg.Name = "nudMaxNormReg";
            nudMaxNormReg.Size = new Size(78, 23);
            nudMaxNormReg.TabIndex = 24;
            // 
            // nudNetworkDropout
            // 
            nudNetworkDropout.DecimalPlaces = 2;
            nudNetworkDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudNetworkDropout.Location = new Point(413, 170);
            nudNetworkDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNetworkDropout.Name = "nudNetworkDropout";
            nudNetworkDropout.Size = new Size(78, 23);
            nudNetworkDropout.TabIndex = 24;
            // 
            // nudModuleDropout
            // 
            nudModuleDropout.DecimalPlaces = 2;
            nudModuleDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudModuleDropout.Location = new Point(413, 140);
            nudModuleDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudModuleDropout.Name = "nudModuleDropout";
            nudModuleDropout.Size = new Size(78, 23);
            nudModuleDropout.TabIndex = 24;
            // 
            // nudRankDropout
            // 
            nudRankDropout.DecimalPlaces = 2;
            nudRankDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudRankDropout.Location = new Point(413, 111);
            nudRankDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRankDropout.Name = "nudRankDropout";
            nudRankDropout.Size = new Size(78, 23);
            nudRankDropout.TabIndex = 24;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(330, 55);
            label26.Name = "label26";
            label26.Size = new Size(77, 15);
            label26.TabIndex = 19;
            label26.Text = "最大トークン数";
            // 
            // page3
            // 
            page3.Controls.Add(label55);
            page3.Controls.Add(nudLoRAPlusTELRRatio);
            page3.Controls.Add(nudLoRAPlusUnetLRRatio);
            page3.Controls.Add(nudLoRAPlusLRRatio);
            page3.Controls.Add(label54);
            page3.Controls.Add(label53);
            page3.Controls.Add(label52);
            page3.Controls.Add(nudHuberC);
            page3.Controls.Add(label50);
            page3.Controls.Add(cbxHuberSchedule);
            page3.Controls.Add(label49);
            page3.Controls.Add(cbxLossType);
            page3.Controls.Add(label48);
            page3.Location = new Point(4, 26);
            page3.Name = "page3";
            page3.Size = new Size(612, 341);
            page3.TabIndex = 10;
            page3.Text = "ページ3";
            page3.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new Point(122, 125);
            label55.Name = "label55";
            label55.Size = new Size(154, 15);
            label55.TabIndex = 9;
            label55.Text = "LoRA+ LR ratioの推奨値は16";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Location = new Point(43, 145);
            label54.Name = "label54";
            label54.Size = new Size(90, 15);
            label54.TabIndex = 7;
            label54.Text = "LoRA+ LR比率#";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Location = new Point(30, 203);
            label53.Name = "label53";
            label53.Size = new Size(105, 15);
            label53.TabIndex = 6;
            label53.Text = "LoRA+ TE LR比率#";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Location = new Point(16, 174);
            label52.Name = "label52";
            label52.Size = new Size(120, 15);
            label52.TabIndex = 6;
            label52.Text = "LoRA+ UNet LR比率#";
            // 
            // nudHuberC
            // 
            nudHuberC.DecimalPlaces = 2;
            nudHuberC.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudHuberC.Location = new Point(138, 89);
            nudHuberC.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            nudHuberC.Name = "nudHuberC";
            nudHuberC.Size = new Size(120, 23);
            nudHuberC.TabIndex = 5;
            nudHuberC.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(83, 91);
            label50.Name = "label50";
            label50.Size = new Size(49, 15);
            label50.TabIndex = 4;
            label50.Text = "huber_c";
            // 
            // cbxHuberSchedule
            // 
            cbxHuberSchedule.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHuberSchedule.FormattingEnabled = true;
            cbxHuberSchedule.Items.AddRange(new object[] { "snr", "exponential", "constant" });
            cbxHuberSchedule.Location = new Point(138, 53);
            cbxHuberSchedule.Name = "cbxHuberSchedule";
            cbxHuberSchedule.Size = new Size(121, 23);
            cbxHuberSchedule.TabIndex = 3;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new Point(30, 56);
            label49.Name = "label49";
            label49.Size = new Size(102, 15);
            label49.TabIndex = 2;
            label49.Text = "huberのスケジュール";
            // 
            // cbxLossType
            // 
            cbxLossType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLossType.FormattingEnabled = true;
            cbxLossType.Items.AddRange(new object[] { "l2(デフォルト)", "huber", "smooth_l1" });
            cbxLossType.Location = new Point(138, 17);
            cbxLossType.Name = "cbxLossType";
            cbxLossType.Size = new Size(121, 23);
            cbxLossType.TabIndex = 1;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(43, 20);
            label48.Name = "label48";
            label48.Size = new Size(89, 15);
            label48.TabIndex = 0;
            label48.Text = "損失関数の種類";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(label51);
            tabPage7.Controls.Add(cbxUseFP8);
            tabPage7.Controls.Add(cbxUseFullFp16);
            tabPage7.Controls.Add(nudGradAccSteps);
            tabPage7.Controls.Add(cbxCacheLatents);
            tabPage7.Controls.Add(cbxHighVRAM);
            tabPage7.Controls.Add(cbxUseGradient);
            tabPage7.Controls.Add(cbxCrossAttenType);
            tabPage7.Controls.Add(label4);
            tabPage7.Controls.Add(cbxUseFastLoading);
            tabPage7.Controls.Add(tbrCpuThreads);
            tabPage7.Controls.Add(cbxMixedPrecision);
            tabPage7.Controls.Add(label29);
            tabPage7.Controls.Add(nudDataLoaderThreads);
            tabPage7.Controls.Add(label27);
            tabPage7.Controls.Add(cbxCacheLatentsToDisk);
            tabPage7.Controls.Add(lblCpuThreadsCounter);
            tabPage7.Controls.Add(label5);
            tabPage7.Location = new Point(4, 26);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(612, 341);
            tabPage7.TabIndex = 8;
            tabPage7.Text = "パフォーマンス";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new Point(37, 246);
            label51.Name = "label51";
            label51.Size = new Size(79, 45);
            label51.TabIndex = 9;
            label51.Text = "gradinet\r\naccumulation\r\nsteps";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(320, 104);
            label29.Name = "label29";
            label29.Size = new Size(55, 15);
            label29.TabIndex = 15;
            label29.Text = "混合精度";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(17, 65);
            label27.Name = "label27";
            label27.Size = new Size(137, 15);
            label27.TabIndex = 20;
            label27.Text = "データローダのCPUスレッド数";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(btnShowTipsAboutOpts);
            tabPage5.Controls.Add(cbxUseAdditionalOptArgs);
            tabPage5.Controls.Add(label43);
            tabPage5.Controls.Add(label42);
            tabPage5.Controls.Add(cbxUseSafeguard);
            tabPage5.Controls.Add(cbxUseBiasCorrection);
            tabPage5.Controls.Add(cbxNoProx);
            tabPage5.Controls.Add(cbxDecouple);
            tabPage5.Controls.Add(tbxMomentum);
            tabPage5.Controls.Add(label30);
            tabPage5.Controls.Add(tbxWeightDecay);
            tabPage5.Controls.Add(label31);
            tabPage5.Controls.Add(tbxBetas0);
            tabPage5.Controls.Add(label32);
            tabPage5.Controls.Add(tbxBetas1);
            tabPage5.Controls.Add(label33);
            tabPage5.Controls.Add(tbxDCoef);
            tabPage5.Controls.Add(tbxProdigyBeta3);
            tabPage5.Controls.Add(tbxBetas2);
            tabPage5.Controls.Add(label34);
            tabPage5.Controls.Add(tbxEps);
            tabPage5.Controls.Add(label35);
            tabPage5.Controls.Add(tbxD0);
            tabPage5.Controls.Add(tbxGrowthRate);
            tabPage5.Location = new Point(4, 26);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(612, 341);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "DAdapt/AdamW/Lion";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnShowTipsAboutOpts
            // 
            btnShowTipsAboutOpts.Location = new Point(285, 166);
            btnShowTipsAboutOpts.Name = "btnShowTipsAboutOpts";
            btnShowTipsAboutOpts.Size = new Size(195, 26);
            btnShowTipsAboutOpts.TabIndex = 27;
            btnShowTipsAboutOpts.Text = "AdamWとLionに関するヒントを表示";
            btnShowTipsAboutOpts.UseVisualStyleBackColor = true;
            btnShowTipsAboutOpts.Click += btnShowTipsAboutOpts_Click;
            // 
            // cbxUseAdditionalOptArgs
            // 
            cbxUseAdditionalOptArgs.AutoSize = true;
            cbxUseAdditionalOptArgs.Location = new Point(285, 141);
            cbxUseAdditionalOptArgs.Name = "cbxUseAdditionalOptArgs";
            cbxUseAdditionalOptArgs.Size = new Size(235, 19);
            cbxUseAdditionalOptArgs.TabIndex = 26;
            cbxUseAdditionalOptArgs.Text = "AdamW/Lionで追加のパラメータを指定する";
            cbxUseAdditionalOptArgs.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(428, 63);
            label43.Name = "label43";
            label43.Size = new Size(77, 30);
            label43.TabIndex = 25;
            label43.Text = "d_coef\r\n(prodigyのみ)";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(428, 19);
            label42.Name = "label42";
            label42.Size = new Size(77, 30);
            label42.TabIndex = 25;
            label42.Text = "beta3#\r\n(prodigyのみ)";
            // 
            // cbxUseSafeguard
            // 
            cbxUseSafeguard.AutoSize = true;
            cbxUseSafeguard.Location = new Point(17, 216);
            cbxUseSafeguard.Name = "cbxUseSafeguard";
            cbxUseSafeguard.Size = new Size(227, 19);
            cbxUseSafeguard.TabIndex = 24;
            cbxUseSafeguard.Text = "safeguard warmupを使用(prodigyのみ)";
            cbxUseSafeguard.UseVisualStyleBackColor = true;
            // 
            // cbxUseBiasCorrection
            // 
            cbxUseBiasCorrection.AutoSize = true;
            cbxUseBiasCorrection.Location = new Point(17, 191);
            cbxUseBiasCorrection.Name = "cbxUseBiasCorrection";
            cbxUseBiasCorrection.Size = new Size(207, 19);
            cbxUseBiasCorrection.TabIndex = 24;
            cbxUseBiasCorrection.Text = "bias correctionを使用(prodigyのみ)";
            cbxUseBiasCorrection.UseVisualStyleBackColor = true;
            // 
            // cbxNoProx
            // 
            cbxNoProx.AutoSize = true;
            cbxNoProx.Location = new Point(17, 166);
            cbxNoProx.Name = "cbxNoProx";
            cbxNoProx.Size = new Size(136, 19);
            cbxNoProx.TabIndex = 24;
            cbxNoProx.Text = "no prox(Adan系のみ)";
            cbxNoProx.UseVisualStyleBackColor = true;
            // 
            // cbxDecouple
            // 
            cbxDecouple.AutoSize = true;
            cbxDecouple.Location = new Point(17, 141);
            cbxDecouple.Name = "cbxDecouple";
            cbxDecouple.Size = new Size(192, 19);
            cbxDecouple.TabIndex = 24;
            cbxDecouple.Text = "decoupleを有効化(Adam系のみ)";
            cbxDecouple.UseVisualStyleBackColor = true;
            // 
            // tbxMomentum
            // 
            tbxMomentum.Location = new Point(245, 45);
            tbxMomentum.Name = "tbxMomentum";
            tbxMomentum.Size = new Size(55, 23);
            tbxMomentum.TabIndex = 10;
            tbxMomentum.Text = "0";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(171, 46);
            label30.Name = "label30";
            label30.Size = new Size(68, 15);
            label30.TabIndex = 18;
            label30.Text = "momentum";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(17, 104);
            label31.Name = "label31";
            label31.Size = new Size(70, 30);
            label31.TabIndex = 19;
            label31.Text = "growth_rate\r\n0で無制限";
            // 
            // tbxBetas0
            // 
            tbxBetas0.Location = new Point(245, 16);
            tbxBetas0.Name = "tbxBetas0";
            tbxBetas0.Size = new Size(55, 23);
            tbxBetas0.TabIndex = 12;
            tbxBetas0.Text = "0.9";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(67, 75);
            label32.Name = "label32";
            label32.Size = new Size(20, 15);
            label32.TabIndex = 20;
            label32.Text = "d0";
            // 
            // tbxBetas1
            // 
            tbxBetas1.Location = new Point(306, 16);
            tbxBetas1.Name = "tbxBetas1";
            tbxBetas1.Size = new Size(55, 23);
            tbxBetas1.TabIndex = 13;
            tbxBetas1.Text = "0.999";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(62, 46);
            label33.Name = "label33";
            label33.Size = new Size(25, 15);
            label33.TabIndex = 21;
            label33.Text = "eps";
            // 
            // tbxDCoef
            // 
            tbxDCoef.Location = new Point(511, 60);
            tbxDCoef.Name = "tbxDCoef";
            tbxDCoef.Size = new Size(55, 23);
            tbxDCoef.TabIndex = 14;
            tbxDCoef.Text = "1";
            // 
            // tbxProdigyBeta3
            // 
            tbxProdigyBeta3.Location = new Point(511, 16);
            tbxProdigyBeta3.Name = "tbxProdigyBeta3";
            tbxProdigyBeta3.Size = new Size(55, 23);
            tbxProdigyBeta3.TabIndex = 14;
            tbxProdigyBeta3.Text = "0";
            // 
            // tbxBetas2
            // 
            tbxBetas2.Location = new Point(367, 16);
            tbxBetas2.Name = "tbxBetas2";
            tbxBetas2.Size = new Size(55, 23);
            tbxBetas2.TabIndex = 14;
            tbxBetas2.Text = "0.999";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(204, 19);
            label34.Name = "label34";
            label34.Size = new Size(35, 15);
            label34.TabIndex = 22;
            label34.Text = "betas";
            // 
            // tbxEps
            // 
            tbxEps.Location = new Point(93, 43);
            tbxEps.Name = "tbxEps";
            tbxEps.Size = new Size(64, 23);
            tbxEps.TabIndex = 15;
            tbxEps.Text = "1E-06";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(10, 16);
            label35.Name = "label35";
            label35.Size = new Size(79, 15);
            label35.TabIndex = 23;
            label35.Text = "weight_decay";
            // 
            // tbxD0
            // 
            tbxD0.Location = new Point(93, 72);
            tbxD0.Name = "tbxD0";
            tbxD0.Size = new Size(64, 23);
            tbxD0.TabIndex = 16;
            tbxD0.Text = "1E-06";
            // 
            // tbxGrowthRate
            // 
            tbxGrowthRate.Location = new Point(93, 101);
            tbxGrowthRate.Name = "tbxGrowthRate";
            tbxGrowthRate.Size = new Size(64, 23);
            tbxGrowthRate.TabIndex = 17;
            tbxGrowthRate.Text = "0";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblConfigPath);
            tabPage2.Controls.Add(lblVAEPath);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(btnClearTBoardPath);
            tabPage2.Controls.Add(btnClearConfigPath);
            tabPage2.Controls.Add(btnSelectLoRAmodel);
            tabPage2.Controls.Add(btnSelectConfigPath);
            tabPage2.Controls.Add(lblTBoardPath);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(btnClearLoRAmodel);
            tabPage2.Controls.Add(btnTensorBoardPath);
            tabPage2.Controls.Add(lblLoRAmodelPath);
            tabPage2.Controls.Add(btnClearVAE);
            tabPage2.Controls.Add(btnSelectVAE);
            tabPage2.Controls.Add(label16);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(612, 341);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "パス";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblConfigPath
            // 
            lblConfigPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfigPath.Location = new Point(309, 162);
            lblConfigPath.Name = "lblConfigPath";
            lblConfigPath.Size = new Size(240, 48);
            lblConfigPath.TabIndex = 25;
            lblConfigPath.Text = "C:\\Users\\Test\\Desktop\\long name\\aaaaa.toml";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(309, 120);
            label21.Name = "label21";
            label21.Size = new Size(69, 30);
            label21.TabIndex = 26;
            label21.Text = "dataset\r\nconfigのパス";
            // 
            // btnClearConfigPath
            // 
            btnClearConfigPath.Location = new Point(454, 120);
            btnClearConfigPath.Name = "btnClearConfigPath";
            btnClearConfigPath.Size = new Size(64, 30);
            btnClearConfigPath.TabIndex = 23;
            btnClearConfigPath.Text = "クリア";
            btnClearConfigPath.UseVisualStyleBackColor = true;
            btnClearConfigPath.Click += btnClearConfigPath_Click;
            // 
            // btnSelectConfigPath
            // 
            btnSelectConfigPath.Location = new Point(384, 120);
            btnSelectConfigPath.Name = "btnSelectConfigPath";
            btnSelectConfigPath.Size = new Size(64, 30);
            btnSelectConfigPath.TabIndex = 24;
            btnSelectConfigPath.Text = "選択";
            btnSelectConfigPath.UseVisualStyleBackColor = true;
            btnSelectConfigPath.Click += btnSelectConfigPath_Click;
            // 
            // pageMisc
            // 
            pageMisc.Controls.Add(label41);
            pageMisc.Controls.Add(cbxSaveState);
            pageMisc.Controls.Add(label40);
            pageMisc.Controls.Add(cbxDontSaveMetadata);
            pageMisc.Controls.Add(tbxComment);
            pageMisc.Controls.Add(label8);
            pageMisc.Controls.Add(nudSeed);
            pageMisc.Controls.Add(cbxPrecision);
            pageMisc.Controls.Add(tbxExtension);
            pageMisc.Controls.Add(label9);
            pageMisc.Controls.Add(label7);
            pageMisc.Controls.Add(label11);
            pageMisc.Controls.Add(label6);
            pageMisc.Controls.Add(nudClipSkip);
            pageMisc.Location = new Point(4, 26);
            pageMisc.Name = "pageMisc";
            pageMisc.Size = new Size(612, 341);
            pageMisc.TabIndex = 2;
            pageMisc.Text = "その他";
            pageMisc.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(85, 41);
            label41.Name = "label41";
            label41.Size = new Size(203, 15);
            label41.TabIndex = 66;
            label41.Text = "次の文字は使用できません /\\?:*<>|\"＆'`\r\n";
            // 
            // cbxSaveState
            // 
            cbxSaveState.AutoSize = true;
            cbxSaveState.Location = new Point(85, 227);
            cbxSaveState.Name = "cbxSaveState";
            cbxSaveState.Size = new Size(153, 19);
            cbxSaveState.TabIndex = 6;
            cbxSaveState.Text = "学習終了時にstateを保存";
            cbxSaveState.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(15, 18);
            label40.Name = "label40";
            label40.Size = new Size(64, 15);
            label40.TabIndex = 33;
            label40.Text = "学習コメント";
            // 
            // tbxComment
            // 
            tbxComment.Location = new Point(85, 15);
            tbxComment.Name = "tbxComment";
            tbxComment.Size = new Size(444, 23);
            tbxComment.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 113);
            label8.Name = "label8";
            label8.Size = new Size(189, 20);
            label8.TabIndex = 31;
            label8.Text = "通常編集する必要のない設定";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(cbxRandomIpNoiseGamma);
            tabPage6.Controls.Add(cbxRandomNoiseOffset);
            tabPage6.Controls.Add(label20);
            tabPage6.Controls.Add(nudNoiseOffset);
            tabPage6.Controls.Add(label18);
            tabPage6.Controls.Add(nudMinSNRGamma);
            tabPage6.Controls.Add(nudMultiresNoiseDiscount);
            tabPage6.Controls.Add(label57);
            tabPage6.Controls.Add(label17);
            tabPage6.Controls.Add(nudMultiresNoiseIterations);
            tabPage6.Controls.Add(nudIpNoiseGamma);
            tabPage6.Controls.Add(nudAdaptiveNoiseScale);
            tabPage6.Controls.Add(label19);
            tabPage6.Controls.Add(label14);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(612, 343);
            tabPage6.TabIndex = 7;
            tabPage6.Text = "ノイズ関連";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // pageXL
            // 
            pageXL.Controls.Add(cbxCacheTextencoderToDisk);
            pageXL.Controls.Add(cbxCacheTextEncoder);
            pageXL.Controls.Add(cbxNoHalfVae);
            pageXL.Location = new Point(4, 26);
            pageXL.Name = "pageXL";
            pageXL.Size = new Size(612, 341);
            pageXL.TabIndex = 9;
            pageXL.Text = "SDXL";
            pageXL.UseVisualStyleBackColor = true;
            // 
            // cbxCacheTextencoderToDisk
            // 
            cbxCacheTextencoderToDisk.AutoSize = true;
            cbxCacheTextencoderToDisk.Location = new Point(18, 69);
            cbxCacheTextencoderToDisk.Name = "cbxCacheTextencoderToDisk";
            cbxCacheTextencoderToDisk.Size = new Size(222, 19);
            cbxCacheTextencoderToDisk.TabIndex = 18;
            cbxCacheTextencoderToDisk.Text = "Text Encoderの出力をディスクにキャッシュ";
            cbxCacheTextencoderToDisk.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label47);
            tabPage3.Controls.Add(cbxWeightDecomposition);
            tabPage3.Controls.Add(cbxUseTucker);
            tabPage3.Controls.Add(cbxConstrainedOFT);
            tabPage3.Controls.Add(cbxUseScalar);
            tabPage3.Controls.Add(cbxRescaledOFT);
            tabPage3.Controls.Add(cbxTrainNorm);
            tabPage3.Controls.Add(cbxAlgoType);
            tabPage3.Controls.Add(label23);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(612, 341);
            tabPage3.TabIndex = 11;
            tabPage3.Text = "LyCORIS";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label47.Location = new Point(26, 14);
            label47.Name = "label47";
            label47.Size = new Size(224, 19);
            label47.TabIndex = 19;
            label47.Text = "注意:LyCORISの動作は保証しません。";
            // 
            // cbxUseTucker
            // 
            cbxUseTucker.AutoSize = true;
            cbxUseTucker.Location = new Point(26, 216);
            cbxUseTucker.Name = "cbxUseTucker";
            cbxUseTucker.Size = new Size(143, 19);
            cbxUseTucker.TabIndex = 18;
            cbxUseTucker.Text = "Tucker Decomposition";
            cbxUseTucker.UseVisualStyleBackColor = true;
            // 
            // cbxConstrainedOFT
            // 
            cbxConstrainedOFT.AutoSize = true;
            cbxConstrainedOFT.Location = new Point(26, 167);
            cbxConstrainedOFT.Name = "cbxConstrainedOFT";
            cbxConstrainedOFT.Size = new Size(113, 19);
            cbxConstrainedOFT.TabIndex = 18;
            cbxConstrainedOFT.Text = "Constrained OFT";
            cbxConstrainedOFT.UseVisualStyleBackColor = true;
            // 
            // cbxUseScalar
            // 
            cbxUseScalar.AutoSize = true;
            cbxUseScalar.Location = new Point(26, 191);
            cbxUseScalar.Name = "cbxUseScalar";
            cbxUseScalar.Size = new Size(57, 19);
            cbxUseScalar.TabIndex = 18;
            cbxUseScalar.Text = "Scalar";
            cbxUseScalar.UseVisualStyleBackColor = true;
            // 
            // cbxRescaledOFT
            // 
            cbxRescaledOFT.AutoSize = true;
            cbxRescaledOFT.Location = new Point(26, 142);
            cbxRescaledOFT.Name = "cbxRescaledOFT";
            cbxRescaledOFT.Size = new Size(96, 19);
            cbxRescaledOFT.TabIndex = 18;
            cbxRescaledOFT.Text = "Rescaled OFT";
            cbxRescaledOFT.UseVisualStyleBackColor = true;
            // 
            // cbxTrainNorm
            // 
            cbxTrainNorm.AutoSize = true;
            cbxTrainNorm.Location = new Point(26, 117);
            cbxTrainNorm.Name = "cbxTrainNorm";
            cbxTrainNorm.Size = new Size(136, 19);
            cbxTrainNorm.TabIndex = 18;
            cbxTrainNorm.Text = "Normalization Layers";
            cbxTrainNorm.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(26, 49);
            label23.Name = "label23";
            label23.Size = new Size(114, 15);
            label23.TabIndex = 17;
            label23.Text = "LyCORISのアルゴリズム";
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Location = new Point(16, 398);
            label56.Name = "label56";
            label56.Size = new Size(177, 15);
            label56.TabIndex = 58;
            label56.Text = "#がつく項目は0を指定すると無効化";
            // 
            // cbxRandomNoiseOffset
            // 
            cbxRandomNoiseOffset.AutoSize = true;
            cbxRandomNoiseOffset.Location = new Point(270, 21);
            cbxRandomNoiseOffset.Name = "cbxRandomNoiseOffset";
            cbxRandomNoiseOffset.Size = new Size(59, 19);
            cbxRandomNoiseOffset.TabIndex = 57;
            cbxRandomNoiseOffset.Text = "ランダム";
            toolTip1.SetToolTip(cbxRandomNoiseOffset, "0から指定した強度の間のランダムな値を適用する");
            cbxRandomNoiseOffset.UseVisualStyleBackColor = true;
            // 
            // cbxRandomIpNoiseGamma
            // 
            cbxRandomIpNoiseGamma.AutoSize = true;
            cbxRandomIpNoiseGamma.Location = new Point(270, 49);
            cbxRandomIpNoiseGamma.Name = "cbxRandomIpNoiseGamma";
            cbxRandomIpNoiseGamma.Size = new Size(59, 19);
            cbxRandomIpNoiseGamma.TabIndex = 57;
            cbxRandomIpNoiseGamma.Text = "ランダム";
            toolTip1.SetToolTip(cbxRandomIpNoiseGamma, "0から指定した強度の間のランダムな値を適用する");
            cbxRandomIpNoiseGamma.UseVisualStyleBackColor = true;
            // 
            // nudIpNoiseGamma
            // 
            nudIpNoiseGamma.DecimalPlaces = 1;
            nudIpNoiseGamma.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudIpNoiseGamma.Location = new Point(170, 48);
            nudIpNoiseGamma.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudIpNoiseGamma.Name = "nudIpNoiseGamma";
            nudIpNoiseGamma.Size = new Size(94, 23);
            nudIpNoiseGamma.TabIndex = 49;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Location = new Point(64, 53);
            label57.Name = "label57";
            label57.Size = new Size(100, 15);
            label57.TabIndex = 50;
            label57.Text = "Ip Noise Gamma#";
            // 
            // FormAdvanced
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(643, 432);
            Controls.Add(label56);
            Controls.Add(tabControl1);
            Controls.Add(btnDiscardAndClose);
            Controls.Add(button1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdvanced";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "詳細設定";
            Load += Form_Advanced_Load;
            ((System.ComponentModel.ISupportInitialize)tbrCpuThreads).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLRSchedulerCycle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNoiseOffset).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCaptionDropout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDataLoaderThreads).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudClipSkip).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxTokens).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudConvDim).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinSNRGamma).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGradAccSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLoRAPlusLRRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLoRAPlusUnetLRRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLoRAPlusTELRRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBucketReso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBucketReso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMomentum).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdaptiveNoiseScale).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseIterations).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseDiscount).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDyLoRAUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudConvAlpha).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxNormReg).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNetworkDropout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudModuleDropout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRankDropout).EndInit();
            page3.ResumeLayout(false);
            page3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHuberC).EndInit();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pageMisc.ResumeLayout(false);
            pageMisc.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            pageXL.ResumeLayout(false);
            pageXL.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIpNoiseGamma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUnetLR;
        private TextBox tbxTextEncoLR;
        private Label label1;
        private Label label2;
        private Label lblMinBucketReso;
        private Label lblMaxBucketReso;
        private CheckBox cbxNoUpscale;
        private TrackBar tbrCpuThreads;
        private Label label5;
        private Label lblCpuThreadsCounter;
        private ToolTip toolTip1;
        private Label label7;
        private Label label6;
        private CheckBox cbxUseWarmupInit;
        private TextBox tbxExtension;
        private Label label9;
        private Button button1;
        private NumericUpDown nudSeed;
        private NumericUpDown nudMinBucketReso;
        private NumericUpDown nudMaxBucketReso;
        private Label label10;
        private ComboBox cbxScheduler;
        private NumericUpDown nudClipSkip;
        private ComboBox cbxPrecision;
        private Label label11;
        private Button btnDiscardAndClose;
        private Button btnTensorBoardPath;
        private Label label12;
        private Label lblTBoardPath;
        private Button btnClearTBoardPath;
        private ComboBox cbxAdvancedTrain;
        private Label label13;
        private ComboBox cbxCrossAttenType;
        private Label label4;
        private CheckBox cbxUseGradient;
        private Label label3;
        private Button btnSelectLoRAmodel;
        private Button btnClearLoRAmodel;
        private Label lblLoRAmodelPath;
        private NumericUpDown nudNoiseOffset;
        private Label label14;
        private NumericUpDown nudMomentum;
        private Label label15;
        private Button btnSelectVAE;
        private Button btnClearVAE;
        private Label label16;
        private Label lblVAEPath;
        private CheckBox cbxUseWeightedCaption;
        private NumericUpDown nudAdaptiveNoiseScale;
        private Label label17;
        private NumericUpDown nudMinSNRGamma;
        private Label label18;
        private NumericUpDown nudMultiresNoiseIterations;
        private Label label19;
        private NumericUpDown nudMultiresNoiseDiscount;
        private Label label20;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage pageMisc;
        private Label label8;
        private Label lblConfigPath;
        private Label label21;
        private Button btnClearConfigPath;
        private Button btnSelectConfigPath;
        private Label label22;
        private NumericUpDown nudDyLoRAUnit;
        private CheckBox cbxUseConv2d;
        private NumericUpDown nudConvAlpha;
        private NumericUpDown nudConvDim;
        private Label label23;
        private Label label24;
        private Label label25;
        private ComboBox cbxAlgoType;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private CheckBox cbxUseColorAug;
        private CheckBox cbxCacheLatentsToDisk;
        private CheckBox cbxUseFastLoading;
        private CheckBox cbxCacheLatents;
        private Label label26;
        private Label label27;
        private CheckBox cbxDontSaveMetadata;
        private Label label28;
        private CheckBox cbxCropRandomly;
        private NumericUpDown nudMaxTokens;
        private CheckBox cbxFlipAug;
        private NumericUpDown nudDataLoaderThreads;
        private ComboBox cbxMixedPrecision;
        private NumericUpDown nudLRSchedulerCycle;
        private Label label29;
        private TextBox tbxMomentum;
        private Label label30;
        private TextBox tbxWeightDecay;
        private Label label31;
        private TextBox tbxBetas0;
        private Label label32;
        private TextBox tbxBetas1;
        private Label label33;
        private TextBox tbxBetas2;
        private Label label34;
        private TextBox tbxEps;
        private Label label35;
        private TextBox tbxD0;
        private TextBox tbxGrowthRate;
        private Label label38;
        private Label label37;
        private Label label36;
        private NumericUpDown nudModuleDropout;
        private NumericUpDown nudRankDropout;
        private NumericUpDown nudCaptionDropout;
        private Label label39;
        private NumericUpDown nudMaxNormReg;
        private CheckBox cbxDecouple;
        private CheckBox cbxNoProx;
        private Label label40;
        private TextBox tbxComment;
        private Label label41;
        private Label label43;
        private Label label42;
        private CheckBox cbxUseSafeguard;
        private CheckBox cbxUseBiasCorrection;
        private TextBox tbxDCoef;
        private TextBox tbxProdigyBeta3;
        private CheckBox cbxNoHalfVae;
        private CheckBox cbxCacheTextEncoder;
        private CheckBox cbxCacheTextencoderToDisk;
        private TabPage tabPage6;
        private Label label44;
        private NumericUpDown nudNetworkDropout;
        private Label label45;
        private TabPage tabPage7;
        private TabPage pageXL;
        private CheckBox cbxUseFullFp16;
        private TextBox tbxTokensSeparator;
        private Label label46;
        private CheckBox cbxUseFP8;
        private TabPage page3;
        private CheckBox cbxScaleParameter;
        private CheckBox cbxRelativeStep;
        private TabPage tabPage3;
        private CheckBox cbxTrainNorm;
        private CheckBox cbxWeightDecomposition;
        private CheckBox cbxUseTucker;
        private CheckBox cbxUseScalar;
        private CheckBox cbxRescaledOFT;
        private CheckBox cbxConstrainedOFT;
        private Label label47;
        private CheckBox cbxHighVRAM;
        private Label label48;
        private Label label49;
        private ComboBox cbxLossType;
        private NumericUpDown nudHuberC;
        private Label label50;
        private ComboBox cbxHuberSchedule;
        private CheckBox cbxSaveState;
        private CheckBox cbxMaskLoss;
        private Label label51;
        private NumericUpDown nudGradAccSteps;
        private NumericUpDown nudLoRAPlusLRRatio;
        private Label label54;
        private Label label53;
        private Label label52;
        private NumericUpDown nudLoRAPlusTELRRatio;
        private NumericUpDown nudLoRAPlusUnetLRRatio;
        private Label label55;
        private Label label56;
        private CheckBox cbxUseAdditionalOptArgs;
        private Button btnShowTipsAboutOpts;
        private CheckBox cbxRandomIpNoiseGamma;
        private CheckBox cbxRandomNoiseOffset;
        private Label label57;
        private NumericUpDown nudIpNoiseGamma;
    }
}

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
            cbxRandomNoiseOffset = new CheckBox();
            cbxRandomIpNoiseGamma = new CheckBox();
            cbxLossType = new ComboBox();
            cbxAlphaMask = new CheckBox();
            nudHuberC = new NumericUpDown();
            nudIpNoiseGamma = new NumericUpDown();
            btnSelectVAE = new Button();
            nudSchedulerTimescale = new NumericUpDown();
            nudMinLRRatio = new NumericUpDown();
            nudLRDecaySteps = new NumericUpDown();
            nudCaptionTagDropout = new NumericUpDown();
            cbxDisableMmapLoadSafetensors = new CheckBox();
            cbxVParameterization = new CheckBox();
            cbxZeroTerminalSNR = new CheckBox();
            cbxUseAdditionalOptArgs = new CheckBox();
            nudMultiresNoiseIterations = new NumericUpDown();
            nudMultiresNoiseDiscount = new NumericUpDown();
            cbxDebiasedEstimation = new CheckBox();
            nudMaxTokensT5 = new NumericUpDown();
            cbxResizeInterpolation = new ComboBox();
            nudScaleWeightNorms = new NumericUpDown();
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
            btnClearVAE = new Button();
            label16 = new Label();
            lblVAEPath = new Label();
            nudAdaptiveNoiseScale = new NumericUpDown();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox8 = new GroupBox();
            groupBox7 = new GroupBox();
            label24 = new Label();
            label25 = new Label();
            nudConvAlpha = new NumericUpDown();
            groupBox6 = new GroupBox();
            label45 = new Label();
            groupBox5 = new GroupBox();
            groupBox4 = new GroupBox();
            label53 = new Label();
            label52 = new Label();
            label54 = new Label();
            label22 = new Label();
            nudDyLoRAUnit = new NumericUpDown();
            tabPage4 = new TabPage();
            label71 = new Label();
            label76 = new Label();
            label70 = new Label();
            nudT5DropoutRate = new NumericUpDown();
            nudClipGDropoutRate = new NumericUpDown();
            label44 = new Label();
            label38 = new Label();
            label75 = new Label();
            label37 = new Label();
            label74 = new Label();
            label36 = new Label();
            nudNetworkDropout = new NumericUpDown();
            nudModuleDropout = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            nudRankDropout = new NumericUpDown();
            nudClipLDropoutRate = new NumericUpDown();
            page3 = new TabPage();
            cbxMaskLoss = new CheckBox();
            label50 = new Label();
            label8 = new Label();
            cbxHuberSchedule = new ComboBox();
            label49 = new Label();
            label48 = new Label();
            label57 = new Label();
            tabPage6 = new TabPage();
            label69 = new Label();
            label66 = new Label();
            label47 = new Label();
            tabPage7 = new TabPage();
            cbxCacheTextencoderToDisk = new CheckBox();
            label51 = new Label();
            label29 = new Label();
            label27 = new Label();
            tabPage5 = new TabPage();
            groupBox3 = new GroupBox();
            cbxDecouple = new CheckBox();
            cbxUseBiasCorrection = new CheckBox();
            cbxUseSafeguard = new CheckBox();
            label65 = new Label();
            btnShowTipsAboutOpts = new Button();
            label43 = new Label();
            label42 = new Label();
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
            tbxEps1 = new TextBox();
            tbxEps = new TextBox();
            label35 = new Label();
            tbxD0 = new TextBox();
            tbxGrowthRate = new TextBox();
            tabPage2 = new TabPage();
            btnClearClipGPath = new Button();
            btnClipGPath = new Button();
            label72 = new Label();
            label67 = new Label();
            btnClearT5XXLPath = new Button();
            btnClearClipLPath = new Button();
            btnT5XXLPath = new Button();
            btnClipLPath = new Button();
            lblConfigPath = new Label();
            label21 = new Label();
            btnClearConfigPath = new Button();
            lblT5XXLPath = new Label();
            btnSelectConfigPath = new Button();
            lblClipGPath = new Label();
            lblClipLPath = new Label();
            label68 = new Label();
            pageMisc = new TabPage();
            label77 = new Label();
            groupBox2 = new GroupBox();
            cbxSaveState = new CheckBox();
            label41 = new Label();
            label40 = new Label();
            tbxTokensSeparator = new TextBox();
            nudTEBatchSize = new NumericUpDown();
            label46 = new Label();
            label73 = new Label();
            label26 = new Label();
            tbxComment = new TextBox();
            tabPage3 = new TabPage();
            label64 = new Label();
            cbxUseTucker = new CheckBox();
            cbxConstrainedOFT = new CheckBox();
            cbxUseScalar = new CheckBox();
            cbxRescaledOFT = new CheckBox();
            cbxTrainNorm = new CheckBox();
            label23 = new Label();
            label56 = new Label();
            cbxUseFullBf16 = new CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)nudHuberC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIpNoiseGamma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSchedulerTimescale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinLRRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLRDecaySteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCaptionTagDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseIterations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxTokensT5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudScaleWeightNorms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBucketReso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBucketReso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdaptiveNoiseScale).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudConvAlpha).BeginInit();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDyLoRAUnit).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudT5DropoutRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClipGDropoutRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNetworkDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudModuleDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRankDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClipLDropoutRate).BeginInit();
            page3.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage5.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            pageMisc.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTEBatchSize).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tbxUnetLR
            // 
            tbxUnetLR.Location = new Point(119, 17);
            tbxUnetLR.Margin = new Padding(3, 4, 3, 4);
            tbxUnetLR.Name = "tbxUnetLR";
            tbxUnetLR.Size = new Size(102, 23);
            tbxUnetLR.TabIndex = 0;
            toolTip1.SetToolTip(tbxUnetLR, "一部のDADaptation系では使用不可");
            tbxUnetLR.TextChanged += tbxUnetLR_TextChanged;
            // 
            // tbxTextEncoLR
            // 
            tbxTextEncoLR.Location = new Point(119, 43);
            tbxTextEncoLR.Margin = new Padding(3, 4, 3, 4);
            tbxTextEncoLR.Name = "tbxTextEncoLR";
            tbxTextEncoLR.Size = new Size(101, 23);
            tbxTextEncoLR.TabIndex = 1;
            toolTip1.SetToolTip(tbxTextEncoLR, "一部のDADaptation系では使用不可");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "UNet LR##";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 46);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 3;
            label2.Text = "Text encoder LR##";
            // 
            // lblMinBucketReso
            // 
            lblMinBucketReso.AutoSize = true;
            lblMinBucketReso.Location = new Point(12, 25);
            lblMinBucketReso.Name = "lblMinBucketReso";
            lblMinBucketReso.Size = new Size(102, 15);
            lblMinBucketReso.TabIndex = 4;
            lblMinBucketReso.Text = "最小バケット解像度";
            // 
            // lblMaxBucketReso
            // 
            lblMaxBucketReso.AutoSize = true;
            lblMaxBucketReso.Location = new Point(12, 56);
            lblMaxBucketReso.Name = "lblMaxBucketReso";
            lblMaxBucketReso.Size = new Size(102, 15);
            lblMaxBucketReso.TabIndex = 7;
            lblMaxBucketReso.Text = "最大バケット解像度";
            // 
            // cbxNoUpscale
            // 
            cbxNoUpscale.AutoSize = true;
            cbxNoUpscale.Location = new Point(12, 87);
            cbxNoUpscale.Name = "cbxNoUpscale";
            cbxNoUpscale.Size = new Size(102, 19);
            cbxNoUpscale.TabIndex = 8;
            cbxNoUpscale.Text = "画像拡大しない";
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
            label5.Location = new Point(22, 17);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 10;
            label5.Text = "CPUスレッド数";
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
            label7.Location = new Point(24, 24);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 13;
            label7.Text = "Clip Skip(SD1)";
            // 
            // cbxPrecision
            // 
            cbxPrecision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPrecision.FormattingEnabled = true;
            cbxPrecision.Items.AddRange(new object[] { "fp16", "bf16", "float" });
            cbxPrecision.Location = new Point(108, 81);
            cbxPrecision.Name = "cbxPrecision";
            cbxPrecision.Size = new Size(92, 23);
            cbxPrecision.TabIndex = 29;
            toolTip1.SetToolTip(cbxPrecision, "fp16にするとファイルサイズ半減\r\nbf16は互換性の観点から非推奨");
            // 
            // cbxCrossAttenType
            // 
            cbxCrossAttenType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCrossAttenType.FormattingEnabled = true;
            cbxCrossAttenType.Items.AddRange(new object[] { "xformers", "mem_eff_attn", "sdpa", "無し" });
            cbxCrossAttenType.Location = new Point(160, 101);
            cbxCrossAttenType.Name = "cbxCrossAttenType";
            cbxCrossAttenType.Size = new Size(98, 23);
            cbxCrossAttenType.TabIndex = 38;
            toolTip1.SetToolTip(cbxCrossAttenType, "最適化アルゴリズムの種類\r\nmef_eff_attenは省メモリだが遅い\r\nxformersは高速だがNVIDIAのみ対応\r\nsdpaは高速だがtorchのエラーで動かないかも(原因不明)");
            // 
            // cbxUseColorAug
            // 
            cbxUseColorAug.AutoSize = true;
            cbxUseColorAug.Location = new Point(25, 47);
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
            toolTip1.SetToolTip(cbxCacheLatents, "予め画像をVAEでエンコード(latentに変換)することで\r\nVRAM消費削減および速度改善\r\n画像反転以外のaugmentationは利用不可");
            cbxCacheLatents.UseVisualStyleBackColor = true;
            // 
            // cbxMixedPrecision
            // 
            cbxMixedPrecision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMixedPrecision.FormattingEnabled = true;
            cbxMixedPrecision.Items.AddRange(new object[] { "なし", "fp16", "bf16" });
            cbxMixedPrecision.Location = new Point(372, 63);
            cbxMixedPrecision.Name = "cbxMixedPrecision";
            cbxMixedPrecision.Size = new Size(74, 23);
            cbxMixedPrecision.TabIndex = 14;
            toolTip1.SetToolTip(cbxMixedPrecision, "bf16はNVIDIA Ampere世代以降のみ対応");
            // 
            // nudLRSchedulerCycle
            // 
            nudLRSchedulerCycle.DecimalPlaces = 2;
            nudLRSchedulerCycle.Location = new Point(148, 144);
            nudLRSchedulerCycle.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            nudLRSchedulerCycle.Name = "nudLRSchedulerCycle";
            nudLRSchedulerCycle.Size = new Size(99, 23);
            nudLRSchedulerCycle.TabIndex = 16;
            toolTip1.SetToolTip(nudLRSchedulerCycle, "一度の学習のLR調整の回数\r\ncosine_with_restartsの場合はコサイン波の数(整数のみ)\r\npolynomialの場合は減衰の乗数");
            nudLRSchedulerCycle.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // cbxAlgoType
            // 
            cbxAlgoType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAlgoType.FormattingEnabled = true;
            cbxAlgoType.Items.AddRange(new object[] { "lora", "loha", "ia3", "lokr", "full", "glora", "diag-oft", "boft" });
            cbxAlgoType.Location = new Point(141, 55);
            cbxAlgoType.Name = "cbxAlgoType";
            cbxAlgoType.Size = new Size(121, 23);
            cbxAlgoType.TabIndex = 14;
            toolTip1.SetToolTip(cbxAlgoType, "loha、lokrやia3の実質的なdimは2乗になる");
            // 
            // cbxUseGradient
            // 
            cbxUseGradient.AutoSize = true;
            cbxUseGradient.Location = new Point(45, 212);
            cbxUseGradient.Name = "cbxUseGradient";
            cbxUseGradient.Size = new Size(150, 19);
            cbxUseGradient.TabIndex = 18;
            cbxUseGradient.Text = "Gradient checkpointing";
            toolTip1.SetToolTip(cbxUseGradient, "VRAM消費削減および増加を強く抑制\r\n速度がやや低下する");
            cbxUseGradient.UseVisualStyleBackColor = true;
            // 
            // nudNoiseOffset
            // 
            nudNoiseOffset.DecimalPlaces = 4;
            nudNoiseOffset.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudNoiseOffset.Location = new Point(445, 20);
            nudNoiseOffset.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudNoiseOffset.Name = "nudNoiseOffset";
            nudNoiseOffset.Size = new Size(80, 23);
            nudNoiseOffset.TabIndex = 44;
            toolTip1.SetToolTip(nudNoiseOffset, "全体的に明るい/暗い環境でグレー寄りになるのを軽減する\r\n変色と明度の変化を減らすため学習元モデルで使用された値を設定すべき\r\nちなみにAnimagine XL系で使用された値は0.0357\r\nZero Terminal SNRを使うなら0にする");
            // 
            // nudCaptionDropout
            // 
            nudCaptionDropout.DecimalPlaces = 4;
            nudCaptionDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudCaptionDropout.Location = new Point(222, 19);
            nudCaptionDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCaptionDropout.Name = "nudCaptionDropout";
            nudCaptionDropout.Size = new Size(78, 23);
            nudCaptionDropout.TabIndex = 24;
            toolTip1.SetToolTip(nudCaptionDropout, "キャプションの切り落としの発生率");
            // 
            // cbxDontSaveMetadata
            // 
            cbxDontSaveMetadata.AutoSize = true;
            cbxDontSaveMetadata.Location = new Point(314, 136);
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
            nudDataLoaderThreads.Size = new Size(98, 23);
            nudDataLoaderThreads.TabIndex = 18;
            toolTip1.SetToolTip(nudDataLoaderThreads, "ほとんどの処理がシングルスレッドで動くため上げても速くならない\r\nメインメモリの使用量増加");
            nudDataLoaderThreads.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // tbxExtension
            // 
            tbxExtension.Location = new Point(108, 110);
            tbxExtension.Name = "tbxExtension";
            tbxExtension.Size = new Size(92, 23);
            tbxExtension.TabIndex = 19;
            tbxExtension.Text = ".txt";
            toolTip1.SetToolTip(tbxExtension, "ピリオド込みで入力する");
            // 
            // nudClipSkip
            // 
            nudClipSkip.Location = new Point(110, 22);
            nudClipSkip.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            nudClipSkip.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudClipSkip.Name = "nudClipSkip";
            nudClipSkip.Size = new Size(92, 23);
            nudClipSkip.TabIndex = 28;
            toolTip1.SetToolTip(nudClipSkip, "イラストは2、実写は1が良いとされる\r\nSD1専用");
            nudClipSkip.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // cbxUseWeightedCaption
            // 
            cbxUseWeightedCaption.AutoSize = true;
            cbxUseWeightedCaption.Location = new Point(314, 111);
            cbxUseWeightedCaption.Name = "cbxUseWeightedCaption";
            cbxUseWeightedCaption.Size = new Size(189, 19);
            cbxUseWeightedCaption.TabIndex = 48;
            cbxUseWeightedCaption.Text = "キャプションに重みづけを使用(SD1)";
            toolTip1.SetToolTip(cbxUseWeightedCaption, "キャプションでカッコなどを強調として使用する\r\nAUTOMATIC1111 WebUIと同様の記法");
            cbxUseWeightedCaption.UseVisualStyleBackColor = true;
            // 
            // cbxCacheTextEncoder
            // 
            cbxCacheTextEncoder.AutoSize = true;
            cbxCacheTextEncoder.Location = new Point(311, 174);
            cbxCacheTextEncoder.Name = "cbxCacheTextEncoder";
            cbxCacheTextEncoder.Size = new Size(180, 19);
            cbxCacheTextEncoder.TabIndex = 18;
            cbxCacheTextEncoder.Text = "Text Encoderの出力のキャッシュ";
            toolTip1.SetToolTip(cbxCacheTextEncoder, "キャプション関連のオプションは使用不可");
            cbxCacheTextEncoder.UseVisualStyleBackColor = true;
            // 
            // nudSeed
            // 
            nudSeed.Location = new Point(110, 51);
            nudSeed.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            nudSeed.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            nudSeed.Name = "nudSeed";
            nudSeed.Size = new Size(92, 23);
            nudSeed.TabIndex = 23;
            toolTip1.SetToolTip(nudSeed, "Seedによって品質が向上することはない");
            nudSeed.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            // 
            // nudMaxTokens
            // 
            nudMaxTokens.Increment = new decimal(new int[] { 75, 0, 0, 0 });
            nudMaxTokens.Location = new Point(144, 94);
            nudMaxTokens.Maximum = new decimal(new int[] { 225, 0, 0, 0 });
            nudMaxTokens.Minimum = new decimal(new int[] { 75, 0, 0, 0 });
            nudMaxTokens.Name = "nudMaxTokens";
            nudMaxTokens.Size = new Size(92, 23);
            nudMaxTokens.TabIndex = 17;
            toolTip1.SetToolTip(nudMaxTokens, "コンマ区切りではなくCLIPのトークン数\r\nSD1以外で動作するかは不明");
            nudMaxTokens.Value = new decimal(new int[] { 75, 0, 0, 0 });
            // 
            // cbxUseConv2d
            // 
            cbxUseConv2d.AutoSize = true;
            cbxUseConv2d.Location = new Point(22, 21);
            cbxUseConv2d.Name = "cbxUseConv2d";
            cbxUseConv2d.Size = new Size(136, 19);
            cbxUseConv2d.TabIndex = 20;
            cbxUseConv2d.Text = "畳み込み層を学習する";
            toolTip1.SetToolTip(cbxUseConv2d, "畳み込み層も学習する\r\nキャラLoRAはオフでよい");
            cbxUseConv2d.UseVisualStyleBackColor = true;
            // 
            // nudConvDim
            // 
            nudConvDim.Location = new Point(86, 43);
            nudConvDim.Maximum = new decimal(new int[] { 1280, 0, 0, 0 });
            nudConvDim.Name = "nudConvDim";
            nudConvDim.Size = new Size(72, 23);
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
            toolTip1.SetToolTip(cbxCacheLatentsToDisk, "latentのキャッシュもオンにする必要あり\r\n2回目以降の学習開始が高速化\r\nlatentの内容はVAEによって変わり、UnetやTEは関係ない\r\n例:AnimagineでキャッシュしたものはPonyでもそのまま使える");
            cbxCacheLatentsToDisk.UseVisualStyleBackColor = true;
            // 
            // cbxCropRandomly
            // 
            cbxCropRandomly.AutoSize = true;
            cbxCropRandomly.Location = new Point(25, 72);
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
            cbxNoHalfVae.Location = new Point(311, 149);
            cbxNoHalfVae.Name = "cbxNoHalfVae";
            cbxNoHalfVae.Size = new Size(199, 19);
            cbxNoHalfVae.TabIndex = 18;
            cbxNoHalfVae.Text = "VAEを32ビットで使用(No-half VAE)";
            toolTip1.SetToolTip(cbxNoHalfVae, "no-half VAE\r\nVAEのNaN演算をなくす\r\nStabilityAIのSDXL VAEはこの設定が必須");
            cbxNoHalfVae.UseVisualStyleBackColor = true;
            // 
            // cbxFlipAug
            // 
            cbxFlipAug.AutoSize = true;
            cbxFlipAug.Location = new Point(25, 22);
            cbxFlipAug.Name = "cbxFlipAug";
            cbxFlipAug.Size = new Size(107, 19);
            cbxFlipAug.TabIndex = 8;
            cbxFlipAug.Text = "反転画像を使用";
            toolTip1.SetToolTip(cbxFlipAug, "反転画像でデータセットを水増し");
            cbxFlipAug.UseVisualStyleBackColor = true;
            // 
            // cbxUseFP8
            // 
            cbxUseFP8.AutoSize = true;
            cbxUseFP8.Location = new Point(311, 124);
            cbxUseFP8.Name = "cbxUseFP8";
            cbxUseFP8.Size = new Size(135, 19);
            cbxUseFP8.TabIndex = 42;
            cbxUseFP8.Text = "モデルをfp8で読み込む";
            toolTip1.SetToolTip(cbxUseFP8, "事前学習モデルをhalfの代わりにfp8_e4m3fnで読み込む\r\n若干の速度低下と引き換えにモデルによるVRAM消費が半減する\r\nVRAM10GB以下では使用を推奨\r\nただし品質が低下する可能性あり");
            cbxUseFP8.UseVisualStyleBackColor = true;
            // 
            // cbxUseFastLoading
            // 
            cbxUseFastLoading.AutoSize = true;
            cbxUseFastLoading.Checked = true;
            cbxUseFastLoading.CheckState = CheckState.Checked;
            cbxUseFastLoading.Location = new Point(311, 99);
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
            cbxScheduler.Items.AddRange(new object[] { "cosine_with_restarts", "cosine", "linear", "polynomial", "constant", "constant_with_warmup", "inverse_sqrt", "cosine_with_min_lr", "warmup_stable_decay" });
            cbxScheduler.Location = new Point(148, 18);
            cbxScheduler.Name = "cbxScheduler";
            cbxScheduler.Size = new Size(159, 23);
            cbxScheduler.TabIndex = 27;
            toolTip1.SetToolTip(cbxScheduler, "LR調整アルゴリズム");
            // 
            // nudMinSNRGamma
            // 
            nudMinSNRGamma.Location = new Point(445, 107);
            nudMinSNRGamma.Name = "nudMinSNRGamma";
            nudMinSNRGamma.Size = new Size(80, 23);
            nudMinSNRGamma.TabIndex = 51;
            toolTip1.SetToolTip(nudMinSNRGamma, "安定性を改善する\r\nDebiased Estimationを使うなら0にする");
            // 
            // cbxWeightDecomposition
            // 
            cbxWeightDecomposition.AutoSize = true;
            cbxWeightDecomposition.Location = new Point(22, 101);
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
            toolTip1.SetToolTip(cbxHighVRAM, "現時点でlatentのキャッシュのみに影響\r\nlatentキャッシュ中はVRAM消費が徐々に増える");
            cbxHighVRAM.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(17, 146);
            label28.Name = "label28";
            label28.Size = new Size(125, 30);
            label28.TabIndex = 21;
            label28.Text = "LRスケジューラのサイクル/\r\npolynomialの減衰";
            toolTip1.SetToolTip(label28, "polynomialの場合はpowerとして使用される");
            // 
            // nudGradAccSteps
            // 
            nudGradAccSteps.Location = new Point(123, 234);
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
            nudLoRAPlusLRRatio.Location = new Point(101, 16);
            nudLoRAPlusLRRatio.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudLoRAPlusLRRatio.Name = "nudLoRAPlusLRRatio";
            nudLoRAPlusLRRatio.Size = new Size(72, 23);
            nudLoRAPlusLRRatio.TabIndex = 8;
            toolTip1.SetToolTip(nudLoRAPlusLRRatio, "適切に設定すると2倍ほど収束が早くなる\r\nこの項目はUnetとTEの両方のratio\r\n論文では16が推奨されているが実際には4がいい感じ\r\n");
            // 
            // nudLoRAPlusUnetLRRatio
            // 
            nudLoRAPlusUnetLRRatio.Location = new Point(101, 45);
            nudLoRAPlusUnetLRRatio.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudLoRAPlusUnetLRRatio.Name = "nudLoRAPlusUnetLRRatio";
            nudLoRAPlusUnetLRRatio.Size = new Size(72, 23);
            nudLoRAPlusUnetLRRatio.TabIndex = 8;
            toolTip1.SetToolTip(nudLoRAPlusUnetLRRatio, "個別指定時はLoRA+ LR比率を0にすること");
            // 
            // nudLoRAPlusTELRRatio
            // 
            nudLoRAPlusTELRRatio.Location = new Point(101, 74);
            nudLoRAPlusTELRRatio.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudLoRAPlusTELRRatio.Name = "nudLoRAPlusTELRRatio";
            nudLoRAPlusTELRRatio.Size = new Size(72, 23);
            nudLoRAPlusTELRRatio.TabIndex = 8;
            toolTip1.SetToolTip(nudLoRAPlusTELRRatio, "個別指定時はLoRA+ LR比率を0にすること");
            // 
            // tbxWeightDecay
            // 
            tbxWeightDecay.Location = new Point(96, 48);
            tbxWeightDecay.Name = "tbxWeightDecay";
            tbxWeightDecay.Size = new Size(64, 23);
            tbxWeightDecay.TabIndex = 11;
            tbxWeightDecay.Text = "0";
            toolTip1.SetToolTip(tbxWeightDecay, "過学習を抑える設定。高くすると学習が遅くなる");
            // 
            // cbxRandomNoiseOffset
            // 
            cbxRandomNoiseOffset.AutoSize = true;
            cbxRandomNoiseOffset.Location = new Point(531, 21);
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
            cbxRandomIpNoiseGamma.Location = new Point(531, 53);
            cbxRandomIpNoiseGamma.Name = "cbxRandomIpNoiseGamma";
            cbxRandomIpNoiseGamma.Size = new Size(59, 19);
            cbxRandomIpNoiseGamma.TabIndex = 57;
            cbxRandomIpNoiseGamma.Text = "ランダム";
            toolTip1.SetToolTip(cbxRandomIpNoiseGamma, "0から指定した強度の間のランダムな値を適用する");
            cbxRandomIpNoiseGamma.UseVisualStyleBackColor = true;
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
            toolTip1.SetToolTip(cbxLossType, "smooth_l1がScheduled Huber Loss\r\nsmooth_l1はSD3とFLUX.1非対応(エラーになる)");
            // 
            // cbxAlphaMask
            // 
            cbxAlphaMask.AutoSize = true;
            cbxAlphaMask.Location = new Point(138, 140);
            cbxAlphaMask.Name = "cbxAlphaMask";
            cbxAlphaMask.Size = new Size(87, 19);
            cbxAlphaMask.TabIndex = 7;
            cbxAlphaMask.Text = "アルファマスク";
            toolTip1.SetToolTip(cbxAlphaMask, "画像の透過部分を学習させない");
            cbxAlphaMask.UseVisualStyleBackColor = true;
            // 
            // nudHuberC
            // 
            nudHuberC.DecimalPlaces = 4;
            nudHuberC.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudHuberC.Location = new Point(138, 89);
            nudHuberC.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHuberC.Name = "nudHuberC";
            nudHuberC.Size = new Size(120, 23);
            nudHuberC.TabIndex = 5;
            toolTip1.SetToolTip(nudHuberC, "Smooth L1でHuber損失を使用する期間(0～1)");
            nudHuberC.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // nudIpNoiseGamma
            // 
            nudIpNoiseGamma.DecimalPlaces = 4;
            nudIpNoiseGamma.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudIpNoiseGamma.Location = new Point(445, 49);
            nudIpNoiseGamma.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudIpNoiseGamma.Name = "nudIpNoiseGamma";
            nudIpNoiseGamma.Size = new Size(80, 23);
            nudIpNoiseGamma.TabIndex = 49;
            toolTip1.SetToolTip(nudIpNoiseGamma, "正則化にinput perturbation noiseを使用する");
            // 
            // btnSelectVAE
            // 
            btnSelectVAE.Location = new Point(384, 22);
            btnSelectVAE.Name = "btnSelectVAE";
            btnSelectVAE.Size = new Size(64, 30);
            btnSelectVAE.TabIndex = 46;
            btnSelectVAE.Text = "選択";
            toolTip1.SetToolTip(btnSelectVAE, "Autoencoder");
            btnSelectVAE.UseVisualStyleBackColor = true;
            btnSelectVAE.Click += btnSelectVAE_Click;
            // 
            // nudSchedulerTimescale
            // 
            nudSchedulerTimescale.Location = new Point(148, 49);
            nudSchedulerTimescale.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            nudSchedulerTimescale.Name = "nudSchedulerTimescale";
            nudSchedulerTimescale.Size = new Size(99, 23);
            nudSchedulerTimescale.TabIndex = 49;
            toolTip1.SetToolTip(nudSchedulerTimescale, "inverse_sqrtのみ");
            // 
            // nudMinLRRatio
            // 
            nudMinLRRatio.DecimalPlaces = 4;
            nudMinLRRatio.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudMinLRRatio.Location = new Point(148, 115);
            nudMinLRRatio.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMinLRRatio.Name = "nudMinLRRatio";
            nudMinLRRatio.Size = new Size(99, 23);
            nudMinLRRatio.TabIndex = 49;
            toolTip1.SetToolTip(nudMinLRRatio, "cosine_with_min_lrと\r\nwarmup_stable_decayのみ");
            // 
            // nudLRDecaySteps
            // 
            nudLRDecaySteps.DecimalPlaces = 2;
            nudLRDecaySteps.Location = new Point(148, 86);
            nudLRDecaySteps.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            nudLRDecaySteps.Name = "nudLRDecaySteps";
            nudLRDecaySteps.Size = new Size(99, 23);
            nudLRDecaySteps.TabIndex = 49;
            toolTip1.SetToolTip(nudLRDecaySteps, "warmup_stable_decayのみ\r\n数値をn.00でステップ数、少数を.00以外にすると比率になる\r\n");
            // 
            // nudCaptionTagDropout
            // 
            nudCaptionTagDropout.DecimalPlaces = 4;
            nudCaptionTagDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudCaptionTagDropout.Location = new Point(222, 47);
            nudCaptionTagDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCaptionTagDropout.Name = "nudCaptionTagDropout";
            nudCaptionTagDropout.Size = new Size(78, 23);
            nudCaptionTagDropout.TabIndex = 48;
            toolTip1.SetToolTip(nudCaptionTagDropout, "キャプションドロップアウト時、\r\nタグ(コンマ区切り)の切り落としの発生率");
            // 
            // cbxDisableMmapLoadSafetensors
            // 
            cbxDisableMmapLoadSafetensors.AutoSize = true;
            cbxDisableMmapLoadSafetensors.Location = new Point(311, 224);
            cbxDisableMmapLoadSafetensors.Name = "cbxDisableMmapLoadSafetensors";
            cbxDisableMmapLoadSafetensors.Size = new Size(234, 19);
            cbxDisableMmapLoadSafetensors.TabIndex = 44;
            cbxDisableMmapLoadSafetensors.Text = "safetensors読込のメモリマッピングの無効化";
            toolTip1.SetToolTip(cbxDisableMmapLoadSafetensors, "safetensorsファイルの読込が少し早くなる");
            cbxDisableMmapLoadSafetensors.UseVisualStyleBackColor = true;
            // 
            // cbxVParameterization
            // 
            cbxVParameterization.AutoSize = true;
            cbxVParameterization.Location = new Point(138, 163);
            cbxVParameterization.Name = "cbxVParameterization";
            cbxVParameterization.Size = new Size(125, 19);
            cbxVParameterization.TabIndex = 58;
            cbxVParameterization.Text = "v-parameterization";
            toolTip1.SetToolTip(cbxVParameterization, "ノイズ予測にv-prediction(デノイズ前後の差分の予測)を使う\r\n学習元モデルが使用を明記している場合のみチェックをつける");
            cbxVParameterization.UseVisualStyleBackColor = true;
            // 
            // cbxZeroTerminalSNR
            // 
            cbxZeroTerminalSNR.AutoSize = true;
            cbxZeroTerminalSNR.Location = new Point(138, 188);
            cbxZeroTerminalSNR.Name = "cbxZeroTerminalSNR";
            cbxZeroTerminalSNR.Size = new Size(122, 19);
            cbxZeroTerminalSNR.TabIndex = 58;
            cbxZeroTerminalSNR.Text = "Zero Terminal SNR";
            toolTip1.SetToolTip(cbxZeroTerminalSNR, "ノイズスケジューラーの問題を修正して\r\n全体が明るい/暗い状況でグレー寄りになるのを防ぐ\r\n出力が不安定になりやすい(おそらくNoobAI-XL特有の問題)");
            cbxZeroTerminalSNR.UseVisualStyleBackColor = true;
            // 
            // cbxUseAdditionalOptArgs
            // 
            cbxUseAdditionalOptArgs.AutoSize = true;
            cbxUseAdditionalOptArgs.Location = new Point(12, 13);
            cbxUseAdditionalOptArgs.Name = "cbxUseAdditionalOptArgs";
            cbxUseAdditionalOptArgs.Size = new Size(239, 19);
            cbxUseAdditionalOptArgs.TabIndex = 26;
            cbxUseAdditionalOptArgs.Text = "一部Optimizerに追加のパラメータを指定する";
            toolTip1.SetToolTip(cbxUseAdditionalOptArgs, "DAdaptationは常に指定される");
            cbxUseAdditionalOptArgs.UseVisualStyleBackColor = true;
            // 
            // nudMultiresNoiseIterations
            // 
            nudMultiresNoiseIterations.Location = new Point(445, 136);
            nudMultiresNoiseIterations.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMultiresNoiseIterations.Name = "nudMultiresNoiseIterations";
            nudMultiresNoiseIterations.Size = new Size(80, 23);
            nudMultiresNoiseIterations.TabIndex = 53;
            toolTip1.SetToolTip(nudMultiresNoiseIterations, "Zero Terminal SNRを使うなら0にする");
            // 
            // nudMultiresNoiseDiscount
            // 
            nudMultiresNoiseDiscount.DecimalPlaces = 4;
            nudMultiresNoiseDiscount.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudMultiresNoiseDiscount.Location = new Point(445, 165);
            nudMultiresNoiseDiscount.Name = "nudMultiresNoiseDiscount";
            nudMultiresNoiseDiscount.Size = new Size(80, 23);
            nudMultiresNoiseDiscount.TabIndex = 55;
            toolTip1.SetToolTip(nudMultiresNoiseDiscount, "Zero Terminal SNRを使うなら0にする");
            // 
            // cbxDebiasedEstimation
            // 
            cbxDebiasedEstimation.AutoSize = true;
            cbxDebiasedEstimation.Location = new Point(138, 213);
            cbxDebiasedEstimation.Name = "cbxDebiasedEstimation";
            cbxDebiasedEstimation.Size = new Size(132, 19);
            cbxDebiasedEstimation.TabIndex = 58;
            cbxDebiasedEstimation.Text = "Debiased Estimation";
            toolTip1.SetToolTip(cbxDebiasedEstimation, "色ずれを軽減する\r\n安定性も改善する");
            cbxDebiasedEstimation.UseVisualStyleBackColor = true;
            // 
            // nudMaxTokensT5
            // 
            nudMaxTokensT5.Increment = new decimal(new int[] { 64, 0, 0, 0 });
            nudMaxTokensT5.Location = new Point(144, 123);
            nudMaxTokensT5.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudMaxTokensT5.Minimum = new decimal(new int[] { 64, 0, 0, 0 });
            nudMaxTokensT5.Name = "nudMaxTokensT5";
            nudMaxTokensT5.Size = new Size(92, 23);
            nudMaxTokensT5.TabIndex = 17;
            toolTip1.SetToolTip(nudMaxTokensT5, "SD3とFLUX.1専用");
            nudMaxTokensT5.Value = new decimal(new int[] { 256, 0, 0, 0 });
            // 
            // cbxResizeInterpolation
            // 
            cbxResizeInterpolation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxResizeInterpolation.FormattingEnabled = true;
            cbxResizeInterpolation.Items.AddRange(new object[] { "未指定(area)", "bicubic", "bilinear", "nearest", "lanczos" });
            cbxResizeInterpolation.Location = new Point(305, 20);
            cbxResizeInterpolation.Name = "cbxResizeInterpolation";
            cbxResizeInterpolation.Size = new Size(95, 23);
            cbxResizeInterpolation.TabIndex = 26;
            toolTip1.SetToolTip(cbxResizeInterpolation, "画像を学習解像度にリサイズする方法\r\n2025/04/03時点でsd3ブランチ専用。\r\nmainやdevで未指定以外にするとエラー落ち");
            // 
            // nudScaleWeightNorms
            // 
            nudScaleWeightNorms.DecimalPlaces = 4;
            nudScaleWeightNorms.Location = new Point(445, 194);
            nudScaleWeightNorms.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudScaleWeightNorms.Name = "nudScaleWeightNorms";
            nudScaleWeightNorms.Size = new Size(80, 23);
            nudScaleWeightNorms.TabIndex = 51;
            toolTip1.SetToolTip(nudScaleWeightNorms, "Max Norm Regularizationのこと");
            // 
            // cbxAdvancedTrain
            // 
            cbxAdvancedTrain.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAdvancedTrain.FormattingEnabled = true;
            cbxAdvancedTrain.Items.AddRange(new object[] { "両方学習", "TEのみ学習", "UNetのみ学習" });
            cbxAdvancedTrain.Location = new Point(119, 73);
            cbxAdvancedTrain.Name = "cbxAdvancedTrain";
            cbxAdvancedTrain.Size = new Size(102, 23);
            cbxAdvancedTrain.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 51);
            label6.Name = "label6";
            label6.Size = new Size(61, 30);
            label6.TabIndex = 16;
            label6.Text = "Seed\r\n-1でランダム";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 113);
            label9.Name = "label9";
            label9.Size = new Size(102, 30);
            label9.TabIndex = 20;
            label9.Text = "キャプションファイルの\r\n拡張子";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F);
            button1.Location = new Point(505, 386);
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
            nudMinBucketReso.Location = new Point(120, 22);
            nudMinBucketReso.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudMinBucketReso.Minimum = new decimal(new int[] { 64, 0, 0, 0 });
            nudMinBucketReso.Name = "nudMinBucketReso";
            nudMinBucketReso.Size = new Size(72, 23);
            nudMinBucketReso.TabIndex = 24;
            nudMinBucketReso.Value = new decimal(new int[] { 320, 0, 0, 0 });
            nudMinBucketReso.ValueChanged += nudMinBucketReso_ValueChanged;
            // 
            // nudMaxBucketReso
            // 
            nudMaxBucketReso.Increment = new decimal(new int[] { 64, 0, 0, 0 });
            nudMaxBucketReso.Location = new Point(120, 53);
            nudMaxBucketReso.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            nudMaxBucketReso.Minimum = new decimal(new int[] { 128, 0, 0, 0 });
            nudMaxBucketReso.Name = "nudMaxBucketReso";
            nudMaxBucketReso.Size = new Size(72, 23);
            nudMaxBucketReso.TabIndex = 25;
            nudMaxBucketReso.Value = new decimal(new int[] { 960, 0, 0, 0 });
            nudMaxBucketReso.ValueChanged += nudMaxBucketReso_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(67, 21);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 26;
            label10.Text = "LRスケジューラ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 84);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 30;
            label11.Text = "保存時の精度";
            // 
            // btnDiscardAndClose
            // 
            btnDiscardAndClose.Font = new Font("Yu Gothic UI", 11F);
            btnDiscardAndClose.Location = new Point(330, 386);
            btnDiscardAndClose.Name = "btnDiscardAndClose";
            btnDiscardAndClose.Size = new Size(165, 31);
            btnDiscardAndClose.TabIndex = 31;
            btnDiscardAndClose.Text = "設定を反映せずに閉じる";
            btnDiscardAndClose.UseVisualStyleBackColor = true;
            btnDiscardAndClose.Click += btnDiscardAndClose_Click;
            // 
            // btnTensorBoardPath
            // 
            btnTensorBoardPath.Location = new Point(112, 97);
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
            label12.Location = new Point(27, 97);
            label12.Name = "label12";
            label12.Size = new Size(84, 30);
            label12.TabIndex = 33;
            label12.Text = "Tensorboard用\r\nログ出力先";
            // 
            // lblTBoardPath
            // 
            lblTBoardPath.Font = new Font("Yu Gothic UI", 8F);
            lblTBoardPath.Location = new Point(27, 139);
            lblTBoardPath.Name = "lblTBoardPath";
            lblTBoardPath.Size = new Size(240, 32);
            lblTBoardPath.TabIndex = 34;
            lblTBoardPath.Text = "very very long name";
            // 
            // btnClearTBoardPath
            // 
            btnClearTBoardPath.Location = new Point(182, 97);
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
            label13.Location = new Point(28, 76);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 37;
            label13.Text = "UNet/TEの学習";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 104);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 40;
            label4.Text = "Cross-Attentionの最適化";
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
            lblLoRAmodelPath.Font = new Font("Yu Gothic UI", 8F);
            lblLoRAmodelPath.Location = new Point(27, 58);
            lblLoRAmodelPath.Name = "lblLoRAmodelPath";
            lblLoRAmodelPath.Size = new Size(240, 36);
            lblLoRAmodelPath.TabIndex = 43;
            lblLoRAmodelPath.Text = "very very long name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(356, 22);
            label14.Name = "label14";
            label14.Size = new Size(83, 15);
            label14.TabIndex = 45;
            label14.Text = "ノイズオフセット#";
            // 
            // btnClearVAE
            // 
            btnClearVAE.Location = new Point(454, 22);
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
            label16.Location = new Point(331, 30);
            label16.Name = "label16";
            label16.Size = new Size(47, 15);
            label16.TabIndex = 47;
            label16.Text = "VAE/AE";
            // 
            // lblVAEPath
            // 
            lblVAEPath.Font = new Font("Yu Gothic UI", 8F);
            lblVAEPath.Location = new Point(310, 59);
            lblVAEPath.Name = "lblVAEPath";
            lblVAEPath.Size = new Size(240, 35);
            lblVAEPath.TabIndex = 43;
            lblVAEPath.Text = "very very long name";
            // 
            // nudAdaptiveNoiseScale
            // 
            nudAdaptiveNoiseScale.DecimalPlaces = 4;
            nudAdaptiveNoiseScale.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudAdaptiveNoiseScale.Location = new Point(445, 78);
            nudAdaptiveNoiseScale.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudAdaptiveNoiseScale.Name = "nudAdaptiveNoiseScale";
            nudAdaptiveNoiseScale.Size = new Size(80, 23);
            nudAdaptiveNoiseScale.TabIndex = 49;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(318, 80);
            label17.Name = "label17";
            label17.Size = new Size(121, 15);
            label17.TabIndex = 50;
            label17.Text = "Adaptive noise scale#";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(334, 109);
            label18.Name = "label18";
            label18.Size = new Size(105, 15);
            label18.TabIndex = 52;
            label18.Text = "Min-SNR Gamma#";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(297, 138);
            label19.Name = "label19";
            label19.Size = new Size(142, 15);
            label19.TabIndex = 54;
            label19.Text = "Multires Noise Iterations#";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(299, 167);
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
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(pageMisc);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(668, 365);
            tabControl1.TabIndex = 57;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox8);
            tabPage1.Controls.Add(groupBox7);
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(nudDyLoRAUnit);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(660, 337);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ページ1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(tbxUnetLR);
            groupBox8.Controls.Add(label13);
            groupBox8.Controls.Add(cbxAdvancedTrain);
            groupBox8.Controls.Add(label2);
            groupBox8.Controls.Add(label1);
            groupBox8.Controls.Add(tbxTextEncoLR);
            groupBox8.Location = new Point(6, 6);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(232, 112);
            groupBox8.TabIndex = 42;
            groupBox8.TabStop = false;
            groupBox8.Text = "U-Net/Text Encoder";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(nudConvDim);
            groupBox7.Controls.Add(label24);
            groupBox7.Controls.Add(label25);
            groupBox7.Controls.Add(nudConvAlpha);
            groupBox7.Controls.Add(cbxUseConv2d);
            groupBox7.Location = new Point(6, 124);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(232, 113);
            groupBox7.TabIndex = 41;
            groupBox7.TabStop = false;
            groupBox7.Text = "畳み込み層(Conv)";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(14, 74);
            label24.Name = "label24";
            label24.Size = new Size(68, 15);
            label24.TabIndex = 16;
            label24.Text = "Conv Alpha";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(22, 48);
            label25.Name = "label25";
            label25.Size = new Size(58, 15);
            label25.TabIndex = 15;
            label25.Text = "Conv Dim";
            // 
            // nudConvAlpha
            // 
            nudConvAlpha.DecimalPlaces = 4;
            nudConvAlpha.Location = new Point(86, 72);
            nudConvAlpha.Maximum = new decimal(new int[] { 1280, 0, 0, 0 });
            nudConvAlpha.Name = "nudConvAlpha";
            nudConvAlpha.Size = new Size(72, 23);
            nudConvAlpha.TabIndex = 19;
            nudConvAlpha.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label45);
            groupBox6.Controls.Add(cbxResizeInterpolation);
            groupBox6.Controls.Add(nudMinBucketReso);
            groupBox6.Controls.Add(nudMaxBucketReso);
            groupBox6.Controls.Add(cbxNoUpscale);
            groupBox6.Controls.Add(lblMaxBucketReso);
            groupBox6.Controls.Add(lblMinBucketReso);
            groupBox6.Location = new Point(248, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(406, 112);
            groupBox6.TabIndex = 40;
            groupBox6.TabStop = false;
            groupBox6.Text = "Aspect Ratio Bucketing";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.BackColor = Color.Transparent;
            label45.Font = new Font("Yu Gothic UI", 9F);
            label45.Location = new Point(200, 23);
            label45.Name = "label45";
            label45.Size = new Size(101, 15);
            label45.TabIndex = 27;
            label45.Text = "画像リサイズの方法";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbxFlipAug);
            groupBox5.Controls.Add(cbxUseColorAug);
            groupBox5.Controls.Add(cbxCropRandomly);
            groupBox5.Location = new Point(248, 124);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(188, 113);
            groupBox5.TabIndex = 39;
            groupBox5.TabStop = false;
            groupBox5.Text = "augmentation";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(nudLoRAPlusLRRatio);
            groupBox4.Controls.Add(label53);
            groupBox4.Controls.Add(nudLoRAPlusTELRRatio);
            groupBox4.Controls.Add(label52);
            groupBox4.Controls.Add(label54);
            groupBox4.Controls.Add(nudLoRAPlusUnetLRRatio);
            groupBox4.Location = new Point(448, 124);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(206, 113);
            groupBox4.TabIndex = 38;
            groupBox4.TabStop = false;
            groupBox4.Text = "LoRA+";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Location = new Point(29, 76);
            label53.Name = "label53";
            label53.Size = new Size(66, 15);
            label53.TabIndex = 6;
            label53.Text = "TE LR比率#";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Location = new Point(14, 47);
            label52.Name = "label52";
            label52.Size = new Size(81, 15);
            label52.TabIndex = 6;
            label52.Text = "UNet LR比率#";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Location = new Point(44, 21);
            label54.Name = "label54";
            label54.Size = new Size(51, 15);
            label54.TabIndex = 7;
            label54.Text = "LR比率#";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(8, 274);
            label22.Name = "label22";
            label22.Size = new Size(80, 15);
            label22.TabIndex = 22;
            label22.Text = "DyLoRAのunit";
            // 
            // nudDyLoRAUnit
            // 
            nudDyLoRAUnit.Location = new Point(92, 271);
            nudDyLoRAUnit.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudDyLoRAUnit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDyLoRAUnit.Name = "nudDyLoRAUnit";
            nudDyLoRAUnit.Size = new Size(72, 23);
            nudDyLoRAUnit.TabIndex = 21;
            nudDyLoRAUnit.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label71);
            tabPage4.Controls.Add(label76);
            tabPage4.Controls.Add(label70);
            tabPage4.Controls.Add(nudT5DropoutRate);
            tabPage4.Controls.Add(nudClipGDropoutRate);
            tabPage4.Controls.Add(nudCaptionTagDropout);
            tabPage4.Controls.Add(label44);
            tabPage4.Controls.Add(label38);
            tabPage4.Controls.Add(label75);
            tabPage4.Controls.Add(label37);
            tabPage4.Controls.Add(label74);
            tabPage4.Controls.Add(label36);
            tabPage4.Controls.Add(nudNetworkDropout);
            tabPage4.Controls.Add(nudModuleDropout);
            tabPage4.Controls.Add(numericUpDown2);
            tabPage4.Controls.Add(nudRankDropout);
            tabPage4.Controls.Add(nudClipLDropoutRate);
            tabPage4.Controls.Add(nudCaptionDropout);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(660, 335);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "dropout";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Location = new Point(334, 78);
            label71.Name = "label71";
            label71.Size = new Size(130, 15);
            label71.TabIndex = 49;
            label71.Text = "T5XXLドロップアウト確率#";
            // 
            // label76
            // 
            label76.AutoSize = true;
            label76.Location = new Point(334, 51);
            label76.Name = "label76";
            label76.Size = new Size(132, 15);
            label76.TabIndex = 49;
            label76.Text = "CLIP Gドロップアウト確率#";
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Location = new Point(58, 49);
            label70.Name = "label70";
            label70.Size = new Size(158, 15);
            label70.TabIndex = 49;
            label70.Text = "caption tagドロップアウト確率#";
            // 
            // nudT5DropoutRate
            // 
            nudT5DropoutRate.DecimalPlaces = 4;
            nudT5DropoutRate.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudT5DropoutRate.Location = new Point(472, 76);
            nudT5DropoutRate.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudT5DropoutRate.Name = "nudT5DropoutRate";
            nudT5DropoutRate.Size = new Size(78, 23);
            nudT5DropoutRate.TabIndex = 48;
            // 
            // nudClipGDropoutRate
            // 
            nudClipGDropoutRate.DecimalPlaces = 4;
            nudClipGDropoutRate.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudClipGDropoutRate.Location = new Point(472, 49);
            nudClipGDropoutRate.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudClipGDropoutRate.Name = "nudClipGDropoutRate";
            nudClipGDropoutRate.Size = new Size(78, 23);
            nudClipGDropoutRate.TabIndex = 48;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(73, 135);
            label44.Name = "label44";
            label44.Size = new Size(141, 15);
            label44.TabIndex = 25;
            label44.Text = "networkドロップアウト確率#";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(78, 105);
            label38.Name = "label38";
            label38.Size = new Size(138, 15);
            label38.TabIndex = 25;
            label38.Text = "moduleドロップアウト確率#";
            // 
            // label75
            // 
            label75.AutoSize = true;
            label75.Location = new Point(95, 164);
            label75.Name = "label75";
            label75.Size = new Size(121, 15);
            label75.TabIndex = 25;
            label75.Text = "rankドロップアウト確率#";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(95, 76);
            label37.Name = "label37";
            label37.Size = new Size(121, 15);
            label37.TabIndex = 25;
            label37.Text = "rankドロップアウト確率#";
            // 
            // label74
            // 
            label74.AutoSize = true;
            label74.Location = new Point(336, 21);
            label74.Name = "label74";
            label74.Size = new Size(130, 15);
            label74.TabIndex = 25;
            label74.Text = "CLIP Lドロップアウト確率#";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(77, 21);
            label36.Name = "label36";
            label36.Size = new Size(138, 15);
            label36.TabIndex = 25;
            label36.Text = "captionドロップアウト確率#";
            // 
            // nudNetworkDropout
            // 
            nudNetworkDropout.DecimalPlaces = 4;
            nudNetworkDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudNetworkDropout.Location = new Point(222, 133);
            nudNetworkDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNetworkDropout.Name = "nudNetworkDropout";
            nudNetworkDropout.Size = new Size(78, 23);
            nudNetworkDropout.TabIndex = 24;
            // 
            // nudModuleDropout
            // 
            nudModuleDropout.DecimalPlaces = 4;
            nudModuleDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudModuleDropout.Location = new Point(222, 103);
            nudModuleDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudModuleDropout.Name = "nudModuleDropout";
            nudModuleDropout.Size = new Size(78, 23);
            nudModuleDropout.TabIndex = 24;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 4;
            numericUpDown2.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown2.Location = new Point(222, 162);
            numericUpDown2.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(78, 23);
            numericUpDown2.TabIndex = 24;
            // 
            // nudRankDropout
            // 
            nudRankDropout.DecimalPlaces = 4;
            nudRankDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudRankDropout.Location = new Point(222, 74);
            nudRankDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRankDropout.Name = "nudRankDropout";
            nudRankDropout.Size = new Size(78, 23);
            nudRankDropout.TabIndex = 24;
            // 
            // nudClipLDropoutRate
            // 
            nudClipLDropoutRate.DecimalPlaces = 4;
            nudClipLDropoutRate.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudClipLDropoutRate.Location = new Point(472, 19);
            nudClipLDropoutRate.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudClipLDropoutRate.Name = "nudClipLDropoutRate";
            nudClipLDropoutRate.Size = new Size(78, 23);
            nudClipLDropoutRate.TabIndex = 24;
            // 
            // page3
            // 
            page3.Controls.Add(cbxDebiasedEstimation);
            page3.Controls.Add(cbxZeroTerminalSNR);
            page3.Controls.Add(cbxVParameterization);
            page3.Controls.Add(cbxRandomIpNoiseGamma);
            page3.Controls.Add(cbxRandomNoiseOffset);
            page3.Controls.Add(cbxAlphaMask);
            page3.Controls.Add(label20);
            page3.Controls.Add(cbxMaskLoss);
            page3.Controls.Add(nudHuberC);
            page3.Controls.Add(label50);
            page3.Controls.Add(nudNoiseOffset);
            page3.Controls.Add(label8);
            page3.Controls.Add(label18);
            page3.Controls.Add(cbxHuberSchedule);
            page3.Controls.Add(label14);
            page3.Controls.Add(label49);
            page3.Controls.Add(nudScaleWeightNorms);
            page3.Controls.Add(nudMinSNRGamma);
            page3.Controls.Add(cbxLossType);
            page3.Controls.Add(label19);
            page3.Controls.Add(label48);
            page3.Controls.Add(nudMultiresNoiseDiscount);
            page3.Controls.Add(nudAdaptiveNoiseScale);
            page3.Controls.Add(nudMultiresNoiseIterations);
            page3.Controls.Add(label57);
            page3.Controls.Add(label17);
            page3.Controls.Add(nudIpNoiseGamma);
            page3.Location = new Point(4, 26);
            page3.Name = "page3";
            page3.Size = new Size(660, 335);
            page3.TabIndex = 10;
            page3.Text = "損失とノイズ";
            page3.UseVisualStyleBackColor = true;
            // 
            // cbxMaskLoss
            // 
            cbxMaskLoss.AutoSize = true;
            cbxMaskLoss.Location = new Point(138, 118);
            cbxMaskLoss.Name = "cbxMaskLoss";
            cbxMaskLoss.Size = new Size(80, 19);
            cbxMaskLoss.TabIndex = 7;
            cbxMaskLoss.Text = "Mask Loss";
            cbxMaskLoss.UseVisualStyleBackColor = true;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(319, 196);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 52;
            label8.Text = "Scale Weight Norms#";
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
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(43, 20);
            label48.Name = "label48";
            label48.Size = new Size(89, 15);
            label48.TabIndex = 0;
            label48.Text = "損失関数の種類";
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Location = new Point(339, 54);
            label57.Name = "label57";
            label57.Size = new Size(100, 15);
            label57.TabIndex = 50;
            label57.Text = "Ip Noise Gamma#";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label69);
            tabPage6.Controls.Add(label66);
            tabPage6.Controls.Add(cbxScheduler);
            tabPage6.Controls.Add(label10);
            tabPage6.Controls.Add(nudLRSchedulerCycle);
            tabPage6.Controls.Add(label28);
            tabPage6.Controls.Add(nudLRDecaySteps);
            tabPage6.Controls.Add(nudMinLRRatio);
            tabPage6.Controls.Add(nudSchedulerTimescale);
            tabPage6.Controls.Add(label47);
            tabPage6.Location = new Point(4, 26);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(660, 335);
            tabPage6.TabIndex = 13;
            tabPage6.Text = "スケジューラ";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Location = new Point(15, 88);
            label69.Name = "label69";
            label69.Size = new Size(127, 15);
            label69.TabIndex = 50;
            label69.Text = "LR減衰ステップ数/比率#";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Location = new Point(67, 117);
            label66.Name = "label66";
            label66.Size = new Size(75, 15);
            label66.TabIndex = 50;
            label66.Text = "最小LR比率#";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(65, 51);
            label47.Name = "label47";
            label47.Size = new Size(77, 30);
            label47.TabIndex = 50;
            label47.Text = "スケジューラの\r\nタイムスケール#";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(cbxDisableMmapLoadSafetensors);
            tabPage7.Controls.Add(cbxCacheTextencoderToDisk);
            tabPage7.Controls.Add(label51);
            tabPage7.Controls.Add(cbxUseFP8);
            tabPage7.Controls.Add(cbxCacheTextEncoder);
            tabPage7.Controls.Add(nudGradAccSteps);
            tabPage7.Controls.Add(cbxNoHalfVae);
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
            tabPage7.Size = new Size(660, 335);
            tabPage7.TabIndex = 8;
            tabPage7.Text = "パフォーマンス";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // cbxCacheTextencoderToDisk
            // 
            cbxCacheTextencoderToDisk.AutoSize = true;
            cbxCacheTextencoderToDisk.Location = new Point(311, 199);
            cbxCacheTextencoderToDisk.Name = "cbxCacheTextencoderToDisk";
            cbxCacheTextencoderToDisk.Size = new Size(222, 19);
            cbxCacheTextencoderToDisk.TabIndex = 18;
            cbxCacheTextencoderToDisk.Text = "Text Encoderの出力をディスクにキャッシュ";
            cbxCacheTextencoderToDisk.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new Point(38, 234);
            label51.Name = "label51";
            label51.Size = new Size(79, 45);
            label51.TabIndex = 9;
            label51.Text = "gradient\r\naccumulation\r\nsteps";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(311, 66);
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
            tabPage5.Controls.Add(groupBox3);
            tabPage5.Controls.Add(label65);
            tabPage5.Controls.Add(btnShowTipsAboutOpts);
            tabPage5.Controls.Add(cbxUseAdditionalOptArgs);
            tabPage5.Controls.Add(label43);
            tabPage5.Controls.Add(label42);
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
            tabPage5.Controls.Add(tbxEps1);
            tabPage5.Controls.Add(tbxEps);
            tabPage5.Controls.Add(label35);
            tabPage5.Controls.Add(tbxD0);
            tabPage5.Controls.Add(tbxGrowthRate);
            tabPage5.Location = new Point(4, 26);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(660, 335);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "オプティマイザ";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbxDecouple);
            groupBox3.Controls.Add(cbxUseBiasCorrection);
            groupBox3.Controls.Add(cbxUseSafeguard);
            groupBox3.Location = new Point(27, 188);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 47;
            groupBox3.TabStop = false;
            groupBox3.Text = "Prodigy";
            // 
            // cbxDecouple
            // 
            cbxDecouple.AutoSize = true;
            cbxDecouple.Location = new Point(12, 22);
            cbxDecouple.Name = "cbxDecouple";
            cbxDecouple.Size = new Size(75, 19);
            cbxDecouple.TabIndex = 24;
            cbxDecouple.Text = "decouple";
            cbxDecouple.UseVisualStyleBackColor = true;
            // 
            // cbxUseBiasCorrection
            // 
            cbxUseBiasCorrection.AutoSize = true;
            cbxUseBiasCorrection.Location = new Point(12, 47);
            cbxUseBiasCorrection.Name = "cbxUseBiasCorrection";
            cbxUseBiasCorrection.Size = new Size(104, 19);
            cbxUseBiasCorrection.TabIndex = 24;
            cbxUseBiasCorrection.Text = "bias correction";
            cbxUseBiasCorrection.UseVisualStyleBackColor = true;
            // 
            // cbxUseSafeguard
            // 
            cbxUseSafeguard.AutoSize = true;
            cbxUseSafeguard.Location = new Point(12, 72);
            cbxUseSafeguard.Name = "cbxUseSafeguard";
            cbxUseSafeguard.Size = new Size(124, 19);
            cbxUseSafeguard.TabIndex = 24;
            cbxUseSafeguard.Text = "safeguard warmup";
            cbxUseSafeguard.UseVisualStyleBackColor = true;
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.Font = new Font("Yu Gothic UI", 8F);
            label65.Location = new Point(163, 61);
            label65.Name = "label65";
            label65.Size = new Size(67, 13);
            label65.TabIndex = 46;
            label65.Text = "↓CAMEのみ";
            // 
            // btnShowTipsAboutOpts
            // 
            btnShowTipsAboutOpts.Location = new Point(254, 8);
            btnShowTipsAboutOpts.Name = "btnShowTipsAboutOpts";
            btnShowTipsAboutOpts.Size = new Size(195, 26);
            btnShowTipsAboutOpts.TabIndex = 27;
            btnShowTipsAboutOpts.Text = "AdamWとLionに関するヒントを表示";
            btnShowTipsAboutOpts.UseVisualStyleBackColor = true;
            btnShowTipsAboutOpts.Click += btnShowTipsAboutOpts_Click;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(490, 98);
            label43.Name = "label43";
            label43.Size = new Size(77, 30);
            label43.TabIndex = 25;
            label43.Text = "d_coef\r\n(prodigyのみ)";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(490, 54);
            label42.Name = "label42";
            label42.Size = new Size(77, 30);
            label42.TabIndex = 25;
            label42.Text = "beta3#\r\n(prodigyのみ)";
            // 
            // tbxMomentum
            // 
            tbxMomentum.Location = new Point(307, 80);
            tbxMomentum.Name = "tbxMomentum";
            tbxMomentum.Size = new Size(55, 23);
            tbxMomentum.TabIndex = 10;
            tbxMomentum.Text = "0";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(233, 81);
            label30.Name = "label30";
            label30.Size = new Size(68, 15);
            label30.TabIndex = 18;
            label30.Text = "momentum";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(20, 139);
            label31.Name = "label31";
            label31.Size = new Size(70, 30);
            label31.TabIndex = 19;
            label31.Text = "growth_rate\r\n0で無制限";
            // 
            // tbxBetas0
            // 
            tbxBetas0.Location = new Point(307, 51);
            tbxBetas0.Name = "tbxBetas0";
            tbxBetas0.Size = new Size(55, 23);
            tbxBetas0.TabIndex = 12;
            tbxBetas0.Text = "0.9";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(70, 110);
            label32.Name = "label32";
            label32.Size = new Size(20, 15);
            label32.TabIndex = 20;
            label32.Text = "d0";
            // 
            // tbxBetas1
            // 
            tbxBetas1.Location = new Point(368, 51);
            tbxBetas1.Name = "tbxBetas1";
            tbxBetas1.Size = new Size(55, 23);
            tbxBetas1.TabIndex = 13;
            tbxBetas1.Text = "0.999";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(65, 81);
            label33.Name = "label33";
            label33.Size = new Size(25, 15);
            label33.TabIndex = 21;
            label33.Text = "eps";
            // 
            // tbxDCoef
            // 
            tbxDCoef.Location = new Point(573, 95);
            tbxDCoef.Name = "tbxDCoef";
            tbxDCoef.Size = new Size(55, 23);
            tbxDCoef.TabIndex = 14;
            tbxDCoef.Text = "1";
            // 
            // tbxProdigyBeta3
            // 
            tbxProdigyBeta3.Location = new Point(573, 51);
            tbxProdigyBeta3.Name = "tbxProdigyBeta3";
            tbxProdigyBeta3.Size = new Size(55, 23);
            tbxProdigyBeta3.TabIndex = 14;
            tbxProdigyBeta3.Text = "0";
            // 
            // tbxBetas2
            // 
            tbxBetas2.Location = new Point(429, 51);
            tbxBetas2.Name = "tbxBetas2";
            tbxBetas2.Size = new Size(55, 23);
            tbxBetas2.TabIndex = 14;
            tbxBetas2.Text = "0.999";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(266, 54);
            label34.Name = "label34";
            label34.Size = new Size(35, 15);
            label34.TabIndex = 22;
            label34.Text = "betas";
            // 
            // tbxEps1
            // 
            tbxEps1.Location = new Point(163, 78);
            tbxEps1.Name = "tbxEps1";
            tbxEps1.Size = new Size(64, 23);
            tbxEps1.TabIndex = 15;
            tbxEps1.Text = "1E-16";
            // 
            // tbxEps
            // 
            tbxEps.Location = new Point(96, 78);
            tbxEps.Name = "tbxEps";
            tbxEps.Size = new Size(64, 23);
            tbxEps.TabIndex = 15;
            tbxEps.Text = "1E-06";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(11, 51);
            label35.Name = "label35";
            label35.Size = new Size(79, 15);
            label35.TabIndex = 23;
            label35.Text = "weight_decay";
            // 
            // tbxD0
            // 
            tbxD0.Location = new Point(96, 107);
            tbxD0.Name = "tbxD0";
            tbxD0.Size = new Size(64, 23);
            tbxD0.TabIndex = 16;
            tbxD0.Text = "1E-06";
            // 
            // tbxGrowthRate
            // 
            tbxGrowthRate.Location = new Point(96, 136);
            tbxGrowthRate.Name = "tbxGrowthRate";
            tbxGrowthRate.Size = new Size(64, 23);
            tbxGrowthRate.TabIndex = 17;
            tbxGrowthRate.Text = "0";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnClearClipGPath);
            tabPage2.Controls.Add(btnClipGPath);
            tabPage2.Controls.Add(label72);
            tabPage2.Controls.Add(label67);
            tabPage2.Controls.Add(btnClearT5XXLPath);
            tabPage2.Controls.Add(btnClearClipLPath);
            tabPage2.Controls.Add(btnT5XXLPath);
            tabPage2.Controls.Add(btnClipLPath);
            tabPage2.Controls.Add(lblConfigPath);
            tabPage2.Controls.Add(lblVAEPath);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(btnClearTBoardPath);
            tabPage2.Controls.Add(btnClearConfigPath);
            tabPage2.Controls.Add(btnSelectLoRAmodel);
            tabPage2.Controls.Add(lblT5XXLPath);
            tabPage2.Controls.Add(btnSelectConfigPath);
            tabPage2.Controls.Add(lblClipGPath);
            tabPage2.Controls.Add(lblClipLPath);
            tabPage2.Controls.Add(lblTBoardPath);
            tabPage2.Controls.Add(label68);
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
            tabPage2.Size = new Size(660, 335);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "パス";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearClipGPath
            // 
            btnClearClipGPath.Location = new Point(182, 248);
            btnClearClipGPath.Name = "btnClearClipGPath";
            btnClearClipGPath.Size = new Size(64, 30);
            btnClearClipGPath.TabIndex = 51;
            btnClearClipGPath.Text = "クリア";
            btnClearClipGPath.UseVisualStyleBackColor = true;
            btnClearClipGPath.Click += btnClearClipGPath_Click;
            // 
            // btnClipGPath
            // 
            btnClipGPath.Location = new Point(112, 248);
            btnClipGPath.Name = "btnClipGPath";
            btnClipGPath.Size = new Size(64, 30);
            btnClipGPath.TabIndex = 51;
            btnClipGPath.Text = "選択";
            btnClipGPath.UseVisualStyleBackColor = true;
            btnClipGPath.Click += btnClipGPath_Click;
            // 
            // label72
            // 
            label72.AutoSize = true;
            label72.Location = new Point(67, 256);
            label72.Name = "label72";
            label72.Size = new Size(41, 15);
            label72.TabIndex = 50;
            label72.Text = "CLIP G";
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Location = new Point(67, 186);
            label67.Name = "label67";
            label67.Size = new Size(39, 15);
            label67.TabIndex = 50;
            label67.Text = "CLIP L";
            // 
            // btnClearT5XXLPath
            // 
            btnClearT5XXLPath.Location = new Point(454, 178);
            btnClearT5XXLPath.Name = "btnClearT5XXLPath";
            btnClearT5XXLPath.Size = new Size(64, 30);
            btnClearT5XXLPath.TabIndex = 48;
            btnClearT5XXLPath.Text = "クリア";
            btnClearT5XXLPath.UseVisualStyleBackColor = true;
            btnClearT5XXLPath.Click += btnClearT5XXLPath_Click;
            // 
            // btnClearClipLPath
            // 
            btnClearClipLPath.Location = new Point(182, 178);
            btnClearClipLPath.Name = "btnClearClipLPath";
            btnClearClipLPath.Size = new Size(64, 30);
            btnClearClipLPath.TabIndex = 48;
            btnClearClipLPath.Text = "クリア";
            btnClearClipLPath.UseVisualStyleBackColor = true;
            btnClearClipLPath.Click += btnClearClipLPath_Click;
            // 
            // btnT5XXLPath
            // 
            btnT5XXLPath.Location = new Point(384, 178);
            btnT5XXLPath.Name = "btnT5XXLPath";
            btnT5XXLPath.Size = new Size(64, 30);
            btnT5XXLPath.TabIndex = 48;
            btnT5XXLPath.Text = "選択";
            btnT5XXLPath.UseVisualStyleBackColor = true;
            btnT5XXLPath.Click += btnT5XXLPath_Click;
            // 
            // btnClipLPath
            // 
            btnClipLPath.Location = new Point(112, 178);
            btnClipLPath.Name = "btnClipLPath";
            btnClipLPath.Size = new Size(64, 30);
            btnClipLPath.TabIndex = 48;
            btnClipLPath.Text = "選択";
            btnClipLPath.UseVisualStyleBackColor = true;
            btnClipLPath.Click += btnClipLPath_Click;
            // 
            // lblConfigPath
            // 
            lblConfigPath.Font = new Font("Yu Gothic UI", 8F);
            lblConfigPath.Location = new Point(309, 139);
            lblConfigPath.Name = "lblConfigPath";
            lblConfigPath.Size = new Size(240, 36);
            lblConfigPath.TabIndex = 25;
            lblConfigPath.Text = "very very long name";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(309, 97);
            label21.Name = "label21";
            label21.Size = new Size(69, 30);
            label21.TabIndex = 26;
            label21.Text = "dataset\r\nconfigのパス";
            // 
            // btnClearConfigPath
            // 
            btnClearConfigPath.Location = new Point(454, 97);
            btnClearConfigPath.Name = "btnClearConfigPath";
            btnClearConfigPath.Size = new Size(64, 30);
            btnClearConfigPath.TabIndex = 23;
            btnClearConfigPath.Text = "クリア";
            btnClearConfigPath.UseVisualStyleBackColor = true;
            btnClearConfigPath.Click += btnClearConfigPath_Click;
            // 
            // lblT5XXLPath
            // 
            lblT5XXLPath.Font = new Font("Yu Gothic UI", 8F);
            lblT5XXLPath.Location = new Point(310, 211);
            lblT5XXLPath.Name = "lblT5XXLPath";
            lblT5XXLPath.Size = new Size(240, 34);
            lblT5XXLPath.TabIndex = 34;
            lblT5XXLPath.Text = "very very long name";
            // 
            // btnSelectConfigPath
            // 
            btnSelectConfigPath.Location = new Point(384, 97);
            btnSelectConfigPath.Name = "btnSelectConfigPath";
            btnSelectConfigPath.Size = new Size(64, 30);
            btnSelectConfigPath.TabIndex = 24;
            btnSelectConfigPath.Text = "選択";
            btnSelectConfigPath.UseVisualStyleBackColor = true;
            btnSelectConfigPath.Click += btnSelectConfigPath_Click;
            // 
            // lblClipGPath
            // 
            lblClipGPath.Font = new Font("Yu Gothic UI", 8F);
            lblClipGPath.Location = new Point(27, 281);
            lblClipGPath.Name = "lblClipGPath";
            lblClipGPath.Size = new Size(240, 34);
            lblClipGPath.TabIndex = 34;
            lblClipGPath.Text = "long namesafetensors";
            // 
            // lblClipLPath
            // 
            lblClipLPath.Font = new Font("Yu Gothic UI", 8F);
            lblClipLPath.Location = new Point(27, 211);
            lblClipLPath.Name = "lblClipLPath";
            lblClipLPath.Size = new Size(240, 34);
            lblClipLPath.TabIndex = 34;
            lblClipLPath.Text = "very very long name";
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Location = new Point(339, 186);
            label68.Name = "label68";
            label68.Size = new Size(39, 15);
            label68.TabIndex = 33;
            label68.Text = "T5XXL";
            // 
            // pageMisc
            // 
            pageMisc.Controls.Add(label77);
            pageMisc.Controls.Add(groupBox2);
            pageMisc.Controls.Add(label41);
            pageMisc.Controls.Add(label40);
            pageMisc.Controls.Add(cbxUseFullBf16);
            pageMisc.Controls.Add(cbxUseWeightedCaption);
            pageMisc.Controls.Add(cbxDontSaveMetadata);
            pageMisc.Controls.Add(tbxTokensSeparator);
            pageMisc.Controls.Add(nudTEBatchSize);
            pageMisc.Controls.Add(label46);
            pageMisc.Controls.Add(nudMaxTokensT5);
            pageMisc.Controls.Add(label73);
            pageMisc.Controls.Add(nudMaxTokens);
            pageMisc.Controls.Add(label26);
            pageMisc.Controls.Add(tbxComment);
            pageMisc.Location = new Point(4, 24);
            pageMisc.Name = "pageMisc";
            pageMisc.Size = new Size(660, 337);
            pageMisc.TabIndex = 2;
            pageMisc.Text = "その他";
            pageMisc.UseVisualStyleBackColor = true;
            // 
            // label77
            // 
            label77.AutoSize = true;
            label77.Location = new Point(47, 70);
            label77.Name = "label77";
            label77.Size = new Size(91, 15);
            label77.TabIndex = 22;
            label77.Text = "TEのバッチサイズ#";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxPrecision);
            groupBox2.Controls.Add(cbxSaveState);
            groupBox2.Controls.Add(nudClipSkip);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(tbxExtension);
            groupBox2.Controls.Add(nudSeed);
            groupBox2.Location = new Point(21, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 169);
            groupBox2.TabIndex = 59;
            groupBox2.TabStop = false;
            groupBox2.Text = "通常編集する必要のない設定";
            // 
            // cbxSaveState
            // 
            cbxSaveState.AutoSize = true;
            cbxSaveState.Location = new Point(47, 146);
            cbxSaveState.Name = "cbxSaveState";
            cbxSaveState.Size = new Size(153, 19);
            cbxSaveState.TabIndex = 6;
            cbxSaveState.Text = "学習終了時にstateを保存";
            cbxSaveState.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(85, 41);
            label41.Name = "label41";
            label41.Size = new Size(201, 15);
            label41.TabIndex = 66;
            label41.Text = "次の文字は使用できません /\\?:*<>|\"&'`\r\n";
            label41.UseMnemonic = false;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(6, 18);
            label40.Name = "label40";
            label40.Size = new Size(78, 15);
            label40.TabIndex = 33;
            label40.Text = "学習コメント##";
            // 
            // tbxTokensSeparator
            // 
            tbxTokensSeparator.Location = new Point(314, 70);
            tbxTokensSeparator.Name = "tbxTokensSeparator";
            tbxTokensSeparator.Size = new Size(170, 23);
            tbxTokensSeparator.TabIndex = 47;
            // 
            // nudTEBatchSize
            // 
            nudTEBatchSize.Location = new Point(144, 65);
            nudTEBatchSize.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudTEBatchSize.Name = "nudTEBatchSize";
            nudTEBatchSize.Size = new Size(92, 23);
            nudTEBatchSize.TabIndex = 21;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(314, 52);
            label46.Name = "label46";
            label46.Size = new Size(111, 15);
            label46.TabIndex = 46;
            label46.Text = "トークンのセパレータ##";
            // 
            // label73
            // 
            label73.AutoSize = true;
            label73.Location = new Point(21, 125);
            label73.Name = "label73";
            label73.Size = new Size(117, 15);
            label73.TabIndex = 19;
            label73.Text = "最大トークン数(T5XXL)";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(26, 96);
            label26.Name = "label26";
            label26.Size = new Size(108, 15);
            label26.TabIndex = 19;
            label26.Text = "最大トークン数(CLIP)";
            // 
            // tbxComment
            // 
            tbxComment.Location = new Point(85, 15);
            tbxComment.Name = "tbxComment";
            tbxComment.Size = new Size(444, 23);
            tbxComment.TabIndex = 32;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label64);
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
            tabPage3.Size = new Size(660, 335);
            tabPage3.TabIndex = 11;
            tabPage3.Text = "LyCORIS";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Location = new Point(21, 15);
            label64.Name = "label64";
            label64.Size = new Size(163, 15);
            label64.TabIndex = 19;
            label64.Text = "LyCORISの動作は保証しません。";
            // 
            // cbxUseTucker
            // 
            cbxUseTucker.AutoSize = true;
            cbxUseTucker.Location = new Point(22, 225);
            cbxUseTucker.Name = "cbxUseTucker";
            cbxUseTucker.Size = new Size(143, 19);
            cbxUseTucker.TabIndex = 18;
            cbxUseTucker.Text = "Tucker Decomposition";
            cbxUseTucker.UseVisualStyleBackColor = true;
            // 
            // cbxConstrainedOFT
            // 
            cbxConstrainedOFT.AutoSize = true;
            cbxConstrainedOFT.Location = new Point(22, 200);
            cbxConstrainedOFT.Name = "cbxConstrainedOFT";
            cbxConstrainedOFT.Size = new Size(113, 19);
            cbxConstrainedOFT.TabIndex = 18;
            cbxConstrainedOFT.Text = "Constrained OFT";
            cbxConstrainedOFT.UseVisualStyleBackColor = true;
            // 
            // cbxUseScalar
            // 
            cbxUseScalar.AutoSize = true;
            cbxUseScalar.Location = new Point(22, 176);
            cbxUseScalar.Name = "cbxUseScalar";
            cbxUseScalar.Size = new Size(57, 19);
            cbxUseScalar.TabIndex = 18;
            cbxUseScalar.Text = "Scalar";
            cbxUseScalar.UseVisualStyleBackColor = true;
            // 
            // cbxRescaledOFT
            // 
            cbxRescaledOFT.AutoSize = true;
            cbxRescaledOFT.Location = new Point(22, 151);
            cbxRescaledOFT.Name = "cbxRescaledOFT";
            cbxRescaledOFT.Size = new Size(96, 19);
            cbxRescaledOFT.TabIndex = 18;
            cbxRescaledOFT.Text = "Rescaled OFT";
            cbxRescaledOFT.UseVisualStyleBackColor = true;
            // 
            // cbxTrainNorm
            // 
            cbxTrainNorm.AutoSize = true;
            cbxTrainNorm.Location = new Point(22, 126);
            cbxTrainNorm.Name = "cbxTrainNorm";
            cbxTrainNorm.Size = new Size(136, 19);
            cbxTrainNorm.TabIndex = 18;
            cbxTrainNorm.Text = "Normalization Layers";
            cbxTrainNorm.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(21, 58);
            label23.Name = "label23";
            label23.Size = new Size(114, 15);
            label23.TabIndex = 17;
            label23.Text = "LyCORISのアルゴリズム";
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Location = new Point(8, 380);
            label56.Name = "label56";
            label56.Size = new Size(205, 30);
            label56.TabIndex = 58;
            label56.Text = "#がつく項目は0を指定すると未指定にする\r\n##がつく項目は空欄で未指定にする";
            // 
            // cbxUseFullBf16
            // 
            cbxUseFullBf16.AutoSize = true;
            cbxUseFullBf16.Location = new Point(314, 161);
            cbxUseFullBf16.Name = "cbxUseFullBf16";
            cbxUseFullBf16.Size = new Size(171, 19);
            cbxUseFullBf16.TabIndex = 41;
            cbxUseFullBf16.Text = "Full bf16を使用(互換性注意)";
            toolTip1.SetToolTip(cbxUseFullBf16, "NVIDIAであればAmpere以降のみ対応");
            cbxUseFullBf16.UseVisualStyleBackColor = true;
            // 
            // FormAdvanced
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(692, 434);
            Controls.Add(label56);
            Controls.Add(tabControl1);
            Controls.Add(btnDiscardAndClose);
            Controls.Add(button1);
            Font = new Font("Yu Gothic UI", 9F);
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
            ((System.ComponentModel.ISupportInitialize)nudHuberC).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIpNoiseGamma).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSchedulerTimescale).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinLRRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLRDecaySteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCaptionTagDropout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseIterations).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxTokensT5).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudScaleWeightNorms).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBucketReso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBucketReso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdaptiveNoiseScale).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudConvAlpha).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDyLoRAUnit).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudT5DropoutRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudClipGDropoutRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNetworkDropout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudModuleDropout).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRankDropout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudClipLDropoutRate).EndInit();
            page3.ResumeLayout(false);
            page3.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pageMisc.ResumeLayout(false);
            pageMisc.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTEBatchSize).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
        private CheckBox cbxDecouple;
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
        private Label label44;
        private NumericUpDown nudNetworkDropout;
        private TabPage tabPage7;
        private TextBox tbxTokensSeparator;
        private Label label46;
        private CheckBox cbxUseFP8;
        private TabPage page3;
        private TabPage tabPage3;
        private CheckBox cbxTrainNorm;
        private CheckBox cbxWeightDecomposition;
        private CheckBox cbxUseTucker;
        private CheckBox cbxUseScalar;
        private CheckBox cbxRescaledOFT;
        private CheckBox cbxConstrainedOFT;
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
        private Label label56;
        private CheckBox cbxUseAdditionalOptArgs;
        private Button btnShowTipsAboutOpts;
        private CheckBox cbxRandomIpNoiseGamma;
        private CheckBox cbxRandomNoiseOffset;
        private Label label57;
        private NumericUpDown nudIpNoiseGamma;
        private CheckBox cbxAlphaMask;
        private Button btnClearT5XXLPath;
        private Button btnClearClipLPath;
        private Button btnT5XXLPath;
        private Button btnClipLPath;
        private Label lblT5XXLPath;
        private Label lblClipLPath;
        private Label label68;
        private Label label67;
        private Label label47;
        private NumericUpDown nudSchedulerTimescale;
        private Label label66;
        private NumericUpDown nudMinLRRatio;
        private TabPage tabPage6;
        private Label label69;
        private NumericUpDown nudLRDecaySteps;
        private Label label70;
        private NumericUpDown nudCaptionTagDropout;
        private Button btnClearClipGPath;
        private Button btnClipGPath;
        private Label label72;
        private Label lblClipGPath;
        private NumericUpDown nudMaxTokensT5;
        private Label label73;
        private CheckBox cbxApplyAttnMaskToT5;
        private CheckBox cbxDisableMmapLoadSafetensors;
        private Label label76;
        private NumericUpDown nudClipGDropoutRate;
        private Label label75;
        private Label label74;
        private NumericUpDown numericUpDown2;
        private NumericUpDown nudClipLDropoutRate;
        private Label label71;
        private NumericUpDown nudT5DropoutRate;
        private Label label77;
        private NumericUpDown nudTEBatchSize;
        private CheckBox cbxVParameterization;
        private CheckBox cbxZeroTerminalSNR;
        private Label label64;
        private Label label65;
        private TextBox tbxEps1;
        private GroupBox groupBox2;
        private CheckBox cbxDebiasedEstimation;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox8;
        private Label label8;
        private NumericUpDown nudScaleWeightNorms;
        private Label label45;
        private ComboBox cbxResizeInterpolation;
        private GroupBox groupBox3;
        private CheckBox cbxUseFullBf16;
    }
}
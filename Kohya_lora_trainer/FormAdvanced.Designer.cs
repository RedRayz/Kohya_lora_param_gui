
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
            cbxRandomNoiseOffset = new CheckBox();
            cbxRandomIpNoiseGamma = new CheckBox();
            cbxLossType = new ComboBox();
            cbxAlphaMask = new CheckBox();
            nudHuberC = new NumericUpDown();
            nudImmiscibleNoise = new NumericUpDown();
            nudIpNoiseGamma = new NumericUpDown();
            btnSelectVAE = new Button();
            cbxSplitMode = new CheckBox();
            cbxCpuOffloadCheckpointing = new CheckBox();
            cbxTrainT5XXL = new CheckBox();
            nudSchedulerTimescale = new NumericUpDown();
            nudMinLRRatio = new NumericUpDown();
            nudLRDecaySteps = new NumericUpDown();
            nudCaptionTagDropout = new NumericUpDown();
            cbxDisableMmapLoadSafetensors = new CheckBox();
            cbxVParameterization = new CheckBox();
            cbxZeroTerminalSNR = new CheckBox();
            nudBlocksToSwap = new NumericUpDown();
            nudDiscreteFlowShift = new NumericUpDown();
            cbxUseAdditionalOptArgs = new CheckBox();
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
            label77 = new Label();
            label22 = new Label();
            label45 = new Label();
            nudTEBatchSize = new NumericUpDown();
            nudDyLoRAUnit = new NumericUpDown();
            label54 = new Label();
            label52 = new Label();
            label53 = new Label();
            nudConvAlpha = new NumericUpDown();
            label25 = new Label();
            label24 = new Label();
            tabPage4 = new TabPage();
            label71 = new Label();
            label76 = new Label();
            label70 = new Label();
            nudT5DropoutRate = new NumericUpDown();
            nudClipGDropoutRate = new NumericUpDown();
            label39 = new Label();
            label44 = new Label();
            label38 = new Label();
            label75 = new Label();
            label37 = new Label();
            label74 = new Label();
            label36 = new Label();
            nudMaxNormReg = new NumericUpDown();
            nudNetworkDropout = new NumericUpDown();
            nudModuleDropout = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            nudRankDropout = new NumericUpDown();
            nudClipLDropoutRate = new NumericUpDown();
            page3 = new TabPage();
            label55 = new Label();
            cbxMaskLoss = new CheckBox();
            label50 = new Label();
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
            label65 = new Label();
            btnShowTipsAboutOpts = new Button();
            label43 = new Label();
            label42 = new Label();
            cbxRelativeStep = new CheckBox();
            cbxUseSafeguard = new CheckBox();
            cbxScaleParameter = new CheckBox();
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
            label41 = new Label();
            cbxSaveState = new CheckBox();
            label40 = new Label();
            tbxTokensSeparator = new TextBox();
            label46 = new Label();
            nudMaxTokensT5 = new NumericUpDown();
            label73 = new Label();
            label26 = new Label();
            tbxComment = new TextBox();
            label8 = new Label();
            tabPage3 = new TabPage();
            label64 = new Label();
            cbxUseTucker = new CheckBox();
            cbxConstrainedOFT = new CheckBox();
            cbxUseScalar = new CheckBox();
            cbxRescaledOFT = new CheckBox();
            cbxTrainNorm = new CheckBox();
            label23 = new Label();
            tabPage8 = new TabPage();
            groupBox1 = new GroupBox();
            cbxModelPredictionType = new ComboBox();
            label58 = new Label();
            cbxTimestepSampling = new ComboBox();
            label60 = new Label();
            label63 = new Label();
            cbxTrainBlock = new ComboBox();
            label59 = new Label();
            nudSigmoidScale = new NumericUpDown();
            label62 = new Label();
            nudGuidanceScale = new NumericUpDown();
            label78 = new Label();
            cbxApplyClipAttnMask = new CheckBox();
            cbxApplyT5AttnMask = new CheckBox();
            label61 = new Label();
            label56 = new Label();
            tabPageExp = new TabPage();
            label79 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)nudImmiscibleNoise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIpNoiseGamma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSchedulerTimescale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinLRRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLRDecaySteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCaptionTagDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBlocksToSwap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscreteFlowShift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBucketReso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBucketReso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMomentum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdaptiveNoiseScale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseIterations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseDiscount).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTEBatchSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDyLoRAUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudConvAlpha).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudT5DropoutRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClipGDropoutRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxNormReg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNetworkDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudModuleDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRankDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClipLDropoutRate).BeginInit();
            page3.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage2.SuspendLayout();
            pageMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxTokensT5).BeginInit();
            tabPage3.SuspendLayout();
            tabPage8.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSigmoidScale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGuidanceScale).BeginInit();
            tabPageExp.SuspendLayout();
            SuspendLayout();
            // 
            // tbxUnetLR
            // 
            tbxUnetLR.Location = new Point(113, 21);
            tbxUnetLR.Margin = new Padding(3, 4, 3, 4);
            tbxUnetLR.Name = "tbxUnetLR";
            tbxUnetLR.Size = new Size(76, 23);
            tbxUnetLR.TabIndex = 0;
            toolTip1.SetToolTip(tbxUnetLR, "一部のDADaptation系では使用不可");
            tbxUnetLR.TextChanged += tbxUnetLR_TextChanged;
            // 
            // tbxTextEncoLR
            // 
            tbxTextEncoLR.Location = new Point(114, 50);
            tbxTextEncoLR.Margin = new Padding(3, 4, 3, 4);
            tbxTextEncoLR.Name = "tbxTextEncoLR";
            tbxTextEncoLR.Size = new Size(76, 23);
            tbxTextEncoLR.TabIndex = 1;
            toolTip1.SetToolTip(tbxTextEncoLR, "一部のDADaptation系では使用不可");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "UNet LR##";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 3;
            label2.Text = "Text encoder LR##";
            // 
            // lblMinBucketReso
            // 
            lblMinBucketReso.AutoSize = true;
            lblMinBucketReso.Location = new Point(210, 24);
            lblMinBucketReso.Name = "lblMinBucketReso";
            lblMinBucketReso.Size = new Size(102, 15);
            lblMinBucketReso.TabIndex = 4;
            lblMinBucketReso.Text = "最小バケット解像度";
            // 
            // lblMaxBucketReso
            // 
            lblMaxBucketReso.AutoSize = true;
            lblMaxBucketReso.Location = new Point(210, 55);
            lblMaxBucketReso.Name = "lblMaxBucketReso";
            lblMaxBucketReso.Size = new Size(102, 15);
            lblMaxBucketReso.TabIndex = 7;
            lblMaxBucketReso.Text = "最大バケット解像度";
            // 
            // cbxNoUpscale
            // 
            cbxNoUpscale.AutoSize = true;
            cbxNoUpscale.Location = new Point(53, 234);
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
            label7.Location = new Point(60, 186);
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
            cbxPrecision.Location = new Point(144, 243);
            cbxPrecision.Name = "cbxPrecision";
            cbxPrecision.Size = new Size(92, 23);
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
            cbxCrossAttenType.Size = new Size(98, 23);
            cbxCrossAttenType.TabIndex = 38;
            toolTip1.SetToolTip(cbxCrossAttenType, "最適化アルゴリズムの種類\r\nmef_eff_attenは省メモリだが遅い\r\nxformersは高速だがNVIDIAのみ対応\r\nsdpaは高速だがtorchのエラーで動かないかも(原因不明)");
            // 
            // cbxUseColorAug
            // 
            cbxUseColorAug.AutoSize = true;
            cbxUseColorAug.Location = new Point(315, 234);
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
            // cbxUseWarmupInit
            // 
            cbxUseWarmupInit.AutoSize = true;
            cbxUseWarmupInit.Location = new Point(286, 188);
            cbxUseWarmupInit.Name = "cbxUseWarmupInit";
            cbxUseWarmupInit.Size = new Size(183, 19);
            cbxUseWarmupInit.TabIndex = 18;
            cbxUseWarmupInit.Text = "AdaFactor: warmup_initを使用";
            toolTip1.SetToolTip(cbxUseWarmupInit, "必要なステップ数がだいたい1万以上になる");
            cbxUseWarmupInit.UseVisualStyleBackColor = true;
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
            toolTip1.SetToolTip(nudNoiseOffset, "全体的に明るい/暗い環境でグレー寄りになるのを軽減する\r\n変色と明度の変化を減らすため学習元モデルで使用された値を設定すべき\r\nちなみにAnimagine XL,Kivotos XLで使用された値は0.0357\r\nZero Terminal SNRを使うなら0にする");
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
            cbxDontSaveMetadata.Location = new Point(106, 69);
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
            tbxExtension.Location = new Point(144, 272);
            tbxExtension.Name = "tbxExtension";
            tbxExtension.Size = new Size(92, 23);
            tbxExtension.TabIndex = 19;
            tbxExtension.Text = ".txt";
            toolTip1.SetToolTip(tbxExtension, "ピリオド込みで入力する");
            // 
            // nudClipSkip
            // 
            nudClipSkip.Location = new Point(146, 184);
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
            cbxUseWeightedCaption.Location = new Point(53, 259);
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
            cbxCacheTextEncoder.Location = new Point(311, 199);
            cbxCacheTextEncoder.Name = "cbxCacheTextEncoder";
            cbxCacheTextEncoder.Size = new Size(180, 19);
            cbxCacheTextEncoder.TabIndex = 18;
            cbxCacheTextEncoder.Text = "Text Encoderの出力のキャッシュ";
            toolTip1.SetToolTip(cbxCacheTextEncoder, "キャプション関連のオプションは使用不可");
            cbxCacheTextEncoder.UseVisualStyleBackColor = true;
            // 
            // nudSeed
            // 
            nudSeed.Location = new Point(146, 213);
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
            toolTip1.SetToolTip(nudMaxTokens, "コンマ区切りではなくCLIPのトークン数\r\nSD1専用");
            nudMaxTokens.Value = new decimal(new int[] { 75, 0, 0, 0 });
            // 
            // cbxUseConv2d
            // 
            cbxUseConv2d.AutoSize = true;
            cbxUseConv2d.Location = new Point(53, 209);
            cbxUseConv2d.Name = "cbxUseConv2d";
            cbxUseConv2d.Size = new Size(161, 19);
            cbxUseConv2d.TabIndex = 20;
            cbxUseConv2d.Text = "LoRAでConv2d拡張を使用";
            toolTip1.SetToolTip(cbxUseConv2d, "畳み込み層も学習する\r\nキャラLoRAはオフでよい");
            cbxUseConv2d.UseVisualStyleBackColor = true;
            // 
            // nudConvDim
            // 
            nudConvDim.Location = new Point(112, 110);
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
            cbxCropRandomly.Location = new Point(315, 259);
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
            cbxNoHalfVae.Location = new Point(311, 174);
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
            cbxFlipAug.Location = new Point(315, 209);
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
            cbxUseFullFp16.Location = new Point(311, 124);
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
            cbxUseFP8.Location = new Point(311, 149);
            cbxUseFP8.Name = "cbxUseFP8";
            cbxUseFP8.Size = new Size(135, 19);
            cbxUseFP8.TabIndex = 42;
            cbxUseFP8.Text = "モデルをfp8で読み込む";
            toolTip1.SetToolTip(cbxUseFP8, "若干の速度低下と引き換えにモデルによるVRAM消費が半減する\r\nVRAM10GB以下では使用を推奨\r\nただし品質が低下する可能性あり");
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
            toolTip1.SetToolTip(nudMinSNRGamma, "設定するとLoRA重ね掛けしたときに不安定になる？");
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
            nudLoRAPlusLRRatio.Location = new Point(540, 22);
            nudLoRAPlusLRRatio.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudLoRAPlusLRRatio.Name = "nudLoRAPlusLRRatio";
            nudLoRAPlusLRRatio.Size = new Size(72, 23);
            nudLoRAPlusLRRatio.TabIndex = 8;
            toolTip1.SetToolTip(nudLoRAPlusLRRatio, "適切に設定すると2倍ほど収束が早くなる\r\nこの項目はUnetとTEの両方のratio\r\n論文では16が推奨されているが実際には4がいい感じ\r\n");
            // 
            // nudLoRAPlusUnetLRRatio
            // 
            nudLoRAPlusUnetLRRatio.Location = new Point(540, 51);
            nudLoRAPlusUnetLRRatio.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudLoRAPlusUnetLRRatio.Name = "nudLoRAPlusUnetLRRatio";
            nudLoRAPlusUnetLRRatio.Size = new Size(72, 23);
            nudLoRAPlusUnetLRRatio.TabIndex = 8;
            toolTip1.SetToolTip(nudLoRAPlusUnetLRRatio, "個別指定時はLoRA+ LR比率を0にすること");
            // 
            // nudLoRAPlusTELRRatio
            // 
            nudLoRAPlusTELRRatio.Location = new Point(540, 80);
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
            cbxAlphaMask.Size = new Size(120, 19);
            cbxAlphaMask.TabIndex = 7;
            cbxAlphaMask.Text = "アルファマスクを使用";
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
            // nudImmiscibleNoise
            // 
            nudImmiscibleNoise.Location = new Point(193, 84);
            nudImmiscibleNoise.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            nudImmiscibleNoise.Name = "nudImmiscibleNoise";
            nudImmiscibleNoise.Size = new Size(80, 23);
            nudImmiscibleNoise.TabIndex = 53;
            toolTip1.SetToolTip(nudImmiscibleNoise, "品質改善の可能性がある\r\n推奨値は1024\r\nVRAM使用量が増加\r\n使用するにはPull Requestのチェックアウト必要");
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
            // cbxSplitMode
            // 
            cbxSplitMode.AutoSize = true;
            cbxSplitMode.Location = new Point(139, 163);
            cbxSplitMode.Name = "cbxSplitMode";
            cbxSplitMode.Size = new Size(75, 19);
            cbxSplitMode.TabIndex = 4;
            cbxSplitMode.Text = "分割モード";
            toolTip1.SetToolTip(cbxSplitMode, "VRAM消費を減らす代わりに2-3倍遅くなる");
            cbxSplitMode.UseVisualStyleBackColor = true;
            // 
            // cbxCpuOffloadCheckpointing
            // 
            cbxCpuOffloadCheckpointing.AutoSize = true;
            cbxCpuOffloadCheckpointing.Location = new Point(139, 200);
            cbxCpuOffloadCheckpointing.Name = "cbxCpuOffloadCheckpointing";
            cbxCpuOffloadCheckpointing.Size = new Size(165, 19);
            cbxCpuOffloadCheckpointing.TabIndex = 43;
            cbxCpuOffloadCheckpointing.Text = "cpu offload checkpointing";
            toolTip1.SetToolTip(cbxCpuOffloadCheckpointing, "gradient checkpointingをCPUにオフロードする\r\nVRAM消費が最大1GB減少するが学習が約15%遅くなる\r\nFLUX.1限定かつ分割モードの併用不可");
            cbxCpuOffloadCheckpointing.UseVisualStyleBackColor = true;
            // 
            // cbxTrainT5XXL
            // 
            cbxTrainT5XXL.AutoSize = true;
            cbxTrainT5XXL.Location = new Point(139, 182);
            cbxTrainT5XXL.Name = "cbxTrainT5XXL";
            cbxTrainT5XXL.Size = new Size(113, 19);
            cbxTrainT5XXL.TabIndex = 8;
            cbxTrainT5XXL.Text = "T5 XXLを学習する";
            toolTip1.SetToolTip(cbxTrainT5XXL, "かなりのVRAMが必要？");
            cbxTrainT5XXL.UseVisualStyleBackColor = true;
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
            cbxDisableMmapLoadSafetensors.Location = new Point(311, 249);
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
            toolTip1.SetToolTip(cbxVParameterization, "v-predictionを使う\r\n学習元モデルが使用を明記している場合のみチェックをつける");
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
            toolTip1.SetToolTip(cbxZeroTerminalSNR, "ノイズスケジューラーの問題を修正して\r\n全体が明るい/暗い状況でグレー寄りになるのを防ぐ\r\n生成時に一部サンプラーの相性が悪くなる欠点あり？");
            cbxZeroTerminalSNR.UseVisualStyleBackColor = true;
            // 
            // nudBlocksToSwap
            // 
            nudBlocksToSwap.Location = new Point(468, 115);
            nudBlocksToSwap.Maximum = new decimal(new int[] { 35, 0, 0, 0 });
            nudBlocksToSwap.Name = "nudBlocksToSwap";
            nudBlocksToSwap.Size = new Size(90, 23);
            nudBlocksToSwap.TabIndex = 44;
            toolTip1.SetToolTip(nudBlocksToSwap, "不要なブロックをCPUに移動することで\r\nVRAM使用量を減らす\r\n最大値はSD3.5 Mediumが22、FLUX.1が35");
            // 
            // nudDiscreteFlowShift
            // 
            nudDiscreteFlowShift.DecimalPlaces = 4;
            nudDiscreteFlowShift.Location = new Point(468, 83);
            nudDiscreteFlowShift.Name = "nudDiscreteFlowShift";
            nudDiscreteFlowShift.Size = new Size(90, 23);
            nudDiscreteFlowShift.TabIndex = 3;
            toolTip1.SetToolTip(nudDiscreteFlowShift, "デフォルト値はSD3.5が1\r\nFLUX.1が3");
            nudDiscreteFlowShift.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbxUseAdditionalOptArgs
            // 
            cbxUseAdditionalOptArgs.AutoSize = true;
            cbxUseAdditionalOptArgs.Location = new Point(12, 13);
            cbxUseAdditionalOptArgs.Name = "cbxUseAdditionalOptArgs";
            cbxUseAdditionalOptArgs.Size = new Size(239, 19);
            cbxUseAdditionalOptArgs.TabIndex = 26;
            cbxUseAdditionalOptArgs.Text = "一部Optimizerに追加のパラメータを指定する";
            toolTip1.SetToolTip(cbxUseAdditionalOptArgs, "DAdaptationは常に指定されます。");
            cbxUseAdditionalOptArgs.UseVisualStyleBackColor = true;
            // 
            // cbxAdvancedTrain
            // 
            cbxAdvancedTrain.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAdvancedTrain.FormattingEnabled = true;
            cbxAdvancedTrain.Items.AddRange(new object[] { "両方学習", "TEのみ学習", "UNetのみ学習" });
            cbxAdvancedTrain.Location = new Point(113, 81);
            cbxAdvancedTrain.Name = "cbxAdvancedTrain";
            cbxAdvancedTrain.Size = new Size(102, 23);
            cbxAdvancedTrain.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 213);
            label6.Name = "label6";
            label6.Size = new Size(61, 30);
            label6.TabIndex = 16;
            label6.Text = "Seed\r\n-1でランダム";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 275);
            label9.Name = "label9";
            label9.Size = new Size(102, 30);
            label9.TabIndex = 20;
            label9.Text = "キャプションファイルの\r\n拡張子";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(505, 370);
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
            nudMinBucketReso.Location = new Point(318, 21);
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
            nudMaxBucketReso.Location = new Point(318, 52);
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
            label10.Location = new Point(83, 21);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 26;
            label10.Text = "スケジューラ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(59, 246);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 30;
            label11.Text = "保存時の精度";
            // 
            // btnDiscardAndClose
            // 
            btnDiscardAndClose.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiscardAndClose.Location = new Point(330, 370);
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
            lblTBoardPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
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
            label13.Location = new Point(22, 84);
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
            // nudMomentum
            // 
            nudMomentum.DecimalPlaces = 4;
            nudMomentum.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudMomentum.Location = new Point(370, 263);
            nudMomentum.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMomentum.Name = "nudMomentum";
            nudMomentum.Size = new Size(78, 23);
            nudMomentum.TabIndex = 44;
            nudMomentum.Value = new decimal(new int[] { 9, 0, 0, 65536 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(287, 263);
            label15.Name = "label15";
            label15.Size = new Size(75, 30);
            label15.TabIndex = 45;
            label15.Text = "Nesterovの\r\nmomentum#";
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
            lblVAEPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
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
            // nudMultiresNoiseIterations
            // 
            nudMultiresNoiseIterations.Location = new Point(445, 136);
            nudMultiresNoiseIterations.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMultiresNoiseIterations.Name = "nudMultiresNoiseIterations";
            nudMultiresNoiseIterations.Size = new Size(80, 23);
            nudMultiresNoiseIterations.TabIndex = 53;
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
            // nudMultiresNoiseDiscount
            // 
            nudMultiresNoiseDiscount.DecimalPlaces = 4;
            nudMultiresNoiseDiscount.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudMultiresNoiseDiscount.Location = new Point(445, 165);
            nudMultiresNoiseDiscount.Name = "nudMultiresNoiseDiscount";
            nudMultiresNoiseDiscount.Size = new Size(80, 23);
            nudMultiresNoiseDiscount.TabIndex = 55;
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
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Controls.Add(tabPageExp);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(668, 352);
            tabControl1.TabIndex = 57;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label77);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(nudLoRAPlusTELRRatio);
            tabPage1.Controls.Add(label45);
            tabPage1.Controls.Add(cbxUseConv2d);
            tabPage1.Controls.Add(nudLoRAPlusUnetLRRatio);
            tabPage1.Controls.Add(tbxUnetLR);
            tabPage1.Controls.Add(nudTEBatchSize);
            tabPage1.Controls.Add(nudDyLoRAUnit);
            tabPage1.Controls.Add(tbxTextEncoLR);
            tabPage1.Controls.Add(nudLoRAPlusLRRatio);
            tabPage1.Controls.Add(label54);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label52);
            tabPage1.Controls.Add(cbxFlipAug);
            tabPage1.Controls.Add(label53);
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
            tabPage1.Controls.Add(cbxAdvancedTrain);
            tabPage1.Controls.Add(label13);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(660, 324);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ページ1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label77
            // 
            label77.AutoSize = true;
            label77.Location = new Point(221, 141);
            label77.Name = "label77";
            label77.Size = new Size(91, 15);
            label77.TabIndex = 22;
            label77.Text = "TEのバッチサイズ#";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(233, 84);
            label22.Name = "label22";
            label22.Size = new Size(80, 15);
            label22.TabIndex = 22;
            label22.Text = "DyLoRAのunit";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(317, 191);
            label45.Name = "label45";
            label45.Size = new Size(105, 15);
            label45.TabIndex = 27;
            label45.Text = "augmentation関連";
            // 
            // nudTEBatchSize
            // 
            nudTEBatchSize.Location = new Point(318, 139);
            nudTEBatchSize.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudTEBatchSize.Name = "nudTEBatchSize";
            nudTEBatchSize.Size = new Size(72, 23);
            nudTEBatchSize.TabIndex = 21;
            // 
            // nudDyLoRAUnit
            // 
            nudDyLoRAUnit.Location = new Point(317, 81);
            nudDyLoRAUnit.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudDyLoRAUnit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDyLoRAUnit.Name = "nudDyLoRAUnit";
            nudDyLoRAUnit.Size = new Size(72, 23);
            nudDyLoRAUnit.TabIndex = 21;
            nudDyLoRAUnit.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Location = new Point(444, 24);
            label54.Name = "label54";
            label54.Size = new Size(90, 15);
            label54.TabIndex = 7;
            label54.Text = "LoRA+ LR比率#";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Location = new Point(417, 53);
            label52.Name = "label52";
            label52.Size = new Size(120, 15);
            label52.TabIndex = 6;
            label52.Text = "LoRA+ UNet LR比率#";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Location = new Point(431, 82);
            label53.Name = "label53";
            label53.Size = new Size(105, 15);
            label53.TabIndex = 6;
            label53.Text = "LoRA+ TE LR比率#";
            // 
            // nudConvAlpha
            // 
            nudConvAlpha.DecimalPlaces = 4;
            nudConvAlpha.Location = new Point(112, 139);
            nudConvAlpha.Maximum = new decimal(new int[] { 1280, 0, 0, 0 });
            nudConvAlpha.Name = "nudConvAlpha";
            nudConvAlpha.Size = new Size(72, 23);
            nudConvAlpha.TabIndex = 19;
            nudConvAlpha.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(48, 115);
            label25.Name = "label25";
            label25.Size = new Size(58, 15);
            label25.TabIndex = 15;
            label25.Text = "Conv Dim";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(40, 141);
            label24.Name = "label24";
            label24.Size = new Size(68, 15);
            label24.TabIndex = 16;
            label24.Text = "Conv Alpha";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label71);
            tabPage4.Controls.Add(label76);
            tabPage4.Controls.Add(label70);
            tabPage4.Controls.Add(nudT5DropoutRate);
            tabPage4.Controls.Add(nudClipGDropoutRate);
            tabPage4.Controls.Add(nudCaptionTagDropout);
            tabPage4.Controls.Add(label39);
            tabPage4.Controls.Add(label44);
            tabPage4.Controls.Add(label38);
            tabPage4.Controls.Add(label75);
            tabPage4.Controls.Add(label37);
            tabPage4.Controls.Add(label74);
            tabPage4.Controls.Add(label36);
            tabPage4.Controls.Add(nudMaxNormReg);
            tabPage4.Controls.Add(nudNetworkDropout);
            tabPage4.Controls.Add(nudModuleDropout);
            tabPage4.Controls.Add(numericUpDown2);
            tabPage4.Controls.Add(nudRankDropout);
            tabPage4.Controls.Add(nudClipLDropoutRate);
            tabPage4.Controls.Add(nudCaptionDropout);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(660, 324);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "dropout";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Location = new Point(334, 78);
            label71.Name = "label71";
            label71.Size = new Size(129, 15);
            label71.TabIndex = 49;
            label71.Text = "T5XLLドロップアウト確率#";
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
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(68, 164);
            label39.Name = "label39";
            label39.Size = new Size(148, 15);
            label39.TabIndex = 25;
            label39.Text = "Max Norm Regularization#";
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
            label75.Location = new Point(95, 193);
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
            // nudMaxNormReg
            // 
            nudMaxNormReg.DecimalPlaces = 4;
            nudMaxNormReg.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudMaxNormReg.Location = new Point(222, 162);
            nudMaxNormReg.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMaxNormReg.Name = "nudMaxNormReg";
            nudMaxNormReg.Size = new Size(78, 23);
            nudMaxNormReg.TabIndex = 24;
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
            numericUpDown2.Location = new Point(222, 191);
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
            page3.Controls.Add(label18);
            page3.Controls.Add(cbxHuberSchedule);
            page3.Controls.Add(label14);
            page3.Controls.Add(label49);
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
            page3.Location = new Point(4, 24);
            page3.Name = "page3";
            page3.Size = new Size(660, 324);
            page3.TabIndex = 10;
            page3.Text = "損失とノイズ";
            page3.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new Point(29, 86);
            label55.Name = "label55";
            label55.Size = new Size(158, 15);
            label55.TabIndex = 56;
            label55.Text = "Immiscible Noise batch size#";
            // 
            // cbxMaskLoss
            // 
            cbxMaskLoss.AutoSize = true;
            cbxMaskLoss.Location = new Point(138, 118);
            cbxMaskLoss.Name = "cbxMaskLoss";
            cbxMaskLoss.Size = new Size(113, 19);
            cbxMaskLoss.TabIndex = 7;
            cbxMaskLoss.Text = "Mask Lossを使用";
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
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(660, 324);
            tabPage6.TabIndex = 13;
            tabPage6.Text = "スケジューラー";
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
            tabPage7.Controls.Add(cbxUseFullFp16);
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
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(660, 324);
            tabPage7.TabIndex = 8;
            tabPage7.Text = "パフォーマンス";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // cbxCacheTextencoderToDisk
            // 
            cbxCacheTextencoderToDisk.AutoSize = true;
            cbxCacheTextencoderToDisk.Location = new Point(311, 224);
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
            tabPage5.Controls.Add(label65);
            tabPage5.Controls.Add(btnShowTipsAboutOpts);
            tabPage5.Controls.Add(cbxUseAdditionalOptArgs);
            tabPage5.Controls.Add(label43);
            tabPage5.Controls.Add(label42);
            tabPage5.Controls.Add(nudMomentum);
            tabPage5.Controls.Add(label15);
            tabPage5.Controls.Add(cbxUseWarmupInit);
            tabPage5.Controls.Add(cbxRelativeStep);
            tabPage5.Controls.Add(cbxUseSafeguard);
            tabPage5.Controls.Add(cbxScaleParameter);
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
            tabPage5.Controls.Add(tbxEps1);
            tabPage5.Controls.Add(tbxEps);
            tabPage5.Controls.Add(label35);
            tabPage5.Controls.Add(tbxD0);
            tabPage5.Controls.Add(tbxGrowthRate);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(660, 324);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "オプティマイザ";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
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
            // cbxRelativeStep
            // 
            cbxRelativeStep.AutoSize = true;
            cbxRelativeStep.Location = new Point(286, 213);
            cbxRelativeStep.Name = "cbxRelativeStep";
            cbxRelativeStep.Size = new Size(183, 19);
            cbxRelativeStep.TabIndex = 18;
            cbxRelativeStep.Text = "AdaFactor: relative_stepを使用";
            cbxRelativeStep.UseVisualStyleBackColor = true;
            // 
            // cbxUseSafeguard
            // 
            cbxUseSafeguard.AutoSize = true;
            cbxUseSafeguard.Location = new Point(20, 263);
            cbxUseSafeguard.Name = "cbxUseSafeguard";
            cbxUseSafeguard.Size = new Size(194, 19);
            cbxUseSafeguard.TabIndex = 24;
            cbxUseSafeguard.Text = "safeguard warmup(prodigyのみ)";
            cbxUseSafeguard.UseVisualStyleBackColor = true;
            // 
            // cbxScaleParameter
            // 
            cbxScaleParameter.AutoSize = true;
            cbxScaleParameter.Location = new Point(286, 235);
            cbxScaleParameter.Name = "cbxScaleParameter";
            cbxScaleParameter.Size = new Size(202, 19);
            cbxScaleParameter.TabIndex = 18;
            cbxScaleParameter.Text = "AdaFactor: scale_parameterを使用";
            cbxScaleParameter.UseVisualStyleBackColor = true;
            // 
            // cbxUseBiasCorrection
            // 
            cbxUseBiasCorrection.AutoSize = true;
            cbxUseBiasCorrection.Location = new Point(20, 238);
            cbxUseBiasCorrection.Name = "cbxUseBiasCorrection";
            cbxUseBiasCorrection.Size = new Size(174, 19);
            cbxUseBiasCorrection.TabIndex = 24;
            cbxUseBiasCorrection.Text = "bias correction(prodigyのみ)";
            cbxUseBiasCorrection.UseVisualStyleBackColor = true;
            // 
            // cbxNoProx
            // 
            cbxNoProx.AutoSize = true;
            cbxNoProx.Location = new Point(20, 213);
            cbxNoProx.Name = "cbxNoProx";
            cbxNoProx.Size = new Size(136, 19);
            cbxNoProx.TabIndex = 24;
            cbxNoProx.Text = "no prox(Adan系のみ)";
            cbxNoProx.UseVisualStyleBackColor = true;
            // 
            // cbxDecouple
            // 
            cbxDecouple.AutoSize = true;
            cbxDecouple.Location = new Point(20, 188);
            cbxDecouple.Name = "cbxDecouple";
            cbxDecouple.Size = new Size(147, 19);
            cbxDecouple.TabIndex = 24;
            cbxDecouple.Text = "decouple(Adam系のみ)";
            cbxDecouple.UseVisualStyleBackColor = true;
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(660, 324);
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
            lblConfigPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblT5XXLPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblClipGPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblClipGPath.Location = new Point(27, 281);
            lblClipGPath.Name = "lblClipGPath";
            lblClipGPath.Size = new Size(240, 34);
            lblClipGPath.TabIndex = 34;
            lblClipGPath.Text = "long namesafetensors";
            // 
            // lblClipLPath
            // 
            lblClipLPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
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
            pageMisc.Controls.Add(label41);
            pageMisc.Controls.Add(cbxSaveState);
            pageMisc.Controls.Add(label40);
            pageMisc.Controls.Add(cbxDontSaveMetadata);
            pageMisc.Controls.Add(tbxTokensSeparator);
            pageMisc.Controls.Add(label46);
            pageMisc.Controls.Add(nudMaxTokensT5);
            pageMisc.Controls.Add(label73);
            pageMisc.Controls.Add(nudMaxTokens);
            pageMisc.Controls.Add(label26);
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
            pageMisc.Location = new Point(4, 24);
            pageMisc.Name = "pageMisc";
            pageMisc.Size = new Size(660, 324);
            pageMisc.TabIndex = 2;
            pageMisc.Text = "その他";
            pageMisc.UseVisualStyleBackColor = true;
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
            // cbxSaveState
            // 
            cbxSaveState.AutoSize = true;
            cbxSaveState.Location = new Point(286, 274);
            cbxSaveState.Name = "cbxSaveState";
            cbxSaveState.Size = new Size(153, 19);
            cbxSaveState.TabIndex = 6;
            cbxSaveState.Text = "学習終了時にstateを保存";
            cbxSaveState.UseVisualStyleBackColor = true;
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
            tbxTokensSeparator.Location = new Point(313, 117);
            tbxTokensSeparator.Name = "tbxTokensSeparator";
            tbxTokensSeparator.Size = new Size(170, 23);
            tbxTokensSeparator.TabIndex = 47;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(313, 99);
            label46.Name = "label46";
            label46.Size = new Size(111, 15);
            label46.TabIndex = 46;
            label46.Text = "トークンのセパレータ##";
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
            nudMaxTokensT5.Value = new decimal(new int[] { 256, 0, 0, 0 });
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
            label26.Location = new Point(38, 96);
            label26.Name = "label26";
            label26.Size = new Size(105, 15);
            label26.TabIndex = 19;
            label26.Text = "最大トークン数(SD1)";
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
            label8.Location = new Point(38, 155);
            label8.Name = "label8";
            label8.Size = new Size(189, 20);
            label8.TabIndex = 31;
            label8.Text = "通常編集する必要のない設定";
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
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(660, 324);
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
            // tabPage8
            // 
            tabPage8.Controls.Add(groupBox1);
            tabPage8.Controls.Add(label78);
            tabPage8.Controls.Add(nudBlocksToSwap);
            tabPage8.Controls.Add(cbxApplyClipAttnMask);
            tabPage8.Controls.Add(cbxApplyT5AttnMask);
            tabPage8.Controls.Add(nudDiscreteFlowShift);
            tabPage8.Controls.Add(label61);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(660, 324);
            tabPage8.TabIndex = 12;
            tabPage8.Text = "DiT";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxModelPredictionType);
            groupBox1.Controls.Add(label58);
            groupBox1.Controls.Add(cbxTimestepSampling);
            groupBox1.Controls.Add(label60);
            groupBox1.Controls.Add(cbxCpuOffloadCheckpointing);
            groupBox1.Controls.Add(label63);
            groupBox1.Controls.Add(cbxTrainT5XXL);
            groupBox1.Controls.Add(cbxTrainBlock);
            groupBox1.Controls.Add(label59);
            groupBox1.Controls.Add(nudSigmoidScale);
            groupBox1.Controls.Add(cbxSplitMode);
            groupBox1.Controls.Add(label62);
            groupBox1.Controls.Add(nudGuidanceScale);
            groupBox1.Location = new Point(17, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 245);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "FLUX.1専用";
            // 
            // cbxModelPredictionType
            // 
            cbxModelPredictionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxModelPredictionType.FormattingEnabled = true;
            cbxModelPredictionType.Items.AddRange(new object[] { "Raw", "Additive", "Sigma Scaled" });
            cbxModelPredictionType.Location = new Point(139, 74);
            cbxModelPredictionType.Name = "cbxModelPredictionType";
            cbxModelPredictionType.Size = new Size(121, 23);
            cbxModelPredictionType.TabIndex = 1;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Location = new Point(16, 19);
            label58.Name = "label58";
            label58.Size = new Size(122, 15);
            label58.TabIndex = 0;
            label58.Text = "タイムステップサンプリング";
            // 
            // cbxTimestepSampling
            // 
            cbxTimestepSampling.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTimestepSampling.FormattingEnabled = true;
            cbxTimestepSampling.Items.AddRange(new object[] { "Sigma", "Uniform", "Sigmoid", "Shift", "Flux Shift" });
            cbxTimestepSampling.Location = new Point(140, 16);
            cbxTimestepSampling.Name = "cbxTimestepSampling";
            cbxTimestepSampling.Size = new Size(121, 23);
            cbxTimestepSampling.TabIndex = 1;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Location = new Point(41, 77);
            label60.Name = "label60";
            label60.Size = new Size(93, 15);
            label60.TabIndex = 0;
            label60.Text = "モデル予測の種類";
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Location = new Point(46, 106);
            label63.Name = "label63";
            label63.Size = new Size(85, 15);
            label63.TabIndex = 0;
            label63.Text = "学習するブロック";
            // 
            // cbxTrainBlock
            // 
            cbxTrainBlock.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTrainBlock.FormattingEnabled = true;
            cbxTrainBlock.Items.AddRange(new object[] { "すべて", "doubleのみ", "singleのみ" });
            cbxTrainBlock.Location = new Point(140, 103);
            cbxTrainBlock.Name = "cbxTrainBlock";
            cbxTrainBlock.Size = new Size(121, 23);
            cbxTrainBlock.TabIndex = 1;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Location = new Point(41, 47);
            label59.Name = "label59";
            label59.Size = new Size(97, 15);
            label59.TabIndex = 2;
            label59.Text = "シグモイドのスケール";
            // 
            // nudSigmoidScale
            // 
            nudSigmoidScale.DecimalPlaces = 4;
            nudSigmoidScale.Location = new Point(140, 45);
            nudSigmoidScale.Name = "nudSigmoidScale";
            nudSigmoidScale.Size = new Size(120, 23);
            nudSigmoidScale.TabIndex = 3;
            nudSigmoidScale.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Location = new Point(10, 136);
            label62.Name = "label62";
            label62.Size = new Size(124, 15);
            label62.TabIndex = 2;
            label62.Text = "ガイダンス(CFG)スケール#";
            // 
            // nudGuidanceScale
            // 
            nudGuidanceScale.DecimalPlaces = 4;
            nudGuidanceScale.Location = new Point(140, 134);
            nudGuidanceScale.Name = "nudGuidanceScale";
            nudGuidanceScale.Size = new Size(120, 23);
            nudGuidanceScale.TabIndex = 3;
            // 
            // label78
            // 
            label78.AutoSize = true;
            label78.Location = new Point(347, 118);
            label78.Name = "label78";
            label78.Size = new Size(115, 15);
            label78.TabIndex = 45;
            label78.Text = "スワップするブロック数#";
            // 
            // cbxApplyClipAttnMask
            // 
            cbxApplyClipAttnMask.AutoSize = true;
            cbxApplyClipAttnMask.Location = new Point(390, 32);
            cbxApplyClipAttnMask.Name = "cbxApplyClipAttnMask";
            cbxApplyClipAttnMask.Size = new Size(192, 19);
            cbxApplyClipAttnMask.TabIndex = 9;
            cbxApplyClipAttnMask.Text = "CLIP L/Gにattn maskを適用(SD3)";
            cbxApplyClipAttnMask.UseVisualStyleBackColor = true;
            // 
            // cbxApplyT5AttnMask
            // 
            cbxApplyT5AttnMask.AutoSize = true;
            cbxApplyT5AttnMask.Location = new Point(390, 58);
            cbxApplyT5AttnMask.Name = "cbxApplyT5AttnMask";
            cbxApplyT5AttnMask.Size = new Size(131, 19);
            cbxApplyT5AttnMask.TabIndex = 7;
            cbxApplyT5AttnMask.Text = "T5にattn maskを適用";
            cbxApplyT5AttnMask.UseVisualStyleBackColor = true;
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.Location = new Point(380, 86);
            label61.Name = "label61";
            label61.Size = new Size(82, 15);
            label61.TabIndex = 2;
            label61.Text = "離散フローシフト";
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Location = new Point(8, 364);
            label56.Name = "label56";
            label56.Size = new Size(205, 30);
            label56.TabIndex = 58;
            label56.Text = "#がつく項目は0を指定すると未指定にする\r\n##がつく項目は空欄で未指定にする";
            // 
            // tabPageExp
            // 
            tabPageExp.Controls.Add(label79);
            tabPageExp.Controls.Add(nudImmiscibleNoise);
            tabPageExp.Controls.Add(label55);
            tabPageExp.Location = new Point(4, 24);
            tabPageExp.Name = "tabPageExp";
            tabPageExp.Size = new Size(660, 324);
            tabPageExp.TabIndex = 14;
            tabPageExp.Text = "試験的";
            tabPageExp.UseVisualStyleBackColor = true;
            // 
            // label79
            // 
            label79.AutoSize = true;
            label79.Location = new Point(18, 12);
            label79.Name = "label79";
            label79.Size = new Size(352, 30);
            label79.TabIndex = 57;
            label79.Text = "ここにある機能は、まだPull Requestの段階で公式で実装されていません。\r\n使用するには、その機能のPull Requestのcheckoutが必要です。";
            // 
            // FormAdvanced
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(692, 455);
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
            ((System.ComponentModel.ISupportInitialize)nudHuberC).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudImmiscibleNoise).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIpNoiseGamma).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSchedulerTimescale).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinLRRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLRDecaySteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCaptionTagDropout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBlocksToSwap).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscreteFlowShift).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBucketReso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBucketReso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMomentum).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdaptiveNoiseScale).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseIterations).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiresNoiseDiscount).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTEBatchSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDyLoRAUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudConvAlpha).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudT5DropoutRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudClipGDropoutRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxNormReg).EndInit();
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pageMisc.ResumeLayout(false);
            pageMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxTokensT5).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSigmoidScale).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGuidanceScale).EndInit();
            tabPageExp.ResumeLayout(false);
            tabPageExp.PerformLayout();
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
        private Label label44;
        private NumericUpDown nudNetworkDropout;
        private Label label45;
        private TabPage tabPage7;
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
        private Label label55;
        private NumericUpDown nudImmiscibleNoise;
        private TabPage tabPage8;
        private NumericUpDown nudSigmoidScale;
        private Label label59;
        private ComboBox cbxModelPredictionType;
        private Label label60;
        private ComboBox cbxTimestepSampling;
        private Label label58;
        private NumericUpDown nudGuidanceScale;
        private Label label62;
        private NumericUpDown nudDiscreteFlowShift;
        private Label label61;
        private CheckBox cbxSplitMode;
        private ComboBox cbxTrainBlock;
        private Label label63;
        private Button btnClearT5XXLPath;
        private Button btnClearClipLPath;
        private Button btnT5XXLPath;
        private Button btnClipLPath;
        private Label lblT5XXLPath;
        private Label lblClipLPath;
        private Label label68;
        private CheckBox cbxApplyT5AttnMask;
        private Label label67;
        private CheckBox cbxCpuOffloadCheckpointing;
        private CheckBox cbxTrainT5XXL;
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
        private CheckBox cbxApplyClipAttnMask;
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
        private Label label78;
        private NumericUpDown nudBlocksToSwap;
        private Label label64;
        private GroupBox groupBox1;
        private Label label65;
        private TextBox tbxEps1;
        private TabPage tabPageExp;
        private Label label79;
    }
}
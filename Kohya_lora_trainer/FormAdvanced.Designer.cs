
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
            cbxScaleVPredLoss = new CheckBox();
            cbxUseColorAug = new CheckBox();
            cbxCacheLatents = new CheckBox();
            cbxMixedPrecision = new ComboBox();
            nudLRSchedulerCycle = new NumericUpDown();
            cbxAlgoType = new ComboBox();
            cbxUseWarmupInit = new CheckBox();
            cbxUseGradient = new CheckBox();
            nudNoiseOffset = new NumericUpDown();
            nudCaptionDropout = new NumericUpDown();
            cbxUseParametarization = new CheckBox();
            cbxDontSaveMetadata = new CheckBox();
            nudDataLoaderThreads = new NumericUpDown();
            tbxExtension = new TextBox();
            nudClipSkip = new NumericUpDown();
            cbxUseWeightedCaption = new CheckBox();
            cbxCacheTextEncoder = new CheckBox();
            nudSeed = new NumericUpDown();
            cbxAdvancedTrain = new ComboBox();
            nudMaxTokens = new NumericUpDown();
            cbxUseConv2d = new CheckBox();
            nudConvDim = new NumericUpDown();
            cbxCacheLatentsToDisk = new CheckBox();
            cbxCropRandomly = new CheckBox();
            cbxNoHalfVae = new CheckBox();
            cbxFlipAug = new CheckBox();
            label6 = new Label();
            label9 = new Label();
            button1 = new Button();
            nudMinBucketReso = new NumericUpDown();
            nudMaxBucketReso = new NumericUpDown();
            label10 = new Label();
            cbxScheduler = new ComboBox();
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
            nudMinSNRGamma = new NumericUpDown();
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
            label23 = new Label();
            label25 = new Label();
            label24 = new Label();
            tabPage4 = new TabPage();
            label39 = new Label();
            label44 = new Label();
            label38 = new Label();
            label37 = new Label();
            label36 = new Label();
            nudMaxNormReg = new NumericUpDown();
            nudNetworkDropout = new NumericUpDown();
            nudModuleDropout = new NumericUpDown();
            nudRankDropout = new NumericUpDown();
            cbxUseV2 = new CheckBox();
            label26 = new Label();
            label28 = new Label();
            tabPage7 = new TabPage();
            groupBox1 = new GroupBox();
            cbxCacheTextencoderToDisk = new CheckBox();
            cbxUseFastLoading = new CheckBox();
            label29 = new Label();
            label27 = new Label();
            tabPage5 = new TabPage();
            label43 = new Label();
            label42 = new Label();
            cbxUseSafeguard = new CheckBox();
            cbxUseBiasCorrection = new CheckBox();
            cbxNoProx = new CheckBox();
            cbxDecouple = new CheckBox();
            tbxMomentum = new TextBox();
            label30 = new Label();
            tbxWeightDecay = new TextBox();
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
            label40 = new Label();
            tbxComment = new TextBox();
            label8 = new Label();
            tabPage6 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)tbrCpuThreads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLRSchedulerCycle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNoiseOffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCaptionDropout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDataLoaderThreads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClipSkip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxTokens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudConvDim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBucketReso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBucketReso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMomentum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdaptiveNoiseScale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinSNRGamma).BeginInit();
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
            tabPage7.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage2.SuspendLayout();
            pageMisc.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // tbxUnetLR
            // 
            tbxUnetLR.Location = new Point(202, 70);
            tbxUnetLR.Margin = new Padding(3, 4, 3, 4);
            tbxUnetLR.Name = "tbxUnetLR";
            tbxUnetLR.Size = new Size(100, 31);
            tbxUnetLR.TabIndex = 0;
            toolTip1.SetToolTip(tbxUnetLR, "一部のDADaptation系では使用不可");
            tbxUnetLR.TextChanged += tbxUnetLR_TextChanged;
            // 
            // tbxTextEncoLR
            // 
            tbxTextEncoLR.Location = new Point(538, 68);
            tbxTextEncoLR.Margin = new Padding(3, 4, 3, 4);
            tbxTextEncoLR.Name = "tbxTextEncoLR";
            tbxTextEncoLR.Size = new Size(100, 31);
            tbxTextEncoLR.TabIndex = 1;
            toolTip1.SetToolTip(tbxTextEncoLR, "一部のDADaptation系では使用不可");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 74);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 2;
            label1.Text = "UNet LR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 70);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 3;
            label2.Text = "Text encoder LR";
            // 
            // lblMinBucketReso
            // 
            lblMinBucketReso.AutoSize = true;
            lblMinBucketReso.Location = new Point(38, 111);
            lblMinBucketReso.Name = "lblMinBucketReso";
            lblMinBucketReso.Size = new Size(163, 25);
            lblMinBucketReso.TabIndex = 4;
            lblMinBucketReso.Text = "最小バケット解像度*";
            // 
            // lblMaxBucketReso
            // 
            lblMaxBucketReso.AutoSize = true;
            lblMaxBucketReso.Location = new Point(370, 111);
            lblMaxBucketReso.Name = "lblMaxBucketReso";
            lblMaxBucketReso.Size = new Size(163, 25);
            lblMaxBucketReso.TabIndex = 7;
            lblMaxBucketReso.Text = "最大バケット解像度*";
            // 
            // cbxNoUpscale
            // 
            cbxNoUpscale.AutoSize = true;
            cbxNoUpscale.Location = new Point(123, 291);
            cbxNoUpscale.Name = "cbxNoUpscale";
            cbxNoUpscale.Size = new Size(283, 29);
            cbxNoUpscale.TabIndex = 8;
            cbxNoUpscale.Text = "バケットのアップスケーリングをしない";
            toolTip1.SetToolTip(cbxNoUpscale, "バケットの解像度は自動設定になる");
            cbxNoUpscale.UseVisualStyleBackColor = true;
            // 
            // tbrCpuThreads
            // 
            tbrCpuThreads.BackColor = Color.WhiteSmoke;
            tbrCpuThreads.Location = new Point(166, 28);
            tbrCpuThreads.Maximum = 32;
            tbrCpuThreads.Minimum = 1;
            tbrCpuThreads.Name = "tbrCpuThreads";
            tbrCpuThreads.Size = new Size(470, 69);
            tbrCpuThreads.TabIndex = 9;
            toolTip1.SetToolTip(tbrCpuThreads, "基本的に上げても速くならない\r\nページング使用量増加");
            tbrCpuThreads.Value = 12;
            tbrCpuThreads.Scroll += tbrCpuThreads_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 28);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 10;
            label5.Text = "CPUスレッド数*";
            // 
            // lblCpuThreadsCounter
            // 
            lblCpuThreadsCounter.AutoSize = true;
            lblCpuThreadsCounter.Location = new Point(642, 28);
            lblCpuThreadsCounter.Name = "lblCpuThreadsCounter";
            lblCpuThreadsCounter.Size = new Size(32, 25);
            lblCpuThreadsCounter.TabIndex = 11;
            lblCpuThreadsCounter.Text = "12";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 202);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 13;
            label7.Text = "Clip Skip";
            // 
            // cbxPrecision
            // 
            cbxPrecision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPrecision.FormattingEnabled = true;
            cbxPrecision.Items.AddRange(new object[] { "fp16", "bf16", "float" });
            cbxPrecision.Location = new Point(502, 266);
            cbxPrecision.Name = "cbxPrecision";
            cbxPrecision.Size = new Size(121, 33);
            cbxPrecision.TabIndex = 29;
            toolTip1.SetToolTip(cbxPrecision, "fp16にするとファイルサイズ半減\r\nbf16は互換性の観点から非推奨");
            // 
            // cbxCrossAttenType
            // 
            cbxCrossAttenType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCrossAttenType.FormattingEnabled = true;
            cbxCrossAttenType.Items.AddRange(new object[] { "xformers", "mem_eff_attn" });
            cbxCrossAttenType.Location = new Point(254, 159);
            cbxCrossAttenType.Name = "cbxCrossAttenType";
            cbxCrossAttenType.Size = new Size(192, 33);
            cbxCrossAttenType.TabIndex = 38;
            toolTip1.SetToolTip(cbxCrossAttenType, "mef_eff_attenは省メモリだが遅い");
            // 
            // cbxScaleVPredLoss
            // 
            cbxScaleVPredLoss.AutoSize = true;
            cbxScaleVPredLoss.Location = new Point(50, 100);
            cbxScaleVPredLoss.Name = "cbxScaleVPredLoss";
            cbxScaleVPredLoss.Size = new Size(265, 29);
            cbxScaleVPredLoss.TabIndex = 26;
            cbxScaleVPredLoss.Text = "v-prediction lossのスケーリング";
            toolTip1.SetToolTip(cbxScaleVPredLoss, "SD1.xでは非推奨");
            cbxScaleVPredLoss.UseVisualStyleBackColor = true;
            // 
            // cbxUseColorAug
            // 
            cbxUseColorAug.AutoSize = true;
            cbxUseColorAug.Location = new Point(460, 290);
            cbxUseColorAug.Name = "cbxUseColorAug";
            cbxUseColorAug.Size = new Size(222, 29);
            cbxUseColorAug.TabIndex = 7;
            cbxUseColorAug.Text = "画像の色をランダムに調整";
            toolTip1.SetToolTip(cbxUseColorAug, "毎回ランダムに画像の色を変える\r\nlatentのキャッシュとの併用は不可");
            cbxUseColorAug.UseVisualStyleBackColor = true;
            // 
            // cbxCacheLatents
            // 
            cbxCacheLatents.AutoSize = true;
            cbxCacheLatents.Location = new Point(52, 222);
            cbxCacheLatents.Name = "cbxCacheLatents";
            cbxCacheLatents.Size = new Size(161, 29);
            cbxCacheLatents.TabIndex = 22;
            cbxCacheLatents.Text = "latentのキャッシュ";
            toolTip1.SetToolTip(cbxCacheLatents, "VRAM消費削減および速度改善\r\n画像反転以外のaugmentationは利用不可");
            cbxCacheLatents.UseVisualStyleBackColor = true;
            // 
            // cbxMixedPrecision
            // 
            cbxMixedPrecision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMixedPrecision.FormattingEnabled = true;
            cbxMixedPrecision.Items.AddRange(new object[] { "なし", "fp16", "bf16" });
            cbxMixedPrecision.Location = new Point(554, 114);
            cbxMixedPrecision.Name = "cbxMixedPrecision";
            cbxMixedPrecision.Size = new Size(120, 33);
            cbxMixedPrecision.TabIndex = 14;
            toolTip1.SetToolTip(cbxMixedPrecision, "bf16はNVIDIA Ampere世代以降のみ対応");
            // 
            // nudLRSchedulerCycle
            // 
            nudLRSchedulerCycle.Location = new Point(717, 28);
            nudLRSchedulerCycle.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            nudLRSchedulerCycle.Name = "nudLRSchedulerCycle";
            nudLRSchedulerCycle.Size = new Size(120, 31);
            nudLRSchedulerCycle.TabIndex = 16;
            toolTip1.SetToolTip(nudLRSchedulerCycle, "LR調整の周期");
            nudLRSchedulerCycle.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // cbxAlgoType
            // 
            cbxAlgoType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAlgoType.FormattingEnabled = true;
            cbxAlgoType.Items.AddRange(new object[] { "lora", "loha", "ia3", "lokr" });
            cbxAlgoType.Location = new Point(202, 182);
            cbxAlgoType.Name = "cbxAlgoType";
            cbxAlgoType.Size = new Size(121, 33);
            cbxAlgoType.TabIndex = 14;
            toolTip1.SetToolTip(cbxAlgoType, "lora以外の実質的なdimはdim^2になる\r\nlora以外は重い");
            // 
            // cbxUseWarmupInit
            // 
            cbxUseWarmupInit.AutoSize = true;
            cbxUseWarmupInit.Location = new Point(50, 136);
            cbxUseWarmupInit.Name = "cbxUseWarmupInit";
            cbxUseWarmupInit.Size = new Size(302, 29);
            cbxUseWarmupInit.TabIndex = 18;
            cbxUseWarmupInit.Text = "AdaFactor: warmup_initを使用する";
            toolTip1.SetToolTip(cbxUseWarmupInit, "必要なステップ数がだいたい1万以上になる");
            cbxUseWarmupInit.UseVisualStyleBackColor = true;
            // 
            // cbxUseGradient
            // 
            cbxUseGradient.AutoSize = true;
            cbxUseGradient.Location = new Point(52, 292);
            cbxUseGradient.Name = "cbxUseGradient";
            cbxUseGradient.Size = new Size(301, 29);
            cbxUseGradient.TabIndex = 18;
            cbxUseGradient.Text = "gradient_checkpointingを使用する";
            toolTip1.SetToolTip(cbxUseGradient, "VRAM消費削減および増加を強く抑制\r\n速度がやや低下する\r\nVRAM不足の場合のみオン推奨");
            cbxUseGradient.UseVisualStyleBackColor = true;
            // 
            // nudNoiseOffset
            // 
            nudNoiseOffset.DecimalPlaces = 4;
            nudNoiseOffset.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudNoiseOffset.Location = new Point(242, 33);
            nudNoiseOffset.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudNoiseOffset.Name = "nudNoiseOffset";
            nudNoiseOffset.Size = new Size(120, 31);
            nudNoiseOffset.TabIndex = 44;
            toolTip1.SetToolTip(nudNoiseOffset, "暗い部分の改善効果があるかも");
            // 
            // nudCaptionDropout
            // 
            nudCaptionDropout.DecimalPlaces = 2;
            nudCaptionDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudCaptionDropout.Location = new Point(717, 104);
            nudCaptionDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCaptionDropout.Name = "nudCaptionDropout";
            nudCaptionDropout.Size = new Size(120, 31);
            nudCaptionDropout.TabIndex = 24;
            toolTip1.SetToolTip(nudCaptionDropout, "一定確率でキャプションを切り落とす");
            // 
            // cbxUseParametarization
            // 
            cbxUseParametarization.AutoSize = true;
            cbxUseParametarization.Location = new Point(50, 66);
            cbxUseParametarization.Name = "cbxUseParametarization";
            cbxUseParametarization.Size = new Size(221, 29);
            cbxUseParametarization.TabIndex = 10;
            cbxUseParametarization.Text = "パラメタリゼーションの使用";
            toolTip1.SetToolTip(cbxUseParametarization, "SD2.X向け");
            cbxUseParametarization.UseVisualStyleBackColor = true;
            // 
            // cbxDontSaveMetadata
            // 
            cbxDontSaveMetadata.AutoSize = true;
            cbxDontSaveMetadata.Location = new Point(50, 171);
            cbxDontSaveMetadata.Name = "cbxDontSaveMetadata";
            cbxDontSaveMetadata.Size = new Size(198, 29);
            cbxDontSaveMetadata.TabIndex = 11;
            cbxDontSaveMetadata.Text = "メタデータを保存しない";
            toolTip1.SetToolTip(cbxDontSaveMetadata, "1111のiボタンで出る学習情報に最小限の情報のみ書き込む\r\nnetwork_dim/alphaやSDバージョンなどのみでデータセット関連は書き込まない");
            cbxDontSaveMetadata.UseVisualStyleBackColor = true;
            // 
            // nudDataLoaderThreads
            // 
            nudDataLoaderThreads.Location = new Point(254, 114);
            nudDataLoaderThreads.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            nudDataLoaderThreads.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDataLoaderThreads.Name = "nudDataLoaderThreads";
            nudDataLoaderThreads.Size = new Size(192, 31);
            nudDataLoaderThreads.TabIndex = 18;
            toolTip1.SetToolTip(nudDataLoaderThreads, "上げるとCPUボトルネックが減少することがある\r\nページング使用量増加");
            nudDataLoaderThreads.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // tbxExtension
            // 
            tbxExtension.Location = new Point(192, 262);
            tbxExtension.Name = "tbxExtension";
            tbxExtension.Size = new Size(126, 31);
            tbxExtension.TabIndex = 19;
            tbxExtension.Text = ".txt";
            toolTip1.SetToolTip(tbxExtension, "ピリオド込みで入力する");
            // 
            // nudClipSkip
            // 
            nudClipSkip.Location = new Point(190, 200);
            nudClipSkip.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            nudClipSkip.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudClipSkip.Name = "nudClipSkip";
            nudClipSkip.Size = new Size(120, 31);
            nudClipSkip.TabIndex = 28;
            toolTip1.SetToolTip(nudClipSkip, "イラストは2、実写は1が良いとされる");
            nudClipSkip.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // cbxUseWeightedCaption
            // 
            cbxUseWeightedCaption.AutoSize = true;
            cbxUseWeightedCaption.Location = new Point(123, 326);
            cbxUseWeightedCaption.Name = "cbxUseWeightedCaption";
            cbxUseWeightedCaption.Size = new Size(242, 29);
            cbxUseWeightedCaption.TabIndex = 48;
            cbxUseWeightedCaption.Text = "キャプションに重みづけを使用";
            toolTip1.SetToolTip(cbxUseWeightedCaption, "キャプションでカッコなどを強調として使用する\r\nAUTOMATIC1111 WebUIと同様の記法");
            cbxUseWeightedCaption.UseVisualStyleBackColor = true;
            // 
            // cbxCacheTextEncoder
            // 
            cbxCacheTextEncoder.AutoSize = true;
            cbxCacheTextEncoder.Location = new Point(15, 64);
            cbxCacheTextEncoder.Name = "cbxCacheTextEncoder";
            cbxCacheTextEncoder.Size = new Size(267, 29);
            cbxCacheTextEncoder.TabIndex = 18;
            cbxCacheTextEncoder.Text = "Text Encoderの出力のキャッシュ";
            toolTip1.SetToolTip(cbxCacheTextEncoder, "キャプション関連のオプションは使用不可");
            cbxCacheTextEncoder.UseVisualStyleBackColor = true;
            // 
            // nudSeed
            // 
            nudSeed.Location = new Point(502, 200);
            nudSeed.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            nudSeed.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            nudSeed.Name = "nudSeed";
            nudSeed.Size = new Size(120, 31);
            nudSeed.TabIndex = 23;
            toolTip1.SetToolTip(nudSeed, "特定のシードが良いとされるが真偽不明");
            nudSeed.Value = new decimal(new int[] { 42, 0, 0, 0 });
            // 
            // cbxAdvancedTrain
            // 
            cbxAdvancedTrain.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAdvancedTrain.FormattingEnabled = true;
            cbxAdvancedTrain.Items.AddRange(new object[] { "両方学習", "TextEncoderのみ学習", "UNetのみ学習" });
            cbxAdvancedTrain.Location = new Point(538, 26);
            cbxAdvancedTrain.Name = "cbxAdvancedTrain";
            cbxAdvancedTrain.Size = new Size(205, 33);
            cbxAdvancedTrain.TabIndex = 36;
            toolTip1.SetToolTip(cbxAdvancedTrain, "SDXLの場合はTEが2つあるため、unetのみ推奨");
            // 
            // nudMaxTokens
            // 
            nudMaxTokens.Increment = new decimal(new int[] { 75, 0, 0, 0 });
            nudMaxTokens.Location = new Point(717, 66);
            nudMaxTokens.Maximum = new decimal(new int[] { 225, 0, 0, 0 });
            nudMaxTokens.Minimum = new decimal(new int[] { 75, 0, 0, 0 });
            nudMaxTokens.Name = "nudMaxTokens";
            nudMaxTokens.Size = new Size(120, 31);
            nudMaxTokens.TabIndex = 17;
            toolTip1.SetToolTip(nudMaxTokens, "コンマ区切りではなくCLIPのトークン数");
            nudMaxTokens.Value = new decimal(new int[] { 75, 0, 0, 0 });
            // 
            // cbxUseConv2d
            // 
            cbxUseConv2d.AutoSize = true;
            cbxUseConv2d.Location = new Point(123, 256);
            cbxUseConv2d.Name = "cbxUseConv2d";
            cbxUseConv2d.Size = new Size(242, 29);
            cbxUseConv2d.TabIndex = 20;
            cbxUseConv2d.Text = "LoRAでConv2d拡張を使用";
            toolTip1.SetToolTip(cbxUseConv2d, "畳み込み層も学習する\r\nキャラLoRAはオフでよい");
            cbxUseConv2d.UseVisualStyleBackColor = true;
            // 
            // nudConvDim
            // 
            nudConvDim.Location = new Point(202, 144);
            nudConvDim.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudConvDim.Name = "nudConvDim";
            nudConvDim.Size = new Size(120, 31);
            nudConvDim.TabIndex = 18;
            toolTip1.SetToolTip(nudConvDim, "畳み込み層(Attnが無い層)の次元数");
            // 
            // cbxCacheLatentsToDisk
            // 
            cbxCacheLatentsToDisk.AutoSize = true;
            cbxCacheLatentsToDisk.Location = new Point(52, 256);
            cbxCacheLatentsToDisk.Name = "cbxCacheLatentsToDisk";
            cbxCacheLatentsToDisk.Size = new Size(227, 29);
            cbxCacheLatentsToDisk.TabIndex = 23;
            cbxCacheLatentsToDisk.Text = "latentをディスクにキャッシュ";
            toolTip1.SetToolTip(cbxCacheLatentsToDisk, "latentのキャッシュもオンにする必要あり");
            cbxCacheLatentsToDisk.UseVisualStyleBackColor = true;
            // 
            // cbxCropRandomly
            // 
            cbxCropRandomly.AutoSize = true;
            cbxCropRandomly.Location = new Point(460, 324);
            cbxCropRandomly.Name = "cbxCropRandomly";
            cbxCropRandomly.Size = new Size(206, 29);
            cbxCropRandomly.TabIndex = 9;
            cbxCropRandomly.Text = "画像をランダムにクロップ";
            toolTip1.SetToolTip(cbxCropRandomly, "latentキャッシュとの併用不可");
            cbxCropRandomly.UseVisualStyleBackColor = true;
            // 
            // cbxNoHalfVae
            // 
            cbxNoHalfVae.AutoSize = true;
            cbxNoHalfVae.Location = new Point(15, 30);
            cbxNoHalfVae.Name = "cbxNoHalfVae";
            cbxNoHalfVae.Size = new Size(322, 29);
            cbxNoHalfVae.TabIndex = 18;
            cbxNoHalfVae.Text = "VAEを32ビットで使用(SDXLでほぼ必須)";
            toolTip1.SetToolTip(cbxNoHalfVae, "no-half VAE\r\nVAEのNaN演算をなくす");
            cbxNoHalfVae.UseVisualStyleBackColor = true;
            // 
            // cbxFlipAug
            // 
            cbxFlipAug.AutoSize = true;
            cbxFlipAug.Location = new Point(460, 256);
            cbxFlipAug.Name = "cbxFlipAug";
            cbxFlipAug.Size = new Size(160, 29);
            cbxFlipAug.TabIndex = 8;
            cbxFlipAug.Text = "反転画像を使用";
            toolTip1.SetToolTip(cbxFlipAug, "反転画像でデータセットを水増し");
            cbxFlipAug.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(404, 201);
            label6.Name = "label6";
            label6.Size = new Size(94, 50);
            label6.TabIndex = 16;
            label6.Text = "Seed\r\n-1でランダム";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 266);
            label9.Name = "label9";
            label9.Size = new Size(155, 50);
            label9.TabIndex = 20;
            label9.Text = "キャプションファイルの\r\n拡張子";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(690, 460);
            button1.Name = "button1";
            button1.Size = new Size(260, 44);
            button1.TabIndex = 22;
            button1.Text = "設定を反映して閉じる";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nudMinBucketReso
            // 
            nudMinBucketReso.Increment = new decimal(new int[] { 64, 0, 0, 0 });
            nudMinBucketReso.Location = new Point(202, 110);
            nudMinBucketReso.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudMinBucketReso.Minimum = new decimal(new int[] { 64, 0, 0, 0 });
            nudMinBucketReso.Name = "nudMinBucketReso";
            nudMinBucketReso.Size = new Size(120, 31);
            nudMinBucketReso.TabIndex = 24;
            nudMinBucketReso.Value = new decimal(new int[] { 320, 0, 0, 0 });
            nudMinBucketReso.ValueChanged += nudMinBucketReso_ValueChanged;
            // 
            // nudMaxBucketReso
            // 
            nudMaxBucketReso.Increment = new decimal(new int[] { 64, 0, 0, 0 });
            nudMaxBucketReso.Location = new Point(538, 110);
            nudMaxBucketReso.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            nudMaxBucketReso.Minimum = new decimal(new int[] { 128, 0, 0, 0 });
            nudMaxBucketReso.Name = "nudMaxBucketReso";
            nudMaxBucketReso.Size = new Size(120, 31);
            nudMaxBucketReso.TabIndex = 25;
            nudMaxBucketReso.Value = new decimal(new int[] { 960, 0, 0, 0 });
            nudMaxBucketReso.ValueChanged += nudMaxBucketReso_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 26);
            label10.Name = "label10";
            label10.Size = new Size(91, 25);
            label10.TabIndex = 26;
            label10.Text = "スケジューラ";
            // 
            // cbxScheduler
            // 
            cbxScheduler.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxScheduler.FormattingEnabled = true;
            cbxScheduler.Items.AddRange(new object[] { "cosine_with_restarts", "cosine", "linear", "polynomial", "constant", "constant_with_warmup" });
            cbxScheduler.Location = new Point(159, 22);
            cbxScheduler.Name = "cbxScheduler";
            cbxScheduler.Size = new Size(212, 33);
            cbxScheduler.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(381, 268);
            label11.Name = "label11";
            label11.Size = new Size(117, 25);
            label11.TabIndex = 30;
            label11.Text = "保存時の精度";
            // 
            // btnDiscardAndClose
            // 
            btnDiscardAndClose.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiscardAndClose.Location = new Point(422, 460);
            btnDiscardAndClose.Name = "btnDiscardAndClose";
            btnDiscardAndClose.Size = new Size(256, 44);
            btnDiscardAndClose.TabIndex = 31;
            btnDiscardAndClose.Text = "設定を反映せずに閉じる";
            btnDiscardAndClose.UseVisualStyleBackColor = true;
            btnDiscardAndClose.Click += btnDiscardAndClose_Click;
            // 
            // btnTensorBoardPath
            // 
            btnTensorBoardPath.Location = new Point(230, 176);
            btnTensorBoardPath.Name = "btnTensorBoardPath";
            btnTensorBoardPath.Size = new Size(110, 46);
            btnTensorBoardPath.TabIndex = 32;
            btnTensorBoardPath.Text = "選択";
            btnTensorBoardPath.UseVisualStyleBackColor = true;
            btnTensorBoardPath.Click += button2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(100, 176);
            label12.Name = "label12";
            label12.Size = new Size(129, 50);
            label12.TabIndex = 33;
            label12.Text = "Tensorboard用\r\nログ出力先";
            // 
            // lblTBoardPath
            // 
            lblTBoardPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTBoardPath.Location = new Point(106, 225);
            lblTBoardPath.Name = "lblTBoardPath";
            lblTBoardPath.Size = new Size(320, 46);
            lblTBoardPath.TabIndex = 34;
            lblTBoardPath.Text = "D:\\Sample\\Please stop using Super Long Naming\\RegImage\\1_1girl";
            // 
            // btnClearTBoardPath
            // 
            btnClearTBoardPath.Location = new Point(345, 176);
            btnClearTBoardPath.Name = "btnClearTBoardPath";
            btnClearTBoardPath.Size = new Size(100, 46);
            btnClearTBoardPath.TabIndex = 35;
            btnClearTBoardPath.Text = "クリア";
            btnClearTBoardPath.UseVisualStyleBackColor = true;
            btnClearTBoardPath.Click += btnClearTBoardPath_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(398, 28);
            label13.Name = "label13";
            label13.Size = new Size(128, 25);
            label13.TabIndex = 37;
            label13.Text = "UNet/TEの学習";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 164);
            label4.Name = "label4";
            label4.Size = new Size(183, 25);
            label4.TabIndex = 40;
            label4.Text = "クロスアテンションの種類";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 44);
            label3.Name = "label3";
            label3.Size = new Size(113, 50);
            label3.TabIndex = 41;
            label3.Text = "追加学習する\r\nLoRAモデル";
            // 
            // btnSelectLoRAmodel
            // 
            btnSelectLoRAmodel.Location = new Point(230, 44);
            btnSelectLoRAmodel.Name = "btnSelectLoRAmodel";
            btnSelectLoRAmodel.Size = new Size(110, 45);
            btnSelectLoRAmodel.TabIndex = 42;
            btnSelectLoRAmodel.Text = "選択";
            btnSelectLoRAmodel.UseVisualStyleBackColor = true;
            btnSelectLoRAmodel.Click += btnSelectLoRAmodel_Click;
            // 
            // btnClearLoRAmodel
            // 
            btnClearLoRAmodel.Location = new Point(345, 44);
            btnClearLoRAmodel.Name = "btnClearLoRAmodel";
            btnClearLoRAmodel.Size = new Size(110, 45);
            btnClearLoRAmodel.TabIndex = 42;
            btnClearLoRAmodel.Text = "クリア";
            btnClearLoRAmodel.UseVisualStyleBackColor = true;
            btnClearLoRAmodel.Click += btnClearLoRAmodel_Click;
            // 
            // lblLoRAmodelPath
            // 
            lblLoRAmodelPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoRAmodelPath.Location = new Point(122, 108);
            lblLoRAmodelPath.Name = "lblLoRAmodelPath";
            lblLoRAmodelPath.Size = new Size(334, 46);
            lblLoRAmodelPath.TabIndex = 43;
            lblLoRAmodelPath.Text = "C:\\Sample\\SuperLong\\Multibyte\\and\\spaces\\日本語.safetensors";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(110, 36);
            label14.Name = "label14";
            label14.Size = new Size(126, 25);
            label14.TabIndex = 45;
            label14.Text = "ノイズオフセット#";
            // 
            // nudMomentum
            // 
            nudMomentum.DecimalPlaces = 4;
            nudMomentum.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudMomentum.Location = new Point(717, 285);
            nudMomentum.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMomentum.Name = "nudMomentum";
            nudMomentum.Size = new Size(120, 31);
            nudMomentum.TabIndex = 44;
            nudMomentum.Value = new decimal(new int[] { 9, 0, 0, 65536 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(590, 285);
            label15.Name = "label15";
            label15.Size = new Size(117, 50);
            label15.TabIndex = 45;
            label15.Text = "Nesterovの\r\nmomentum#";
            // 
            // btnSelectVAE
            // 
            btnSelectVAE.Location = new Point(598, 48);
            btnSelectVAE.Name = "btnSelectVAE";
            btnSelectVAE.Size = new Size(100, 45);
            btnSelectVAE.TabIndex = 46;
            btnSelectVAE.Text = "選択";
            btnSelectVAE.UseVisualStyleBackColor = true;
            btnSelectVAE.Click += btnSelectVAE_Click;
            // 
            // btnClearVAE
            // 
            btnClearVAE.Location = new Point(705, 46);
            btnClearVAE.Name = "btnClearVAE";
            btnClearVAE.Size = new Size(100, 45);
            btnClearVAE.TabIndex = 46;
            btnClearVAE.Text = "クリア";
            btnClearVAE.UseVisualStyleBackColor = true;
            btnClearVAE.Click += btnClearVAE_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(524, 57);
            label16.Name = "label16";
            label16.Size = new Size(43, 25);
            label16.TabIndex = 47;
            label16.Text = "VAE";
            // 
            // lblVAEPath
            // 
            lblVAEPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblVAEPath.Location = new Point(489, 96);
            lblVAEPath.Name = "lblVAEPath";
            lblVAEPath.Size = new Size(334, 46);
            lblVAEPath.TabIndex = 43;
            lblVAEPath.Text = "C:\\Sample\\SuperLong\\Multibyte\\and\\spaces\\日本語.safetensors";
            // 
            // nudAdaptiveNoiseScale
            // 
            nudAdaptiveNoiseScale.DecimalPlaces = 1;
            nudAdaptiveNoiseScale.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudAdaptiveNoiseScale.Location = new Point(242, 74);
            nudAdaptiveNoiseScale.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudAdaptiveNoiseScale.Name = "nudAdaptiveNoiseScale";
            nudAdaptiveNoiseScale.Size = new Size(120, 31);
            nudAdaptiveNoiseScale.TabIndex = 49;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(86, 76);
            label17.Name = "label17";
            label17.Size = new Size(152, 25);
            label17.TabIndex = 50;
            label17.Text = "適応ノイズスケール#";
            // 
            // nudMinSNRGamma
            // 
            nudMinSNRGamma.Location = new Point(242, 116);
            nudMinSNRGamma.Name = "nudMinSNRGamma";
            nudMinSNRGamma.Size = new Size(120, 31);
            nudMinSNRGamma.TabIndex = 51;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(75, 118);
            label18.Name = "label18";
            label18.Size = new Size(161, 25);
            label18.TabIndex = 52;
            label18.Text = "Min-SNR Gamma#";
            // 
            // nudMultiresNoiseIterations
            // 
            nudMultiresNoiseIterations.Location = new Point(242, 154);
            nudMultiresNoiseIterations.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMultiresNoiseIterations.Name = "nudMultiresNoiseIterations";
            nudMultiresNoiseIterations.Size = new Size(120, 31);
            nudMultiresNoiseIterations.TabIndex = 53;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(20, 158);
            label19.Name = "label19";
            label19.Size = new Size(215, 25);
            label19.TabIndex = 54;
            label19.Text = "Multires Noise Iterations#";
            // 
            // nudMultiresNoiseDiscount
            // 
            nudMultiresNoiseDiscount.DecimalPlaces = 2;
            nudMultiresNoiseDiscount.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudMultiresNoiseDiscount.Location = new Point(242, 195);
            nudMultiresNoiseDiscount.Name = "nudMultiresNoiseDiscount";
            nudMultiresNoiseDiscount.Size = new Size(120, 31);
            nudMultiresNoiseDiscount.TabIndex = 55;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(26, 198);
            label20.Name = "label20";
            label20.Size = new Size(211, 25);
            label20.TabIndex = 56;
            label20.Text = "Multires Noise Discount#";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(pageMisc);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(938, 430);
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
            tabPage1.Controls.Add(cbxAlgoType);
            tabPage1.Controls.Add(lblMinBucketReso);
            tabPage1.Controls.Add(label23);
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
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(930, 392);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ページ1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(412, 184);
            label22.Name = "label22";
            label22.Size = new Size(121, 25);
            label22.TabIndex = 22;
            label22.Text = "DyLoRAのunit";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(454, 228);
            label45.Name = "label45";
            label45.Size = new Size(159, 25);
            label45.TabIndex = 27;
            label45.Text = "augmentation関連";
            // 
            // nudDyLoRAUnit
            // 
            nudDyLoRAUnit.Location = new Point(538, 184);
            nudDyLoRAUnit.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudDyLoRAUnit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDyLoRAUnit.Name = "nudDyLoRAUnit";
            nudDyLoRAUnit.Size = new Size(120, 31);
            nudDyLoRAUnit.TabIndex = 21;
            nudDyLoRAUnit.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nudConvAlpha
            // 
            nudConvAlpha.DecimalPlaces = 2;
            nudConvAlpha.Location = new Point(538, 146);
            nudConvAlpha.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudConvAlpha.Name = "nudConvAlpha";
            nudConvAlpha.Size = new Size(120, 31);
            nudConvAlpha.TabIndex = 19;
            nudConvAlpha.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(10, 184);
            label23.Name = "label23";
            label23.Size = new Size(176, 25);
            label23.TabIndex = 17;
            label23.Text = "LyCORISのアルゴリズム";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(106, 146);
            label25.Name = "label25";
            label25.Size = new Size(91, 25);
            label25.TabIndex = 15;
            label25.Text = "Conv Dim";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(429, 146);
            label24.Name = "label24";
            label24.Size = new Size(104, 25);
            label24.TabIndex = 16;
            label24.Text = "Conv Alpha";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(cbxScaleVPredLoss);
            tabPage4.Controls.Add(label39);
            tabPage4.Controls.Add(cbxDontSaveMetadata);
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
            tabPage4.Controls.Add(cbxUseV2);
            tabPage4.Controls.Add(label26);
            tabPage4.Controls.Add(cbxUseParametarization);
            tabPage4.Controls.Add(label28);
            tabPage4.Controls.Add(nudMaxTokens);
            tabPage4.Controls.Add(nudLRSchedulerCycle);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(930, 392);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "ページ2";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(488, 250);
            label39.Name = "label39";
            label39.Size = new Size(224, 25);
            label39.TabIndex = 25;
            label39.Text = "Max Norm Regularization#";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(500, 213);
            label44.Name = "label44";
            label44.Size = new Size(214, 25);
            label44.TabIndex = 25;
            label44.Text = "networkドロップアウト確率#";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(500, 178);
            label38.Name = "label38";
            label38.Size = new Size(211, 25);
            label38.TabIndex = 25;
            label38.Text = "moduleドロップアウト確率#";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(526, 142);
            label37.Name = "label37";
            label37.Size = new Size(184, 25);
            label37.TabIndex = 25;
            label37.Text = "rankドロップアウト確率#";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(502, 105);
            label36.Name = "label36";
            label36.Size = new Size(212, 25);
            label36.TabIndex = 25;
            label36.Text = "Captionドロップアウト確率#";
            // 
            // nudMaxNormReg
            // 
            nudMaxNormReg.DecimalPlaces = 2;
            nudMaxNormReg.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudMaxNormReg.Location = new Point(717, 248);
            nudMaxNormReg.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMaxNormReg.Name = "nudMaxNormReg";
            nudMaxNormReg.Size = new Size(120, 31);
            nudMaxNormReg.TabIndex = 24;
            // 
            // nudNetworkDropout
            // 
            nudNetworkDropout.DecimalPlaces = 2;
            nudNetworkDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudNetworkDropout.Location = new Point(717, 212);
            nudNetworkDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNetworkDropout.Name = "nudNetworkDropout";
            nudNetworkDropout.Size = new Size(120, 31);
            nudNetworkDropout.TabIndex = 24;
            // 
            // nudModuleDropout
            // 
            nudModuleDropout.DecimalPlaces = 2;
            nudModuleDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudModuleDropout.Location = new Point(717, 177);
            nudModuleDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudModuleDropout.Name = "nudModuleDropout";
            nudModuleDropout.Size = new Size(120, 31);
            nudModuleDropout.TabIndex = 24;
            // 
            // nudRankDropout
            // 
            nudRankDropout.DecimalPlaces = 2;
            nudRankDropout.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudRankDropout.Location = new Point(717, 140);
            nudRankDropout.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRankDropout.Name = "nudRankDropout";
            nudRankDropout.Size = new Size(120, 31);
            nudRankDropout.TabIndex = 24;
            // 
            // cbxUseV2
            // 
            cbxUseV2.AutoSize = true;
            cbxUseV2.Location = new Point(50, 32);
            cbxUseV2.Name = "cbxUseV2";
            cbxUseV2.Size = new Size(243, 29);
            cbxUseV2.TabIndex = 13;
            cbxUseV2.Text = "Stable Diffusion 2.Xを使用";
            cbxUseV2.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(594, 68);
            label26.Name = "label26";
            label26.Size = new Size(117, 25);
            label26.TabIndex = 19;
            label26.Text = "最大トークン数";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(530, 32);
            label28.Name = "label28";
            label28.Size = new Size(181, 25);
            label28.TabIndex = 21;
            label28.Text = "LRスケジューラのサイクル";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(groupBox1);
            tabPage7.Controls.Add(cbxCacheLatents);
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
            tabPage7.Location = new Point(4, 34);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(930, 392);
            tabPage7.TabIndex = 8;
            tabPage7.Text = "パフォーマンス";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxNoHalfVae);
            groupBox1.Controls.Add(cbxCacheTextEncoder);
            groupBox1.Controls.Add(cbxCacheTextencoderToDisk);
            groupBox1.Location = new Point(446, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 142);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "SDXL関連";
            // 
            // cbxCacheTextencoderToDisk
            // 
            cbxCacheTextencoderToDisk.AutoSize = true;
            cbxCacheTextencoderToDisk.Location = new Point(15, 100);
            cbxCacheTextencoderToDisk.Name = "cbxCacheTextencoderToDisk";
            cbxCacheTextencoderToDisk.Size = new Size(333, 29);
            cbxCacheTextencoderToDisk.TabIndex = 18;
            cbxCacheTextencoderToDisk.Text = "Text Encoderの出力をディスクにキャッシュ";
            cbxCacheTextencoderToDisk.UseVisualStyleBackColor = true;
            // 
            // cbxUseFastLoading
            // 
            cbxUseFastLoading.AutoSize = true;
            cbxUseFastLoading.Checked = true;
            cbxUseFastLoading.CheckState = CheckState.Checked;
            cbxUseFastLoading.Location = new Point(52, 327);
            cbxUseFastLoading.Name = "cbxUseFastLoading";
            cbxUseFastLoading.Size = new Size(143, 29);
            cbxUseFastLoading.TabIndex = 12;
            cbxUseFastLoading.Text = "読込の高速化";
            cbxUseFastLoading.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(464, 117);
            label29.Name = "label29";
            label29.Size = new Size(84, 25);
            label29.TabIndex = 15;
            label29.Text = "混合精度";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(38, 116);
            label27.Name = "label27";
            label27.Size = new Size(209, 25);
            label27.TabIndex = 20;
            label27.Text = "データローダのCPUスレッド数";
            // 
            // tabPage5
            // 
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
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(930, 392);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "DAdaptation";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(698, 94);
            label43.Name = "label43";
            label43.Size = new Size(116, 50);
            label43.TabIndex = 25;
            label43.Text = "d_coef\r\n(prodigyのみ)";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(698, 36);
            label42.Name = "label42";
            label42.Size = new Size(116, 50);
            label42.TabIndex = 25;
            label42.Text = "beta3#\r\n(prodigyのみ)";
            // 
            // cbxUseSafeguard
            // 
            cbxUseSafeguard.AutoSize = true;
            cbxUseSafeguard.Location = new Point(80, 333);
            cbxUseSafeguard.Name = "cbxUseSafeguard";
            cbxUseSafeguard.Size = new Size(341, 29);
            cbxUseSafeguard.TabIndex = 24;
            cbxUseSafeguard.Text = "safeguard warmupを使用(prodigyのみ)";
            cbxUseSafeguard.UseVisualStyleBackColor = true;
            // 
            // cbxUseBiasCorrection
            // 
            cbxUseBiasCorrection.AutoSize = true;
            cbxUseBiasCorrection.Location = new Point(80, 298);
            cbxUseBiasCorrection.Name = "cbxUseBiasCorrection";
            cbxUseBiasCorrection.Size = new Size(308, 29);
            cbxUseBiasCorrection.TabIndex = 24;
            cbxUseBiasCorrection.Text = "bias correctionを使用(prodigyのみ)";
            cbxUseBiasCorrection.UseVisualStyleBackColor = true;
            // 
            // cbxNoProx
            // 
            cbxNoProx.AutoSize = true;
            cbxNoProx.Location = new Point(80, 262);
            cbxNoProx.Name = "cbxNoProx";
            cbxNoProx.Size = new Size(201, 29);
            cbxNoProx.TabIndex = 24;
            cbxNoProx.Text = "no prox(Adan系のみ)";
            cbxNoProx.UseVisualStyleBackColor = true;
            // 
            // cbxDecouple
            // 
            cbxDecouple.AutoSize = true;
            cbxDecouple.Location = new Point(80, 228);
            cbxDecouple.Name = "cbxDecouple";
            cbxDecouple.Size = new Size(286, 29);
            cbxDecouple.TabIndex = 24;
            cbxDecouple.Text = "decoupleを有効化(Adam系のみ)";
            cbxDecouple.UseVisualStyleBackColor = true;
            // 
            // tbxMomentum
            // 
            tbxMomentum.Location = new Point(400, 80);
            tbxMomentum.Name = "tbxMomentum";
            tbxMomentum.Size = new Size(94, 31);
            tbxMomentum.TabIndex = 10;
            tbxMomentum.Text = "0";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(290, 82);
            label30.Name = "label30";
            label30.Size = new Size(106, 25);
            label30.TabIndex = 18;
            label30.Text = "momentum";
            // 
            // tbxWeightDecay
            // 
            tbxWeightDecay.Location = new Point(158, 42);
            tbxWeightDecay.Name = "tbxWeightDecay";
            tbxWeightDecay.Size = new Size(100, 31);
            tbxWeightDecay.TabIndex = 11;
            tbxWeightDecay.Text = "0";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(45, 160);
            label31.Name = "label31";
            label31.Size = new Size(106, 50);
            label31.TabIndex = 19;
            label31.Text = "growth_rate\r\n0で無制限";
            // 
            // tbxBetas0
            // 
            tbxBetas0.Location = new Point(400, 36);
            tbxBetas0.Name = "tbxBetas0";
            tbxBetas0.Size = new Size(73, 31);
            tbxBetas0.TabIndex = 12;
            tbxBetas0.Text = "0.9";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(111, 118);
            label32.Name = "label32";
            label32.Size = new Size(33, 25);
            label32.TabIndex = 20;
            label32.Text = "d0";
            // 
            // tbxBetas1
            // 
            tbxBetas1.Location = new Point(489, 36);
            tbxBetas1.Name = "tbxBetas1";
            tbxBetas1.Size = new Size(78, 31);
            tbxBetas1.TabIndex = 13;
            tbxBetas1.Text = "0.999";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(111, 82);
            label33.Name = "label33";
            label33.Size = new Size(40, 25);
            label33.TabIndex = 21;
            label33.Text = "eps";
            // 
            // tbxDCoef
            // 
            tbxDCoef.Location = new Point(819, 92);
            tbxDCoef.Name = "tbxDCoef";
            tbxDCoef.Size = new Size(78, 31);
            tbxDCoef.TabIndex = 14;
            tbxDCoef.Text = "1";
            // 
            // tbxProdigyBeta3
            // 
            tbxProdigyBeta3.Location = new Point(819, 33);
            tbxProdigyBeta3.Name = "tbxProdigyBeta3";
            tbxProdigyBeta3.Size = new Size(78, 31);
            tbxProdigyBeta3.TabIndex = 14;
            tbxProdigyBeta3.Text = "0";
            // 
            // tbxBetas2
            // 
            tbxBetas2.Location = new Point(584, 36);
            tbxBetas2.Name = "tbxBetas2";
            tbxBetas2.Size = new Size(78, 31);
            tbxBetas2.TabIndex = 14;
            tbxBetas2.Text = "0.999";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(340, 39);
            label34.Name = "label34";
            label34.Size = new Size(55, 25);
            label34.TabIndex = 22;
            label34.Text = "betas";
            // 
            // tbxEps
            // 
            tbxEps.Location = new Point(158, 80);
            tbxEps.Name = "tbxEps";
            tbxEps.Size = new Size(100, 31);
            tbxEps.TabIndex = 15;
            tbxEps.Text = "1E-06";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(33, 42);
            label35.Name = "label35";
            label35.Size = new Size(118, 25);
            label35.TabIndex = 23;
            label35.Text = "weight_decay";
            // 
            // tbxD0
            // 
            tbxD0.Location = new Point(158, 116);
            tbxD0.Name = "tbxD0";
            tbxD0.Size = new Size(100, 31);
            tbxD0.TabIndex = 16;
            tbxD0.Text = "1E-06";
            // 
            // tbxGrowthRate
            // 
            tbxGrowthRate.Location = new Point(158, 158);
            tbxGrowthRate.Name = "tbxGrowthRate";
            tbxGrowthRate.Size = new Size(100, 31);
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
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(930, 392);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "パス";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblConfigPath
            // 
            lblConfigPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfigPath.Location = new Point(594, 236);
            lblConfigPath.Name = "lblConfigPath";
            lblConfigPath.Size = new Size(280, 50);
            lblConfigPath.TabIndex = 25;
            lblConfigPath.Text = "C:\\Users\\Test\\Desktop\\long name\\aaaaa.toml";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(488, 182);
            label21.Name = "label21";
            label21.Size = new Size(106, 50);
            label21.TabIndex = 26;
            label21.Text = "dataset\r\nconfigのパス";
            // 
            // btnClearConfigPath
            // 
            btnClearConfigPath.Location = new Point(705, 176);
            btnClearConfigPath.Name = "btnClearConfigPath";
            btnClearConfigPath.Size = new Size(106, 46);
            btnClearConfigPath.TabIndex = 23;
            btnClearConfigPath.Text = "クリア";
            btnClearConfigPath.UseVisualStyleBackColor = true;
            btnClearConfigPath.Click += btnClearConfigPath_Click;
            // 
            // btnSelectConfigPath
            // 
            btnSelectConfigPath.Location = new Point(598, 176);
            btnSelectConfigPath.Name = "btnSelectConfigPath";
            btnSelectConfigPath.Size = new Size(100, 46);
            btnSelectConfigPath.TabIndex = 24;
            btnSelectConfigPath.Text = "選択";
            btnSelectConfigPath.UseVisualStyleBackColor = true;
            btnSelectConfigPath.Click += btnSelectConfigPath_Click;
            // 
            // pageMisc
            // 
            pageMisc.Controls.Add(label41);
            pageMisc.Controls.Add(label40);
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
            pageMisc.Location = new Point(4, 34);
            pageMisc.Name = "pageMisc";
            pageMisc.Size = new Size(930, 392);
            pageMisc.TabIndex = 2;
            pageMisc.Text = "その他";
            pageMisc.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(120, 72);
            label41.Name = "label41";
            label41.Size = new Size(307, 25);
            label41.TabIndex = 66;
            label41.Text = "次の文字は使用できません /\\?:*<>|\"＆'`\r\n";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(20, 38);
            label40.Name = "label40";
            label40.Size = new Size(99, 25);
            label40.TabIndex = 33;
            label40.Text = "学習コメント";
            // 
            // tbxComment
            // 
            tbxComment.Location = new Point(124, 34);
            tbxComment.Name = "tbxComment";
            tbxComment.Size = new Size(691, 31);
            tbxComment.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(42, 146);
            label8.Name = "label8";
            label8.Size = new Size(279, 30);
            label8.TabIndex = 31;
            label8.Text = "通常編集する必要のない設定";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label20);
            tabPage6.Controls.Add(nudNoiseOffset);
            tabPage6.Controls.Add(label18);
            tabPage6.Controls.Add(nudMinSNRGamma);
            tabPage6.Controls.Add(nudMultiresNoiseDiscount);
            tabPage6.Controls.Add(label17);
            tabPage6.Controls.Add(nudMultiresNoiseIterations);
            tabPage6.Controls.Add(nudAdaptiveNoiseScale);
            tabPage6.Controls.Add(label19);
            tabPage6.Controls.Add(label14);
            tabPage6.Location = new Point(4, 34);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(930, 392);
            tabPage6.TabIndex = 7;
            tabPage6.Text = "ノイズ関連";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // FormAdvanced
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(971, 516);
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
            ((System.ComponentModel.ISupportInitialize)nudMinBucketReso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBucketReso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMomentum).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdaptiveNoiseScale).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinSNRGamma).EndInit();
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
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pageMisc.ResumeLayout(false);
            pageMisc.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
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
        private CheckBox cbxUseV2;
        private Label label26;
        private CheckBox cbxUseParametarization;
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
        private CheckBox cbxScaleVPredLoss;
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
        private GroupBox groupBox1;
    }
}
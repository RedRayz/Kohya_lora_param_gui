namespace Kohya_lora_trainer
{
    partial class FormLECO
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label28 = new Label();
            nudBatchSize = new NumericUpDown();
            nudResolution = new NumericUpDown();
            label23 = new Label();
            nudGuidanceScale = new NumericUpDown();
            label22 = new Label();
            btnSavePrompts = new Button();
            label21 = new Label();
            label5 = new Label();
            cbxAction = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbxNeutral = new TextBox();
            tbxNegative = new TextBox();
            tbxPositive = new TextBox();
            tbxTarget = new TextBox();
            tabPage2 = new TabPage();
            btnSaveConfig = new Button();
            tbxOutputPath = new TextBox();
            tbxOutputName = new TextBox();
            label17 = new Label();
            tbxLRScheduler = new TextBox();
            tbxOptimizer = new TextBox();
            label16 = new Label();
            tbxLR = new TextBox();
            label14 = new Label();
            label9 = new Label();
            label13 = new Label();
            label24 = new Label();
            label12 = new Label();
            label20 = new Label();
            label8 = new Label();
            nudAlpha = new NumericUpDown();
            nudMaxDenoiseSteps = new NumericUpDown();
            nudSteps = new NumericUpDown();
            nudSaveEveryNSteps = new NumericUpDown();
            nudDim = new NumericUpDown();
            label15 = new Label();
            label11 = new Label();
            label19 = new Label();
            label25 = new Label();
            label10 = new Label();
            label7 = new Label();
            cbxNoiseScheduler = new ComboBox();
            cbxSavePrecision = new ComboBox();
            cbxMethod = new ComboBox();
            cbxTrainPrecision = new ComboBox();
            cbxType = new ComboBox();
            cbxUseXformers = new CheckBox();
            cbxVerbose = new CheckBox();
            cbxUseWandb = new CheckBox();
            cbxUseVPrediction = new CheckBox();
            cbxUseSDV2 = new CheckBox();
            label18 = new Label();
            label6 = new Label();
            tbxPromptPath = new TextBox();
            tbxModelPath = new TextBox();
            tabPage3 = new TabPage();
            label26 = new Label();
            label27 = new Label();
            btnTrainLECO = new Button();
            btnUpdateLECO = new Button();
            btnInstallLECO = new Button();
            label29 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBatchSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudResolution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGuidanceScale).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAlpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxDenoiseSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSaveEveryNSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDim).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(610, 554);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label29);
            tabPage1.Controls.Add(label28);
            tabPage1.Controls.Add(nudBatchSize);
            tabPage1.Controls.Add(nudResolution);
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(nudGuidanceScale);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(btnSavePrompts);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(cbxAction);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tbxNeutral);
            tabPage1.Controls.Add(tbxNegative);
            tabPage1.Controls.Add(tbxPositive);
            tabPage1.Controls.Add(tbxTarget);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(602, 526);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "prompts生成";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(29, 24);
            label28.Name = "label28";
            label28.Size = new Size(263, 15);
            label28.TabIndex = 6;
            label28.Text = "※改行はお控えください。LECOで読み込めなくなります";
            // 
            // nudBatchSize
            // 
            nudBatchSize.Location = new Point(229, 456);
            nudBatchSize.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            nudBatchSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudBatchSize.Name = "nudBatchSize";
            nudBatchSize.Size = new Size(72, 23);
            nudBatchSize.TabIndex = 5;
            nudBatchSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudResolution
            // 
            nudResolution.Increment = new decimal(new int[] { 64, 0, 0, 0 });
            nudResolution.Location = new Point(130, 456);
            nudResolution.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            nudResolution.Minimum = new decimal(new int[] { 64, 0, 0, 0 });
            nudResolution.Name = "nudResolution";
            nudResolution.Size = new Size(72, 23);
            nudResolution.TabIndex = 5;
            nudResolution.Value = new decimal(new int[] { 512, 0, 0, 0 });
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(229, 438);
            label23.Name = "label23";
            label23.Size = new Size(62, 15);
            label23.TabIndex = 3;
            label23.Text = "バッチサイズ";
            // 
            // nudGuidanceScale
            // 
            nudGuidanceScale.DecimalPlaces = 1;
            nudGuidanceScale.Location = new Point(34, 456);
            nudGuidanceScale.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudGuidanceScale.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGuidanceScale.Name = "nudGuidanceScale";
            nudGuidanceScale.Size = new Size(72, 23);
            nudGuidanceScale.TabIndex = 5;
            nudGuidanceScale.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(130, 438);
            label22.Name = "label22";
            label22.Size = new Size(43, 15);
            label22.TabIndex = 3;
            label22.Text = "解像度";
            // 
            // btnSavePrompts
            // 
            btnSavePrompts.Location = new Point(404, 438);
            btnSavePrompts.Name = "btnSavePrompts";
            btnSavePrompts.Size = new Size(137, 44);
            btnSavePrompts.TabIndex = 4;
            btnSavePrompts.Text = "保存";
            btnSavePrompts.UseVisualStyleBackColor = true;
            btnSavePrompts.Click += btnSavePrompts_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(29, 438);
            label21.Name = "label21";
            label21.Size = new Size(58, 15);
            label21.TabIndex = 3;
            label21.Text = "CFG Scale";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 375);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 3;
            label5.Text = "アクション";
            // 
            // cbxAction
            // 
            cbxAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAction.FormattingEnabled = true;
            cbxAction.Items.AddRange(new object[] { "erase", "enhance" });
            cbxAction.Location = new Point(34, 393);
            cbxAction.Name = "cbxAction";
            cbxAction.Size = new Size(128, 23);
            cbxAction.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 288);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 1;
            label4.Text = "neutral";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 217);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 1;
            label3.Text = "unconditional";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 146);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "positive";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 64);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "target";
            // 
            // tbxNeutral
            // 
            tbxNeutral.Location = new Point(33, 306);
            tbxNeutral.Multiline = true;
            tbxNeutral.Name = "tbxNeutral";
            tbxNeutral.Size = new Size(512, 38);
            tbxNeutral.TabIndex = 0;
            // 
            // tbxNegative
            // 
            tbxNegative.Location = new Point(29, 235);
            tbxNegative.Multiline = true;
            tbxNegative.Name = "tbxNegative";
            tbxNegative.Size = new Size(512, 38);
            tbxNegative.TabIndex = 0;
            // 
            // tbxPositive
            // 
            tbxPositive.Location = new Point(29, 164);
            tbxPositive.Multiline = true;
            tbxPositive.Name = "tbxPositive";
            tbxPositive.Size = new Size(512, 38);
            tbxPositive.TabIndex = 0;
            // 
            // tbxTarget
            // 
            tbxTarget.Location = new Point(29, 92);
            tbxTarget.Multiline = true;
            tbxTarget.Name = "tbxTarget";
            tbxTarget.Size = new Size(512, 38);
            tbxTarget.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSaveConfig);
            tabPage2.Controls.Add(tbxOutputPath);
            tabPage2.Controls.Add(tbxOutputName);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(tbxLRScheduler);
            tabPage2.Controls.Add(tbxOptimizer);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(tbxLR);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label24);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(nudAlpha);
            tabPage2.Controls.Add(nudMaxDenoiseSteps);
            tabPage2.Controls.Add(nudSteps);
            tabPage2.Controls.Add(nudSaveEveryNSteps);
            tabPage2.Controls.Add(nudDim);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label25);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(cbxNoiseScheduler);
            tabPage2.Controls.Add(cbxSavePrecision);
            tabPage2.Controls.Add(cbxMethod);
            tabPage2.Controls.Add(cbxTrainPrecision);
            tabPage2.Controls.Add(cbxType);
            tabPage2.Controls.Add(cbxUseXformers);
            tabPage2.Controls.Add(cbxVerbose);
            tabPage2.Controls.Add(cbxUseWandb);
            tabPage2.Controls.Add(cbxUseVPrediction);
            tabPage2.Controls.Add(cbxUseSDV2);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(tbxPromptPath);
            tabPage2.Controls.Add(tbxModelPath);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(602, 524);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "config生成";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.Location = new Point(500, 487);
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.Size = new Size(96, 33);
            btnSaveConfig.TabIndex = 9;
            btnSaveConfig.Text = "保存";
            btnSaveConfig.UseVisualStyleBackColor = true;
            btnSaveConfig.Click += btnSaveConfig_Click;
            // 
            // tbxOutputPath
            // 
            tbxOutputPath.Location = new Point(116, 318);
            tbxOutputPath.Name = "tbxOutputPath";
            tbxOutputPath.Size = new Size(346, 23);
            tbxOutputPath.TabIndex = 8;
            tbxOutputPath.Text = "./output";
            // 
            // tbxOutputName
            // 
            tbxOutputName.Location = new Point(116, 289);
            tbxOutputName.Name = "tbxOutputName";
            tbxOutputName.Size = new Size(346, 23);
            tbxOutputName.TabIndex = 8;
            tbxOutputName.Text = "sample";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(72, 321);
            label17.Name = "label17";
            label17.Size = new Size(43, 15);
            label17.TabIndex = 7;
            label17.Text = "保存先";
            // 
            // tbxLRScheduler
            // 
            tbxLRScheduler.Location = new Point(118, 260);
            tbxLRScheduler.Name = "tbxLRScheduler";
            tbxLRScheduler.Size = new Size(158, 23);
            tbxLRScheduler.TabIndex = 8;
            tbxLRScheduler.Text = "constant";
            // 
            // tbxOptimizer
            // 
            tbxOptimizer.Location = new Point(118, 231);
            tbxOptimizer.Name = "tbxOptimizer";
            tbxOptimizer.Size = new Size(158, 23);
            tbxOptimizer.TabIndex = 8;
            tbxOptimizer.Text = "AdamW";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(70, 292);
            label16.Name = "label16";
            label16.Size = new Size(43, 15);
            label16.TabIndex = 7;
            label16.Text = "保存名";
            // 
            // tbxLR
            // 
            tbxLR.Location = new Point(345, 202);
            tbxLR.Name = "tbxLR";
            tbxLR.Size = new Size(100, 23);
            tbxLR.TabIndex = 8;
            tbxLR.Text = "0.0001";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(47, 234);
            label14.Name = "label14";
            label14.Size = new Size(68, 15);
            label14.TabIndex = 7;
            label14.Text = "オプティマイザ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 115);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 7;
            label9.Text = "アルファ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(298, 207);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 7;
            label13.Text = "学習率";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(274, 170);
            label24.Name = "label24";
            label24.Size = new Size(65, 30);
            label24.TabIndex = 7;
            label24.Text = "最大デノイズ\r\nステップ数";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(61, 205);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 7;
            label12.Text = "ステップ数";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(59, 378);
            label20.Name = "label20";
            label20.Size = new Size(55, 15);
            label20.TabIndex = 7;
            label20.Text = "保存周期";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(266, 114);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 7;
            label8.Text = "次元数";
            // 
            // nudAlpha
            // 
            nudAlpha.DecimalPlaces = 1;
            nudAlpha.Location = new Point(430, 112);
            nudAlpha.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudAlpha.Name = "nudAlpha";
            nudAlpha.Size = new Size(72, 23);
            nudAlpha.TabIndex = 6;
            nudAlpha.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudMaxDenoiseSteps
            // 
            nudMaxDenoiseSteps.Location = new Point(345, 173);
            nudMaxDenoiseSteps.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudMaxDenoiseSteps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxDenoiseSteps.Name = "nudMaxDenoiseSteps";
            nudMaxDenoiseSteps.Size = new Size(68, 23);
            nudMaxDenoiseSteps.TabIndex = 6;
            nudMaxDenoiseSteps.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // nudSteps
            // 
            nudSteps.Location = new Point(118, 202);
            nudSteps.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudSteps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSteps.Name = "nudSteps";
            nudSteps.Size = new Size(120, 23);
            nudSteps.TabIndex = 6;
            nudSteps.Value = new decimal(new int[] { 250, 0, 0, 0 });
            // 
            // nudSaveEveryNSteps
            // 
            nudSaveEveryNSteps.Location = new Point(119, 376);
            nudSaveEveryNSteps.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudSaveEveryNSteps.Name = "nudSaveEveryNSteps";
            nudSaveEveryNSteps.Size = new Size(95, 23);
            nudSaveEveryNSteps.TabIndex = 6;
            nudSaveEveryNSteps.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // nudDim
            // 
            nudDim.Location = new Point(315, 112);
            nudDim.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudDim.Name = "nudDim";
            nudDim.Size = new Size(62, 23);
            nudDim.TabIndex = 6;
            nudDim.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(256, 144);
            label15.Name = "label15";
            label15.Size = new Size(85, 15);
            label15.TabIndex = 5;
            label15.Text = "ノイズスケジューラ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(41, 263);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 5;
            label11.Text = "LRスケジューラ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(58, 353);
            label19.Name = "label19";
            label19.Size = new Size(55, 15);
            label19.TabIndex = 5;
            label19.Text = "保存精度";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(75, 173);
            label25.Name = "label25";
            label25.Size = new Size(40, 15);
            label25.TabIndex = 5;
            label25.Text = "メソッド";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(82, 144);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 5;
            label10.Text = "精度";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 115);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 5;
            label7.Text = "種類";
            // 
            // cbxNoiseScheduler
            // 
            cbxNoiseScheduler.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNoiseScheduler.FormattingEnabled = true;
            cbxNoiseScheduler.Items.AddRange(new object[] { "ddim", "ddpm", "lms", "euler_a" });
            cbxNoiseScheduler.Location = new Point(345, 141);
            cbxNoiseScheduler.Name = "cbxNoiseScheduler";
            cbxNoiseScheduler.Size = new Size(141, 23);
            cbxNoiseScheduler.TabIndex = 4;
            // 
            // cbxSavePrecision
            // 
            cbxSavePrecision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSavePrecision.FormattingEnabled = true;
            cbxSavePrecision.Items.AddRange(new object[] { "float16", "float32", "bfloat16" });
            cbxSavePrecision.Location = new Point(119, 347);
            cbxSavePrecision.Name = "cbxSavePrecision";
            cbxSavePrecision.Size = new Size(95, 23);
            cbxSavePrecision.TabIndex = 4;
            // 
            // cbxMethod
            // 
            cbxMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMethod.FormattingEnabled = true;
            cbxMethod.Items.AddRange(new object[] { "full", "selfattn", "xattn", "noxattn", "innoxattn" });
            cbxMethod.Location = new Point(118, 170);
            cbxMethod.Name = "cbxMethod";
            cbxMethod.Size = new Size(120, 23);
            cbxMethod.TabIndex = 4;
            // 
            // cbxTrainPrecision
            // 
            cbxTrainPrecision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTrainPrecision.FormattingEnabled = true;
            cbxTrainPrecision.Items.AddRange(new object[] { "float32", "bfloat16(RTX30以降のみ)", "float16(不安定)" });
            cbxTrainPrecision.Location = new Point(116, 141);
            cbxTrainPrecision.Name = "cbxTrainPrecision";
            cbxTrainPrecision.Size = new Size(122, 23);
            cbxTrainPrecision.TabIndex = 4;
            // 
            // cbxType
            // 
            cbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "Lierla", "C3Lier" });
            cbxType.Location = new Point(116, 112);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(122, 23);
            cbxType.TabIndex = 4;
            // 
            // cbxUseXformers
            // 
            cbxUseXformers.AutoSize = true;
            cbxUseXformers.Location = new Point(61, 441);
            cbxUseXformers.Name = "cbxUseXformers";
            cbxUseXformers.Size = new Size(101, 19);
            cbxUseXformers.TabIndex = 3;
            cbxUseXformers.Text = "xfomersを使用";
            cbxUseXformers.UseVisualStyleBackColor = true;
            // 
            // cbxVerbose
            // 
            cbxVerbose.AutoSize = true;
            cbxVerbose.Location = new Point(162, 416);
            cbxVerbose.Name = "cbxVerbose";
            cbxVerbose.Size = new Size(67, 19);
            cbxVerbose.TabIndex = 3;
            cbxVerbose.Text = "verbose";
            cbxVerbose.UseVisualStyleBackColor = true;
            // 
            // cbxUseWandb
            // 
            cbxUseWandb.AutoSize = true;
            cbxUseWandb.Location = new Point(61, 416);
            cbxUseWandb.Name = "cbxUseWandb";
            cbxUseWandb.Size = new Size(95, 19);
            cbxUseWandb.TabIndex = 3;
            cbxUseWandb.Text = "wandbを使用";
            cbxUseWandb.UseVisualStyleBackColor = true;
            // 
            // cbxUseVPrediction
            // 
            cbxUseVPrediction.AutoSize = true;
            cbxUseVPrediction.Location = new Point(235, 416);
            cbxUseVPrediction.Name = "cbxUseVPrediction";
            cbxUseVPrediction.Size = new Size(124, 19);
            cbxUseVPrediction.TabIndex = 3;
            cbxUseVPrediction.Text = "v-predictionを使用";
            cbxUseVPrediction.UseVisualStyleBackColor = true;
            // 
            // cbxUseSDV2
            // 
            cbxUseSDV2.AutoSize = true;
            cbxUseSDV2.Location = new Point(162, 441);
            cbxUseSDV2.Name = "cbxUseSDV2";
            cbxUseSDV2.Size = new Size(89, 19);
            cbxUseSDV2.TabIndex = 3;
            cbxUseSDV2.Text = "SD2.Xを使用";
            cbxUseSDV2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 31);
            label18.Name = "label18";
            label18.Size = new Size(108, 15);
            label18.TabIndex = 2;
            label18.Text = "prompts.yamlのパス";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 55);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 2;
            label6.Text = "モデルのパス";
            // 
            // tbxPromptPath
            // 
            tbxPromptPath.Location = new Point(116, 28);
            tbxPromptPath.Name = "tbxPromptPath";
            tbxPromptPath.Size = new Size(385, 23);
            tbxPromptPath.TabIndex = 0;
            tbxPromptPath.Text = "./sample/prompts.yaml";
            // 
            // tbxModelPath
            // 
            tbxModelPath.Location = new Point(116, 65);
            tbxModelPath.Name = "tbxModelPath";
            tbxModelPath.Size = new Size(385, 23);
            tbxModelPath.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label26);
            tabPage3.Controls.Add(label27);
            tabPage3.Controls.Add(btnTrainLECO);
            tabPage3.Controls.Add(btnUpdateLECO);
            tabPage3.Controls.Add(btnInstallLECO);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(602, 524);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "インストール・更新・学習";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(199, 276);
            label26.Name = "label26";
            label26.Size = new Size(195, 15);
            label26.TabIndex = 4;
            label26.Text = "GUIフォルダと同階層にインストールします";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(222, 178);
            label27.Name = "label27";
            label27.Size = new Size(152, 15);
            label27.TabIndex = 3;
            label27.Text = "config.yamlを指定してください";
            // 
            // btnTrainLECO
            // 
            btnTrainLECO.Location = new Point(222, 140);
            btnTrainLECO.Name = "btnTrainLECO";
            btnTrainLECO.Size = new Size(140, 35);
            btnTrainLECO.TabIndex = 0;
            btnTrainLECO.Text = "LECOの学習";
            btnTrainLECO.UseVisualStyleBackColor = true;
            btnTrainLECO.Click += btnTrainLECO_Click;
            // 
            // btnUpdateLECO
            // 
            btnUpdateLECO.Location = new Point(222, 336);
            btnUpdateLECO.Name = "btnUpdateLECO";
            btnUpdateLECO.Size = new Size(140, 35);
            btnUpdateLECO.TabIndex = 0;
            btnUpdateLECO.Text = "LECOの更新";
            btnUpdateLECO.UseVisualStyleBackColor = true;
            btnUpdateLECO.Click += btnUpdateLECO_Click;
            // 
            // btnInstallLECO
            // 
            btnInstallLECO.Location = new Point(222, 238);
            btnInstallLECO.Name = "btnInstallLECO";
            btnInstallLECO.Size = new Size(140, 35);
            btnInstallLECO.TabIndex = 0;
            btnInstallLECO.Text = "LECOのインストール";
            btnInstallLECO.UseVisualStyleBackColor = true;
            btnInstallLECO.Click += btnInstallLECO_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(394, 494);
            label29.Name = "label29";
            label29.Size = new Size(162, 15);
            label29.TabIndex = 7;
            label29.Text = "注意:SD1.5のみ対応しています。";
            // 
            // FormLECO
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(633, 577);
            Controls.Add(tabControl1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLECO";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LECO(SD1.5 only)";
            Load += FormLECO_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBatchSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudResolution).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGuidanceScale).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAlpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxDenoiseSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSaveEveryNSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDim).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNeutral;
        private System.Windows.Forms.TextBox tbxNegative;
        private System.Windows.Forms.TextBox tbxPositive;
        private System.Windows.Forms.TextBox tbxTarget;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSavePrompts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxAction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxModelPath;
        private System.Windows.Forms.NumericUpDown nudDim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.CheckBox cbxUseVPrediction;
        private System.Windows.Forms.CheckBox cbxUseSDV2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudAlpha;
        private System.Windows.Forms.NumericUpDown nudSteps;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxTrainPrecision;
        private System.Windows.Forms.TextBox tbxOutputPath;
        private System.Windows.Forms.TextBox tbxOutputName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbxOptimizer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxLR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxNoiseScheduler;
        private System.Windows.Forms.CheckBox cbxUseXformers;
        private System.Windows.Forms.CheckBox cbxVerbose;
        private System.Windows.Forms.CheckBox cbxUseWandb;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nudSaveEveryNSteps;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbxSavePrecision;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxPromptPath;
        private System.Windows.Forms.TextBox tbxLRScheduler;
        private System.Windows.Forms.NumericUpDown nudGuidanceScale;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nudBatchSize;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown nudMaxDenoiseSteps;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbxMethod;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnTrainLECO;
        private System.Windows.Forms.Button btnUpdateLECO;
        private System.Windows.Forms.Button btnInstallLECO;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private Label label29;
    }
}
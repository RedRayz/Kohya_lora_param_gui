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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSavePrompts = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxAction = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNeutral = new System.Windows.Forms.TextBox();
            this.tbxNegative = new System.Windows.Forms.TextBox();
            this.tbxPositive = new System.Windows.Forms.TextBox();
            this.tbxTarget = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.tbxOutputPath = new System.Windows.Forms.TextBox();
            this.tbxOutputName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxLRScheduler = new System.Windows.Forms.TextBox();
            this.tbxOptimizer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxLR = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudAlpha = new System.Windows.Forms.NumericUpDown();
            this.nudSteps = new System.Windows.Forms.NumericUpDown();
            this.nudSaveEveryNSteps = new System.Windows.Forms.NumericUpDown();
            this.nudDim = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxNoiseScheduler = new System.Windows.Forms.ComboBox();
            this.cbxSavePrecision = new System.Windows.Forms.ComboBox();
            this.cbxTrainPrecision = new System.Windows.Forms.ComboBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxUseXformers = new System.Windows.Forms.CheckBox();
            this.cbxVerbose = new System.Windows.Forms.CheckBox();
            this.cbxUseWandb = new System.Windows.Forms.CheckBox();
            this.cbxUseVPrediction = new System.Windows.Forms.CheckBox();
            this.cbxUseSDV2 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPromptPath = new System.Windows.Forms.TextBox();
            this.tbxModelPath = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaveEveryNSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDim)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 762);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSavePrompts);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbxAction);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbxNeutral);
            this.tabPage1.Controls.Add(this.tbxNegative);
            this.tabPage1.Controls.Add(this.tbxPositive);
            this.tabPage1.Controls.Add(this.tbxTarget);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(837, 724);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "prompts生成";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSavePrompts
            // 
            this.btnSavePrompts.Location = new System.Drawing.Point(661, 664);
            this.btnSavePrompts.Name = "btnSavePrompts";
            this.btnSavePrompts.Size = new System.Drawing.Size(137, 44);
            this.btnSavePrompts.TabIndex = 4;
            this.btnSavePrompts.Text = "保存";
            this.btnSavePrompts.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "アクション";
            // 
            // cbxAction
            // 
            this.cbxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAction.FormattingEnabled = true;
            this.cbxAction.Items.AddRange(new object[] {
            "erase",
            "enhance"});
            this.cbxAction.Location = new System.Drawing.Point(32, 482);
            this.cbxAction.Name = "cbxAction";
            this.cbxAction.Size = new System.Drawing.Size(176, 33);
            this.cbxAction.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "neutral";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "unconditional";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "positive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "target";
            // 
            // tbxNeutral
            // 
            this.tbxNeutral.Location = new System.Drawing.Point(27, 374);
            this.tbxNeutral.Multiline = true;
            this.tbxNeutral.Name = "tbxNeutral";
            this.tbxNeutral.Size = new System.Drawing.Size(771, 57);
            this.tbxNeutral.TabIndex = 0;
            // 
            // tbxNegative
            // 
            this.tbxNegative.Location = new System.Drawing.Point(27, 254);
            this.tbxNegative.Multiline = true;
            this.tbxNegative.Name = "tbxNegative";
            this.tbxNegative.Size = new System.Drawing.Size(771, 57);
            this.tbxNegative.TabIndex = 0;
            // 
            // tbxPositive
            // 
            this.tbxPositive.Location = new System.Drawing.Point(27, 157);
            this.tbxPositive.Multiline = true;
            this.tbxPositive.Name = "tbxPositive";
            this.tbxPositive.Size = new System.Drawing.Size(771, 57);
            this.tbxPositive.TabIndex = 0;
            // 
            // tbxTarget
            // 
            this.tbxTarget.Location = new System.Drawing.Point(27, 53);
            this.tbxTarget.Multiline = true;
            this.tbxTarget.Name = "tbxTarget";
            this.tbxTarget.Size = new System.Drawing.Size(771, 57);
            this.tbxTarget.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveConfig);
            this.tabPage2.Controls.Add(this.tbxOutputPath);
            this.tabPage2.Controls.Add(this.tbxOutputName);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.tbxLRScheduler);
            this.tabPage2.Controls.Add(this.tbxOptimizer);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbxLR);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.nudAlpha);
            this.tabPage2.Controls.Add(this.nudSteps);
            this.tabPage2.Controls.Add(this.nudSaveEveryNSteps);
            this.tabPage2.Controls.Add(this.nudDim);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbxNoiseScheduler);
            this.tabPage2.Controls.Add(this.cbxSavePrecision);
            this.tabPage2.Controls.Add(this.cbxTrainPrecision);
            this.tabPage2.Controls.Add(this.cbxType);
            this.tabPage2.Controls.Add(this.cbxUseXformers);
            this.tabPage2.Controls.Add(this.cbxVerbose);
            this.tabPage2.Controls.Add(this.cbxUseWandb);
            this.tabPage2.Controls.Add(this.cbxUseVPrediction);
            this.tabPage2.Controls.Add(this.cbxUseSDV2);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbxPromptPath);
            this.tabPage2.Controls.Add(this.tbxModelPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(837, 724);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "config生成";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(683, 661);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(126, 48);
            this.btnSaveConfig.TabIndex = 9;
            this.btnSaveConfig.Text = "保存";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            // 
            // tbxOutputPath
            // 
            this.tbxOutputPath.Location = new System.Drawing.Point(134, 470);
            this.tbxOutputPath.Name = "tbxOutputPath";
            this.tbxOutputPath.Size = new System.Drawing.Size(675, 31);
            this.tbxOutputPath.TabIndex = 8;
            this.tbxOutputPath.Text = "./output";
            // 
            // tbxOutputName
            // 
            this.tbxOutputName.Location = new System.Drawing.Point(134, 433);
            this.tbxOutputName.Name = "tbxOutputName";
            this.tbxOutputName.Size = new System.Drawing.Size(675, 31);
            this.tbxOutputName.TabIndex = 8;
            this.tbxOutputName.Text = "sample";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(62, 473);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 25);
            this.label17.TabIndex = 7;
            this.label17.Text = "保存先";
            // 
            // tbxLRScheduler
            // 
            this.tbxLRScheduler.Location = new System.Drawing.Point(136, 367);
            this.tbxLRScheduler.Name = "tbxLRScheduler";
            this.tbxLRScheduler.Size = new System.Drawing.Size(344, 31);
            this.tbxLRScheduler.TabIndex = 8;
            this.tbxLRScheduler.Text = "constant";
            // 
            // tbxOptimizer
            // 
            this.tbxOptimizer.Location = new System.Drawing.Point(134, 330);
            this.tbxOptimizer.Name = "tbxOptimizer";
            this.tbxOptimizer.Size = new System.Drawing.Size(344, 31);
            this.tbxOptimizer.TabIndex = 8;
            this.tbxOptimizer.Text = "AdamW";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 436);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 25);
            this.label16.TabIndex = 7;
            this.label16.Text = "保存名";
            // 
            // tbxLR
            // 
            this.tbxLR.Location = new System.Drawing.Point(378, 282);
            this.tbxLR.Name = "tbxLR";
            this.tbxLR.Size = new System.Drawing.Size(100, 31);
            this.tbxLR.TabIndex = 8;
            this.tbxLR.Text = "0.0001";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "オプティマイザ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "アルファ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "学習率";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "ステップ数";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(44, 567);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 25);
            this.label20.TabIndex = 7;
            this.label20.Text = "保存周期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "次元数";
            // 
            // nudAlpha
            // 
            this.nudAlpha.Location = new System.Drawing.Point(601, 182);
            this.nudAlpha.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudAlpha.Name = "nudAlpha";
            this.nudAlpha.Size = new System.Drawing.Size(120, 31);
            this.nudAlpha.TabIndex = 6;
            // 
            // nudSteps
            // 
            this.nudSteps.Location = new System.Drawing.Point(108, 277);
            this.nudSteps.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSteps.Name = "nudSteps";
            this.nudSteps.Size = new System.Drawing.Size(120, 31);
            this.nudSteps.TabIndex = 6;
            this.nudSteps.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // nudSaveEveryNSteps
            // 
            this.nudSaveEveryNSteps.Location = new System.Drawing.Point(134, 565);
            this.nudSaveEveryNSteps.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSaveEveryNSteps.Name = "nudSaveEveryNSteps";
            this.nudSaveEveryNSteps.Size = new System.Drawing.Size(120, 31);
            this.nudSaveEveryNSteps.TabIndex = 6;
            this.nudSaveEveryNSteps.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudDim
            // 
            this.nudDim.Location = new System.Drawing.Point(360, 181);
            this.nudDim.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudDim.Name = "nudDim";
            this.nudDim.Size = new System.Drawing.Size(120, 31);
            this.nudDim.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(299, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 25);
            this.label15.TabIndex = 5;
            this.label15.Text = "ノイズスケジューラ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "LRスケジューラ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(44, 519);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 25);
            this.label19.TabIndex = 5;
            this.label19.Text = "保存精度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "精度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "種類";
            // 
            // cbxNoiseScheduler
            // 
            this.cbxNoiseScheduler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNoiseScheduler.FormattingEnabled = true;
            this.cbxNoiseScheduler.Items.AddRange(new object[] {
            "ddim",
            "ddpm",
            "lms",
            "euler_a"});
            this.cbxNoiseScheduler.Location = new System.Drawing.Point(434, 229);
            this.cbxNoiseScheduler.Name = "cbxNoiseScheduler";
            this.cbxNoiseScheduler.Size = new System.Drawing.Size(169, 33);
            this.cbxNoiseScheduler.TabIndex = 4;
            // 
            // cbxSavePrecision
            // 
            this.cbxSavePrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSavePrecision.FormattingEnabled = true;
            this.cbxSavePrecision.Items.AddRange(new object[] {
            "float16",
            "float32",
            "bfloat16"});
            this.cbxSavePrecision.Location = new System.Drawing.Point(134, 516);
            this.cbxSavePrecision.Name = "cbxSavePrecision";
            this.cbxSavePrecision.Size = new System.Drawing.Size(169, 33);
            this.cbxSavePrecision.TabIndex = 4;
            // 
            // cbxTrainPrecision
            // 
            this.cbxTrainPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrainPrecision.FormattingEnabled = true;
            this.cbxTrainPrecision.Items.AddRange(new object[] {
            "float32",
            "bfloat16(RTX30以降のみ)",
            "float16(不安定)"});
            this.cbxTrainPrecision.Location = new System.Drawing.Point(108, 229);
            this.cbxTrainPrecision.Name = "cbxTrainPrecision";
            this.cbxTrainPrecision.Size = new System.Drawing.Size(169, 33);
            this.cbxTrainPrecision.TabIndex = 4;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Lierla",
            "C3Lier"});
            this.cbxType.Location = new System.Drawing.Point(108, 181);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(169, 33);
            this.cbxType.TabIndex = 4;
            // 
            // cbxUseXformers
            // 
            this.cbxUseXformers.AutoSize = true;
            this.cbxUseXformers.Location = new System.Drawing.Point(67, 637);
            this.cbxUseXformers.Name = "cbxUseXformers";
            this.cbxUseXformers.Size = new System.Drawing.Size(152, 29);
            this.cbxUseXformers.TabIndex = 3;
            this.cbxUseXformers.Text = "xfomersを使用";
            this.cbxUseXformers.UseVisualStyleBackColor = true;
            // 
            // cbxVerbose
            // 
            this.cbxVerbose.AutoSize = true;
            this.cbxVerbose.Location = new System.Drawing.Point(257, 602);
            this.cbxVerbose.Name = "cbxVerbose";
            this.cbxVerbose.Size = new System.Drawing.Size(101, 29);
            this.cbxVerbose.TabIndex = 3;
            this.cbxVerbose.Text = "verbose";
            this.cbxVerbose.UseVisualStyleBackColor = true;
            // 
            // cbxUseWandb
            // 
            this.cbxUseWandb.AutoSize = true;
            this.cbxUseWandb.Location = new System.Drawing.Point(67, 602);
            this.cbxUseWandb.Name = "cbxUseWandb";
            this.cbxUseWandb.Size = new System.Drawing.Size(142, 29);
            this.cbxUseWandb.TabIndex = 3;
            this.cbxUseWandb.Text = "wandbを使用";
            this.cbxUseWandb.UseVisualStyleBackColor = true;
            // 
            // cbxUseVPrediction
            // 
            this.cbxUseVPrediction.AutoSize = true;
            this.cbxUseVPrediction.Location = new System.Drawing.Point(206, 123);
            this.cbxUseVPrediction.Name = "cbxUseVPrediction";
            this.cbxUseVPrediction.Size = new System.Drawing.Size(184, 29);
            this.cbxUseVPrediction.TabIndex = 3;
            this.cbxUseVPrediction.Text = "v-predictionを使用";
            this.cbxUseVPrediction.UseVisualStyleBackColor = true;
            // 
            // cbxUseSDV2
            // 
            this.cbxUseSDV2.AutoSize = true;
            this.cbxUseSDV2.Location = new System.Drawing.Point(27, 123);
            this.cbxUseSDV2.Name = "cbxUseSDV2";
            this.cbxUseSDV2.Size = new System.Drawing.Size(136, 29);
            this.cbxUseSDV2.TabIndex = 3;
            this.cbxUseSDV2.Text = "SD2.Xを使用";
            this.cbxUseSDV2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 25);
            this.label18.TabIndex = 2;
            this.label18.Text = "prompts.yamlのパス";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "モデルのパス";
            // 
            // tbxPromptPath
            // 
            this.tbxPromptPath.Location = new System.Drawing.Point(179, 28);
            this.tbxPromptPath.Name = "tbxPromptPath";
            this.tbxPromptPath.Size = new System.Drawing.Size(630, 31);
            this.tbxPromptPath.TabIndex = 0;
            this.tbxPromptPath.Text = "./sample/prompts.yaml";
            // 
            // tbxModelPath
            // 
            this.tbxModelPath.Location = new System.Drawing.Point(179, 65);
            this.tbxModelPath.Name = "tbxModelPath";
            this.tbxModelPath.Size = new System.Drawing.Size(630, 31);
            this.tbxModelPath.TabIndex = 0;
            // 
            // FormLECO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 786);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLECO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LECO";
            this.Load += new System.EventHandler(this.FormLECO_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaveEveryNSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDim)).EndInit();
            this.ResumeLayout(false);

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
    }
}
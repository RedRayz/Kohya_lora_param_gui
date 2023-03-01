
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
            this.lblModelPath = new System.Windows.Forms.Label();
            this.btnModel = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxLR = new System.Windows.Forms.TextBox();
            this.lblLR = new System.Windows.Forms.Label();
            this.cbxOptimizer = new System.Windows.Forms.ComboBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.lblRegImgPath = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.btnStartTraining = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxShuffle = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSavePreset = new System.Windows.Forms.Button();
            this.btnLoadPreset = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearRegImagePath = new System.Windows.Forms.Button();
            this.lblNumStepsBatch1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCustomScriptPath = new System.Windows.Forms.Button();
            this.lblScriptPathDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetworkAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetworkDim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKeepTokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaveEpoch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModelPath
            // 
            this.lblModelPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblModelPath.Location = new System.Drawing.Point(34, 193);
            this.lblModelPath.Name = "lblModelPath";
            this.lblModelPath.Size = new System.Drawing.Size(318, 52);
            this.lblModelPath.TabIndex = 0;
            this.lblModelPath.Text = "D:\\Sample\\Super Long File path\\Models\\aaaa.safetensors";
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(152, 148);
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
            this.btnImage.Location = new System.Drawing.Point(506, 147);
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
            this.label2.Location = new System.Drawing.Point(31, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "学習元モデル*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "教師画像フォルダ*";
            // 
            // btnRegImage
            // 
            this.btnRegImage.Location = new System.Drawing.Point(850, 147);
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
            this.label4.Location = new System.Drawing.Point(692, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "正則化画像フォルダ";
            // 
            // tbxLR
            // 
            this.tbxLR.Location = new System.Drawing.Point(152, 253);
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
            this.lblLR.Location = new System.Drawing.Point(25, 256);
            this.lblLR.Name = "lblLR";
            this.lblLR.Size = new System.Drawing.Size(121, 25);
            this.lblLR.TabIndex = 5;
            this.lblLR.Text = "学習速度(LR)*";
            // 
            // cbxOptimizer
            // 
            this.cbxOptimizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOptimizer.FormattingEnabled = true;
            this.cbxOptimizer.Items.AddRange(new object[] {
            "AdamW8bit",
            "AdamW",
            "AdaFactor"});
            this.cbxOptimizer.Location = new System.Drawing.Point(152, 427);
            this.cbxOptimizer.Name = "cbxOptimizer";
            this.cbxOptimizer.Size = new System.Drawing.Size(146, 33);
            this.cbxOptimizer.TabIndex = 6;
            this.cbxOptimizer.SelectedIndexChanged += new System.EventHandler(this.cbxOptimizer_SelectedIndexChanged);
            // 
            // lblImagePath
            // 
            this.lblImagePath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblImagePath.Location = new System.Drawing.Point(356, 193);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(292, 49);
            this.lblImagePath.TabIndex = 12;
            this.lblImagePath.Text = "1folder, extremely long name, ultra detailed name";
            // 
            // lblRegImgPath
            // 
            this.lblRegImgPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRegImgPath.Location = new System.Drawing.Point(700, 193);
            this.lblRegImgPath.Name = "lblRegImgPath";
            this.lblRegImgPath.Size = new System.Drawing.Size(316, 49);
            this.lblRegImgPath.TabIndex = 13;
            this.lblRegImgPath.Text = "D:\\Sample\\Please stop using Super Long Naming\\RegImage\\1_1girl";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "オプティマイザ*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 304);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 25);
            this.label17.TabIndex = 23;
            this.label17.Text = "エポック数*";
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(36, 719);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(210, 48);
            this.btnAdvanced.TabIndex = 26;
            this.btnAdvanced.Text = "Advanced options";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnStartTraining
            // 
            this.btnStartTraining.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStartTraining.Location = new System.Drawing.Point(824, 710);
            this.btnStartTraining.Name = "btnStartTraining";
            this.btnStartTraining.Size = new System.Drawing.Size(192, 58);
            this.btnStartTraining.TabIndex = 27;
            this.btnStartTraining.Text = "学習開始";
            this.btnStartTraining.UseVisualStyleBackColor = true;
            this.btnStartTraining.Click += new System.EventHandler(this.btnStartTraining_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(29, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "基本設定";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(409, 50);
            this.label7.TabIndex = 29;
            this.label7.Text = "*がつく項目は必須です\r\n他の設定は「Advanced options」を押すと表示します。";
            // 
            // cbxShuffle
            // 
            this.cbxShuffle.AutoSize = true;
            this.cbxShuffle.Location = new System.Drawing.Point(86, 366);
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
            this.label12.Location = new System.Drawing.Point(382, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 50);
            this.label12.TabIndex = 33;
            this.label12.Text = "トークン保持数\r\n0で無効";
            // 
            // btnSavePreset
            // 
            this.btnSavePreset.Location = new System.Drawing.Point(354, 720);
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
            this.btnLoadPreset.Location = new System.Drawing.Point(512, 720);
            this.btnLoadPreset.Name = "btnLoadPreset";
            this.btnLoadPreset.Size = new System.Drawing.Size(160, 46);
            this.btnLoadPreset.TabIndex = 35;
            this.btnLoadPreset.Text = "プリセットの読込";
            this.btnLoadPreset.UseVisualStyleBackColor = true;
            this.btnLoadPreset.Click += new System.EventHandler(this.btnLoadPreset_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(425, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 25);
            this.label13.TabIndex = 36;
            this.label13.Text = "解像度*";
            // 
            // tbxFileName
            // 
            this.tbxFileName.Location = new System.Drawing.Point(152, 510);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(474, 31);
            this.tbxFileName.TabIndex = 38;
            this.tbxFileName.TextChanged += new System.EventHandler(this.tbxFileName_TextChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(29, 513);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(117, 25);
            this.lblFileName.TabIndex = 39;
            this.lblFileName.Text = "出力ファイル名";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(695, 362);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 50);
            this.label16.TabIndex = 42;
            this.label16.Text = "nエポックごとに保存\r\n0で無効";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(742, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 25);
            this.label18.TabIndex = 44;
            this.label18.Text = "バッチサイズ*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(291, 304);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(205, 50);
            this.label20.TabIndex = 48;
            this.label20.Text = "ネットワークディメンション数*\r\n(network_dim)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(695, 308);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(150, 25);
            this.label21.TabIndex = 50;
            this.label21.Text = "ネットワークアルファ*";
            // 
            // nudNetworkAlpha
            // 
            this.nudNetworkAlpha.Location = new System.Drawing.Point(850, 304);
            this.nudNetworkAlpha.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudNetworkAlpha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNetworkAlpha.Name = "nudNetworkAlpha";
            this.nudNetworkAlpha.Size = new System.Drawing.Size(120, 31);
            this.nudNetworkAlpha.TabIndex = 51;
            this.nudNetworkAlpha.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudNetworkAlpha.ValueChanged += new System.EventHandler(this.nudNetworkAlpha_ValueChanged);
            // 
            // nudNetworkDim
            // 
            this.nudNetworkDim.Location = new System.Drawing.Point(506, 304);
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
            this.nudNetworkDim.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudNetworkDim.ValueChanged += new System.EventHandler(this.nudNetworkDim_ValueChanged);
            // 
            // nudEpochs
            // 
            this.nudEpochs.Location = new System.Drawing.Point(152, 302);
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
            this.nudResolution.Location = new System.Drawing.Point(505, 256);
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
            this.nudResolution.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudResolution.ValueChanged += new System.EventHandler(this.nudResolution_ValueChanged);
            // 
            // nudKeepTokens
            // 
            this.nudKeepTokens.Location = new System.Drawing.Point(505, 364);
            this.nudKeepTokens.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudKeepTokens.Name = "nudKeepTokens";
            this.nudKeepTokens.Size = new System.Drawing.Size(120, 31);
            this.nudKeepTokens.TabIndex = 55;
            this.nudKeepTokens.ValueChanged += new System.EventHandler(this.nudKeepTokens_ValueChanged);
            // 
            // nudSaveEpoch
            // 
            this.nudSaveEpoch.Location = new System.Drawing.Point(850, 362);
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
            this.nudBatchSize.Location = new System.Drawing.Point(850, 258);
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
            this.label1.Location = new System.Drawing.Point(813, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "総ステップ数:";
            // 
            // lblNumSteps
            // 
            this.lblNumSteps.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumSteps.Location = new System.Drawing.Point(925, 621);
            this.lblNumSteps.Name = "lblNumSteps";
            this.lblNumSteps.Size = new System.Drawing.Size(84, 25);
            this.lblNumSteps.TabIndex = 61;
            this.lblNumSteps.Text = "16384";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(505, 428);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 62;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 50);
            this.label9.TabIndex = 63;
            this.label9.Text = "ウォームアップステップ数\r\n0で無効";
            // 
            // btnClearRegImagePath
            // 
            this.btnClearRegImagePath.Location = new System.Drawing.Point(850, 105);
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
            this.lblNumStepsBatch1.Location = new System.Drawing.Point(925, 659);
            this.lblNumStepsBatch1.Name = "lblNumStepsBatch1";
            this.lblNumStepsBatch1.Size = new System.Drawing.Size(84, 25);
            this.lblNumStepsBatch1.TabIndex = 61;
            this.lblNumStepsBatch1.Text = "16384";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(803, 659);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "(batch1相当):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 25);
            this.label8.TabIndex = 65;
            this.label8.Text = "次の文字は使用できません /\\?:*<>|";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(720, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "出力先フォルダ*";
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOutputPath.Location = new System.Drawing.Point(700, 548);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(316, 49);
            this.lblOutputPath.TabIndex = 13;
            this.lblOutputPath.Text = "D:\\Sample\\Please stop using Super Long Naming\\RegImage\\1_1girl";
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Location = new System.Drawing.Point(850, 501);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(159, 44);
            this.btnOutputPath.TabIndex = 66;
            this.btnOutputPath.Text = "選択";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // btnCustomScriptPath
            // 
            this.btnCustomScriptPath.Enabled = false;
            this.btnCustomScriptPath.Location = new System.Drawing.Point(850, 37);
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
            this.lblScriptPathDesc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblScriptPathDesc.Location = new System.Drawing.Point(796, 9);
            this.lblScriptPathDesc.Name = "lblScriptPathDesc";
            this.lblScriptPathDesc.Size = new System.Drawing.Size(268, 25);
            this.lblScriptPathDesc.TabIndex = 68;
            this.lblScriptPathDesc.Text = "sd-scriptsの場所を選択してください";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 787);
            this.Controls.Add(this.lblScriptPathDesc);
            this.Controls.Add(this.btnCustomScriptPath);
            this.Controls.Add(this.btnOutputPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClearRegImagePath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNumStepsBatch1);
            this.Controls.Add(this.numericUpDown1);
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
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnLoadPreset);
            this.Controls.Add(this.btnSavePreset);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxShuffle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnStartTraining);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblOutputPath);
            this.Controls.Add(this.lblRegImgPath);
            this.Controls.Add(this.lblImagePath);
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
            this.Controls.Add(this.lblModelPath);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoRA Training GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNetworkAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetworkDim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKeepTokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaveEpoch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelPath;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLR;
        private System.Windows.Forms.Label lblLR;
        private System.Windows.Forms.ComboBox cbxOptimizer;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Label lblRegImgPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Button btnStartTraining;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxShuffle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnSavePreset;
        private System.Windows.Forms.Button btnLoadPreset;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClearRegImagePath;
        private System.Windows.Forms.Label lblNumStepsBatch1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button btnCustomScriptPath;
        private System.Windows.Forms.Label lblScriptPathDesc;
    }
}


namespace Kohya_lora_trainer {
    partial class FormUtils {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnRunTensorboard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectModel = new System.Windows.Forms.Button();
            this.btnResizeDim = new System.Windows.Forms.Button();
            this.cbxCudaConversion = new System.Windows.Forms.CheckBox();
            this.lblLoraPath = new System.Windows.Forms.Label();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.nudTargetDim = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectOutputPath = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInstallExtension = new System.Windows.Forms.Button();
            this.btnUpdateRepo = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTaggerExclude = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTaggerBatchSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTaggetSelectDir = new System.Windows.Forms.Button();
            this.lblTaggerDir = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRunTagger = new System.Windows.Forms.Button();
            this.cbxTaggerModel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudThresh = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetDim)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaggerBatchSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRunTensorboard
            // 
            this.btnRunTensorboard.Location = new System.Drawing.Point(308, 158);
            this.btnRunTensorboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRunTensorboard.Name = "btnRunTensorboard";
            this.btnRunTensorboard.Size = new System.Drawing.Size(214, 44);
            this.btnRunTensorboard.TabIndex = 0;
            this.btnRunTensorboard.Text = "tensorboard起動";
            this.btnRunTensorboard.UseVisualStyleBackColor = true;
            this.btnRunTensorboard.Click += new System.EventHandler(this.btnRunTensorboard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "ターミナルは手動で閉じてください";
            // 
            // btnSelectModel
            // 
            this.btnSelectModel.Location = new System.Drawing.Point(60, 43);
            this.btnSelectModel.Name = "btnSelectModel";
            this.btnSelectModel.Size = new System.Drawing.Size(134, 37);
            this.btnSelectModel.TabIndex = 5;
            this.btnSelectModel.Text = "変換元の選択";
            this.btnSelectModel.UseVisualStyleBackColor = true;
            this.btnSelectModel.Click += new System.EventHandler(this.btnSelectModel_Click);
            // 
            // btnResizeDim
            // 
            this.btnResizeDim.Location = new System.Drawing.Point(60, 232);
            this.btnResizeDim.Name = "btnResizeDim";
            this.btnResizeDim.Size = new System.Drawing.Size(134, 37);
            this.btnResizeDim.TabIndex = 5;
            this.btnResizeDim.Text = "変換";
            this.btnResizeDim.UseVisualStyleBackColor = true;
            this.btnResizeDim.Click += new System.EventHandler(this.btnResizeDim_Click);
            // 
            // cbxCudaConversion
            // 
            this.cbxCudaConversion.AutoSize = true;
            this.cbxCudaConversion.Location = new System.Drawing.Point(204, 159);
            this.cbxCudaConversion.Name = "cbxCudaConversion";
            this.cbxCudaConversion.Size = new System.Drawing.Size(136, 29);
            this.cbxCudaConversion.TabIndex = 6;
            this.cbxCudaConversion.Text = "CUDAで変換";
            this.cbxCudaConversion.UseVisualStyleBackColor = true;
            // 
            // lblLoraPath
            // 
            this.lblLoraPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLoraPath.Location = new System.Drawing.Point(200, 43);
            this.lblLoraPath.Name = "lblLoraPath";
            this.lblLoraPath.Size = new System.Drawing.Size(581, 37);
            this.lblLoraPath.TabIndex = 7;
            this.lblLoraPath.Text = "G:\\SD\\model\\lora\\longlongname\\aaaaa.safetensors";
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOutputPath.Location = new System.Drawing.Point(200, 86);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(581, 37);
            this.lblOutputPath.TabIndex = 7;
            this.lblOutputPath.Text = "G:\\SD\\model\\lora\\longlongname\\aaaaa.safetensors";
            // 
            // nudTargetDim
            // 
            this.nudTargetDim.Location = new System.Drawing.Point(60, 159);
            this.nudTargetDim.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudTargetDim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTargetDim.Name = "nudTargetDim";
            this.nudTargetDim.Size = new System.Drawing.Size(134, 31);
            this.nudTargetDim.TabIndex = 8;
            this.nudTargetDim.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "次元数";
            // 
            // btnSelectOutputPath
            // 
            this.btnSelectOutputPath.Location = new System.Drawing.Point(60, 86);
            this.btnSelectOutputPath.Name = "btnSelectOutputPath";
            this.btnSelectOutputPath.Size = new System.Drawing.Size(134, 37);
            this.btnSelectOutputPath.TabIndex = 10;
            this.btnSelectOutputPath.Text = "出力先の選択";
            this.btnSelectOutputPath.UseVisualStyleBackColor = true;
            this.btnSelectOutputPath.Click += new System.EventHandler(this.btnSelectOutputPath_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 422);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRunTensorboard);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tensorboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSelectModel);
            this.tabPage2.Controls.Add(this.btnSelectOutputPath);
            this.tabPage2.Controls.Add(this.btnResizeDim);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbxCudaConversion);
            this.tabPage2.Controls.Add(this.nudTargetDim);
            this.tabPage2.Controls.Add(this.lblLoraPath);
            this.tabPage2.Controls.Add(this.lblOutputPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dimリサイズ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnInstallExtension);
            this.tabPage3.Controls.Add(this.btnUpdateRepo);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(804, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "更新";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "リポジトリと必須のpythonパッケージの更新をします。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "lycorisおよび追加のオプティマイザを\r\nインストールまたは更新をします。";
            // 
            // btnInstallExtension
            // 
            this.btnInstallExtension.Location = new System.Drawing.Point(293, 177);
            this.btnInstallExtension.Name = "btnInstallExtension";
            this.btnInstallExtension.Size = new System.Drawing.Size(235, 45);
            this.btnInstallExtension.TabIndex = 1;
            this.btnInstallExtension.Text = "拡張機能のインストール・更新";
            this.btnInstallExtension.UseVisualStyleBackColor = true;
            this.btnInstallExtension.Click += new System.EventHandler(this.btnInstallExtension_Click);
            // 
            // btnUpdateRepo
            // 
            this.btnUpdateRepo.Location = new System.Drawing.Point(293, 75);
            this.btnUpdateRepo.Name = "btnUpdateRepo";
            this.btnUpdateRepo.Size = new System.Drawing.Size(235, 45);
            this.btnUpdateRepo.TabIndex = 0;
            this.btnUpdateRepo.Text = "sd-scriptsのアップデート";
            this.btnUpdateRepo.UseVisualStyleBackColor = true;
            this.btnUpdateRepo.Click += new System.EventHandler(this.btnUpdateRepo_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbxTaggerModel);
            this.tabPage4.Controls.Add(this.btnRunTagger);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.lblTaggerDir);
            this.tabPage4.Controls.Add(this.btnTaggetSelectDir);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.nudThresh);
            this.tabPage4.Controls.Add(this.nudTaggerBatchSize);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.tbxTaggerExclude);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(804, 384);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tagger";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(26, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "未実装";
            // 
            // tbxTaggerExclude
            // 
            this.tbxTaggerExclude.Location = new System.Drawing.Point(26, 159);
            this.tbxTaggerExclude.Name = "tbxTaggerExclude";
            this.tbxTaggerExclude.Size = new System.Drawing.Size(749, 31);
            this.tbxTaggerExclude.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "除外タグ(アンダースコア込み)。コンマ区切り";
            // 
            // nudTaggerBatchSize
            // 
            this.nudTaggerBatchSize.Location = new System.Drawing.Point(26, 228);
            this.nudTaggerBatchSize.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudTaggerBatchSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTaggerBatchSize.Name = "nudTaggerBatchSize";
            this.nudTaggerBatchSize.Size = new System.Drawing.Size(120, 31);
            this.nudTaggerBatchSize.TabIndex = 3;
            this.nudTaggerBatchSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Batch size";
            // 
            // btnTaggetSelectDir
            // 
            this.btnTaggetSelectDir.Location = new System.Drawing.Point(26, 72);
            this.btnTaggetSelectDir.Name = "btnTaggetSelectDir";
            this.btnTaggetSelectDir.Size = new System.Drawing.Size(117, 38);
            this.btnTaggetSelectDir.TabIndex = 5;
            this.btnTaggetSelectDir.Text = "選択";
            this.btnTaggetSelectDir.UseVisualStyleBackColor = true;
            // 
            // lblTaggerDir
            // 
            this.lblTaggerDir.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTaggerDir.Location = new System.Drawing.Point(149, 79);
            this.lblTaggerDir.Name = "lblTaggerDir";
            this.lblTaggerDir.Size = new System.Drawing.Size(626, 31);
            this.lblTaggerDir.TabIndex = 6;
            this.lblTaggerDir.Text = "選択してください";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "ディレクトリ";
            // 
            // btnRunTagger
            // 
            this.btnRunTagger.Location = new System.Drawing.Point(663, 323);
            this.btnRunTagger.Name = "btnRunTagger";
            this.btnRunTagger.Size = new System.Drawing.Size(112, 43);
            this.btnRunTagger.TabIndex = 7;
            this.btnRunTagger.Text = "尋問";
            this.btnRunTagger.UseVisualStyleBackColor = true;
            // 
            // cbxTaggerModel
            // 
            this.cbxTaggerModel.FormattingEnabled = true;
            this.cbxTaggerModel.Items.AddRange(new object[] {
            "convnext-v2",
            "convnext",
            "vit-v2",
            "vit"});
            this.cbxTaggerModel.Location = new System.Drawing.Point(26, 302);
            this.cbxTaggerModel.Name = "cbxTaggerModel";
            this.cbxTaggerModel.Size = new System.Drawing.Size(163, 33);
            this.cbxTaggerModel.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "モデル";
            // 
            // nudThresh
            // 
            this.nudThresh.DecimalPlaces = 2;
            this.nudThresh.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudThresh.Location = new System.Drawing.Point(202, 228);
            this.nudThresh.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThresh.Name = "nudThresh";
            this.nudThresh.Size = new System.Drawing.Size(120, 31);
            this.nudThresh.TabIndex = 3;
            this.nudThresh.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "タグ検出の閾値";
            // 
            // FormUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(840, 446);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUtils";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Utils";
            this.Load += new System.EventHandler(this.FormUtils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetDim)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaggerBatchSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRunTensorboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectModel;
        private System.Windows.Forms.Button btnResizeDim;
        private System.Windows.Forms.CheckBox cbxCudaConversion;
        private System.Windows.Forms.Label lblLoraPath;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.NumericUpDown nudTargetDim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectOutputPath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnUpdateRepo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInstallExtension;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRunTagger;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTaggerDir;
        private System.Windows.Forms.Button btnTaggetSelectDir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudTaggerBatchSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTaggerExclude;
        private System.Windows.Forms.ComboBox cbxTaggerModel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudThresh;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
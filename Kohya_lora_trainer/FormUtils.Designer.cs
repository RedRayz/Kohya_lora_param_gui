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
            this.btnInstallLeco = new System.Windows.Forms.Button();
            this.btnRunLeco = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetDim)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRunTensorboard
            // 
            this.btnRunTensorboard.Location = new System.Drawing.Point(212, 107);
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
            this.label3.Location = new System.Drawing.Point(196, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "ターミナルは手動で閉じてください";
            // 
            // btnSelectModel
            // 
            this.btnSelectModel.Location = new System.Drawing.Point(24, 22);
            this.btnSelectModel.Name = "btnSelectModel";
            this.btnSelectModel.Size = new System.Drawing.Size(134, 37);
            this.btnSelectModel.TabIndex = 5;
            this.btnSelectModel.Text = "変換元の選択";
            this.btnSelectModel.UseVisualStyleBackColor = true;
            this.btnSelectModel.Click += new System.EventHandler(this.btnSelectModel_Click);
            // 
            // btnResizeDim
            // 
            this.btnResizeDim.Location = new System.Drawing.Point(24, 225);
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
            this.cbxCudaConversion.Location = new System.Drawing.Point(168, 138);
            this.cbxCudaConversion.Name = "cbxCudaConversion";
            this.cbxCudaConversion.Size = new System.Drawing.Size(136, 29);
            this.cbxCudaConversion.TabIndex = 6;
            this.cbxCudaConversion.Text = "CUDAで変換";
            this.cbxCudaConversion.UseVisualStyleBackColor = true;
            // 
            // lblLoraPath
            // 
            this.lblLoraPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLoraPath.Location = new System.Drawing.Point(164, 22);
            this.lblLoraPath.Name = "lblLoraPath";
            this.lblLoraPath.Size = new System.Drawing.Size(474, 37);
            this.lblLoraPath.TabIndex = 7;
            this.lblLoraPath.Text = "G:\\SD\\model\\lora\\longlongname\\aaaaa.safetensors";
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOutputPath.Location = new System.Drawing.Point(164, 65);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(474, 37);
            this.lblOutputPath.TabIndex = 7;
            this.lblOutputPath.Text = "G:\\SD\\model\\lora\\longlongname\\aaaaa.safetensors";
            // 
            // nudTargetDim
            // 
            this.nudTargetDim.Location = new System.Drawing.Point(24, 138);
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
            this.nudTargetDim.Size = new System.Drawing.Size(89, 31);
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
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "次元数";
            // 
            // btnSelectOutputPath
            // 
            this.btnSelectOutputPath.Location = new System.Drawing.Point(24, 65);
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
            this.tabControl1.Size = new System.Drawing.Size(663, 325);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRunTensorboard);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(655, 287);
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
            this.tabPage2.Size = new System.Drawing.Size(655, 287);
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
            this.tabPage3.Size = new System.Drawing.Size(655, 287);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "更新";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "リポジトリと必須のpythonパッケージの更新をします。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "lycorisおよび追加のオプティマイザを\r\nインストールまたは更新をします。";
            // 
            // btnInstallExtension
            // 
            this.btnInstallExtension.Location = new System.Drawing.Point(197, 146);
            this.btnInstallExtension.Name = "btnInstallExtension";
            this.btnInstallExtension.Size = new System.Drawing.Size(235, 45);
            this.btnInstallExtension.TabIndex = 1;
            this.btnInstallExtension.Text = "拡張機能のインストール・更新";
            this.btnInstallExtension.UseVisualStyleBackColor = true;
            this.btnInstallExtension.Click += new System.EventHandler(this.btnInstallExtension_Click);
            // 
            // btnUpdateRepo
            // 
            this.btnUpdateRepo.Location = new System.Drawing.Point(197, 44);
            this.btnUpdateRepo.Name = "btnUpdateRepo";
            this.btnUpdateRepo.Size = new System.Drawing.Size(235, 45);
            this.btnUpdateRepo.TabIndex = 0;
            this.btnUpdateRepo.Text = "sd-scriptsのアップデート";
            this.btnUpdateRepo.UseVisualStyleBackColor = true;
            this.btnUpdateRepo.Click += new System.EventHandler(this.btnUpdateRepo_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.btnRunLeco);
            this.tabPage4.Controls.Add(this.btnInstallLeco);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(655, 287);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "LECO";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnInstallLeco
            // 
            this.btnInstallLeco.Location = new System.Drawing.Point(241, 47);
            this.btnInstallLeco.Name = "btnInstallLeco";
            this.btnInstallLeco.Size = new System.Drawing.Size(169, 38);
            this.btnInstallLeco.TabIndex = 0;
            this.btnInstallLeco.Text = "LECOのインストール";
            this.btnInstallLeco.UseVisualStyleBackColor = true;
            this.btnInstallLeco.Click += new System.EventHandler(this.btnInstallLeco_Click);
            // 
            // btnRunLeco
            // 
            this.btnRunLeco.Location = new System.Drawing.Point(241, 163);
            this.btnRunLeco.Name = "btnRunLeco";
            this.btnRunLeco.Size = new System.Drawing.Size(169, 38);
            this.btnRunLeco.TabIndex = 0;
            this.btnRunLeco.Text = "LECOの学習";
            this.btnRunLeco.UseVisualStyleBackColor = true;
            this.btnRunLeco.Click += new System.EventHandler(this.btnRunLeco_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "config.yamlを指定してください";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "GUIフォルダと同階層にインストールします";
            // 
            // FormUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(693, 366);
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
        private System.Windows.Forms.Button btnRunLeco;
        private System.Windows.Forms.Button btnInstallLeco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
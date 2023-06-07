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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectModel = new System.Windows.Forms.Button();
            this.btnResizeDim = new System.Windows.Forms.Button();
            this.cbxCudaConversion = new System.Windows.Forms.CheckBox();
            this.lblLoraPath = new System.Windows.Forms.Label();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.nudTargetDim = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectOutputPath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetDim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRunTensorboard
            // 
            this.btnRunTensorboard.Location = new System.Drawing.Point(24, 31);
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
            this.label3.Location = new System.Drawing.Point(244, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "ターミナルは手動で閉じてください";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dimのリサイズ";
            // 
            // btnSelectModel
            // 
            this.btnSelectModel.Location = new System.Drawing.Point(35, 139);
            this.btnSelectModel.Name = "btnSelectModel";
            this.btnSelectModel.Size = new System.Drawing.Size(134, 37);
            this.btnSelectModel.TabIndex = 5;
            this.btnSelectModel.Text = "変換元の選択";
            this.btnSelectModel.UseVisualStyleBackColor = true;
            this.btnSelectModel.Click += new System.EventHandler(this.btnSelectModel_Click);
            // 
            // btnResizeDim
            // 
            this.btnResizeDim.Location = new System.Drawing.Point(35, 275);
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
            this.cbxCudaConversion.Location = new System.Drawing.Point(208, 236);
            this.cbxCudaConversion.Name = "cbxCudaConversion";
            this.cbxCudaConversion.Size = new System.Drawing.Size(136, 29);
            this.cbxCudaConversion.TabIndex = 6;
            this.cbxCudaConversion.Text = "CUDAで変換";
            this.cbxCudaConversion.UseVisualStyleBackColor = true;
            // 
            // lblLoraPath
            // 
            this.lblLoraPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLoraPath.Location = new System.Drawing.Point(175, 139);
            this.lblLoraPath.Name = "lblLoraPath";
            this.lblLoraPath.Size = new System.Drawing.Size(452, 37);
            this.lblLoraPath.TabIndex = 7;
            this.lblLoraPath.Text = "G:\\SD\\model\\lora\\longlongname\\aaaaa.safetensors";
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOutputPath.Location = new System.Drawing.Point(175, 182);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(452, 37);
            this.lblOutputPath.TabIndex = 7;
            this.lblOutputPath.Text = "G:\\SD\\model\\lora\\longlongname\\aaaaa.safetensors";
            // 
            // nudTargetDim
            // 
            this.nudTargetDim.Location = new System.Drawing.Point(97, 234);
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
            this.label2.Location = new System.Drawing.Point(47, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dim";
            // 
            // btnSelectOutputPath
            // 
            this.btnSelectOutputPath.Location = new System.Drawing.Point(35, 182);
            this.btnSelectOutputPath.Name = "btnSelectOutputPath";
            this.btnSelectOutputPath.Size = new System.Drawing.Size(134, 37);
            this.btnSelectOutputPath.TabIndex = 10;
            this.btnSelectOutputPath.Text = "出力先の選択";
            this.btnSelectOutputPath.UseVisualStyleBackColor = true;
            this.btnSelectOutputPath.Click += new System.EventHandler(this.btnSelectOutputPath_Click);
            // 
            // FormUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(662, 323);
            this.Controls.Add(this.btnSelectOutputPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTargetDim);
            this.Controls.Add(this.lblOutputPath);
            this.Controls.Add(this.lblLoraPath);
            this.Controls.Add(this.cbxCudaConversion);
            this.Controls.Add(this.btnResizeDim);
            this.Controls.Add(this.btnSelectModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRunTensorboard);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRunTensorboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectModel;
        private System.Windows.Forms.Button btnResizeDim;
        private System.Windows.Forms.CheckBox cbxCudaConversion;
        private System.Windows.Forms.Label lblLoraPath;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.NumericUpDown nudTargetDim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectOutputPath;
    }
}
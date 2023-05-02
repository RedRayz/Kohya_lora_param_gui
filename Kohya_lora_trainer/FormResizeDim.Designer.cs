namespace Kohya_lora_trainer
{
    partial class FormResizeDim
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
            this.btnSelectModel = new System.Windows.Forms.Button();
            this.btnPathToSave = new System.Windows.Forms.Button();
            this.lblModelPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDimSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDimSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectModel
            // 
            this.btnSelectModel.Location = new System.Drawing.Point(43, 62);
            this.btnSelectModel.Name = "btnSelectModel";
            this.btnSelectModel.Size = new System.Drawing.Size(129, 40);
            this.btnSelectModel.TabIndex = 0;
            this.btnSelectModel.Text = "選択";
            this.btnSelectModel.UseVisualStyleBackColor = true;
            this.btnSelectModel.Click += new System.EventHandler(this.btnSelectModel_Click);
            // 
            // btnPathToSave
            // 
            this.btnPathToSave.Location = new System.Drawing.Point(363, 62);
            this.btnPathToSave.Name = "btnPathToSave";
            this.btnPathToSave.Size = new System.Drawing.Size(129, 40);
            this.btnPathToSave.TabIndex = 0;
            this.btnPathToSave.Text = "選択";
            this.btnPathToSave.UseVisualStyleBackColor = true;
            this.btnPathToSave.Click += new System.EventHandler(this.btnPathToSave_Click);
            // 
            // lblModelPath
            // 
            this.lblModelPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblModelPath.Location = new System.Drawing.Point(39, 105);
            this.lblModelPath.Name = "lblModelPath";
            this.lblModelPath.Size = new System.Drawing.Size(233, 47);
            this.lblModelPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "変更するモデル";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "保存先";
            // 
            // nudDimSize
            // 
            this.nudDimSize.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudDimSize.Location = new System.Drawing.Point(52, 216);
            this.nudDimSize.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudDimSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDimSize.Name = "nudDimSize";
            this.nudDimSize.Size = new System.Drawing.Size(120, 34);
            this.nudDimSize.TabIndex = 3;
            this.nudDimSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "次元数";
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOutputPath.Location = new System.Drawing.Point(359, 105);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(233, 47);
            this.lblOutputPath.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(467, 238);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(125, 47);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "変換";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // FormResizeDim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 297);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudDimSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOutputPath);
            this.Controls.Add(this.lblModelPath);
            this.Controls.Add(this.btnPathToSave);
            this.Controls.Add(this.btnSelectModel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormResizeDim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dimリサイズ";
            ((System.ComponentModel.ISupportInitialize)(this.nudDimSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectModel;
        private System.Windows.Forms.Button btnPathToSave;
        private System.Windows.Forms.Label lblModelPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDimSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.Button btnConvert;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtils));
            this.btnCheckCorrupt = new System.Windows.Forms.Button();
            this.lblTipNeedScript = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunTensorboard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxConsoleOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCheckCorrupt
            // 
            this.btnCheckCorrupt.Location = new System.Drawing.Point(43, 44);
            this.btnCheckCorrupt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckCorrupt.Name = "btnCheckCorrupt";
            this.btnCheckCorrupt.Size = new System.Drawing.Size(214, 44);
            this.btnCheckCorrupt.TabIndex = 0;
            this.btnCheckCorrupt.Text = "position_ids破損チェック";
            this.btnCheckCorrupt.UseVisualStyleBackColor = true;
            this.btnCheckCorrupt.Click += new System.EventHandler(this.btnCheckCorrupt_Click);
            // 
            // lblTipNeedScript
            // 
            this.lblTipNeedScript.AutoSize = true;
            this.lblTipNeedScript.Location = new System.Drawing.Point(263, 54);
            this.lblTipNeedScript.Name = "lblTipNeedScript";
            this.lblTipNeedScript.Size = new System.Drawing.Size(345, 25);
            this.lblTipNeedScript.TabIndex = 1;
            this.lblTipNeedScript.Text = "sd-scripts内にfix_position_ids.pyが必要です";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Console Output";
            // 
            // btnRunTensorboard
            // 
            this.btnRunTensorboard.Location = new System.Drawing.Point(43, 96);
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
            this.label3.Location = new System.Drawing.Point(263, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "ターミナルは手動で閉じてください";
            // 
            // tbxConsoleOutput
            // 
            this.tbxConsoleOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxConsoleOutput.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConsoleOutput.ForeColor = System.Drawing.Color.White;
            this.tbxConsoleOutput.Location = new System.Drawing.Point(12, 220);
            this.tbxConsoleOutput.Multiline = true;
            this.tbxConsoleOutput.Name = "tbxConsoleOutput";
            this.tbxConsoleOutput.ReadOnly = true;
            this.tbxConsoleOutput.Size = new System.Drawing.Size(983, 394);
            this.tbxConsoleOutput.TabIndex = 2;
            this.tbxConsoleOutput.Text = resources.GetString("tbxConsoleOutput.Text");
            // 
            // FormUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1007, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxConsoleOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTipNeedScript);
            this.Controls.Add(this.btnRunTensorboard);
            this.Controls.Add(this.btnCheckCorrupt);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUtils";
            this.Text = "Utils";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUtils_FormClosing);
            this.Load += new System.EventHandler(this.FormUtils_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckCorrupt;
        private System.Windows.Forms.Label lblTipNeedScript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRunTensorboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxConsoleOutput;
    }
}
namespace Kohya_lora_trainer {
    partial class TrainForm {
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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopyCmd = new System.Windows.Forms.Button();
            this.lblCuntdown = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.MistyRose;
            this.btnStop.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStop.Location = new System.Drawing.Point(90, 37);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(257, 47);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "ターミナルを閉じる";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(90, 90);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(257, 47);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "このウィンドウを閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "注意!ターミナルを閉じると学習は中止します!";
            // 
            // btnCopyCmd
            // 
            this.btnCopyCmd.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCopyCmd.Location = new System.Drawing.Point(209, 229);
            this.btnCopyCmd.Name = "btnCopyCmd";
            this.btnCopyCmd.Size = new System.Drawing.Size(210, 32);
            this.btnCopyCmd.TabIndex = 4;
            this.btnCopyCmd.Text = "コマンドをクリップボードにコピー";
            this.btnCopyCmd.UseVisualStyleBackColor = true;
            this.btnCopyCmd.Click += new System.EventHandler(this.btnCopyCmd_Click);
            // 
            // lblCuntdown
            // 
            this.lblCuntdown.AutoSize = true;
            this.lblCuntdown.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCuntdown.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCuntdown.Location = new System.Drawing.Point(55, 149);
            this.lblCuntdown.Name = "lblCuntdown";
            this.lblCuntdown.Size = new System.Drawing.Size(344, 56);
            this.lblCuntdown.TabIndex = 6;
            this.lblCuntdown.Text = "30秒後にシャットダウンします\r\nしない場合はこのウィンドウを閉じてください";
            this.lblCuntdown.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 273);
            this.ControlBox = false;
            this.Controls.Add(this.lblCuntdown);
            this.Controls.Add(this.btnCopyCmd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStop);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "学習";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainForm_FormClosing);
            this.Load += new System.EventHandler(this.TrainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopyCmd;
        private System.Windows.Forms.Label lblCuntdown;
        private System.Windows.Forms.Timer timer1;
    }
}
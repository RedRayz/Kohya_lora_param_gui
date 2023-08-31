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
            this.lblCountdown = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.MistyRose;
            this.btnStop.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStop.Location = new System.Drawing.Point(60, 25);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(171, 31);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "ターミナルを閉じる";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(60, 60);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "このウィンドウを閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "注意!ターミナルを閉じると学習は中止します!";
            // 
            // btnCopyCmd
            // 
            this.btnCopyCmd.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCopyCmd.Location = new System.Drawing.Point(123, 148);
            this.btnCopyCmd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCopyCmd.Name = "btnCopyCmd";
            this.btnCopyCmd.Size = new System.Drawing.Size(153, 23);
            this.btnCopyCmd.TabIndex = 4;
            this.btnCopyCmd.Text = "コマンドをクリップボードにコピー";
            this.btnCopyCmd.UseVisualStyleBackColor = true;
            this.btnCopyCmd.Click += new System.EventHandler(this.btnCopyCmd_Click);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCountdown.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCountdown.Location = new System.Drawing.Point(23, 93);
            this.lblCountdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(244, 38);
            this.lblCountdown.TabIndex = 6;
            this.lblCountdown.Text = "30秒後にシャットダウンします\r\nしない場合はこのウィンドウを閉じてください";
            this.lblCountdown.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(287, 182);
            this.ControlBox = false;
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.btnCopyCmd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStop);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Timer timer1;
    }
}
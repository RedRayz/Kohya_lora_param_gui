namespace Kohya_lora_trainer
{
    partial class TrainForm
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
            components = new System.ComponentModel.Container();
            btnStop = new Button();
            btnClose = new Button();
            btnCopyCmd = new Button();
            lblCountdown = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.MistyRose;
            btnStop.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.Location = new Point(116, 37);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(256, 46);
            btnStop.TabIndex = 1;
            btnStop.Text = "学習中止";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(116, 89);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(256, 46);
            btnClose.TabIndex = 2;
            btnClose.Text = "このウィンドウを閉じる";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCopyCmd
            // 
            btnCopyCmd.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopyCmd.Location = new Point(216, 246);
            btnCopyCmd.Name = "btnCopyCmd";
            btnCopyCmd.Size = new Size(230, 34);
            btnCopyCmd.TabIndex = 4;
            btnCopyCmd.Text = "コマンドをクリップボードにコピー";
            btnCopyCmd.UseVisualStyleBackColor = true;
            btnCopyCmd.Click += btnCopyCmd_Click;
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountdown.ForeColor = Color.OrangeRed;
            lblCountdown.Location = new Point(75, 138);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(344, 56);
            lblCountdown.TabIndex = 6;
            lblCountdown.Text = "30秒後にシャットダウンします\r\nしない場合はこのウィンドウを閉じてください";
            lblCountdown.Visible = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // TrainForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(470, 303);
            ControlBox = false;
            Controls.Add(lblCountdown);
            Controls.Add(btnCopyCmd);
            Controls.Add(btnClose);
            Controls.Add(btnStop);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TrainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "学習";
            FormClosing += TrainForm_FormClosing;
            Load += TrainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStop;
        private Button btnClose;
        private Button btnCopyCmd;
        private Label lblCountdown;
        private System.Windows.Forms.Timer timer1;
    }
}
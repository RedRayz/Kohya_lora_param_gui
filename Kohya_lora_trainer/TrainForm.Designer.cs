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
            lblProcessingCaptions = new Label();
            btnTensorboard = new Button();
            cbxCompleteAction = new ComboBox();
            lblCompleteAction = new Label();
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.MistyRose;
            btnStop.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.Location = new Point(76, 12);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(170, 36);
            btnStop.TabIndex = 1;
            btnStop.Text = "停止";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(76, 54);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(170, 36);
            btnClose.TabIndex = 2;
            btnClose.Text = "このウィンドウを閉じる";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCopyCmd
            // 
            btnCopyCmd.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopyCmd.Location = new Point(211, 177);
            btnCopyCmd.Name = "btnCopyCmd";
            btnCopyCmd.Size = new Size(93, 24);
            btnCopyCmd.TabIndex = 4;
            btnCopyCmd.Text = "コマンドをコピー";
            btnCopyCmd.UseVisualStyleBackColor = true;
            btnCopyCmd.Click += btnCopyCmd_Click;
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountdown.ForeColor = Color.OrangeRed;
            lblCountdown.Location = new Point(41, 114);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(244, 38);
            lblCountdown.TabIndex = 6;
            lblCountdown.Text = "30秒後にシャットダウンします\r\nしない場合はこのウィンドウを閉じてください";
            lblCountdown.Visible = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblProcessingCaptions
            // 
            lblProcessingCaptions.AutoSize = true;
            lblProcessingCaptions.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProcessingCaptions.Location = new Point(76, 93);
            lblProcessingCaptions.Name = "lblProcessingCaptions";
            lblProcessingCaptions.Size = new Size(167, 21);
            lblProcessingCaptions.TabIndex = 7;
            lblProcessingCaptions.Text = "キャプションのシャッフル中";
            // 
            // btnTensorboard
            // 
            btnTensorboard.Location = new Point(119, 177);
            btnTensorboard.Name = "btnTensorboard";
            btnTensorboard.Size = new Size(86, 24);
            btnTensorboard.TabIndex = 8;
            btnTensorboard.Text = "tensorboard";
            btnTensorboard.UseVisualStyleBackColor = true;
            btnTensorboard.Visible = false;
            btnTensorboard.Click += btnTensorboard_Click;
            // 
            // cbxCompleteAction
            // 
            cbxCompleteAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCompleteAction.FormattingEnabled = true;
            cbxCompleteAction.Items.AddRange(new object[] { "なにもしない", "経過時間表示", "シャットダウン", "スリープ" });
            cbxCompleteAction.Location = new Point(12, 179);
            cbxCompleteAction.Name = "cbxCompleteAction";
            cbxCompleteAction.Size = new Size(101, 23);
            cbxCompleteAction.TabIndex = 9;
            cbxCompleteAction.SelectedIndexChanged += cbxCompleteAction_SelectedIndexChanged;
            // 
            // lblCompleteAction
            // 
            lblCompleteAction.AutoSize = true;
            lblCompleteAction.Location = new Point(12, 161);
            lblCompleteAction.Name = "lblCompleteAction";
            lblCompleteAction.Size = new Size(101, 15);
            lblCompleteAction.TabIndex = 10;
            lblCompleteAction.Text = "学習終了時の動作";
            // 
            // TrainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(321, 214);
            ControlBox = false;
            Controls.Add(lblCompleteAction);
            Controls.Add(cbxCompleteAction);
            Controls.Add(btnTensorboard);
            Controls.Add(lblProcessingCaptions);
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
            Shown += TrainForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStop;
        private Button btnClose;
        private Button btnCopyCmd;
        private Label lblCountdown;
        private System.Windows.Forms.Timer timer1;
        private Label lblProcessingCaptions;
        private Button btnTensorboard;
        private ComboBox cbxCompleteAction;
        private Label lblCompleteAction;
    }
}
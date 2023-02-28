
namespace Kohya_lora_trainer
{
    partial class Form_Advanced
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
            this.components = new System.ComponentModel.Container();
            this.tbxUnetLR = new System.Windows.Forms.TextBox();
            this.tbxTextEncoLR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNoUpscale = new System.Windows.Forms.CheckBox();
            this.tbrCpuThreads = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCpuThreadsCounter = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxUseWarmupInit = new System.Windows.Forms.CheckBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tbxExtension = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxPrecision = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxScheduler = new System.Windows.Forms.ComboBox();
            this.nudClipSkip = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbrCpuThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClipSkip)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUnetLR
            // 
            this.tbxUnetLR.Location = new System.Drawing.Point(211, 169);
            this.tbxUnetLR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxUnetLR.Name = "tbxUnetLR";
            this.tbxUnetLR.Size = new System.Drawing.Size(100, 31);
            this.tbxUnetLR.TabIndex = 0;
            // 
            // tbxTextEncoLR
            // 
            this.tbxTextEncoLR.Location = new System.Drawing.Point(547, 166);
            this.tbxTextEncoLR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxTextEncoLR.Name = "tbxTextEncoLR";
            this.tbxTextEncoLR.Size = new System.Drawing.Size(100, 31);
            this.tbxTextEncoLR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "UNet LR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text encoder LR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "最小バケット解像度*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "最大バケット解像度*";
            // 
            // cbxNoUpscale
            // 
            this.cbxNoUpscale.AutoSize = true;
            this.cbxNoUpscale.Location = new System.Drawing.Point(50, 286);
            this.cbxNoUpscale.Name = "cbxNoUpscale";
            this.cbxNoUpscale.Size = new System.Drawing.Size(283, 29);
            this.cbxNoUpscale.TabIndex = 8;
            this.cbxNoUpscale.Text = "バケットのアップスケーリングをしない";
            this.cbxNoUpscale.UseVisualStyleBackColor = true;
            // 
            // tbrCpuThreads
            // 
            this.tbrCpuThreads.Location = new System.Drawing.Point(159, 32);
            this.tbrCpuThreads.Maximum = 32;
            this.tbrCpuThreads.Minimum = 1;
            this.tbrCpuThreads.Name = "tbrCpuThreads";
            this.tbrCpuThreads.Size = new System.Drawing.Size(470, 69);
            this.tbrCpuThreads.TabIndex = 9;
            this.tbrCpuThreads.Value = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPUスレッド数*";
            // 
            // lblCpuThreadsCounter
            // 
            this.lblCpuThreadsCounter.AutoSize = true;
            this.lblCpuThreadsCounter.Location = new System.Drawing.Point(646, 32);
            this.lblCpuThreadsCounter.Name = "lblCpuThreadsCounter";
            this.lblCpuThreadsCounter.Size = new System.Drawing.Size(32, 25);
            this.lblCpuThreadsCounter.TabIndex = 11;
            this.lblCpuThreadsCounter.Text = "12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Clip Skip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Seed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(48, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "-通常編集の必要のない設定-";
            // 
            // cbxUseWarmupInit
            // 
            this.cbxUseWarmupInit.AutoSize = true;
            this.cbxUseWarmupInit.Location = new System.Drawing.Point(411, 286);
            this.cbxUseWarmupInit.Name = "cbxUseWarmupInit";
            this.cbxUseWarmupInit.Size = new System.Drawing.Size(302, 29);
            this.cbxUseWarmupInit.TabIndex = 18;
            this.cbxUseWarmupInit.Text = "AdaFactor: warmup_initを使用する";
            this.toolTip2.SetToolTip(this.cbxUseWarmupInit, "使用すると、学習が遅くなります。");
            this.cbxUseWarmupInit.UseVisualStyleBackColor = true;
            // 
            // tbxExtension
            // 
            this.tbxExtension.Location = new System.Drawing.Point(211, 496);
            this.tbxExtension.Name = "tbxExtension";
            this.tbxExtension.Size = new System.Drawing.Size(126, 31);
            this.tbxExtension.TabIndex = 19;
            this.tbxExtension.Text = ".txt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 50);
            this.label9.TabIndex = 20;
            this.label9.Text = "キャプションファイルの\r\n拡張子";
            // 
            // cbxPrecision
            // 
            this.cbxPrecision.AutoSize = true;
            this.cbxPrecision.Checked = true;
            this.cbxPrecision.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPrecision.Location = new System.Drawing.Point(477, 499);
            this.cbxPrecision.Name = "cbxPrecision";
            this.cbxPrecision.Size = new System.Drawing.Size(125, 29);
            this.cbxPrecision.TabIndex = 21;
            this.cbxPrecision.Text = "fp16で保存";
            this.cbxPrecision.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(760, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudSeed
            // 
            this.nudSeed.Location = new System.Drawing.Point(547, 430);
            this.nudSeed.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(120, 31);
            this.nudSeed.TabIndex = 23;
            this.nudSeed.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(211, 224);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown2.TabIndex = 24;
            this.numericUpDown2.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(547, 224);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown3.TabIndex = 25;
            this.numericUpDown3.Value = new decimal(new int[] {
            960,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "スケジューラ";
            // 
            // cbxScheduler
            // 
            this.cbxScheduler.FormattingEnabled = true;
            this.cbxScheduler.Items.AddRange(new object[] {
            "cosine_with_restarts",
            "cosine",
            "linear",
            "polynomial",
            "constant",
            "constant_with_warmup"});
            this.cbxScheduler.Location = new System.Drawing.Point(211, 107);
            this.cbxScheduler.Name = "cbxScheduler";
            this.cbxScheduler.Size = new System.Drawing.Size(212, 33);
            this.cbxScheduler.TabIndex = 27;
            this.cbxScheduler.Text = "cosine_with_restarts";
            // 
            // nudClipSkip
            // 
            this.nudClipSkip.Location = new System.Drawing.Point(211, 429);
            this.nudClipSkip.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudClipSkip.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClipSkip.Name = "nudClipSkip";
            this.nudClipSkip.Size = new System.Drawing.Size(120, 31);
            this.nudClipSkip.TabIndex = 28;
            this.nudClipSkip.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form_Advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 663);
            this.Controls.Add(this.nudClipSkip);
            this.Controls.Add(this.cbxScheduler);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.nudSeed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxPrecision);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxExtension);
            this.Controls.Add(this.cbxUseWarmupInit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCpuThreadsCounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbrCpuThreads);
            this.Controls.Add(this.cbxNoUpscale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTextEncoLR);
            this.Controls.Add(this.tbxUnetLR);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Advanced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Advanced";
            ((System.ComponentModel.ISupportInitialize)(this.tbrCpuThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClipSkip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUnetLR;
        private System.Windows.Forms.TextBox tbxTextEncoLR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxNoUpscale;
        private System.Windows.Forms.TrackBar tbrCpuThreads;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCpuThreadsCounter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxUseWarmupInit;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox tbxExtension;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbxPrecision;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxScheduler;
        private System.Windows.Forms.NumericUpDown nudClipSkip;
    }
}
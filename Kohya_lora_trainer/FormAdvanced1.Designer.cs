namespace Kohya_lora_trainer
{
    partial class FormAdvanced1
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
            this.cbxUseColorAug = new System.Windows.Forms.CheckBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDiscardChanges = new System.Windows.Forms.Button();
            this.cbxMixedPrecision = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLRSchedulerCycle = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUseFastLoading = new System.Windows.Forms.CheckBox();
            this.nudDataLoaderThreads = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUseV2 = new System.Windows.Forms.CheckBox();
            this.nudMaxTokens = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDontSaveMetadata = new System.Windows.Forms.CheckBox();
            this.cbxCropRandomly = new System.Windows.Forms.CheckBox();
            this.cbxFlipAug = new System.Windows.Forms.CheckBox();
            this.cbxUseParametarization = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLRSchedulerCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataLoaderThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxUseColorAug
            // 
            this.cbxUseColorAug.AutoSize = true;
            this.cbxUseColorAug.Checked = true;
            this.cbxUseColorAug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUseColorAug.Location = new System.Drawing.Point(45, 22);
            this.cbxUseColorAug.Name = "cbxUseColorAug";
            this.cbxUseColorAug.Size = new System.Drawing.Size(165, 29);
            this.cbxUseColorAug.TabIndex = 0;
            this.cbxUseColorAug.Text = "color_augを使用";
            this.cbxUseColorAug.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(553, 358);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(199, 42);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "設定を反映して閉じる";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDiscardChanges
            // 
            this.btnDiscardChanges.Location = new System.Drawing.Point(348, 358);
            this.btnDiscardChanges.Name = "btnDiscardChanges";
            this.btnDiscardChanges.Size = new System.Drawing.Size(199, 42);
            this.btnDiscardChanges.TabIndex = 1;
            this.btnDiscardChanges.Text = "設定を反映せずに閉じる";
            this.btnDiscardChanges.UseVisualStyleBackColor = true;
            this.btnDiscardChanges.Click += new System.EventHandler(this.btnDiscardChanges_Click);
            // 
            // cbxMixedPrecision
            // 
            this.cbxMixedPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMixedPrecision.FormattingEnabled = true;
            this.cbxMixedPrecision.Items.AddRange(new object[] {
            "なし",
            "fp16",
            "bf16"});
            this.cbxMixedPrecision.Location = new System.Drawing.Point(250, 184);
            this.cbxMixedPrecision.Name = "cbxMixedPrecision";
            this.cbxMixedPrecision.Size = new System.Drawing.Size(120, 33);
            this.cbxMixedPrecision.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "混合精度";
            // 
            // nudLRSchedulerCycle
            // 
            this.nudLRSchedulerCycle.Location = new System.Drawing.Point(250, 223);
            this.nudLRSchedulerCycle.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudLRSchedulerCycle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLRSchedulerCycle.Name = "nudLRSchedulerCycle";
            this.nudLRSchedulerCycle.Size = new System.Drawing.Size(120, 31);
            this.nudLRSchedulerCycle.TabIndex = 4;
            this.nudLRSchedulerCycle.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "LRスケジューラのサイクル";
            // 
            // cbxUseFastLoading
            // 
            this.cbxUseFastLoading.AutoSize = true;
            this.cbxUseFastLoading.Checked = true;
            this.cbxUseFastLoading.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUseFastLoading.Location = new System.Drawing.Point(45, 57);
            this.cbxUseFastLoading.Name = "cbxUseFastLoading";
            this.cbxUseFastLoading.Size = new System.Drawing.Size(143, 29);
            this.cbxUseFastLoading.TabIndex = 0;
            this.cbxUseFastLoading.Text = "読込の高速化";
            this.cbxUseFastLoading.UseVisualStyleBackColor = true;
            // 
            // nudDataLoaderThreads
            // 
            this.nudDataLoaderThreads.Location = new System.Drawing.Point(250, 264);
            this.nudDataLoaderThreads.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudDataLoaderThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDataLoaderThreads.Name = "nudDataLoaderThreads";
            this.nudDataLoaderThreads.Size = new System.Drawing.Size(120, 31);
            this.nudDataLoaderThreads.TabIndex = 4;
            this.nudDataLoaderThreads.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "データローダのCPUスレッド数";
            // 
            // cbxUseV2
            // 
            this.cbxUseV2.AutoSize = true;
            this.cbxUseV2.Location = new System.Drawing.Point(45, 92);
            this.cbxUseV2.Name = "cbxUseV2";
            this.cbxUseV2.Size = new System.Drawing.Size(243, 29);
            this.cbxUseV2.TabIndex = 0;
            this.cbxUseV2.Text = "Stable Diffusion 2.Xを使用";
            this.cbxUseV2.UseVisualStyleBackColor = true;
            // 
            // nudMaxTokens
            // 
            this.nudMaxTokens.Increment = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudMaxTokens.Location = new System.Drawing.Point(250, 301);
            this.nudMaxTokens.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.nudMaxTokens.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudMaxTokens.Name = "nudMaxTokens";
            this.nudMaxTokens.Size = new System.Drawing.Size(120, 31);
            this.nudMaxTokens.TabIndex = 4;
            this.nudMaxTokens.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "最大トークン数";
            // 
            // cbxDontSaveMetadata
            // 
            this.cbxDontSaveMetadata.AutoSize = true;
            this.cbxDontSaveMetadata.Location = new System.Drawing.Point(425, 92);
            this.cbxDontSaveMetadata.Name = "cbxDontSaveMetadata";
            this.cbxDontSaveMetadata.Size = new System.Drawing.Size(198, 29);
            this.cbxDontSaveMetadata.TabIndex = 0;
            this.cbxDontSaveMetadata.Text = "メタデータを保存しない";
            this.cbxDontSaveMetadata.UseVisualStyleBackColor = true;
            // 
            // cbxCropRandomly
            // 
            this.cbxCropRandomly.AutoSize = true;
            this.cbxCropRandomly.Location = new System.Drawing.Point(425, 57);
            this.cbxCropRandomly.Name = "cbxCropRandomly";
            this.cbxCropRandomly.Size = new System.Drawing.Size(206, 29);
            this.cbxCropRandomly.TabIndex = 0;
            this.cbxCropRandomly.Text = "画像をランダムにクロップ";
            this.cbxCropRandomly.UseVisualStyleBackColor = true;
            // 
            // cbxFlipAug
            // 
            this.cbxFlipAug.AutoSize = true;
            this.cbxFlipAug.Location = new System.Drawing.Point(425, 22);
            this.cbxFlipAug.Name = "cbxFlipAug";
            this.cbxFlipAug.Size = new System.Drawing.Size(160, 29);
            this.cbxFlipAug.TabIndex = 0;
            this.cbxFlipAug.Text = "反転画像を使用";
            this.cbxFlipAug.UseVisualStyleBackColor = true;
            // 
            // cbxUseParametarization
            // 
            this.cbxUseParametarization.AutoSize = true;
            this.cbxUseParametarization.Location = new System.Drawing.Point(45, 127);
            this.cbxUseParametarization.Name = "cbxUseParametarization";
            this.cbxUseParametarization.Size = new System.Drawing.Size(258, 29);
            this.cbxUseParametarization.TabIndex = 0;
            this.cbxUseParametarization.Text = "SD2:パラメタリゼーションの使用";
            this.cbxUseParametarization.UseVisualStyleBackColor = true;
            // 
            // FormAdvanced1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 412);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMaxTokens);
            this.Controls.Add(this.nudDataLoaderThreads);
            this.Controls.Add(this.nudLRSchedulerCycle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMixedPrecision);
            this.Controls.Add(this.btnDiscardChanges);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.cbxFlipAug);
            this.Controls.Add(this.cbxCropRandomly);
            this.Controls.Add(this.cbxDontSaveMetadata);
            this.Controls.Add(this.cbxUseParametarization);
            this.Controls.Add(this.cbxUseV2);
            this.Controls.Add(this.cbxUseFastLoading);
            this.Controls.Add(this.cbxUseColorAug);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAdvanced1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdvanced1";
            this.Load += new System.EventHandler(this.FormAdvanced1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLRSchedulerCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataLoaderThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxUseColorAug;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDiscardChanges;
        private System.Windows.Forms.ComboBox cbxMixedPrecision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLRSchedulerCycle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxUseFastLoading;
        private System.Windows.Forms.NumericUpDown nudDataLoaderThreads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxUseV2;
        private System.Windows.Forms.NumericUpDown nudMaxTokens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxDontSaveMetadata;
        private System.Windows.Forms.CheckBox cbxCropRandomly;
        private System.Windows.Forms.CheckBox cbxFlipAug;
        private System.Windows.Forms.CheckBox cbxUseParametarization;
    }
}
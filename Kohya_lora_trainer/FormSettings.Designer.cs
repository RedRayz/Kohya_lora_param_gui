namespace Kohya_lora_trainer
{
    partial class FormSettings
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
            label1 = new Label();
            label2 = new Label();
            tbxModel = new TextBox();
            btnSelectModel = new Button();
            brnClearModel = new Button();
            label3 = new Label();
            tbxImage = new TextBox();
            btnSelectImage = new Button();
            btnClearImage = new Button();
            label4 = new Label();
            tbxRegImage = new TextBox();
            btnSelectRegImage = new Button();
            btnClearRegImage = new Button();
            label5 = new Label();
            tbxOutput = new TextBox();
            btnSelectOutput = new Button();
            btnClearOutput = new Button();
            label6 = new Label();
            tbxPreset = new TextBox();
            btnSelectPreset = new Button();
            btnClearPreset = new Button();
            btnDiscardAndClose = new Button();
            label7 = new Label();
            tbxVAE = new TextBox();
            btnSelectVAE = new Button();
            btnClearVAE = new Button();
            label8 = new Label();
            tbxTensorboard = new TextBox();
            btnSelectTensorboard = new Button();
            btnClearTensorboard = new Button();
            label9 = new Label();
            tbxConfig = new TextBox();
            btnSelectConfig = new Button();
            btnClearConfig = new Button();
            btnApplyAndClose = new Button();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 0;
            label1.Text = "デフォルトで開くディレクトリ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 95);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "学習元モデル";
            // 
            // tbxModel
            // 
            tbxModel.Location = new Point(292, 92);
            tbxModel.Name = "tbxModel";
            tbxModel.Size = new Size(402, 23);
            tbxModel.TabIndex = 2;
            // 
            // btnSelectModel
            // 
            btnSelectModel.Location = new Point(130, 88);
            btnSelectModel.Name = "btnSelectModel";
            btnSelectModel.Size = new Size(75, 29);
            btnSelectModel.TabIndex = 3;
            btnSelectModel.Text = "選択";
            btnSelectModel.UseVisualStyleBackColor = true;
            btnSelectModel.Click += btnSelectModel_Click;
            // 
            // brnClearModel
            // 
            brnClearModel.Location = new Point(211, 88);
            brnClearModel.Name = "brnClearModel";
            brnClearModel.Size = new Size(75, 29);
            brnClearModel.TabIndex = 3;
            brnClearModel.Text = "クリア";
            brnClearModel.UseVisualStyleBackColor = true;
            brnClearModel.Click += brnClearModel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 130);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 1;
            label3.Text = "教師画像フォルダ";
            // 
            // tbxImage
            // 
            tbxImage.Location = new Point(292, 127);
            tbxImage.Name = "tbxImage";
            tbxImage.Size = new Size(402, 23);
            tbxImage.TabIndex = 2;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(130, 123);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(75, 29);
            btnSelectImage.TabIndex = 3;
            btnSelectImage.Text = "選択";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // btnClearImage
            // 
            btnClearImage.Location = new Point(211, 123);
            btnClearImage.Name = "btnClearImage";
            btnClearImage.Size = new Size(75, 29);
            btnClearImage.TabIndex = 3;
            btnClearImage.Text = "クリア";
            btnClearImage.UseVisualStyleBackColor = true;
            btnClearImage.Click += btnClearImage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 165);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 1;
            label4.Text = "正則化画像フォルダ";
            // 
            // tbxRegImage
            // 
            tbxRegImage.Location = new Point(292, 162);
            tbxRegImage.Name = "tbxRegImage";
            tbxRegImage.Size = new Size(402, 23);
            tbxRegImage.TabIndex = 2;
            // 
            // btnSelectRegImage
            // 
            btnSelectRegImage.Location = new Point(130, 158);
            btnSelectRegImage.Name = "btnSelectRegImage";
            btnSelectRegImage.Size = new Size(75, 29);
            btnSelectRegImage.TabIndex = 3;
            btnSelectRegImage.Text = "選択";
            btnSelectRegImage.UseVisualStyleBackColor = true;
            btnSelectRegImage.Click += btnSelectRegImage_Click;
            // 
            // btnClearRegImage
            // 
            btnClearRegImage.Location = new Point(211, 158);
            btnClearRegImage.Name = "btnClearRegImage";
            btnClearRegImage.Size = new Size(75, 29);
            btnClearRegImage.TabIndex = 3;
            btnClearRegImage.Text = "クリア";
            btnClearRegImage.UseVisualStyleBackColor = true;
            btnClearRegImage.Click += btnClearRegImage_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 200);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 1;
            label5.Text = "出力先";
            // 
            // tbxOutput
            // 
            tbxOutput.Location = new Point(292, 197);
            tbxOutput.Name = "tbxOutput";
            tbxOutput.Size = new Size(402, 23);
            tbxOutput.TabIndex = 2;
            // 
            // btnSelectOutput
            // 
            btnSelectOutput.Location = new Point(130, 193);
            btnSelectOutput.Name = "btnSelectOutput";
            btnSelectOutput.Size = new Size(75, 29);
            btnSelectOutput.TabIndex = 3;
            btnSelectOutput.Text = "選択";
            btnSelectOutput.UseVisualStyleBackColor = true;
            btnSelectOutput.Click += btnSelectOutput_Click;
            // 
            // btnClearOutput
            // 
            btnClearOutput.Location = new Point(211, 193);
            btnClearOutput.Name = "btnClearOutput";
            btnClearOutput.Size = new Size(75, 29);
            btnClearOutput.TabIndex = 3;
            btnClearOutput.Text = "クリア";
            btnClearOutput.UseVisualStyleBackColor = true;
            btnClearOutput.Click += btnClearOutput_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 235);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 1;
            label6.Text = "プリセット";
            // 
            // tbxPreset
            // 
            tbxPreset.Location = new Point(292, 232);
            tbxPreset.Name = "tbxPreset";
            tbxPreset.Size = new Size(402, 23);
            tbxPreset.TabIndex = 2;
            // 
            // btnSelectPreset
            // 
            btnSelectPreset.Location = new Point(130, 228);
            btnSelectPreset.Name = "btnSelectPreset";
            btnSelectPreset.Size = new Size(75, 29);
            btnSelectPreset.TabIndex = 3;
            btnSelectPreset.Text = "選択";
            btnSelectPreset.UseVisualStyleBackColor = true;
            btnSelectPreset.Click += btnSelectPreset_Click;
            // 
            // btnClearPreset
            // 
            btnClearPreset.Location = new Point(211, 228);
            btnClearPreset.Name = "btnClearPreset";
            btnClearPreset.Size = new Size(75, 29);
            btnClearPreset.TabIndex = 3;
            btnClearPreset.Text = "クリア";
            btnClearPreset.UseVisualStyleBackColor = true;
            btnClearPreset.Click += btnClearPreset_Click;
            // 
            // btnDiscardAndClose
            // 
            btnDiscardAndClose.Location = new Point(398, 376);
            btnDiscardAndClose.Name = "btnDiscardAndClose";
            btnDiscardAndClose.Size = new Size(144, 28);
            btnDiscardAndClose.TabIndex = 4;
            btnDiscardAndClose.Text = "設定を保存せず閉じる";
            btnDiscardAndClose.UseVisualStyleBackColor = true;
            btnDiscardAndClose.Click += btnDiscardAndClose_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 270);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 1;
            label7.Text = "VAE";
            // 
            // tbxVAE
            // 
            tbxVAE.Location = new Point(292, 267);
            tbxVAE.Name = "tbxVAE";
            tbxVAE.Size = new Size(402, 23);
            tbxVAE.TabIndex = 2;
            // 
            // btnSelectVAE
            // 
            btnSelectVAE.Location = new Point(130, 263);
            btnSelectVAE.Name = "btnSelectVAE";
            btnSelectVAE.Size = new Size(75, 29);
            btnSelectVAE.TabIndex = 3;
            btnSelectVAE.Text = "選択";
            btnSelectVAE.UseVisualStyleBackColor = true;
            btnSelectVAE.Click += btnSelectVAE_Click;
            // 
            // btnClearVAE
            // 
            btnClearVAE.Location = new Point(211, 263);
            btnClearVAE.Name = "btnClearVAE";
            btnClearVAE.Size = new Size(75, 29);
            btnClearVAE.TabIndex = 3;
            btnClearVAE.Text = "クリア";
            btnClearVAE.UseVisualStyleBackColor = true;
            btnClearVAE.Click += btnClearVAE_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 305);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 1;
            label8.Text = "Tensorboard";
            // 
            // tbxTensorboard
            // 
            tbxTensorboard.Location = new Point(292, 302);
            tbxTensorboard.Name = "tbxTensorboard";
            tbxTensorboard.Size = new Size(402, 23);
            tbxTensorboard.TabIndex = 2;
            // 
            // btnSelectTensorboard
            // 
            btnSelectTensorboard.Location = new Point(130, 298);
            btnSelectTensorboard.Name = "btnSelectTensorboard";
            btnSelectTensorboard.Size = new Size(75, 29);
            btnSelectTensorboard.TabIndex = 3;
            btnSelectTensorboard.Text = "選択";
            btnSelectTensorboard.UseVisualStyleBackColor = true;
            btnSelectTensorboard.Click += btnSelectTensorboard_Click;
            // 
            // btnClearTensorboard
            // 
            btnClearTensorboard.Location = new Point(211, 298);
            btnClearTensorboard.Name = "btnClearTensorboard";
            btnClearTensorboard.Size = new Size(75, 29);
            btnClearTensorboard.TabIndex = 3;
            btnClearTensorboard.Text = "クリア";
            btnClearTensorboard.UseVisualStyleBackColor = true;
            btnClearTensorboard.Click += btnClearTensorboard_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 340);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 1;
            label9.Text = "Dataset config";
            // 
            // tbxConfig
            // 
            tbxConfig.Location = new Point(292, 337);
            tbxConfig.Name = "tbxConfig";
            tbxConfig.Size = new Size(402, 23);
            tbxConfig.TabIndex = 2;
            // 
            // btnSelectConfig
            // 
            btnSelectConfig.Location = new Point(130, 333);
            btnSelectConfig.Name = "btnSelectConfig";
            btnSelectConfig.Size = new Size(75, 29);
            btnSelectConfig.TabIndex = 3;
            btnSelectConfig.Text = "選択";
            btnSelectConfig.UseVisualStyleBackColor = true;
            btnSelectConfig.Click += btnSelectConfig_Click;
            // 
            // btnClearConfig
            // 
            btnClearConfig.Location = new Point(211, 333);
            btnClearConfig.Name = "btnClearConfig";
            btnClearConfig.Size = new Size(75, 29);
            btnClearConfig.TabIndex = 3;
            btnClearConfig.Text = "クリア";
            btnClearConfig.UseVisualStyleBackColor = true;
            btnClearConfig.Click += btnClearConfig_Click;
            // 
            // btnApplyAndClose
            // 
            btnApplyAndClose.Location = new Point(561, 376);
            btnApplyAndClose.Name = "btnApplyAndClose";
            btnApplyAndClose.Size = new Size(133, 28);
            btnApplyAndClose.TabIndex = 4;
            btnApplyAndClose.Text = "設定を保存して閉じる";
            btnApplyAndClose.UseVisualStyleBackColor = true;
            btnApplyAndClose.Click += btnApplyAndClose_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 42);
            label10.Name = "label10";
            label10.Size = new Size(614, 30);
            label10.TabIndex = 5;
            label10.Text = "ファイルやディレクトリを指定する項目で、未指定や存在しないパスの場合に選択画面でデフォルトで開くディレクトリを選択できます。\r\nここの設定が空欄か存在しないパスの場合は無視されます。";
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 416);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnClearConfig);
            Controls.Add(btnApplyAndClose);
            Controls.Add(btnDiscardAndClose);
            Controls.Add(btnClearTensorboard);
            Controls.Add(btnSelectOutput);
            Controls.Add(tbxModel);
            Controls.Add(tbxOutput);
            Controls.Add(btnClearVAE);
            Controls.Add(tbxPreset);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(btnClearPreset);
            Controls.Add(tbxVAE);
            Controls.Add(btnSelectModel);
            Controls.Add(label9);
            Controls.Add(btnClearOutput);
            Controls.Add(btnSelectRegImage);
            Controls.Add(label4);
            Controls.Add(tbxTensorboard);
            Controls.Add(btnClearRegImage);
            Controls.Add(label7);
            Controls.Add(tbxImage);
            Controls.Add(tbxConfig);
            Controls.Add(btnClearImage);
            Controls.Add(btnSelectPreset);
            Controls.Add(label5);
            Controls.Add(tbxRegImage);
            Controls.Add(brnClearModel);
            Controls.Add(btnSelectVAE);
            Controls.Add(btnSelectImage);
            Controls.Add(label6);
            Controls.Add(btnSelectConfig);
            Controls.Add(btnSelectTensorboard);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSettings";
            Text = "設定";
            Load += FormSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxModel;
        private Button btnSelectModel;
        private Button brnClearModel;
        private Label label3;
        private TextBox tbxImage;
        private Button btnSelectImage;
        private Button btnClearImage;
        private Label label4;
        private TextBox tbxRegImage;
        private Button btnSelectRegImage;
        private Button btnClearRegImage;
        private Label label5;
        private TextBox tbxOutput;
        private Button btnSelectOutput;
        private Button btnClearOutput;
        private Label label6;
        private TextBox tbxPreset;
        private Button btnSelectPreset;
        private Button btnClearPreset;
        private Button btnDiscardAndClose;
        private Label label7;
        private TextBox tbxVAE;
        private Button btnSelectVAE;
        private Button btnClearVAE;
        private Label label8;
        private TextBox tbxTensorboard;
        private Button btnSelectTensorboard;
        private Button btnClearTensorboard;
        private Button btnClearConfig;
        private Button btnSelectConfig;
        private TextBox tbxConfig;
        private Label label9;
        private Button btnApplyAndClose;
        private Label label10;
    }
}
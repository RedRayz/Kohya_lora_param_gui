namespace Kohya_lora_trainer
{
    partial class FormUtils
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
            btnRunTensorboard = new Button();
            label3 = new Label();
            btnSelectModel = new Button();
            btnResizeDim = new Button();
            cbxCudaConversion = new CheckBox();
            lblLoraPath = new Label();
            lblOutputPath = new Label();
            nudTargetDim = new NumericUpDown();
            label2 = new Label();
            btnSelectOutputPath = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRegenVenv = new Button();
            label8 = new Label();
            tabPage2 = new TabPage();
            btnClearResizeOutput = new Button();
            label10 = new Label();
            tabPage3 = new TabPage();
            label4 = new Label();
            label1 = new Label();
            btnInstallExtension = new Button();
            btnUpdateRepo = new Button();
            tabPage4 = new TabPage();
            label5 = new Label();
            btnRunTagger = new Button();
            label9 = new Label();
            lblTaggerDir = new Label();
            btnTaggetSelectDir = new Button();
            label11 = new Label();
            label7 = new Label();
            nudThresh = new NumericUpDown();
            nudTaggerBatchSize = new NumericUpDown();
            label6 = new Label();
            tbxTaggerExclude = new TextBox();
            toolTip1 = new ToolTip(components);
            btnDeleteNpz = new Button();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudTargetDim).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudThresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTaggerBatchSize).BeginInit();
            SuspendLayout();
            // 
            // btnRunTensorboard
            // 
            btnRunTensorboard.Location = new Point(183, 29);
            btnRunTensorboard.Margin = new Padding(3, 4, 3, 4);
            btnRunTensorboard.Name = "btnRunTensorboard";
            btnRunTensorboard.Size = new Size(150, 35);
            btnRunTensorboard.TabIndex = 0;
            btnRunTensorboard.Text = "tensorboard起動";
            btnRunTensorboard.UseVisualStyleBackColor = true;
            btnRunTensorboard.Click += btnRunTensorboard_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 68);
            label3.Name = "label3";
            label3.Size = new Size(158, 15);
            label3.TabIndex = 1;
            label3.Text = "ターミナルは手動で閉じてください";
            // 
            // btnSelectModel
            // 
            btnSelectModel.Location = new Point(23, 18);
            btnSelectModel.Name = "btnSelectModel";
            btnSelectModel.Size = new Size(90, 32);
            btnSelectModel.TabIndex = 5;
            btnSelectModel.Text = "変換元の選択";
            btnSelectModel.UseVisualStyleBackColor = true;
            btnSelectModel.Click += btnSelectModel_Click;
            // 
            // btnResizeDim
            // 
            btnResizeDim.Location = new Point(23, 250);
            btnResizeDim.Name = "btnResizeDim";
            btnResizeDim.Size = new Size(90, 32);
            btnResizeDim.TabIndex = 5;
            btnResizeDim.Text = "変換";
            btnResizeDim.UseVisualStyleBackColor = true;
            btnResizeDim.Click += btnResizeDim_Click;
            // 
            // cbxCudaConversion
            // 
            cbxCudaConversion.AutoSize = true;
            cbxCudaConversion.Location = new Point(119, 175);
            cbxCudaConversion.Name = "cbxCudaConversion";
            cbxCudaConversion.Size = new Size(91, 19);
            cbxCudaConversion.TabIndex = 6;
            cbxCudaConversion.Text = "CUDAで変換";
            cbxCudaConversion.UseVisualStyleBackColor = true;
            // 
            // lblLoraPath
            // 
            lblLoraPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoraPath.Location = new Point(119, 18);
            lblLoraPath.Name = "lblLoraPath";
            lblLoraPath.Size = new Size(383, 37);
            lblLoraPath.TabIndex = 7;
            lblLoraPath.Text = "G:\\SD\\model\\lora\\longlongname\\aaaaa.safetensors";
            // 
            // lblOutputPath
            // 
            lblOutputPath.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutputPath.Location = new Point(119, 60);
            lblOutputPath.Name = "lblOutputPath";
            lblOutputPath.Size = new Size(383, 37);
            lblOutputPath.TabIndex = 7;
            lblOutputPath.Text = "G:\\SD\\model\\lora\\longlongname\\aaaaa.safetensors";
            // 
            // nudTargetDim
            // 
            nudTargetDim.Location = new Point(23, 174);
            nudTargetDim.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nudTargetDim.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTargetDim.Name = "nudTargetDim";
            nudTargetDim.Size = new Size(90, 23);
            nudTargetDim.TabIndex = 8;
            nudTargetDim.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 146);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "次元数";
            // 
            // btnSelectOutputPath
            // 
            btnSelectOutputPath.Location = new Point(23, 60);
            btnSelectOutputPath.Name = "btnSelectOutputPath";
            btnSelectOutputPath.Size = new Size(90, 32);
            btnSelectOutputPath.TabIndex = 10;
            btnSelectOutputPath.Text = "出力先の選択";
            btnSelectOutputPath.UseVisualStyleBackColor = true;
            btnSelectOutputPath.Click += btnSelectOutputPath_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(533, 347);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(btnDeleteNpz);
            tabPage1.Controls.Add(btnRegenVenv);
            tabPage1.Controls.Add(btnRunTensorboard);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(525, 319);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ユーティリティ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegenVenv
            // 
            btnRegenVenv.Location = new Point(183, 112);
            btnRegenVenv.Name = "btnRegenVenv";
            btnRegenVenv.Size = new Size(150, 35);
            btnRegenVenv.TabIndex = 2;
            btnRegenVenv.Text = "venv再生成";
            btnRegenVenv.UseVisualStyleBackColor = true;
            btnRegenVenv.Click += btnRegenVenv_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(103, 150);
            label8.Name = "label8";
            label8.Size = new Size(315, 30);
            label8.TabIndex = 1;
            label8.Text = "ターミナルは手動で閉じてください\r\nvnevがない場合に再生成し、必要なパッケージをインストールします";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnClearResizeOutput);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(btnSelectModel);
            tabPage2.Controls.Add(btnSelectOutputPath);
            tabPage2.Controls.Add(btnResizeDim);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(cbxCudaConversion);
            tabPage2.Controls.Add(nudTargetDim);
            tabPage2.Controls.Add(lblLoraPath);
            tabPage2.Controls.Add(lblOutputPath);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(525, 317);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dimリサイズ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearResizeOutput
            // 
            btnClearResizeOutput.Location = new Point(23, 98);
            btnClearResizeOutput.Name = "btnClearResizeOutput";
            btnClearResizeOutput.Size = new Size(90, 32);
            btnClearResizeOutput.TabIndex = 12;
            btnClearResizeOutput.Text = "クリア";
            btnClearResizeOutput.UseVisualStyleBackColor = true;
            btnClearResizeOutput.Click += btnClearResizeOutput_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(119, 107);
            label10.Name = "label10";
            label10.Size = new Size(273, 15);
            label10.TabIndex = 11;
            label10.Text = "注意:出力先が未指定の場合は変換元を上書きします。";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(btnInstallExtension);
            tabPage3.Controls.Add(btnUpdateRepo);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(525, 317);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "更新";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 99);
            label4.Name = "label4";
            label4.Size = new Size(255, 15);
            label4.TabIndex = 3;
            label4.Text = "リポジトリと必須のpythonパッケージの更新をします。";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 210);
            label1.Name = "label1";
            label1.Size = new Size(174, 30);
            label1.TabIndex = 2;
            label1.Text = "lycorisおよび追加のオプティマイザを\r\nインストールまたは更新をします。";
            // 
            // btnInstallExtension
            // 
            btnInstallExtension.Location = new Point(188, 163);
            btnInstallExtension.Name = "btnInstallExtension";
            btnInstallExtension.Size = new Size(169, 35);
            btnInstallExtension.TabIndex = 1;
            btnInstallExtension.Text = "拡張機能のインストール・更新";
            btnInstallExtension.UseVisualStyleBackColor = true;
            btnInstallExtension.Click += btnInstallExtension_Click;
            // 
            // btnUpdateRepo
            // 
            btnUpdateRepo.Location = new Point(188, 61);
            btnUpdateRepo.Name = "btnUpdateRepo";
            btnUpdateRepo.Size = new Size(169, 35);
            btnUpdateRepo.TabIndex = 0;
            btnUpdateRepo.Text = "sd-scriptsのアップデート";
            btnUpdateRepo.UseVisualStyleBackColor = true;
            btnUpdateRepo.Click += btnUpdateRepo_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(btnRunTagger);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(lblTaggerDir);
            tabPage4.Controls.Add(btnTaggetSelectDir);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(nudThresh);
            tabPage4.Controls.Add(nudTaggerBatchSize);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(tbxTaggerExclude);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(525, 317);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Tagger";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 14);
            label5.Name = "label5";
            label5.Size = new Size(378, 45);
            label5.TabIndex = 8;
            label5.Text = "AIを用いてDanbooruタグを推論します。\r\nsd-scriptsのTaggerは簡易的なものとなります。\r\n細かい設定をしたい方はAUTOMATIC1111 WebUIのTaggerをご利用ください。";
            // 
            // btnRunTagger
            // 
            btnRunTagger.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRunTagger.Location = new Point(411, 269);
            btnRunTagger.Name = "btnRunTagger";
            btnRunTagger.Size = new Size(98, 32);
            btnRunTagger.TabIndex = 7;
            btnRunTagger.Text = "推論開始";
            btnRunTagger.UseVisualStyleBackColor = true;
            btnRunTagger.Click += btnRunTagger_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 85);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 6;
            label9.Text = "ディレクトリ";
            // 
            // lblTaggerDir
            // 
            lblTaggerDir.Font = new Font("Yu Gothic UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTaggerDir.Location = new Point(110, 113);
            lblTaggerDir.Name = "lblTaggerDir";
            lblTaggerDir.Size = new Size(399, 31);
            lblTaggerDir.TabIndex = 6;
            lblTaggerDir.Text = "選択してください";
            // 
            // btnTaggetSelectDir
            // 
            btnTaggetSelectDir.Location = new Point(26, 113);
            btnTaggetSelectDir.Name = "btnTaggetSelectDir";
            btnTaggetSelectDir.Size = new Size(78, 27);
            btnTaggetSelectDir.TabIndex = 5;
            btnTaggetSelectDir.Text = "選択";
            btnTaggetSelectDir.UseVisualStyleBackColor = true;
            btnTaggetSelectDir.Click += btnTaggetSelectDir_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(129, 209);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 4;
            label11.Text = "タグ検出の閾値";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 209);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 4;
            label7.Text = "Batch size";
            // 
            // nudThresh
            // 
            nudThresh.DecimalPlaces = 2;
            nudThresh.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudThresh.Location = new Point(134, 227);
            nudThresh.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudThresh.Name = "nudThresh";
            nudThresh.Size = new Size(78, 23);
            nudThresh.TabIndex = 3;
            nudThresh.Value = new decimal(new int[] { 35, 0, 0, 131072 });
            // 
            // nudTaggerBatchSize
            // 
            nudTaggerBatchSize.Location = new Point(26, 227);
            nudTaggerBatchSize.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            nudTaggerBatchSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTaggerBatchSize.Name = "nudTaggerBatchSize";
            nudTaggerBatchSize.Size = new Size(78, 23);
            nudTaggerBatchSize.TabIndex = 3;
            nudTaggerBatchSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 153);
            label6.Name = "label6";
            label6.Size = new Size(221, 15);
            label6.TabIndex = 2;
            label6.Text = "除外タグ(アンダースコア込み)、複数指定不可";
            // 
            // tbxTaggerExclude
            // 
            tbxTaggerExclude.Location = new Point(26, 171);
            tbxTaggerExclude.Name = "tbxTaggerExclude";
            tbxTaggerExclude.Size = new Size(432, 23);
            tbxTaggerExclude.TabIndex = 1;
            // 
            // btnDeleteNpz
            // 
            btnDeleteNpz.Location = new Point(183, 199);
            btnDeleteNpz.Name = "btnDeleteNpz";
            btnDeleteNpz.Size = new Size(150, 35);
            btnDeleteNpz.TabIndex = 3;
            btnDeleteNpz.Text = ".npzの消去";
            btnDeleteNpz.UseVisualStyleBackColor = true;
            btnDeleteNpz.Click += btnDeleteNpz_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(135, 237);
            label12.Name = "label12";
            label12.Size = new Size(253, 15);
            label12.TabIndex = 4;
            label12.Text = "latentやte_outputのキャッシュファイルを消去します。";
            // 
            // FormUtils
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(557, 382);
            Controls.Add(tabControl1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUtils";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Utils";
            Load += FormUtils_Load;
            ((System.ComponentModel.ISupportInitialize)nudTargetDim).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudThresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTaggerBatchSize).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRunTensorboard;
        private Label label3;
        private Button btnSelectModel;
        private Button btnResizeDim;
        private CheckBox cbxCudaConversion;
        private Label lblLoraPath;
        private Label lblOutputPath;
        private NumericUpDown nudTargetDim;
        private Label label2;
        private Button btnSelectOutputPath;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnUpdateRepo;
        private Label label1;
        private Button btnInstallExtension;
        private Label label4;
        private TabPage tabPage4;
        private Button btnRunTagger;
        private Label label9;
        private Label lblTaggerDir;
        private Button btnTaggetSelectDir;
        private Label label7;
        private NumericUpDown nudTaggerBatchSize;
        private Label label6;
        private TextBox tbxTaggerExclude;
        private Label label11;
        private NumericUpDown nudThresh;
        private ToolTip toolTip1;
        private Label label5;
        private Button btnRegenVenv;
        private Label label8;
        private Button btnClearResizeOutput;
        private Label label10;
        private Label label12;
        private Button btnDeleteNpz;
    }
}
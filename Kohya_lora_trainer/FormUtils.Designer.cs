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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtils));
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
            cbxUseLatestTorch = new CheckBox();
            cbxPythonVersion = new ComboBox();
            label14 = new Label();
            cbxUsePy = new CheckBox();
            lblProcessingNpz = new Label();
            label12 = new Label();
            btnDeleteNpz = new Button();
            btnRegenVenv = new Button();
            label8 = new Label();
            tabPage2 = new TabPage();
            btnClearResizeOutput = new Button();
            label10 = new Label();
            label13 = new Label();
            numericUpDown1 = new NumericUpDown();
            tabPage3 = new TabPage();
            cbxUpdateOnlyPackage = new CheckBox();
            label4 = new Label();
            label1 = new Label();
            btnInstallExtension = new Button();
            btnUpdateRepo = new Button();
            tabPage4 = new TabPage();
            lblSwitching = new Label();
            label7 = new Label();
            label6 = new Label();
            btnSwitchBranch = new Button();
            label5 = new Label();
            tbxBranchName = new TextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)nudTargetDim).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // btnRunTensorboard
            // 
            btnRunTensorboard.Location = new Point(183, 7);
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
            label3.Location = new Point(183, 46);
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
            btnResizeDim.Location = new Point(23, 270);
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
            cbxCudaConversion.Location = new Point(119, 278);
            cbxCudaConversion.Name = "cbxCudaConversion";
            cbxCudaConversion.Size = new Size(91, 19);
            cbxCudaConversion.TabIndex = 6;
            cbxCudaConversion.Text = "CUDAで変換";
            cbxCudaConversion.UseVisualStyleBackColor = true;
            // 
            // lblLoraPath
            // 
            lblLoraPath.Font = new Font("Yu Gothic UI", 8F);
            lblLoraPath.Location = new Point(119, 18);
            lblLoraPath.Name = "lblLoraPath";
            lblLoraPath.Size = new Size(383, 37);
            lblLoraPath.TabIndex = 7;
            lblLoraPath.Text = "path";
            // 
            // lblOutputPath
            // 
            lblOutputPath.Font = new Font("Yu Gothic UI", 8F);
            lblOutputPath.Location = new Point(119, 60);
            lblOutputPath.Name = "lblOutputPath";
            lblOutputPath.Size = new Size(383, 37);
            lblOutputPath.TabIndex = 7;
            lblOutputPath.Text = "path";
            // 
            // nudTargetDim
            // 
            nudTargetDim.Location = new Point(23, 156);
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
            label2.Location = new Point(23, 138);
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
            tabControl1.Size = new Size(533, 429);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbxUseLatestTorch);
            tabPage1.Controls.Add(cbxPythonVersion);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(cbxUsePy);
            tabPage1.Controls.Add(lblProcessingNpz);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(btnDeleteNpz);
            tabPage1.Controls.Add(btnRegenVenv);
            tabPage1.Controls.Add(btnRunTensorboard);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(525, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ユーティリティ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbxUseLatestTorch
            // 
            cbxUseLatestTorch.AutoSize = true;
            cbxUseLatestTorch.Location = new Point(161, 123);
            cbxUseLatestTorch.Name = "cbxUseLatestTorch";
            cbxUseLatestTorch.Size = new Size(198, 19);
            cbxUseLatestTorch.TabIndex = 9;
            cbxUseLatestTorch.Text = "Torch 2.7(CUDA 12.8)をインストール";
            toolTip1.SetToolTip(cbxUseLatestTorch, "NVIDIA RTX 50シリーズ使用中ならチェックつける");
            cbxUseLatestTorch.UseVisualStyleBackColor = true;
            // 
            // cbxPythonVersion
            // 
            cbxPythonVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPythonVersion.FormattingEnabled = true;
            cbxPythonVersion.Items.AddRange(new object[] { "3.10", "3.11" });
            cbxPythonVersion.Location = new Point(260, 178);
            cbxPythonVersion.Name = "cbxPythonVersion";
            cbxPythonVersion.Size = new Size(103, 23);
            cbxPythonVersion.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(68, 181);
            label14.Name = "label14";
            label14.Size = new Size(186, 15);
            label14.TabIndex = 7;
            label14.Text = "Pythonバージョン(pyを使用する場合)";
            // 
            // cbxUsePy
            // 
            cbxUsePy.AutoSize = true;
            cbxUsePy.Location = new Point(161, 148);
            cbxUsePy.Name = "cbxUsePy";
            cbxUsePy.Size = new Size(202, 19);
            cbxUsePy.TabIndex = 6;
            cbxUsePy.Text = "「python」の代わりに「py」を使用する";
            toolTip1.SetToolTip(cbxUsePy, "ターミナルpythonとだけ表示されて何も起きないか\r\nPythonバージョンを指定する場合にチェックをつけてください\r\n");
            cbxUsePy.UseVisualStyleBackColor = true;
            cbxUsePy.CheckedChanged += cbxUsePy_CheckedChanged;
            // 
            // lblProcessingNpz
            // 
            lblProcessingNpz.AutoSize = true;
            lblProcessingNpz.Font = new Font("Yu Gothic UI", 10F);
            lblProcessingNpz.Location = new Point(339, 275);
            lblProcessingNpz.Name = "lblProcessingNpz";
            lblProcessingNpz.Size = new Size(61, 19);
            lblProcessingNpz.TabIndex = 5;
            lblProcessingNpz.Text = "処理中…";
            lblProcessingNpz.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(131, 305);
            label12.Name = "label12";
            label12.Size = new Size(253, 30);
            label12.TabIndex = 4;
            label12.Text = "latentやte_outputのキャッシュファイルを消去します。\r\nサブディレクトリ内のキャッシュも消去します。";
            // 
            // btnDeleteNpz
            // 
            btnDeleteNpz.Location = new Point(183, 267);
            btnDeleteNpz.Name = "btnDeleteNpz";
            btnDeleteNpz.Size = new Size(150, 35);
            btnDeleteNpz.TabIndex = 3;
            btnDeleteNpz.Text = ".npzの消去";
            btnDeleteNpz.UseVisualStyleBackColor = true;
            btnDeleteNpz.Click += btnDeleteNpz_Click;
            // 
            // btnRegenVenv
            // 
            btnRegenVenv.Location = new Point(183, 79);
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
            label8.Location = new Point(68, 204);
            label8.Name = "label8";
            label8.Size = new Size(388, 45);
            label8.TabIndex = 1;
            label8.Text = "ターミナルは手動で閉じてください\r\nvnevがない場合に再生成し、必要なパッケージのみをインストールします\r\nD-AdaptationやLyCORISなどはvenv生成後に更新タブでインストールしてください";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnClearResizeOutput);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(btnSelectModel);
            tabPage2.Controls.Add(btnSelectOutputPath);
            tabPage2.Controls.Add(btnResizeDim);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(cbxCudaConversion);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(nudTargetDim);
            tabPage2.Controls.Add(lblLoraPath);
            tabPage2.Controls.Add(lblOutputPath);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(525, 399);
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 191);
            label13.Name = "label13";
            label13.Size = new Size(234, 15);
            label13.TabIndex = 9;
            label13.Text = "畳み込み層(Conv)の次元数、0で未指定にする";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(23, 209);
            numericUpDown1.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(90, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cbxUpdateOnlyPackage);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(btnInstallExtension);
            tabPage3.Controls.Add(btnUpdateRepo);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(525, 399);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "更新";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbxUpdateOnlyPackage
            // 
            cbxUpdateOnlyPackage.AutoSize = true;
            cbxUpdateOnlyPackage.Location = new Point(188, 117);
            cbxUpdateOnlyPackage.Name = "cbxUpdateOnlyPackage";
            cbxUpdateOnlyPackage.Size = new Size(154, 19);
            cbxUpdateOnlyPackage.TabIndex = 4;
            cbxUpdateOnlyPackage.Text = "Pythonパッケージのみ更新";
            cbxUpdateOnlyPackage.UseVisualStyleBackColor = true;
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
            tabPage4.Controls.Add(lblSwitching);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(btnSwitchBranch);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(tbxBranchName);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(525, 399);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "ブランチ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblSwitching
            // 
            lblSwitching.AutoSize = true;
            lblSwitching.Location = new Point(91, 224);
            lblSwitching.Name = "lblSwitching";
            lblSwitching.Size = new Size(310, 15);
            lblSwitching.TabIndex = 5;
            lblSwitching.Text = "切り替え中です。終了メッセージが表示されるまでお待ちください。";
            lblSwitching.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 74);
            label7.Name = "label7";
            label7.Size = new Size(416, 105);
            label7.TabIndex = 4;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 20);
            label6.Name = "label6";
            label6.Size = new Size(188, 15);
            label6.TabIndex = 3;
            label6.Text = "sd-scriptsリポジトリのブランチ切り替え";
            // 
            // btnSwitchBranch
            // 
            btnSwitchBranch.Location = new Point(289, 48);
            btnSwitchBranch.Name = "btnSwitchBranch";
            btnSwitchBranch.Size = new Size(99, 23);
            btnSwitchBranch.TabIndex = 2;
            btnSwitchBranch.Text = "ブランチ切り替え";
            btnSwitchBranch.UseVisualStyleBackColor = true;
            btnSwitchBranch.Click += btnSwitchBranch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 51);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 1;
            label5.Text = "ブランチの名称";
            // 
            // tbxBranchName
            // 
            tbxBranchName.Location = new Point(128, 48);
            tbxBranchName.Name = "tbxBranchName";
            tbxBranchName.Size = new Size(155, 23);
            tbxBranchName.TabIndex = 0;
            // 
            // FormUtils
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(562, 481);
            Controls.Add(tabControl1);
            Font = new Font("Yu Gothic UI", 9F);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
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
        private ToolTip toolTip1;
        private Button btnRegenVenv;
        private Label label8;
        private Button btnClearResizeOutput;
        private Label label10;
        private Label label12;
        private Button btnDeleteNpz;
        private Label label13;
        private NumericUpDown numericUpDown1;
        private Label lblProcessingNpz;
        private CheckBox cbxUsePy;
        private ComboBox cbxPythonVersion;
        private Label label14;
        private CheckBox cbxUpdateOnlyPackage;
        private CheckBox cbxUseLatestTorch;
        private TabPage tabPage4;
        private Label label6;
        private Button btnSwitchBranch;
        private Label label5;
        private TextBox tbxBranchName;
        private Label label7;
        private Label lblSwitching;
    }
}
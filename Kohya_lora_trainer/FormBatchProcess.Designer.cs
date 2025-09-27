namespace Kohya_lora_trainer
{
    partial class FormBatchProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBatchProcess));
            tbxPrestList = new TextBox();
            label1 = new Label();
            btnDiscardChanges = new Button();
            btnApplyChanges = new Button();
            btnAddPreset = new Button();
            cbxGenerateLogText = new CheckBox();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label4 = new Label();
            nudKeepTokens = new NumericUpDown();
            label3 = new Label();
            cbxShuffleCaptionsBefore = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudKeepTokens).BeginInit();
            SuspendLayout();
            // 
            // tbxPrestList
            // 
            tbxPrestList.AllowDrop = true;
            tbxPrestList.Font = new Font("Yu Gothic UI", 8F);
            tbxPrestList.Location = new Point(8, 9);
            tbxPrestList.Margin = new Padding(2, 3, 2, 3);
            tbxPrestList.Multiline = true;
            tbxPrestList.Name = "tbxPrestList";
            tbxPrestList.ScrollBars = ScrollBars.Vertical;
            tbxPrestList.Size = new Size(386, 327);
            tbxPrestList.TabIndex = 0;
            tbxPrestList.DragDrop += tbxPrestList_DragDrop;
            tbxPrestList.DragEnter += tbxPrestList_DragEnter;
            // 
            // label1
            // 
            label1.Location = new Point(5, 3);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 182);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // btnDiscardChanges
            // 
            btnDiscardChanges.Location = new Point(476, 316);
            btnDiscardChanges.Margin = new Padding(2);
            btnDiscardChanges.Name = "btnDiscardChanges";
            btnDiscardChanges.Size = new Size(160, 28);
            btnDiscardChanges.TabIndex = 2;
            btnDiscardChanges.Text = "設定を反映せずに閉じる";
            btnDiscardChanges.UseVisualStyleBackColor = true;
            btnDiscardChanges.Click += btnDiscardChanges_Click;
            // 
            // btnApplyChanges
            // 
            btnApplyChanges.Location = new Point(476, 348);
            btnApplyChanges.Margin = new Padding(2);
            btnApplyChanges.Name = "btnApplyChanges";
            btnApplyChanges.Size = new Size(160, 28);
            btnApplyChanges.TabIndex = 2;
            btnApplyChanges.Text = "設定を反映して閉じる";
            btnApplyChanges.UseVisualStyleBackColor = true;
            btnApplyChanges.Click += btnApplyChanges_Click;
            // 
            // btnAddPreset
            // 
            btnAddPreset.Location = new Point(11, 348);
            btnAddPreset.Margin = new Padding(2);
            btnAddPreset.Name = "btnAddPreset";
            btnAddPreset.Size = new Size(109, 28);
            btnAddPreset.TabIndex = 3;
            btnAddPreset.Text = "プリセットの追加";
            btnAddPreset.UseVisualStyleBackColor = true;
            btnAddPreset.Click += btnAddPreset_Click;
            // 
            // cbxGenerateLogText
            // 
            cbxGenerateLogText.AutoSize = true;
            cbxGenerateLogText.Location = new Point(17, 16);
            cbxGenerateLogText.Margin = new Padding(2);
            cbxGenerateLogText.Name = "cbxGenerateLogText";
            cbxGenerateLogText.Size = new Size(158, 19);
            cbxGenerateLogText.TabIndex = 4;
            cbxGenerateLogText.Text = "終了時にレポートを出力する";
            cbxGenerateLogText.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 37);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(202, 45);
            label2.TabIndex = 5;
            label2.Text = "学習時間などを\r\nドキュメントフォルダーにbatchlog-日付.txt\r\nとして書き出します。";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(399, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(292, 303);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(284, 275);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "説明";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(nudKeepTokens);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cbxShuffleCaptionsBefore);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(cbxGenerateLogText);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(277, 273);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "オプション";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 234);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 7;
            label4.Text = "トークン保持数";
            // 
            // nudKeepTokens
            // 
            nudKeepTokens.Location = new Point(103, 232);
            nudKeepTokens.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudKeepTokens.Name = "nudKeepTokens";
            nudKeepTokens.Size = new Size(97, 23);
            nudKeepTokens.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 114);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(237, 105);
            label3.TabIndex = 5;
            label3.Text = "各プリセットの学習を開始する前に\r\nキャプションファイル内のタグを\r\nシャッフルします。\r\ncache_text_encoder_output使用時に\r\n有用な機能となります。\r\n学習パラメータ側でキャプションシャッフル有効時は\r\n機能しません。";
            // 
            // cbxShuffleCaptionsBefore
            // 
            cbxShuffleCaptionsBefore.AutoSize = true;
            cbxShuffleCaptionsBefore.Location = new Point(17, 93);
            cbxShuffleCaptionsBefore.Margin = new Padding(2);
            cbxShuffleCaptionsBefore.Name = "cbxShuffleCaptionsBefore";
            cbxShuffleCaptionsBefore.Size = new Size(212, 19);
            cbxShuffleCaptionsBefore.TabIndex = 4;
            cbxShuffleCaptionsBefore.Text = "学習開始直前にキャプションのシャッフル";
            cbxShuffleCaptionsBefore.UseVisualStyleBackColor = true;
            // 
            // FormBatchProcess
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(696, 387);
            Controls.Add(tabControl1);
            Controls.Add(btnAddPreset);
            Controls.Add(btnApplyChanges);
            Controls.Add(btnDiscardChanges);
            Controls.Add(tbxPrestList);
            Font = new Font("Yu Gothic UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "FormBatchProcess";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Batch Process";
            Load += FormBatchProcess_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudKeepTokens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxPrestList;
        private Label label1;
        private Button btnDiscardChanges;
        private Button btnApplyChanges;
        private Button btnAddPreset;
        private CheckBox cbxGenerateLogText;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private NumericUpDown nudKeepTokens;
        private Label label3;
        private CheckBox cbxShuffleCaptionsBefore;
    }
}
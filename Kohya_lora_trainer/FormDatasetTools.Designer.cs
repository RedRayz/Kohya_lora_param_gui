namespace Kohya_lora_trainer
{
    partial class FormDatasetTools
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            nudKeepTokens = new NumericUpDown();
            label4 = new Label();
            cbxUseRegEx = new CheckBox();
            btnRemoveImgWithTag = new Button();
            btnAddTag = new Button();
            btnShowTagCnt = new Button();
            btnRemoveTag = new Button();
            btnTagToHead = new Button();
            btnConvertToWD = new Button();
            btnShuffleCaptions = new Button();
            label3 = new Label();
            label2 = new Label();
            tbxBooruTag = new TextBox();
            tbxTargetDir = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            label8 = new Label();
            label7 = new Label();
            nudTagsCount = new NumericUpDown();
            nudNumRemoveRandomly = new NumericUpDown();
            nudPixels = new NumericUpDown();
            nudFileSize = new NumericUpDown();
            cbxDeleteImmediately = new CheckBox();
            btnRemoveCapNoImg = new Button();
            btnRemoveLessTags = new Button();
            btnRemoveRandomly = new Button();
            btnRemoveImgLessPixels = new Button();
            btnRemoveImgLessSize = new Button();
            btnDeleteTrash = new Button();
            btnRemoveImgNoCap = new Button();
            btnRemoveDupNameImg = new Button();
            tbxSourceDir = new TextBox();
            label6 = new Label();
            lblProcessing = new Label();
            btnCloseWindow = new Button();
            label9 = new Label();
            btnRemoveGifs = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudKeepTokens).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTagsCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumRemoveRandomly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPixels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFileSize).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(670, 462);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(nudKeepTokens);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(cbxUseRegEx);
            tabPage1.Controls.Add(btnRemoveImgWithTag);
            tabPage1.Controls.Add(btnAddTag);
            tabPage1.Controls.Add(btnShowTagCnt);
            tabPage1.Controls.Add(btnRemoveTag);
            tabPage1.Controls.Add(btnTagToHead);
            tabPage1.Controls.Add(btnConvertToWD);
            tabPage1.Controls.Add(btnShuffleCaptions);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(tbxBooruTag);
            tabPage1.Controls.Add(tbxTargetDir);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(662, 434);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "キャプション";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 149);
            label5.Name = "label5";
            label5.Size = new Size(175, 45);
            label5.TabIndex = 10;
            label5.Text = "注意:処理が遅くなります。\r\nまた、正規表現の検索に20ms以上\r\nかかるとスキップします。";
            // 
            // nudKeepTokens
            // 
            nudKeepTokens.Location = new Point(257, 65);
            nudKeepTokens.Name = "nudKeepTokens";
            nudKeepTokens.Size = new Size(72, 23);
            nudKeepTokens.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 70);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 8;
            label4.Text = "トークン保持数";
            // 
            // cbxUseRegEx
            // 
            cbxUseRegEx.AutoSize = true;
            cbxUseRegEx.Location = new Point(482, 127);
            cbxUseRegEx.Name = "cbxUseRegEx";
            cbxUseRegEx.Size = new Size(103, 19);
            cbxUseRegEx.TabIndex = 7;
            cbxUseRegEx.Text = "正規表現を使う";
            cbxUseRegEx.UseVisualStyleBackColor = true;
            cbxUseRegEx.CheckedChanged += cbxUseRegEx_CheckedChanged;
            // 
            // btnRemoveImgWithTag
            // 
            btnRemoveImgWithTag.Location = new Point(176, 154);
            btnRemoveImgWithTag.Name = "btnRemoveImgWithTag";
            btnRemoveImgWithTag.Size = new Size(153, 28);
            btnRemoveImgWithTag.TabIndex = 6;
            btnRemoveImgWithTag.Text = "指定タグがある画像を削除";
            btnRemoveImgWithTag.UseVisualStyleBackColor = true;
            btnRemoveImgWithTag.Click += btnRemoveImgWithTag_Click;
            // 
            // btnAddTag
            // 
            btnAddTag.Location = new Point(27, 222);
            btnAddTag.Name = "btnAddTag";
            btnAddTag.Size = new Size(143, 28);
            btnAddTag.TabIndex = 6;
            btnAddTag.Text = "指定タグを追加";
            btnAddTag.UseVisualStyleBackColor = true;
            btnAddTag.Click += btnAddTag_Click;
            // 
            // btnShowTagCnt
            // 
            btnShowTagCnt.Location = new Point(176, 188);
            btnShowTagCnt.Name = "btnShowTagCnt";
            btnShowTagCnt.Size = new Size(153, 28);
            btnShowTagCnt.TabIndex = 6;
            btnShowTagCnt.Text = "指定タグの出現回数を表示";
            btnShowTagCnt.UseVisualStyleBackColor = true;
            btnShowTagCnt.Click += btnShowTagCnt_Click;
            // 
            // btnRemoveTag
            // 
            btnRemoveTag.Location = new Point(27, 188);
            btnRemoveTag.Name = "btnRemoveTag";
            btnRemoveTag.Size = new Size(143, 28);
            btnRemoveTag.TabIndex = 6;
            btnRemoveTag.Text = "指定タグを削除";
            btnRemoveTag.UseVisualStyleBackColor = true;
            btnRemoveTag.Click += btnRemoveTag_Click;
            // 
            // btnTagToHead
            // 
            btnTagToHead.Location = new Point(27, 154);
            btnTagToHead.Name = "btnTagToHead";
            btnTagToHead.Size = new Size(143, 28);
            btnTagToHead.TabIndex = 6;
            btnTagToHead.Text = "指定タグを先頭へ";
            btnTagToHead.UseVisualStyleBackColor = true;
            btnTagToHead.Click += btnTagToHead_Click;
            // 
            // btnConvertToWD
            // 
            btnConvertToWD.Location = new Point(352, 63);
            btnConvertToWD.Name = "btnConvertToWD";
            btnConvertToWD.Size = new Size(111, 28);
            btnConvertToWD.TabIndex = 6;
            btnConvertToWD.Text = "WD式に変換";
            btnConvertToWD.UseVisualStyleBackColor = true;
            btnConvertToWD.Click += btnConvertToWD_Click;
            // 
            // btnShuffleCaptions
            // 
            btnShuffleCaptions.Location = new Point(26, 65);
            btnShuffleCaptions.Name = "btnShuffleCaptions";
            btnShuffleCaptions.Size = new Size(143, 28);
            btnShuffleCaptions.TabIndex = 6;
            btnShuffleCaptions.Text = "キャプションのシャッフル";
            btnShuffleCaptions.UseVisualStyleBackColor = true;
            btnShuffleCaptions.Click += btnShuffleCaptions_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 107);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 5;
            label3.Text = "タグ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 18);
            label2.Name = "label2";
            label2.Size = new Size(446, 15);
            label2.TabIndex = 4;
            label2.Text = "ソースディレクトリ(画像とキャプション/タグが入った場所)、直接入力かフォルダをドロップして指定";
            // 
            // tbxBooruTag
            // 
            tbxBooruTag.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxBooruTag.Location = new Point(27, 125);
            tbxBooruTag.Name = "tbxBooruTag";
            tbxBooruTag.Size = new Size(449, 22);
            tbxBooruTag.TabIndex = 3;
            // 
            // tbxTargetDir
            // 
            tbxTargetDir.AllowDrop = true;
            tbxTargetDir.Location = new Point(27, 36);
            tbxTargetDir.Name = "tbxTargetDir";
            tbxTargetDir.Size = new Size(507, 23);
            tbxTargetDir.TabIndex = 2;
            tbxTargetDir.DragDrop += tbxTargetDir_DragDrop;
            tbxTargetDir.DragEnter += tbxTargetDir_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 265);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "正規表現サンプル";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(22, 286);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(609, 128);
            textBox1.TabIndex = 0;
            textBox1.Text = "人数タグ\r\n^.\\+?(boy|girl|other)s?\r\n日本人特有のユーザー名(例:)「name (nanashi1234)」\r\n.*\\d{3,}\r\n中国人特有のユーザー名(例:)「name (123456)」\r\n.* \\(\\d{4,}\\)\r\nユーザー名らしきもの(例:)「username (hogehoge00)」\r\n.* \\(.*\\d{2,}\\)\r\nuser XXXX\r\nuser .*";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRemoveGifs);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(nudTagsCount);
            tabPage2.Controls.Add(nudNumRemoveRandomly);
            tabPage2.Controls.Add(nudPixels);
            tabPage2.Controls.Add(nudFileSize);
            tabPage2.Controls.Add(cbxDeleteImmediately);
            tabPage2.Controls.Add(btnRemoveCapNoImg);
            tabPage2.Controls.Add(btnRemoveLessTags);
            tabPage2.Controls.Add(btnRemoveRandomly);
            tabPage2.Controls.Add(btnRemoveImgLessPixels);
            tabPage2.Controls.Add(btnRemoveImgLessSize);
            tabPage2.Controls.Add(btnDeleteTrash);
            tabPage2.Controls.Add(btnRemoveImgNoCap);
            tabPage2.Controls.Add(btnRemoveDupNameImg);
            tabPage2.Controls.Add(tbxSourceDir);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(662, 434);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ファイル処理";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(376, 282);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 5;
            label8.Text = "枚";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 214);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 5;
            label7.Text = "KB";
            // 
            // nudTagsCount
            // 
            nudTagsCount.Location = new Point(248, 314);
            nudTagsCount.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudTagsCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTagsCount.Name = "nudTagsCount";
            nudTagsCount.Size = new Size(120, 23);
            nudTagsCount.TabIndex = 4;
            nudTagsCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nudNumRemoveRandomly
            // 
            nudNumRemoveRandomly.Location = new Point(248, 280);
            nudNumRemoveRandomly.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudNumRemoveRandomly.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumRemoveRandomly.Name = "nudNumRemoveRandomly";
            nudNumRemoveRandomly.Size = new Size(120, 23);
            nudNumRemoveRandomly.TabIndex = 4;
            nudNumRemoveRandomly.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudPixels
            // 
            nudPixels.Location = new Point(248, 246);
            nudPixels.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudPixels.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPixels.Name = "nudPixels";
            nudPixels.Size = new Size(120, 23);
            nudPixels.TabIndex = 4;
            nudPixels.Value = new decimal(new int[] { 1048576, 0, 0, 0 });
            // 
            // nudFileSize
            // 
            nudFileSize.Location = new Point(248, 212);
            nudFileSize.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudFileSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudFileSize.Name = "nudFileSize";
            nudFileSize.Size = new Size(120, 23);
            nudFileSize.TabIndex = 4;
            nudFileSize.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // cbxDeleteImmediately
            // 
            cbxDeleteImmediately.AutoSize = true;
            cbxDeleteImmediately.Location = new Point(374, 95);
            cbxDeleteImmediately.Name = "cbxDeleteImmediately";
            cbxDeleteImmediately.Size = new Size(74, 19);
            cbxDeleteImmediately.TabIndex = 3;
            cbxDeleteImmediately.Text = "即時消去";
            cbxDeleteImmediately.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCapNoImg
            // 
            btnRemoveCapNoImg.Location = new Point(188, 123);
            btnRemoveCapNoImg.Name = "btnRemoveCapNoImg";
            btnRemoveCapNoImg.Size = new Size(180, 28);
            btnRemoveCapNoImg.TabIndex = 2;
            btnRemoveCapNoImg.Text = "キャプションがない画像を削除";
            btnRemoveCapNoImg.UseVisualStyleBackColor = true;
            btnRemoveCapNoImg.Click += btnRemoveCapNoImg_Click;
            // 
            // btnRemoveLessTags
            // 
            btnRemoveLessTags.Location = new Point(30, 314);
            btnRemoveLessTags.Name = "btnRemoveLessTags";
            btnRemoveLessTags.Size = new Size(212, 28);
            btnRemoveLessTags.TabIndex = 2;
            btnRemoveLessTags.Text = "タグ数が閾値以下の画像を削除";
            btnRemoveLessTags.UseVisualStyleBackColor = true;
            btnRemoveLessTags.Click += btnRemoveLessTags_Click;
            // 
            // btnRemoveRandomly
            // 
            btnRemoveRandomly.Location = new Point(30, 280);
            btnRemoveRandomly.Name = "btnRemoveRandomly";
            btnRemoveRandomly.Size = new Size(212, 28);
            btnRemoveRandomly.TabIndex = 2;
            btnRemoveRandomly.Text = "ランダムに削除";
            btnRemoveRandomly.UseVisualStyleBackColor = true;
            btnRemoveRandomly.Click += btnRemoveRandomly_Click;
            // 
            // btnRemoveImgLessPixels
            // 
            btnRemoveImgLessPixels.Location = new Point(30, 246);
            btnRemoveImgLessPixels.Name = "btnRemoveImgLessPixels";
            btnRemoveImgLessPixels.Size = new Size(212, 28);
            btnRemoveImgLessPixels.TabIndex = 2;
            btnRemoveImgLessPixels.Text = "指定未満の画素数の画像を削除";
            btnRemoveImgLessPixels.UseVisualStyleBackColor = true;
            btnRemoveImgLessPixels.Click += btnRemoveImgLessPixels_Click;
            // 
            // btnRemoveImgLessSize
            // 
            btnRemoveImgLessSize.Location = new Point(30, 212);
            btnRemoveImgLessSize.Name = "btnRemoveImgLessSize";
            btnRemoveImgLessSize.Size = new Size(212, 28);
            btnRemoveImgLessSize.TabIndex = 2;
            btnRemoveImgLessSize.Text = "指定未満のファイルサイズの画像を削除";
            btnRemoveImgLessSize.UseVisualStyleBackColor = true;
            btnRemoveImgLessSize.Click += btnRemoveImgLessSize_Click;
            // 
            // btnDeleteTrash
            // 
            btnDeleteTrash.Location = new Point(30, 123);
            btnDeleteTrash.Name = "btnDeleteTrash";
            btnDeleteTrash.Size = new Size(152, 28);
            btnDeleteTrash.TabIndex = 2;
            btnDeleteTrash.Text = "trashを消去";
            btnDeleteTrash.UseVisualStyleBackColor = true;
            btnDeleteTrash.Click += btnDeleteTrash_Click;
            // 
            // btnRemoveImgNoCap
            // 
            btnRemoveImgNoCap.Location = new Point(188, 89);
            btnRemoveImgNoCap.Name = "btnRemoveImgNoCap";
            btnRemoveImgNoCap.Size = new Size(180, 28);
            btnRemoveImgNoCap.TabIndex = 2;
            btnRemoveImgNoCap.Text = "画像がないキャプションを削除";
            btnRemoveImgNoCap.UseVisualStyleBackColor = true;
            btnRemoveImgNoCap.Click += btnRemoveImgNoCap_Click;
            // 
            // btnRemoveDupNameImg
            // 
            btnRemoveDupNameImg.Location = new Point(30, 89);
            btnRemoveDupNameImg.Name = "btnRemoveDupNameImg";
            btnRemoveDupNameImg.Size = new Size(152, 28);
            btnRemoveDupNameImg.TabIndex = 2;
            btnRemoveDupNameImg.Text = "名前が重複した画像を削除";
            btnRemoveDupNameImg.UseVisualStyleBackColor = true;
            btnRemoveDupNameImg.Click += btnRemoveDupNameImg_Click;
            // 
            // tbxSourceDir
            // 
            tbxSourceDir.AllowDrop = true;
            tbxSourceDir.Location = new Point(30, 60);
            tbxSourceDir.Name = "tbxSourceDir";
            tbxSourceDir.Size = new Size(457, 23);
            tbxSourceDir.TabIndex = 1;
            tbxSourceDir.DragDrop += tbxSourceDir_DragDrop;
            tbxSourceDir.DragEnter += tbxSourceDir_DragEnter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 42);
            label6.Name = "label6";
            label6.Size = new Size(446, 15);
            label6.TabIndex = 0;
            label6.Text = "ソースディレクトリ(画像とキャプション/タグが入った場所)、直接入力かフォルダをドロップして指定";
            // 
            // lblProcessing
            // 
            lblProcessing.AutoSize = true;
            lblProcessing.Font = new Font("Yu Gothic UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProcessing.Location = new Point(202, 477);
            lblProcessing.Name = "lblProcessing";
            lblProcessing.Size = new Size(290, 25);
            lblProcessing.TabIndex = 1;
            lblProcessing.Text = "処理中です。しばらくお待ちください。";
            // 
            // btnCloseWindow
            // 
            btnCloseWindow.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCloseWindow.Location = new Point(589, 476);
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.Size = new Size(89, 31);
            btnCloseWindow.TabIndex = 2;
            btnCloseWindow.Text = "閉じる";
            btnCloseWindow.UseVisualStyleBackColor = true;
            btnCloseWindow.Click += btnCloseWindow_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 476);
            label9.Name = "label9";
            label9.Size = new Size(161, 30);
            label9.TabIndex = 6;
            label9.Text = "対応画像拡張子:png,jpg,jpeg\r\n対応キャプション拡張子:txt";
            // 
            // btnRemoveGifs
            // 
            btnRemoveGifs.Location = new Point(30, 157);
            btnRemoveGifs.Name = "btnRemoveGifs";
            btnRemoveGifs.Size = new Size(152, 28);
            btnRemoveGifs.TabIndex = 6;
            btnRemoveGifs.Text = "GIF画像を削除";
            btnRemoveGifs.UseVisualStyleBackColor = true;
            btnRemoveGifs.Click += btnRemoveGifs_Click;
            // 
            // FormDatasetTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 515);
            Controls.Add(label9);
            Controls.Add(btnCloseWindow);
            Controls.Add(lblProcessing);
            Controls.Add(tabControl1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDatasetTools";
            StartPosition = FormStartPosition.CenterParent;
            Text = "データセット一括編集/選別ツール";
            Load += FormDatasetTools_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudKeepTokens).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTagsCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumRemoveRandomly).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPixels).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFileSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnRemoveImgWithTag;
        private Button btnAddTag;
        private Button btnShowTagCnt;
        private Button btnRemoveTag;
        private Button btnTagToHead;
        private Button btnConvertToWD;
        private Button btnShuffleCaptions;
        private Label label3;
        private Label label2;
        private TextBox tbxBooruTag;
        private TextBox tbxTargetDir;
        private Label label1;
        private TextBox textBox1;
        private CheckBox cbxUseRegEx;
        private NumericUpDown nudKeepTokens;
        private Label label4;
        private Label label5;
        private Button btnRemoveCapNoImg;
        private Button btnRemoveLessTags;
        private Button btnRemoveRandomly;
        private Button btnRemoveImgLessPixels;
        private Button btnRemoveImgLessSize;
        private Button btnDeleteTrash;
        private Button btnRemoveImgNoCap;
        private Button btnRemoveDupNameImg;
        private TextBox tbxSourceDir;
        private Label label6;
        private CheckBox cbxDeleteImmediately;
        private NumericUpDown nudTagsCount;
        private NumericUpDown nudNumRemoveRandomly;
        private NumericUpDown nudPixels;
        private NumericUpDown nudFileSize;
        private Label label8;
        private Label label7;
        private Label lblProcessing;
        private Button btnCloseWindow;
        private Label label9;
        private Button btnRemoveGifs;
    }
}
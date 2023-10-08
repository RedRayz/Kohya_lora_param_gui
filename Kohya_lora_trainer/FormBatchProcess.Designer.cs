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
            tbxPrestList = new TextBox();
            label1 = new Label();
            btnDiscardChanges = new Button();
            btnApplyChanges = new Button();
            btnAddPreset = new Button();
            cbxGenerateLogText = new CheckBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbxPrestList
            // 
            tbxPrestList.Location = new Point(8, 9);
            tbxPrestList.Margin = new Padding(2, 3, 2, 3);
            tbxPrestList.Multiline = true;
            tbxPrestList.Name = "tbxPrestList";
            tbxPrestList.Size = new Size(534, 490);
            tbxPrestList.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(564, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(415, 273);
            label1.TabIndex = 1;
            label1.Text = "バッチ処理\r\n入力したプリセットを基に順番に学習します。\r\n★使用方法\r\n左のテキストボックスに1行ごとにプリセットファイルのパスを入力します。\r\nプリセットを追加する場合は改行してから入力します。\r\n空欄にするとバッチ処理を行いません。\r\n★注意\r\nプリセットが見つからないか無効な場合は無視されます。\r\nバッチ処理時は「経過時間の表示」は無視されます。";
            // 
            // btnDiscardChanges
            // 
            btnDiscardChanges.Location = new Point(744, 471);
            btnDiscardChanges.Margin = new Padding(2);
            btnDiscardChanges.Name = "btnDiscardChanges";
            btnDiscardChanges.Size = new Size(226, 45);
            btnDiscardChanges.TabIndex = 2;
            btnDiscardChanges.Text = "設定を反映せずに閉じる";
            btnDiscardChanges.UseVisualStyleBackColor = true;
            btnDiscardChanges.Click += btnDiscardChanges_Click;
            // 
            // btnApplyChanges
            // 
            btnApplyChanges.Location = new Point(744, 520);
            btnApplyChanges.Margin = new Padding(2);
            btnApplyChanges.Name = "btnApplyChanges";
            btnApplyChanges.Size = new Size(226, 41);
            btnApplyChanges.TabIndex = 2;
            btnApplyChanges.Text = "設定を反映して閉じる";
            btnApplyChanges.UseVisualStyleBackColor = true;
            btnApplyChanges.Click += btnApplyChanges_Click;
            // 
            // btnAddPreset
            // 
            btnAddPreset.Location = new Point(8, 520);
            btnAddPreset.Margin = new Padding(2);
            btnAddPreset.Name = "btnAddPreset";
            btnAddPreset.Size = new Size(151, 41);
            btnAddPreset.TabIndex = 3;
            btnAddPreset.Text = "プリセットの追加";
            btnAddPreset.UseVisualStyleBackColor = true;
            btnAddPreset.Click += btnAddPreset_Click;
            // 
            // cbxGenerateLogText
            // 
            cbxGenerateLogText.AutoSize = true;
            cbxGenerateLogText.Location = new Point(564, 320);
            cbxGenerateLogText.Margin = new Padding(2);
            cbxGenerateLogText.Name = "cbxGenerateLogText";
            cbxGenerateLogText.Size = new Size(237, 29);
            cbxGenerateLogText.TabIndex = 4;
            cbxGenerateLogText.Text = "終了時にレポートを出力する";
            cbxGenerateLogText.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(564, 351);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(305, 75);
            label2.TabIndex = 5;
            label2.Text = "学習時間などを\r\nドキュメントフォルダーにbatchlog-日付.txt\r\nとして書き出します。";
            // 
            // FormBatchProcess
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(981, 572);
            Controls.Add(label2);
            Controls.Add(cbxGenerateLogText);
            Controls.Add(btnAddPreset);
            Controls.Add(btnApplyChanges);
            Controls.Add(btnDiscardChanges);
            Controls.Add(label1);
            Controls.Add(tbxPrestList);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "FormBatchProcess";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Batch Process";
            Load += FormBatchProcess_Load;
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
    }
}
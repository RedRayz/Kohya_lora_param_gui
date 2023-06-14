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
            this.tbxPrestList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiscardChanges = new System.Windows.Forms.Button();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.btnAddPreset = new System.Windows.Forms.Button();
            this.cbxGenerateLogText = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxPrestList
            // 
            this.tbxPrestList.Location = new System.Drawing.Point(12, 13);
            this.tbxPrestList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPrestList.Multiline = true;
            this.tbxPrestList.Name = "tbxPrestList";
            this.tbxPrestList.Size = new System.Drawing.Size(557, 528);
            this.tbxPrestList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(590, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 396);
            this.label1.TabIndex = 1;
            this.label1.Text = "バッチ処理\r\n入力したプリセットを基に順番に学習します。\r\n★使用方法\r\n左のテキストボックスに1行ごとにプリセットファイルのパスを入力します。\r\nプリセットを追" +
    "加する場合は改行してから入力します。\r\n空欄にするとバッチ処理を行いません。\r\n★注意\r\nプリセットが見つからないか無効な場合は無視されます。\r\nバッチ処理時は" +
    "「経過時間の表示」は無視されます。";
            // 
            // btnDiscardChanges
            // 
            this.btnDiscardChanges.Location = new System.Drawing.Point(824, 482);
            this.btnDiscardChanges.Name = "btnDiscardChanges";
            this.btnDiscardChanges.Size = new System.Drawing.Size(195, 44);
            this.btnDiscardChanges.TabIndex = 2;
            this.btnDiscardChanges.Text = "設定を反映せずに閉じる";
            this.btnDiscardChanges.UseVisualStyleBackColor = true;
            this.btnDiscardChanges.Click += new System.EventHandler(this.btnDiscardChanges_Click);
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Location = new System.Drawing.Point(824, 543);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(195, 44);
            this.btnApplyChanges.TabIndex = 2;
            this.btnApplyChanges.Text = "設定を反映して閉じる";
            this.btnApplyChanges.UseVisualStyleBackColor = true;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // btnAddPreset
            // 
            this.btnAddPreset.Location = new System.Drawing.Point(12, 548);
            this.btnAddPreset.Name = "btnAddPreset";
            this.btnAddPreset.Size = new System.Drawing.Size(143, 39);
            this.btnAddPreset.TabIndex = 3;
            this.btnAddPreset.Text = "プリセットの追加";
            this.btnAddPreset.UseVisualStyleBackColor = true;
            this.btnAddPreset.Click += new System.EventHandler(this.btnAddPreset_Click);
            // 
            // cbxGenerateLogText
            // 
            this.cbxGenerateLogText.AutoSize = true;
            this.cbxGenerateLogText.Location = new System.Drawing.Point(595, 302);
            this.cbxGenerateLogText.Name = "cbxGenerateLogText";
            this.cbxGenerateLogText.Size = new System.Drawing.Size(237, 29);
            this.cbxGenerateLogText.TabIndex = 4;
            this.cbxGenerateLogText.Text = "終了時にレポートを出力する";
            this.cbxGenerateLogText.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "開始時間、終了時間、経過時間、学習成功の可否を\r\nドキュメントフォルダーにbatchlog-日付.txtとして書き出します。";
            // 
            // FormBatchProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 601);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxGenerateLogText);
            this.Controls.Add(this.btnAddPreset);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.btnDiscardChanges);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPrestList);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormBatchProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Process";
            this.Load += new System.EventHandler(this.FormBatchProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPrestList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiscardChanges;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.Button btnAddPreset;
        private System.Windows.Forms.CheckBox cbxGenerateLogText;
        private System.Windows.Forms.Label label2;
    }
}
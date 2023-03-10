namespace Kohya_lora_trainer {
    partial class FormAddtional {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cbxAlgoType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDiscardChangesAndClose = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.nudConvDim = new System.Windows.Forms.NumericUpDown();
            this.nudConvAlpha = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvDim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxAlgoType
            // 
            this.cbxAlgoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlgoType.FormattingEnabled = true;
            this.cbxAlgoType.Items.AddRange(new object[] {
            "lora",
            "loha"});
            this.cbxAlgoType.Location = new System.Drawing.Point(229, 109);
            this.cbxAlgoType.Name = "cbxAlgoType";
            this.cbxAlgoType.Size = new System.Drawing.Size(121, 33);
            this.cbxAlgoType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conv Dim\r\n0で無効";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Conv Alpha\r\n0で無効";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "LyCORISのアルゴリズム";
            // 
            // btnDiscardChangesAndClose
            // 
            this.btnDiscardChangesAndClose.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDiscardChangesAndClose.Location = new System.Drawing.Point(164, 295);
            this.btnDiscardChangesAndClose.Name = "btnDiscardChangesAndClose";
            this.btnDiscardChangesAndClose.Size = new System.Drawing.Size(228, 43);
            this.btnDiscardChangesAndClose.TabIndex = 6;
            this.btnDiscardChangesAndClose.Text = "設定を反映せずに閉じる";
            this.btnDiscardChangesAndClose.UseVisualStyleBackColor = true;
            this.btnDiscardChangesAndClose.Click += new System.EventHandler(this.btnDiscardChangesAndClose_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSaveAndClose.Location = new System.Drawing.Point(414, 295);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(217, 43);
            this.btnSaveAndClose.TabIndex = 6;
            this.btnSaveAndClose.Text = "設定を反映して閉じる";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // nudConvDim
            // 
            this.nudConvDim.Location = new System.Drawing.Point(230, 52);
            this.nudConvDim.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudConvDim.Name = "nudConvDim";
            this.nudConvDim.Size = new System.Drawing.Size(120, 31);
            this.nudConvDim.TabIndex = 7;
            // 
            // nudConvAlpha
            // 
            this.nudConvAlpha.Location = new System.Drawing.Point(506, 54);
            this.nudConvAlpha.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudConvAlpha.Name = "nudConvAlpha";
            this.nudConvAlpha.Size = new System.Drawing.Size(120, 31);
            this.nudConvAlpha.TabIndex = 8;
            // 
            // FormAddtional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 366);
            this.Controls.Add(this.nudConvAlpha);
            this.Controls.Add(this.nudConvDim);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.btnDiscardChangesAndClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAlgoType);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddtional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "追加設定";
            this.Load += new System.EventHandler(this.FormAddtional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudConvDim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvAlpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAlgoType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDiscardChangesAndClose;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.NumericUpDown nudConvDim;
        private System.Windows.Forms.NumericUpDown nudConvAlpha;
    }
}
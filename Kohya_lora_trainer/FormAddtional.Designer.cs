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
            this.cbxAlgo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxConvDim = new System.Windows.Forms.TextBox();
            this.tbxConvAlpha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDiscardChangesAndClose = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxAlgo
            // 
            this.cbxAlgo.FormattingEnabled = true;
            this.cbxAlgo.Items.AddRange(new object[] {
            "lora",
            "loha"});
            this.cbxAlgo.Location = new System.Drawing.Point(229, 109);
            this.cbxAlgo.Name = "cbxAlgo";
            this.cbxAlgo.Size = new System.Drawing.Size(121, 33);
            this.cbxAlgo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conv Dim";
            // 
            // tbxConvDim
            // 
            this.tbxConvDim.Location = new System.Drawing.Point(229, 51);
            this.tbxConvDim.Name = "tbxConvDim";
            this.tbxConvDim.Size = new System.Drawing.Size(121, 31);
            this.tbxConvDim.TabIndex = 2;
            this.tbxConvDim.Text = "1e-5";
            // 
            // tbxConvAlpha
            // 
            this.tbxConvAlpha.Location = new System.Drawing.Point(505, 51);
            this.tbxConvAlpha.Name = "tbxConvAlpha";
            this.tbxConvAlpha.Size = new System.Drawing.Size(126, 31);
            this.tbxConvAlpha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Conv Alpha";
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
            this.btnDiscardChangesAndClose.Location = new System.Drawing.Point(312, 524);
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
            this.btnSaveAndClose.Location = new System.Drawing.Point(562, 524);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(217, 43);
            this.btnSaveAndClose.TabIndex = 6;
            this.btnSaveAndClose.Text = "設定を反映して閉じる";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // FormAddtional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.btnDiscardChangesAndClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxConvAlpha);
            this.Controls.Add(this.tbxConvDim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAlgo);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddtional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "追加設定";
            this.Load += new System.EventHandler(this.FormAddtional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAlgo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxConvDim;
        private System.Windows.Forms.TextBox tbxConvAlpha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDiscardChangesAndClose;
        private System.Windows.Forms.Button btnSaveAndClose;
    }
}
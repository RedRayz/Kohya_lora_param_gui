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
            this.cbxUseConv2d = new System.Windows.Forms.CheckBox();
            this.nudDyLoRAUnit = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectConfigPath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearConfigPath = new System.Windows.Forms.Button();
            this.lblConfigPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvDim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDyLoRAUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxAlgoType
            // 
            this.cbxAlgoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlgoType.FormattingEnabled = true;
            this.cbxAlgoType.Items.AddRange(new object[] {
            "lora",
            "loha",
            "ia3",
            "lokr"});
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
            this.btnDiscardChangesAndClose.Location = new System.Drawing.Point(171, 426);
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
            this.btnSaveAndClose.Location = new System.Drawing.Point(421, 426);
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
            this.nudConvAlpha.DecimalPlaces = 2;
            this.nudConvAlpha.Location = new System.Drawing.Point(506, 54);
            this.nudConvAlpha.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudConvAlpha.Name = "nudConvAlpha";
            this.nudConvAlpha.Size = new System.Drawing.Size(120, 31);
            this.nudConvAlpha.TabIndex = 8;
            this.nudConvAlpha.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // cbxUseConv2d
            // 
            this.cbxUseConv2d.AutoSize = true;
            this.cbxUseConv2d.Location = new System.Drawing.Point(108, 174);
            this.cbxUseConv2d.Name = "cbxUseConv2d";
            this.cbxUseConv2d.Size = new System.Drawing.Size(242, 29);
            this.cbxUseConv2d.TabIndex = 9;
            this.cbxUseConv2d.Text = "LoRAでConv2d拡張を使用";
            this.cbxUseConv2d.UseVisualStyleBackColor = true;
            // 
            // nudDyLoRAUnit
            // 
            this.nudDyLoRAUnit.Location = new System.Drawing.Point(506, 112);
            this.nudDyLoRAUnit.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudDyLoRAUnit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDyLoRAUnit.Name = "nudDyLoRAUnit";
            this.nudDyLoRAUnit.Size = new System.Drawing.Size(120, 31);
            this.nudDyLoRAUnit.TabIndex = 10;
            this.nudDyLoRAUnit.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "DyLoRAのunit";
            // 
            // btnSelectConfigPath
            // 
            this.btnSelectConfigPath.Location = new System.Drawing.Point(220, 275);
            this.btnSelectConfigPath.Name = "btnSelectConfigPath";
            this.btnSelectConfigPath.Size = new System.Drawing.Size(106, 37);
            this.btnSelectConfigPath.TabIndex = 12;
            this.btnSelectConfigPath.Text = "選択";
            this.btnSelectConfigPath.UseVisualStyleBackColor = true;
            this.btnSelectConfigPath.Click += new System.EventHandler(this.btnSelectConfigPath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "データセットconfigのパス";
            // 
            // btnClearConfigPath
            // 
            this.btnClearConfigPath.Location = new System.Drawing.Point(332, 275);
            this.btnClearConfigPath.Name = "btnClearConfigPath";
            this.btnClearConfigPath.Size = new System.Drawing.Size(106, 37);
            this.btnClearConfigPath.TabIndex = 12;
            this.btnClearConfigPath.Text = "クリア";
            this.btnClearConfigPath.UseVisualStyleBackColor = true;
            this.btnClearConfigPath.Click += new System.EventHandler(this.btnClearConfigPath_Click);
            // 
            // lblConfigPath
            // 
            this.lblConfigPath.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConfigPath.Location = new System.Drawing.Point(180, 315);
            this.lblConfigPath.Name = "lblConfigPath";
            this.lblConfigPath.Size = new System.Drawing.Size(281, 50);
            this.lblConfigPath.TabIndex = 13;
            this.lblConfigPath.Text = "C:\\Users\\Test\\Desktop\\long name\\aaaaa.toml";
            // 
            // FormAddtional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 494);
            this.Controls.Add(this.lblConfigPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClearConfigPath);
            this.Controls.Add(this.btnSelectConfigPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudDyLoRAUnit);
            this.Controls.Add(this.cbxUseConv2d);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudDyLoRAUnit)).EndInit();
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
        private System.Windows.Forms.CheckBox cbxUseConv2d;
        private System.Windows.Forms.NumericUpDown nudDyLoRAUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectConfigPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearConfigPath;
        private System.Windows.Forms.Label lblConfigPath;
    }
}
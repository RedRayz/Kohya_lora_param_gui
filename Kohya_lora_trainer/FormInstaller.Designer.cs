namespace Kohya_lora_trainer
{
    partial class FormInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstaller));
            btnInstall = new Button();
            label1 = new Label();
            label2 = new Label();
            cbxUsePy = new CheckBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnInstall
            // 
            btnInstall.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInstall.Location = new Point(171, 29);
            btnInstall.Name = "btnInstall";
            btnInstall.Size = new Size(134, 42);
            btnInstall.TabIndex = 0;
            btnInstall.Text = "インストール";
            btnInstall.UseVisualStyleBackColor = true;
            btnInstall.Click += btnInstall_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 120);
            label1.Name = "label1";
            label1.Size = new Size(352, 105);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 244);
            label2.Name = "label2";
            label2.Size = new Size(394, 180);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // cbxUsePy
            // 
            cbxUsePy.AutoSize = true;
            cbxUsePy.Location = new Point(145, 77);
            cbxUsePy.Name = "cbxUsePy";
            cbxUsePy.Size = new Size(202, 19);
            cbxUsePy.TabIndex = 3;
            cbxUsePy.Text = "「python」の代わりに「py」を使用する";
            toolTip1.SetToolTip(cbxUsePy, "ターミナルpythonとだけ表示されて何も起きない場合にチェックをつけてください");
            cbxUsePy.UseVisualStyleBackColor = true;
            // 
            // FormInstaller
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(485, 452);
            Controls.Add(cbxUsePy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInstall);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormInstaller";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "簡易インストーラ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CheckBox cbxUsePy;
        private ToolTip toolTip1;
    }
}
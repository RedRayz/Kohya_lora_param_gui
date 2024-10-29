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
            cbxPythonVersion = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnInstall
            // 
            btnInstall.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInstall.Location = new Point(171, 12);
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
            label1.Location = new Point(32, 122);
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
            cbxUsePy.Location = new Point(142, 60);
            cbxUsePy.Name = "cbxUsePy";
            cbxUsePy.Size = new Size(202, 19);
            cbxUsePy.TabIndex = 3;
            cbxUsePy.Text = "「python」の代わりに「py」を使用する";
            toolTip1.SetToolTip(cbxUsePy, "ターミナルpythonとだけ表示されて何も起きないか\r\nPythonバージョンを指定する場合にチェックをつけてください");
            cbxUsePy.UseVisualStyleBackColor = true;
            // 
            // cbxPythonVersion
            // 
            cbxPythonVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPythonVersion.FormattingEnabled = true;
            cbxPythonVersion.Items.AddRange(new object[] { "3.10", "3.11" });
            cbxPythonVersion.Location = new Point(277, 80);
            cbxPythonVersion.Name = "cbxPythonVersion";
            cbxPythonVersion.Size = new Size(96, 23);
            cbxPythonVersion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 83);
            label3.Name = "label3";
            label3.Size = new Size(186, 15);
            label3.TabIndex = 5;
            label3.Text = "Pythonバージョン(pyを使用する場合)";
            // 
            // FormInstaller
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(485, 452);
            Controls.Add(label3);
            Controls.Add(cbxPythonVersion);
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
            Load += FormInstaller_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CheckBox cbxUsePy;
        private ToolTip toolTip1;
        private ComboBox cbxPythonVersion;
        private Label label3;
    }
}
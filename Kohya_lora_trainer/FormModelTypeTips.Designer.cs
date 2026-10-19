namespace Kohya_lora_trainer
{
    partial class FormModelTypeTips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModelTypeTips));
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(187, 283);
            button1.Name = "button1";
            button1.Size = new Size(90, 41);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(449, 214);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormModelTypeTips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 357);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormModelTypeTips";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormModelTypeTips";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}
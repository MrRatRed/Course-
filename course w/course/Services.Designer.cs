namespace course
{
    partial class Services
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
            SelectButton = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(185, 413);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(111, 68);
            SelectButton.TabIndex = 2;
            SelectButton.Text = "Готово";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Лікування";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(469, 350);
            textBox1.TabIndex = 5;
            // 
            // Services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(489, 515);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(SelectButton);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Services";
            Text = "Вибір послуг";
            Load += Services_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SelectButton;
        private Label label2;
        private TextBox textBox1;
    }
}
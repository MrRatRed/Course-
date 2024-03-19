namespace course
{
    partial class patients
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NameBox = new TextBox();
            comboBox1 = new ComboBox();
            TelephoneBox = new TextBox();
            AgeBox = new TextBox();
            RegisterButt = new Button();
            Order = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 5);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "ПІБ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 69);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Номер Телефону";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 134);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 2;
            label3.Text = "Вік";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 196);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Стать";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(7, 28);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(380, 27);
            NameBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Чоловік", "Жінка" });
            comboBox1.Location = new Point(6, 219);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(299, 28);
            comboBox1.TabIndex = 5;
            // 
            // TelephoneBox
            // 
            TelephoneBox.Location = new Point(6, 92);
            TelephoneBox.Name = "TelephoneBox";
            TelephoneBox.Size = new Size(383, 27);
            TelephoneBox.TabIndex = 6;
            // 
            // AgeBox
            // 
            AgeBox.Location = new Point(6, 157);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(125, 27);
            AgeBox.TabIndex = 7;
            // 
            // RegisterButt
            // 
            RegisterButt.Location = new Point(322, 390);
            RegisterButt.Name = "RegisterButt";
            RegisterButt.Size = new Size(113, 48);
            RegisterButt.TabIndex = 8;
            RegisterButt.Text = "Готово";
            RegisterButt.UseVisualStyleBackColor = true;
            RegisterButt.Click += RegisterButt_Click;
            // 
            // Order
            // 
            Order.Location = new Point(7, 328);
            Order.Name = "Order";
            Order.Size = new Size(158, 29);
            Order.TabIndex = 9;
            Order.Text = "Замовити послуги";
            Order.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 295);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 272);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 11;
            label5.Text = "Ціна";
            // 
            // patients
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(466, 450);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(Order);
            Controls.Add(RegisterButt);
            Controls.Add(AgeBox);
            Controls.Add(TelephoneBox);
            Controls.Add(comboBox1);
            Controls.Add(NameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "patients";
            Text = "Реєстрація пацієнта";
            Load += patients_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameBox;
        private ComboBox comboBox1;
        private TextBox TelephoneBox;
        private TextBox AgeBox;
        private Button RegisterButt;
        private Button Order;
        private TextBox textBox1;
        private Label label5;
    }
}
namespace course
{
    partial class list
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ArchiveButton = new Button();
            AddButton = new Button();
            label5 = new Label();
            NameBox = new TextBox();
            TelephoneBox = new TextBox();
            AgeBox = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            ResultBox = new TextBox();
            Select = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(337, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(678, 346);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Меню Реєстрації";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 2;
            label2.Text = "ПІБ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 112);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 3;
            label3.Text = "Номер телефону";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 178);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 4;
            label4.Text = "Вік";
            // 
            // ArchiveButton
            // 
            ArchiveButton.BackColor = SystemColors.ActiveBorder;
            ArchiveButton.Location = new Point(855, 12);
            ArchiveButton.Name = "ArchiveButton";
            ArchiveButton.Size = new Size(152, 59);
            ArchiveButton.TabIndex = 5;
            ArchiveButton.Text = "Додати в архів";
            ArchiveButton.UseVisualStyleBackColor = false;
            ArchiveButton.Click += ArchiveButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.AppWorkspace;
            AddButton.Location = new Point(337, 12);
            AddButton.Name = "AddButton";
            AddButton.RightToLeft = RightToLeft.No;
            AddButton.Size = new Size(155, 59);
            AddButton.TabIndex = 6;
            AddButton.Text = "Додати пацієнта в список";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 242);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 7;
            label5.Text = "Стать";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(11, 71);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(302, 27);
            NameBox.TabIndex = 8;
            // 
            // TelephoneBox
            // 
            TelephoneBox.Location = new Point(10, 135);
            TelephoneBox.Name = "TelephoneBox";
            TelephoneBox.Size = new Size(211, 27);
            TelephoneBox.TabIndex = 9;
            // 
            // AgeBox
            // 
            AgeBox.Location = new Point(10, 201);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(75, 27);
            AgeBox.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Чоловік", "Жінка" });
            comboBox1.Location = new Point(10, 265);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(179, 380);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 12;
            label6.Text = "Віділ";
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(138, 403);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(132, 27);
            ResultBox.TabIndex = 13;
            // 
            // Select
            // 
            Select.Location = new Point(138, 338);
            Select.Name = "Select";
            Select.Size = new Size(132, 29);
            Select.TabIndex = 14;
            Select.Text = "Обрати послуги";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Select_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1023, 452);
            Controls.Add(Select);
            Controls.Add(ResultBox);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(AgeBox);
            Controls.Add(TelephoneBox);
            Controls.Add(NameBox);
            Controls.Add(label5);
            Controls.Add(AddButton);
            Controls.Add(ArchiveButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "list";
            Text = "Список пациеннтов";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ArchiveButton;
        private Button AddButton;
        private Label label5;
        private TextBox NameBox;
        private TextBox TelephoneBox;
        private TextBox AgeBox;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox ResultBox;
        private Button Select;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
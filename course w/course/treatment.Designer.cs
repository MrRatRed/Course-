namespace course
{
    partial class treatment
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            buttonServices = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.One;
            pictureBox1.Location = new Point(12, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Two;
            pictureBox2.Location = new Point(510, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 185);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Three;
            pictureBox3.Location = new Point(12, 374);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(285, 185);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.four;
            pictureBox4.Location = new Point(503, 374);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(285, 185);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 6);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 4;
            label1.Text = "Лікування печінки і жовчного";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(548, 6);
            label2.Name = "label2";
            label2.Size = new Size(204, 20);
            label2.TabIndex = 5;
            label2.Text = "лікування астми та бронхіту";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 351);
            label3.Name = "label3";
            label3.Size = new Size(210, 20);
            label3.TabIndex = 6;
            label3.Text = "Лікування суглобів та хребта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 351);
            label4.Name = "label4";
            label4.Size = new Size(305, 20);
            label4.TabIndex = 7;
            label4.Text = "Лікування гастриту та виразкової хвороби";
            // 
            // button1
            // 
            button1.Location = new Point(101, 243);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Замовити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(609, 243);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Замовити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(101, 586);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Замовити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(609, 586);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Замовити";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonServices
            // 
            buttonServices.Location = new Point(341, 601);
            buttonServices.Name = "buttonServices";
            buttonServices.Size = new Size(117, 73);
            buttonServices.TabIndex = 12;
            buttonServices.Text = "Переглянути Список процедур";
            buttonServices.UseVisualStyleBackColor = true;
            buttonServices.Click += buttonServices_Click;
            // 
            // treatment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(828, 450);
            Controls.Add(buttonServices);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "treatment";
            Text = "treatment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button buttonServices;
    }
}
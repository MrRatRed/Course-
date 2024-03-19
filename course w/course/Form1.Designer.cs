namespace course
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            Patients = new ToolStripMenuItem();
            List = new ToolStripMenuItem();
            treatment = new ToolStripMenuItem();
            Service = new ToolStripMenuItem();
            Archive = new ToolStripMenuItem();
            places = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Patients, treatment, Service, Archive, places });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(759, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Patients
            // 
            Patients.DropDownItems.AddRange(new ToolStripItem[] { List });
            Patients.Name = "Patients";
            Patients.Size = new Size(187, 24);
            Patients.Text = "Надходження пацієнтів";
            // 
            // List
            // 
            List.Name = "List";
            List.Size = new Size(301, 26);
            List.Text = "Переглянути список пацієнтів";
            List.Click += List_Click;
            // 
            // treatment
            // 
            treatment.Name = "treatment";
            treatment.Size = new Size(97, 24);
            treatment.Text = "Лікування ";
            treatment.Click += treatment_Click;
            // 
            // Service
            // 
            Service.Name = "Service";
            Service.Size = new Size(145, 24);
            Service.Text = "Список процедур";
            Service.Click += Service_Click;
            // 
            // Archive
            // 
            Archive.Name = "Archive";
            Archive.Size = new Size(129, 24);
            Archive.Text = "Архів пацієнтів";
            Archive.Click += Archive_Click;
            // 
            // places
            // 
            places.Name = "places";
            places.Size = new Size(183, 24);
            places.Text = "Список зайнятих місць";
            places.Click += places_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.number1;
            pictureBox1.Location = new Point(0, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(759, 407);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(759, 436);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Головне вікно";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Patients;
        private ToolStripMenuItem treatment;
        private ToolStripMenuItem Service;
        private ToolStripMenuItem Archive;
        private ToolStripMenuItem places;
        private PictureBox pictureBox1;
        private ToolStripMenuItem List;
    }
}
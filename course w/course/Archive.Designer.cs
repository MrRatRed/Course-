namespace course
{
    partial class Archive
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
            DataGridViewRow = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRow).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewRow
            // 
            DataGridViewRow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewRow.Location = new Point(12, 107);
            DataGridViewRow.Name = "DataGridViewRow";
            DataGridViewRow.RowHeadersWidth = 51;
            DataGridViewRow.RowTemplate.Height = 29;
            DataGridViewRow.Size = new Size(744, 331);
            DataGridViewRow.TabIndex = 0;
            DataGridViewRow.CellContentClick += DataGridViewRow_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 24);
            label1.Name = "label1";
            label1.Size = new Size(319, 20);
            label1.TabIndex = 1;
            label1.Text = "Тут знаходиться список пацієнтів,які виїхали";
            // 
            // Archive
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(label1);
            Controls.Add(DataGridViewRow);
            Name = "Archive";
            Text = "Архив";
            Load += Archive_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewRow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewRow;
        private Label label1;
    }
}
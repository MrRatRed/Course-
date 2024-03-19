using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course
{
    public partial class order : Form

    {
        public delegate void DataUpdatedEventHandler(object sender, DataTable data);
        public event DataUpdatedEventHandler DataUpdated;

        public order()
        {
            InitializeComponent();
            var listForm = new list();
            listForm.DataAdded += ListForm_DataAdded;

        }
        private void ListForm_DataAdded(object sender, DataTable data)
        {
            // Обновляем данные в таблице на основе полученной DataTable
            dataGridView1.DataSource = data;
        }
        places places;
        private void button1_Click(object sender, EventArgs e)
        {
            places = new places();
            places.Show();
            this.Close();
        }

        private void order_Load(object sender, EventArgs e)
        {

        }
    }
}

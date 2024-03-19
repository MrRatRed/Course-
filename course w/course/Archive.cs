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
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void Archive_Load(object sender, EventArgs e)
        {
            
        }
        public void SetData(DataTable data)
        {
            DataGridViewRow.DataSource = data;
        }
        private void DataGridViewRow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

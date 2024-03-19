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
    public partial class places : Form
    {
        public places()
        {
            InitializeComponent();

        }
        order order;
        private void button1_Click(object sender, EventArgs e)
        {
            order = new order();
            order.Show();
            this.Close();
        }

        private void places_Load(object sender, EventArgs e)
        {

        }
    }
}

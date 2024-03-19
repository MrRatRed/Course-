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
    public partial class patients : Form
    {
        public string PIB { get; set; }
        public string PhoneNumber { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public patients()
        {
            InitializeComponent();
        }
        private void patients_Load(object sender, EventArgs e)
        {

        }
        private void RegisterButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(TelephoneBox.Text) ||
                string.IsNullOrWhiteSpace(AgeBox.Text) ||
                string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Увага! Всі поля мають бути заповнені!");
            }
            else
            {
                PIB = NameBox.Text;
                PhoneNumber = TelephoneBox.Text;
                Age = AgeBox.Text;
                Gender = comboBox1.Text;
                this.Close();
            }
        }
    }
}

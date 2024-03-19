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
    public partial class treatment : Form
    {
        list listForm;

        public treatment()
        {
            InitializeComponent();
            listForm = new list();
            listForm.FormClosed += ListForm_FormClosed;
        }

        private void ListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listForm.SetText("Хірургія");
            listForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listForm.SetText("Пульманологія");
            listForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listForm.SetText("Ревматологія");
            listForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listForm.SetText("Гастроентерологія");
            listForm.Show();
        }

        Services services;

        private void buttonServices_Click(object sender, EventArgs e)
        {
            services = new Services();
            services.Show();
        }
    }
}
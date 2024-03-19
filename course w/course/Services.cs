using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace course
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
            textBox1.Multiline = true;
            textBox1.Text =
                "           Лікування печінки і жовчного\r\n" +
                "Медикаментозне лікування\r\n   " +
                "Особлива дієта\r\n     " +
                "Медичний нагляд\r\n    " +
                "           Лікування астми і бронхіту\r\n" +
                "Інгаляційна терапія\r\n" +
                "Управління тригерами\r\n" +
                "Відпочинок і гідратація\r\n" +
                "           Лікування суглобів та хребта\r\n" +
                "Фізіотерапія\r\n" +
                "Ін'єкції протизапальних ліків\r\n" +
                "Ортопедичні вироби\r\n" +
                "           Лікування гастриту та виразкової хвороби\r\n" +
                "Особлива дієта\r\n" +
                "Протизапальні препарати\r\n" +
                "Ерадикація Helicobacter pylori\r\n";
        }


        private void Services_Load(object sender, EventArgs e)
        {

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

namespace course
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        list list;
        private void List_Click(object sender, EventArgs e)
        {
            list = new list();
            list.Show();
        }
        Archive archive;
        private void Archive_Click(object sender, EventArgs e)
        {
            archive = new Archive();
            archive.Show();
        }
        Services services;
        private void Service_Click(object sender, EventArgs e)
        {
            services = new Services();
            services.Show();
        }
        treatment Treatment;
        private void treatment_Click(object sender, EventArgs e)
        {
            Treatment = new treatment();
            Treatment.Show();
        }
        places Places;
        private void places_Click(object sender, EventArgs e)
        {
            Places = new places();
            Places.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Xml.Linq;
using System.Windows.Forms;

namespace course
{
    public class Humans
    {
        public Humans(string FullName, string Telephone, string Age, string Gender, string Money)
        {
            this.FullName = FullName;
            this.Telephone = Telephone;
            this.Age = Age;
            this.Gender = Gender;
            this.Money = Money;
        }
        public string FullName { get; set; }
        public string Telephone { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Money { get; set; }
    }
    internal static class Program
    {
        public static List<Humans> Humans = new List<Humans>();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        
    }
}
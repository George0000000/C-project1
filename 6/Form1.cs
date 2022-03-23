using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize
            FileStream file1 = new FileStream("G:\\person1.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);

            //First person
            string str = reader.ReadLine();
            person p1 = new person(str.Split(';'));

            //Second person
            str = reader.ReadLine();
            person p2 = new person(str.Split(';'));


            //Third person
            str = reader.ReadLine();
            person p3 = new person(str.Split(';'));

            reader.Close();

            

            textBox1.Text = p1.Name;
            textBox2.Text = p1.Profession;
            textBox3.Text = p1.Position;
        }
    }
}

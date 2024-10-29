using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Media;

namespace Fisher
{
    public partial class Encumbrance : Form
    {
        private string password;
        private SoundPlayer wrongFx;

        public Encumbrance()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string validatorPassword = this.password;

            if (validatorPassword == ConfigurationManager.AppSettings["Password"])
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                this.wrongFx.Play();
                Console.WriteLine("Wrong password.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

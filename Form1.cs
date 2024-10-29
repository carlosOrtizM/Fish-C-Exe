using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fisher
{
    public partial class Form1 : Form
    {

        private SoundPlayer bocelliGang;

        public Form1()
        {
            InitializeComponent();
            SoundPlay(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
            this.Focus(); 
            this.Show();
        }

        static private void SoundPlay(Form1 form1)
        {
            form1.bocelliGang.PlayLooping();
        }

        static public void SoundPause(Form1 form1)
        {
            form1.bocelliGang.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using Fisher.Properties;
using System;
using System.Media;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Fisher
{
    public class IntroSplashForm : Form
    {
        private PictureBox pictureBox1;
        private BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;

        private SoundPlayer introMusic;
        private bool ControlProps = true;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;

        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        public IntroSplashForm splashForm;

        public IntroSplashForm()
        {
            InitializeComponent();
        }

        static public void ShowSplashScreen(IntroSplashForm splashForm)
        {
            Thread thread = new Thread(() => ShowForm(splashForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            SoundPlay(splashForm);
        }

        static private void ShowForm(IntroSplashForm splashForm)
        {
            if (splashForm != null) Application.Run(splashForm);
        }

        static public void CloseForm(IntroSplashForm splashForm)
        {
            SoundPause(splashForm);
            splashForm.timer1.Stop();
            splashForm.Invoke((MethodInvoker)delegate
            {
                // close the form on the forms thread
                splashForm.Close();
            });
        }

        static private void SoundPlay(IntroSplashForm splashForm)
        {
            splashForm.introMusic.PlayLooping();
        }

        static public void SoundPause(IntroSplashForm splashForm)
        {
            splashForm.introMusic.Stop();
        }

        static public void ImageSwitcher(object sender, EventArgs e, IntroSplashForm splashForm)
        {
            ImageReplacement(splashForm);
        }

        static private void ImageReplacement(IntroSplashForm splashForm)
        {
            if (splashForm.ControlProps)
            {
                splashForm.pictureBox2.Image = global::Fisher.Properties.Resources.david_clode_u5K46PukKAo_unsplash__1_;
                splashForm.pictureBox2.Refresh();
                splashForm.ControlProps = false;

            }
            else
            {
                splashForm.pictureBox2.Image = global::Fisher.Properties.Resources.david_clode_EDfZ0Sjmp_w_unsplash__1_;
                splashForm.pictureBox2.Refresh();
                splashForm.ControlProps = true;
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.introMusic = new System.Media.SoundPlayer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fisher.Properties.Resources.oshitpixeled;
            this.pictureBox1.Location = new System.Drawing.Point(43, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 265);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // introMusic
            // 
            this.introMusic.LoadTimeout = 10000;
            this.introMusic.SoundLocation = "";
            this.introMusic.Stream = global::Fisher.Properties.Resources.fish1;
            this.introMusic.Tag = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Fisher.Properties.Resources.please;
            this.pictureBox2.Location = new System.Drawing.Point(436, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(479, 419);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // IntroSplashForm
            // 
            this.ClientSize = new System.Drawing.Size(936, 571);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IntroSplashForm";
            this.Load += new System.EventHandler(this.IntroSplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private void IntroSplashForm_Load(object sender, System.EventArgs e)
        {
            IntroSplashForm splashForm = this;
            timer1.Interval = (4000);
            timer1.Tick += (sender1, e1) => ImageSwitcher(sender, e, splashForm);
            timer1.Start();
        }
    }
}

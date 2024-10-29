using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Fisher
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IntroSplashForm splashForm = new IntroSplashForm();
            IntroSplashForm.ShowSplashScreen(splashForm);

            int milliseconds = 15000;
            Thread.Sleep(milliseconds);

            Encumbrance login = new Encumbrance();
            IntroSplashForm.CloseForm(splashForm);

            Application.Run(login);
        }
    }
}

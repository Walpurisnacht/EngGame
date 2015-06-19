using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form0());
        }
    }
    public class Form0 : Form 
    {
        public static Form0 Form0Instance;

        public Form0()
        {
            Form0Instance = this;

            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;

            MainForm _Main = new MainForm();
            _Main.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVF
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static LoginForm mp;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mp = new LoginForm());
            /*
            LoginForm main = new LoginForm();
            menuPrincipal mp = new menuPrincipal();
            main.Show();
            Application.Run();
            */
        }
    }
}

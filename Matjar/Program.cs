using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Matjar
{
    static class Program
    {
        static List<string> model = new List<string>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashBoard());
        }
    }
}

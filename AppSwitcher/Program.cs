using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CSharp;
using System.Threading;
using System.Windows.Forms;

namespace AppSwitcher
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
            Application.Run(new MainForm());
        }
    }
}

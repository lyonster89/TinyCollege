using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Team Cheetah
// Desiree Bonilla, John Lyon, Ryan McSorley, Christopher Perry
// Christion Smith, Alexis Snider
// CISS 311
// Advanced Agile Software Development
// December 12 2021

namespace TinyCollege
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

/*
 * Student Name: Sena Unal
 *  Class: ICS3U
 *  Game Name: The Mystery At The Manor
 *  Project Completed: 2026/01/26
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Whodunnit
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

             using (var title = new TitleForm())
            {
                title.ShowDialog(); // Show the title screen
            }

            Application.Run(new Form1());
        }
    }
}

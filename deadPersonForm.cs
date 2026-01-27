/*
 * Student Name: Sena Unal
 *  Class: ICS3U
 *  Game Name: The Mystery At The Manor
 *  Project Completed: 2026/01/26
 *  
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Whodunnit
{
    public partial class deadPersonForm : Form
    {
        public deadPersonForm()
        {
            InitializeComponent();
        }

        // Hides this form (but doesn't close it because it gets destroyed once it is closed)
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

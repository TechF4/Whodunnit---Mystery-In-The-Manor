using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Whodunnit
{
    public partial class evidenceForm : Form
    {
        string filePath = @"C:\Users\techn\OneDrive\Desktop\whodunnitGame.txt";
        public evidenceForm()
        {
            InitializeComponent();

            using (StreamReader reader = new StreamReader(filePath))
            {
            }

            string[] lines = File.ReadAllLines(filePath);
            //read the file in, line by line into an array
            string evidence;
            for (int i = 0; i < lines.Length; i = i + 2)
            {
                evidence = lines[i];
                //read the 'ith' line in and it will be the name

            }
            
            
            
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void evidenceForm_Load(object sender, EventArgs e)
        {

        }



    }
}

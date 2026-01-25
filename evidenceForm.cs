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
            
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void evidenceForm_Load(object sender, EventArgs e)
        {

        }

        // PURPOSE: When the form becomes active, reload evidence from the file
        private void evidenceForm_Activated(object sender, EventArgs e)
        {
            
        }

        // PURPOSE: Reads the evidence file and displays what has been collected
        private void LoadEvidenceFromFile()
        {
            // Clear labels first
            wineGlassLabel.Text = "";
            journalLabel.Text = "";
            medicalCabinetLabel.Text = "";
            openWindowLabel.Text = "";

            // If file doesn't exist, nothing to show
            if (!File.Exists(filePath))
            {
                return;
            }

            // Read all evidence lines
            string[] lines = File.ReadAllLines(filePath);

            // Loop through each line and set labels
            for (int i = 0; i < lines.Length; i++)
            {
                string evidence = lines[i];

                if (evidence == "Wine Glass")
                {
                    wineGlassLabel.Text = "Wine Glass";
                }
                else if (evidence == "Journal")
                {
                    journalLabel.Text = "Journal";
                }
                else if (evidence == "Medical Log")
                {
                    medicalCabinetLabel.Text = "Medical Log";
                }
                else if (evidence == "Open Window")
                {
                    openWindowLabel.Text = "Open Window";
                }
            }
        }

        private void evidenceForm_Activated_1(object sender, EventArgs e)
        {
            LoadEvidenceFromFile();
        }
    }
}

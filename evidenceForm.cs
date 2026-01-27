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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Whodunnit
{
    public partial class evidenceForm : Form
    {
        // The file for storing all of the info
        string filePath = @"C:\Users\techn\OneDrive\Desktop\whodunnitGame.txt";
        public evidenceForm()
        {
            InitializeComponent();
            
        }

        // Hides this form (but doesn't close it because it gets destroyed once it is closed)
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
                    // If the wine glass is found then displays this message and shows the picture
                    wineGlassLabel.Text = "Wine Glass found. \n Poison mixed into the wine to kill.";
                    wineGlassPicture.Visible = true;
                }

                else if (evidence == "Journal")
                {
                    // If the journal is found then displays this message and shows the picture
                    journalLabel.Text = "Journal found. \n The wife doesn't like reading.";
                    journalEvidence.Visible = true;
                }

                else if (evidence == "Medical Log")
                {
                    // If the medical log is found then displays this message and shows the picture
                    medicalCabinetLabel.Text = "Medical Log found. \n Digitalis taken out earlier.";
                    medicalCabinetPicture.Visible = true;
                }

                else if (evidence == "Open Window")
                {
                    // If the open window is found then displays this message and shows the picture
                    openWindowLabel.Text = "Open Window. \n The window was left open.";
                    windowEvidence.Visible = true;
                }
            }
        }

        // When the evidence form is active
        private void evidenceForm_Activated_1(object sender, EventArgs e)
        {
            // Calls the function
            LoadEvidenceFromFile();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void wineGlassLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

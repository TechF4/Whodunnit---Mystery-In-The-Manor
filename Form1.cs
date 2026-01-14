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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string[] suspectList = { "Evelyn", "Marcus", "Dr. Nina", "Oliver Grant" };
        string[] realEvidence = { "Digitalis" };
        string[] fakeEvidence = { "Muddy Shoes", "Open Window" };


        suspectsForm suspectsForm = new suspectsForm();

        private void suspectsButton_Click(object sender, EventArgs e)
        {
            suspectsForm.Show();
        }

        evidenceForm evidenceForm = new evidenceForm();

        private void evidenceButton_Click(object sender, EventArgs e)
        {
            evidenceForm.Show();
        }

        storyForm storyForm = new storyForm();

        private void storyButton_Click(object sender, EventArgs e)
        {
            storyForm.Show();
        }

        deadPersonForm deadPersonForm = new deadPersonForm();

        private void victimButton_Click(object sender, EventArgs e)
        {
            deadPersonForm.Show();

        }

        int timesClicked = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            timesClicked++;

            if (timesClicked == 1)
            {
                narratorLabel.Text = "Dr. Hale’s body was found here, slumped at his desk. " +
                    "The room is orderly, almost too orderly, as if someone wanted it to appear untouched.    (Click)";
            }

            if (timesClicked == 2)
            {
                narratorLabel.Text = "Objects of interest catch your attention: a wine glass, " +
                    "a medical cabinet, a notebook, and a partially open window.";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Add code when the user clicks on the wine glass
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        // If the game has ended, make sure to use close all of the other forms one by one
    }
}

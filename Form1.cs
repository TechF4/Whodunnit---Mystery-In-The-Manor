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

        int narratorTimesClicked = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            narratorTimesClicked++;

            if (narratorTimesClicked == 1)
            {
                narratorLabel.Text = "Dr. Hale’s body was found here, slumped at his desk. " +
                    "The room is orderly, almost too orderly, as if someone wanted it to appear untouched.    (Click)";
            }

            if (narratorTimesClicked == 2)
            {
                narratorLabel.Text = "Objects of interest catch your attention: a wine glass, " +
                    "a medical cabinet, a notebook, and a partially open window.";
            }

        }

        int wineTimesClicked = 0;
        private void pictureBox1_Click(object sender, EventArgs e) // Wine Glass
        {
            wineTimesClicked++;

            if (wineTimesClicked == 1)
            {
                narratorLabel.Text = "Wine Glass: The wine glass is half full and resting near the edge of the desk.    (Click)";
            }

            if (wineTimesClicked == 2)
            {
                narratorLabel.Text = "Wine Glass: The liquid appears darker than expected, " +
                    "and a faint residue clings to the inside of the glass.    (Click)";
            }

            if (wineTimesClicked == 3)
            {
                narratorLabel.Text = "Wine Glass: The smell is slightly bitter—unusual for such an expensive wine.";
            }

            if(wineTimesClicked == 4)
            {
                narratorLabel.Text = "Wine Glass: You’ve already examined the wine glass.";
            }

            if(wineTimesClicked >= 5)
            {
                narratorLabel.Text = "Wine Glass: Whatever was added to this drink was meant to go unnoticed.";
            }

        }

        int windowTimesClicked = 0;
        private void pictureBox2_Click(object sender, EventArgs e) // Window
        {
            windowTimesClicked++;

            if (windowTimesClicked == 1)
            {
                narratorLabel.Text = "Window: The window is slightly open, letting in cold air and rain.    (Click)";
            }

            if (windowTimesClicked == 2)
            {
                narratorLabel.Text = "Window: The latch looks damaged, as if it were forced.";
            }

            if (windowTimesClicked == 3)
            {
                narratorLabel.Text = "Window: Looking closer, the damage appears to be from the inside, not outside.";
            }

            if (windowTimesClicked >= 4)
            {
                narratorLabel.Text = "Window: There are no signs of anyone entering through the window.";
            }
        }

        int journalTimesClicked = 0;
        private void journalEvidence_Click(object sender, EventArgs e)
        {
            journalTimesClicked++;

            if (journalTimesClicked == 1)
            {
                narratorLabel.Text = "Notebook: The notebook lies open on the desk, filled with neat, deliberate " +
                    "handwriting.    (Click)";
            }

            if (journalTimesClicked == 2)
            {
                narratorLabel.Text = "Notebook: Most entries concern legal matters and personal concerns.    (Click)";
            }

            if (journalTimesClicked == 3)
            {
                narratorLabel.Text = "Notebook: Some talk about how annoying his colleauge is, and some talk about his wife. " +
                    " 'Evelyn despises reading, too bad she won't read my report'.    (Click)";
            }

            if (journalTimesClicked == 4)
            {
                narratorLabel.Text = "Notebook: One line has been underlined heavily:\r\n“I must tell her tonight.”\r\n ";
            }

            if (journalTimesClicked == 5)
            {
                narratorLabel.Text = "Notebook: You reread the note.";
            }

            if (journalTimesClicked >= 6)
            {
                narratorLabel.Text = "Notebook: Whoever “her” is, the timing of this message feels important.";
            }
        }

        int cabinetTimesClicked = 0;
        private void pictureBox2_Click_1(object sender, EventArgs e) // Medical Cabinet
        {
            cabinetTimesClicked++;

            if (cabinetTimesClicked == 1)
            {
                narratorLabel.Text = "Medical Cabinet: The wall-mounted medical cabinet contains " +
                "prescription bottles and research samples.    (Click)";
            }

            if (cabinetTimesClicked == 2)
            {
                narratorLabel.Text = "Medical Cabinet: A digital access log is clipped inside the door.    (Click)";
            }

            if (cabinetTimesClicked >= 3)
            {
                narratorLabel.Text = "Medical Cabinet: One entry stands out: a medication was removed " +
                    "shortly before Dr. Hale’s death.";
            }

            

            // If I have time add one more thing when key is found

        }

        // If the game has ended, make sure to use close all of the other forms one by one
    }
}

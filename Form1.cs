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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The file to store evidence in
        string filePath = @"C:\Users\techn\OneDrive\Desktop\whodunnitGame.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, ""); // new game = empty evidence file
        }

        // Used arrays to organize the suspectList, real evidence, and fake evidence
        string[] suspectList = { "Evelyn", "Marcus", "Dr. Nina", "Oliver Grant" };
        string[] realEvidence = { "Wine Glass", "Digitalis", "Journal", "Medical Log" };
        string[] fakeEvidence = { "Open Window", "Muddy Shoes" };


        // Initializes the suspectsForm
        suspectsForm suspectsForm = new suspectsForm();

        // When the user clicks on the suspects button it shows the suspects form
        private void suspectsButton_Click(object sender, EventArgs e)
        {
            suspectsForm.Show();
        }


        // Initializes the evidenceForm
        evidenceForm evidenceForm = new evidenceForm();

        // When the user clicks on the evidence button it shows the evidence form
        private void evidenceButton_Click(object sender, EventArgs e)
        {
            evidenceForm.Show();
        }


        // Initializes the storyForm
        storyForm storyForm = new storyForm();

        // When the user clicks on the story button it shows the story form
        private void storyButton_Click(object sender, EventArgs e)
        {
            storyForm.Show();
        }


        // Initializes the deadPersonForm
        deadPersonForm deadPersonForm = new deadPersonForm();

        // When the user clicks on the victim button it shows the victim form
        private void victimButton_Click(object sender, EventArgs e)
        {
            deadPersonForm.Show();

        }

        // Counts how many times the user has clicked on the narrator label
        int narratorTimesClicked = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            // Increments each time the label is clicked
            narratorTimesClicked++;

            // Uses if statements to check how many times the narrator label has been clicked then displays the text

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

        // Initializes wineFound and sets it to false
        bool wineFound = false;

        // Counts how many times the user has clicked on the wine glass
        int wineTimesClicked = 0;
        private void pictureBox1_Click(object sender, EventArgs e) // Wine Glass
        {
            // Increments each time the wine glass is clicked
            wineTimesClicked++;

            // Calls the matching function and tells it how many times it has been clicked
            wineGlassClick(wineTimesClicked);
        }

        // A programmer made function that uses a switch statement to check how many times it has been clicked
        // Displays text based on how many times it has been clicked
        void wineGlassClick(int clickedNumber)
        {
            switch (clickedNumber)
            {
                case 1:
                    narratorLabel.Text = "Wine Glass: The wine glass is half full and resting near the edge of the desk.  " +
                    "  (Click)";
                    break;

                case 2:
                    narratorLabel.Text = "Wine Glass: The liquid appears darker than expected, " +
                    "and a faint residue clings to the inside of the glass.    (Click)";
                    break;

                case 3:
                    narratorLabel.Text = "Wine Glass: The smell is slightly bitter—unusual for such an expensive wine.";
                    break;

                case 4:
                    narratorLabel.Text = "Wine Glass: Whatever was added to this drink was meant to go unnoticed." +
                    " \n Wine Glass saved as evidence";

                    // Records that the evidence has been found in the file
                    File.AppendAllText(filePath, realEvidence[0] + Environment.NewLine);

                    // Records that the evidence has been found (sets it at true)
                    wineFound = true;

                    // If all of the evidence has been found
                    if (wineFound && windowFound && journalFound && cabinetFound)
                    {
                        accuseButton.Visible = true;
                    }

                    break;

                case 5:
                    narratorLabel.Text = "There are no more observations to be made from the wine glass";
                    break;
                default:
                    narratorLabel.Text = "There are no more observations to be made from the wine glass";
                    break;

            }
        }

        // Counts how many times the user has clicked on the wine glass
        int windowTimesClicked = 0;
        private void pictureBox2_Click(object sender, EventArgs e) // Window
        {
            // Increments each time the window is clicked
            windowTimesClicked++;

            // Calls the matching function and tells it how many times it has been clicked
            windowClicks(windowTimesClicked);
        }

        // Initializes windowFound and sets it to false
        bool windowFound = false;

        // A programmer made function that uses a switch statement to check how many times it has been clicked
        // Displays text based on how many times it has been clicked
        void windowClicks(int clickedNumber)
        {
            switch (clickedNumber)
            {
                case 1:
                    narratorLabel.Text = "Window: The window is slightly open, letting in cold air and rain.    (Click)";
                    break;

                case 2:
                    narratorLabel.Text = "Window: The latch looks damaged, as if it were forced.";
                    break;

                case 3:
                    narratorLabel.Text = "Window: Looking closer, the damage appears to be from the inside, not outside.";
                    break;

                case 4:
                    narratorLabel.Text = "Window: There are no signs of anyone entering through the window. \n Window " +
                    "saved as evidence";

                    // Records that the evidence has been found in the file
                    File.AppendAllText(filePath, fakeEvidence[0] + Environment.NewLine);

                    // Records that the evidence has been found (sets it at true)
                    windowFound = true;

                    // If all of the evidence has been found
                    if (wineFound && windowFound && journalFound && cabinetFound)
                    {
                        accuseButton.Visible = true;
                    }

                    break;

                default:
                    narratorLabel.Text = "There are no more observations to be made from the Open Window";
                    break;

            }
        }

        // Counts how many times the user has clicked on the journal
        int journalTimesClicked = 0;
        private void journalEvidence_Click(object sender, EventArgs e)
        {
            // Increments each time the journal is clicked
            journalTimesClicked++;

            // Calls the matching function and tells it how many times it has been clicked
            journalClicks(journalTimesClicked);
        }

        // Initializes journalFound and sets it to false
        bool journalFound = false;

        // A programmer made function that uses a switch statement to check how many times it has been clicked
        // Displays text based on how many times it has been clicked
        void journalClicks(int timesClicked)
        {
            switch (timesClicked)
            {
                case 1:
                    narratorLabel.Text = "Notebook: The notebook lies open on the desk, filled with neat, deliberate " +
                   "handwriting.    (Click)";
                    break;

                case 2:
                    narratorLabel.Text = "Notebook: Most entries concern legal matters and personal concerns.    (Click)";
                    break;

                case 3:
                    narratorLabel.Text = "Notebook: Some talk about how annoying his colleauge is, and some talk about his wife. " +
                    " 'Evelyn despises reading, too bad she won't read my report'.    (Click)";
                    break;

                case 4:
                    narratorLabel.Text = "Notebook: One line has been underlined heavily:\r\n“I must tell her tonight.”\r\n ";
                    break;

                case 5:
                    narratorLabel.Text = "Notebook: You reread the note. Whoever “her” " +
                    "is, the timing of this message feels important. \n Notebook saved as evidence";

                    // Records that the evidence has been found in the file
                    File.AppendAllText(filePath, realEvidence[2] + Environment.NewLine);

                    // Records that the evidence has been found (sets it at true)
                    journalFound = true;

                    // If all of the evidence has been found
                    if (wineFound && windowFound && journalFound && cabinetFound)
                    {
                        accuseButton.Visible = true;
                    }
                    break;

                default:
                    narratorLabel.Text = "Notebook: There are no more observations to " +
                    "be made from the notebook.";
                    break;
            }
        }

        // Counts how many times the user has clicked on the cabinet
        int cabinetTimesClicked = 0;
        private void pictureBox2_Click_1(object sender, EventArgs e) // Medical Cabinet
        {
            // Increments each time the cabinet is clicked
            cabinetTimesClicked++;

            // Calls the matching function and tells it how many times it has been clicked
            cabinetClicks(cabinetTimesClicked);

        }

        // Initializes cabinetFound and sets it to false
        bool cabinetFound = false;

        // A programmer made function that uses a switch statement to check how many times it has been clicked
        // Displays text based on how many times it has been clicked
        void cabinetClicks(int timesClicked)
        {
            switch (timesClicked)
            {
                case 1:
                    narratorLabel.Text = "Medical Cabinet: The wall-mounted medical cabinet contains " +
                "prescription bottles and research samples.    (Click)";
                    break;
                case 2:
                    narratorLabel.Text = "Medical Cabinet: A digital access log is clipped inside the door.    (Click)";
                    break;
                case 3:
                    narratorLabel.Text = "Medical Cabinet: One entry stands out: a medication was removed " +
                    "shortly before Dr. Hale’s death. \n Medical Cabinet saved as evidence.";

                    // Records that the evidence has been found in the file
                    File.AppendAllText(filePath, realEvidence[3] + Environment.NewLine);

                    // Records that the evidence has been found (sets it at true)
                    cabinetFound = true;

                    // If all of the evidence has been found
                    if (wineFound && windowFound && journalFound && cabinetFound)
                    {
                        accuseButton.Visible = true;
                    }
                    break;
                default:
                    narratorLabel.Text = "Medical Cabinet: There are no more observations to " +
                    "be made from the Medical Cabinet.";
                    break;
            }
        }

        // Initializes the accuseForm
        accuseForm accuseForm = new accuseForm();

        // Shows the accuse form and hides this form
        private void accuseButton_Click(object sender, EventArgs e)
        {
            accuseForm.Show();
            this.Hide();
        }
    }
}
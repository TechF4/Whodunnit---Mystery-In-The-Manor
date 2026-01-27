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
using System.IO;

namespace Final_Project_Whodunnit
{
    public partial class suspectsForm : Form
    {

        public suspectsForm()
        {
            InitializeComponent();
        }

        // The file where the evidence recorded is read
        string filePath = @"C:\Users\techn\OneDrive\Desktop\whodunnitGame.txt";

        // Sets all of the evidences found to false after intializing them
        bool wineFound = false;
        bool windowFound = false;
        bool journalFound = false;
        bool logFound = false;

        // Reads the evidence file and displays what has been collected
        private void LoadEvidenceFromFile()
        {

            // If file doesn't exist, nothing to show
            if (!File.Exists(filePath))
            {
                return;
            }

            // Read all evidence lines
            string[] lines = File.ReadAllLines(filePath);

            // Loop through each line and set labels, if any of the evidence is found the bool for it turns true
            for (int i = 0; i < lines.Length; i++)
            {
                string evidence = lines[i];

                if (evidence == "Wine Glass")
                {
                    wineFound = true;
                }
                else if (evidence == "Journal")
                {
                    journalFound = true;
                }
                else if (evidence == "Medical Log")
                {
                    logFound = true;
                }
                else if (evidence == "Open Window")
                {
                    windowFound = true;
                }
            }
        }

        // Hides this form
        private void closeButton_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "";
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Sets the two bools to false after initializing them 
        // This was very important for the control flow of the story
        bool journalTalkedEvelyn = false;
        bool logTalkedEvelyn = false;

        private void talkToEvelyn_Click(object sender, EventArgs e)
        {
            // If the journal is found and user has not talked to Evelyn about it yet
            if (journalFound && !journalTalkedEvelyn)
            {
                // Displays the text
                narratorLabel.Text = "“He told me he wanted to talk that night,” she admits after a " +
                    "pause.\r\n“I didn’t know it would be our last conversation.”\r\n";

                // Turns this bool to true so that the user doesn't get this info again
                journalTalkedEvelyn = true;

                return;
            }

            // If the log is found, user has talked to Evelyn about the journal, but has not talked about the log yet
            if (logFound && journalTalkedEvelyn && !logTalkedEvelyn)
            {
                // Displays the text
                narratorLabel.Text = "At the mention of the medical cabinet, Evelyn stiffens slightly.\r\n“I" +
                    " had access for emergencies only,” she says.\r\n“That doesn’t mean I used it.”\r\n";

                // Turns this bool to true so that the user doesn't get this info again
                logTalkedEvelyn = true;

                return;
            }

            // If the wine and log is found and the user has talked to Evelyn about the log
            if ((wineFound && logFound) && logTalkedEvelyn)
            {
                // Displays the text
                narratorLabel.Text = "At the mention of the wine glass and Digitalis She exhales slowly.\r\n“I " +
                    "don’t see how any of this matters,” she " +
                    "says, a little too quickly.\r\n“You’re reading into things that don’t concern you.”\r\n";

                return;
            }

            // Default text when no evidence has been discovered
            narratorLabel.Text = "“Leonard was… difficult at times,” she says carefully.\r\n“But" +
               " I loved him. I would never harm him.”\r\n";

        }

        // Button to examine Evelyn
        private void examineEvelyn_Click(object sender, EventArgs e)
        {
            // Displays the text
            narratorLabel.Text = "Evelyn Hale sits calmly, her posture controlled and deliberate.\r\nShe" +
                " appears composed, though her eyes avoid yours whenever the conversation " +
                "turns personal.\r\nShe shows no visible signs of distress—but restraint can hide many things.\r\n";
        }



        // Button to Examine Marcus
        private void examineMarcus_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "Marcus Hale stands with his arms crossed, tension obvious in his posture.\r\nHe " +
                "looks exhausted and angry, as though the events of the night are still replaying in his mind.\r\n " +
                "He has mud on his shoes...";
        }

        // Initializes and sets the variable to false (IMPORTANT for control flow)
        bool journalTalkedMarcus = false;

        private void talkToMarcus_Click(object sender, EventArgs e)
        {
            // If the journal is found and the user has not yet talked to Marcus about it
            if (journalFound && !journalTalkedMarcus)
            {
                // Displays the text
                narratorLabel.Text = "When the journal is mentioned: “Dad was secretive lately,” he mutters.\r\n“I" +
                    " figured it was about " +
                    "money or control. It always is.”\r\n";

                // Sets the variable to true 
                journalTalkedMarcus = true;

                return;
            }

            // If the user has found the window and talked to Marcus about the journal
            if (windowFound && journalTalkedMarcus)
            {
                // Displays the text
                narratorLabel.Text = "“I noticed that window earlier,” Marcus says.\r\n“It was already open before" +
                    " things went bad.”\r\n";

                return;
            }

            // Default text when no evidence has been discovered
            narratorLabel.Text = "“Yeah, we argued,” he admits.\r\n“But people argue all the time. That doesn’t " +
                "make me a murderer.”\r\n";

        }




        // Button to examine Nina
        private void examineNina_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "Dr. Brooks maintains a professional demeanor, though fatigue lines " +
                "her face.\r\nHer expression sharpens whenever the investigation turns toward Hale’s research.\r\n";
        }

        // Initializes and sets the variable to false (IMPORTANT for control flow)
        bool wineTalkedNina = false;

        private void talkToNina_Click(object sender, EventArgs e)
        {
            // If the wine is found and the user has not yet asked about the wine to Nina
            if (wineFound && !wineTalkedNina)
            {
                narratorLabel.Text = " “Poison in wine?” she repeats.\r\n“If that’s true, then whoever did this " +
                    "wanted it to look… quiet.”\r\n";

                // Turns this variable to true
                wineTalkedNina = true;

                return;
            }

            // If the log is found and the user has talked to Nina about the wine
            if (logFound && wineTalkedNina)
            {
                narratorLabel.Text = " “Yes, I know what Digitalis is,” she admits.\r\n“So do many researchers. " +
                    "Knowledge isn’t the same as access.”\r\n";
                return;
            }

            // Default text when no evidence has been discovered
            narratorLabel.Text = "“Leonard and I disagreed,” she says.\r\n“But professionally. Not violently.”\r\n";
        }




        // Button to examine Oliver
        private void examineOliver_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "Oliver Grant stands straight, hands folded neatly in front of " +
                "him.\r\nHis expression is solemn, shaped by years of quiet service.\r\n";
        }

        // Initializes and sets the variable to false (IMPORTANT for control flow)
        bool wineTalkedOliver = false;

        private void talkToOliver_Click(object sender, EventArgs e)
        {
           // If the wine is found but the user has not talked to Oliver about the wine yet
            if (wineFound && !wineTalkedOliver)
            {
                narratorLabel.Text = " “I did not touch the wine after it was poured,” he says firmly.\r\n“I " +
                    "would remember if I had.”\r\n";

                // Turns this variable to true
                wineTalkedOliver = true;
                return;
            }

            // If the log is found and the user has talked to Oliver about the wine
            if (logFound && wineTalkedOliver)
            {
                narratorLabel.Text = " “I do not have access to the medical cabinet,” Oliver says.\r\n“That " +
                    "was strictly controlled.”\r\n";
                return;
            }

            // Default text when no evidence has been discovered
            narratorLabel.Text = "“Dinner was served at half past nine,” Oliver explains.\r\n“After that, " +
               "Dr. Hale took his glass upstairs.”\r\n";
        }

        private void suspectsForm_Load(object sender, EventArgs e)
        {

        }

        // When the suspectForm is activated
        private void suspectsForm_Activated(object sender, EventArgs e)
        {
            LoadEvidenceFromFile();
        }
    }
}

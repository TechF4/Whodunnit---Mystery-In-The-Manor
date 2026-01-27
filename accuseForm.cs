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
    public partial class accuseForm : Form
    {
        public accuseForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Closes the whole game
            Application.Exit();
        }

        // Function for if the user gets it right
        void goodEnding()
        {
            // Displays the ending message
            finaleLabel.Text = "You have accused the correct person. It was infact Evelyn Hale who killed -- her " +
                "husband -- Leonard Hale. He had changed his will, and Evelyn did not like this. " +
                "Your title has changed now to... The greatest detective ever (after " +
                "Sherlock Holmes of course). You get the good ending. You may close this game now by clicking" +
                " on the The End button.";
            closeEverything();
        }

        // Function for if the user gets it wrong
        void badEnding()
        {
            // Displays the ending message
            finaleLabel.Text = "You have failed to accuse the correct person, and your detective license" +
                " has been taken away from you... You get the band ending. You may close this game by clicking on" +
                " the The End button.";
            closeEverything();
        }

        // Function to make all of the choice buttons invisible and the final text and exit button to be visible
        void closeEverything()
        {
            evelynButton.Visible = false;
            marcusButton.Visible = false;
            ninaButton.Visible = false;
            oliverButton.Visible = false;

            finaleLabel.Visible = true;
            closeButton.Visible = true;
        }

        // Evelyn was the murderer
        private void evelynButton_Click(object sender, EventArgs e)
        {
            goodEnding();
        }

        private void marcusButton_Click(object sender, EventArgs e)
        {
            badEnding();
        }

        private void ninaButton_Click(object sender, EventArgs e)
        {
            badEnding();
        }

        private void oliverButton_Click(object sender, EventArgs e)
        {
            badEnding();
        }
    }
}

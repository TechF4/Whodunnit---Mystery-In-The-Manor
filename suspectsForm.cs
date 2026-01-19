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
    public partial class suspectsForm : Form
    {
        public suspectsForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "";
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void talkToEvelyn_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "“Leonard was… difficult at times,” she says carefully.\r\n“But" +
                " I loved him. I would never harm him.”\r\n";

            // With file handling, make compoud if statements so when evidence is discovered she will speak more
        }

        private void examineEvelyn_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "Evelyn Hale sits calmly, her posture controlled and deliberate.\r\nShe" +
                " appears composed, though her eyes avoid yours whenever the conversation " +
                "turns personal.\r\nShe shows no visible signs of distress—but restraint can hide many things.\r\n";
        }

        private void examineMarcus_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "Marcus Hale stands with his arms crossed, tension obvious in his posture.\r\nHe " +
                "looks exhausted and angry, as though the events of the night are still replaying in his mind.\r\n " +
                "He has mud on his shoes...";
        }

        private void talkToMarcus_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "“Yeah, we argued,” he admits.\r\n“But people argue all the time. That doesn’t " +
                "make me a murderer.”\r\n";
        }

        private void examineNina_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "Dr. Brooks maintains a professional demeanor, though fatigue lines " +
                "her face.\r\nHer expression sharpens whenever the investigation turns toward Hale’s research.\r\n";
        }

        private void talkToNina_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "“Leonard and I disagreed,” she says.\r\n“But professionally. Not violently.”\r\n";
        }

        private void examineOliver_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "Oliver Grant stands straight, hands folded neatly in front of " +
                "him.\r\nHis expression is solemn, shaped by years of quiet service.\r\n";
        }

        private void talkToOliver_Click(object sender, EventArgs e)
        {
            narratorLabel.Text = "“Dinner was served at half past nine,” Oliver explains.\r\n“After that, " +
                "Dr. Hale took his glass upstairs.”\r\n";
        }
    }
}

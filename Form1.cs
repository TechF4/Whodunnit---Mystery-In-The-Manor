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
        string[] realEvidence = {"Digitalis" };
        string[] fakeEvidence = {"Muddy Shoes", "Open Window" };


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

        victimForm victimForm = new victimForm();

        private void victimButton_Click(object sender, EventArgs e)
        {
            victimForm.Show();
        }
    }
}

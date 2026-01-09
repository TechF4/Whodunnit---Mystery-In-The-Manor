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
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstImage.Visible = false;
            titleLabel.Visible = false; 
            startButton.Visible = false;

            beginButton.Visible = true;
            storyLabel.Visible = true;
            storyLabel.Text += "Ravenwood Manor sits on the edge of town, isolated and silent beneath a relentless storm." +
                "\r\n\r\nLate last night, Dr. Leonard Hale, a renowned scientist and wealthy estate owner, was found " +
                "dead in his private study. The door was locked from the inside. There were no signs of a " +
                "struggle.\r\n\r\nAt first glance, it appeared to be a natural death. However, inconsistencies quickly " +
                "raised suspicion. An open window, a half-finished glass of wine, and a recently altered will suggest " +
                "something far more sinister.\r\n\r\nOnly four people were inside the manor at the time of death. Each " +
                "had access. Each had a reason to lie.\r\n\r\nYou have been called in to investigate.\r\n\r\nSearch the " +
                "rooms. Examine objects carefully. Interview the suspects.\r\n\r\nSome clues will reveal the truth. " +
                "Others may lead you astray.\r\nIn the end, only logic will uncover the killer.";

        }

        private void firstImage_Click(object sender, EventArgs e)
        {

        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

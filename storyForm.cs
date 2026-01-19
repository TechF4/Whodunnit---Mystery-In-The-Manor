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

    public partial class storyForm : Form
    {
        public storyForm()
        {
            InitializeComponent();

            storyLabel.Text = "How to play: \n The victim and suspects buttons give you more information about them. " +
                "The evidence form will have the evidence/clue that you already found shown. Once you have discovered " +
                "all of the evidence/clues, you will be presented with the decision to pick who you think " +
                "did it. Be careful to not select the wrong person, there will be consequences... Hint: Once you have found " +
                "new evidence, go back and check with the suspects.\r\n" +
                "Not every clue tells the truth.\r\nSome evidence exists only to distract you.\r\nFocus on " +
                "opportunity, access, and timing—not just motive.\r\n";
        }

        

        private void storyForm_Load(object sender, EventArgs e)
        {

        }

        private void storyLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

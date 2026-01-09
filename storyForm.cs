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
        }

        private void storyForm_Load(object sender, EventArgs e)
        {

        }

        private void storyLabel_Click(object sender, EventArgs e)
        {
            storyLabel.Text = " Dr. Leonard Hale is found dead in his" +
                " locked study during a storm. Four suspects were in " +
                "the mansion that night: his wife Evelyn, his son Marcus," +
                " his colleague Dr. Nina Brooks, and the butler Oliver Grant." +
                " The player investigates rooms and objects to discover clues." +
                " Real evidence points to poisoning (Digitalis) and access" +
                " logs show who could have taken it. Fake evidence " +
                "(muddy shoes, open window) is placed to mislead." +
                " The player uses evidence and interviews to identify " +
                "the killer.";
        }
    }
}

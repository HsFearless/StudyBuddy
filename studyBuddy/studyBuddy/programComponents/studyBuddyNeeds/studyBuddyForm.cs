using studyBuddyForm.forumNeeds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddyForm.studyBuddyNeeds
{
    public partial class studyBuddyForm : Form
    {
        public studyBuddyForm()
        {
            InitializeComponent();
        }

        private void ToolBarProfileButton_Click(object sender, EventArgs e)
        {
            var profile = new userProfileForm();
            this.Hide();
            profile.ShowDialog();
            Application.Exit();
        }

        private void StudyBuddyIwantToLearnLabel_Click(object sender, EventArgs e)
        {

        }

        private void StudyBuddyFindBuddyButton_Click(object sender, EventArgs e)
        {

        }

        private void ToolBarForumButton_Click(object sender, EventArgs e)
        {
            var profile = new ForumForm();
            this.Hide();
            profile.ShowDialog();
            Application.Exit();
        }
    }
}

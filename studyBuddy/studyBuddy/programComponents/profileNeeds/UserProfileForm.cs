using studyBuddy.forumNeeds;
using studyBuddy.studyBuddyNeeds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy
{
    public partial class userProfileForm : Form
    {
        public userProfileForm()
        {
            InitializeComponent();
        }

        private void Labeltest_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void ToolBarForumButton_Click(object sender, EventArgs e)
        {
            var profile = new ForumForm();
            this.Hide();
            profile.ShowDialog();
            Application.Exit();
        }

        private void ToolBarFindBuddyButton_Click(object sender, EventArgs e)
        {
            var profile = new studyBuddyForm();
            this.Hide();
            profile.ShowDialog();
            Application.Exit();
        }

        private void ToolBarSettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void ToolBarExitButton_Click(object sender, EventArgs e)
        {

        }

        private void UserProfileNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void UserProfileUpForTeachingCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserProfileInfoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserProfileChangeAndAddPictureButton_Click(object sender, EventArgs e)
        {

        }
    }
    }
//}

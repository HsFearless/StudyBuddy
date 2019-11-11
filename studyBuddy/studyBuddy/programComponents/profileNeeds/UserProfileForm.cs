using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studyBuddy.dataNeeds;

namespace studyBuddy.programComponents.profileNeeds
{
    public partial class userProfileForm : Form
    {

        public userProfileForm()
        {
            InitializeComponent();
            loginNeeds.Auth.DoCheckCurrentUser(); //possible exception throwing
            if (CurrentUser.isLoggedIn) //unnecessary
            {
                userNameLabel.Text = CurrentUser.name;
                userProfileInfoBox.Text = CurrentUser.profileInfo;
                numberOfKarmaPointsLabel.Text = CurrentUser.karma.ToString();
                if(CurrentUser.upForTeaching == 1)
                {
                    userProfileUpForTeachingCheckbox.Checked = true;
                }
                else
                {
                    userProfileUpForTeachingCheckbox.Checked = false;
                }
                
                foreach (string interest in CurrentUser.interests)
                {
                    Label interestsLabel = new Label();
                    interestsLabel.AutoSize = true;
                    interestsLabel.Text = interest;
                    userInterestsFlowLayoutPanel.Controls.Add(interestsLabel);
                }
            }
            //commented because that popup was super annoying
            /*string test = "";
            users = DataFetcher.GetUsers();
            foreach (User user in users)
                test += user.ToString(full: true) + '\n';
            MessageBox.Show(test);*/
        }
        

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void ToolBarForumButton_Click(object sender, EventArgs e)
        {
            var profile = new forumNeeds.ForumForm();
            this.Hide();
            profile.ShowDialog();
            Application.Exit();
        }

        private void ToolBarFindBuddyButton_Click(object sender, EventArgs e)
        {
            var profile = new studyBuddyNeeds.studyBuddyForm();
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
        
        private void ConfirmEditingUserProfileButton_Click(object sender, EventArgs e)
        {
            confirmEditingUserProfileButton.Visible = false;
            userProfileInfoBox.ReadOnly = true;
            UserDataPusher.UpdateUserProfileInfo(userProfileInfoBox.Text);
            CurrentUser.profileInfo = userProfileInfoBox.Text;
        }

        private void UserProfileAddInterestsButton_Click(object sender, EventArgs e)
        {
            var InterestsForm = new InterestsForm(this.userInterestsFlowLayoutPanel);
            InterestsForm.Show();
        }

        private void UserProfileEditInfoBoxButton_Click(object sender, EventArgs e)
        {
            confirmEditingUserProfileButton.Visible = true;
            userProfileInfoBox.ReadOnly = false;
        }

        private void UserProfileChangeAndAddPictureButton_Click(object sender, EventArgs e)
        {

        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void KarmaPointsLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserProfileUpForTeachingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (userProfileUpForTeachingCheckbox.Checked)
            {
                UserDataPusher.UpdateIfUserUpForTeaching(1);
                CurrentUser.upForTeaching = 1;
            }
            else
            {
                UserDataPusher.UpdateIfUserUpForTeaching(0);
                CurrentUser.upForTeaching = 0;
            }
                
        }
    }
    }
//}

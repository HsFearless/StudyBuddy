using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studyBuddy.programComponents;
using studyBuddy.dataNeeds;
using studyBuddy.programComponents.profileNeeds;

namespace studyBuddy.programComponents.studyBuddyNeeds
{
    public partial class studyBuddyForm : Form
    {
        public studyBuddyForm()
        {
            InitializeComponent();
        }

        private void ToolBarProfileButton_Click(object sender, EventArgs e)
        {
            var profile = new profileNeeds.userProfileForm();
            this.Hide();
            profile.ShowDialog();
            Application.Exit();
        }

        private void StudyBuddyIwantToLearnLabel_Click(object sender, EventArgs e)
        {

        }

        private void StudyBuddyFindBuddyButton_Click(object sender, EventArgs e)
        {
            availableBuddiesLabel.Visible = true;
            availableBuddiesFlowLayoutPanel.Controls.Clear(); //clearing what was in panel before

            List<User>  users = DataFetcher.GetUsersAsList();
            var userInterests = DataFetcher.GetUserInterestsAsStringList();
            var allInterests = DataFetcher.GetInterestsAsStringList();

            var subjectID = (from interest in allInterests // interest[1] - name of interest
                             where interest[1] == chooseWhatToLearnComboBox.Text
                             select Int32.Parse(interest[0]));

            //get users who have that interest and are up for teaching
                var matchedUsers = from user in users
                                   join userInterest in userInterests
                                   on user.id equals Convert.ToInt32(userInterest[0]) // userInterest[0] - userID
                                   where user.upForTeaching == 1
                                   where Convert.ToInt32(userInterest[1]) == subjectID.FirstOrDefault<int>()
                                   where user.id != CurrentUser.id
                                   select user.name;

                foreach (var matchedUser in matchedUsers)
                {
                    Label name = new Label();
                    name.AutoSize = true;
                    name.Text = matchedUser;
                    availableBuddiesFlowLayoutPanel.Controls.Add(name);
                }
        }

        private void ToolBarForumButton_Click(object sender, EventArgs e)
        {
            var profile = new forumNeeds.ForumForm();
            this.Hide();
            profile.ShowDialog();
            Application.Exit();
        }

    }
}

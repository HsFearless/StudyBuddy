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
        public Interests interests = DataFetcher.GetInterests();
        delegate IEnumerable<int> IdGetter<T>(string name, T items); //^generics in delegate
        IdGetter<Interests> getId = GetID; 
        public studyBuddyForm()
        {
            InitializeComponent();
        }

        private void ToolBarProfileButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToProfileFrom(this);
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


            var subjectID = getId(chooseWhatToLearnComboBox.Text,interests); //^delegate usage

            //get users who have that interest and are up for teaching
                var matchedUsers = from user in users
                                   join userInterest in userInterests
                                   on user.id equals Convert.ToInt32(userInterest[0]) // userInterest[0] - userID
                                   where user.upForTeaching == 1
                                   where Convert.ToInt32(userInterest[1]) == subjectID.FirstOrDefault<int>() // userInterest[1] - subjectID
                                   where user.id != CurrentUser.id
                                   select user.name;

            Action<IEnumerable<string>> showUsers = delegate (IEnumerable<string> Users) //^anonymous method
            {
                foreach (var user in Users)
                {
                    Label name = new Label();
                    name.AutoSize = true;
                    name.Text = user;
                    availableBuddiesFlowLayoutPanel.Controls.Add(name);
                }
            };

            showUsers(matchedUsers);
               
        }

        static IEnumerable<int> GetID<T>(string name, T items) where T : Interests
        {
            var ID = from item in items
                             where item.name == name
                             select item.id;
            return ID;
        }



        private void ToolBarForumButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToForumFrom(this);
        }

    }
}

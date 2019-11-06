using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy.programComponents.settingsNeeds
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void FakeSessionButton_Click(object sender, EventArgs e)
        {
            CurrentUser.id = -1;
            loginNeeds.Auth.SetLoggedOut();
            MessageBox.Show("done");
        }

        private void ToolBarForumButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToForumFrom(this);
        }

        private void ToolBarProfileButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToProfileFrom(this);
        }

        private void ToolBarFindBuddyButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToStudyBuddyFrom(this);
        }

        private void ToolBarHelpButton_Click(object sender, EventArgs e)
        {

        }

        private void ToolBarSettingsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToSettingsFrom(this);
        }

        private void ToolBarExitButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToExitFrom(this);
        }
    }
}

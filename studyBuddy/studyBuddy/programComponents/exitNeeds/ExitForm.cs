using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy.programComponents.exitNeeds
{
    public partial class exitForm : Form
    {
        public exitForm()
        {
            InitializeComponent();
        }

        private void ExitForm_Load(object sender, EventArgs e)
        {

        }

        private void ToolBarProfileButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToProfileFrom(this);
        }

        private void ToolBarForumButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToForumFrom(this);
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

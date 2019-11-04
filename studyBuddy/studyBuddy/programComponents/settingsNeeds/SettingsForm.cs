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
            var profile = new forumNeeds.ForumForm();
            this.Hide();
            profile.ShowDialog();
            Application.Exit();
        }
    }
}

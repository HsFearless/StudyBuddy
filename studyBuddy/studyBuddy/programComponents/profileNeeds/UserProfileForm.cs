using studyBuddy.forumNeeds;
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
            var profile = new forumForm();
            this.Hide();
            profile.ShowDialog();
            Application.Exit();
        }
    }
    }
//}

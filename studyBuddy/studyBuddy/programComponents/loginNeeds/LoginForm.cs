using studyBuddyForm.dataNeeds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddyForm.programComponents.loginNeeds
{
    public partial class loginForm : Form
    {
        private bool skipLogin = false;
        private UserDataFetcher dataFetcher = new UserDataFetcher();
        public loginForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var user = textUsername.Text;
            var pass = textPassword.Text;
            if (skipLogin || Auth.LogIn(dataFetcher, user, pass))
            {
                MessageBox.Show("Hi\n" +
                    "You are in");
                Auth.SetLoggedIn(dataFetcher);
                this.Hide();
                var profile = new userProfileForm();
                profile.ShowDialog();
                //this.Visible = true;
                Application.Exit();
            }
            else
            {
                var pressedButton = MessageBox.Show("No hello for you.\n" +
                    $" {Auth.error.Message()}\n\n" +
                    "Want to skip login next time?", "skip?", MessageBoxButtons.YesNoCancel);
                if (pressedButton == DialogResult.Yes)
                    skipLogin = true;
            }
        }

        private void LinkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Visible = true;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textUsername.Text = UserDataFetcher.GetLastUsedUsername();
        }
    }
}

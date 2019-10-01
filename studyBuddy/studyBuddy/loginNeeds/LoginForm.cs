using studyBuddy.dataNeeds;
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
    public partial class loginForm : Form
    {
        private DataFetcher dataFetcher = new DataFetcher();
        public loginForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var user = textUsername.Text;
            var salt = dataFetcher.getSalt(user);
            if (user.Length > 0) {
                MessageBox.Show($"Hi, your salt is: {((salt.Length > 0) ? salt : "wtf idk")}");
            }
            MessageBox.Show("Hi");
            var profile = new UserProfileForm();
            this.Hide();
            profile.ShowDialog();
            this.Visible = true;        }

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

        }
    }
}

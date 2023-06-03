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
using studyBuddy.programComponents;

namespace studyBuddy.programComponents.loginNeeds
{
    public partial class loginForm : Form
    {
        private bool skipLogin = false;
        public bool success = false;
        private UserDataFetcher dataFetcher = new UserDataFetcher();
        public bool itWasExpectedExit { get; private set; } = false;
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
                //Auth.SetLoggedIn(dataFetcher);
                ShowAfterLoginScreen();
            }
            else
            {
                var pressedButton = MessageBox.Show("No hello for you.\n" +
                    $" {Auth.error.Message()}\n\n");
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
            //Method();
            this.textUsername.Text = UserDataFetcher.GetLastUsedUsername();
        }

        private void ShowAfterLoginScreen()
        {


            success = true;
            this.Close();
            /*
             * NavigationHelper.SwitchToProfileFrom(this);
            //this.Visible = true;
            this.itWasExpectedExit = true;
            Application.Exit();
            */



        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.itWasExpectedExit = true; //exceptions do not close forms this way
        }
        private void Method()
        {
            //try
            //{
                if (Auth.LogInUsingSession(new ProgressBar()))
                    ShowAfterLoginScreen();
                else
                    MessageBox.Show(Auth.error.Message() + " " + Auth.messageToOutterWorld + $"({Auth.messageToOutterWorld.Length})");
                textUsername.Text = UserDataFetcher.GetLastUsedUsername();
            //}
            //catch
            //{
                //throw;
            //}
        }


        private void SesijaButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}

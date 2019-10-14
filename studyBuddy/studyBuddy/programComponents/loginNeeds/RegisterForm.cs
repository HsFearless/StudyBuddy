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
    public partial class RegisterForm : Form
    {
        private UserDataFetcher userData = new UserDataFetcher();
        private PasswordHasher passwordHasher = new PasswordHasher();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            /*var salt = passwordHasher.newSalt();
            string saltas = Convert.ToBase64String(salt);
            string res1 = passwordHasher.hash("password", saltas);
            string res2 = passwordHasher.hash("password", saltas);
            /*MessageBox.Show($"{res1}\n\n" +
                $"po converTo64 ir convertFrom64 ar sutapo? - {(res1.Equals(res2) ? "taip" : "ne")}");
            labelTest.Text = $"{res1}\n\n" +
                $"po converTo64 ir convertFrom64 ar sutapo? - {(res1.Equals(res2) ? "taip" : "ne")}" +
                $"\n" +
                $"{res1}\n{res2}";
            */
            if (Auth.register(userData, textUsername.Text, textEmail.Text, textPassword.Text, textPassword2.Text))
                MessageBox.Show($"congratulations {textUsername.Text}");
            else
            {
                MessageBox.Show($"error: {Auth.error.no}  {Auth.error.message()}");
            }
            var mysql = new dataNeeds.MysqlHandler();
            mysql.testSelectAllUsers();
            MessageBox.Show(mysql.messageToOutterWorld + mysql.lastError);

            //MessageBox.Show(passwordHasher.newSalt());
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

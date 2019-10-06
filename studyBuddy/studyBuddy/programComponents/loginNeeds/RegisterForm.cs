using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy.programComponents.loginNeeds
{
    public partial class RegisterForm : Form
    {

        private PasswordHasher passwordHasher = new PasswordHasher();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var salt = passwordHasher.newSalt();
            string saltas = Convert.ToBase64String(salt);
            string res1 = passwordHasher.hash("password", saltas);
            string res2 = passwordHasher.hash("password", saltas);
            /*MessageBox.Show($"{res1}\n\n" +
                $"po converTo64 ir convertFrom64 ar sutapo? - {(res1.Equals(res2) ? "taip" : "ne")}");*/
            labelTest.Text = $"{res1}\n\n" +
                $"po converTo64 ir convertFrom64 ar sutapo? - {(res1.Equals(res2) ? "taip" : "ne")}" +
                $"\n" +
                $"{res1}\n{res2}";
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
    }
}

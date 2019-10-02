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
            string res1 = passwordHasher.hash("password", salt);
            string saltas = Convert.ToBase64String(salt);
            salt = Convert.FromBase64String(saltas);
            string res2 = passwordHasher.hash("password", salt);
            /*MessageBox.Show($"{res1}\n\n" +
                $"po converTo64 ir convertFrom64 ar sutapo? - {(res1.Equals(res2) ? "taip" : "ne")}");*/
            labelTest.Text = $"{res1}\n\n" +
                $"po converTo64 ir convertFrom64 ar sutapo? - {(res1.Equals(res2) ? "taip" : "ne")}";
            var mysql = new MysqlHandler();
            mysql.testSelectAllUsers();
            MessageBox.Show(mysql.messageToOutterWorld + mysql.lastError);

            //MessageBox.Show(passwordHasher.newSalt());
        }
    }
}

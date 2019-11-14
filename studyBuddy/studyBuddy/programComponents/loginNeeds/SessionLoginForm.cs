using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace studyBuddy.programComponents.loginNeeds
{
    public partial class SessionLoginForm : Form
    {
        private Thread logInThread = null;
        public bool success = false;
        public SessionLoginForm()
        {
            InitializeComponent();
        }

        private void SessionLoginForm_Load(object sender, EventArgs e)
        {
            //logInThread = new Thread();
            //SessionLoginFormLogic.LoginThreadsStartFor(this, this.progressBar1);
            success = Auth.LogInUsingSession(this.progressBar1);
            if (success)
                this.Close();
            else
            {
                MessageBox.Show(Auth.error.Message());
                this.Close();
            }
        }

        private void SessionLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //success = SessionLoginFormLogic.SessionSuccess();
            //SessionLoginFormLogic.Exit(wait: false);
        }
    }
}

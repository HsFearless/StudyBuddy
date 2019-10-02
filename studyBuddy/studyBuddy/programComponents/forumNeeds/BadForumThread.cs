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
    public partial class createProblemForm : Form
    {

        forumForm forumForm;
        public createProblemForm(forumForm forumForm)
        {
            this.forumForm = forumForm;
            InitializeComponent();
        }

        private void CreateProblemForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Co_Click(object sender, EventArgs e)
        {
            this.Hide();
            problemsNameTextBox.ResetText();
            problemsDescriptionTextBox.ResetText();
            forumForm.Show();
        }
    }
}

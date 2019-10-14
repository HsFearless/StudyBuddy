using studyBuddy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy.forumNeeds
{
    public partial class CreateProblem : Form
    {
       public ForumForm forumForm;

        public CreateProblem(ForumForm forumForm)
        {
            this.forumForm = forumForm;
            InitializeComponent();
        }

        private void CreateProblem_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            forumForm.AddNewProblem(problemsNameTextBox.Text, SubjectComboBox.Text, descriptionTextBox.Text);
            CommentsManager.AddNewFile(problemsNameTextBox.Text + ".txt");
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

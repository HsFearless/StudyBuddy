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
using studyBuddy.dataNeeds;

namespace studyBuddy.programComponents.forumNeeds
{
    public partial class CreateProblem : Form
    {
        public ForumForm forumForm;
        private Subjects subjects;

        public CreateProblem(ForumForm forumForm)
        {
            this.StartPosition = FormStartPosition.CenterParent;

            this.forumForm = forumForm;
            this.subjects = forumForm.subjects;
            InitializeComponent();

            foreach(var subject in subjects)
            {
                SubjectComboBox.Items.Add(subject);
            }


        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //this.Hide(); //#might need to change to this.close() or something //but it works somehow
            if (ForumManager.NewProblem(problemsNameTextBox.Text,
                (Subjects.Subject)SubjectComboBox.SelectedItem,
                descriptionTextBox.Text, forumForm.forum))
                this.Close(); //#without it it also works
            else
            {
                this.Visible = true;
                System.Windows.Forms.MessageBox.Show(ForumManager.error.Message());
            }

            //forumForm.AddNewProblem(problemsNameTextBox.Text, SubjectComboBox.Text, descriptionTextBox.Text);
            //CommentsManager.AddNewFile(problemsNameTextBox.Text + ".txt");



        }

        private void SubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CreateProblem_Load(object sender, EventArgs e)
        {

        }

        private void CreateProblem_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

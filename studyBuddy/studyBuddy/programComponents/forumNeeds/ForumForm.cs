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
using studyBuddy.programComponents;

namespace studyBuddy.programComponents.forumNeeds
{
    public partial class ForumForm : Form
    {
        private bool sortByNameAscending = true;
        private bool sortBySubjectAscending = true;
        public Subjects subjects = DataFetcher.GetSubjects();
        public ForumContent forum = DataFetcher.GetForum();

        public ForumForm()
        {
            InitializeComponent();

            
        }

        private void ForumForm_Load(object sender, EventArgs e)
        {
            var forumContent = forum.GetPostsBySubjects();
            foreach (var subject in forumContent)
            {
                foreach (var forumRow in subject.forumPosts)
                {
                    problemsGridView.Rows.Add(0, forumRow.name, subject.name, forumRow.description, forumRow.id);
                    CommentsManager.AddNewFile(forumRow.name + ".txt");
                }
            }

            foreach (var subject in subjects)
            {
                filterSubjectsComboBox.Items.Add(subject);
            }

        }

        private void SortByNameButton_Click(object sender, EventArgs e)
        {
            if (sortByNameAscending)
            {
                problemsGridView.Sort(problemsGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                sortByNameAscending = !sortByNameAscending;
            }
            else
            {
                problemsGridView.Sort(problemsGridView.Columns[0], System.ComponentModel.ListSortDirection.Descending);
                sortByNameAscending = !sortByNameAscending;
            }
        }

        private void AddProblemButton_Click(object sender, EventArgs e)
        {
            var createProblemForm = new CreateProblem(this);
            createProblemForm.ShowDialog(this);
        }

        public void AddNewProblem(String name, String subject, String description)
        {
            problemsGridView.Rows.Add(name, subject, description);
        }

        private void SortBySubjectButton_Click(object sender, EventArgs e)
        {

            if (sortBySubjectAscending)
            {
                problemsGridView.Sort(problemsGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                sortBySubjectAscending = !sortBySubjectAscending;
            }
            else
            {
                problemsGridView.Sort(problemsGridView.Columns[1], System.ComponentModel.ListSortDirection.Descending);
                sortBySubjectAscending = !sortBySubjectAscending;
            }

            
        }

        private void ProblemsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.problemsGridView.CurrentRow.Cells[0].Value == null)
                return;
            long forumPostId = Convert.ToInt64(problemsGridView.CurrentRow.Cells["Id"].Value);
            var problem = forum[forumPostId];
            if (problem != null)
            {
                ProblemDiscussion problemDiscussion = new ProblemDiscussion(problem);
                problemDiscussion.ShowDialog();
            }
            else
                MessageBox.Show("Sorry, it is an error. Try other choosing other post");
            
        }

        private void ToolBarProfileButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToProfileFrom(this);
        }

        private void ToolBarFindBuddyButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToStudyBuddyFrom(this);
        }

        private void FilterSubjectsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterSubjectsComboBox.SelectedIndex < 0)
                return;
            Subjects.Subject subject = (Subjects.Subject)filterSubjectsComboBox.SelectedItem;
            var forumContent = forum.GetPostsWhereSubjectIs(subject);

            problemsGridView.Rows.Clear();
            foreach (var forumRow in forumContent)
            {
                problemsGridView.Rows.Add(forumRow.name, forumRow.subject, forumRow.description);
                CommentsManager.AddNewFile(forumRow.name + ".txt");
            }
            textBoxSearch.Text = "";
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string text = textBoxSearch.Text;
            //filtruoti

            var forumContent = forum.GetPostsWhereContains(text);

            problemsGridView.Rows.Clear();

            foreach (var forumRow in forumContent)
            {

                problemsGridView.Rows.Add(forumRow.name, forumRow.subject, forumRow.description);
                CommentsManager.AddNewFile(forumRow.name + ".txt");
            }
            filterSubjectsComboBox.SelectedIndex = -1;
        }

        private void ProblemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToolBarSettingsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToSettingsFrom(this);

        }

        private void ToolBarForumButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToForumFrom(this);
        }

        private void ToolBarHelpButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolBarExitButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchToExitFrom(this);
        }

        private void ForumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FormConfig.FormClosingEventHandler(this);
        }
    }
}

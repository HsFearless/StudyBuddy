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
    public partial class ForumForm : Form
    {
        private bool sortByNameAscending = true;
        private bool sortBySubjectAscending = true;

        public ForumForm()
        {
            InitializeComponent();
        }

        private void ForumForm_Load(object sender, EventArgs e)
        {
            problemsGridView.Rows.Add("Pitagoras", "Math", "Turiu dvi krastine 2cm ir 15cm, kokia kita?");
            problemsGridView.Rows.Add("Lietuviu", "Foreign language", "Kas tas yr, renesansas???");
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
            createProblemForm.ShowDialog();
        }

        public void addNewProblem(String name, String subject, String description)
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
            ProblemDiscussion problemDiscussion = new ProblemDiscussion();
            problemDiscussion.problemNameLabel.Text = this.problemsGridView.CurrentRow.Cells[0].Value.ToString();
            problemDiscussion.problemDescriptionLabel.Text = this.problemsGridView.CurrentRow.Cells[2].Value.ToString();
            problemDiscussion.ShowDialog();
        }
    }
}

using studyBuddy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy.programComponents.forumNeeds
{
    public partial class ProblemDiscussion : Form
    {
        //int commentsPosition = 1;
        //public StreamWriter sw;
        //public bool fileClosed = false;
        public ForumPost forumPost;
        public ProblemDiscussion(ForumPost forumPost)
        {
            InitializeComponent();
            this.forumPost = forumPost;
            this.problemNameLabel.Text = forumPost.name;
            this.problemDescriptionLabel.Text = forumPost.description;
        }

        private void ProblemDiscussion_Load(object sender, EventArgs e)
        {
            forumPost.comments.Load(commentsPanel);
            //if (sw == null)
            //if (File.Exists(problemNameLabel.Text + ".txt") == false)
            //{
            //    sw = new StreamWriter(problemNameLabel.Text + ".txt");
            //}
            //else
            //{
            //    fileClosed = true;
            //}
        }



        private void CommentsLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddCommentButton_Click(object sender, EventArgs e)
        {
            if(forumPost.comments.Write(addCommentTextBox.Text))
            {
                forumPost.comments.LoadLast(commentsPanel);
                addCommentTextBox.ResetText();
            }
            else
                MessageBox.Show(forumPost.comments.error.Message());

        }

        private void ProblemDiscussion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (fileClosed == false)
            //{
            //    sw.Close();
            //}
        }
    }
}

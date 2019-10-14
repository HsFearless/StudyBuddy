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

namespace studyBuddyForm
{
    public partial class ProblemDiscussion : Form
    {
        int commentsPosition = 1;
        public StreamWriter sw;
        public bool fileClosed = false;
        public ProblemDiscussion()
        {
            InitializeComponent();
        }

        private void ProblemDiscussion_Load(object sender, EventArgs e)
        {
            commentsPosition = CommentsManager.LoadComments(problemNameLabel.Text, commentsPanel, commentsPosition);
            //if(sw == null)
            if (File.Exists(problemNameLabel.Text + ".txt") == false)
            {
                sw = new StreamWriter(problemNameLabel.Text + ".txt");
            }
            else
            {
                fileClosed = true;
            }
        }



        private void CommentsLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddCommentButton_Click(object sender, EventArgs e)
        {
            if (fileClosed == false)
            {
                commentsPosition = CommentsManager.WriteComment(sw, addCommentTextBox.Text, commentsPanel, commentsPosition);
                fileClosed = true; 
            }
            else
            {
                sw = File.AppendText(problemNameLabel.Text + ".txt");
                sw.WriteLine(addCommentTextBox.Text);
                //sw = new StreamWriter(problemNameLabel.Text + ".txt");
                commentsPosition = CommentsManager.WriteComment(addCommentTextBox.Text, commentsPanel, commentsPosition);
                fileClosed = true;
                sw.Close();
            }
            addCommentTextBox.ResetText();
        }

        private void ProblemDiscussion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileClosed == false)
            {
                sw.Close();
            }
        }
    }
}

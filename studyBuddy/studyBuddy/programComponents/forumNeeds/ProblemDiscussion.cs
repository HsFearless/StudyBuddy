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
        bool toUpvote = true;

        public ForumPost forumPost;
        public CommentsManager comments;
        public ProblemDiscussion(ForumPost forumPost)
        {
            InitializeComponent();
            this.forumPost = forumPost;
            this.problemNameLabel.Text = forumPost.name;
            this.problemDescriptionLabel.Text = forumPost.description;
            comments = new CommentsManager(forumPost, commentsPanel);
            comments.SuccessfullyAddedCommentEvent += SuccessfullyAddedCommentEventHandler;
            
            
        }

        public void SuccessfullyAddedCommentEventHandler(object sender, SuccessfullyAddedCommentEventArgs args)
        {
            string message =
                "Your comment: " + Environment.NewLine + args.commentText + Environment.NewLine +
                "Was successfully created at: " + args.commentUnix.ToString();
            MessageBox.Show(message);
        }

        private void ProblemDiscussion_Load(object sender, EventArgs e)
        {
            comments.Load(commentsPanel);
            votesCountLabel.Text = forumPost.votes.ToString();  //before and after vote it auto updates
            AfterUpvote();
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
            
            
                if (comments.Write(addCommentTextBox.Text))
                {
                    comments.LoadLast(commentsPanel);
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

        private void UpvoteButton_Click(object sender, EventArgs e)
        {
            if (toUpvote)
            {
                try
                {
                    if (!forumPost.Upvote())
                        MessageBox.Show(ForumManager.error.Message());
                    else
                    {
                        AfterUpvote();
                    }
                }
                catch (exceptions.DoneBefore)
                {
                    AfterUpvote();
                    MessageBox.Show("You have already upvoted it!");
                }
            }//still upvote
            else
            { //take back upvote
                if (!forumPost.TakeBackUpvote())
                    if(ForumManager.error.no == dataNeeds.ErrorCode.NOT_FOUND)
                    {
                        MessageBox.Show("Your vote did not exist");
                        AfterTakeBackUpvote();
                    }
                    else
                        MessageBox.Show(ForumManager.error.Message());
                else
                    AfterTakeBackUpvote();
            }
            
            
        }

        private void AfterTakeBackUpvote()
        {
            Button butt = upvoteButton;
            toUpvote = true;
            butt.BackColor = Color.Green;
            butt.Text = "Vote++";
            UpdateVotesLabel();
        }

        private void AfterUpvote()
        {
            Button butt = upvoteButton;
            toUpvote = false;
            butt.BackColor = Color.MediumSlateBlue;
            butt.Text = "Vote --";
            UpdateVotesLabel();
        }

        private void UpdateVotesLabel()
        {
            votesCountLabel.Text = forumPost.votes.ToString();
        }

    }
}

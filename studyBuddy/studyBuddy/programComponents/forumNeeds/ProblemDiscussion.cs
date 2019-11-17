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

            FormConfig.GetFormConfig(this);

            this.forumPost = forumPost;
            this.problemNameLabel.Text = forumPost.name;
            this.problemDescriptionLabel.Text = forumPost.description;
            this.upvoteButton = new VoteButton(forumPost);
            this.upvoteButton.Name = "upvoteButton";
            this.upvoteButton.Location = new System.Drawing.Point(7, 39);
            this.upvoteButton.Click += (o,e) => UpdateVotesLabel(); //^lambda
            this.votesGroupBox.Controls.Add(this.upvoteButton); //^events standard
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
            //AfterUpvote();
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
                    MessageBox.Show(comments.error.Message());
            
        

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
            //if (toupvote)
            //{
            //    try
            //    {
            //        if (!forumpost.upvote())
            //            messagebox.show(forummanager.error.message());
            //        else
            //        {
            //            afterupvote();
            //        }
            //    }
            //    catch (exceptions.donebefore)
            //    {
            //        afterupvote();
            //        messagebox.show("you have already upvoted it!");
            //    }
            //}//still upvote
            //else
            //{ //take back upvote
            //    if (!forumpost.takebackupvote())
            //        if (forummanager.error.no == dataneeds.errorcode.not_found)
            //        {
            //            messagebox.show("your vote did not exist");
            //            aftertakebackupvote();
            //        }
            //        else
            //            messagebox.show(forummanager.error.message());
            //    else
            //        aftertakebackupvote();
            //}


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

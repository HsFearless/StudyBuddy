using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using studyBuddy.dataNeeds;

namespace studyBuddy.programComponents.forumNeeds
{
    public class CommentsManager
    {
        internal Error error;
        public readonly ForumPost forumPost;
        public int commentsPosition { get; private set; } = 1;
        //public Panel commentsPanel;
        private List<Comment> comments;
        private Comment lastComment;
        public delegate void SuccessfullyAddedComment<T>(object sender, T args); //^generic event's delegate
        public event SuccessfullyAddedComment<SuccessfullyAddedCommentEventArgs> SuccessfullyAddedCommentEvent;  //event's declaration
        //public static ArrayList commentsTextFiles = new ArrayList();

        public CommentsManager(ForumPost forumPost)
        {
            this.forumPost = forumPost;
        }

        /*public CommentsManager(ForumPost forumPost, Panel commentsPanel)
        {
            this.forumPost = forumPost;
            this.commentsPanel = commentsPanel;
        }*/


        public static void AddNewFile(string textFilesName)
        {/*
            FileStream fs = File.Create(textFilesName);
            commentsTextFiles.Add(textFilesName);
            fs.Close();*/
        }

        public static int WriteComment(StreamWriter File, string commmentToShow, /*Panel panel,*/ int commentsPosition)
        {
            /*
            using (File)
            {
                File.WriteLine(commmentToShow, true);
                Label comment = new Label();//
                comment.BackColor = Color.White;//
                comment.MinimumSize = new Size(765, 15);//
                comment.AutoSize = true;//
                comment.Text = commmentToShow;//
                Point position = new Point(commentsPosition, 30 * commentsPosition);//
                comment.Location = position;//
                panel.Controls.Add(comment);//
                commentsPosition++;//
            }

            return commentsPosition;
            */
            
            return 0;
        }

        public bool Write(string commentToShow)
        {
            error.Clear();
            //validate
                //user
                if (!CurrentUser.isLoggedIn)
                    return error.SetErrorAndReturnFalse(ErrorCode.INVALID_SESSION);
                if (!InputValidator.ValidateId(CurrentUser.id))
                    return error.SetErrorAndReturnFalse(ErrorCode.USER_NOT_FOUND);
                //good text
                if (!InputValidator.ValidateForumProblemCommentText(commentToShow))
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_TEXT_FIELD | InputValidator.error.no);
                //valid as comment
                //first get timestamp
                long unix = DataFetcher.GetServerTimeStamp();
                Comment comment = new Comment(0, CurrentUser.id, forumPost.id, commentToShow, unix);
            //push
            if (!UserDataPusher.PushNewForumProblemComment(comment))
                return error.SetErrorAndReturnFalse(ErrorCode.PUSH_ERROR);

            //retrieve id
            this.lastComment = DataFetcher.GetCommentFromTemplate(comment); //changes only id

            comments.Add(this.lastComment);
            

            //this.LoadLast(this.commentsPanel);

            if (SuccessfullyAddedCommentEvent != null)
            {
                SuccessfullyAddedCommentEvent.Invoke(this, new SuccessfullyAddedCommentEventArgs(commentToShow, unix)); //invokes event if it has subscribers
            }

            return true;
            
        }


        public void Load(/*Panel panel*/)
        {
            return;
            commentsPosition = 1;
            comments = DataFetcher.GetCommentsAsList(forumPost.id); //this.
            foreach (Comment comment in comments)
            {

                var lComment = MakeCommentLabel(comment.content, commentsPosition);
                //panel.Controls.Add(lComment);
                commentsPosition++; //this.
            }
        }

        public void LoadLast(/*Panel*/int panel)
        {
            return;
            var lComment = MakeCommentLabel(this.lastComment.content, commentsPosition);
            //panel.Controls.Add(lComment);
            commentsPosition++;
        }

        private static int/*Label*/ MakeCommentLabel(string text, int commentsPosition)
        {
            return 0;
            
            //new label
            //Label lComment = new Label();
            //lComment.AutoEllipsis = true;
            //lComment.BackColor = Color.White;
            //lComment.MinimumSize = new Size(760, 15);
            //lComment.AutoSize = true;
            ////label text
            //lComment.Text = text;
            ////position?
            //Point position = new Point(69, 39 * commentsPosition);
            //lComment.Location = position;
            //return lComment;
            

            /*
            TextBox lComment = new TextBox();
            lComment.BackColor = Color.White;
            lComment.MaximumSize = new Size(760, 8000);
            lComment.AutoSize = false;
            //label text
            lComment.Text = text;
            //position?
            Point position = new Point(commentsPosition, 30 * commentsPosition);
            lComment.Location = position;
            lComment.ReadOnly = true;
            lComment.Multiline = true;
            lComment.HideSelection = false;
            lComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lComment.Enabled = true;
            lComment.WordWrap = true;
            return lComment;*/
        }
    }
}

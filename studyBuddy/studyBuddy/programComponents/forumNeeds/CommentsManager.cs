using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studyBuddy.dataNeeds;

namespace studyBuddy.programComponents.forumNeeds
{
    public class CommentsManager
    {
        internal Error error;
        public readonly ForumPost forumPost;
        public int commentsPosition { get; private set; } = 1;
        private List<Comment> comments;
        private Comment lastComment;
        //public static ArrayList commentsTextFiles = new ArrayList();

        public CommentsManager(ForumPost forumPost)
        {
            this.forumPost = forumPost;
        }

        public static void AddNewFile(string textFilesName)
        {/*
            FileStream fs = File.Create(textFilesName);
            commentsTextFiles.Add(textFilesName);
            fs.Close();*/
        }

        public static int WriteComment(StreamWriter File, string commmentToShow, Panel panel, int commentsPosition)
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

            return true;
            
        }


        public void Load(Panel panel)
        {
            commentsPosition = 1;
            comments = DataFetcher.GetCommentsAsList(forumPost.id); //this.
            foreach (Comment comment in comments)
            {

                var lComment = MakeCommentLabel(comment.content, commentsPosition);
                panel.Controls.Add(lComment);
                commentsPosition++; //this.
            }
        }

        public void LoadLast(Panel panel)
        {
            var lComment = MakeCommentLabel(this.lastComment.content, commentsPosition);
            panel.Controls.Add(lComment);
            commentsPosition++;
        }

        private static Label MakeCommentLabel(string text, int commentsPosition)
        {
            //new label
            Label lComment = new Label();
            lComment.BackColor = Color.White;
            lComment.MinimumSize = new Size(760, 15);
            lComment.AutoSize = true;
            //label text
            lComment.Text = text;
            //position?
            Point position = new Point(commentsPosition, 30 * commentsPosition);
            lComment.Location = position;
            return lComment;
        }
    }
}

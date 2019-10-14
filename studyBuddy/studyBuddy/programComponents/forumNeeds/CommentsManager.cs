using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy
{
    static class CommentsManager
    {
        public static ArrayList commentsTextFiles = new ArrayList();

        public static void AddNewFile(string textFilesName)
        {
            FileStream fs = File.Create(textFilesName);
            commentsTextFiles.Add(textFilesName);
            fs.Close();
        }

        public static int WriteComment(StreamWriter File, string commmentToShow, Panel panel, int commentsPosition)
        {
            using (File)
            {
                File.WriteLine(commmentToShow, true);
                Label comment = new Label();
                comment.BackColor = Color.White;
                comment.MinimumSize = new Size(765, 15);
                comment.AutoSize = true;
                comment.Text = commmentToShow;
                Point position = new Point(commentsPosition, 30 * commentsPosition);
                comment.Location = position;
                panel.Controls.Add(comment);
                commentsPosition++;
            }

            return commentsPosition;

        }

        public static int WriteComment(string commmentToShow, Panel panel, int commentsPosition)
        {

                Label comment = new Label();
                comment.BackColor = Color.White;
                comment.MinimumSize = new Size(765, 15);
                comment.AutoSize = true;
                comment.Text = commmentToShow;
                Point position = new Point(commentsPosition, 30 * commentsPosition);
                comment.Location = position;
                panel.Controls.Add(comment);
                commentsPosition++;

            return commentsPosition;

        }


        public static int LoadComments(string textFilesName, Panel panel, int commentsPosition)
        {
            using (StreamReader sr = new StreamReader(textFilesName + ".txt")) {
                String line;
                //StreamReader sr = new StreamReader(textFilesName + ".txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Label comment = new Label();
                    comment.BackColor = Color.White;
                    comment.MinimumSize = new Size(760, 15);
                    comment.AutoSize = true;
                    comment.Text = line;
                    Point position = new Point(commentsPosition, 30 * commentsPosition);
                    comment.Location = position;
                    panel.Controls.Add(comment);
                    commentsPosition++;
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            return commentsPosition;
        }
    }
}

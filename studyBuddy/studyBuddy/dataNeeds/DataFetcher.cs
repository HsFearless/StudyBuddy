using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studyBuddy.dataNeeds;

namespace studyBuddy.dataNeeds
{
    abstract class DataFetcher : DataHandler
    {
        public static List<string[]> GetSubjectsAsStringList()
        {
            var subjects = staticSource.Select("ID, name FROM " +
                MysqlHandler.tblSubjects);
            return subjects;
        }

        public static misc.Subjects GetSubjects()
        {
            return misc.Subjects.GetInstance();
        }

        public static programComponents.forumNeeds.ForumContent GetForum()
        {
            var rows = staticSource.Select("ID, name, subjectID, description, ownerID FROM " +
                MysqlHandler.tblForum);
            var post = new programComponents.forumNeeds.ForumPost[rows.Count];
            int i = 0;
            foreach (var row in rows)
            {
                long id = Convert.ToInt64(row[0]);
                string name = row[1];
                int subjectId = Convert.ToInt32(row[2]);
                string description = row[3];
                int ownerId = Convert.ToInt32(row[4]);
                var temp = new programComponents.forumNeeds.ForumPost(id, subjectId, name, description, ownerId);
                //System.Windows.Forms.MessageBox.Show(temp.ToString() );
                post[i++] = temp;
            }
            var content = new programComponents.forumNeeds.ForumContent(post);
            return content;
        }

        //public static GetForumContent

    }
}

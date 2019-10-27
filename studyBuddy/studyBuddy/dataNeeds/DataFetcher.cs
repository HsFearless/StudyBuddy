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

        public static Subjects GetSubjects()
        {
            return Subjects.GetInstance();
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

        public static string GetDeviceIdentifier()
        {
            string toReturn = programComponents.loginNeeds.DeviceIdentifier.GetIdentifier();
            if (toReturn.Length > 0)
                return toReturn;
            throw new KeyNotFoundException("Failed to get identifier.");
        }

        public static long GetServerTimeStamp()
        {
            string[] row = staticSource.SelectOneRow("UNIX_TIMESTAMP();");
            if (row.Length > 0)
                return Convert.ToInt64(row[0]) ;//long
            return 0;
        }

        public static long GetDeviceTimeStamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        }

        public static List<programComponents.profileNeeds.User> GetUsers()
        {
            var rows = staticSource.Select("ID, username, email, "
                + "karma, rating, lastActivity, profileInfo "
                + "FROM " + MysqlHandler.tblUsers);
            var toReturn = new List<programComponents.profileNeeds.User>();
            foreach(string[] col in rows)
            {
                int id = Convert.ToInt32(col[0]);
                string name = col[1];
                string email = col[2];
                int karma = Convert.ToInt32(col[3]);
                int rating = Convert.ToInt32(col[4]);
                long lastActivity = Convert.ToInt64(col[5]);
                string profileInfo = Convert.ToString(col[6]);
                try
                {
                    var user = new programComponents.profileNeeds.User(id, name,
                        email, karma, rating, lastActivity, profileInfo);
                    toReturn.Add(user);
                }
                catch (Exception)
                {
                    // :)
                } //try catch

            }//foreach

            return toReturn;
        }//static function

        public static void GetInterestsOfCurrentUserAsList(List<string> result, int userID)
        {
            //get ids of all interests of current user
            List<string[]> interestsIDs = staticSource.Select("interestID FROM " + MysqlHandler.tblUserInterests + $" WHERE userID = '{userID}' ;");
            
            foreach (string[] ids in interestsIDs)
            {
                foreach (string id in ids)
                    {
                    //get names of those interests
                    var items = staticSource.Select("name FROM " + MysqlHandler.tblInterests + $" WHERE ID = '{Int32.Parse(id)}' ;");
                    foreach (string[] interests in items)
                        foreach (string interest in interests)
                            result.Add(interest);
                    }
            }
        }

    }
}

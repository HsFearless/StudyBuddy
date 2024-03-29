﻿using System;
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

        public static Interests GetInterests()
        {
            return Interests.GetInstance();
        }

        public static List<string[]> GetUserInterestsAsStringList()
        {
            var interests = staticSource.Select("userID, interestID FROM " +
                MysqlHandler.tblUserInterests);
            return interests;
        }

        public static List<string[]> GetInterestsAsStringList()
        {
            var interests = staticSource.Select("ID, name FROM " +
                MysqlHandler.tblInterests);
            return interests;
        }

        public static programComponents.forumNeeds.ForumContent GetForum()
        {
            var rows = staticSource.Select("ID, name, subjectID, description, ownerID, votes FROM " +
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
                int votes = Convert.ToInt32(row[5]);
                var temp = new programComponents.forumNeeds.ForumPost(id, subjectId, name, 
                                                                        description, ownerId,votes);
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

        public static List<programComponents.profileNeeds.User> GetUsersAsList()
        {
            var rows = staticSource.Select("ID, username, email, "
                + "karma, rating, lastActivity, profileInfo, upForTeaching "
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
                int upForTeaching = Convert.ToInt32(col[7]);
                try
                {
                    var user = new programComponents.profileNeeds.User(id, name,
                        email, karma, rating, lastActivity, profileInfo, upForTeaching);
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

        public static List<programComponents.forumNeeds.Comment> GetCommentsAsList(long chosenForumId)
        {
            var rows = staticSource.Select("ID, forumID, userID, comment, time FROM " +
                MysqlHandler.tblForumComments + 
                " WHERE forumID = " + chosenForumId);
            var toReturn = new List<programComponents.forumNeeds.Comment>();
            foreach (var row in rows)
            {
                long id = Convert.ToInt32(row[0]);
                int ownerId = Convert.ToInt32(row[1]);
                long forumId = Convert.ToInt64(row[2]);
                string content = row[3];
                long unix = Convert.ToInt64(row[4]);
                var temp = new programComponents.forumNeeds.Comment(id, ownerId, forumId, content, unix);
                toReturn.Add(temp);
            }
            return toReturn;
        }

        public static programComponents.forumNeeds.Comment GetCommentFromTemplate(
                        programComponents.forumNeeds.Comment commentTemplate)
        {
            programComponents.forumNeeds.Comment toReturn = null;

            var row = staticSource.SelectOneRow("ID FROM " + MysqlHandler.tblForumComments
                + $" WHERE userID = '{commentTemplate.ownerId}'"
                + $" AND time = '{commentTemplate.postedAt}'");
            long id = Convert.ToInt64(row[0]);

            toReturn = new programComponents.forumNeeds.Comment(id, commentTemplate.ownerId,
                commentTemplate.forumPostId, commentTemplate.content, commentTemplate.postedAt);
            return toReturn;
        }

        public static int GetForumPostVotes(programComponents.forumNeeds.ForumPost post)
        {
            var row = staticSource.SelectOneRow("votes FROM " + MysqlHandler.tblForum +
                $" WHERE ID = '{post.id}'");
            int votes = Convert.ToInt32(row[0]);
            return votes;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    class DataCrusher : DataHandler
    {
        public static bool TakeBackUpvoteForForum(programComponents.forumNeeds.ForumPost post)
        {
            using (var db = new studybuddyDBEntities())
            {
                var fVote = db.ForumVotes.Where(vote => (vote.forumID == post.id && vote.userID == CurrentUser.id)).DefaultIfEmpty(null).FirstOrDefault();
                if (fVote == null)
                    return false;
                db.ForumVotes.Remove(fVote);
                db.SaveChanges();
                return true;
            }
            return staticSource.DeleteFrom(MysqlHandler.tblForumVotes +
                $" WHERE userID = {CurrentUser.id} AND forumID = {post.id}");
        }

        public static void DestroySession()
        {
            SessionFileHandler.SetLoggedIn(0);
        }
    }
}

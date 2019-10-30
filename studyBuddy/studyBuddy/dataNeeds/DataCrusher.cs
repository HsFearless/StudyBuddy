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
            return staticSource.DeleteFrom(MysqlHandler.tblForumVotes +
                $" WHERE userID = {CurrentUser.id} AND forumID = {post.id}");
        }
    }
}

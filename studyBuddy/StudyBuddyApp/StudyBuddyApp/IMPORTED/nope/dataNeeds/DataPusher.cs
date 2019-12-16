using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    abstract class DataPusher : DataHandler
    {
        public static bool SetForumPostVotes(programComponents.forumNeeds.ForumPost post, int intoVotes)
        {
            post.votes = intoVotes;
            return staticSource.Update(MysqlHandler.tblForum + " SET votes =" +
                $" '{post.votes}' WHERE ID = '{post.id}'");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.programComponents.forumNeeds
{
    public class Comment
    {
        public readonly long id;
        public readonly int ownerId;
        public readonly long forumPostId;
        public string content;
        public readonly long postedAt;

        public Comment(long id, int ownerId, long forumPostId, string content, long postedAtUnix)
        {
            this.id = id > 0 ? id : 0;
            this.ownerId = ownerId > 0? ownerId:0;
            this.forumPostId = forumPostId > 0 ? forumPostId : 0;
            this.content = content;
            this.postedAt = postedAtUnix;
        }

        public override string ToString()
        {
            return content.ToString();
        }
    }
}

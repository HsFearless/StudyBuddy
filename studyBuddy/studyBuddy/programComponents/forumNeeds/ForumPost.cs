using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.programComponents.forumNeeds
{
    class ForumPost
    {
        public long id { get; private set; }
        public string name;
        public string description;
        public int ownerId;

        public ForumPost(long id, string name="", string description = "", int ownerId=0)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.ownerId = (ownerId >= 0) ? ownerId : 0;
        }

        

    }
}

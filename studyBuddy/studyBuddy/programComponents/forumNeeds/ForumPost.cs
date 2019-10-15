using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.programComponents.forumNeeds
{
    class ForumPost
    {
        public int id { get; private set; }
        public string name;
        public string description;
        public int subjectId;
        public int ownerId;
        public string[] comments = null;

        public ForumPost(long id, int subjectId, string name="", string description = "", int ownerId=0)
        {
            this.id = (int)id; //^widening with possible precision loss
            this.name = name;
            this.subjectId = subjectId;
            this.description = description;
            this.ownerId = (ownerId >= 0) ? ownerId : 0;
        }

        public override string ToString()
        {
            return $"id = ({id}), name = ({name}), subjectId = ({subjectId}), " +
                $"description = ({description}), ownerId = ({ownerId})";
        }

    }
}

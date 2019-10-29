using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.programComponents.forumNeeds
{
    public class ForumPost : IComparable<ForumPost>
    {
        public long id { get; private set; }
        public string name;
        public string description;
        public int subjectId;
        public int ownerId;
        private CommentsManager backingComments = null;
        public CommentsManager comments { get
            {
                if (this.backingComments == null)
                    this.backingComments = new CommentsManager(this);
                return this.backingComments;
            }
            set { this.backingComments = value; }
        }

        public ForumPost(long id, int subjectId, string name="", string description = "", int ownerId=0)
        {
            this.id = id;
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

        public int CompareTo(ForumPost other)
        {
            return this.id.CompareTo(other.id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.programComponents.forumNeeds
{
    public class SubjectKnowsPosts
    { 
        public string name;
        public IEnumerable<ForumPost> forumPosts;


        public SubjectKnowsPosts() : this(null, null)
        {
        }

        public SubjectKnowsPosts(string name, IEnumerable<ForumPost> forumPosts)
        {
            this.name = name;
            this.forumPosts = forumPosts;
        }
    }
}

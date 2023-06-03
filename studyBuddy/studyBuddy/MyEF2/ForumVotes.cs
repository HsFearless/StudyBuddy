using System;
using System.Collections.Generic;

namespace studyBuddy.MyEF2
{
    public partial class ForumVotes
    {
        public int UserId { get; set; }
        public long ForumId { get; set; }
    }
}

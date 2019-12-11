using System;
using System.Collections.Generic;

namespace studyBuddy.MyEF2
{
    public partial class CommentVotes
    {
        public int UserId { get; set; }
        public long CommentId { get; set; }
    }
}

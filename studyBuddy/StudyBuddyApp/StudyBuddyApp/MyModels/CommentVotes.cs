using System;
using System.Collections.Generic;

namespace StudyBuddyApp.MyModels
{
    public partial class CommentVotes
    {
        public int UserId { get; set; }
        public long CommentId { get; set; }
    }
}

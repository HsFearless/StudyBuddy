using System;
using System.Collections.Generic;

namespace StudyBuddyApp.MyModelsc
{
    public partial class ForumComments
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public long ForumId { get; set; }
        public string Comment { get; set; }
        public int Time { get; set; }
    }
}

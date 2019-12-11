using System;
using System.Collections.Generic;

namespace studyBuddy.MyEF2
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

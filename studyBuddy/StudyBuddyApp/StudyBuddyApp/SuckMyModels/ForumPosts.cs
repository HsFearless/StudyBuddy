using System;
using System.Collections.Generic;

namespace StudyBuddyApp.MyModels
{
    public partial class ForumPosts
    {
        public long Id { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public string Description { get; set; }
        public int Votes { get; set; }
    }
}

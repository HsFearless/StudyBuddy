using System;
using System.Collections.Generic;
using System.Text;

namespace StudyBuddyApp
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

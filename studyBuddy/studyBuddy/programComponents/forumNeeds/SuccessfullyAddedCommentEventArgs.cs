using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy
{
    public class SuccessfullyAddedCommentEventArgs : EventArgs
    {
        public string commentText;
        public long commentUnix;

        public SuccessfullyAddedCommentEventArgs(string text, long unix)
        {
            commentText = text;
            commentUnix = unix;
        }
    }
}

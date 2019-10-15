using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.programComponents.forumNeeds
{
    class ForumContent : IEnumerable<ForumPost>
    {
        class ForumPostEnumerator : IEnumerator<ForumPost>
        {
            public ForumPost Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
        protected ForumPost[] post;

        IEnumerator<ForumPost> IEnumerable<ForumPost>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.programComponents.forumNeeds
{
    class ForumContent : IEnumerable<ForumPost>//^IEnumerable
    {

        public ForumPost[] post;

        public void Add(ForumPost onePost)
        {
            post.Append<ForumPost>(onePost);
        }

        public ForumContent(ForumPost[] posts=null)
        {
            if (posts == null)
                post = new ForumPost[0];
            else
                post = posts;
        }

        IEnumerator<ForumPost> IEnumerable<ForumPost>.GetEnumerator()
        {
            return new ForumPostEnumerator(post);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ForumPostEnumerator(post);
        }


    }

     class ForumPostEnumerator : IEnumerator<ForumPost>//^IEnumerator
     {
        private ForumPost[] post;
        private int length;
        private int pos = -1;

        public ForumPostEnumerator(ForumPost[] posts)
        {
            this.post = posts;
            this.length = post.Length;
        }

        public ForumPost Current
        {
            get
            {
                return post[pos];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return post[pos];
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            pos++;
            return pos < length;
        }

        public void Reset()
        {
            pos = -1;
        }
     }

}

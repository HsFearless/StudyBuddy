using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.programComponents.forumNeeds
{
    public class ForumContent : IEnumerable<ForumPost>//^IEnumerable
    {

        private bool sorted = false;
        long maxId = 0;

        public ForumPost[] post;

        public void Add(ForumPost onePost)
        {
            post.Append<ForumPost>(onePost);
            sorted = false;
            maxId = Math.Max(maxId, onePost.id);
        }

        public ForumContent(ForumPost[] posts = null)
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

        private void FindMaxId()
        {
            if (sorted)
            {
                this.maxId = post[post.Length - 1].id;
                return;
            }
                
            foreach (var post in this)
            {
                maxId = Math.Max(maxId, post.id);
            }
        }

        private void Sort()
        {
            if (maxId == 0)
                FindMaxId();
            Array.Sort<ForumPost>(post);
        }

        private ForumPost FindPost(long id)
        {
            if (!this.sorted)
                Sort();
            ForumPost toFind = new ForumPost(id, 0, null, null, 0);
            long index = Array.BinarySearch<ForumPost>(post, toFind); //#but it returns int32
            ForumPost toReturn = index > -1 ? post[index] : null;
            return toReturn;
        }

        public ForumPost this[long id]
        {
            get { return FindPost(id); }
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
            return;
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds.misc
{
    public sealed class Subjects : IEnumerable<Subjects.Subject>//singleton
    {
        public sealed class Subject : IComparable<Subject> //^comparable
        {
            public int id { get; private set; }
            public string name { get; private set; }

            internal Subject(int id, string name)
            {
                this.id = id; this.name = name;
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                try
                {
                    if (this.id != ((Subject)obj).id) //^narrowing
                        return false;
                }
                catch (InvalidCastException)
                {
                    return false;
                }
                return true;
            }

            public override int GetHashCode()
            {
                return id;
            }

            public int CompareTo(Subject other)
            {
                return (this.Equals(other))? 1:0;
            }

            public override string ToString()
            {
                return this.name;
            }

        }//nested class Subject end

        private static readonly Lazy<Subjects> lazy =
            new Lazy<Subjects>(() => new Subjects()); //^generics
        private static Subject[] subjects;

        private Subjects()
        {
            //do nothing//singleton after all
        }

        public static Subjects GetInstance()
        {
            Initialize();
            return lazy.Value;
        }

        private static void Initialize()
        {
            if (subjects != null && subjects.Length != 0)
                return; //not null and not 0 elements
            //we need to initialize it
            var subjectsList = studyBuddy.dataNeeds.DataFetcher.GetSubjectsAsStringList();
            subjects = new Subject[subjectsList.Count];

            int i = 0;
            foreach(string[] subjectAsStringArr in subjectsList)
            {
                int id = Convert.ToInt32(subjectAsStringArr[0]);
                string name = subjectAsStringArr[1];
                subjects[i++] = new Subject(id,name);
            }
        }

        public IEnumerator<Subject> GetEnumerator()
        {
            return new SubjectsEnumerator(subjects);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SubjectsEnumerator(subjects);
        }

        IEnumerator<Subject> IEnumerable<Subject>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Subject this[int i] //^indexed
        {
            get { return subjects[i]; }
            set { subjects[i] = value; }
        }
    }


    class SubjectsEnumerator : IEnumerator<Subjects.Subject>
    {
        private int pos = -1;
        private Subjects.Subject[] subjects;
        private int len=0;

        public SubjectsEnumerator(Subjects.Subject[] subjects)
        {
            this.subjects = subjects;
            this.len = subjects.Length;
        }

        public Subjects.Subject Current => subjects[pos];

        object IEnumerator.Current => subjects[pos];

        public void Dispose()//#
        {
            return;
            //throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            pos++;
            return pos < len;
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}

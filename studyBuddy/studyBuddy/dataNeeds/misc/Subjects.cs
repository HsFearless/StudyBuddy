using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds.misc
{
    public sealed class Subjects //singleton
    {
        public sealed class Subject
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
                if (this.id != ((Subject)obj).id) //^narrowing
                    return false;
                return true;
            }

            public override int GetHashCode()
            {
                return id;
            }

        }//nested class Subject end

        private static readonly Lazy<Subjects> lazy =
            new Lazy<Subjects>(() => new Subjects()); //^geenerics
        private static Subject[] subjects;

        private Subjects()
        {
            //do nothing//singleton after all
        }

        public Subjects getInstance()
        {
            Initialize();
            return lazy.Value;
        }

        private void Initialize()
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
        public Subject this[int i] //^indexed
        {
            get { return subjects[i]; }
            set { subjects[i] = value; }
        }
    }
}

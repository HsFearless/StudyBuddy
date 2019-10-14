using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    public static class Misc
    {
        public sealed class Subjects //singleton
        {
            public sealed class Subject
            {
                public int id { get; private set; }
                public string name { get; private set; }

                Subject(int id, string name)
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

            }//nested class Subject end

            private static readonly Lazy<Subjects> lazy =
                new Lazy<Subjects>(() => new Subjects());
            private static string[] subject;

            private Subjects()
            {
                //do nothing
            }
            /*public string this[int i] //^indexed
            {
                get { return row[i]; }
                set { row[i] = value; }
            }*/
        }
    }
}

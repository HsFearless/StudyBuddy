using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    public sealed class Interests
    {
        public sealed class Interest
        {
            public int id { get; private set; }
            public string name { get; private set; }

            internal Interest(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
        }

        private static readonly Lazy<Interests> lazy = new Lazy<Interests>(() => new Interests());
        private static Interest[] interests;

        private Interests()
        {
            
        }

        public static Interests GetInstance()
        {
            Initialize();
            return lazy.Value;
        }

        private static void Initialize()
        {
            if (interests != null && interests.Length != 0)
                return;
            //initialization
            var interestsList = DataFetcher.GetInterestsAsStringList();
            interests = new Interest[interestsList.Count];
            int i = 0;
            foreach (string[] interestAsStringArr in interestsList)
            {
                int id = Convert.ToInt32(interestAsStringArr[0]);
                string name = interestAsStringArr[1];
                interests[i++] = new Interest(id, name);
            }
        }
    }
}

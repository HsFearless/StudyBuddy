using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    class DataFetcher
    {
        MysqlHandler source = new MysqlHandler();

        public string getSalt(string username)
        {
            return "aaaaa";
        }

        public int getKarma(string username)
        {
            return 0;
        }
    }
}

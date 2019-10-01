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
            string[] row = source.selectOneRow("salt FROM " + MysqlHandler.tblUsers +
                $" WHERE username = '{username}' ;");
            if (row.Length == 0)
                return "";
            return row[0];
        }

        public int getKarma(string username)
        {
            return 84845;
        }
    }
}

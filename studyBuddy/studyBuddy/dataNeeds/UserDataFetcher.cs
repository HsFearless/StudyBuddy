using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    class UserDataFetcher : UserDataAbstract
    {
        
        private int loggedIn = 0; //epoch. unix. 10 digits. 11 in db

        

        public string getSalt(string username)
        {
            string[] row = source.selectOneRow("salt,id FROM " + MysqlHandler.tblUsers +
                $" WHERE username = '{username}' ;");
            if (row.Length == 0)
                return "";
            userId = Convert.ToInt32(row[1]);
            return row[0];
        }

        public string getSalt(System.Net.Mail.MailAddress mail)
        {
            string[] row = source.selectOneRow("salt,id FROM " + MysqlHandler.tblUsers +
                $" WHERE email = '{mail.Address}' ;");
            if (row.Length == 0)
                return "";
            userId = Convert.ToInt32(row[1]);
            return row[0];
        }

        internal bool isCorrectPassword(string password)
        {
            string[] row = source.selectOneRow("karma FROM " + MysqlHandler.tblUsers +
                $" WHERE id = '{this.userId}' AND password = '{password}' ;");
            if (row.Length != 1)
                return false;
            return true;
        }

        internal bool isEmailTaken(System.Net.Mail.MailAddress mail)
        {
            string[] row = source.selectOneRow("id FROM " + MysqlHandler.tblUsers +
                $" WHERE email = '{mail.Address}' ;");
            if (row.Length == 0)
                return false;
            return true;
        }

        internal bool isUsernameTaken(string username)
        {
            string[] row = source.selectOneRow("id FROM " + MysqlHandler.tblUsers +
                $" WHERE username = '{username}' ;");
            if (row.Length == 0)
                return false;
            return true;
        }

        public int getKarma(string username)
        {
            return 999;
        }

        public int getId()
        {
            return userId;
        }

        public int getId(string username)
        {
            string[] row = source.selectOneRow("ID FROM " + MysqlHandler.tblUsers + 
                $" WHERE username = '{username}';");
            if (row.Length != 1)
                return 0;
            return Convert.ToInt32(row[0]);
        }

        public static string getLastUsedUsername()
        {
            return file.read();
        }

        public long getCurrentUserTimeStamp()
        {
            return 0;//#
        }

        public static long getTimeStamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        }
    }
}

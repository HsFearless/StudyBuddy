using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    class UserDataFetcher : UserDataAbstract
    {
        
        private int loggedIn = 0; //epoch. unix. 10 digits. 11 in db //maybe long int?

        public string GetSalt(string username)
        {
            string[] row = source.SelectOneRow("salt,id FROM " + MysqlHandler.tblUsers +
                $" WHERE username = '{username}' ;");
            if (row.Length == 0)
                return "";
            userId = Convert.ToInt32(row[1]);
            return row[0];
        }

        public string GetSalt(System.Net.Mail.MailAddress mail)
        {
            string[] row = source.SelectOneRow("salt,id FROM " + MysqlHandler.tblUsers +
                $" WHERE email = '{mail.Address}' ;");
            if (row.Length == 0)
                return "";
            userId = Convert.ToInt32(row[1]);
            return row[0];
        }

        internal bool IsCorrectPassword(string password)
        {
            string[] row = source.SelectOneRow("karma FROM " + MysqlHandler.tblUsers +
                $" WHERE id = '{this.userId}' AND password = '{password}' ;");
            if (row.Length != 1)
                return false;
            return true;
        }

        internal bool IsEmailTaken(System.Net.Mail.MailAddress mail)
        {
            string[] row = source.SelectOneRow("id FROM " + MysqlHandler.tblUsers +
                $" WHERE email = '{mail.Address}' ;");
            if (row.Length == 0)
                return false;
            return true;
        }

        internal bool IsUsernameTaken(string username)
        {
            string[] row = source.SelectOneRow("id FROM " + MysqlHandler.tblUsers +
                $" WHERE username = '{username}' ;");
            if (row.Length == 0)
                return false;
            return true;
        }

        public int GetKarma(string username)
        {
            return 999;
        }

        public int GetId()
        {
            return userId;
        }

        public int GetId(string username)
        {
            string[] row = source.SelectOneRow("ID FROM " + MysqlHandler.tblUsers + 
                $" WHERE username = '{username}';");
            if (row.Length != 1)
                return 0;
            return Convert.ToInt32(row[0]);
        }

        public static string GetLastUsedUsername()
        {
            return file.Read();
        }

        public long GetCurrentUserTimeStamp()
        {
            return 0;//#
        }

        public static long GetTimeStamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    class UserDataFetcher : UserDataAbstract
    {

        public string GetSalt(string username)
        {
            using (var db = new studybuddyDBEntities() )
            {
                var user = db.Users.Where(use => use.username.ToLower() == username.ToLower()).DefaultIfEmpty(null).FirstOrDefault();
                
                userId = user.ID;
                return user.salt;

            }
            /*string[] row = source.SelectOneRow("salt,id FROM " + MysqlHandler.tblUsers +
                $" WHERE username = '{username}' ;");
            if (row.Length == 0)
                return "";
            userId = Convert.ToInt32(row[1]);
            return row[0];*/
        }

        public string GetSalt(System.Net.Mail.MailAddress mail)
        {
            using(var db = new studybuddyDBEntities())
            {
                var user = db.Users.Where(use => use.email.ToLower() == mail.Address.ToLower()).DefaultIfEmpty(null).FirstOrDefault();
                
                userId = user.ID;
                return user.salt;

            }
            //string[] row = source.SelectOneRow("salt,id FROM " + MysqlHandler.tblUsers +
            //    $" WHERE email = '{mail.Address}' ;");
            //if (row.Length == 0)
            //    return "";
            //userId = Convert.ToInt32(row[1]);
            //return row[0];
        }

        internal bool IsCorrectPassword(string password)
        {
            using (var db = new studybuddyDBEntities())
            {
                var user = db.Users.Where(use => (use.password == password && use.ID == userId)).DefaultIfEmpty(null).FirstOrDefault();

                return true;
            }
            /*
            string[] row = source.SelectOneRow("karma FROM " + MysqlHandler.tblUsers +
                $" WHERE id = '{this.userId}' AND password = '{password}' ;");
            if (row.Length != 1)
                return false;
            return true;*/
        }

        internal bool IsEmailTaken(System.Net.Mail.MailAddress mail)
        {
            using(var db = new studybuddyDBEntities())
            {
                var user = db.Users.Where(use => use.email.ToLower() == mail.Address.ToLower()).DefaultIfEmpty(null).FirstOrDefault();
                return true;
            }
            /*
            string[] row = source.SelectOneRow("id FROM " + MysqlHandler.tblUsers +
                $" WHERE email = '{mail.Address}' ;");
            if (row.Length == 0)
                return false;
            return true;*/
        }

        internal bool IsUsernameTaken(string username)
        {
            using (var db = new studybuddyDBEntities())
            {
                var user = db.Users.Where(use => use.username == use.username).DefaultIfEmpty(null).FirstOrDefault();

                return false;
            }
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

        public int GetId(string username, bool saveId = true)
        {
            using(var db = new studybuddyDBEntities())
            {
                var user = db.Users.Where(use => use.username == username).DefaultIfEmpty(null).FirstOrDefault();

                if (saveId)
                    userId = user.ID;
                return user.ID ;
            }
            /*
            int toReturn = 0;
            string[] row = source.SelectOneRow("ID FROM " + MysqlHandler.tblUsers +
                $" WHERE username = '{username}';");
            if (row.Length == 1)
                toReturn = Convert.ToInt32(row[0]);
            if (saveId)
                userId = toReturn;
            return toReturn;*/
        }

        public int GetId(System.Net.Mail.MailAddress mail, bool saveId = true)
        {
            using (var db = new studybuddyDBEntities())
            {
                var user = db.Users.Where(use => use.email.ToLower() == mail.Address).DefaultIfEmpty(null).FirstOrDefault();

                if (saveId)
                    userId = user.ID;
                return user.ID;
            }
                /*int toReturn = 0;
            string[] row = source.SelectOneRow("ID FROM " + MysqlHandler.tblUsers +
               $" WHERE email = '{mail.Address}';");
            if (row.Length == 1)
                toReturn = Convert.ToInt32(row[0]);
            if (saveId)
                userId = toReturn;
            return toReturn;*/
        }

        public int GetIdByUsernameOrEmail(string usernameOrEmail, bool saveId = true)
        {
            if (InputValidator.ValidateUsername(usernameOrEmail))
                return GetId(usernameOrEmail, saveId);

            //it is not username
            System.Net.Mail.MailAddress mail;
            if (!InputValidator.ValidateEmail(usernameOrEmail, out mail))
                return 0; //#exception?

            //it is an email
            return GetId(mail, saveId);
        }

        public static string GetLastUsedUsername()
        {
            return SessionFileHandler.GetLastUser(); //cached
        }

        public static long GetLastLoginTimestamp()
        {
            return SessionFileHandler.GetLoggedIn(); //cached
        }

        public static bool GetLastLogoutWasDoneOrNot()
        {
            return SessionFileHandler.GetSignedOut();
        }

        /*public long GetCurrentUserTimeStamp()
        {
        //loggedIn does no longer exist
            string[] row = staticSource.SelectOneRow("loggedIn FROM " + MysqlHandler.tblUsers +
                " WHERE ID = " + this.GetId());
            if (row.Length < 1)
            {
                return -1;
            }
            return Convert.ToInt64(row[0]);
        }*/

        public bool IsThisLastLoggedInTimestampHash(string hashedUnix)
        {
            using(var db = new studybuddyDBEntities())
            {
                var user = db.Users.Where(use => (use.loggedInHash == hashedUnix && use.ID == userId)).DefaultIfEmpty().FirstOrDefault();

                return true;
            }
            //when calling this method make sure that you have called
            //getId(argument) method before. 
            /*

            var row = staticSource.SelectOneRow("rating FROM " + MysqlHandler.tblUsers +
                $" WHERE loggedInHash = '{hashedUnix}' AND ID = '{this.userId}'");
            if (row.Length < 1)
                return false;
            return true;*/
        }

    }
}

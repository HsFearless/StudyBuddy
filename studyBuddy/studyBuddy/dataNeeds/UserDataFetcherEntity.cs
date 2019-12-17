using Microsoft.EntityFrameworkCore;
using studyBuddy.MyEF2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace studyBuddy.dataNeeds
{
    class UserDataFetcherEntity : UserDataAbstract, IUserDataFetcher
    {
        public UserDataFetcherEntity(int userId = 0) : base(userId)
        {
        }

        public string GetSalt(string username)
        {
            //string[] row = source.SelectOneRow("salt,id FROM " + MysqlHandler.tblUsers +
            //    $" WHERE username = '{username}' ;");
            //if (row.Length == 0)
            //    return "";
            //userId = Convert.ToInt32(row[1]);
            //return row[0];
            using (var db = new MyDbContext())
            {
                /*Users catGary = new Users() { Id = 6, Username = "useris", Salt = "penis" };
                db.Users.Add(catGary);
                db.SaveChanges();

                Cat catJack = new Cat() { CatId = 2, Name = "Jack", MeowsPerSecond = 11 };
                Cat catLuna = new Cat() { CatId = 3, Name = "Luna", MeowsPerSecond = 3 };

                List catsInTheHat = new List() { catGary, catJack, catLuna };

                if (await db.Cats.CountAsync() < 3)
                {
                    await db.Cats.AddRangeAsync(catsInTheHat);
                    await db.SaveChangesAsync();
                }

                var catsInTheBag = await db.Cats.ToListAsync();

                foreach (var cat in catsInTheBag)
                {
                    textView.Text += $"{cat.CatId} - {cat.Name} - {cat.MeowsPerSecond}" + System.Environment.NewLine;
                }*/

                Users user = db.Users.
                    Where(userr => userr.Username == username)
                    .DefaultIfEmpty(null).FirstOrDefault();
                if (user == null)
                    return "";

                userId = user.Id;
                return user.Salt;
                    
            }
        }

        public string GetSalt(System.Net.Mail.MailAddress mail)
        {
            //string[] row = source.SelectOneRow("salt,id FROM " + MysqlHandler.tblUsers +
            //    $" WHERE email = '{mail.Address}' ;");
            //if (row.Length == 0)
            //    return "";
            //userId = Convert.ToInt32(row[1]);
            //return row[0];
            Console.WriteLine("I am in get salt by email");
            using (var db = new studybuddyDBEntities())
            {
                try
                {
                    foreach (var uzze in db.Users)
                    {
                        Console.WriteLine(uzze.username);
                    }
                    var daba = db;
                    var uze = db.Users;
                    var were = uze.Where(use => use.ID > 0);
                    var forst = were.First();
                    Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                    return "----";

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.ToString());

                }
                return "+++++";
                var user = db.Users.Where(use => use.email.ToLower() == mail.Address.ToLower())
                    .DefaultIfEmpty(null).FirstOrDefault();
                if (user == null)
                    return "";

                userId = user.ID;
                return user.salt;
            }
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

        public int GetId(string username, bool saveId = true)
        {
            int toReturn = 0;
            string[] row = source.SelectOneRow("ID FROM " + MysqlHandler.tblUsers +
                $" WHERE username = '{username}';");
            if (row.Length == 1)
                toReturn = Convert.ToInt32(row[0]);
            if (saveId)
                userId = toReturn;
            return toReturn;
        }

        public int GetId(System.Net.Mail.MailAddress mail, bool saveId = true)
        {
            int toReturn = 0;
            string[] row = source.SelectOneRow("ID FROM " + MysqlHandler.tblUsers +
               $" WHERE email = '{mail.Address}';");
            if (row.Length == 1)
                toReturn = Convert.ToInt32(row[0]);
            if (saveId)
                userId = toReturn;
            return toReturn;
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

        public static string GetLastUsedUsernameStatic()
        {
            return SessionFileHandler.GetLastUser(); //cached
        }

        public static long GetLastLoginTimestampStatic()
        {
            return SessionFileHandler.GetLoggedIn(); //cached
        }

        public static bool GetLastLogoutWasDoneOrNotStatic()
        {
            return SessionFileHandler.GetSignedOut();
        }

        public bool IsThisLastLoggedInTimestampHash(string hashedUnix)
        {
            //when calling this method make sure that you have called
            //getId(argument) method before. 
            if (this.userId == 0)
                return false; //#possible throw new illegalMethodCall exception

            var row = staticSource.SelectOneRow("rating FROM " + MysqlHandler.tblUsers +
                $" WHERE loggedInHash = '{hashedUnix}' AND ID = '{this.userId}'");
            if (row.Length < 1)
                return false;
            return true;
        }

        bool IUserDataFetcher.IsCorrectPassword(string password)
        {
            throw new NotImplementedException();
        }

        bool IUserDataFetcher.IsEmailTaken(MailAddress mail)
        {
            throw new NotImplementedException();
        }

        bool IUserDataFetcher.IsUsernameTaken(string username)
        {
            throw new NotImplementedException();
        }

        public string GetLastUsedUsername()
        {
            return GetLastUsedUsernameStatic();
        }

        public long GetLastLoginTimestamp()
        {
            return GetLastLoginTimestampStatic();
        }

        public bool GetLastLogoutWasDoneOrNot()
        {
            return GetLastLogoutWasDoneOrNotStatic();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    abstract class SessionFileHandler
    {
        //why we need this class?
        //to keep data in order
        private static FileHandler file;
        private static string lastUser = null;
        private static long loggedIn = 0; //epoch. unix. 10 digits. 11 in db
        static SessionFileHandler()
        {
            file = new FileHandler("sbSession.txt");
        }

        public static void SetLastUser(string usernameOrEmail)
        {
            lastUser = usernameOrEmail;
            Flush();
        }

        public static void SetLoggedIn(long unix)
        {
            loggedIn = unix;
            Flush();
        }

        private static void Flush()
        {
            lastUser = (lastUser == null) ? "" : lastUser;
            file.WriteNewly(lastUser);
            file.Append(loggedIn.ToString());
        }

        private static void fetchAllData()
        {
            try
            {
                lastUser = file.Read();
                loggedIn = Convert.ToInt64(file.Read());
            }
            catch (Exception)
            {
                lastUser = "";
                loggedIn = 0;
            }
            
        }

        public static string GetLastUser()
        {
            if (lastUser != null)
                return lastUser;
            //it is
            fetchAllData();
            return lastUser;
        }

        public static long GetLoggedIn()
        {
            if (lastUser != null) //because loggedIn can be 0 but can not be null;
                return loggedIn;
            fetchAllData();
            return loggedIn;
        }

    }
}

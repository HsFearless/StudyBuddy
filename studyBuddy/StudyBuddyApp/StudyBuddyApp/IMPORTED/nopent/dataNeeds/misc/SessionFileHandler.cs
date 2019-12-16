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
        private static long loggedIn = -1; //epoch. unix. 10 digits. 11 in db
        private static bool signedOut = true;
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

        public static void SetSignedOut(bool trueFalse)
        {
            signedOut = trueFalse;
            Flush();
        }

        private static void Flush()
        {
            lastUser = (lastUser == null) ? "" : lastUser;
            file.WriteNewly(lastUser);
            file.Append(loggedIn.ToString());
            file.Append(signedOut.ToString());
        }

        private static void FetchAllData()
        {
            try
            {
                lastUser = file.Read();
                loggedIn = Convert.ToInt64(file.Read());
                signedOut = Convert.ToBoolean(file.Read());
            }
            catch (Exception)
            {
                lastUser = (lastUser == null) ? "" : lastUser;
                loggedIn = (loggedIn == -1) ? 0 : loggedIn;
                signedOut = true;
            }
            
        }

        public static string GetLastUser()
        {
            if (lastUser != null)
                return lastUser;
            //it is
            FetchAllData();
            return lastUser;
        }

        public static long GetLoggedIn()
        {
            if (lastUser != null) //because loggedIn can be 0 but can not be null;
                return loggedIn;
            FetchAllData();
            return loggedIn;
        }

        public static bool GetSignedOut()
        {
            if (lastUser != null)
                return signedOut;
            FetchAllData();
            return signedOut;
        }

    }
}

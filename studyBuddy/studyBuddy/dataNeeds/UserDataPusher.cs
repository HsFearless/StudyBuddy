using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    internal abstract class UserDataPusher : UserDataAbstract
    {
        //staticSource, userId from abstract class
        static internal void PushNewUser(string user, System.Net.Mail.MailAddress email, string hashPass, string salt)
        {
            staticSource.InsertInto(MysqlHandler.tblUsers +
                "(username, email, password, salt) VALUES" +
                $"('{user}', '{email.Address}', '{hashPass}', '{salt}') ;"); //you sure it safe not to check for " ' " in strings?

        }

        static internal void UpdateUserSession(UserDataFetcher UDF, string hashedUnix)
        {
            int userId = UDF.GetId();
            if (InputValidator.ValidateId(userId) )
                return; //#change to exception invalid user //default
            staticSource.Update(MysqlHandler.tblUsers +
                $" SET loggedInHash = '{hashedUnix}'" +
                $" WHERE ID = '{userId}'");
        }

        static internal void PushToFileFromScratch(string text)
        {
            file.WriteNewly(text);
        }

        static internal void PushToFile(string text)
        {
            file.Append(text);
        }

        static internal void PushSessionFileUser(string user)
        {
            SessionFileHandler.SetLastUser(user);
        }

        static internal void PushSessionFileLoggedIn(long unix)
        {
            SessionFileHandler.SetLoggedIn(unix);
        }
    }
}

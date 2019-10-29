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

        static internal void PushNewInterest(string interest)
        {
            var interestID = staticSource.Select("ID FROM " + MysqlHandler.tblInterests + $" WHERE name = '{interest}' ;");
            staticSource.InsertInto(MysqlHandler.tblUserInterests +
                "(userID, interestID) VALUES" +
                $"('{CurrentUser.id}', '{Int32.Parse(interestID[0][0])}') ;");

        }

        static internal void UpdateUserSession(UserDataFetcher UDF, long unix, string hashedUnix)
        {
            int userId = UDF.GetId();
            if (!InputValidator.ValidateId(userId))
                throw new Exception() ; //#change to exception invalid user //default
            staticSource.Update(MysqlHandler.tblUsers +
                $" SET lastActivity = '{unix}', loggedInHash = '{hashedUnix}'" +
                $" WHERE ID = '{userId}'");
        }

        static internal void UpdateUserProfileInfo(String updatedInfo)
        {
            staticSource.Update(MysqlHandler.tblUsers +
                $" SET profileInfo = '{updatedInfo}'" +
                $" WHERE ID = '{CurrentUser.id}'");
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

        static internal bool PushNewProblem(String name, Subjects.Subject subject, String description)
        {
            //name = string.Format("'{0}'", name);
            //description = string.Format("'{0}'", description);
            string nameName = "■name";
            string descName = "■desc";
            var qParams = MysqlHandler.ConstructQueryParams(new string[] { nameName, descName },
                new string[] { name, description });

            return staticSource.InsertInto(MysqlHandler.tblForum
                + "(ownerID, name, subjectID, description) VALUES"
                + $"('{CurrentUser.id}', '{nameName}', '{subject.id}', '{descName}')",
                qParams);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace studyBuddy.dataNeeds
{
    interface IUserDataFetcher
    {

        string GetSalt(string username);

        string GetSalt(System.Net.Mail.MailAddress mail);

        int GetKarma(string username);

        int GetId();

        int GetId(string username, bool saveId = true);

        int GetId(System.Net.Mail.MailAddress mail, bool saveId = true);

        int GetIdByUsernameOrEmail(string usernameOrEmail, bool saveId = true);

        bool IsCorrectPassword(string password);

        bool IsEmailTaken(System.Net.Mail.MailAddress mail);

        bool IsUsernameTaken(string username);

        string GetLastUsedUsername();

        long GetLastLoginTimestamp();

        bool GetLastLogoutWasDoneOrNot();

        bool IsThisLastLoggedInTimestampHash(string hashedUnix);

}
    }

using System;
using System.Collections.Generic;
using System.Text;

namespace studyBuddy.dataNeeds
{
    interface IUserDataFetcherPrivate
    {

        bool IsCorrectPassword(string password);

        bool IsEmailTaken(System.Net.Mail.MailAddress mail);

        bool IsUsernameTaken(string username);

        }
}

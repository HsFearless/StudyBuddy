﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddyForm.dataNeeds
{
    internal abstract class UserDataPusher : UserDataAbstract
    {
        //staticSource, userId from abstract class
        static internal void pushNewUser(string user, System.Net.Mail.MailAddress email, string hashPass, string salt)
        {
            staticSource.InsertInto(MysqlHandler.tblUsers +
                "(username, email, password, salt) VALUES" +
                $"('{user}', '{email.Address}', '{hashPass}', '{salt}') ;"); //you sure it safe not to check for " ' " in strings?
        }

        static internal void pushToFile(string text)
        {
            file.Write(text);
        }
    }
}

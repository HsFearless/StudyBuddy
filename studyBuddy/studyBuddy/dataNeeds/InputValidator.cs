using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace studyBuddy.dataNeeds
{
    abstract class InputValidator
    {
        static public int errorNo { get; private set; } = 0;
        static public readonly int OK = 0;
        static public readonly int TOO_SHORT = 1;
        static public readonly int TOO_LONG = 2;
        static public readonly int INVALID_CHAR = 3;
        static public readonly int INVALID_EMAIL = 4;

        static public bool validateUsername(string username)
        {
            if(username.Length < 4) //<=3
            {
                errorNo = TOO_SHORT;
                return false;
            }
            if (username.Length > 24)
            {
                errorNo = TOO_LONG;
                return false;
            }

            Regex regex = new Regex(@"\W", RegexOptions.ECMAScript);
            //ECMAScript to narrow \w match to [a-zA-Z0-9_]
            //look closely. It is \W there, not \w
            //therefore it is true if we find
            //a character that does not match pattern [a-zA-Z0-9_]
            //a-z or A-Z or 0-9 or _
            if (regex.IsMatch(username))
            {
                errorNo = INVALID_CHAR;
                return false;
            }


            errorNo = OK;
            return true;
        }

        static public bool validateEmail(string email, out System.Net.Mail.MailAddress mail)
        {
            try
            {
                mail = new System.Net.Mail.MailAddress(email);
                errorNo = OK;
                return true;
            }
            catch (FormatException)
            {
                errorNo = INVALID_EMAIL;
                mail = null;
                return false;
            }
        }
    }
}

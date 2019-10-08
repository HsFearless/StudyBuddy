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
        //let us keep positive flow returns as true
        static public Error error = new Error(Error.code.UNKNOWN);


        static public bool validateUsername(string username)
        {
            if(username.Length < 4) //<=3
            {
                error.no = Error.code.TOO_SHORT;
                return false;
            }
            if (username.Length > 24)
            {
                error.no = Error.code.TOO_LONG;
                return false;
            }

            Regex regex = new Regex(@"\W", RegexOptions.ECMAScript); //^regex
            //ECMAScript to narrow \w match to [a-zA-Z0-9_]
            //look closely. It is \W there, not \w
            //therefore it is true if we find
            //a character that does not match pattern [a-zA-Z0-9_]
            //a-z or A-Z or 0-9 or _
            if (regex.IsMatch(username))
            {
                error.no = Error.code.INVALID_CHAR;
                return false;
            }


            error.no = Error.code.OK;
            return true;
        }

        static public bool validateEmail(string email, out System.Net.Mail.MailAddress mail)
        {
            try
            {
                mail = new System.Net.Mail.MailAddress(email);
                error.no = Error.code.OK;
                return true;
            }
            catch (FormatException)
            {
                error.no = Error.code.INVALID_EMAIL;
                mail = null;
                return false;
            }
        }

        static public bool validatePassword(string pass, string pass2 = null)
        {
            if (pass == null)
                return error.setErrorAndReturnFalse(Error.code.TOO_SHORT);
            if (pass.Length < 8)
                return error.setErrorAndReturnFalse(Error.code.TOO_SHORT);
            if (pass.Length > 52)
                return error.setErrorAndReturnFalse(Error.code.TOO_LONG);
            if (pass2 != null)
            {
                if (!pass.Equals(pass2))
                    return error.setErrorAndReturnFalse(Error.code.PASSWORDS_NOT_MATCH);
            }
            error.no = Error.code.OK;
            return true;
        }

        static internal bool checkPasswordMatch(UserDataFetcher UDF, string password)
        {
            if(UDF.isCorrectPassword(password))
                return true;
            return false;
        }

        static public bool checkEmailNotTaken(UserDataFetcher UDF, System.Net.Mail.MailAddress mail)
        {
            if (UDF.isEmailTaken(mail))
                return false;
            return true;
        }

        static public bool checkUsernameNotTaken(UserDataFetcher UDF, string username)
        {
            if (UDF.isUsernameTaken(username))
                return false;
            return true;
        }

        static public bool validateId(int id)
        {
            if (id <= 0)
                return false;
            return true;
        }

    }
}

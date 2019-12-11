using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using studyBuddy.dataNeeds;

namespace studyBuddy.dataNeeds
{
    abstract class InputValidator
    {
        //let us keep positive flow returns as true
        static public Error error = new Error(ErrorCode.UNKNOWN);


        static public bool ValidateUsername(string username)
        {
            if (username.Length < 4) //<=3
            {
                error.no = ErrorCode.TOO_SHORT;
                return false;
            }
            if (username.Length > 24)
            {
                error.no = ErrorCode.TOO_LONG;
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
                error.no = ErrorCode.INVALID_CHAR;
                return false;
            }


            error.no = ErrorCode.OK;
            return true;
        }

        static public bool ValidateEmail(string email, out System.Net.Mail.MailAddress mail)
        {
            try
            {
                mail = new System.Net.Mail.MailAddress(email);
                error.no = ErrorCode.OK;
                return true;
            }
            catch (Exception)
            {
                error.no = ErrorCode.INVALID_EMAIL;
                mail = null;
                return false;
            }
        }

        static public bool ValidatePassword(string pass, string pass2 = null)
        {
            if (pass == null)
                return error.SetErrorAndReturnFalse(ErrorCode.TOO_SHORT);
            if (pass.Length < 8)
                return error.SetErrorAndReturnFalse(ErrorCode.TOO_SHORT);
            if (pass.Length > 52)
                return error.SetErrorAndReturnFalse(ErrorCode.TOO_LONG);
            if (pass2 != null)
            {
                if (!pass.Equals(pass2))
                    return error.SetErrorAndReturnFalse(ErrorCode.PASSWORDS_NOT_MATCH);
            }
            error.no = ErrorCode.OK;
            return true;
        }

        static internal bool CheckPasswordMatch(UserDataFetcher UDF, string password)
        {
            if (UDF.IsCorrectPassword(password))
                return true;
            return false;
        }

        static public bool CheckEmailNotTaken(UserDataFetcher UDF, System.Net.Mail.MailAddress mail)
        {
            if (UDF.IsEmailTaken(mail))
                return false;
            return true;
        }

        static public bool CheckUsernameNotTaken(UserDataFetcher UDF, string username)
        {
            if (UDF.IsUsernameTaken(username))
                return false;
            return true;
        }

        static public bool ValidateId(int id)
        {
            if (id <= 0)
                return false;
            return true;
        }

        static public bool ValidateForumProblemName(string name)
        {
            error.no = ErrorCode.OK;
            if (name.Length < 4)
                return error.SetErrorAndReturnFalse(ErrorCode.TOO_SHORT);
            if (name.Length > 50)
                return error.SetErrorAndReturnFalse(ErrorCode.TOO_LONG);
            Regex forbidden = new Regex("[^\x20-\x7E\n\r\t€ąĄčČęĘėĖįĮšŠųŲūŪžŽ]");
            //regex
            //^ this time means NEGATIVE
            //\x20-\x7E means from hex value 20 to hex value 7E
            //from space to tilde
            //all ascii ~!@#$... symbols and letters
            //http://www.asciitable.com/
            //new line, return, tab
            if (forbidden.IsMatch(name))
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_CHAR);
            name.Replace('\t', ' '); //#validator escapes !?!?!?
            return true;
        }

        static public bool ValidateForumProblemDescription(string desc)
        {
            error.no = ErrorCode.OK;
            if (desc.Contains('■'))
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_CHAR);
            if (desc.Length < 4)
                return error.SetErrorAndReturnFalse(ErrorCode.TOO_SHORT);
            if (desc.Length > 40000)
                return error.SetErrorAndReturnFalse(ErrorCode.TOO_LONG);
            return true;
        }

        static public bool ValidateForumProblemCommentText(string text)
        {
            error.no = ErrorCode.OK;
            if (text.Contains('■'))
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_CHAR);
            if (text.Length < 4)
                return error.SetErrorAndReturnFalse(ErrorCode.TOO_SHORT);
            if (text.Length > 20000)
                return error.SetErrorAndReturnFalse(ErrorCode.TOO_LONG);
            return true;
        }

    }//class
}//namespace

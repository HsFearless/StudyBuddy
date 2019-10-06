using studyBuddy.dataNeeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.programComponents.loginNeeds
{
    abstract internal class Auth
    {
        private static PasswordHasher hasher = new PasswordHasher(saltLength:12, derivedLength:39); // not base64 length !!!
        public static Error error = new Error();
        public static bool logIn(UserDataFetcher UDF, string username, string password)
        {

            string salt;

            if (!InputValidator.validatePassword(password))
                return error.setErrorAndReturnFalse(Error.WRONG_PASSWORD);
            //is it username?
            if (InputValidator.validateUsername(username))
            {
                //-yes. get salt
                salt = UDF.getSalt(username);
            }
            //was it too short?
            else if (InputValidator.error.no != Error.TOO_SHORT)
            {
                //-yes. is it email?
                System.Net.Mail.MailAddress email;
                string Email = username;
                if (InputValidator.validateEmail(Email, out email))
                {
                    //--yes. get salt
                    salt = UDF.getSalt(email);
                }
                    //--no. return false but before set error
                else
                    return error.setErrorAndReturnFalse(Error.INVALID_EMAIL);
            }
            //it was not username nor email. Let the input validator say what was the problem
            else
            {
                return error.setErrorAndReturnFalse(InputValidator.error.no);
            }

            //we have a salt
            //or maybe we should have it

            if (salt == null)
                return error.setErrorAndReturnFalse(Error.UNKNOWN);

            if (salt.Length < 1)
                return error.setErrorAndReturnFalse(Error.USER_NOT_FOUND);

            //let us hash password

            password = hasher.hash(password, salt);

            //and finally check it

            if (InputValidator.validatePasswordMatch(UDF, password))
            {
                error.no = Error.OK;
                //set log in timestamp
                return true;
            }

            error.no = Error.WRONG_PASSWORD;
            return false;
        }//logIn

        public static bool setLoggedIn(UserDataFetcher UDF) //# change to private
        {
            if (!InputValidator.validateId(UDF.getId()))
                return error.setErrorAndReturnFalse(Error.USER_NOT_FOUND);
            System.Windows.Forms.MessageBox.Show(DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString());
            return true;
        }

    }//class
}//namespace

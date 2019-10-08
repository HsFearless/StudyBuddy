using studyBuddy.dataNeeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studyBuddy.extensions;

namespace studyBuddy.programComponents.loginNeeds
{
    abstract internal class Auth
    {
        private static PasswordHasher hasher = new PasswordHasher(saltLength:12, derivedLength:39); // not base64 length !!!
        public static Error error = new Error(Error.code.UNKNOWN);
        public static bool logIn(UserDataFetcher UDF, string username, string password)
        {

            string salt;

            if (!InputValidator.validatePassword(password))
                return error.setErrorAndReturnFalse(Error.code.WRONG_PASSWORD | InputValidator.error.no);
            //is it username?
            if (InputValidator.validateUsername(username))
            {
                //-yes. get salt
                salt = UDF.getSalt(username);
            }
            //was it too short?
            else if (InputValidator.error.no != Error.code.TOO_SHORT)
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
                    return error.setErrorAndReturnFalse(Error.code.INVALID_EMAIL | Error.code.INVALID_USERNAME);
            }
            //it was not username nor email. Let the input validator say what was the problem
            else
            {
                return error.setErrorAndReturnFalse(InputValidator.error.no | Error.code.INVALID_USERNAME);
            }

            //we have a salt
            //or maybe we should have it

            if (salt == null)
                return error.setErrorAndReturnFalse(Error.code.UNKNOWN);

            if (salt.Length < 1)
                return error.setErrorAndReturnFalse(Error.code.USER_NOT_FOUND);

            //let us hash password

            password = hasher.hash(password, salt);

            //and finally check it

            if (InputValidator.checkPasswordMatch(UDF, password))
            {
                error.no = Error.code.OK;
                //set log in timestamp
                UserDataPusher.pushToFile(username);
                return true;
            }

            error.no = Error.code.WRONG_PASSWORD;
            return false;
        }//logIn

        public static bool setLoggedIn(UserDataFetcher UDF) //# change to private
        {
            if (!InputValidator.validateId(UDF.getId()))
                return error.setErrorAndReturnFalse(Error.code.USER_NOT_FOUND);
            if (UDF.getCurrentUserTimeStamp().isTimeStampOlderThan(7 * 24))
                //user has not been logged in for a whole week
                return true;
            return true;
        }

        public static bool register(UserDataFetcher UDF, string username, string email, string password, string passwordRepeat)
        {
            error.no = Error.code.OK;
            //valid username password
            if (!InputValidator.validateUsername(username))
                return error.setErrorAndReturnFalse(
                    InputValidator.error.no | Error.code.INVALID_USERNAME);
            if (!InputValidator.validatePassword(password, passwordRepeat))
                return error.setErrorAndReturnFalse(
                    InputValidator.error.no | Error.code.INVALID_PASSWORD); //#trigger pass

            //valid email
            System.Net.Mail.MailAddress mail;
            if (!InputValidator.validateEmail(email, out mail))
                return error.setErrorAndReturnFalse(Error.code.INVALID_EMAIL);

            //taken email username
            if (!InputValidator.checkEmailNotTaken(UDF, mail))
                return error.setErrorAndReturnFalse(Error.code.EMAIL_TAKEN);
            if (!InputValidator.checkUsernameNotTaken(UDF, username))
                return error.setErrorAndReturnFalse(Error.code.USERNAME_TAKEN);

            //hash and retrieve used salt
            string hashedPass = hasher.hash(password, saveUsedSalt: true); //^named argument
            string usedSalt = hasher.getLastUsedSaltAndForgetIt();

            //push user
            UserDataPusher.pushNewUser(username, mail, hashedPass, usedSalt);

            //was it successful?
            if (InputValidator.checkUsernameNotTaken(UDF, username))
                return error.setErrorAndReturnFalse(Error.code.PUSH_ERROR);
            return true;
        }

    }//class
}//namespace

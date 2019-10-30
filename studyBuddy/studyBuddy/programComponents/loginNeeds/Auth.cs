using studyBuddy.dataNeeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studyBuddy.extensions;
using studyBuddy.programComponents.profileNeeds;
using System.Windows.Forms;

namespace studyBuddy.programComponents.loginNeeds
{
    abstract internal class Auth
    {
        private static PasswordHasher hasher = new PasswordHasher(saltLength: 12, derivedLength: 39); // not base64 length !!!
        public static Error error = new Error(ErrorCode.UNKNOWN);
        private static PasswordHasher timestampHasher = new PasswordHasher(derivedLength: 20);
        public static string messageToOutterWorld =""; //#delete me
        public static bool LogIn(UserDataFetcher UDF, string username, string password)
        {

            string salt;

            if (!InputValidator.ValidatePassword(password))
                return error.SetErrorAndReturnFalse(ErrorCode.WRONG_PASSWORD | InputValidator.error.no);
            //is it username?
            if (InputValidator.ValidateUsername(username))
            {
                //-yes. get salt
                salt = UDF.GetSalt(username);
            }
            //was it too short?
            else if (InputValidator.error.no != ErrorCode.TOO_SHORT)
            {
                //-yes. is it email?
                System.Net.Mail.MailAddress email;
                string Email = username;
                if (InputValidator.ValidateEmail(Email, out email))
                {
                    //--yes. get salt
                    salt = UDF.GetSalt(email);
                }
                //--no. return false but before set error
                else
                    return error.SetErrorAndReturnFalse(ErrorCode.INVALID_EMAIL | ErrorCode.INVALID_USERNAME);
            }
            //it was not username nor email. Let the input validator say what was the problem
            else
            {
                return error.SetErrorAndReturnFalse(InputValidator.error.no | ErrorCode.INVALID_USERNAME);
            }

            //we have a salt
            //or maybe we should have it

            if (salt == null)
                return error.SetErrorAndReturnFalse(ErrorCode.UNKNOWN);

            if (salt.Length < 1)
                return error.SetErrorAndReturnFalse(ErrorCode.USER_NOT_FOUND);

            //let us hash password

            password = hasher.Hash(password, salt);

            //and finally check it

            if (InputValidator.CheckPasswordMatch(UDF, password))
            {
                error.no = ErrorCode.OK;
                //set log in timestamp
                UserDataPusher.PushSessionFileUser(username);
                if(SetSession(UDF))
                {
                    Auth.SetCurrentUser(username, UDF);
                    return true;
                }
                return false;
            }

            error.no = ErrorCode.WRONG_PASSWORD;
            return false;
        }//logIn

        private static void SetCurrentUser(string username, UserDataFetcher UDF)
        {
            List<User> users = DataFetcher.GetUsersAsList();
            int id = UDF.GetId();
            List<string> interests = new List<string>();
            DataFetcher.GetInterestsOfCurrentUserAsList(interests, id);
            //if logged in with username
            if (InputValidator.ValidateUsername(username))
            {
                findUser();
            }
            else
            {
                System.Net.Mail.MailAddress email;
                string Email = username;
                //if logged in with email
                if (InputValidator.ValidateEmail(Email, out email))
                    findUser();
            }

            //find user in db with same id and set CurrentUser's fields
            void findUser()
            {
                for (var i = 0; i < users.Count; i++)
                {
                    if (id == users[i].id)
                    {
                        CurrentUser.setUserInfo(users[i].name, users[i].id, users[i].karma, users[i].rating, users[i].profileInfo, interests, users[i].upForTeaching);
                        break;
                    }
                }
            }
        }

        private static bool SetSession(UserDataFetcher UDF)
        {
            /* Session. unix in file.
             * we will hash it.
             * send it to server.
             * __________________
             * check procedure: 
             * if hash matches -> proceed
             * does not match -> invalid session
             */
            if (!InputValidator.ValidateId(UDF.GetId()))
                return error.SetErrorAndReturnFalse(ErrorCode.USER_NOT_FOUND);
            //-----timestamp
            long unix = DataFetcher.GetServerTimeStamp();
            UserDataPusher.PushSessionFileLoggedIn(unix);
            string hashedUnix = timestampHasher.Hash(unix.ToString(), DataFetcher.GetDeviceIdentifier());
            UserDataPusher.UpdateUserSession(UDF, unix, hashedUnix);
            //System.Windows.Forms.MessageBox.Show($"hashedUnix: {hashedUnix} ({hashedUnix.Length})");

            return true;
            /*
            if (UDF.GetCurrentUserTimeStamp().IsTimeStampOlderThan(7 * 24)) //^extension
                //user has not been logged in for a whole week
                return true;
            return true;
            */
        }

        public static bool LogInUsingSession()
        {
            //is timestamp not old?
            long lastUnix = UserDataFetcher.GetLastLoginTimestamp();
            if (lastUnix.IsTimeStampOlderThan(hours: 1,minutes: 5))//^extension
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_SESSION
                    | ErrorCode.OUTDATED); //session became a garbage

            //does user exist?
            UserDataFetcher UDF = new UserDataFetcher();
            string lastUser = UserDataFetcher.GetLastUsedUsername();
            //first validate it, because user is scum
            if (!InputValidator.ValidateUsername(lastUser))
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_USERNAME); //#throw new exception, session file corrupted
            //get id. it might be email or username
            UDF.GetIdByUsernameOrEmail(lastUser, saveId: true);
            if (!InputValidator.ValidateId(UDF.GetId()))
                return error.SetErrorAndReturnFalse(ErrorCode.USER_NOT_FOUND);

            //check hash
            string hashedUnix = timestampHasher.Hash(lastUnix.ToString(), DataFetcher.GetDeviceIdentifier());
            messageToOutterWorld = hashedUnix;
            if (!UDF.IsThisLastLoggedInTimestampHash(hashedUnix) )
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_SESSION);

            //all good
            Auth.SetCurrentUser(lastUser, UDF);
            SetSession(UDF);
            return true;
        }

        public static bool Register(UserDataFetcher UDF, string username, string email, string password, string passwordRepeat)
        {
            error.no = ErrorCode.OK;
            //valid username password
            if (!InputValidator.ValidateUsername(username))
                return error.SetErrorAndReturnFalse(
                    InputValidator.error.no | ErrorCode.INVALID_USERNAME);
            if (!InputValidator.ValidatePassword(password, passwordRepeat))
                return error.SetErrorAndReturnFalse(
                    InputValidator.error.no | ErrorCode.INVALID_PASSWORD); //#trigger pass

            //valid email
            System.Net.Mail.MailAddress mail;
            if (!InputValidator.ValidateEmail(email, out mail))
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_EMAIL);

            //taken email username
            if (!InputValidator.CheckEmailNotTaken(UDF, mail))
                return error.SetErrorAndReturnFalse(ErrorCode.EMAIL_TAKEN);
            if (!InputValidator.CheckUsernameNotTaken(UDF, username))
                return error.SetErrorAndReturnFalse(ErrorCode.USERNAME_TAKEN);

            //hash and retrieve used salt
            string hashedPass = hasher.Hash(password, saveUsedSalt: true); //^named argument
            string usedSalt = hasher.GetLastUsedSaltAndForgetIt();

            //push user
            UserDataPusher.PushNewUser(username, mail, hashedPass, usedSalt);

            //was it successful?
            if (InputValidator.CheckUsernameNotTaken(UDF, username))
                return error.SetErrorAndReturnFalse(ErrorCode.PUSH_ERROR);
            return true;
        }


    }//class
}//namespace

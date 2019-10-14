using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddyForm.dataNeeds
{
    class Error //# possible conversion to struct
    {
        public int no { get; set; } = OK;
        //# trigger struct somewhere
        public const int OK = 0; //0
        public const int TOO_SHORT = 1;
        public const int TOO_LONG = 2;
        public const int INVALID_CHAR = 3;
        public const int INVALID_EMAIL = 4;
        public const int WRONG_PASSWORD = 5;
        public const int PASSWORDS_NOT_MATCH = 6;
        public const int UNKNOWN = 7;
        public const int USER_NOT_FOUND = 8;
        public const int USERNAME_TAKEN = 9;
        public const int EMAIL_TAKEN = 10;
        public const int PUSH_ERROR = 11;

        public Error()
        {
            no = OK;
        }

        public Error(int no)
        {
            this.no = no;
        }

        public bool setErrorAndReturnFalse(int no)
        {
            this.no = no;
            return false;
        }

        public static string message(int no)
        {
            switch (no)
            {
                case OK:
                    return nameof(OK);
                case TOO_SHORT:
                    return nameof(TOO_SHORT);
                case TOO_LONG:
                    return nameof(TOO_LONG);
                case INVALID_CHAR:
                    return nameof(INVALID_CHAR);
                case INVALID_EMAIL:
                    return nameof(INVALID_EMAIL);
                case WRONG_PASSWORD:
                    return nameof(WRONG_PASSWORD);
                case PASSWORDS_NOT_MATCH:
                    return nameof(PASSWORDS_NOT_MATCH);
                case UNKNOWN:
                    return nameof(UNKNOWN);
                case USER_NOT_FOUND:
                    return nameof(USER_NOT_FOUND);
                case USERNAME_TAKEN:
                    return nameof(USERNAME_TAKEN);
                case EMAIL_TAKEN:
                    return nameof(EMAIL_TAKEN);
                case PUSH_ERROR:
                    return nameof(PUSH_ERROR);
                default:
                    return "?";
            }
        }

        public string message()
        {
            return message(this.no);
        }

    }
}

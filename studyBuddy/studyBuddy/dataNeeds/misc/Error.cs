using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    public struct Error //^struct
    {
        public ErrorCode no; // { get; set; } = code.OK;
                        //# trigger struct somewhere
                        /*public const int OK = 0; //0
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
                        public const int PUSH_ERROR = 11;*/
        public string reason;

        

        /*public Error()
        {
            no = code.OK;
        }*/

        public Error(ErrorCode no) : this(no,"")
        {
        }

        public Error(ErrorCode no, string reason)
        {
            this.no = no;
            this.reason = (reason == null)? "":reason;
        }

        public void Clear()
        {
            this.no = ErrorCode.OK;
            this.reason = "";
        }

        public bool SetErrorAndReturnFalse(ErrorCode no)
        {
            this.no = no;
            return false;
        }

        public static string Message(ErrorCode no)
        {
            switch (no)
            {
                case ErrorCode.OK:
                    return nameof(ErrorCode.OK);
                case ErrorCode.TOO_SHORT:
                    return nameof(ErrorCode.TOO_SHORT);
                case ErrorCode.TOO_LONG:
                    return nameof(ErrorCode.TOO_LONG);
                case ErrorCode.INVALID_CHAR:
                    return nameof(ErrorCode.INVALID_CHAR);
                case ErrorCode.INVALID_EMAIL:
                    return nameof(ErrorCode.INVALID_EMAIL);
                case ErrorCode.INVALID_SESSION:
                    return nameof(ErrorCode.INVALID_SESSION);
                case ErrorCode.WRONG_PASSWORD:
                    return nameof(ErrorCode.WRONG_PASSWORD);
                case ErrorCode.PASSWORDS_NOT_MATCH:
                    return nameof(ErrorCode.PASSWORDS_NOT_MATCH);
                case ErrorCode.UNKNOWN:
                    return nameof(ErrorCode.UNKNOWN);
                case ErrorCode.USER_NOT_FOUND:
                    return nameof(ErrorCode.USER_NOT_FOUND);
                case ErrorCode.USERNAME_TAKEN:
                    return nameof(ErrorCode.USERNAME_TAKEN);
                case ErrorCode.EMAIL_TAKEN:
                    return nameof(ErrorCode.EMAIL_TAKEN);
                case ErrorCode.PUSH_ERROR:
                    return nameof(ErrorCode.PUSH_ERROR);
                case ErrorCode.OUTDATED:
                    return nameof(ErrorCode.OUTDATED);
                case ErrorCode.INVALID_TEXT_FIELD:
                    return nameof(ErrorCode.INVALID_TEXT_FIELD);
                case ErrorCode.INVALID_CHOSEN_ITEM:
                    return nameof(ErrorCode.INVALID_CHOSEN_ITEM);
                case ErrorCode.INVALID_NAME:
                    return nameof(ErrorCode.INVALID_NAME);
                case ErrorCode.UPDATE_ERROR:
                    return nameof(ErrorCode.PUSH_ERROR);
                case ErrorCode.NOT_FOUND:
                    return nameof(ErrorCode.NOT_FOUND);
                default:
                    return "?";
            }
        }

        public string Message()
        {
            //return message(this.no);
            string toReturn = $"Error: {no}";
            if (this.reason != null && this.reason.Length > 0)
                toReturn += "\nReason: " + this.reason;
            return toReturn;
        }

    }
}

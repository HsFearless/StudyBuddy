using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddyForm.dataNeeds
{
    struct Error //^struct
    {
        public code no; // { get; set; } = code.OK;
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

        [Flags]
        public enum code //^enum
        {
            UNKNOWN             = 0b_0000_0000_0000_0000_0000_0000_0000_0000,
            OK                  = 0b_0000_0000_0000_0000_0000_0000_0000_0010,
            //trigger
            INVALID_USERNAME    = 0b_0000_0000_0000_0000_0000_0000_0001_0000,
            INVALID_PASSWORD    = 0b_0000_0000_0000_0000_0000_0000_0010_0000,
            INVALID_EMAIL       = 0b_0000_0000_0000_0000_0000_0000_0100_0000,
            WRONG_PASSWORD      = 0b_0000_0000_0000_0000_0000_0000_1000_0000,

            //format
            TOO_SHORT           = 0b_0000_0000_0000_0000_0001_0000_0000_0000,
            TOO_LONG            = 0b_0000_0000_0000_0000_0010_0000_0000_0000,
            INVALID_CHAR        = 0b_0000_0000_0000_0000_0100_0000_0000_0000,
           
            //misc
            PASSWORDS_NOT_MATCH = 0b_0000_0000_0001_0000_0000_0000_0000_0000,
            USER_NOT_FOUND      = 0b_0000_0000_0010_0000_0000_0000_0000_0000,
            USERNAME_TAKEN      = 0b_0000_0000_0100_0000_0000_0000_0000_0000,
            EMAIL_TAKEN         = 0b_0000_0000_1000_0000_0000_0000_0000_0000,
            PUSH_ERROR          = 0b_0000_0001_0000_0000_0000_0000_0000_0000
        }

        /*public Error()
        {
            no = code.OK;
        }*/

        public Error(code no)
        {
            this.no = no;
        }

        public bool SetErrorAndReturnFalse(code no)
        {
            this.no = no;
            return false;
        }

        public static string Message(code no)
        {
            switch (no)
            {
                case code.OK:
                    return nameof(code.OK);
                case code.TOO_SHORT:
                    return nameof(code.TOO_SHORT);
                case code.TOO_LONG:
                    return nameof(code.TOO_LONG);
                case code.INVALID_CHAR:
                    return nameof(code.INVALID_CHAR);
                case code.INVALID_EMAIL:
                    return nameof(code.INVALID_EMAIL);
                case code.WRONG_PASSWORD:
                    return nameof(code.WRONG_PASSWORD);
                case code.PASSWORDS_NOT_MATCH:
                    return nameof(code.PASSWORDS_NOT_MATCH);
                case code.UNKNOWN:
                    return nameof(code.UNKNOWN);
                case code.USER_NOT_FOUND:
                    return nameof(code.USER_NOT_FOUND);
                case code.USERNAME_TAKEN:
                    return nameof(code.USERNAME_TAKEN);
                case code.EMAIL_TAKEN:
                    return nameof(code.EMAIL_TAKEN);
                case code.PUSH_ERROR:
                    return nameof(code.PUSH_ERROR);
                default:
                    return "?";
            }
        }

        public string Message()
        {
            //return message(this.no);
            return $"Error: {no}";
        }

    }
}

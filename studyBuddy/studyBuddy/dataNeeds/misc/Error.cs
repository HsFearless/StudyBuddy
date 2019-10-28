using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
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
            UNKNOWN             = 1,
            OK                  = 2,
            //trigger
            INVALID_USERNAME    =   16,
            INVALID_PASSWORD    =   32,
            INVALID_EMAIL       =   64,
            WRONG_PASSWORD      =  128,
            INVALID_SESSION     =  256,
            INVALID_NAME        =  512,
            INVALID_CHOSEN_ITEM = 1024,
            INVALID_TEXT_FIELD  = 2048,

            //format
            TOO_SHORT           =  4096,
            TOO_LONG            =  8192,
            INVALID_CHAR        = 16384,
           
            //misc
            PASSWORDS_NOT_MATCH = 1048576,
            USER_NOT_FOUND      = 1048576*2,
            USERNAME_TAKEN      = 1048576*4,
            EMAIL_TAKEN         = 1048576*8,
            PUSH_ERROR          = 1048576*16,
            OUTDATED            = 1048576*32
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
                case code.INVALID_SESSION:
                    return nameof(code.INVALID_SESSION);
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
                case code.OUTDATED:
                    return nameof(code.OUTDATED);
                case code.INVALID_TEXT_FIELD:
                    return nameof(code.INVALID_TEXT_FIELD);
                case code.INVALID_CHOSEN_ITEM:
                    return nameof(code.INVALID_CHOSEN_ITEM);
                case code.INVALID_NAME:
                    return nameof(code.INVALID_NAME);
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

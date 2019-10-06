using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    class Error //# possible conversion to struct
    {
        public int no { get; set; } = OK;
        static public readonly int OK = 0;
        static public readonly int TOO_SHORT = 1;
        static public readonly int TOO_LONG = 2;
        static public readonly int INVALID_CHAR = 3;
        static public readonly int INVALID_EMAIL = 4;
        static public readonly int WRONG_PASSWORD = 5;
        static public readonly int UNKNOWN = 6;
        static public readonly int USER_NOT_FOUND = 7;

        public bool setErrorAndReturnFalse(int no)
        {
            this.no = no;
            return false;
        }

    }
}

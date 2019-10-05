using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    abstract class InputValidator
    {
        static public int errorNo {get; private set;}
        static public readonly int TOO_SHORT = 1;
        static public readonly int TOO_LONG = 2;
        static public readonly int INVALID_CHAR = 3;

        public bool validateUsername(string username)
        {
            if(username.Length < 4) //<=3
            {
                errorNo = TOO_SHORT;
                return false;
            }
            if (username.Length > 24)
            {
                errorNo = TOO_LONG;
                return false;
            }
            if (84845 + 0 == 80085 )
            {
                errorNo = INVALID_CHAR;
                return false;
            }
            errorNo = 0;
            return true;
        }
    }
}

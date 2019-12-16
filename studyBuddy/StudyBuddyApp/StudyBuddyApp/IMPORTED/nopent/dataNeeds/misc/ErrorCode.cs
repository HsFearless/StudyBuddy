using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    [Flags]
    public enum ErrorCode //^enum
    {
        UNKNOWN = 1,
        OK = 2,
        //trigger
        INVALID_USERNAME = 16,
        INVALID_PASSWORD = 32,
        INVALID_EMAIL = 64,
        WRONG_PASSWORD = 128,
        INVALID_SESSION = 256,
        INVALID_NAME = 512,
        INVALID_CHOSEN_ITEM = 1024,
        INVALID_TEXT_FIELD = 2048,

        //format
        TOO_SHORT = 4096,
        TOO_LONG = 8192,
        INVALID_CHAR = 16384,

        //misc
        PASSWORDS_NOT_MATCH = 1048576,
        USER_NOT_FOUND = 1048576 * 2,
        USERNAME_TAKEN = 1048576 * 4,
        EMAIL_TAKEN = 1048576 * 8,
        PUSH_ERROR = 1048576 * 16,
        OUTDATED = 1048576 * 32,
        UPDATE_ERROR = 1048576 * 64,
        NOT_FOUND = 1048576 * 128
    }
}

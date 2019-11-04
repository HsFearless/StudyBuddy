using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studyBuddy.dataNeeds;

namespace studyBuddy.exceptions
{
    class InvalidSession : Exception
    {
        public readonly bool loggedOut;
        public readonly bool wasNotLogged;

        public InvalidSession(bool didUserLogOutOnHisFreeWill)
        {
            loggedOut = didUserLogOutOnHisFreeWill;
            wasNotLogged = !didUserLogOutOnHisFreeWill;
        }
        
    }
}

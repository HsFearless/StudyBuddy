using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studyBuddy.dataNeeds;

namespace studyBuddy.extensions
{
    static class LongExtensions
    {
        static public bool IsTimeStampOlderThan(this long timeStamp, int hours)//^extension
        {
            long now = UserDataFetcher.GetTimeStamp();
            now = now - timeStamp;
            if (now <= 0)
                return false;
            if (now / 60 / 60 <= hours)
                return false;
            return true;
        }
    }
}

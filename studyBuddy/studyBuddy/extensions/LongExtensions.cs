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
        static public bool IsTimeStampOlderThan(this long timeStamp, 
            uint hours=0, uint minutes=0, uint seconds=0)//^extension
        {
            uint compareTo = hours * 60 * 60 + minutes * 60 + seconds;
            long now = DataFetcher.GetServerTimeStamp();
            now -= timeStamp;
            if (now <= 0)
                return false;
            if (now <= compareTo)
                return false;
            return true;
        }

    }
}

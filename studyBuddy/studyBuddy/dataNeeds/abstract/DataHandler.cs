using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studyBuddy.dataNeeds;
//using studyBuddyForm.dataNeeds;

namespace studyBuddy.dataNeeds
{
    abstract class DataHandler
    {
        internal protected static MysqlHandler staticSource = new MysqlHandler();
        internal protected static FileHandler file = new FileHandler("sb.txt");
        internal protected MysqlHandler source = DataHandler.staticSource;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddyForm.dataNeeds
{
    abstract class UserDataAbstract
    {
        internal protected static MysqlHandler staticSource = new MysqlHandler();
        internal protected MysqlHandler source = new MysqlHandler();
        internal protected int userId = 0;

        public UserDataAbstract(int userId = 0)
        {
            this.userId = (this.userId <= 0) ? 0 : userId;
        }
    }
}

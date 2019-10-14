using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    abstract class UserDataAbstract : DataHandler
    {
        
        internal protected int userId = 0;

        public UserDataAbstract(int userId = 0)
        {
            this.userId = (this.userId <= 0) ? 0 : userId;
        }
    }
}

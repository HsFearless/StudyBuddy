using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    abstract class DataFetcher : DataHandler
    {
        public static List<string[]> GetSubjectsAsStringList()
        {
            var subjects = staticSource.Select("ID, name FROM " +
                MysqlHandler.tblSubjects);
            return subjects;
        }

        public static misc.Subjects GetSubjects()
        {
            return misc.Subjects.GetInstance();
        }

        //public static GetForumContent

    }
}

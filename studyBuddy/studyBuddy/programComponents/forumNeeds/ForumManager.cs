using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studyBuddy.dataNeeds;
using studyBuddy.programComponents.profileNeeds;

namespace studyBuddy.programComponents.forumNeeds
{
    static class ForumManager
    {
        public static Error error = new Error();
        public static bool NewProblem(String name, Subjects.Subject subject, String description)
        {
            if (!InputValidator.ValidateId(CurrentUser.id))
                return error.SetErrorAndReturnFalse(Error.code.INVALID_SESSION | Error.code.USER_NOT_FOUND);
            if (!InputValidator.ValidateForumProblemName(name))
                return error.SetErrorAndReturnFalse(Error.code.INVALID_NAME | InputValidator.error.no);
            if (subject == null)
                return error.SetErrorAndReturnFalse(Error.code.INVALID_CHOSEN_ITEM);
            if (!InputValidator.ValidateForumProblemDescription(description))
                return error.SetErrorAndReturnFalse(Error.code.INVALID_TEXT_FIELD | InputValidator.error.no);
            return UserDataPusher.PushNewProblem(name, subject, description);
        }
    }
}

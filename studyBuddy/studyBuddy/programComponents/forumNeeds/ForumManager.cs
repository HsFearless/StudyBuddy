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
        public static bool NewProblem(String name, Subjects.Subject subject, String description, ForumContent FC)
        {
            error.no = ErrorCode.OK;
            //user id
            if (!InputValidator.ValidateId(CurrentUser.id))
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_SESSION | ErrorCode.USER_NOT_FOUND);
            //problem name
            if (!InputValidator.ValidateForumProblemName(name))
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_NAME | InputValidator.error.no);
            //chosen dropdown item
            if (subject == null)
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_CHOSEN_ITEM);
            //problem description
            if (!InputValidator.ValidateForumProblemDescription(description))
                return error.SetErrorAndReturnFalse(ErrorCode.INVALID_TEXT_FIELD | InputValidator.error.no);
            //create forum post
            ForumPost forumPost;
            try
            {
                //#watch out. A forum post with ID 0 !
                forumPost = new ForumPost(0, subject.id, name, description, CurrentUser.id);
            }
            catch (Exception)
            {
                return error.SetErrorAndReturnFalse(ErrorCode.UNKNOWN);
            }
            FC.Add(forumPost);
            //push ok
            if (!UserDataPusher.PushNewForumProblem(forumPost))
                return error.SetErrorAndReturnFalse(ErrorCode.PUSH_ERROR);
            return true;
        }
    }
}

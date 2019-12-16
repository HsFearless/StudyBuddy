using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.programComponents.forumNeeds
{
    interface IVotable
    {
        bool Upvote();

        bool TakeBackUpvote();

        string VoteErrorMessage();

        dataNeeds.Error GetError();

    }
}

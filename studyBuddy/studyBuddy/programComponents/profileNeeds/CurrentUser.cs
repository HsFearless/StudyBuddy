using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studyBuddy.programComponents.profileNeeds;
using studyBuddy.dataNeeds;
using System.Net.Mail;

namespace studyBuddy
{
    static class CurrentUser
    {
        public static string name;
        public static int id;
       // public static MailAddress email;
        public static int karma;
        public static int rating;
        //private static bool _isLoggedIn = false;
        public static bool isLoggedIn { get; private set; } = false;
        public static string profileInfo;
        public static List<string> interests;
        public static int upForTeaching;

        public static void SetUserInfo(string username, int id, int karma, int rating, String profileInfo, List<string> interests)
        {
            name = username;
            CurrentUser.id = id;
            CurrentUser.karma = karma;
            CurrentUser.rating = rating;
            CurrentUser.profileInfo = profileInfo;
            CurrentUser.interests = interests;
            CurrentUser.upForTeaching = upForTeaching;
            isLoggedIn = true;
        } 


    }
}

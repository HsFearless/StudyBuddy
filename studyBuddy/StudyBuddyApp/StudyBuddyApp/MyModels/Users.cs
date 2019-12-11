using System;
using System.Collections.Generic;

namespace StudyBuddyApp.MyModels
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public int Karma { get; set; }
        public int Rating { get; set; }
        public int LastActivity { get; set; }
        public string LoggedInHash { get; set; }
        public string ProfileInfo { get; set; }
        public sbyte UpForTeaching { get; set; }
    }
}

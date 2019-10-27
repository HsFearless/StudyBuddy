using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.programComponents.profileNeeds
{
    class User
    {
        public readonly int id;
        public readonly string name;
        public readonly System.Net.Mail.MailAddress email;
        public readonly int karma;
        public readonly int rating;
        public readonly long lastActivity;
        public readonly string profileInfo;
        public readonly List<string> interests;

        public User(int id, string name,
            string email, int karma,
            int rating, long lastActivity, string profileInfo)
        {
            this.id = id;
            this.name = name;
            this.email = new System.Net.Mail.MailAddress(email);
            this.karma = karma;
            this.rating = rating;
            this.lastActivity = lastActivity;
            this.profileInfo = profileInfo;
        }

        public override string ToString()
        {
            return name;
        }

        public string ToString(bool full)
        {
            if (!full)
                return ToString();
            return $"id: {id}, name: {name}, email: {email.Address}, rating: {rating}," +
                $"karma: {karma}, lastActivity: {lastActivity}";
            /*var toReturn = new StringBuilder();
            toReturn.Append("id: ");
            toReturn.Append(this.id);
            toReturn.Append(", name: ");
            toReturn.Append(this.name);
            toReturn.Append(", name: "); 
            return toReturn.toString();*/
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy
{
    class PasswordHasher
    {
        private int saltLength;
        private System.Security.Cryptography.RNGCryptoServiceProvider RNG;

        public PasswordHasher(int saltLength=12)
        {
            this.saltLength = (saltLength > 3) ? saltLength : 12;
            RNG = new System.Security.Cryptography.RNGCryptoServiceProvider();
        }

        public byte[] newSalt()
        {
            var salt = new byte[saltLength];
            RNG.GetBytes(salt);
            return salt;
        }

        public string hash(string pass, byte[] salt)
        {
            //var salt = newSalt();
            var derived = new System.Security.Cryptography.Rfc2898DeriveBytes(pass, salt, 30000);
            //100 000 takes about 3 sec
            var derived64 = Convert.ToBase64String(derived.GetBytes(39));
            var salt64 = Convert.ToBase64String(salt);
            return $"{derived64} (len: {derived64.Length})\n" +
                $"{salt64} (len: {salt64.Length})";

        }
    }
}

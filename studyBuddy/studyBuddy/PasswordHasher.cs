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

        public PasswordHasher(int saltLength=10)
        {
            this.saltLength = (saltLength > 3) ? saltLength : 10;
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
            var derived = new System.Security.Cryptography.Rfc2898DeriveBytes(pass, salt, 1000);
            return $"{Convert.ToBase64String(derived.GetBytes(20))}\n" +
                $"{Convert.ToBase64String(salt)}";

        }
    }
}

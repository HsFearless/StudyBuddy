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
        private int salt64Length;
        private int derivedLength;
        private System.Security.Cryptography.RNGCryptoServiceProvider RNG;
        private string salt;

        public PasswordHasher(int saltLength = 12, int derivedLength = 39)
        {
            this.saltLength = (saltLength > 3) ? saltLength : 12;
            this.derivedLength = (derivedLength > 3) ? derivedLength : 39;
            RNG = new System.Security.Cryptography.RNGCryptoServiceProvider();
            salt64Length = Convert.ToBase64String(NewSalt()).Length;
        }

        private byte[] NewSalt()
        {
            var salt = new byte[saltLength];
            RNG.GetBytes(salt);
            return salt;
        }

        public string GetLastUsedSaltAndForgetIt()
        {
            string temp = salt;
            salt = "";
            return temp;
        }

        public string Hash(string pass, string saltASCII = null, bool saveUsedSalt = false)
        {//#
            byte[] saltBytes = null;
            //is new salt needed or other is provided
            if (saltASCII == null || saltASCII.Length != this.salt64Length)
            { 
                saltBytes = NewSalt();
                if(saveUsedSalt)
                    this.salt = Convert.ToBase64String(saltBytes); 
            }
            else
            {
                saltBytes = Convert.FromBase64String(saltASCII);
                if (saveUsedSalt)
                    this.salt = saltASCII;
            }
            var derived = new System.Security.Cryptography.Rfc2898DeriveBytes(pass, saltBytes, 30000);
            //100 000 takes about 3 sec
            var derived64 = Convert.ToBase64String(derived.GetBytes(this.derivedLength));
            var salt64 = Convert.ToBase64String(saltBytes);
            /*return $"{derived64} (len: {derived64.Length})\n" +
                $"{salt64} (len: {salt64.Length})";*/
            return derived64;
        }
    }
}

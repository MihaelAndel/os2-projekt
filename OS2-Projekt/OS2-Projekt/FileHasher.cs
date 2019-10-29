using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OS2_Projekt
{
    class FileHasher
    {
        public string HashFile(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] hashedBytes = null;
            using(var hasher = new SHA512Managed())
            {
                hashedBytes = hasher.ComputeHash(bytes);
            }

            string hashedText = Convert.ToBase64String(hashedBytes);
            
            return hashedText;
        }
    }
}

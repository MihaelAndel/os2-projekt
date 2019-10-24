using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace OS2_Projekt
{
    static class AESKeyProvider
    {
        private static Aes key = null;

        public static Aes ProvideKey()
        {
            if(key == null)
            {
                key = Aes.Create();
            }
            return key;
        }
    }
}

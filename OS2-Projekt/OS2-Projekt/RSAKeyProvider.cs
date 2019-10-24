using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OS2_Projekt
{
    static class RSAKeyProvider
    {
        private static RSA key = null;

        public static RSA ProvideKey()
        {
            if (key == null)
            {
                key = RSA.Create();
            }
            return key;
        }

    }
}

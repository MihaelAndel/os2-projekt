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
        private static RSACryptoServiceProvider key = null;
        private static RSAParameters parameters;

        public static RSACryptoServiceProvider ProvideKey()
        {
            if (key == null)
            {
                key = new RSACryptoServiceProvider(4096);
                parameters = key.ExportParameters(true);
            }
            return key;
        }

        public static RSA ProvideNewKey()
        {
            key = new RSACryptoServiceProvider(4096);
            return key;
        }

        public static void ImportParams(RSAParameters newParams)
        {
            parameters.D = newParams.D;
            parameters.Modulus = newParams.Modulus;
            key.ImportParameters(parameters);
        }

    }
}

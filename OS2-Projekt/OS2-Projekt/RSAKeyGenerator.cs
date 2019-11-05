using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OS2_Projekt 
{
    class RSAKeyGenerator : IKeyGenerator
    {
        private RSAParameters parameters;
        public string PublicKey;
        public string PrivateKey;

        public RSAKeyGenerator(RSACryptoServiceProvider rsa)
        {
            parameters = rsa.ExportParameters(true);
        }

        public void GenerateKeys()
        {
            PrivateKey = Convert.ToBase64String(parameters.D);
            PublicKey = Convert.ToBase64String(parameters.Modulus);
        }
    }
}

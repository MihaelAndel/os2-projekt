using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OS2_Projekt
{
    class AESKeyGenerator : IKeyGenerator
    {
        private Aes keyProvider;
        public string SecretKey;

        public AESKeyGenerator(Aes aes)
        {
            keyProvider = aes;
        }

        public void GenerateKeys()
        {
            SecretKey = Convert.ToBase64String(keyProvider.Key) + ' ' + Convert.ToBase64String(keyProvider.IV);
        }
    }
}

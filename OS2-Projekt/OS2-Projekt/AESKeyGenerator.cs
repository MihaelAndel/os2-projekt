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
        public List<Tuple<string, byte[]>> secretKey = null;

        public AESKeyGenerator(Aes aes)
        {
            keyProvider = aes;
        }

        public void GenerateKeys()
        {
            secretKey = GenerateSecretKey();
        }

        private List<Tuple<string, byte[]>> GenerateSecretKey()
        {
            List<Tuple<string, byte[]>> keys = new List<Tuple<string, byte[]>>();
            keys.Add(Tuple.Create("Tajni AES ključ", keyProvider.Key));
            return keys;
        }
    }
}

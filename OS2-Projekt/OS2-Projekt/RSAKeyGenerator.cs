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
        private RSA keyProvider;
        private RSAParameters keys;
        public List<Tuple<string, byte[]>> privateKey;
        public List<Tuple<string, byte[]>> publicKey;

        public RSAKeyGenerator()
        {
            keyProvider = RSA.Create();
            keys = keyProvider.ExportParameters(true);
        }

        public void GenerateKeys()
        {
            privateKey = GeneratePrivateKey();
            publicKey = GeneratePublicKey();
        }

        private List<Tuple<string, byte[]>> GeneratePublicKey()
        {
            List<Tuple<string, byte[]>> publicKey = new List<Tuple<string, byte[]>>();

            publicKey.Add(Tuple.Create("Javni ključ - modulus (n)", keys.Modulus));
            publicKey.Add(Tuple.Create("Javni ključ - exponent (e)", keys.Exponent));

            return publicKey;

        }

        private List<Tuple<string, byte[]>> GeneratePrivateKey()
        {
            List<Tuple<string, byte[]>> privateKey = new List<Tuple<string, byte[]>>();

            privateKey.Add(Tuple.Create("Privatni ključ - exponent (d)", keys.D));

            return privateKey;
        }
    }
}

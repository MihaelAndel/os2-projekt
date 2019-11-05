using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace OS2_Projekt
{
    class RSAEncryptionService
    {

        private RSACryptoServiceProvider rsaKey;
        
        public RSAEncryptionService()
        {
            string fullPathPrivate = FileManager.RootPath + "privatni_kljuc.txt";
            string fullPathPublic = FileManager.RootPath + "javni_kljuc.txt";
            RSAParameters parameters = new RSAParameters();
            parameters.D = Convert.FromBase64String(FileManager.ReadTextFile(fullPathPrivate));
            parameters.Modulus = Convert.FromBase64String(FileManager.ReadTextFile(fullPathPublic));
            RSAKeyProvider.ImportParams(parameters);
            rsaKey = RSAKeyProvider.ProvideKey();
        }

        public string EncryptText(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] encryptedBytes = rsaKey.Encrypt(bytes, true);

            string encryptedText = Convert.ToBase64String(encryptedBytes);
            return encryptedText;
        }

        public string DecryptText(string text)
        {
            byte[] bytes = Convert.FromBase64String(text);
            byte[] decryptedBytes = rsaKey.Decrypt(bytes, true);

            string decryptedText = Encoding.UTF8.GetString(decryptedBytes);
            return decryptedText;
        }

        public byte[] SignData(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);

            SHA512Managed sha = new SHA512Managed();
            byte[] hashedBytes = sha.ComputeHash(bytes);

            byte[] signedData = rsaKey.SignHash(hashedBytes, CryptoConfig.MapNameToOID("SHA512"));

            return signedData;
        }

        public bool VerifySignature(byte[] data, byte[] signature)
        {
            SHA512Managed sha = new SHA512Managed();
            byte[] hashedBytes = sha.ComputeHash(data);
            return rsaKey.VerifyHash(hashedBytes, CryptoConfig.MapNameToOID("SHA512"), signature);
        }
    }
}

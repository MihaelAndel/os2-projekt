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
            rsaKey = new RSACryptoServiceProvider();
            rsaKey.ImportParameters(RSAKeyProvider.ProvideKey().ExportParameters(true));
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
    }
}

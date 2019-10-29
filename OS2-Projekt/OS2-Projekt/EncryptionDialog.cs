using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace OS2_Projekt
{
    public partial class EncryptionDialog : Form
    {

        private string fileContent;

        public EncryptionDialog()
        {
            InitializeComponent();
        }

        private void UIActionSymEncrypt_Click(object sender, EventArgs e)
        {
            string encryptedContent = "";

            Aes aesKey = AESKeyProvider.ProvideKey();
            var encryptor = aesKey.CreateEncryptor(aesKey.Key, aesKey.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(fileContent);
                    }
                }
                encryptedContent = Convert.ToBase64String(msEncrypt.ToArray());
            }

            FileManager.WriteTextToFile("simetricna-enkripcija.txt", encryptedContent);
        }


        private void UIActionSelectFile_Click(object sender, EventArgs e)
        {
            string pathToFile = FileManager.OpenFile();
            string content = FileManager.ReadTextFile(pathToFile);

            if (content.Length <= 0)
            {
                MessageBox.Show("Učitana datoteka nema sadržaja!");
                return;
            } else
            {
                fileContent = content;
            }
        }

        private void UIActionSymDecrypt_Click(object sender, EventArgs e)
        {
            string decryptedContent = "";
            string encryptedContent = FileManager.ReadTextFile(FileManager.RootPath + "simetricna-enkripcija.txt");

            Aes aesKey = AESKeyProvider.ProvideKey();
            var decryptor = aesKey.CreateDecryptor(aesKey.Key, aesKey.IV);

            using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedContent)))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader swDecrypt = new StreamReader(csDecrypt))
                    {
                        decryptedContent = swDecrypt.ReadToEnd();
                    }
                }
            }
            FileManager.WriteTextToFile("simetricna-dekripcija.txt", decryptedContent);
        }

        private void UIActionAsymEncrypt_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider(2048);

            rsaKey.ImportParameters(RSAKeyProvider.ProvideKey().ExportParameters(true));

            byte[] content = Encoding.UTF8.GetBytes(fileContent);
            byte[] encryptedBytes = rsaKey.Encrypt(content, true);

            string encryptedContent = Convert.ToBase64String(encryptedBytes);
            FileManager.WriteTextToFile("asimetricna-enkripcija.txt", encryptedContent);
        }

        private void UIActionAsymDecrypt_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider(2048);
            rsaKey.ImportParameters(RSAKeyProvider.ProvideKey().ExportParameters(true));

            string fullPath = FileManager.RootPath + "asimetricna-enkripcija.txt";
            string encryptedContent = FileManager.ReadTextFile(fullPath);

            byte[] encryptedBytes = Convert.FromBase64String(encryptedContent);
            byte[] decryptedBytes = rsaKey.Decrypt(encryptedBytes, true);

            string decryptedContent = Encoding.UTF8.GetString(decryptedBytes);
            FileManager.WriteTextToFile("asimetricna-dekripcija.txt", decryptedContent);

        }

        private void UIActionHashFile_Click(object sender, EventArgs e)
        {
            FileHasher hasher = new FileHasher();
            string hashedContent = hasher.HashFile(fileContent);
            FileManager.WriteTextToFile("sazetak.txt", hashedContent);
        }
    }
}

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

        private string pathToFile;

        public EncryptionDialog()
        {
            InitializeComponent();
        }

        private void UIActionSymEncrypt_Click(object sender, EventArgs e)
        {
            string fileContent = FileManager.ReadTextFile(pathToFile);
            string fullPath = FileManager.RootPath + "tajni_kljuc.txt";
            string[] aes = FileManager.ReadTextFile(fullPath).Split(' ');
            byte[] key = Convert.FromBase64String(aes[0]);
            byte[] iv = Convert.FromBase64String(aes[1]);
            string encryptedContent = "";

            Aes aesKey = AESKeyProvider.ProvideKey();
            var encryptor = aesKey.CreateEncryptor(key, iv);

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
            string path = FileManager.OpenFile();

            pathToFile = path;
        }


        private void UIActionSymDecrypt_Click(object sender, EventArgs e)
        {
            string fullPath = FileManager.RootPath + "tajni_kljuc.txt";
            string[] aes = FileManager.ReadTextFile(fullPath).Split(' ');
            byte[] key = Convert.FromBase64String(aes[0]);
            byte[] iv = Convert.FromBase64String(aes[1]);
            string decryptedContent = "";
            string encryptedContent = FileManager.ReadTextFile(FileManager.RootPath + "simetricna-enkripcija.txt");
            Aes aesKey = AESKeyProvider.ProvideKey();
            var decryptor = aesKey.CreateDecryptor(key, iv);

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
            string fileContent = FileManager.ReadTextFile(pathToFile);
            RSAEncryptionService rsa = new RSAEncryptionService();
            string encryptedContent = rsa.EncryptText(fileContent);
            FileManager.WriteTextToFile("asimetricna-enkripcija.txt", encryptedContent);
        }

        private void UIActionAsymDecrypt_Click(object sender, EventArgs e)
        {
            RSAEncryptionService rsa = new RSAEncryptionService();

            string fullPath = FileManager.RootPath + "asimetricna-enkripcija.txt";
            string encryptedContent = FileManager.ReadTextFile(fullPath);

            string decryptedContent = rsa.DecryptText(encryptedContent);

            FileManager.WriteTextToFile("asimetricna-dekripcija.txt", decryptedContent);

        }

        private void UIActionHashFile_Click(object sender, EventArgs e)
        {
            string fileContent = FileManager.ReadTextFile(pathToFile);
            FileHasher hasher = new FileHasher();
            string hashedContent = hasher.HashFile(fileContent);
            FileManager.WriteTextToFile("sazetak.txt", hashedContent);
        }

        private void UIActionCreateSignature_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pathToFile);
            string fileContent = FileManager.ReadTextFile(pathToFile);
            MessageBox.Show(fileContent);
            RSAEncryptionService rsa = new RSAEncryptionService();
            string signedContent = rsa.SignData(fileContent);
            MessageBox.Show(signedContent);

            FileManager.WriteTextToFile("potpis.txt", signedContent);
        }

        private void UIActionVerifySignature_Click(object sender, EventArgs e)
        {
            string pathToHash = FileManager.RootPath + "potpis.txt";
            string pathToData = pathToFile;

            string signature = FileManager.ReadTextFile(pathToHash);

            byte[] hash = Convert.FromBase64String(signature);
            
            byte[] data = Encoding.UTF8.GetBytes(FileManager.ReadTextFile(pathToData));
            MessageBox.Show(Encoding.UTF8.GetString(data));
            RSAEncryptionService rsa = new RSAEncryptionService();
            
            if(rsa.VerifySignature(hash, data) == true)
            {
                MessageBox.Show("Potpis je valjan!");
            } else
            {
                MessageBox.Show("Potpis nije valjan!");
            }

        }
    }
}

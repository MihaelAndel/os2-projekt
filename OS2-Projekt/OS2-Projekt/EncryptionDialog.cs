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
            Aes aesKey = AESKeyProvider.ProvideKey();
            var encryptor = aesKey.CreateEncryptor();

            byte[] content = Encoding.UTF8.GetBytes(fileContent);
            byte[] encryptedBytes = encryptor.TransformFinalBlock(content, 0, content.Length);

            string encryptedContent = Convert.ToBase64String(encryptedBytes);
            FileManager.WriteTextToFile("simetricna-enkripcija.txt", encryptedContent);
        }

        private void UIActionAsymEncrypt_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();

            rsaKey.ImportParameters(RSAKeyProvider.ProvideKey().ExportParameters(true));

            byte[] content = Encoding.UTF8.GetBytes(fileContent);
            byte[] encryptedBytes = rsaKey.Encrypt(content, true); 

            string encryptedContent = Convert.ToBase64String(encryptedBytes);
            FileManager.WriteTextToFile("asimetricna-enkripcija.txt", encryptedContent);
        }

        private void UIActionSelectFile_Click(object sender, EventArgs e)
        {
            string pathToFile = FileManager.OpenFile();
            string content = FileManager.ReadTextFile(pathToFile);

            if(content.Length <= 0)
            {
                MessageBox.Show("Učitana datoteka nema sadržaja!");
                return;
            }
            else
            {
                fileContent = content;
            }
        }
    }
}

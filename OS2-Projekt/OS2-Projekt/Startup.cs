using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace OS2_Projekt
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
            UIActionOpenEncryptionDialog.Enabled = false;
            FileManager.RootPath = @"C:\Users\andel\Documents\Repozitoriji\os2-projekt\datoteke\";
        }

        private void UIActionCreateKeyFiles_Click(object sender, EventArgs e)
        { 
            RSAKeyGenerator rsaGenerator = new RSAKeyGenerator(RSAKeyProvider.ProvideKey());
            AESKeyGenerator aesGenerator = new AESKeyGenerator(AESKeyProvider.ProvideKey());

            rsaGenerator.GenerateKeys();
            aesGenerator.GenerateKeys();

            FileManager.WriteTextToFile("javni_kljuc.txt", rsaGenerator.PublicKey);
            FileManager.WriteTextToFile("privatni_kljuc.txt", rsaGenerator.PrivateKey);
            FileManager.WriteTextToFile("tajni_kljuc.txt", aesGenerator.SecretKey);

            UIActionOpenEncryptionDialog.Enabled = true;
        }

        private void UIActionOpenEncryptionDialog_Click(object sender, EventArgs e)
        {
            EncryptionDialog encryptionDialog = new EncryptionDialog();
            encryptionDialog.Show();
        }
    }
}

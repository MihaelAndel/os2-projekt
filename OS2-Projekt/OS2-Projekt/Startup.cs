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
            FileManager.RootPath = @"C:\Users\andel\Documents\Repozitoriji\os2-projekt\datoteke\";
        }

        private void UIActionCreateKeyFiles_Click(object sender, EventArgs e)
        {
            RSA rsa = RSA.Create();
            Aes aes = Aes.Create();

            RSAKeyGenerator rsaGenerator = new RSAKeyGenerator(rsa);
            AESKeyGenerator aesGenerator = new AESKeyGenerator(aes);

            rsaGenerator.GenerateKeys();
            aesGenerator.GenerateKeys();

            FileManager.WriteKeyToFile("javni.txt", rsaGenerator.publicKey);
            FileManager.WriteKeyToFile("privatni.txt", rsaGenerator.privateKey);
            FileManager.WriteKeyToFile("tajni.txt", aesGenerator.secretKey);
            
        }
    }
}

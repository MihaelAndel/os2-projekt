using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS2_Projekt
{
    public partial class EncryptionDialog : Form
    {
        public EncryptionDialog()
        {
            InitializeComponent();
        }

        private void UIActionSymEncrypt_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK) { }
            }
        }

        private void UIActionAsymEncrypt_Click(object sender, EventArgs e)
        {

        }
    }
}

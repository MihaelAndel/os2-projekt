namespace OS2_Projekt
{
    partial class EncryptionDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UIActionSymEncrypt = new System.Windows.Forms.Button();
            this.UIActionAsymEncrypt = new System.Windows.Forms.Button();
            this.UIActionSelectFile = new System.Windows.Forms.Button();
            this.UIActionSymDecrypt = new System.Windows.Forms.Button();
            this.UIActionAsymDecrypt = new System.Windows.Forms.Button();
            this.UIActionHashFile = new System.Windows.Forms.Button();
            this.UIActionCreateSignature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UIActionSymEncrypt
            // 
            this.UIActionSymEncrypt.Location = new System.Drawing.Point(538, 105);
            this.UIActionSymEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UIActionSymEncrypt.Name = "UIActionSymEncrypt";
            this.UIActionSymEncrypt.Size = new System.Drawing.Size(200, 50);
            this.UIActionSymEncrypt.TabIndex = 0;
            this.UIActionSymEncrypt.Text = "Simetrično kriptiranje datoteke";
            this.UIActionSymEncrypt.UseVisualStyleBackColor = true;
            this.UIActionSymEncrypt.Click += new System.EventHandler(this.UIActionSymEncrypt_Click);
            // 
            // UIActionAsymEncrypt
            // 
            this.UIActionAsymEncrypt.Location = new System.Drawing.Point(289, 105);
            this.UIActionAsymEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UIActionAsymEncrypt.Name = "UIActionAsymEncrypt";
            this.UIActionAsymEncrypt.Size = new System.Drawing.Size(200, 50);
            this.UIActionAsymEncrypt.TabIndex = 1;
            this.UIActionAsymEncrypt.Text = "Asimetrično kriptiranje datoteke";
            this.UIActionAsymEncrypt.UseVisualStyleBackColor = true;
            this.UIActionAsymEncrypt.Click += new System.EventHandler(this.UIActionAsymEncrypt_Click);
            // 
            // UIActionSelectFile
            // 
            this.UIActionSelectFile.Location = new System.Drawing.Point(49, 36);
            this.UIActionSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.UIActionSelectFile.Name = "UIActionSelectFile";
            this.UIActionSelectFile.Size = new System.Drawing.Size(200, 50);
            this.UIActionSelectFile.TabIndex = 2;
            this.UIActionSelectFile.Text = "Odabir datoteke za kriptiranje";
            this.UIActionSelectFile.UseVisualStyleBackColor = true;
            this.UIActionSelectFile.Click += new System.EventHandler(this.UIActionSelectFile_Click);
            // 
            // UIActionSymDecrypt
            // 
            this.UIActionSymDecrypt.Location = new System.Drawing.Point(538, 161);
            this.UIActionSymDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.UIActionSymDecrypt.Name = "UIActionSymDecrypt";
            this.UIActionSymDecrypt.Size = new System.Drawing.Size(200, 50);
            this.UIActionSymDecrypt.TabIndex = 3;
            this.UIActionSymDecrypt.Text = "Simetrično dekriptiranje";
            this.UIActionSymDecrypt.UseVisualStyleBackColor = true;
            this.UIActionSymDecrypt.Click += new System.EventHandler(this.UIActionSymDecrypt_Click);
            // 
            // UIActionAsymDecrypt
            // 
            this.UIActionAsymDecrypt.Location = new System.Drawing.Point(289, 161);
            this.UIActionAsymDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.UIActionAsymDecrypt.Name = "UIActionAsymDecrypt";
            this.UIActionAsymDecrypt.Size = new System.Drawing.Size(200, 50);
            this.UIActionAsymDecrypt.TabIndex = 4;
            this.UIActionAsymDecrypt.Text = "Asimetrično dekriptiranje";
            this.UIActionAsymDecrypt.UseVisualStyleBackColor = true;
            this.UIActionAsymDecrypt.Click += new System.EventHandler(this.UIActionAsymDecrypt_Click);
            // 
            // UIActionHashFile
            // 
            this.UIActionHashFile.Location = new System.Drawing.Point(52, 236);
            this.UIActionHashFile.Name = "UIActionHashFile";
            this.UIActionHashFile.Size = new System.Drawing.Size(200, 50);
            this.UIActionHashFile.TabIndex = 5;
            this.UIActionHashFile.Text = "Kreiranje sažetka datoteke";
            this.UIActionHashFile.UseVisualStyleBackColor = true;
            this.UIActionHashFile.Click += new System.EventHandler(this.UIActionHashFile_Click);
            // 
            // UIActionCreateSignature
            // 
            this.UIActionCreateSignature.Location = new System.Drawing.Point(289, 236);
            this.UIActionCreateSignature.Name = "UIActionCreateSignature";
            this.UIActionCreateSignature.Size = new System.Drawing.Size(200, 50);
            this.UIActionCreateSignature.TabIndex = 6;
            this.UIActionCreateSignature.Text = "Stvori digitalni potpis";
            this.UIActionCreateSignature.UseVisualStyleBackColor = true;
            this.UIActionCreateSignature.Click += new System.EventHandler(this.UIActionCreateSignature_Click);
            // 
            // EncryptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UIActionCreateSignature);
            this.Controls.Add(this.UIActionHashFile);
            this.Controls.Add(this.UIActionAsymDecrypt);
            this.Controls.Add(this.UIActionSymDecrypt);
            this.Controls.Add(this.UIActionSelectFile);
            this.Controls.Add(this.UIActionAsymEncrypt);
            this.Controls.Add(this.UIActionSymEncrypt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EncryptionDialog";
            this.Text = "EncryptionDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UIActionSymEncrypt;
        private System.Windows.Forms.Button UIActionAsymEncrypt;
        private System.Windows.Forms.Button UIActionSelectFile;
        private System.Windows.Forms.Button UIActionSymDecrypt;
        private System.Windows.Forms.Button UIActionAsymDecrypt;
        private System.Windows.Forms.Button UIActionHashFile;
        private System.Windows.Forms.Button UIActionCreateSignature;
    }
}
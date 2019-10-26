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
            this.SuspendLayout();
            // 
            // UIActionSymEncrypt
            // 
            this.UIActionSymEncrypt.Location = new System.Drawing.Point(24, 20);
            this.UIActionSymEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UIActionSymEncrypt.Name = "UIActionSymEncrypt";
            this.UIActionSymEncrypt.Size = new System.Drawing.Size(225, 41);
            this.UIActionSymEncrypt.TabIndex = 0;
            this.UIActionSymEncrypt.Text = "Simetrično kriptiranje datoteke";
            this.UIActionSymEncrypt.UseVisualStyleBackColor = true;
            this.UIActionSymEncrypt.Click += new System.EventHandler(this.UIActionSymEncrypt_Click);
            // 
            // UIActionAsymEncrypt
            // 
            this.UIActionAsymEncrypt.Location = new System.Drawing.Point(262, 20);
            this.UIActionAsymEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UIActionAsymEncrypt.Name = "UIActionAsymEncrypt";
            this.UIActionAsymEncrypt.Size = new System.Drawing.Size(225, 41);
            this.UIActionAsymEncrypt.TabIndex = 1;
            this.UIActionAsymEncrypt.Text = "Asimetrično kriptiranje datoteke";
            this.UIActionAsymEncrypt.UseVisualStyleBackColor = true;
            this.UIActionAsymEncrypt.Click += new System.EventHandler(this.UIActionAsymEncrypt_Click);
            // 
            // UIActionSelectFile
            // 
            this.UIActionSelectFile.Location = new System.Drawing.Point(24, 106);
            this.UIActionSelectFile.Name = "UIActionSelectFile";
            this.UIActionSelectFile.Size = new System.Drawing.Size(225, 41);
            this.UIActionSelectFile.TabIndex = 2;
            this.UIActionSelectFile.Text = "Odabir datoteke za kriptiranje";
            this.UIActionSelectFile.UseVisualStyleBackColor = true;
            this.UIActionSelectFile.Click += new System.EventHandler(this.UIActionSelectFile_Click);
            // 
            // EncryptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.UIActionSelectFile);
            this.Controls.Add(this.UIActionAsymEncrypt);
            this.Controls.Add(this.UIActionSymEncrypt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EncryptionDialog";
            this.Text = "EncryptionDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UIActionSymEncrypt;
        private System.Windows.Forms.Button UIActionAsymEncrypt;
        private System.Windows.Forms.Button UIActionSelectFile;
    }
}
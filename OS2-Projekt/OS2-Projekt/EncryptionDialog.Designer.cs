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
            this.SuspendLayout();
            // 
            // UIActionSymEncrypt
            // 
            this.UIActionSymEncrypt.Location = new System.Drawing.Point(32, 24);
            this.UIActionSymEncrypt.Name = "UIActionSymEncrypt";
            this.UIActionSymEncrypt.Size = new System.Drawing.Size(300, 50);
            this.UIActionSymEncrypt.TabIndex = 0;
            this.UIActionSymEncrypt.Text = "Simetrično kriptiranje - odabir datoteke";
            this.UIActionSymEncrypt.UseVisualStyleBackColor = true;
            this.UIActionSymEncrypt.Click += new System.EventHandler(this.UIActionSymEncrypt_Click);
            // 
            // UIActionAsymEncrypt
            // 
            this.UIActionAsymEncrypt.Location = new System.Drawing.Point(349, 24);
            this.UIActionAsymEncrypt.Name = "UIActionAsymEncrypt";
            this.UIActionAsymEncrypt.Size = new System.Drawing.Size(300, 50);
            this.UIActionAsymEncrypt.TabIndex = 1;
            this.UIActionAsymEncrypt.Text = "Asimetrično kriptiranje - odabir datoteke";
            this.UIActionAsymEncrypt.UseVisualStyleBackColor = true;
            this.UIActionAsymEncrypt.Click += new System.EventHandler(this.UIActionAsymEncrypt_Click);
            // 
            // EncryptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UIActionAsymEncrypt);
            this.Controls.Add(this.UIActionSymEncrypt);
            this.Name = "EncryptionDialog";
            this.Text = "EncryptionDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UIActionSymEncrypt;
        private System.Windows.Forms.Button UIActionAsymEncrypt;
    }
}
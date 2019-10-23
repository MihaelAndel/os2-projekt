namespace OS2_Projekt
{
    partial class Startup
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
            this.UIActionCreateKeyFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UIActionCreateKeyFiles
            // 
            this.UIActionCreateKeyFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UIActionCreateKeyFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UIActionCreateKeyFiles.FlatAppearance.BorderSize = 0;
            this.UIActionCreateKeyFiles.Location = new System.Drawing.Point(215, 154);
            this.UIActionCreateKeyFiles.Name = "UIActionCreateKeyFiles";
            this.UIActionCreateKeyFiles.Size = new System.Drawing.Size(141, 62);
            this.UIActionCreateKeyFiles.TabIndex = 0;
            this.UIActionCreateKeyFiles.Text = "Stvori datoteke s ključevima";
            this.UIActionCreateKeyFiles.UseVisualStyleBackColor = true;
            this.UIActionCreateKeyFiles.Click += new System.EventHandler(this.UIActionCreateKeyFiles_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UIActionCreateKeyFiles);
            this.Name = "Startup";
            this.Text = "Operacijski Sustavi 2 - Projekt - Mihael Anđel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UIActionCreateKeyFiles;
    }
}
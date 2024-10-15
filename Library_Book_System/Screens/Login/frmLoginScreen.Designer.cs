namespace Library_Book_System.Screens.Login
{
    partial class frmLoginScreen
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
            this.ctrLoginCredentials1 = new Library_Book_System.Controls.ctrLoginCredentials();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrLoginCredentials1
            // 
            this.ctrLoginCredentials1.Location = new System.Drawing.Point(12, 76);
            this.ctrLoginCredentials1.Name = "ctrLoginCredentials1";
            this.ctrLoginCredentials1.Size = new System.Drawing.Size(295, 176);
            this.ctrLoginCredentials1.TabIndex = 0;
            this.ctrLoginCredentials1.onLoginAttemptComplete += new System.EventHandler<Library_Book_System.Controls.ctrLoginCredentials.LoginAttemptEventArgs>(this.ctrLoginCredentials1_onLoginAttemptComplete);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Book_System.Properties.Resources.library;
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrLoginCredentials1);
            this.Name = "frmLoginScreen";
            this.Text = "Login Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrLoginCredentials ctrLoginCredentials1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
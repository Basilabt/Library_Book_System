namespace Library_Book_System.Screens.Reservations
{
    partial class frmListReservations
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
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrListReservations1 = new Library_Book_System.Controls.ctrListReservations();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(792, 491);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Book_System.Properties.Resources.booking;
            this.pictureBox1.Location = new System.Drawing.Point(390, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ctrListReservations1
            // 
            this.ctrListReservations1.BackColor = System.Drawing.Color.White;
            this.ctrListReservations1.Location = new System.Drawing.Point(-19, 76);
            this.ctrListReservations1.Name = "ctrListReservations1";
            this.ctrListReservations1.Size = new System.Drawing.Size(905, 411);
            this.ctrListReservations1.TabIndex = 3;
            this.ctrListReservations1.onSearchAttempt += new System.EventHandler<Library_Book_System.Controls.ctrListReservations.SearchAttemptArgs>(this.ctrListReservations1_onSearchAttempt);
            // 
            // frmListReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 533);
            this.Controls.Add(this.ctrListReservations1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmListReservations";
            this.Text = "List Reservations";
            this.Load += new System.EventHandler(this.frmListReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.ctrListReservations ctrListReservations1;
    }
}
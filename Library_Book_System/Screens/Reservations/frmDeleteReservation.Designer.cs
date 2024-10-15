namespace Library_Book_System.Screens.Reservations
{
    partial class frmDeleteReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteReservation));
            this.ctrFindReservation1 = new Library_Book_System.Controls.ctrFindReservation();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrFindReservation1
            // 
            this.ctrFindReservation1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ctrFindReservation1, "ctrFindReservation1");
            this.ctrFindReservation1.Name = "ctrFindReservation1";
            this.ctrFindReservation1.onSearchAttempt += new System.EventHandler<Library_Book_System.Controls.ctrFindReservation.SearchAttemptArgs>(this.ctrFindReservation1_onSearchAttempt);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeleteReservation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ctrFindReservation1);
            this.Name = "frmDeleteReservation";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrFindReservation ctrFindReservation1;
        private System.Windows.Forms.Button btnDelete;
    }
}
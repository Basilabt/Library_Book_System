namespace Library_Book_System.Screens.Copies
{
    partial class frmDeleteCopy
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.ctrFindBookCopy1 = new Library_Book_System.Controls.ctrFindBookCopy();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(329, 297);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ctrFindBookCopy1
            // 
            this.ctrFindBookCopy1.BackColor = System.Drawing.Color.White;
            this.ctrFindBookCopy1.Location = new System.Drawing.Point(12, -1);
            this.ctrFindBookCopy1.Name = "ctrFindBookCopy1";
            this.ctrFindBookCopy1.Size = new System.Drawing.Size(784, 292);
            this.ctrFindBookCopy1.TabIndex = 2;
            this.ctrFindBookCopy1.onSearchAttempt += new System.EventHandler<Library_Book_System.Controls.ctrFindBookCopy.SearchAttemptEventArgs>(this.ctrFindBookCopy1_onSearchAttempt);
            // 
            // frmDeleteCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 338);
            this.Controls.Add(this.ctrFindBookCopy1);
            this.Controls.Add(this.btnDelete);
            this.Name = "frmDeleteCopy";
            this.Text = "Delete Copy";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private Controls.ctrFindBookCopy ctrFindBookCopy1;
    }
}
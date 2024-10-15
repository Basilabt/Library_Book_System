namespace Library_Book_System.Screens.Borrowings
{
    partial class frmDeleteBorrowing
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
            this.ctrFindBorrowing1 = new Library_Book_System.Controls.ctrFindBorrowing();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(383, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 28);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ctrFindBorrowing1
            // 
            this.ctrFindBorrowing1.BackColor = System.Drawing.Color.White;
            this.ctrFindBorrowing1.Location = new System.Drawing.Point(12, 12);
            this.ctrFindBorrowing1.Name = "ctrFindBorrowing1";
            this.ctrFindBorrowing1.Size = new System.Drawing.Size(879, 231);
            this.ctrFindBorrowing1.TabIndex = 0;
            this.ctrFindBorrowing1.onSearchAttempt += new System.EventHandler<Library_Book_System.Controls.ctrFindBorrowing.SearchAttemptArgs>(this.ctrFindBorrowing1_onSearchAttempt);
            // 
            // frmDeleteBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 300);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ctrFindBorrowing1);
            this.Name = "frmDeleteBorrowing";
            this.Text = "Delete Borrowing";
            this.Load += new System.EventHandler(this.frmDeleteBorrowing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrFindBorrowing ctrFindBorrowing1;
        private System.Windows.Forms.Button btnDelete;
    }
}
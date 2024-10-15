namespace Library_Book_System.Screens.Users
{
    partial class frmDeleteUser
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
            this.ctrFindUser1 = new Library_Book_System.Controls.ctrFindUser();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrFindUser1
            // 
            this.ctrFindUser1.BackColor = System.Drawing.Color.White;
            this.ctrFindUser1.ForeColor = System.Drawing.Color.White;
            this.ctrFindUser1.Location = new System.Drawing.Point(8, 12);
            this.ctrFindUser1.Name = "ctrFindUser1";
            this.ctrFindUser1.Size = new System.Drawing.Size(881, 275);
            this.ctrFindUser1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(387, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 327);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ctrFindUser1);
            this.Name = "frmDeleteUser";
            this.Text = "Delete User";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrFindUser ctrFindUser1;
        private System.Windows.Forms.Button btnDelete;
    }
}
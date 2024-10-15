namespace Library_Book_System.Screens.Copies
{
    partial class frmAddCopies
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxNumberOfCopiesToAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.ctrFindBook1 = new Library_Book_System.Controls.ctrFindBook();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtboxNumberOfCopiesToAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Copy";
            // 
            // txtboxNumberOfCopiesToAdd
            // 
            this.txtboxNumberOfCopiesToAdd.Location = new System.Drawing.Point(151, 45);
            this.txtboxNumberOfCopiesToAdd.Name = "txtboxNumberOfCopiesToAdd";
            this.txtboxNumberOfCopiesToAdd.Size = new System.Drawing.Size(300, 20);
            this.txtboxNumberOfCopiesToAdd.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of Copies To Add:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.Location = new System.Drawing.Point(393, 354);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(186, 36);
            this.btnAddCopy.TabIndex = 2;
            this.btnAddCopy.Text = "Add";
            this.btnAddCopy.UseVisualStyleBackColor = true;
            this.btnAddCopy.Click += new System.EventHandler(this.btnAddCopy_Click);
            // 
            // ctrFindBook1
            // 
            this.ctrFindBook1.BackColor = System.Drawing.Color.White;
            this.ctrFindBook1.Location = new System.Drawing.Point(0, -2);
            this.ctrFindBook1.Name = "ctrFindBook1";
            this.ctrFindBook1.Size = new System.Drawing.Size(997, 240);
            this.ctrFindBook1.TabIndex = 3;
            this.ctrFindBook1.onSearchAttempt += new System.EventHandler<Library_Book_System.Controls.ctrFindBook.SearchAttemptEventArgs>(this.ctrFindBook1_onSearchAttempt);
            // 
            // frmAddCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 402);
            this.Controls.Add(this.ctrFindBook1);
            this.Controls.Add(this.btnAddCopy);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddCopies";
            this.Text = "Add Copies";
            this.Load += new System.EventHandler(this.frmAddCopies_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxNumberOfCopiesToAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCopy;
        private Controls.ctrFindBook ctrFindBook1;
    }
}
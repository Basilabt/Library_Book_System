namespace Library_Book_System.Controls
{
    partial class ctrFindReservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupboxFindReservation = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtboxReservationID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupboxReservation = new System.Windows.Forms.GroupBox();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupboxFindReservation.SuspendLayout();
            this.groupboxReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxFindReservation
            // 
            this.groupboxFindReservation.Controls.Add(this.btnSearch);
            this.groupboxFindReservation.Controls.Add(this.txtboxReservationID);
            this.groupboxFindReservation.Controls.Add(this.label1);
            this.groupboxFindReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxFindReservation.Location = new System.Drawing.Point(12, 16);
            this.groupboxFindReservation.Name = "groupboxFindReservation";
            this.groupboxFindReservation.Size = new System.Drawing.Size(833, 68);
            this.groupboxFindReservation.TabIndex = 0;
            this.groupboxFindReservation.TabStop = false;
            this.groupboxFindReservation.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Library_Book_System.Properties.Resources.search__2_;
            this.btnSearch.Location = new System.Drawing.Point(286, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 28);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtboxReservationID
            // 
            this.txtboxReservationID.Location = new System.Drawing.Point(90, 28);
            this.txtboxReservationID.Name = "txtboxReservationID";
            this.txtboxReservationID.Size = new System.Drawing.Size(190, 20);
            this.txtboxReservationID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ReservationID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupboxReservation
            // 
            this.groupboxReservation.Controls.Add(this.lblReservationDate);
            this.groupboxReservation.Controls.Add(this.lblFullname);
            this.groupboxReservation.Controls.Add(this.lblBookTitle);
            this.groupboxReservation.Controls.Add(this.lblReservationID);
            this.groupboxReservation.Controls.Add(this.label6);
            this.groupboxReservation.Controls.Add(this.label4);
            this.groupboxReservation.Controls.Add(this.label3);
            this.groupboxReservation.Controls.Add(this.label2);
            this.groupboxReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxReservation.Location = new System.Drawing.Point(12, 90);
            this.groupboxReservation.Name = "groupboxReservation";
            this.groupboxReservation.Size = new System.Drawing.Size(833, 132);
            this.groupboxReservation.TabIndex = 1;
            this.groupboxReservation.TabStop = false;
            this.groupboxReservation.Text = "Reservation";
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.AutoSize = true;
            this.lblReservationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationDate.ForeColor = System.Drawing.Color.Black;
            this.lblReservationDate.Location = new System.Drawing.Point(111, 107);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(43, 13);
            this.lblReservationDate.TabIndex = 24;
            this.lblReservationDate.Text = "UserID:";
            this.lblReservationDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.Color.Black;
            this.lblFullname.Location = new System.Drawing.Point(111, 84);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(43, 13);
            this.lblFullname.TabIndex = 22;
            this.lblFullname.Text = "UserID:";
            this.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBookTitle.Location = new System.Drawing.Point(111, 55);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(43, 13);
            this.lblBookTitle.TabIndex = 21;
            this.lblBookTitle.Text = "UserID:";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationID.ForeColor = System.Drawing.Color.Black;
            this.lblReservationID.Location = new System.Drawing.Point(111, 26);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(43, 13);
            this.lblReservationID.TabIndex = 20;
            this.lblReservationID.Text = "UserID:";
            this.lblReservationID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Reservation Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fullname:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Book Title:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ReservationID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrFindReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupboxReservation);
            this.Controls.Add(this.groupboxFindReservation);
            this.Name = "ctrFindReservation";
            this.Size = new System.Drawing.Size(860, 238);
            this.Load += new System.EventHandler(this.ctrFindReservation_Load);
            this.groupboxFindReservation.ResumeLayout(false);
            this.groupboxFindReservation.PerformLayout();
            this.groupboxReservation.ResumeLayout(false);
            this.groupboxReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxFindReservation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtboxReservationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupboxReservation;
        private System.Windows.Forms.Label lblReservationDate;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

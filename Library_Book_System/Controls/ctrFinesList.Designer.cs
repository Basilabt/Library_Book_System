namespace Library_Book_System.Controls
{
    partial class ctrFinesList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumberOfFines = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFines = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxFineID = new System.Windows.Forms.TextBox();
            this.btnMarkFineAsPaid = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnMarkFineAsPaid);
            this.groupBox1.Controls.Add(this.txtboxFineID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNumberOfFines);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvFines);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 406);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fines";
            // 
            // lblNumberOfFines
            // 
            this.lblNumberOfFines.AutoSize = true;
            this.lblNumberOfFines.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfFines.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfFines.Location = new System.Drawing.Point(58, 383);
            this.lblNumberOfFines.Name = "lblNumberOfFines";
            this.lblNumberOfFines.Size = new System.Drawing.Size(23, 13);
            this.lblNumberOfFines.TabIndex = 12;
            this.lblNumberOfFines.Text = "199";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(6, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "# Fines:";
            // 
            // dgvFines
            // 
            this.dgvFines.BackgroundColor = System.Drawing.Color.White;
            this.dgvFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFines.Location = new System.Drawing.Point(15, 72);
            this.dgvFines.Name = "dgvFines";
            this.dgvFines.Size = new System.Drawing.Size(776, 297);
            this.dgvFines.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "FineID:";
            // 
            // txtboxFineID
            // 
            this.txtboxFineID.Location = new System.Drawing.Point(58, 15);
            this.txtboxFineID.Name = "txtboxFineID";
            this.txtboxFineID.Size = new System.Drawing.Size(186, 22);
            this.txtboxFineID.TabIndex = 13;
            // 
            // btnMarkFineAsPaid
            // 
            this.btnMarkFineAsPaid.Location = new System.Drawing.Point(85, 43);
            this.btnMarkFineAsPaid.Name = "btnMarkFineAsPaid";
            this.btnMarkFineAsPaid.Size = new System.Drawing.Size(121, 23);
            this.btnMarkFineAsPaid.TabIndex = 14;
            this.btnMarkFineAsPaid.Text = "Mark as paid";
            this.btnMarkFineAsPaid.UseVisualStyleBackColor = true;
            this.btnMarkFineAsPaid.Click += new System.EventHandler(this.btnMarkFineAsPaid_Click);
            // 
            // ctrFinesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrFinesList";
            this.Size = new System.Drawing.Size(838, 431);
            this.Load += new System.EventHandler(this.ctrFinesList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumberOfFines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMarkFineAsPaid;
        private System.Windows.Forms.TextBox txtboxFineID;
    }
}

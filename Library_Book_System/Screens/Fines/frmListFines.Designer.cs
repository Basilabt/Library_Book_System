﻿namespace Library_Book_System.Screens.Fines
{
    partial class frmListFines
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
            this.ctrFinesList1 = new Library_Book_System.Controls.ctrFinesList();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrFinesList1
            // 
            this.ctrFinesList1.BackColor = System.Drawing.Color.White;
            this.ctrFinesList1.Location = new System.Drawing.Point(12, 12);
            this.ctrFinesList1.Name = "ctrFinesList1";
            this.ctrFinesList1.Size = new System.Drawing.Size(838, 431);
            this.ctrFinesList1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(748, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmListFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 470);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrFinesList1);
            this.Name = "frmListFines";
            this.Text = "frmListFines";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrFinesList ctrFinesList1;
        private System.Windows.Forms.Button btnClose;
    }
}
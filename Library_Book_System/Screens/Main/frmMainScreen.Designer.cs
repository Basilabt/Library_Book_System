namespace Library_Book_System.Screens.Main
{
    partial class frmMainScreen
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
            this.lblLoggedUsername = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowingsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBorrowingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBorrowingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listAllFinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoggedUsername
            // 
            this.lblLoggedUsername.AutoSize = true;
            this.lblLoggedUsername.BackColor = System.Drawing.Color.White;
            this.lblLoggedUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLoggedUsername.Location = new System.Drawing.Point(49, 443);
            this.lblLoggedUsername.Name = "lblLoggedUsername";
            this.lblLoggedUsername.Size = new System.Drawing.Size(42, 14);
            this.lblLoggedUsername.TabIndex = 0;
            this.lblLoggedUsername.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.cardsToolStripMenuItem,
            this.copiesToolStripMenuItem,
            this.reservationsToolStripMenuItem,
            this.borrowingsToolStripMenuItem,
            this.finesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllUsersToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.editUserToolStripMenuItem});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = global::Library_Book_System.Properties.Resources.man;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // listAllUsersToolStripMenuItem
            // 
            this.listAllUsersToolStripMenuItem.Name = "listAllUsersToolStripMenuItem";
            this.listAllUsersToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.listAllUsersToolStripMenuItem.Text = "List Users";
            this.listAllUsersToolStripMenuItem.Click += new System.EventHandler(this.listAllUsersToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // cardsToolStripMenuItem
            // 
            this.cardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listCardsToolStripMenuItem,
            this.createNewCardToolStripMenuItem,
            this.deleteCardToolStripMenuItem});
            this.cardsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardsToolStripMenuItem.Image = global::Library_Book_System.Properties.Resources.atm_card;
            this.cardsToolStripMenuItem.Name = "cardsToolStripMenuItem";
            this.cardsToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.cardsToolStripMenuItem.Text = "Cards";
            // 
            // listCardsToolStripMenuItem
            // 
            this.listCardsToolStripMenuItem.Name = "listCardsToolStripMenuItem";
            this.listCardsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listCardsToolStripMenuItem.Text = "List Cards";
            this.listCardsToolStripMenuItem.Click += new System.EventHandler(this.listCardsToolStripMenuItem_Click);
            // 
            // createNewCardToolStripMenuItem
            // 
            this.createNewCardToolStripMenuItem.Name = "createNewCardToolStripMenuItem";
            this.createNewCardToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.createNewCardToolStripMenuItem.Text = "Create New Card";
            this.createNewCardToolStripMenuItem.Click += new System.EventHandler(this.createNewCardToolStripMenuItem_Click);
            // 
            // deleteCardToolStripMenuItem
            // 
            this.deleteCardToolStripMenuItem.Name = "deleteCardToolStripMenuItem";
            this.deleteCardToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteCardToolStripMenuItem.Text = "Delete Card";
            this.deleteCardToolStripMenuItem.Click += new System.EventHandler(this.deleteCardToolStripMenuItem_Click);
            // 
            // copiesToolStripMenuItem
            // 
            this.copiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.availableBooksToolStripMenuItem,
            this.addCopyToolStripMenuItem,
            this.deleteBookToolStripMenuItem,
            this.addBookToolStripMenuItem});
            this.copiesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiesToolStripMenuItem.Image = global::Library_Book_System.Properties.Resources.stack_of_books;
            this.copiesToolStripMenuItem.Name = "copiesToolStripMenuItem";
            this.copiesToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.copiesToolStripMenuItem.Text = "Copies";
            // 
            // availableBooksToolStripMenuItem
            // 
            this.availableBooksToolStripMenuItem.Name = "availableBooksToolStripMenuItem";
            this.availableBooksToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.availableBooksToolStripMenuItem.Text = "Available Copies";
            this.availableBooksToolStripMenuItem.Click += new System.EventHandler(this.availableBooksToolStripMenuItem_Click);
            // 
            // addCopyToolStripMenuItem
            // 
            this.addCopyToolStripMenuItem.Name = "addCopyToolStripMenuItem";
            this.addCopyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addCopyToolStripMenuItem.Text = "Add Copy";
            this.addCopyToolStripMenuItem.Click += new System.EventHandler(this.addCopyToolStripMenuItem_Click);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteBookToolStripMenuItem.Text = "Delete Copy";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.deleteBookToolStripMenuItem_Click);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationsListToolStripMenuItem,
            this.addNewReservationToolStripMenuItem,
            this.deleteReservationToolStripMenuItem});
            this.reservationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsToolStripMenuItem.Image = global::Library_Book_System.Properties.Resources.booking;
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(102, 21);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            // 
            // reservationsListToolStripMenuItem
            // 
            this.reservationsListToolStripMenuItem.Name = "reservationsListToolStripMenuItem";
            this.reservationsListToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reservationsListToolStripMenuItem.Text = "Reservations List";
            this.reservationsListToolStripMenuItem.Click += new System.EventHandler(this.reservationsListToolStripMenuItem_Click);
            // 
            // addNewReservationToolStripMenuItem
            // 
            this.addNewReservationToolStripMenuItem.Name = "addNewReservationToolStripMenuItem";
            this.addNewReservationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addNewReservationToolStripMenuItem.Text = "Add New Reservation";
            this.addNewReservationToolStripMenuItem.Click += new System.EventHandler(this.addNewReservationToolStripMenuItem_Click);
            // 
            // deleteReservationToolStripMenuItem
            // 
            this.deleteReservationToolStripMenuItem.Name = "deleteReservationToolStripMenuItem";
            this.deleteReservationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.deleteReservationToolStripMenuItem.Text = "Delete Reservation";
            this.deleteReservationToolStripMenuItem.Click += new System.EventHandler(this.deleteReservationToolStripMenuItem_Click);
            // 
            // borrowingsToolStripMenuItem
            // 
            this.borrowingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowingsListToolStripMenuItem,
            this.addBorrowingToolStripMenuItem,
            this.deleteBorrowingToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.borrowingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingsToolStripMenuItem.Image = global::Library_Book_System.Properties.Resources.pay;
            this.borrowingsToolStripMenuItem.Name = "borrowingsToolStripMenuItem";
            this.borrowingsToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.borrowingsToolStripMenuItem.Text = "Borrowings";
            // 
            // borrowingsListToolStripMenuItem
            // 
            this.borrowingsListToolStripMenuItem.Name = "borrowingsListToolStripMenuItem";
            this.borrowingsListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrowingsListToolStripMenuItem.Text = "Borrowings List";
            this.borrowingsListToolStripMenuItem.Click += new System.EventHandler(this.borrowingsListToolStripMenuItem_Click);
            // 
            // addBorrowingToolStripMenuItem
            // 
            this.addBorrowingToolStripMenuItem.Name = "addBorrowingToolStripMenuItem";
            this.addBorrowingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBorrowingToolStripMenuItem.Text = "Add Borrowing";
            this.addBorrowingToolStripMenuItem.Click += new System.EventHandler(this.addBorrowingToolStripMenuItem_Click);
            // 
            // deleteBorrowingToolStripMenuItem
            // 
            this.deleteBorrowingToolStripMenuItem.Name = "deleteBorrowingToolStripMenuItem";
            this.deleteBorrowingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteBorrowingToolStripMenuItem.Text = "Delete Borrowing";
            this.deleteBorrowingToolStripMenuItem.Click += new System.EventHandler(this.deleteBorrowingToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // finesToolStripMenuItem
            // 
            this.finesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllFinesToolStripMenuItem});
            this.finesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finesToolStripMenuItem.Image = global::Library_Book_System.Properties.Resources.fine;
            this.finesToolStripMenuItem.Name = "finesToolStripMenuItem";
            this.finesToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.finesToolStripMenuItem.Text = "Fines";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Library_Book_System.Properties.Resources.user;
            this.button1.Location = new System.Drawing.Point(12, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 32);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Book_System.Properties.Resources.annie_spratt_GWCvnsMtiBg_unsplash;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 427);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Image = global::Library_Book_System.Properties.Resources.power;
            this.btnLogout.Location = new System.Drawing.Point(757, 433);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(31, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 45);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // listAllFinesToolStripMenuItem
            // 
            this.listAllFinesToolStripMenuItem.Name = "listAllFinesToolStripMenuItem";
            this.listAllFinesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listAllFinesToolStripMenuItem.Text = "List All Fines";
            this.listAllFinesToolStripMenuItem.Click += new System.EventHandler(this.listAllFinesToolStripMenuItem_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblLoggedUsername);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedUsername;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem listAllUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowingsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBorrowingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBorrowingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllFinesToolStripMenuItem;
    }
}
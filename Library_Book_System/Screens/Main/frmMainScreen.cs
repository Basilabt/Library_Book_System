using BusinessAccessLayer;
using Library_Book_System.Screens.Borrowings;
using Library_Book_System.Screens.Cards;
using Library_Book_System.Screens.Copies;
using Library_Book_System.Screens.Fines;
using Library_Book_System.Screens.Login;
using Library_Book_System.Screens.Reservations;
using Library_Book_System.Screens.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_System.Screens.Main
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            this._fillUsernamelabel();


        }

        // --> Start: Users Menu Strip Items

        private void listAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers form = new frmListUsers();
            form.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteUser form = new frmDeleteUser();
            form.ShowDialog();
        }
        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditUser form = new frmEditUser();
            form.ShowDialog();
        }

        // --> END




        // --> Start: Cards Menu Strip Items 

        private void listCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCards form = new frmListCards();
            form.ShowDialog();

        }

        private void createNewCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewCard form = new frmAddNewCard();
            form.ShowDialog();
        }

        private void deleteCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteCard form = new frmDeleteCard();
            form.ShowDialog();
        }

        // --> END



        // --> Start: Copies

        private void availableBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvailableBooks form = new frmAvailableBooks();
            form.ShowDialog();
        }

        private void addCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCopies form = new frmAddCopies();
            form.ShowDialog();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteCopy form = new frmDeleteCopy();
            form.ShowDialog();
        }


        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewBook form = new frmAddNewBook();
            form.ShowDialog();
        }

        // --> End 


        // -> Start

        private void reservationsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListReservations form = new frmListReservations();
            form.ShowDialog();


        }

        private void addNewReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewReservation form = new frmAddNewReservation();
            form.ShowDialog();
        }

        private void deleteReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDeleteReservation form = new frmDeleteReservation();
            form.ShowDialog();

        }

        // END


        // --> Start 

        private void borrowingsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAllBorrowings form = new frmListAllBorrowings();
            form.ShowDialog();
        }

        private void addBorrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewBorrowing form = new frmAddNewBorrowing();
            form.ShowDialog();
        }

        private void deleteBorrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteBorrowing form = new frmDeleteBorrowing();
            form.ShowDialog();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnBorrowing form = new frmReturnBorrowing();
            form.ShowDialog();  
        }

        // --> END 





        // --> Fines: Start

        private void listAllFinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAllFines form = new frmListAllFines();
            form.ShowDialog();
        }

        // END
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            clsGlobal.loggedManager = null;
            this.Hide();
            frmLoginScreen form = new frmLoginScreen();
            form.ShowDialog();
           
        }



        // Private methods

        private void _fillUsernamelabel()
        {
            lblLoggedUsername.Text = clsGlobal.loggedManager.username;
        }


    }
}

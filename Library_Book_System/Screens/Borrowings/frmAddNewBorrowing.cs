using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_System.Screens.Borrowings
{
    public partial class frmAddNewBorrowing : Form
    {
        private DataTable _books = new DataTable();
        private clsBorrowing _borrowing;

        public frmAddNewBorrowing()
        {
            InitializeComponent();
        }

        private void frmAddNewBorrowing_Load(object sender, EventArgs e)
        {
            this._handleListBooksFillingProcess();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!this._isValidInput())
            {
                return;
            }

            this._borrowing = new clsBorrowing();

            this._borrowing.bookCopyID = clsBookCopy.findAvailableBookCopyIDByBookTitle(this.listboxBookTitle.SelectedItem.ToString()); ;
            this._borrowing.userID = clsUser.findUserByPhoneNumber(this.txtboxPhoneNumber.Text).userID;
            this._borrowing.startDate = dtpStartDate.Value;
            this._borrowing.endDate = dtpEndDate.Value;
    


            if(this._borrowing.bookCopyID == -1)
            {
                MessageBox.Show("No available books are currently available", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._borrowing.mode = clsBorrowing.enMode.AddNew;
            if(this._borrowing.save())
            {
                MessageBox.Show("Borrowing added succefully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            MessageBox.Show("Falied to add new borrowing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Private Methods.

        private void _handleListBooksFillingProcess()
        {
            this._fetchBooksFromDB();
            this._fillListBoxWithBooks();
        }

        private void _fetchBooksFromDB()
        {
            this._books = clsBook.getBooksTitles();

  
        }

        private void _fillListBoxWithBooks()
        {
            foreach (DataRow row in this._books.Rows)
            {
                listboxBookTitle.Items.Add(row["Title"].ToString());
            }
        }

        private bool _isValidInput()
        {
            string userPhoneNumber = txtboxPhoneNumber.Text;

            return userPhoneNumber != "";
        }


    }
}

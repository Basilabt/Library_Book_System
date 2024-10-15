using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_System.Controls
{
    public partial class ctrFindBorrowing : UserControl
    {
        private clsBorrowing _borrowing;

        // Event

        public class SearchAttemptArgs: EventArgs
        {
            public bool isBorrowingFound { get; }

            public SearchAttemptArgs(bool isBorrowingFound)
            {
                this.isBorrowingFound = isBorrowingFound;
            }
        }

        public event EventHandler<SearchAttemptArgs> onSearchAttempt;

        private void _handleSearchAttempt(bool isBorrowingFound)
        {
            this._handleSearchAttempt(new SearchAttemptArgs(isBorrowingFound));
        }

        protected virtual void _handleSearchAttempt(SearchAttemptArgs e)
        {
            if(this.onSearchAttempt != null)
            {
                this.onSearchAttempt.Invoke(this, e);
            }
        }

        // Event End 

        public ctrFindBorrowing()
        {
            InitializeComponent();
        }
        private void ctrFindBorrowing_Load(object sender, EventArgs e)
        {
            this._hideBowrroingInfoGroupBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {   
            if(this.txtboxBorrowingID.Text == "")
            {
                return;
            }



            int borrowingID = int.Parse(txtboxBorrowingID.Text);

            this._borrowing = clsBorrowing.findBorrowingByBorrowingID(borrowingID);
         
            if(this._borrowing !=  null )
            {
                this._borrowing.mode = clsBorrowing.enMode.Delete;
                this._handleSearchAttempt(true);

                this._fillLabelsWithValues();
                this._showBowrroingInfoGroupBox();


                return;
            }

            MessageBox.Show("Borrowing not found !","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
            

        }

        public bool deleteBorrowing()
        {
            return this._borrowing.save();
        }


        // Private methods

        private void _hideBowrroingInfoGroupBox()
        {
            this.groupboxBorrowingInfo.Hide();
        }

        private void _showBowrroingInfoGroupBox()
        {
            this.groupboxBorrowingInfo.Show();
        }

        private void _fillLabelsWithValues()
        {
            this.lblBorrowingID.Text = this._borrowing.borrowingID.ToString();
            this.lblBookTitle.Text = this._borrowing.bookCopy.book.title;
            this.lblStartDate.Text = this._borrowing.startDate.ToString();
            this.lblEndDate.Text = this._borrowing.endDate.ToString();
            this.lblFullname.Text = this._borrowing.user.person.fullname;
           
        }
    }
}

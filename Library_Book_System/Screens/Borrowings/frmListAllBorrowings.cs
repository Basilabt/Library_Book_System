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
    public partial class frmListAllBorrowings : Form
    {
        public frmListAllBorrowings()
        {
            InitializeComponent();
        }

        // Custom Event
        private void ctrBorrowingsList1_onSearchAttempt(object sender, Controls.ctrBorrowingsList.SearchAttemptArgs e)
        {
            bool isBorrowingFound = e.isFound;

            if(isBorrowingFound)
            {
                MessageBox.Show($"There is a borrowing for {e.fullname}", "Borrowing Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"There is no borrowing for {e.fullname}","Borrowing NOT Found",MessageBoxButtons.OK, MessageBoxIcon.Error);   

        }

        // Private Methods

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

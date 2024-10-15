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
    public partial class frmReturnBorrowing : Form
    {
        public frmReturnBorrowing()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this._returnBorrowing();
        }

        // private methods

        private void _returnBorrowing()
        {
            if(this.txtboxBorrowingID.Text == "")
            {
                return;
            }

            int borrowingID = int.Parse(this.txtboxBorrowingID.Text);

            if(clsBorrowing.returnBorrowing(borrowingID))
            {

                MessageBox.Show("Borrowed book marked as returned","Succeed",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            MessageBox.Show("Failed to mark borrowed as returned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

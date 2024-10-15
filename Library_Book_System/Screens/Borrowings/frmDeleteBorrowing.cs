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
    public partial class frmDeleteBorrowing : Form
    {
        public frmDeleteBorrowing()
        {
            InitializeComponent();
        }

        private void frmDeleteBorrowing_Load(object sender, EventArgs e)
        {
            this._hideDeleteButton();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.ctrFindBorrowing1.deleteBorrowing())
            {
                MessageBox.Show("Borrowing deleted successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } else
            {
                MessageBox.Show("Failed to delete borrowing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Custom Event
        private void ctrFindBorrowing1_onSearchAttempt(object sender, Controls.ctrFindBorrowing.SearchAttemptArgs e)
        {
            if(e.isBorrowingFound)
            {
                this._showDeleteButton();
         
            } else
            {
                this._hideDeleteButton();
            }
        }


        // Private methods

        void _hideDeleteButton()
        {
            this.btnDelete.Hide();
        }

        void _showDeleteButton()
        {
            this.btnDelete.Show();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_System.Screens.Copies
{
    public partial class frmDeleteCopy : Form
    {
        public frmDeleteCopy()
        {
            InitializeComponent();
        }

        private void ctrFindBookCopy1_onSearchAttempt(object sender, Controls.ctrFindBookCopy.SearchAttemptEventArgs e)
        {
            if(e.isBookCopyFound)
            {
                this._showDeleteButton();
            } else
            {
                this._hideDeleteButton();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._delete();
        }



        // Private methods.

        private void _delete()
        {
            this.ctrFindBookCopy1.bookCopy.mode = BusinessAccessLayer.clsBookCopy.enMode.Delete;

            if (this.ctrFindBookCopy1.bookCopy.save())
            {
                MessageBox.Show("Book Copy deleted successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } else
            {
                MessageBox.Show("Failed to delete Book Copy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void _showDeleteButton()
        {
            this.btnDelete.Show();
        }

        private void _hideDeleteButton()
        {
            this.btnDelete.Hide();
        }


    }
}

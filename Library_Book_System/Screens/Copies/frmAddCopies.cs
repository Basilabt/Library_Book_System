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

namespace Library_Book_System.Screens.Copies
{
    public partial class frmAddCopies : Form
    {
        private int _bookID;

        public frmAddCopies()
        {
            InitializeComponent();
        }

        private void frmAddCopies_Load(object sender, EventArgs e)
        {
            this._hideAddCopyComponents();
        }


        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            int numberOfCopies = int.Parse(txtboxNumberOfCopiesToAdd.Text);

            if(clsBookCopy.insertMultipleBookCopies(this._bookID,numberOfCopies))
            {
                MessageBox.Show("Insertion process completed succesfully","Succeed",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Insertion process failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Custom Event
        private void ctrFindBook1_onSearchAttempt(object sender, Controls.ctrFindBook.SearchAttemptEventArgs e)
        {
            if(e.isBookFound)
            {
                this._bookID = e.bookID;
                this._showAddCopyComponents();
            } else
            {
                this._hideAddCopyComponents();
            }
        }


        // Private methods

        private void _hideAddCopyComponents()
        {
            this.groupBox1.Hide();
            this.btnAddCopy.Hide();
        }

        private void _showAddCopyComponents()
        {
            this.groupBox1.Show();
            this.btnAddCopy.Show();
        }


    }
}

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

namespace Library_Book_System.Screens.Reservations
{
    public partial class frmAddNewReservation : Form
    {
        public frmAddNewReservation()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._addNewReservation();
        }

        // Private Methods

        private void _addNewReservation()
        {
            string bookTitle = txtboxBookTitle.Text;
            string phoneNumber = txtboxPhoneNumber.Text;
            DateTime reservationDate = dtpReservationDate.Value;

            if(!this._isValidInput())
            {
                MessageBox.Show("Failed , invalid input", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
            if(clsReservation.addNewReservation(bookTitle,phoneNumber,reservationDate) != -1)
            {
                MessageBox.Show("Reservation Added Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            } else
            {
                MessageBox.Show("Failed to add reservation","Failed ",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool _isValidInput()
        {
            if(txtboxBookTitle.Text == "")
            {
                return false;
            }

            if(txtboxPhoneNumber.Text == "")
            {
                return false;
            }


            return true;
        }


    }
}

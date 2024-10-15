using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessAccessLayer;

namespace Library_Book_System.Screens.Reservations
{
    public partial class frmDeleteReservation : Form
    {
        public frmDeleteReservation()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.ctrFindReservation1.reservation.mode = clsReservation.enMode.Delete;

            if(this.ctrFindReservation1.reservation.save())
            {
                MessageBox.Show("Reservation deleted succesfully","Succeed",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();

            } else
            {
                MessageBox.Show("Failed to delete reservation ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrFindReservation1_onSearchAttempt(object sender, Controls.ctrFindReservation.SearchAttemptArgs e)
        {

            if(e.isFoundReservationFound)
            {
                ctrFindReservation1.showReservationGroupbox();

            } 

        }
    }
}

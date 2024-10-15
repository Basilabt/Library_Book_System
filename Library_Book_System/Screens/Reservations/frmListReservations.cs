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
    public partial class frmListReservations : Form
    {

        public frmListReservations()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListReservations_Load(object sender, EventArgs e)
        {

        }

        private void ctrListReservations1_onSearchAttempt(object sender, Controls.ctrListReservations.SearchAttemptArgs e)
        {
            if(e.isReservationFound)
            {

                MessageBox.Show("There is a reservation for this person", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                MessageBox.Show("There is NO reservation for this person", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Private methods


    }
}

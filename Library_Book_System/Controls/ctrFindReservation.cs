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

namespace Library_Book_System.Controls
{
    public partial class ctrFindReservation : UserControl
    {
        public clsReservation reservation;

        public class SearchAttemptArgs: EventArgs
        {
            public bool isFoundReservationFound { get; }

            public SearchAttemptArgs(bool isFoundReservationFound)
            {
                this.isFoundReservationFound = isFoundReservationFound;
            }
        }

        public event EventHandler<SearchAttemptArgs> onSearchAttempt;

        private void _handleSearchAttempt(bool isFoundReservationFound)
        {
            this._handleSearchAttempt(new SearchAttemptArgs(isFoundReservationFound));
        }

        protected virtual void _handleSearchAttempt(SearchAttemptArgs e)
        {
            if(this.onSearchAttempt != null)
            {
                this.onSearchAttempt.Invoke(this, e);
            }

        }

        public ctrFindReservation()
        {
            InitializeComponent();
        }

        private void ctrFindReservation_Load(object sender, EventArgs e)
        {
            this._clearReservationLabels();
            this._hideReservationGroupbox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._search();
        }

        // Private Method.
        private void _clearReservationLabels()
        {
            this.lblReservationID.Text = "";
            this.lblBookTitle.Text = "";
            this.lblFullname.Text = "";
            this.lblReservationDate.Text = "";

        }

        private void _search()
        {
            int reservationID = int.Parse(txtboxReservationID.Text);

            this.reservation = clsReservation.findReservationByReservationID(reservationID);

            if (this.reservation != null)
            {
                this.showReservationGroupbox();
                this.fillLabelsWithReservationValues();
                this._handleSearchAttempt(true);
                return;

            }

            this._handleSearchAttempt(false);

        }

        private void _hideReservationGroupbox()
        {
            this.groupboxReservation.Hide();
        }

        public void showReservationGroupbox()
        {
            this.groupboxFindReservation.Show();
        }

        
        public void fillLabelsWithReservationValues()
        {
            this.lblReservationID.Text = this.reservation.reservationID.ToString();
            this.lblBookTitle.Text = this.reservation.bookCopy.book.title;
            this.lblFullname.Text = this.reservation.user.person.fullname;
            this.lblReservationDate.Text = this.reservation.reservationDate.ToString();    
        }


    }
}

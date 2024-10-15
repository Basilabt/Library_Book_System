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
    public partial class ctrListReservations : UserControl
    {
        private DataTable _dataTable = new DataTable();

        public class SearchAttemptArgs:EventArgs
        {
            public bool isReservationFound { get; }

            public SearchAttemptArgs(bool isReservationFound)
            {
                this.isReservationFound = isReservationFound;
            }
        }

        public event EventHandler<SearchAttemptArgs> onSearchAttempt;

        public ctrListReservations()
        {
            InitializeComponent();
        }

        private void ctrListReservations_Load(object sender, EventArgs e)
        {
            this._handleReservationsFetching();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fullname = txtboxFullname.Text;

            if(fullname != "")
            {
                bool doesHaveReservation = clsReservation.doesReservationExistByFullname(fullname);

                this._handleSearchAttempt(doesHaveReservation);
            }
        }

        private void _handleSearchAttempt(bool isReservationFound)
        {
            this._handleSearchAttempt(new SearchAttemptArgs(isReservationFound));
        }

        protected virtual void _handleSearchAttempt(SearchAttemptArgs e)
        {
            this.onSearchAttempt?.Invoke(this, e);
        }

        // Private methods.

        private void _handleReservationsFetching()
        {
            this._fetchReservationsFromDB();

            this._fillDataIntoDataGrid();

            this._resizeGridColumns();

        }

        private void _fetchReservationsFromDB()
        {
            this._dataTable = clsReservation.getAllReservations();
        }

        private void _fillDataIntoDataGrid()
        {
            this.dgvReservations.DataSource = this._dataTable;
        }

        private void _resizeGridColumns()
        {
            if(this._dataTable.Rows.Count > 0) 
            { 

                this.dgvReservations.Columns[0].Width = 50;
                this.dgvReservations.Columns[1].Width = 50;
                this.dgvReservations.Columns[2].Width = 260;
                this.dgvReservations.Columns[3].Width = 260;
                this.dgvReservations.Columns[4].Width = 170;

            }

        }

  
    }
}

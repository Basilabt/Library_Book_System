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
    public partial class ctrBorrowingsList : UserControl
    {
        private DataTable _dataTable = new DataTable();

        // Event Start

        public class SearchAttemptArgs: EventArgs
        {
            public bool isFound { get; }

            public string fullname { get; }

            public SearchAttemptArgs(bool isFound , string fullname)
            {
                this.isFound = isFound;
                this.fullname = fullname;
            }
        }

        public event EventHandler<SearchAttemptArgs> onSearchAttempt;

        private void _handleOnSearchAttempt(bool isFound , string fullname)
        {
            this._handleOnSearchAttempt(new SearchAttemptArgs(isFound,fullname));
        }

        protected virtual void _handleOnSearchAttempt(SearchAttemptArgs args)
        {
            this.onSearchAttempt?.Invoke(this, args);   
        }

        // Event End 
        public ctrBorrowingsList()
        {
            InitializeComponent();
        }

        private void ctrBorrowingsList_Load(object sender, EventArgs e)
        {
            this._clearNumberOfBorrowingsLabel();
            this._handleBorrowingsFetchingProcess();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._search();
        }


        // Private methods

        private void _handleBorrowingsFetchingProcess()
        {
            this._fetchBorrowingsFromDB();
            
            if(this._dataTable.Rows.Count == 0) 
            {
                return;
            }

            this._fillDataTableIntoGrid();
            this._resizeGridColumns();

        }

        private void _fetchBorrowingsFromDB()
        {
            this._dataTable = clsBorrowing.getAllBorrowings();
        }

        private void _fillDataTableIntoGrid()
        {
            this.dgvBorrowings.DataSource = this._dataTable;
        }

        private void _resizeGridColumns()
        {
            this.dgvBorrowings.Columns[0].Width = 80;
            this.dgvBorrowings.Columns[1].Width = 250;
            this.dgvBorrowings.Columns[2].Width = 250;
            this.dgvBorrowings.Columns[3].Width = 80;
            this.dgvBorrowings.Columns[4].Width = 80;
        }

        private void _changeNumberOfBorrowingsLabel()
        {
            this.lblNumberOfBorrowings.Text = this._dataTable.Rows.Count.ToString();    
        }

        private void _clearNumberOfBorrowingsLabel()
        {
            this.lblNumberOfBorrowings.Text = "";
        }

        private void _search()
        {
            string bookTitle = this.txtboxBookTitle.Text;
            string fullname = this.txtboxFullname.Text;

            if(bookTitle == "" || fullname == "")
            {
                return;
            }

           if(clsBorrowing.doesBorrowingExist(bookTitle,fullname))
           {
                this._handleOnSearchAttempt(true,fullname);
                return;
           }


            this._handleOnSearchAttempt(false, fullname);
        }

    }
}

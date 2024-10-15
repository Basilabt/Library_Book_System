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
    public partial class ctrFinesList : UserControl
    {
        private DataTable _dataTable = new DataTable();

        public ctrFinesList()
        {
            InitializeComponent();
        }

        private void ctrFinesList_Load(object sender, EventArgs e)
        {
            this._handleFinesFetchingFromDB();
        }

        private void btnMarkFineAsPaid_Click(object sender, EventArgs e)
        {
            this._markFineAsPaid();
        }

        // Private Methods.

        private void _handleFinesFetchingFromDB() 
        {
            this._loadFinesFromDB();
            this._fillDataGridViewWithData();
            this._resizeDataGridViewColumns();
        }

        private void _loadFinesFromDB()
        {
            this._dataTable = clsFine.getAllFines();
        }

        private void _fillDataGridViewWithData()
        {
            if(this._dataTable.Rows.Count == 0)
            {
                return;
            }

            this.dgvFines.DataSource = this._dataTable;
        }

        private void _resizeDataGridViewColumns()
        {
            this.dgvFines.Columns[0].Width = 50;
            this.dgvFines.Columns[1].Width = 150;
            this.dgvFines.Columns[2].Width = 150;
            this.dgvFines.Columns[3].Width = 150;
            this.dgvFines.Columns[4].Width = 150;
            this.dgvFines.Columns[5].Width = 150;
            this.dgvFines.Columns[6].Width = 80;
        }

        private void _markFineAsPaid()
        {
            if(this.txtboxFineID.Text == "")
            {
                return;
            }


            int findID = int.Parse(this.txtboxFineID.Text);

            if(clsFine.markFineAsPaidByFineID(findID))
            {
                MessageBox.Show("Fine marked as paid !","Succedd",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this._handleFinesFetchingFromDB();
                return;
            }

            MessageBox.Show("Failed to mark fine as paid !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

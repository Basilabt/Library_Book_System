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
    public partial class ctrCardsList : UserControl
    {
        private DataTable _dataTable = new DataTable();

        public ctrCardsList()
        {
            InitializeComponent();
        }

        private void ctrCardsList_Load(object sender, EventArgs e)
        {
            this._fetchCardsFromDB();
            this._fillDataGridWithData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._search();
        }


        // Private methods

        private void _fetchCardsFromDB()
        {
            this._dataTable = clsCard.getAllCards();
        }

        private void _fillDataGridWithData()
        {
            if(this._dataTable == null)
            {
                return;
            }

            this.dgvCards.DataSource = this._dataTable;
            this._resizeGridColumnsSize();
        }

        private void _resizeGridColumnsSize()
        {
            this.dgvCards.Columns[0].Width = 30;
            this.dgvCards.Columns[1].Width = 350;
            this.dgvCards.Columns[2].Width = 350;

        }


        private void _search()
        {
            string fullname = txtboxFullName.Text;

            if(clsCard.doesCardExistByFullname(fullname))
            {
                MessageBox.Show("There is a card for this user", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("There is NO card for this user ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}

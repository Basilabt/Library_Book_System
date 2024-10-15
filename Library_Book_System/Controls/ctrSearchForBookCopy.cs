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
    public partial class ctrSearchForBookCopy : UserControl
    {
        private DataTable _dataTable = new DataTable();

        public ctrSearchForBookCopy()
        {
            InitializeComponent();
        }

        private void ctrSearchForBookCopy_Load(object sender, EventArgs e)
        {
            this._fetchDataFromDB();
            this._fillDataGridWithData();
            this._resizeGridColumns();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._search();
        }



        // Private methods.

        private void _fetchDataFromDB()
        {
            this._dataTable = clsBookCopy.getAllBooks();
        }

        private void _fillDataGridWithData()
        {           
          this.dataGridView1.DataSource = this._dataTable;
        }

        private void _resizeGridColumns()
        {

            if(this._dataTable.Rows.Count > 0)
            {
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].Width = 200;


            }

        }

        private void _search()
        {
            string title = txtboxBookTitle.Text;

            if(title != "" && clsBookCopy.doesBookCopyExistByTitle(title))
            {
                MessageBox.Show("Book copy available", "Book Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Book copy is NOT available", "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}

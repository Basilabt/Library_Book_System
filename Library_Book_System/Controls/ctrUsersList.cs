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
    public partial class ctrUsersList : UserControl
    {

        private DataTable _usersDataTable;

        public ctrUsersList()
        {
            InitializeComponent();
        }

        private void ctrUsersList_Load(object sender, EventArgs e)
        {
            this._fetchUsers();
            this._setNumberOfUsersLabel();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._search();
        }

        // Private Methods

        private void _fetchUsers()
        {
            this._loadUsersFromDB();
            this._fillDataGridWithData();

            if (this._usersDataTable != null)
            {
                this._resizeGridView();
            }
        }

        private void _loadUsersFromDB()
        {
            this._usersDataTable = clsUser.getAllUsers();
        }

        private void _fillDataGridWithData()
        {
            this.dgvUsers.DataSource = this._usersDataTable;
        }

        private void _resizeGridView()
        {
            this.dgvUsers.Columns[0].Width = 50;
            this.dgvUsers.Columns[1].Width = 200;
            this.dgvUsers.Columns[2].Width = 200;
            this.dgvUsers.Columns[3].Width = 200;
            this.dgvUsers.Columns[4].Width = 80;
        }

        private void _setNumberOfUsersLabel()
        {
            this.lblNumberOfUsers.Text = this._usersDataTable.Rows.Count.ToString();
        }

        private void _search()
        {

            if (this._doesPhoneNumberExistInDataTable())
            {
                MessageBox.Show("There is a user with this phone number", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("There is No user with this phone number", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool _doesPhoneNumberExistInDataTable()
        {
            bool doesPhoneNumberExist = false;

            string phoneNumberToSearchFor = txtboxPhoneNumber.Text;

            foreach (DataRow row in this._usersDataTable.Rows)
            {
                string phoneNumber = row["PhoneNumber"].ToString();

                if (phoneNumber == phoneNumberToSearchFor)
                {
                    doesPhoneNumberExist = true;
                    break;
                }

            }

            return doesPhoneNumberExist;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_System.Screens.Users
{
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if(ctrFindUser1.deleteUser())
            {
                MessageBox.Show("User deleted successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrFindUser1.clearLabels();
                return;
            }

            MessageBox.Show("Failed to delete user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

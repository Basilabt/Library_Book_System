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

namespace Library_Book_System.Screens.Cards
{
    public partial class frmDeleteCard : Form
    {
        public frmDeleteCard()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._delete();
        }

        // Private methods

        private void _delete()
        {
            ctrFindCard1.card.mode = clsCard.enMode.Delete;

            if(ctrFindCard1.card.save())
            {
                MessageBox.Show("Card deleted successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

        }
    }
}

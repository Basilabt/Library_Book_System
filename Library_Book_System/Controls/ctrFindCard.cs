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
    public partial class ctrFindCard : UserControl
    {
        public clsCard card;

        public ctrFindCard()
        {
            InitializeComponent();
        }

        private void ctrFindCard_Load(object sender, EventArgs e)
        {
            this._hideResultsView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._search();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // Private Methods.

        private void _search()
        {
            string cardNumber = txtboxCardNumber.Text;

            this.card = clsCard.findCardByCardNumber(cardNumber);

            if(card != null )
            {
                this._fillLabelsWithData();
                this._showResultsView();
                return;
            }

            MessageBox.Show("No Card Exists","Not found",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void _fillLabelsWithData()
        {
            this.lblCardOwner.Text = this.card.user.person.fullname;
            this.lblCardNumber.Text = this.card.cardNumber;
        }

        private void _hideResultsView()
        {
            this.groupBox1.Hide();
        }

        private void _showResultsView()
        {
            this.groupBox1.Show();
        }

    }
}

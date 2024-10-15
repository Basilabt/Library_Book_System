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
    public partial class ctrFindUser : UserControl
    {
        public clsUser user;
        public class SearchAttemptArgs
        {
            public bool isUserFound { set; get; }

            public SearchAttemptArgs(bool isUserFound)
            {
                this.isUserFound = isUserFound;
            }
        }

        public event EventHandler<SearchAttemptArgs> onUserSearchComplete;

        private void raiseOnUserSearchCompleteEvent(bool isUserFound)
        {
            this.raiseOnUserSearchCompleteEvent(new SearchAttemptArgs(isUserFound));
        }

        protected virtual void raiseOnUserSearchCompleteEvent(SearchAttemptArgs e)
        {
            this.onUserSearchComplete?.Invoke(this,e);
        }


        public ctrFindUser()
        {
            InitializeComponent();
        }

        public bool deleteUser()
        {
            if (this.user != null)
            {
                this.user.mode = clsUser.enMode.Delete;
                return this.user.save();
            }

            return false;
        }

        private void ctrFindUser_Load(object sender, EventArgs e)
        {
            this.clearLabels();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._search();
        }



        // Methods

        private void _search()
        {
            string phoneNumber = txtboxPhoneNumber.Text;

            if(phoneNumber != "")
            {
                this.user = clsUser.findUserByPhoneNumber(phoneNumber);

                if(this.user != null)
                {
                    this._fillLabelValues();
                    this.raiseOnUserSearchCompleteEvent(true);
                    return;
                }

                this.raiseOnUserSearchCompleteEvent(false);
            }
            

        }

        private void _fillLabelValues()
        {
            lblUserID.Text = this.user.userID.ToString();
            lblPersonID.Text = this.user.person.personID.ToString();
            lblFullname.Text = this.user.person.fullname;
            lblEmail.Text = this.user.person.email;
            lblPhoneNumber.Text = this.user.person.phoneNumber;
            lblGender.Text = this.user.person.gender.ToString();

        }


        public void clearLabels()
        {
            lblUserID.Text = "";
            lblPersonID.Text = "";
            lblFullname.Text = "";
            lblEmail.Text = "";
            lblPhoneNumber.Text = "";
            lblGender.Text = "";
            txtboxPhoneNumber.Text = "";
        }

 
    }
}

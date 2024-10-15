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

namespace Library_Book_System.Screens.Users
{
    public partial class frmEditUser : Form
    {
        private clsUser _user;

        public frmEditUser()
        {
            InitializeComponent();
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            this._hideEditControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this._isValidNewValues())
            {
                this._fillPersonObjectWithNewData();

                this.ctrFindUser1.user.person.mode = clsPerson.enMode.update;

                if (this.ctrFindUser1.user.person.save())
                {
                    MessageBox.Show("User Edited Successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Failed to edit user info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ctrFindUser1_onUserSearchComplete(object sender, Controls.ctrFindUser.SearchAttemptArgs e)
        {
            if (e.isUserFound)
            {
                this._showEditControls();
                this._fillUserDataIntoEditControls();
            }
        }



        // Private Methods.

        private void _hideEditControls()
        {
            this.grpboxEditInfo.Hide();
            this.btnSave.Hide();
        }

        private void _showEditControls()
        {
            this.grpboxEditInfo.Show();
            this.btnSave.Show();
        }

        private void _fillUserDataIntoEditControls()
        {
            this.txtboxFirstName.Text = this.ctrFindUser1.user.person.firstName;
            this.txtboxSecondName.Text = this.ctrFindUser1.user.person.secondName;
            this.txtboxThirdName.Text = this.ctrFindUser1.user.person.thirdName;
            this.txtboxLastName.Text = this.ctrFindUser1.user.person.lastName;
            this.txtboxPhone.Text = this.ctrFindUser1.user.person.phoneNumber;
            this.txtboxEmail.Text = this.ctrFindUser1.user.person.email;

            this.checkboxMale.Checked = (this.ctrFindUser1.user.person.gender == clsPerson.enGender.male);
            this.checkboxFemale.Checked = (this.ctrFindUser1.user.person.gender == clsPerson.enGender.female);

        }


        private bool _isValidNewValues()
        {
            string firstName = this.txtboxFirstName.Text;
            string secondName = this.txtboxSecondName.Text;
            string thirdName = this.txtboxThirdName.Text;
            string lastName = this.txtboxLastName.Text;
            string phone = this.txtboxPhone.Text;
            string email = this.txtboxEmail.Text;

            bool isBoxChecked = checkboxFemale.Checked || checkboxMale.Checked;

            if (firstName == "" || secondName == "" || thirdName == "" || lastName == "" || phone == "" ||  email == "")
            {
                return false;
            }

            if(!isBoxChecked)
            {
                return false;
            }

            return true;
        }

        private void _fillPersonObjectWithNewData()
        {
            this.ctrFindUser1.user.person.firstName = this.txtboxFirstName.Text;
            this.ctrFindUser1.user.person.secondName = this.txtboxSecondName.Text;
            this.ctrFindUser1.user.person.thirdName = this.txtboxThirdName.Text;
            this.ctrFindUser1.user.person.lastName = this.txtboxLastName.Text;
            this.ctrFindUser1.user.person.phoneNumber = this.txtboxPhone.Text;
            this.ctrFindUser1.user.person.email = this.txtboxEmail.Text;

            this.ctrFindUser1.user.person.gender = (this.checkboxFemale.Checked) ? clsPerson.enGender.female : clsPerson.enGender.male;


        }

    }
}

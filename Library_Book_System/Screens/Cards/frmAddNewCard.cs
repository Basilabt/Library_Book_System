using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Library_Book_System.Screens.Cards
{
    public partial class frmAddNewCard : Form
    {
        private clsPerson _newPerson = new clsPerson();
        private clsUser _newUser = new clsUser();
        private clsCard _newCard = new clsCard();

        public frmAddNewCard()
        {
            InitializeComponent();
        }

        private void frmAddNewCard_Load(object sender, EventArgs e)
        {
            this._hideNewCardInfoView();
        }

        private void btnCreateNewCard_Click(object sender, EventArgs e)
        {
            this._createNewCard();
        }

        // Private Methods.

        private void _createNewCard()
        {
            if(!this._isValidTextFieldsInput())
            {
                MessageBox.Show("Textbox input can not be null", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if(this._addNewPerson())
            {
               if(this._addNewUser())
                {
                   string newCardNumber = this._generateUniqueCardNumber();

                    this._newCard.cardNumber = newCardNumber;
                    this._newCard.userID = this._newUser.userID;

                    if(this._newCard.save())
                    {   
                        this._fillNewCardData();
                        this._showCardInfoView();

                        MessageBox.Show("Card Added Successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    } else
                    {
                        MessageBox.Show("Failed to create new card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                } else
                {
                    MessageBox.Show("Failed to create new card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Failed to create new card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

 
        }

        private bool _isValidTextFieldsInput()
        {
            if(txtboxFirstName.Text == "")
            {
                return false;
            }

            if(txtboxSecondName.Text == "")
            {
                return false;
            }

            if(txtboxThirdName.Text == "")
            {
                return false;
            }

            if(txtboxLastName.Text == "")
            {
                return false;
            }

            if(txtboxEmail.Text == "")
            {
                return false;
            }

            if(txtboxPhoneNumber.Text == "")
            {
                return false;
            }

            return true;

        }

        private bool _addNewPerson()
        {
            this._newPerson.firstName = txtboxFirstName.Text;
            this._newPerson.secondName = txtboxSecondName.Text;
            this._newPerson.thirdName = txtboxThirdName.Text;
            this._newPerson.lastName = txtboxLastName.Text;
            this._newPerson.phoneNumber = txtboxPhoneNumber.Text;
            this._newPerson.email = txtboxEmail.Text;
            this._newPerson.gender = (this.checkboxMale.Checked) ? clsPerson.enGender.male : clsPerson.enGender.female;

            this._newPerson.mode = clsPerson.enMode.addNew;

            return this._newPerson.save();
        }

        private bool _addNewUser()
        {
            this._newUser.personID = this._newPerson.personID;

            this._newUser.mode = clsUser.enMode.AddNew;

            return this._newUser.save();
        }
        
        private string _generateUniqueCardNumber()
        {
            string newCardNumber = "";

            Random random = new Random();

            do
            {
                newCardNumber = "";

                for (int i = 1; i <= 20; i++)
                {
                    if (i % 4 == 0)
                    {
                        newCardNumber += random.Next().ToString() + "-";

                    }
                    else
                    {
                        newCardNumber += random.Next().ToString();
                    }

                }

            } while (!clsCard.isUniqueCardNumber(newCardNumber));


            return newCardNumber.Substring(0,newCardNumber.Length - 1);
        }

        private void _fillNewCardData()
        {
            this.lblCardNumber.Text = this._newCard.cardNumber;
            this.lblCardOwner.Text = this._newPerson.fullname;
        }

        private void _hideNewCardInfoView()
        {
            this.groupBox2.Hide();
        }

        private void _showCardInfoView()
        {
            this.groupBox2.Show();
        }


    }
}

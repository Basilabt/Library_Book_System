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

namespace Library_Book_System.Screens.Copies
{
    public partial class frmAddNewBook : Form
    {
        private clsBook _book;
        private clsAuthor _author;
        private clsPerson _person;

        public frmAddNewBook()
        {
            InitializeComponent();
        }

        private void frmAddNewBook_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            this._addNewBook();
        }


        // Private methods

        private void _addNewBook()
        {
            string title = txtboxTitle.Text;

            if(clsBook.doesBookExistByTitle(title))
            {
                MessageBox.Show("Book already exists","Duplicate",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!this._isValidInput())
            {
                MessageBox.Show("Input can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            this._person = new clsPerson();
            this._person.firstName = txtboxFirstName.Text;
            this._person.secondName = txtboxSecondName.Text;
            this._person.thirdName = txtboxThirdName.Text;
            this._person.lastName = txtboxLastName.Text;
            this._person.phoneNumber = txtboxPhoneNumber.Text;
            this._person.email = txtboxEmail.Text;
            this._person.gender = (this.listboxGender.Text == "Male") ? clsPerson.enGender.male : clsPerson.enGender.female;
            this._person.mode = clsPerson.enMode.addNew;

            if(!this._person.save())
            {
                MessageBox.Show("Failed to add book", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

       
            this._author = new clsAuthor();
            this._author.personID = this._person.personID;

            
            if(!this._author.save())
            {
                MessageBox.Show("Failed to add book", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._book = new clsBook();
            this._book.title = txtboxTitle.Text;
            this._book.authorID = this._author.authorID;
            this._book.genre = txtboxGenre.Text;
            this._book.ISBN = txtboxISBN.Text;
            this._book.additionalNotes = txtboxAdditionalNotes.Text;
            this._book.publishedDate = dtpPublishedDate.Value;
            this._book.mode = clsBook.enMode.AddNew;

            if(!this._book.save())
            {
                MessageBox.Show("Failed to add book", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            MessageBox.Show("Book Added Succesfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private bool _isValidInput()
        {
            if(txtboxTitle.Text == "" || txtboxFirstName.Text == "" || txtboxSecondName.Text == "" || txtboxThirdName.Text == "" || txtboxLastName.Text == "" || txtboxPhoneNumber.Text == "" || txtboxEmail.Text == "")
            {
                return false;
            }

            if(txtboxGenre.Text == "" || txtboxISBN.Text == "" || txtboxAdditionalNotes.Text == "")
            {
                return false;
            }


            return true;
        }
       
    }
}

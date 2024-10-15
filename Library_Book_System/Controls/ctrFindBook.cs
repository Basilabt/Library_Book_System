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
    public partial class ctrFindBook : UserControl
    {
        // --> Start Of Event

        public class SearchAttemptEventArgs: EventArgs
        {
            public bool isBookFound = false;
            public int bookID { get; }

            public SearchAttemptEventArgs(bool isBookFound, int bookID)
            {
                this.isBookFound = isBookFound;
                this.bookID = bookID;
            }

        }

        public event EventHandler<SearchAttemptEventArgs> onSearchAttempt;

        private void _searchAttempt(bool isBookFound,int bookID)
        {
            this._searchAttempt(new SearchAttemptEventArgs(isBookFound,bookID));
        }

        protected virtual void _searchAttempt(SearchAttemptEventArgs e)
        {
            this.onSearchAttempt?.Invoke(this, e);
        }


        // --> End Of Event

        private clsBook _book;

        public ctrFindBook()
        {
            InitializeComponent();
        }

        private void ctrFindBook_Load(object sender, EventArgs e)
        {
            this._clearLabels();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._search();
        }




        // Private methods.

        private void _search()
        {
            string title = txtboxBookTitle.Text;

            this._book = clsBook.findBookByTitle(title);


            if(this._book != null)
            {
                this._fillBookValues();
                this._searchAttempt(true,this._book.bookID);
                return;
            }

            this._searchAttempt(false,-1);
            MessageBox.Show("Book not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _fillBookValues()
        {
            this.lblBookTitle.Text = this._book.title;
            this.lblAuthor.Text = this._book.author.person.fullname;
            this.lblGenre.Text = this._book.genre;
            this.lblISBN.Text = this._book.ISBN;
            this.lblPublishedDate.Text  = this._book.publishedDate.ToString();
            this.lblAdditionalNotes.Text = this._book.additionalNotes;
        }

        private void _clearLabels()
        {
            this.lblBookTitle.Text = "";
            this.lblAuthor.Text = "";
            this.lblGenre.Text = "";
            this.lblISBN.Text = "";
            this.lblAdditionalNotes.Text = "";
            this.lblPublishedDate.Text = "";
        }


    }
}

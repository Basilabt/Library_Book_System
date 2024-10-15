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
    public partial class ctrFindBookCopy : UserControl
    {
        // Delegeate

        public class SearchAttemptEventArgs: EventArgs
        {
            public bool isBookCopyFound { get; }

            public SearchAttemptEventArgs(bool isBookCopyFound)
            {
                this.isBookCopyFound = isBookCopyFound;
            }

        }

        public event EventHandler<SearchAttemptEventArgs> onSearchAttempt;

        private void _searchAttempt(bool isBookCopyFound)
        {
            this._searchAttempt(new SearchAttemptEventArgs(isBookCopyFound));
        }

        protected virtual void _searchAttempt(SearchAttemptEventArgs e)
        {
            this.onSearchAttempt?.Invoke(this, e);
        }

        // 




        public clsBookCopy bookCopy;

        public ctrFindBookCopy()
        {
            InitializeComponent();
        }

        private void ctrFindBookCopy_Load(object sender, EventArgs e)
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
            int bookCopyID = int.Parse(txtboxBookCopyID.Text);

            this.bookCopy = clsBookCopy.findBookCopyByBookCopyID(bookCopyID);

            if(this.bookCopy != null)
            {

                this._fillBookCopyDataIntoLables();
                this._searchAttempt(true);
                return;
            }

            this._searchAttempt(false);
            MessageBox.Show("No Book Copy Exists", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _fillBookCopyDataIntoLables()
        {
            lblBookCopyID.Text = this.bookCopy.bookCopyID.ToString();

            lblAuthor.Text = this.bookCopy.book.author.person.fullname;
            lblBookTitle.Text = this.bookCopy.book.title;
            lblGenre.Text = this.bookCopy.book.genre;
            lblAdditionalNotes.Text = this.bookCopy.book.additionalNotes;
            lblISBN.Text = this.bookCopy.book.ISBN;
            lblPublishedDate.Text = this.bookCopy.book.publishedDate.ToString();
           
        }

        private void _clearLabels()
        {
            lblBookCopyID.Text = "";
            lblAuthor.Text = "";
            lblBookTitle.Text = "";
            lblGenre.Text = "";
            lblAdditionalNotes.Text = "";
            lblISBN.Text = "";
            lblPublishedDate.Text = "";

        }
    }



    
}

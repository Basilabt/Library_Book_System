using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public  class clsBookCopy
    {
        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3
        }

        public int bookCopyID { set; get; }
        public int bookID { set; get; }
        public bool isAvailable { set; get; }

        public enMode mode;

        public clsBook book;

        public clsBookCopy()
        {
            this.bookCopyID = -1;
            this.bookID = -1;
            this.isAvailable = false;
            this.mode = enMode.AddNew;
        }

        private clsBookCopy(int bookCopyID , int bookID , bool isAvailable)
        {
            this.bookCopyID = bookCopyID;
            this.bookID = bookID;
            this.isAvailable = isAvailable;
            this.mode = enMode.Update;
            this.book = clsBook.findBookByBookID(bookID); 

        }

        public bool save()
        {
            switch(this.mode)
            {

            case enMode.AddNew:
                    {
                        return false;
                    }

              case enMode.Update:
                    {
                        return false;
                    }

                case enMode.Delete:
                    {
                        return deleteBookCopyByID(this.bookCopyID);
                    }

            }


            return false;
        }

        // Static methods.

        public static DataTable getAllBooks()
        {
            return clsBookCopyDataAccess.getAllAvailableBooks();
        }

        public static bool doesBookCopyExistByTitle(string title)
        {
            return clsBookCopyDataAccess.doesBookCopyExistByTitle(title);
        }

        public static bool insertMultipleBookCopies(int bookID , int numberOfCopies)
        {
            return clsBookCopyDataAccess.insertMultipleBookCopies(bookID , numberOfCopies);
        }

        public static bool deleteBookCopyByID(int id)
        {
            return clsBookCopyDataAccess.deleteBookCopyByID(id);
        }

        public static clsBookCopy findBookCopyByBookCopyID(int bookCopyID)
        {
            int bookID = -1;
            bool isAvailable = false;

            if(clsBookCopyDataAccess.findBookCopyByBookCopyID(bookCopyID , ref bookID , ref isAvailable))
            {
                return new clsBookCopy(bookCopyID, bookID, isAvailable);
            }

            return null;
        }

        public static int findAvailableBookCopyIDByBookTitle(string bookTitle)
        {
            return clsBookCopyDataAccess.findAvailableBookCopyIDByBookTitle(bookTitle);
        }

    }
}

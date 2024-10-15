using DataAccessLayer;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsBook
    {
        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3
        }

        public int bookID { get; set; }
        public int authorID { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string ISBN { get; set; }
        public DateTime publishedDate { get; set; }
        public string additionalNotes { get; set; }

        public enMode mode;

        public clsAuthor author;

        public clsBook()
        {
            this.bookID = -1;
            this.authorID = -1;
            this.title = "";
            this.genre = "";
            this.ISBN = "";
            this.publishedDate = DateTime.Now;
            this.additionalNotes = "";

            this.mode = enMode.Update;
        }

        private clsBook(int bookID , int authorID , string title , string genre , string ISBN , DateTime publishedDate , string additionalNotes)
        {
            this.bookID = bookID; 
            this.authorID = authorID;
            this.title = title;
            this.genre = genre;
            this.ISBN = ISBN;
            this.publishedDate = publishedDate; 
            this.additionalNotes = additionalNotes;

            this.author = clsAuthor.findAuthorByID(authorID);
            this.mode = enMode.Update;
            

        }

        public bool save()
        {

            switch(this.mode)
            {
                
                case enMode.Update:
                    {

                        return false;
                    }

                case enMode.Delete:
                    {
                        return false;
                    }

                case enMode.AddNew:
                    {
                        this.bookID = addNewBook(this.authorID, this.title, this.genre, this.ISBN, this.publishedDate, this.additionalNotes);

                        return bookID != -1;
                    }



            }


            return false;
        }

        // Static Methods

        public static clsBook findBookByTitle(string title)
        {
            int bookID = -1, authorID = -1;
            string genre = "", ISBN = "", additionalNotes = "";
            DateTime publishedDate = DateTime.Now;

            if(clsBookDataAccess.findBookByTitle(ref bookID,ref authorID,title,ref genre,ref ISBN,ref publishedDate,ref additionalNotes))
            {
                return new clsBook(bookID, authorID, title, genre, ISBN, publishedDate, additionalNotes);
            }
               
           
            return null;
        }

        public static clsBook findBookByBookID(int bookID)
        {
            int authorID = -1;
            string title = "" , genre = "", ISBN = "", additionalNotes = "";
            DateTime publishedDate = DateTime.Now;

            if(clsBookDataAccess.findBookByBookID(bookID, ref authorID,ref title, ref genre, ref ISBN, ref publishedDate, ref additionalNotes))
            {
                return new clsBook(bookID,authorID,title,genre,ISBN, publishedDate,additionalNotes);
            }
            

            return null;

        }

        public static bool doesBookExistByTitle(string title)
        {
            return clsBookDataAccess.doesBookExistByTitle(title);
        }

        public static int addNewBook(int authorID , string title , string genre , string ISBN , DateTime punlishedDate , string additionalNotes)
        {
            return clsBookDataAccess.addNewBook(authorID,title,genre,ISBN,punlishedDate,additionalNotes);
        }

        public static DataTable getBooksTitles()
        {
            return clsBookDataAccess.getBooksTitles();
        }
    }
}

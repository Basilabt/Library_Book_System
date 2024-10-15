using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsBorrowing
    {
        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3
        }

        public int borrowingID { get; set; }
        public int bookCopyID { get; set; }
        public int userID { set; get; }
        public DateTime startDate { set; get; }
        public DateTime endDate { set; get; }
        public DateTime actualReturnDate { set; get; }

        public enMode mode;

        public clsUser user;

        public clsBookCopy bookCopy;

        public clsBorrowing()
        {
            this.borrowingID = -1;
            this.bookCopyID = -1;
            this.userID = -1;
            this.startDate = DateTime.MinValue;
            this.endDate = DateTime.MinValue;
            this.actualReturnDate = DateTime.MinValue;
        }

        private clsBorrowing(int borrowingID, int bookCopyID, int userID, DateTime startDate, DateTime endDate, DateTime actualReturnDate)
        {
            this.borrowingID = borrowingID;
            this.bookCopyID = bookCopyID;
            this.userID = userID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.actualReturnDate = actualReturnDate;

            this.user = clsUser.findUserByID(userID);
            this.bookCopy = clsBookCopy.findBookCopyByBookCopyID(bookCopyID);
 
        }

        public bool save()
        {
           switch(this.mode)
           {
              case enMode.AddNew:
                    {
                        this.borrowingID = addNewBorrowing(this.bookCopyID,this.userID,this.startDate,this.endDate,this.actualReturnDate);
                        return this.borrowingID != -1;
                    }

              case enMode.Update:
                    {
                        return false;
                    }

              case enMode.Delete:
                    {
                        return deleteBorrowingByBorrowingID(this.borrowingID);
                    }

           }

            return false;
        }


        // Static Methods

        public static  DataTable getAllBorrowings()
        {
            return clsBorrowingDataAccess.getAllBorrowings();
        }

        public static bool doesBorrowingExist(string bookTitle , string fullname)
        {
            return clsBorrowingDataAccess.doesBorrowingExist(bookTitle, fullname);
        }

        public static clsBorrowing findBorrowingByBorrowingID(int borrowingID)
        {
            int bookCopyID = -1;
            int userID = -1;
            DateTime startDate = DateTime.MinValue;
            DateTime endDate = DateTime.MinValue;
            DateTime actualReturnDate = DateTime.MinValue;

            if(clsBorrowingDataAccess.findBorrowingByBorrowingID(borrowingID,ref bookCopyID,ref userID,ref startDate,ref endDate,ref actualReturnDate))
            {
                return  new clsBorrowing(borrowingID,bookCopyID,userID,startDate,endDate,actualReturnDate);
            }

            return null;
        }

        public static bool deleteBorrowingByBorrowingID(int borrowingID)
        {
            return clsBorrowingDataAccess.deleteBorrowing(borrowingID);
        }

        public static int addNewBorrowing(int bookCopyID , int userID , DateTime startDate , DateTime endDate , DateTime actualReturnDate) 
        {
            return clsBorrowingDataAccess.addNewBorrowing(bookCopyID, userID, startDate, endDate, actualReturnDate);
        }

        public static bool returnBorrowing(int borrowingID)
        {
            return clsBorrowingDataAccess.returnBorrowing(borrowingID) ;
        }
    }
}

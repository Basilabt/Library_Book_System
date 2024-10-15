using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsFine
    {
        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3
        }

        public int fineID { set; get; }
        public int borrowingID { set; get; }
        public int userID { set; get; }
        public float totalFines { set; get; }
        public int numberOfLateDays { set; get; }
        public bool isPaid { set; get; }

        public enMode mode;

        public clsBorrowing borrowing;

        public clsUser user;

        public clsFine()
        {
            this.fineID = -1;
            this.borrowingID = -1;
            this.userID = -1;
            this.totalFines = -1;
            this.numberOfLateDays = -1;
            this.isPaid = false;
            this.mode = enMode.AddNew;
        }

        private clsFine(int fineID, int borrowingID, int userID, float totalFines, int numberOfLateDays, bool isPaid, enMode mode, clsBorrowing borrowing, clsUser user)
        {
            this.fineID = fineID;
            this.borrowingID = borrowingID;
            this.userID = userID;
            this.totalFines = totalFines;
            this.numberOfLateDays = numberOfLateDays;
            this.isPaid = isPaid;

            this.mode = enMode.Update;
            this.borrowing = clsBorrowing.findBorrowingByBorrowingID(borrowingID);
            this.user = clsUser.findUserByID(userID);
        }

        // Static methods.

        public static DataTable getAllFines()
        {
            return clsFineDataAccess.getAllFines();
        }

        public static bool deleteFineByID(int fineID)
        {
            return clsFineDataAccess.deleteFineByFineID(fineID);
        }

        public static bool markFineAsPaidByFineID(int fineID)
        {
            return clsFineDataAccess.markFineIsPaidByFineID(fineID);
        }
    }
}

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
    public class clsReservation
    {
        public enum enMode 
        { 
            AddNew = 1 , Update = 2 ,Delete = 3
        }

        public int reservationID { get; set; }
        public int bookCopyID { set; get; }
        public int userID { get; set; }
        public DateTime reservationDate { set; get; }

        public enMode mode;

        public clsUser user;

        public clsBookCopy bookCopy;


        public clsReservation()
        {
            this.reservationID = -1;
            this.bookCopyID = -1;
            this.userID = -1;
            this.reservationDate = DateTime.MinValue;
            this.mode = enMode.AddNew;
        }

        private clsReservation(int reservationID , int bookCopyID , int userID , DateTime reservationDate)
        {
            this.reservationID = reservationID;
            this.bookCopyID = bookCopyID;
            this.userID = userID;
            this.reservationDate = reservationDate;
            this.user = clsUser.findUserByID(userID);
            this.bookCopy = clsBookCopy.findBookCopyByBookCopyID(bookCopyID);
            this.mode = enMode.Update;
        }

        public bool save()
        {

            switch(this.mode)
            {

                case enMode.AddNew:
                    {
                        return false;               
                    }


                case enMode.Delete:
                    {
                        return deleteReservation(this.reservationID);                      
                    }


                case enMode.Update:
                    {
                        return false;                       
                    }


            }



            return false;
        }

        // Static Methods:

        public static DataTable getAllReservations()
        {
            return clsReservationDataAccess.getAllReservations();
        }
        
        public static int addNewReservation(string bookTitle , string userPhoneNumer , DateTime reservationDate)
        {
            return clsReservationDataAccess.addNewReservation(bookTitle , userPhoneNumer , reservationDate);
        }

        public static bool deleteReservation(int reservationID)
        {
            return clsReservationDataAccess.deleteReservationByReservationID(reservationID);
        }

        public static bool doesReservationExistByFullname(string fullname)
        {
            return clsReservationDataAccess.doesReservationExistByFullname(fullname);
        }

        public static clsReservation findReservationByReservationID(int reservationID)
        {
            int bookCopyID = -1;
            int userID = -1;
            DateTime reservationDate = DateTime.MinValue;

            if (clsReservationDataAccess.findReservationByReservationID(reservationID, ref bookCopyID, ref userID,ref reservationDate)) 
            {
                return new clsReservation(reservationID, bookCopyID, userID, reservationDate);
            }

            return null;
        }

    }
}

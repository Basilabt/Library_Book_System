using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsCard
    {
        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3
        }

        public int cardID { set; get; }
        public int userID { set; get; }
        public string cardNumber { set; get; }

        public enMode mode;

        public clsUser user;


        public clsCard()
        {
            this.cardID = -1;
            this.userID = -1;
            this.cardNumber = "";
            this.mode = enMode.AddNew;
        }
        private clsCard(int cardID, int userID, string cardNumber)
        {
            this.cardID = cardID;
            this.userID = userID;
            this.cardNumber = cardNumber;
            this.mode = enMode.Update;
            this.user = clsUser.findUserByID(userID);
        }

        public bool save()
        {
            
            switch(this.mode)
            {
                case enMode.AddNew:
                    {   
                        this.cardID = addNewCard(this.userID, this.cardNumber);

                        return this.cardID != -1;
                    }

                case enMode.Update:
                    {
                        return false;
                    }

                case enMode.Delete:
                    {
                        return deleteCardByCardNumber(this.cardNumber);
                    }


            }


            return false;
        }

        // Static Methods

        public static DataTable getAllCards()
        {
            return clsCardDataAccess.getAllCards();
        }

        public static bool doesCardExistByFullname(string fullname)
        {
            return clsCardDataAccess.doesCardExistByFullname(fullname);
        }

        public static bool deleteCardByCardNumber(string cardNumber)
        {
            return clsCardDataAccess.deleteCardByCardNumber(cardNumber);
        }

        public static clsCard findCardByCardNumber(string cardNumber)
        {
            int cardID = -1;
            int userID = -1;

            if(clsCardDataAccess.findCardByCardNumber(ref cardID,ref userID,cardNumber))
            {
                return new clsCard(cardID, userID, cardNumber);
            }

            return null;
        }

        public static bool isUniqueCardNumber(string cardNumber)
        {
            return clsCardDataAccess.isUniqueCardNumber(cardNumber);
        }

        public static int addNewCard(int userID , string cardNumber)
        {
            return clsCardDataAccess.addNewCard(userID, cardNumber);
        }
    }
}

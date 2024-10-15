using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class clsUser
    {

        public enum enMode
        {
            AddNew = 1, Update = 2, Delete = 3
        }

        public int userID { set; get; }
        public int personID { set; get; }

        public enMode mode;

        public clsPerson person;

        public clsUser()
        {
            this.userID = -1;
            this.personID = -1;
            this.person = null;
            this.mode = enMode.AddNew;

        }

        private clsUser(int userID, int personID)
        {
            this.userID = userID;
            this.personID = personID;
            this.person = clsPerson.findPersonByPersonID(personID);
            this.mode = enMode.Update;
        }


        public bool save()
        {
            switch(this.mode)
            {
                case enMode.AddNew:
                    {
                        this.userID = addNewUser(this.personID);

                        return this.userID != -1;
                    }

                case enMode.Update:
                    {
                        return false;
                    }

                case enMode.Delete:
                    {
                        return deleteUserByID(userID);
                    }
            }

            return false;

        }



        // Static Methods

        public static DataTable getAllUsers()
        {
            return clsUserDataAccess.getAllUsers();
        }

        public static clsUser findUserByPhoneNumber(string  phoneNumber)
        {
            int userID = -1;
            int personID = -1;
            
            if(clsUserDataAccess.findUserByPhoneNumber(phoneNumber,ref userID,ref personID))
            {
                return new clsUser(userID,personID);
            }

            return null;
        }

        public static clsUser findUserByID(int userID)
        {
            int personID = -1;

            if(clsUserDataAccess.findUserByID(userID,ref personID))
            {
                return new clsUser(userID,personID);
            }



            return null;
        }

        public static bool deleteUserByID(int userID)
        {
            return clsUserDataAccess.deleteUserByID(userID);
        }

        public static int addNewUser(int personID)
        {
            return clsUserDataAccess.addNewUser(personID);
        }

    }
}

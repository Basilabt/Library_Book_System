using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsAuthor
    {
        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3
        }

        public int authorID { get; set; }
        public int personID { get; set; }

        public enMode mode;

        public clsPerson person;


        public clsAuthor()
        {
            this.authorID = -1;
            this.personID = -1;
            this.mode = enMode.AddNew;

        }

        private clsAuthor(int authorID , int personID)
        {
            this.authorID = authorID;
            this.personID = personID;
            this.mode = enMode.Update;
            this.person = clsPerson.findPersonByPersonID(personID);
        }

        public bool save()
        {
            switch(this.mode)
            {

                case enMode.AddNew:
                    {
                        this.authorID = addNewAuthor(this.personID);

                        return this.authorID != -1;
                    }

                case enMode.Update:
                    {
                        return false;
                    }

                case enMode.Delete:
                    {
                        return false;
                    }

            }



            return false;
        }


        // Static Methods

        public static clsAuthor findAuthorByID(int authorID)
        {
            int personID = -1;

            if(clsAuthorDataAccess.findAuthorByID(authorID,ref personID))
            {
                return new clsAuthor(authorID,personID);
            }

            return null;
        }

        public static int addNewAuthor(int personID)
        {
            return clsAuthorDataAccess.addNewAuthor(personID);
        }

    }
}

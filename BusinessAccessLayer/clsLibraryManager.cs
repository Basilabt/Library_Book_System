using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public  class clsLibraryManager
    {


        public enum enMode
        {
            addNew = 1, delete = 2, update = 3
        }

        public int libraryManagerID { get; set; }
        public int personID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool isActive { set; get; }

        public enMode mode;

        // Composition
        public clsPerson person;


        public clsLibraryManager()
        {
            this.libraryManagerID = -1;
            this.personID = -1;
            this.username = "";
            this.password = "";
            this.isActive = false;
            this.mode = enMode.addNew;
        }

        private clsLibraryManager(int libraryManagerID, int personID, string username, string password, bool isActive)
        {
            this.libraryManagerID = libraryManagerID;
            this.personID = personID;
            this.username = username;
            this.password = password;
            this.isActive = isActive;
            this.mode = enMode.update;

            this.person = clsPerson.findPersonByPersonID(personID);

        }


        public bool save()
        {
            return false;
        }


        // Static Methods:

        public static bool login(string username, string password)
        {
            return clsLibraryMangerDataAccess.loginByUsernameAndPassword(username, password);
        }


        public static bool isManagerAccountActive(string username)
        {
            return clsLibraryMangerDataAccess.isLibraryManagerAccountActive(username);
        }

        public static clsLibraryManager findLibraryManagerByUsername(string username)
        {
            int managerID = -1;
            int personID = -1;
            string password = "";
            bool isActive = false;

            if(clsLibraryMangerDataAccess.findLibraryManagerByUsername(ref managerID,ref personID,username,ref password,ref isActive))
            {
                return new clsLibraryManager(managerID,personID,username,password,isActive);
            }

            return null;
        }




    }
}

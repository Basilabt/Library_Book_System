using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessAccessLayer
{
    public  class clsPerson
    {

        public enum enMode
        {
            addNew = 1, delete = 2, update = 3
        }

        public enum enGender
        {
            male = 1, female = 0
        }

        public int personID { set; get; }
        public string firstName { set; get; }
        public string secondName { set; get; }
        public string thirdName { set; get; }
        public string lastName { set; get; }
        public string fullname
        {
            get
            {
                return this.firstName + " " + this.secondName + " " + this.thirdName + " " + this.lastName;
            }
        }
        public enGender gender { set; get; }
        public string phoneNumber { set; get; }
        public string email { set; get; }

        public enMode mode;

        public clsPerson()
        {
            this.personID = -1;
            this.firstName = "";
            this.secondName = "";
            this.thirdName = "";
            this.lastName = "";
            this.gender = enGender.female;
            this.phoneNumber = "";
            this.email = "";
            this.mode = enMode.addNew;

        }

        private clsPerson(int personID,string firstName, string secondName, string thirdName, string lastName, enGender gender, string phoneNumber, string email)
        {
            this.personID = personID;
            this.firstName = firstName;
            this.secondName = secondName;
            this.thirdName = thirdName;
            this.lastName = lastName;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.mode = enMode.update;

        }


        public bool save()
        {

            switch(this.mode)
            {

                case enMode.addNew:
                    {

                        this.personID = addNewPerson(this.firstName, this.secondName, this.thirdName, this.lastName, this.gender == enGender.male, this.phoneNumber, this.email);

                        return this.personID != -1;
                    }

                case enMode.update:
                    {
                        return updatePerson(this.personID,this.firstName,this.secondName,this.thirdName,this.lastName,this.gender == enGender.male,this.phoneNumber,this.email);
                    }

                case enMode.delete:
                    {
                        return false;
                    }



            }




            return false;
        }

        // Static Methods

        public static clsPerson findPersonByPersonID(int personID)
        {
            string firstName = "", secondName = "", thirdName = "", lastName = "", phoneNumber = "", email = "";
            bool gender = false;


            if(clsPersonDataAccess.findPersonByPersonID(personID,ref firstName,ref secondName,ref thirdName,ref lastName,ref gender,ref phoneNumber,ref email))
            {
                enGender g = gender ? enGender.male : enGender.female;

                return new clsPerson(personID,firstName,secondName,thirdName,lastName,g,phoneNumber,email);
            }

            return null;
        }

        public static int addNewPerson(string firstName, string secondName, string thirdName, string lastName, bool gender, string phoneNumber, string email)
        {
            return clsPersonDataAccess.addNewPerson(firstName,secondName,thirdName,lastName,gender,phoneNumber,email);  
        }

        public static bool updatePerson(int personID , string firstName , string secondName , string thirdName , string lastName , bool gender , string phoneNumber , string email)
        {
            return clsPersonDataAccess.updatePerson(personID,firstName,secondName,thirdName,lastName,gender,phoneNumber,email);
        }

    }
}

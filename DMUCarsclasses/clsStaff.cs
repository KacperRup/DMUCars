using System;
using System.Collections.Generic;
using DMUCarsclasses;

namespace DMUCarsclasses
{
    public class clsStaff
    {   //create data member for the staff id property
        private Int32 mStaffID;
        //private data member for the firstname
        private string mFirstName;
        //private data member for the lastname
        private string mLastName;
        //private data member for the mobilenumber
        private string mMobileNo;
        //private data member for the date
        private DateTime mStartDate;


       

        public string MobileNo
        {
            get
            {
                return mMobileNo;
            }
            set
            {
                mMobileNo = value;
            }
        }


        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
            }
        }
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public clsStaff ThisStaff { get; set; }



        public bool Find(int StaffID)
        {
            //create an instance of the new data connection
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            //add the parameter for the staffid to search for
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found
            if (DB.Count == 1)
            {
                //read in the field from the current recordm
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mMobileNo = Convert.ToString(DB.DataTable.Rows[0]["MobileNo"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                //return that everything worked ok
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string startDate, string mobileNo)
        {
            //create a string variable to store the error
            string Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the firstname is  blank
            if (firstName.Length < 3)
            {
                //record error
                Error = Error + "The FirstName may not be less than 3 characters  : ";
            }
            if (firstName.Length > 20)
            {
                //record error
                Error = Error + "The FirstName may not be more than 20 characters  : ";
            }
            try
            {
                //copy the startdate value to the datetemp variable
                DateTemp = Convert.ToDateTime(startDate);
                //check to see if the date is less than todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            
            catch
                {
                    //record the error
                    Error = Error + "The date was not a valid date";
                }
            if (lastName.Length < 3)
            {
                //record error
                Error = Error + "The FirstName may not be less than 3 characters  : ";
            }
            if (lastName.Length > 20)
            {
                //record error
                Error = Error + "The FirstName may not be more than 20 characters  : ";
            }
            if (mobileNo.Length < 9)
            {
                //record the error
                Error = Error + "The MobileNo must not be less than 11 characters";
            }
            if (mobileNo.Length > 14)
            {
                //record the error
                Error = Error + "The MobileNo must be less than 14 characters";
            }
            //return any error messages
            return Error;
        }
    }
}
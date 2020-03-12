using System;
using System.Collections.Generic;

namespace DMUCarsclasses
{
    public class clsStaffCollection
    {
        //private data member for the lsit
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member thisStaff
        clsStaff mThisStaff = new clsStaff();

        //public property for thisstaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mStaffList.Count;
            }
            set
            {

            }
        }
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                //set the private variable
                mStaffList = value;
            }
        }

        public clsStaffCollection()
        {
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to be process
            while (Index < RecordCount)
            {
                //create a blank staff 
                clsStaff staff = new clsStaff();
                //read in the field from the current record
                staff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                staff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                staff.MobileNo = Convert.ToString(DB.DataTable.Rows[Index]["MobileNumber"]);
                staff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                staff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                //add the record to the private data member
                mStaffList.Add(staff);
                //point at the next record
                Index++;

            }

        }



        public int Add()
        {
            //adds a new record to the database basd on the value of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@MobileNo", mThisStaff.MobileNo);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }
        




        //constructor for the class
    
       
    }

   
}
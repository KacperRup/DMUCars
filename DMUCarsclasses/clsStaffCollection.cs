using System;
using System.Collections.Generic;
using DMUCarsclasses;
using DMUCarsBackOffice;

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
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proecedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisstaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Find()
        {
            clsStaffCollection staff = new clsStaffCollection();
            staff.ThisStaff.Find(3);
        }

        public void Update()
        {
            //update an existing record based in the values of thisstaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@MobileNo", mThisStaff.MobileNo);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByLastName(string LastName)
        {
            //filters the record based on a full or partial staffid
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Stafflastname parameter to the database
            DB.AddParameter("@LastName", LastName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByLastName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in teh parameter DB

            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //execute the stored procedure
            mStaffList = new List<clsStaff>();
            //while there are records to be process
            while (Index < RecordCount)
            {
                //create a blank staff 
                clsStaff AStaff = new clsStaff();
                //read in the field from the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AStaff.MobileNo = Convert.ToString(DB.DataTable.Rows[Index]["MobileNo"]);
                AStaff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
       
        }
    }
}
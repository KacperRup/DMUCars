using System.Collections.Generic;
using System;

namespace DMUCars_Classes
{
    public class clsDMUCarCollection
    {
        //private data member for the list
        List<clsDMUCars> mCarList = new List<clsDMUCars>();
        //private data member thisCar
        clsDMUCars mThisCar = new clsDMUCars();

        public List<clsDMUCars> CarList
        {
            get
            {
                return mCarList;
            }
            set
            {
                //set the private data
                mCarList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCarList.Count;
            }          
            set
            {
                //need to do later!!!!!!!!
            }
        }
        //public property for this class
        public clsDMUCars ThisCar
        {
            get
            {
                //return the private data
                return mThisCar;
            }
            set
            {
                //set the private data
                mThisCar = value;
            }
        }
        //constructor for the class
        public clsDMUCarCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCars_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisCar
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarBrand", mThisCar.CarBrand);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@CarPrice", mThisCar.CarPrice);
            DB.AddParameter("@CarYearProduced", mThisCar.CarYearProduced);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblCars_Insert");
        }
        
        public void Delete()
        {
            //deletes the record pointed by thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarID", mThisCar.CarID);
            //execute the stored procedure
            DB.Execute("sproc_tblCars_Delete");
        }

        //function for updating records
        public void Update()
        {
            //adds a new record to the database based on the values of thisCar
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarID", mThisCar.CarID);
            DB.AddParameter("@CarBrand", mThisCar.CarBrand);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@CarPrice", mThisCar.CarPrice);
            DB.AddParameter("@CarYearProduced", mThisCar.CarYearProduced);
            //execute the SQL returning the primary key value 
            DB.Execute("sproc_tblCars_Update");
        }

        public void ReportByCarModel(string CarModel)
        {
            //filters the records based on a full or partial post code
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the CarModel parameter to the database
            DB.AddParameter("@CarModel", CarModel);
            //execute the stored procedure
            DB.Execute("sproc_tblCars_FilterByCarModel");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCarList = new List<clsDMUCars>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsDMUCars ACar = new clsDMUCars();
                //read in the fields from the current record
                ACar.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                ACar.CarBrand = Convert.ToString(DB.DataTable.Rows[Index]["CarBrand"]);
                ACar.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                ACar.CarColour = Convert.ToString(DB.DataTable.Rows[Index]["CarColour"]);
                ACar.CarPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["CarPrice"]);
                ACar.CarYearProduced = Convert.ToDateTime(DB.DataTable.Rows[Index]["CarYearProduced"]);
                //add the records to the private data member
                mCarList.Add(ACar);
                //point to the next record
                Index++;
            }
        }
        

    }
}
using System.Collections.Generic;
using System;
using DMUCars_Classes;

namespace DMUCars_Classes
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private member thisOrder
        clsOrder mThisOrder = new clsOrder();

        public clsOrder ThisOrder
        {
            get
            {
                //reutn the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        //public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {

            }
        }
        //constructor for the class
        public clsOrderCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        public int Add()
        {
            //adds a new record to the database based on the value of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@CarID", mThisOrder.CarID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed by thisorder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@CarID", mThisOrder.CarID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByCarID(string CarID)
        {
            //filters the recorsd based on a full or partial carid
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the carid parameter to the database
            DB.AddParameter("@CarID", CarID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCarID");
            //populaten the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Order
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.CustomerNo = Convert.ToString(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnOrder.CarID = Convert.ToString(DB.DataTable.Rows[Index]["CarID"]);
                AnOrder.StaffID = Convert.ToString(DB.DataTable.Rows[Index]["StaffID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }
}

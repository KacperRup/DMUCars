using System;
namespace DMUCars_Classes
{
    public class clsOrder
    {
        private Int32 mOrderNo;
        //private data member for the customerno
        private string mCustomerNo;
        //privtae data for orderDate
        private DateTime mOrderDate;
        //private data for delviery date
        private DateTime mDeliverydate;
        //private data for carID
        private string mCarID;
        //private data for StaffID
        private string mStaffID;

        //public property for CustomerNo

        public string CarID
        {
            get
            {
                return mCarID;
            }
            set
            {
                mCarID = value;
            }
        }
        public string CustomerNo
        {
            get
            {
                //return the private data
                return mCustomerNo;
            }
            set
            {
                //set the private data
                mCustomerNo = value;
            }
        }
        public DateTime DeliveryDate
        {
            get
            {
                //return the private data
                return mDeliverydate;
            }
            set
            {
                //set the private data
                mDeliverydate = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        public int OrderNo
        {
            get
            {
                //return the private data
                return mOrderNo;
            }
            set
            {
                //set the value of private data member
                mOrderNo = value;
            }
        }
        public string StaffID
        {
            get
            {
                //return the private data
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }

        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the OrderNo to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if on record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerNo = Convert.ToString(DB.DataTable.Rows[0]["CustomerNo"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mDeliverydate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                mCarID = Convert.ToString(DB.DataTable.Rows[0]["CarID"]);
                mStaffID = Convert.ToString(DB.DataTable.Rows[0]["StaffID"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string customerNo, string orderDate, string deliveryDate, string carID, string staffID)
        {
            //create a string variable to store the error
            string Error = "";
            DateTime DateTemp;
            //if the CustomerNo is blank
            if (customerNo.Length < 7)
            {
                //record the error
                Error = Error + "The CustomerNo must contain less than 7 characters: ";
            }
            //if the customer no is greater than 7 characters
            if (customerNo.Length > 7)
            {
                //record the error
                Error = Error + "The CustomerNo must be more than 7 characters";

            }
            try
            {
                //copy the dateAdded value to the datetemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past: ";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }
            try
            {
                //copy the dateAdded value to the datetemp variable
                DateTemp = Convert.ToDateTime(deliveryDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past: ";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.AddDays(31))
                {
                    //record the error
                    Error = Error + "The Date cannot be that far in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }
            if (carID.Length < 4)
            {
                //record the error
                Error = Error + "The CarID must be less than 4 characters: ";
            }
            //if the customer no is greater than 7 characters
            if (carID.Length > 4)
            {
                //record the error
                Error = Error + "The CarID must be more than 4 characters";
            }
            {
            }
            if (staffID.Length < 7)
            {
                //record the error
                Error = Error + "The staffID must be less than 4 characters: ";
            }
            //if the customer no is greater than 7 characters
            if (staffID.Length > 7)
            {
                //record the error
                Error = Error + "The staffID must be more than 4 characters";
            }
            return Error;
        }
    }
}
using System;

namespace DMUCars_Classes
{
    public class clsDMUCars
    {
        private Int32 mCarID;
        private string mCarBrand;
        private string mCarModel;
        private string mCarColour;
        private int mCarPrice;
        private DateTime mCarYearProduced;
        public int CarID
        {
            get
            {
                return mCarID;
            }
            set
            {
                //set the value of the private data member
                mCarID = value;
            }
        }          
        public string CarBrand
        {
            get
            {
                return mCarBrand;
            }
            set
            {
                mCarBrand = value;
            }
        }
        public string CarModel
        {
            get
            {
                return mCarModel;
            }
            set
            {
                mCarModel = value;
            }
        }
        public string CarColour
        {
            get
            {
                return mCarColour;
            }
            set
            {
                mCarColour = value;
            }
        }

        public int CarPrice
        {
            get
            {
                return mCarPrice;
            }
            set
            {
                mCarPrice = value;
            }                
        }
        public DateTime CarYearProduced
        {
            get
            {
                return mCarYearProduced;
            }
            set
            {
                mCarYearProduced = value;
            }
        }
        public bool Find(int CarID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the car ID to search for
            DB.AddParameter("CarID", CarID);
            //execute the store procedure
            DB.Execute("sproc_tblCars_FilterByCarID");
            //if one record is found (there should be either one or zero!)
            if(DB.Count == 1)
            {
                //copy the data from the database to the priovate data members
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                mCarBrand = Convert.ToString(DB.DataTable.Rows[0]["CarBrand"]);
                mCarModel = Convert.ToString(DB.DataTable.Rows[0]["CarModel"]);
                mCarColour = Convert.ToString(DB.DataTable.Rows[0]["CarColour"]);
                mCarPrice = Convert.ToInt32(DB.DataTable.Rows[0]["CarPrice"]);
                mCarYearProduced = Convert.ToDateTime(DB.DataTable.Rows[0]["CarYearProduced"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //reutrn false indicating a problem
                return false;
            }
        }

        public string Valid(string carBrand, string carModel, string carColour, string carPrice, string carYearProduced)
        {
            //string variable to store the error;
            String Error = "";
            DateTime DateTemp;
            if (carBrand.Length < 3)
            {
                //record the error
                Error = Error + "The Car Brand must be more than 2 chracters of length : ";
            }
            //if the CarBrand is greater than 3
            if (carBrand.Length > 20)
            {
                //record the error
                Error = Error + "The Car Brand must be less than 20 characters : ";
            }
            if (carModel.Length == 0)
            {
                //record the error
                Error = Error + "The Car Model cannot be empty : ";
            }
            if (carModel.Length > 30)
            {
                //record the error
                Error = Error + "The Car Model cannot be over 30 characters of length : ";
            }
            if (carColour.Length < 3)
            {
                //record the error
                Error = Error + "The Car Colour must be more than 2 characters : ";
            }
            if (carColour.Length > 20)
            {
                //record the error
                Error = Error + "The Car Colour must be more than 20 characters of length : ";
            }
            if (carPrice.Length < 3)
            {
                //record the error
                Error = Error + "The Car Price must be above £100.00 in value : ";
            }
            if (carPrice.Length > 5)
            {
                //record the error
                Error = Error + "The Car Price must be below £999,999.99 in value : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(carYearProduced);
                if (DateTemp < DateTime.Today.AddYears(-20))
                {
                    //record the error 
                    Error = Error + "The car cannot be produced more than 20 years ago: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannt be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            //return any error message
            return Error;
        }
    }
}
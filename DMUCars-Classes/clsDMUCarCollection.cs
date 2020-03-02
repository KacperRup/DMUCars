using System.Collections.Generic;

namespace DMUCars_Classes
{
    public class clsDMUCarCollection
    {
        //private data member for the list
        List<clsDMUCars> mCarList = new List<clsDMUCars>();

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
        public clsDMUCars ThisCar { get; set; }
    }
}
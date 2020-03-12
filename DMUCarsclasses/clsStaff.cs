using System;
using System.Collections.Generic;

namespace DMUCarsclasses
{
    public class clsStaff
    {
        public static List<clsStaff> datasource;

        public string MobileNo { get; set; }
        public int StaffID { get; set; }
        public DateTime StartDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public clsStaff ThisStaff { get; set; }

        public void Find(int primaryKey)
        {
            clsStaff SomeStaff = new clsStaff();
            SomeStaff.Find(3);
        }
    }
}
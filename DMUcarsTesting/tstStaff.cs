using System;
using DMUCarsclasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMUcarsTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance
            clsStaff DMUCars = new clsStaff();
            // test to see that it exists
            Assert.IsNotNull(DMUCars);
        }
        [TestMethod]
        public void StaffPropertyOK()
        {
            //create an instance of the class we wat to create 
            clsStaff DMUCars = new clsStaff();
            //create some test data to assign to the property 
            
        }

    }
}

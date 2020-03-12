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
        [TestMethod]
        public void StaffMobileNo()
        {
            //create an instance of the class we want to create
            clsStaff DMUCars = new clsStaff();
            //create some test data to assign to the property
            string TestData = "123456789";
            //assign the data to the property
            DMUCars.MobileNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(DMUCars.MobileNo, TestData);
        }
        [TestMethod]
        public void StaffID()
        {
            //create an instance of the class we want to create
            clsStaff DMUCars = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            DMUCars.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(DMUCars.StaffID, TestData);
        }

        [TestMethod]
        public void DateJoined()
        {
            //create an instance of the class we want to create
            clsStaff DMUCars = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            DMUCars.StartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(DMUCars.StartDate, TestData);
        }

        [TestMethod]
        public void FirstNameK()
        {
            //create an instance of the class we want to create
            clsStaff Name = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Aasim";
            //assign the data to the property
            Name.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Name.FirstName, TestData);
        }
        [TestMethod]
        public void LastName()
        {
            //create an instance of the class we want to create
            clsStaff Name = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Saina";
            //assign the data to the property
            Name.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Name.LastName, TestData);
        }
       

    }
}

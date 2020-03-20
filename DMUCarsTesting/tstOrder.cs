using System;
using DMUCars_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMUCarsTesting
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass the method
        string customerNo = "CUST002";
        string orderDate = DateTime.Now.Date.ToString();
        string deliveryDate = DateTime.Now.Date.ToString();
        string carID = "M346";
        string staffID = "STAFF01";


        [TestMethod]
        public void IntanceOK()
        {
            clsOrder AOrder = new clsOrder();
            //test too see that it exists
            Assert.IsNotNull(AOrder);
        }
        [TestMethod]
        public void CarIDPropertyOK()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = "M345";
            AOrder.CarID = TestData;
            Assert.AreEqual(AOrder.CarID, TestData);
        }
        [TestMethod]
        public void CustomerPropertyOK()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = "CUST001";
            AOrder.CustomerNo = TestData;
            Assert.AreEqual(AOrder.CustomerNo, TestData);
        }
        [TestMethod]
        public void DeliveryDatePropertyOK()
        {
            clsOrder AOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AOrder.DeliveryDate = TestData;
            Assert.AreEqual(AOrder.DeliveryDate, TestData);

        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AOrder.OrderDate = TestData;
            Assert.AreEqual(AOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void OrderNoPropertyOK()
        {
            clsOrder AOrder = new clsOrder();
            Int32 TestData = 1;
            AOrder.OrderNo = TestData;
            Assert.AreEqual(AOrder.OrderNo, TestData);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = "STAFF01";
            AOrder.StaffID = TestData;
            Assert.AreEqual(AOrder.StaffID, TestData);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any message
            string Error = "";
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string customerNo = "C"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMinMinusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string customerNo = "CUST00"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string customerNo = "CUST000"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string customerNo = "CUST0001"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string customerNo = "CUST99"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string customerNo = "CUST999"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string customerNo = "CUST1000"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string customerNo = "CUS"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string customerNo = "";
            customerNo = customerNo.PadRight(500, 'C');//this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string orderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string orderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string orderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string orderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string orderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            string Error = "";
            //set the dateadded to a non date value
            string orderDate = "this is not a date";
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(30);
            //convert the date variable to a string variable
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to whatever the date is plus 100 days
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test too see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //set the dateadded to a non date value
            string deliveryDate = "this is not a date";
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarIDExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string carID = "M"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarIDMinMinusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string carID = "M00"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarIDMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string carID = "M001"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string carID = "M0001"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarIDMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string carID = "M99"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarIDMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string carID = "M999"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarIDMaxPlusOne()
        {
            //create an instae of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string carID = "M1000"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarIDMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string carID = "M00"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string carID = "";
            carID = carID.PadRight(500, 'M');//this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string staffID = "S"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMinMinusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string staffID = "STAFF0"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string staffID = "STAFF01"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string staffID = "STAFF001"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string staffID = "STAFF999"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string staffID = "STAFF99"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            //create an instae of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string staffID = "STAFF100"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string staffID = "STAFF"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            string staffID = "";
            staffID = staffID.PadRight(500, 'S');//this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(customerNo, orderDate, deliveryDate, carID, staffID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsDMUCars AOrder = new clsDMUCars();
            string TestData = "01/02/2020";
            AOrder.OrderDate = TestData;
            Assert.AreEqual(AOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void OrderNoPropertyOK()
        {
            clsDMUCars AOrder = new clsDMUCars();
            string TestData = "123";
            AOrder.OrderNo = TestData;
            Assert.AreEqual(AOrder.OrderNo, TestData);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsDMUCars AOrder = new clsDMUCars();
            string TestData = "STAFF01";
            AOrder.StaffID = TestData;
            Assert.AreEqual(AOrder.StaffID, TestData);

        }
    }
}

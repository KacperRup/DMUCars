using System;
using DMUCarsclasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMUcarsTesting
{
    [TestClass]
    public class tstStaff
    {
        //good test data 
        //create some test data to pass to the method
        string FirstName = "somename";
        string lastName = "somelastname";
        string MobileNo = "1234567891";
        string StartDate = DateTime.Now.Date.ToString();

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
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameNoMinLess()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "ab"; // this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void FirstNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            FirstName = FirstName.PadLeft(50, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "abc"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNamePlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "abcd"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            FirstName = FirstName.PadRight(19, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            FirstName = FirstName.PadRight(20, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            FirstName = FirstName.PadRight(21, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            FirstName = FirstName.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StartDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate; //this should be ok
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string varible
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate; //this should be ok
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string varible
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StartDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate; //this should be ok
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string varible
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate; //this should be ok
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string varible
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message 
            string Error = "";
            //set the dateadded to a non date value
            string StartDate = "this is not a date";
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameNoMinLess()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string lastName = "ab"; // this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void LastNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string lastName = ""; //this should be ok
            lastName = lastName.PadLeft(50, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string lastName = "abc"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNamePlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string lastName = "abcd"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string lastName = ""; //this should be ok
            lastName = lastName.PadRight(19, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string lastName = ""; //this should be ok
            lastName = lastName.PadRight(20, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            FirstName = FirstName.PadRight(21, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string lastName = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string lastName = ""; //this should be ok
            lastName = lastName.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void MobileNoMinLess()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string MobileNo = "11111111"; // this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void MobileNoExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string MobileNo = "a"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MobileNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string MobileNo = ""; //this should be ok
            MobileNo = MobileNo.PadRight(11, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MobileNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string MobileNo = ""; //this should be ok
            MobileNo = MobileNo.PadRight(12, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MobileNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string MobileNo = ""; //this should be ok
            MobileNo = MobileNo.PadRight(13, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MobileNoMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string MobileNo = ""; //this should be ok
            MobileNo = MobileNo.PadRight(14, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MobileNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string MobileNo = ""; //this should be ok
            MobileNo = MobileNo.PadRight(15, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void MobileNoMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string MobileNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MobileNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string MobileNo = ""; //this should be ok
            MobileNo = MobileNo.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, lastName, StartDate, MobileNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

    }
}

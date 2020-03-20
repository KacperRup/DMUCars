using System;
using System.Collections.Generic;
using DMUCarsclasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMUcarsTesting
{
    [TestClass]
    public class tstStaffCollection
    {
     

        [TestMethod]
        public void InstanceOK()
        {
            //create a instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exist
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the ist
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.FirstName = "Aasim";
            TestItem.LastName = "Saina";
            TestItem.MobileNo = "12345678912";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.StaffID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

        [TestMethod]
        public void DateAddedProperty()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.StartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StartDate, TestData);
        }

        [TestMethod]
        public void StaffIDProperty()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 12345;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffMobileNoProperty()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "12345678912";
            //assign the data to the property
            AStaff.MobileNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.MobileNo, TestData);
        }

        [TestMethod]
        public void LastNameProperty()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "SomeLastName";
            //assign the data to the property
            AStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.LastName, TestData);
        }
        [TestMethod]
        public void FirstNameProperty()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "SomeName";
            //assign the data to the property
            AStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FirstName, TestData);
        }



        [TestMethod]
        public void ThisStaffProperty()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set its properties 
            TestStaff.FirstName = "Aasim";
            TestStaff.LastName = "Saina";
            TestStaff.MobileNo = "12345678912";
            TestStaff.StartDate = DateTime.Now.Date;
            TestStaff.StaffID = 2;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }



        [TestMethod]
        public void ListandCount()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the ist
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.FirstName = "Aasim";
            TestItem.LastName = "Saina";
            TestItem.MobileNo = "12345678912";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.StaffID = 3;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);


        }
        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //vat to store the primary key
            Int32 PrimaryKey = 0;
            //set its property
            TestItem.FirstName = "somename";
            TestItem.LastName = "somelastname";
            TestItem.MobileNo = "123456789";
            TestItem.StaffID = 4;
            TestItem.StartDate = DateTime.Now.Date;
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);



        }
        [TestMethod]
        public void DeleteMethod()
        {
            //create an instance of the class we want to create
            clsStaffCollection Staff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName = "somename";
            TestItem.LastName = "somelastname";
            TestItem.MobileNo = "123456789";
            TestItem.StaffID = 12518;
            TestItem.StartDate = DateTime.Now.Date;
            //set thisStaff to the test data
            Staff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = Staff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            Staff.ThisStaff.Find(PrimaryKey);
            //delete the record
            Staff.Delete();
            //now find the record
            Boolean Found = Staff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            //create an instance of the class we want to create
            clsStaffCollection Staff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName = "somename";
            TestItem.LastName = "somelastname";
            TestItem.MobileNo = "123456789";
            TestItem.StartDate = DateTime.Now.Date;
            //set thisStaff to the test data
            Staff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = Staff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test data
            TestItem.FirstName = "anothername";
            TestItem.LastName = "anotherlastname";
            TestItem.MobileNo = "123456788";
            TestItem.StartDate = DateTime.Now.Date;
            //set the record based on the new test data
            Staff.ThisStaff = TestItem;
            //update the record
            Staff.Update();
            //find the record
            Staff.ThisStaff.Find(PrimaryKey);
            //test to see thisstaff matches the test data
            Assert.AreEqual(Staff.ThisStaff, TestItem);
        }

        [TestMethod]

        public void ReportByLastNameMethod()
        {
            //create an instance of the class containing the unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance if the instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByLastName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }
        [TestMethod]

        public void ReportByLastNameNoneFound()
        {
            //create an instance if the instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a staffid that doesnt exist
            FilteredStaff.ReportByLastName("xxxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByLastNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilterLastname = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a lastname that doesnt exist
            FilterLastname.ReportByLastName("xxx");
            if (FilterLastname.Count == 2)
            {
                //check that the first record is ID 12324
                if (FilterLastname.StaffList[0].StaffID != 12324)
                {
                    OK = false;
                }
                //check that the last record id is 12324
                if (FilterLastname.StaffList[1].StaffID != 12395)
                {
                    OK = false;
                }
                //test to see that there are no records 
                Assert.IsTrue(OK);
            }
        }
        [TestMethod]
        public void FindMethod()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 12518;
            //invoke a method
            Found = AStaff.Find(StaffID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is okay 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 12518;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id 
            if (AStaff.StaffID != 12518)
            {
                OK = false;
            }
            //test to see that the result result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffMobileNoFound()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is okay 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 12518;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id 
            if (AStaff.MobileNo != "123456789")
            {
                OK = false;
            }
            //test to see that the result result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffStartDateFound()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is okay 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 12518;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id 
            if (AStaff.StartDate != Convert.ToDateTime("19/03/2020") )
            {
                OK = false;
            }
            //test to see that the result result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffFirstNameFound()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is okay 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 12518;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id 
            if (AStaff.FirstName != "somename")
            {
                OK = false;
            }
            //test to see that the result result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffLastNameFound()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is okay 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 12518;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id 
            if (AStaff.LastName != "somelastname")
            {
                OK = false;
            }
            //test to see that the result result is correct
            Assert.IsTrue(OK);
        }
    


    }

}

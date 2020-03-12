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
            TestItem.MobileNo = "1";
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
        public void ThisStaffProperty()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set its properties 
            TestStaff.FirstName = "Aasim";
            TestStaff.LastName = "Saina";
            TestStaff.MobileNo = "1";
            TestStaff.StartDate = DateTime.Now.Date;
            TestStaff.StaffID = 1;
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
            TestItem.MobileNo = "1";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.StaffID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);


        }
        [TestMethod]
        public void AddMethodOK()
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
            TestItem.StaffID = 1;
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


    }
}

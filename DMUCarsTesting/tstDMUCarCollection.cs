using System;
using DMUCars_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DMUCarsTesting
{
    [TestClass]
    public class tstDMUCarCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsDMUCarCollection AllCars = new clsDMUCarCollection();
            Assert.IsNotNull(AllCars);
        }
        [TestMethod]
        public void CarListOK()
        {
            //create an instance of the class we want to create
            clsDMUCarCollection AllCars = new clsDMUCarCollection();
            //create some test data to assign the property
            //in this case the data needs to be a list of objects
            List<clsDMUCars> TestList = new List<clsDMUCars>();
            //add an item to the list
            //create the item of test data
            clsDMUCars TestItem = new clsDMUCars();
            //set its properties
            TestItem.CarID = 1;
            TestItem.CarBrand = "Vauxhall";
            TestItem.CarModel = "Corsa";
            TestItem.CarColour = "Blue";
            TestItem.CarPrice = 2000;
            TestItem.CarYearProduced = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            Assert.AreEqual(AllCars.CarList, TestList); 
        }
        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsDMUCarCollection AllCars = new clsDMUCarCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 2;
        //    //assign the data to the property
        //    AllCars.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCars.Count, SomeCount);
        //}
        [TestMethod]
        public void ThisCarListPropertyOK()
        {
            //create an instance of the class we want to create
            clsDMUCarCollection AllCars = new clsDMUCarCollection();
            //create some test data to assign the property
            clsDMUCars TestCar = new clsDMUCars();
            //set its properties
            TestCar.CarID = 1;
            TestCar.CarBrand = "Vauxhall";
            TestCar.CarModel = "Corsa";
            TestCar.CarColour = "Blue";
            TestCar.CarPrice = 2000;
            TestCar.CarYearProduced = DateTime.Now.Date;
            //assign the data to the property
            AllCars.ThisCar = TestCar;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.ThisCar, TestCar);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsDMUCarCollection AllCars = new clsDMUCarCollection();
            //create some test data to assign the property
            //in this case the data needs to be a list of objects
            List<clsDMUCars> TestList = new List<clsDMUCars>();
            //add an item to the list
            //create the item of test data
            clsDMUCars TestItem = new clsDMUCars();
            //set its properties
            TestItem.CarID = 1;
            TestItem.CarBrand = "Vauxhall";
            TestItem.CarModel = "Corsa";
            TestItem.CarColour = "Blue";
            TestItem.CarPrice = 200;
            TestItem.CarYearProduced = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsDMUCarCollection AllCars = new clsDMUCarCollection();
        //    //test to see that two values are the same
        //    Assert.AreEqual(AllCars.Count, 2);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsDMUCarCollection AllCars = new clsDMUCarCollection();
            //create the item of test data
            clsDMUCars TestItem = new clsDMUCars();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            //set its properties
            TestItem.CarID = 1;
            TestItem.CarBrand = "some brand";
            TestItem.CarModel = "Some model";
            TestItem.CarColour = "some colour";
            TestItem.CarPrice = 12;
            TestItem.CarYearProduced = DateTime.Now.Date;
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary ket of the test data
            TestItem.CarID = PrimaryKey;
            //find the record
            //AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsDMUCarCollection AllCars = new clsDMUCarCollection();
            //create the item of test data
            clsDMUCars TestItem = new clsDMUCars();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CarID = 1;
            TestItem.CarBrand = "some brand";
            TestItem.CarModel = "Some model";
            TestItem.CarColour = "some colour";
            TestItem.CarPrice = 12;
            TestItem.CarYearProduced = DateTime.Now.Date;
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary ket of the test data
            TestItem.CarID = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //delete the record
            AllCars.Delete();
            //now find the record
            Boolean Found = AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsDMUCarCollection AllCars = new clsDMUCarCollection();
            //create the item of test data
            clsDMUCars TestItem = new clsDMUCars();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CarBrand = "some brand";
            TestItem.CarModel = "Some model";
            TestItem.CarColour = "some colour";
            TestItem.CarPrice = 12;
            TestItem.CarYearProduced = DateTime.Now.Date;
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //modify the test data
            TestItem.CarBrand = "some bddrand";
            TestItem.CarModel = "Some mdddel";
            TestItem.CarColour = "some codddur";
            TestItem.CarPrice = 17;
            TestItem.CarYearProduced = DateTime.Now.Date;
            //set the record based on the new test data
            AllCars.ThisCar = TestItem;
            //update the record
            AllCars.Update();
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see ThisCar matches the test data
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void ReportByCarModelMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsDMUCarCollection AllCars = new clsDMUCarCollection();
            //create an instance of the filtered data
            clsDMUCarCollection FilteredCars = new clsDMUCarCollection();
            //apply a blank string reutring all records
            FilteredCars.ReportByCarModel("");
            //test to see that two of the values are the same
            Assert.AreEqual(AllCars.Count, FilteredCars.Count);
        }

        [TestMethod]
        public void ReportByCarModelNoneFound()
        {
            //create an instance of the collection class
            clsDMUCarCollection FilteredCars = new clsDMUCarCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a car model that doesnt exist
            FilteredCars.ReportByCarModel("xxx xxx");
            //check that the correct number of records are found
            if (FilteredCars.Count ==2)
            {
                //check that the first record is ID=11
                if (FilteredCars.CarList[0].CarID !=11)
                {
                    OK = false;
                }
                //check that the first record is ID=12
                if (FilteredCars.CarList[1].CarID !=12)
                {
                    OK = false;
                }
            else
                {
                    OK = false;
                }
                Assert.IsTrue(OK);               
            }
        }

    }
}

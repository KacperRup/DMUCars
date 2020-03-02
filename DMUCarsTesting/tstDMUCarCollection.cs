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
            TestItem.CarID = "AMC12";
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
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsDMUCarCollection AllCars = new clsDMUCarCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllCars.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.Count, SomeCount);
        }
        [TestMethod]
        public void ThisCarListPropertyOK()
        {
            //create an instance of the class we want to create
            clsDMUCarCollection AllCars = new clsDMUCarCollection();
            //create some test data to assign the property
            clsDMUCars TestCar = new clsDMUCars();
            //set its properties
            TestCar.CarID = "AMC12";
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
            TestItem.CarID = "AMC12";
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
    }
}

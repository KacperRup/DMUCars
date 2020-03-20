using System;
using DMUCars_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMUCarsTesting
{
    [TestClass]
    public class tstDMUCars
    {
        //good test data
        //create some test data to pass to the method
        string CarBrand = "SomeBrand";
        string CarModel = "SomeModel";
        string CarColour = "SomeColour";
        string CarPrice = Convert.ToString("1000");
        string CarYearProduced = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            clsDMUCars ACar = new clsDMUCars();
            Assert.IsNotNull(ACar);
        }

        [TestMethod]
        public void CarIDPropertyOK()
        {
            clsDMUCars ACar = new clsDMUCars();
            Int32 TestData = 1;
            ACar.CarID = TestData;
            Assert.AreEqual(ACar.CarID, TestData);
        }
        [TestMethod]
        public void CarBrandPropertyOK()
        {
            clsDMUCars ACar = new clsDMUCars();
            string TestData = "Vauxhall";
            ACar.CarBrand = TestData;
            Assert.AreEqual(ACar.CarBrand, TestData);
        }
        [TestMethod]
        public void CarModelPropertyOK()
        {
            clsDMUCars ACar = new clsDMUCars();
            string TestData = "Corsa";
            ACar.CarModel = TestData;
            Assert.AreEqual(ACar.CarModel, TestData);
        }
        [TestMethod]
        public void CarColourPropertyOK()
        {
            clsDMUCars ACar = new clsDMUCars();
            string TestData = "Red";
            Assert.IsNotNull(ACar);
            ACar.CarColour = TestData;
            Assert.AreEqual(ACar.CarColour, TestData);
        }
        [TestMethod]
        public void CarPricePropertyOK()
        {
            clsDMUCars ACar = new clsDMUCars();
            Int32 TestData = 1;
            ACar.CarPrice = TestData;
            Assert.AreEqual(ACar.CarPrice, TestData);
        }
        [TestMethod]
        public void CarYearProducedPropertyOK()
        {
            clsDMUCars ACar = new clsDMUCars();
            DateTime TestData = DateTime.Now.Date;
            ACar.CarYearProduced = TestData;
            Assert.AreEqual(ACar.CarYearProduced, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CarID = 1;
            //invoke the method
            Found = ACar.Find(CarID);
            //test to see tha the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCarIDFound()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 11;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the CarID
            if (ACar.CarID != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarBrandFound()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 11;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the property
            if (ACar.CarBrand != "Toyota")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CarBrandMinLessOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "aa";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandMin()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "aaa";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandMinPlusOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "aaaa";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandMaxLessOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "1234567890123456789";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandMax()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "12345678901234567890";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandMid()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "1234567890";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandMaxPlusOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "123456789012345678901"; //this should fail
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarBrandExtremeMax()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "";
            CarBrand = CarBrand.PadRight(300, 'a');
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestCarModelFound()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 11;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the CarID
            if (ACar.CarModel != "Yaris")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CarModelMinLessOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarModel = "";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMin()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarModel = "a";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMinPlusOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarModel = "aa";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMid()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarModel = "123456789012345";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMaxLessOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarModel = "12345678901234567890123456789";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMax()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarModel = "123456789012345678901234567890";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarModelMaxPlusOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarModel = "1234567890123456789012345678901";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarModelExtremerMax()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarModel= "";
            CarModel = CarModel.PadRight(400, 'a');
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestCarColourFound()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 11;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the CarID
            if (ACar.CarColour != "Green")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CarColourMinLessOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarColour = "aa";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarColourMin()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarColour = "aaa";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColourMinPlusOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarColour = "aaaa";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColourMaxLessOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarColour = "1234567890123456789";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColourMax()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarColour = "12345678901234567890";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarColourMid()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "1234567890";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarColourMaxPlusOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "123456789012345678901"; //this should fail
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarColourExtremeMax()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "";
            CarBrand = CarBrand.PadRight(300, 'a');
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestCarPriceFound()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 11;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the property
            if (ACar.CarPrice != 2000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CarPriceMinLessOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarPrice = "99";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarPriceMin()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarPrice = "100";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarPriceMid()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarBrand = "500000";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarPriceMaxLessOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarColour = "999998";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarPriceMax()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarColour = "999999";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarPriceMaxPlusOne()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarColour = "1000000";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreEqual(Error, "");
        }
        public void CarPriceExtremeMax()
        {
            //create an instance of the class
            clsDMUCars ACar = new clsDMUCars();
            //variable to store error messages
            String Error = "";
            //test data to pass the method
            string CarColour = "10000000000000000000000000000000000";
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestCarYearProducedFound()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 11;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the CarID
            if (ACar.CarYearProduced != Convert.ToDateTime("06/12/2018"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CarYearProducedExtremeMin()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to less than 100 years from now
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string CarYearProduced = TestDate.ToString();
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarYearProducedMinLessOne()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to less than 100 years from now
            TestDate = TestDate.AddYears(-21);
            //convert the date variable to a string variable
            string CarYearProduced = TestDate.ToString();
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarYearProducedMin()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to more than than 20 years from now
            TestDate = TestDate.AddYears(-20);
            //convert the date variable to a string variable
            string CarYearProduced = TestDate.ToString();
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarYearProducedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to less than 100 years from now
            TestDate = TestDate.AddYears(-19);
            //convert the date variable to a string variable
            string CarYearProduced = TestDate.ToString();
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarYearProducedMax()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string CarYearProduced = TestDate.ToString();
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarYearProducedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddMinutes(1);
            //convert the date variable to a string variable
            string CarYearProduced = TestDate.ToString();
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarYearProducedExtreme()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string CarYearProduced = TestDate.ToString();
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CarYearProducedInvalidData()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //string variable to store any error message
            String Error = "";
            string CarYearProduced = "Not a date";
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsDMUCars ACar = new clsDMUCars();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACar.Valid(CarBrand, CarModel, CarColour, CarPrice, CarYearProduced);
        }
    }
}

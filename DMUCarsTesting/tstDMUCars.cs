using System;
using DMUCars_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMUCarsTesting
{
    [TestClass]
    public class tstDMUCars
    {
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
            string TestData = "MC323";
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
    }
}

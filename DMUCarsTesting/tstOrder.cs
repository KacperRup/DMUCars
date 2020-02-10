using System;
using DMUCars_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMUCarsTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void IntanceOK()
        {
            clsDMUCars AOrder = new clsDMUCars();
            //test too see that it exists
            Assert.IsNotNull(AOrder);
        }
        [TestMethod]
        public void CarIDPropertyOK()
        {
            clsDMUCars AOrder = new clsDMUCars();
            string TestData = "M345";
            AOrder.CarID = TestData;
            Assert.AreEqual(AOrder.CarID, TestData);
        }
        [TestMethod]
        public void CustomerPropertyOK()
        {
            clsDMUCars AOrder = new clsDMUCars();
            string TestData = "CUST001";
            AOrder.CustomerNo = TestData;
            Assert.AreEqual(AOrder.CustomerNo, TestData);
        }
        [TestMethod]
        public void DeliveryDatePropertyOK()
        {
            clsDMUCars AOrder = new clsDMUCars();
            string TestData = "21/06/2020";
            AOrder.DeliveryDate = TestData;
            Assert.AreEqual(AOrder.DeliveryDate, TestData);
            
        }
    }
}

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

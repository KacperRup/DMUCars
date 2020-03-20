using System;
using DMUCars_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DMUCarsTesting
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = "CUST001";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.CarID = "M345";
            TestItem.StaffID = "STAFF01";
            //add the item to the test list
            TestList.Add(TestItem);
            //add the item to the test list
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestOrder = new clsOrder();
            //set its properties
            TestOrder.OrderNo = 1;
            TestOrder.CustomerNo = "CUST001";
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.DeliveryDate = DateTime.Now.Date;
            TestOrder.CarID = "M345";
            TestOrder.StaffID = "STAFF01";
            //add the item to the test list
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = "CUST001";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.CarID = "M345";
            TestItem.StaffID = "STAFF01";
            //add the item to the test list
            TestList.Add(TestItem);
            //add the item to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = "CUST001";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.CarID = "M345";
            TestItem.StaffID = "STAFF01";
            //set ThisOrder to rthe test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderNo = 1055;
            TestItem.CustomerNo = "CUST001";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.CarID = "M345";
            TestItem.StaffID = "STAFF01";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethod()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerNo = "CUST001";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.CarID = "M345";
            TestItem.StaffID = "STAFF01";
            //set ThisOrder to rthe test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //modify the test data
            TestItem.CustomerNo = "CUST002";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.CarID = "M346";
            TestItem.StaffID = "STAFF01";
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void ReportByCarID()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered dagta
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrders.ReportByCarID("");
            //test to see that the 2 are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByCarIDNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a carID that doesnt exist
            FilteredOrders.ReportByCarID("xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);

        }
        [TestMethod]
        public void ReportByCarIDDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a CarID that doesnt exist
            FilteredOrders.ReportByCarID("xxxx");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is 36
                if (FilteredOrders.OrderList[0].OrderNo != 1055)
                {
                    OK = false;
                }
                //check that the first record ID is 37
                if (FilteredOrders.OrderList[1].OrderNo != 1057)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                //test to see that there are no records
                Assert.IsTrue(OK);
            }
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 1058;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean varible to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1058;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the OrderNo
            if (AnOrder.OrderNo != 1058)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean varible to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1058;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the OrderNo
            if (AnOrder.OrderDate != Convert.ToDateTime("15/03/2020"))
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean varible to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1058;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the OrderNo
            if (AnOrder.DeliveryDate != Convert.ToDateTime("15/03/2020"))
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCarIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean varible to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1058;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the OrderNo
            if (AnOrder.CarID != "M345")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean varible to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1058;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the OrderNo
            if (AnOrder.StaffID != "STAFF01")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
    }
}
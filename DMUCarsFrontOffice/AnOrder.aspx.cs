using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUCars_Classes;

public partial class AnOrder : System.Web.UI.Page
{
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            //populate the list of orders
            DisplayOrders();
            //if this is  not a mew record
            if (OrderNo != -1)
            {
                //display the current data for the record
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        //create an instance of the OrdersBook
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderNo);
        //display the data for this record
        txtCustomerID.Text = OrderBook.ThisOrder.CustomerNo;
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        txtDeliveryDate.Text = OrderBook.ThisOrder.DeliveryDate.ToString();
        txtCarID.Text = OrderBook.ThisOrder.CarID;
        txtStaffID.Text = OrderBook.ThisOrder.StaffID;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (OrderNo == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    void Add()
    {
        //create an instance of the Order Book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //validate the data on the web form
        string Error = OrderBook.ThisOrder.Valid(txtCustomerID.Text, txtOrderDate.Text, txtDeliveryDate.Text, txtCarID.Text, txtStaffID.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            OrderBook.ThisOrder.CustomerNo = txtCustomerID.Text;
            OrderBook.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            OrderBook.ThisOrder.DeliveryDate = Convert.ToDateTime(txtDeliveryDate.Text);
            OrderBook.ThisOrder.CarID = txtCarID.Text;
            OrderBook.ThisOrder.StaffID = txtStaffID.Text;
            OrderBook.Add();
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    void Update()
    {
        //create an instance of the Order Book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //validate the data on the web form
        string Error = OrderBook.ThisOrder.Valid(txtCustomerID.Text, txtOrderDate.Text, txtDeliveryDate.Text, txtCarID.Text, txtStaffID.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            OrderBook.ThisOrder.Find(OrderNo);
            //get the data entered by the user
            OrderBook.ThisOrder.CustomerNo = txtCustomerID.Text;
            OrderBook.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            OrderBook.ThisOrder.DeliveryDate = Convert.ToDateTime(txtDeliveryDate.Text);
            OrderBook.ThisOrder.CarID = txtCarID.Text;
            OrderBook.ThisOrder.StaffID = txtStaffID.Text;
            //update the record
            OrderBook.Update();
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an errpor
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    protected void txtOrderNo_TextChanged(object sender, EventArgs e)
    {

    }
}
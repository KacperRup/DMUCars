using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUCars_Classes;

public partial class Delete : System.Web.UI.Page
{
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
    }

    void DeleteOrder()
        //function to delete the OrderBook
    {
        //create a new instance
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record
        OrderBook.ThisOrder.Find(OrderNo);
        //deleter the record
        OrderBook.Delete();
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteOrder();
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUCars_Classes;

public partial class Delete : System.Web.UI.Page
{
    Int32 CarID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the car that need to be deleted from the session object
        CarID = Convert.ToInt32(Session["CarID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCar();
        //redirect back to default page
        Response.Redirect("Default.aspx");
    }
    void DeleteCar()
    {
        //function to delete the selected record

        //create a new instance of the car book
        clsDMUCarCollection CarBook = new clsDMUCarCollection();
        //find the record to delete
        CarBook.ThisCar.Find(CarID);
        //delete the record
        CarBook.Delete();
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
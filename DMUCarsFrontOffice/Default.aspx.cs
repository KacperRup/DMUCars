using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUCarsclasses;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed          
        if (IsPostBack ==false)
        {
            //update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create an instance of the county collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to the list of counties in the collection
        LstStaff.DataSource = Staff.StaffList;
        //set the name of the primary key
        LstStaff.DataTextField = "StaffID";
        //set the data field to display
        LstStaff.DataTextField = "PhoneNumber";
        //bind the data to the list
        LstStaff.DataBind();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("Staff.aspx");
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
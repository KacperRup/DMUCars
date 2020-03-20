using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUCars_Classes;

public partial class _Default : System.Web.UI.Page
{
    //this function handels the load event from the staff
    protected void Page_Load(object sender, EventArgs e)
    {
       if (IsPostBack == false)
        {
            //update the list box
            DisplayCars();
        }
    }
    void DisplayCars()
    {
        //create an instance of the Cars class
        DMUCars_Classes.clsDMUCarCollection Cars = new DMUCars_Classes.clsDMUCarCollection();
        //set the data source to the list of counties in the collection
        lstCars.DataSource = Cars.CarList;
        //set the name of the primary key
        lstCars.DataValueField = "CarID";
        //set the data field to display
        lstCars.DataTextField = "CarModel";
        //bind the data to the list
        lstCars.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store the session object to indicate this is a new record
        Session["CarID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ACar.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CarID;
        //if a record has been selected from the list
        if (lstCars.SelectedIndex != -1)
        {
            //get the primary key value of the record to be deleted 
            CarID = Convert.ToInt32(lstCars.SelectedValue);
            //store the data in the session object
            Session["CarID"] = CarID;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no records has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CarID;
        //if a record has been selected from the list
        if (lstCars.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CarID = Convert.ToInt32(lstCars.SelectedValue);
            //store the data in the session object
            Session["CarID"] = CarID;
            //redirect to the edit page
            Response.Redirect("ACar.aspx");
        }
        else //if no recordhas been selected
        {
            //display an error
            lblError.Text = "Please select a round to delete from the list";
        }
    }
    protected void txtAdd_Click(object sender, EventArgs e)
    {
        //store the session object to indicate this is a new record
        Session["CarID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ACar.aspx");
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        DisplayCars(txtCarModel.Text);
    }
}
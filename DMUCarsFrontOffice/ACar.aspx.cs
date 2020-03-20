using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUCars_Classes;



public partial class ACar : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CarID;

    //event handler for the page load
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of Cars to get processed
        CarID = Convert.ToInt32(Session["CarID"]);
        if (IsPostBack == false)
        {
            if(CarID != -1)
            {
                //display the current data for the record
                DisplayCars();
            }
        }


    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CarID == -1)
        {
            //adding record
            Add();
        }
        else
        {
            //update record
            Update();
        }
        Response.Redirect("Default.aspx");
    }

    void Add()
    {
        //create an instance of the collection class
        clsDMUCarCollection CarBook = new clsDMUCarCollection();
        //validate the data on the web form
        String Error = CarBook.ThisCar.Valid(txtCarBrand.Text, txtCarModel.Text, txtCarColour.Text, txtCarPrice.Text, txtCarYearProduced.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CarBook.ThisCar.CarBrand = txtCarBrand.Text;
            CarBook.ThisCar.CarModel = txtCarModel.Text;
            CarBook.ThisCar.CarColour = txtCarColour.Text;
            CarBook.ThisCar.CarPrice = Convert.ToInt32(txtCarPrice.Text);
            CarBook.ThisCar.CarYearProduced = Convert.ToDateTime(txtCarYearProduced.Text);
            //add the record
            CarBook.Add();
        }
        else
        {
            //report an error
            lblError.Text = "There was a problem with data entered " + Error;
        }
    }
    void Update()
    {
        //create an instance of the address book
        clsDMUCarCollection CarBook = new clsDMUCarCollection();
        //validate the data on the web form
        String Error = CarBook.ThisCar.Valid(txtCarBrand.Text, txtCarModel.Text, txtCarColour.Text, txtCarPrice.Text, txtCarYearProduced.Text);
        //if data is ok then add it to the object
        if (Error == "")
        {
            //find the record to update
            CarBook.ThisCar.Find(CarID);
            //get the data entered by the user
            CarBook.ThisCar.CarBrand = txtCarBrand.Text;
            CarBook.ThisCar.CarModel = txtCarModel.Text;
            CarBook.ThisCar.CarColour = txtCarColour.Text;
            CarBook.ThisCar.CarPrice = Convert.ToInt32(txtCarPrice.Text);
            CarBook.ThisCar.CarYearProduced = Convert.ToDateTime(txtCarYearProduced.Text);
            //update the record
            CarBook.Update();
            //all done so redirect 
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }

    }

    void DisplayCars()
    {
        //create an instance of the car book
        clsDMUCarCollection CarBook = new clsDMUCarCollection();
        //find the record to update
        CarBook.ThisCar.Find(CarID);
        //display the data for this record
        txtCarBrand.Text = CarBook.ThisCar.CarBrand;
        txtCarModel.Text = CarBook.ThisCar.CarModel;
        txtCarColour.Text = CarBook.ThisCar.CarColour;
        txtCarPrice.Text = CarBook.ThisCar.CarPrice.ToString();
        txtCarYearProduced.Text = CarBook.ThisCar.CarYearProduced.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
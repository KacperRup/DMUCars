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
        if (IsPostBack == false)
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
        lstStaff.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaff.DataTextField = "StaffID";
        //set the data field to display
        lstStaff.DataTextField = "MobileNo";
        //bind the data to the list
        lstStaff.DataBind();
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

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else // if no record has been selected
        {
            //display an error
            lblError.Text = "please select a record to delete from the list";
        }
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key of the record to be edited
        Int32 StaffID;
        //if the record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the records to edit
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("Staff.aspx");
        }
        else // if no record has been selected

        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayLastName(txtPhoneNo.Text);
        RecordCount = DisplayLastName("");
        lblError.Text = RecordCount + " records in the database";
        txtPhoneNo.Text = "";
    }

    private int DisplayLastName(string Lastname)
    {
        Int32 RecordCount;

        string Genre;

        // create an instance of the address collection class
        clsStaffCollection Astaff = new clsStaffCollection();

        Int32 Index = 0;
        lstStaff.Items.Clear();// clear the list box
       Astaff.ReportByLastName(Lastname);
        RecordCount = Astaff.Count;

        while (Index < RecordCount)
        {

            Lastname = Astaff.StaffList[Index].LastName;
            Genre = Astaff.StaffList[Index].LastName;

            //create a new entry for the list box
            ListItem NewEntry = new ListItem(Genre);
            lstStaff.Items.Add(NewEntry);
            Index++;
        }
        return RecordCount;
    }



    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayLastName(txtPhoneNo.Text);
        RecordCount = DisplayLastName("");
        lblError.Text = RecordCount + " records in the database";
        txtPhoneNo.Text = "";
    }
}
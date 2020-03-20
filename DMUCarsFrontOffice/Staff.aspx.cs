using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUCarsclasses;

public partial class Staff : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staffid to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //populate the list of staff
            DisplayStaff();
            //if this not a new record 

            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

     void DisplayStaff()
    {
        //create an instnace of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to the update 
        StaffBook.ThisStaff.Find(StaffID);
        //display the data for this record
        txtFirstName.Text = StaffBook.ThisStaff.FirstName;
        txtLastName.Text = StaffBook.ThisStaff.LastName;
        txtDate.Text = StaffBook.ThisStaff.StartDate.ToString();
        txtStaffNo.Text = StaffBook.ThisStaff.MobileNo;
    }

    protected void BtnOK_Click(object sender, EventArgs e)

    {
        if (StaffID == -1)
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

    void Add()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        //validate the data on the web form
        string Error = StaffBook.ThisStaff.Valid(txtFirstName.Text, txtLastName.Text, txtStaffNo.Text, txtDate.Text);
        if (Error == "")
        {
            //get the data entered by the user
            StaffBook.ThisStaff.FirstName = txtFirstName.Text;
            StaffBook.ThisStaff.LastName = txtLastName.Text;
            StaffBook.ThisStaff.MobileNo = txtStaffNo.Text;
            StaffBook.ThisStaff.StartDate = Convert.ToDateTime(txtDate.Text);
            //add the record
            StaffBook.Add();
            //all done to redirect back to main oage
            Response.Redirect("Default.aspx");
            
        }
        else
        {
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
    void Update()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        //validate the data on the web form
        string Error = StaffBook.ThisStaff.Valid(txtFirstName.Text, txtLastName.Text, txtStaffNo.Text, txtDate.Text);
        if (Error == "")
        {   //find the record to update
            StaffBook.ThisStaff.Find(StaffID);
            //get the data entered by the user
            StaffBook.ThisStaff.FirstName = txtFirstName.Text;
            StaffBook.ThisStaff.LastName = txtLastName.Text;
            StaffBook.ThisStaff.MobileNo = txtStaffNo.Text;
            StaffBook.ThisStaff.StartDate = Convert.ToDateTime(txtDate.Text);
            //add the record
            StaffBook.Update();
            Response.Redirect("Default.aspx");


        }
        else
        {
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }



    protected void txtStaffNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtboxStaffID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
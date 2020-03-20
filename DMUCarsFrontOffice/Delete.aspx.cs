using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUCarsclasses;

public partial class Delete : System.Web.UI.Page

{
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staffno to be deleted from the session object
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    void DeleteRecord()
        //function to delete the address book
    {
        //create a new instance
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record
        StaffBook.ThisStaff.Find(StaffNo);
        //delete the record
        StaffBook.Delete();
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteRecord();
        //redirect back to the main page
        Response.Redirect("Default.aspx");

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUCarsclasses;

public partial class Staff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //create a new instance if the clstaff
        clsStaff AStaff = new clsStaff();
        //capture the mobile no
        AStaff.MobileNo = TxtStaffNo.Text;
        //store the address in the session object
        Session["AStaff"] = AStaff;
        //redirect to the view page
        Response.Redirect("DMUCarsViewer.aspx");
    }
}
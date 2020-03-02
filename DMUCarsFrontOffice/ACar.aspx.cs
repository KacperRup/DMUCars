using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUCars_Classes;



public partial class ACar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the clsDMUCars
        clsDMUCars ACar = new clsDMUCars();
        //capture the CarID
        ACar.CarID = txtCarID.Text;
        //store the CarID in the session object
        Session["ACar"] = ACar;
        //redirect to the viewer page
        Response.Redirect("ACarViewer.aspx");
    }
}
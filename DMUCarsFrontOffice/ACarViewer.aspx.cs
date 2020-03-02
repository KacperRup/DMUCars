using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUCars_Classes;

public partial class ACarViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsDMUCars
        clsDMUCars ACar = new clsDMUCars();
        //get the data from the session object
        ACar = (clsDMUCars)Session["ACar"];
        //display the house number for this entry
        Response.Write(ACar.CarID);
    }
}
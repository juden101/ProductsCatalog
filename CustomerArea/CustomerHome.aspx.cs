using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerArea_CustomerHome : System.Web.UI.Page
{
    private DAL db;
    private Shop myShop;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lnkProducts_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowProducts.aspx");
    }

    protected void lnkOrders_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewOrders.aspx");
    }
}
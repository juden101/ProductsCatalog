using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerArea_ViewOrderLines : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int orderId = (int)Session["orderId"];
        DAL db = new DAL();
        GridView1.DataSource = db.getOrderOrderlines(orderId);
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
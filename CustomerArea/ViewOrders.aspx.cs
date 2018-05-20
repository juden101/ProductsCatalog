using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerArea_Default : System.Web.UI.Page
{
    DAL db;
    protected void Page_Load(object sender, EventArgs e)
    {
        Customer cust = (Customer)Session["loggedinCustomer"];
        String username = cust.Username;
        DAL db = new DAL();
       GridView1.DataSource =db.getCustomerOrders(username);
        
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        // view order lines
     
        GridViewRow row = GridView1.SelectedRow;
        int orderId = Convert.ToInt32(row.Cells[1].Text);


        Session["orderId"] = orderId;
        Response.Redirect("ViewOrderLines.aspx");
    }
}
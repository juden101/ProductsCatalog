using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerArea_Basket : System.Web.UI.Page
{
    List<OrderLine> orderLines;
    DAL db;
    Order newOrder;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get basket from session
        OrderLine basket = (OrderLine)Session["BasketItem"];
       newOrder = (Order)Session["CurrentOrder"];
        gridViewOrderLines.DataSource = newOrder.getOrderLines();
        gridViewOrderLines.DataBind();
     }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //buy item

        //insert order into database
        db = new DAL();
         Customer cust = (Customer) Session["loggedinCustomer"];
        String username = cust.Username;
       int orderId = db.insertOrder(newOrder,username);
      
        
       lblbasket.Text = " thank you for your order, OrderId:"+ orderId;

        
        //insert orderlines into database

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowProducts.aspx");
    }

    protected void gridViewOrderLines_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
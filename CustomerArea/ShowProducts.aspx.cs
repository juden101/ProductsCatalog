using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerArea_ShowProducts : System.Web.UI.Page
{
    Order newOrder;
    protected void Page_Load(object sender, EventArgs e)
    {
      
        if (Session["CurrentOrder"] == null)
        {
            newOrder = new Order();

        }
        else
        {
            newOrder = (Order)Session["CurrentOrder"];
        }


    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlQuantity.Items.Clear();
        // choose a quantity
        GridViewRow row = GridView1.SelectedRow;
        int stockL = Convert.ToInt32(row.Cells[4].Text);
        //bind max dropdown for quantity to stocklevel
        for (int i = 1; i <= stockL; i++)
        {
            ddlQuantity.Items.Add(i.ToString());
        }

        ddlQuantity.DataSource = new int[stockL];
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //CREATE NEW ORDERLINE
        //  Product selectedProduct = (Product)GridView1.SelectedRow.DataItem;
        GridViewRow pRow = GridView1.SelectedRow;
        //long way
        int pid = Convert.ToInt32(pRow.Cells[1].Text);
        string pname = Convert.ToString(pRow.Cells[2].Text);
        string pdesc = Convert.ToString(pRow.Cells[3].Text);
        int pstock = Convert.ToInt32(pRow.Cells[4].Text);
        decimal price = Convert.ToDecimal(pRow.Cells[5].Text);

        Product selectedProduct = new Product(pid, pname, pdesc, pstock, price);

        //get quantity
        int quantity = Int32.Parse(ddlQuantity.SelectedValue);

        OrderLine newOL = new OrderLine(selectedProduct, quantity);
        
        newOrder.OrderLines.Add(newOL);
       



        Session["BasketItem"] = newOL;
        Session["CurrentOrder"] = newOrder;
        Response.Redirect("Basket.aspx");
    }
}

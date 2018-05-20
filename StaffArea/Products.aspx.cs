using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffArea_Products : System.Web.UI.Page
{
    private DAL db;
    protected void Page_Load(object sender, EventArgs e)
    {
        //instantiate db
        db = new DAL();
        //populate table with products
        productsGridView.DataSource = db.getAllProducts();
        //productsGridView.DataKeys = "ProductId";
        productsGridView.DataBind();

    }


}
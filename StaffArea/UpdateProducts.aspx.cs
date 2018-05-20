using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffArea_UpdateProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        //Update the values.
        GridViewRow row = GridView1.Rows[e.RowIndex];
       TextBox txtProdId= (TextBox)row.Cells[1].Controls[0];
        int productId = Convert.ToInt32(txtProdId.Text.ToString());
        TextBox txtName = (TextBox)row.Cells[2].Controls[0];
        String name = Convert.ToString(txtName.Text);
        TextBox txtDesc = (TextBox)row.Cells[3].Controls[0];
        String desc = Convert.ToString(txtDesc.Text);
        TextBox txtStock = (TextBox)row.Cells[4].Controls[0];
        int stockLevel = Convert.ToInt32(txtStock.Text);
        TextBox txtPrice = (TextBox)row.Cells[5].Controls[0];

        Decimal price = Convert.ToDecimal(txtPrice.Text);
        //Create a new product
        //create a new DAL
        //call the updateProduct method
        

    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;

       
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
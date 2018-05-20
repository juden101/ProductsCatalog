using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Practice : System.Web.UI.Page
{
    Dictionary<int, Product> dProducts;
    Dictionary<string, Customer> dCustomers;
    Dictionary<int, Order> dOrders;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loadProducts_Click(object sender, EventArgs e)
    {
        //load products
        Product p1 = new Product(1, "cup", "china tea cup", 12, 2.99m);
        Product p2 = new Product(2, "mug", "big coffee mug", 15, 4.99m);

    }

    protected void loadCustomerWithOrders_Click(object sender, EventArgs e)
    {
        Customer c1 = new Customer("jude", "pass", "judith", "nelson","judith@me.com");
        Customer c2 = new Customer("mark", "pass", "mark", "gilchrist", "mark@me.com");

        //Order order1 = new Order(1,"")

    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Shop
/// </summary>
public class Shop
{
    private string shopName;
    private Dictionary<int, Product> allProducts;
    private Dictionary<int, Customer> registeredCustomers;
    private Dictionary<int, Order> allOrders;

    public string ShopName
    {
        get
        {
            return shopName;
        }

        set
        {
            shopName = value;
        }
    }

    public Dictionary<int, Product> AllProducts
    {
        get
        {
            return allProducts;
        }

        set
        {
            allProducts = value;
        }
    }

    public Dictionary<int, Customer> RegisteredCustomers
    {
        get
        {
            return registeredCustomers;
        }

        set
        {
            registeredCustomers = value;
        }
    }

    public Dictionary<int, Order> AllOrders
    {
        get
        {
            return allOrders;
        }

        set
        {
            allOrders = value;
        }
    }

    public Shop()
    {
        //
        // TODO: Add constructor logic here
        //
        allProducts = new Dictionary<int, Product>();
    }

    public Shop(string shopName, Dictionary<int, Product> allProducts, Dictionary<int, Customer> registeredCustomers, Dictionary<int, Order> allOrders)
    {
        this.shopName = shopName;
        this.allProducts = allProducts;
        this.registeredCustomers = registeredCustomers;
        this.allOrders = allOrders;
    }

    public void LoadProducts()
    {
        //create a new db
        DAL db = new DAL();
        DataTable productsTab = db.getAllProducts();

        for (int i = 0; i <= productsTab.Rows.Count - 1; i++)
        {
            
            int pid = Convert.ToInt32(productsTab.Rows[i][0]);
            string pname = Convert.ToString(productsTab.Rows[i][1]);
            string pdesc = Convert.ToString(productsTab.Rows[i][2]);
            int stockLevel = Convert.ToInt32(productsTab.Rows[i][3]);
            decimal price = Convert.ToDecimal(productsTab.Rows[i][4]);

            Product prod = new Product(pid, pname, pdesc, stockLevel, price);
            //add customer to the dictionary
            allProducts.Add(pid, prod);

        }
            
        }
}
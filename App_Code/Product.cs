using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    private int productId;
    private string productName;
    private string productDesc;
    private int stockLevel;
    private decimal price;

    public int ProductId
    {
        get
        {
            return productId;
        }

        set
        {
            productId = value;
        }
    }

    public string ProductName
    {
        get
        {
            return productName;
        }

        set
        {
            productName = value;
        }
    }

    public string ProductDesc
    {
        get
        {
            return productDesc;
        }

        set
        {
            productDesc = value;
        }
    }

    public int StockLevel
    {
        get
        {
            return stockLevel;
        }

        set
        {
            stockLevel = value;
        }
    }

    public decimal Price
    {
        get
        {
            return price;
        }

        set
        {
            price = value;
        }
    }

    public Product()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Product(int productId, string productName, string productDesc, int stockLevel, decimal price)
    {
        this.ProductId = productId;
        this.ProductName = productName;
        this.ProductDesc = productDesc;
        this.StockLevel = stockLevel;
        this.Price = price;
    }

    public override string ToString()
    {
        return productName;
    }
}
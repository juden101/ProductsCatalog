using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderLine
/// </summary>
public class OrderLine
{
    private int orderLineId;
    private Product selectedProduct;
    private int quantity;
    private int orderId;

    public Product SelectedProduct
    {
        get
        {
            return selectedProduct;
        }

        set
        {
            selectedProduct = value;
        }
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }

        set
        {
            quantity = value;
        }
    }

    public int OrderId
    {
        get
        {
            return orderId;
        }

        set
        {
            orderId = value;
        }
    }

    public OrderLine()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public OrderLine(Product selectedProduct, int quantity)
    {
        this.SelectedProduct = selectedProduct;
        this.Quantity = quantity;
    }

    public string ProductName
    {
        get { return selectedProduct.ProductName; }
        set { selectedProduct.ProductName = value; }
    }

    //new method to get orderline total
    public decimal getOrderLineTotal()
    {
        return quantity * selectedProduct.Price;
    }

    public override string ToString()
    {
        return selectedProduct.ToString()+ quantity.ToString();
    }
}
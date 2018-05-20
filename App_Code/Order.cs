using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
    private int orderId;
    private List<OrderLine> orderLines;
    private DateTime orderDate;
    private string username;

    public decimal getOrderTotal()
    {
        decimal tot = 0.0m;
        foreach (OrderLine item in orderLines)
        {
            tot += item.SelectedProduct.Price * item.Quantity;
        }
        return tot;
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

    public List<OrderLine> getOrderLines() {
        return orderLines;
    }

    public List<OrderLine> OrderLines
    {
        get
        {
            return orderLines;
        }

        set
        {
            orderLines = value;
        }
    }

    public DateTime OrderDate
    {
        get
        {
            return orderDate;
        }

        set
        {
            orderDate = value;
        }
    }

    public Order()
    {
        //
        // TODO: Add constructor logic here
        //
        orderLines = new List<OrderLine>();
        this.orderDate = DateTime.Now;
    }

    

    public Order(int orderId, List<OrderLine> orderLines, string user)
    {
        this.orderId = orderId;
        this.orderLines = orderLines;
        this.orderDate = DateTime.Now; ;
    }
}
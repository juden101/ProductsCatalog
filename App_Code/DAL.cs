using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    private string conStr;
    private SqlConnection con;

    private Dictionary<string, Staff> allStaff;
    private Dictionary<string, Customer> customers;

    public Dictionary<string, Staff> AllStaff
    {
        get
        {
            return allStaff;
        }

        set
        {
            allStaff = value;
        }
    }

    public Dictionary<string, Customer> Customers
    {
        get
        {
            return customers;
        }

        set
        {
            customers = value;
        }
    }

    public DAL()
    {
        //
        // TODO: Add constructor logic here
        //

        conStr = ConfigurationManager.ConnectionStrings["UserDBConnectionString1"].ConnectionString;
        con = new SqlConnection(conStr);

        AllStaff = new Dictionary<string, Staff>();
        Customers = new Dictionary<string, Customer>();
    }

    public DataTable getAllUserData() {

        
        string myQuery = "SELECT * FROM Users";
        var myCommand = new SqlCommand(myQuery, con);
        SqlDataReader myResults;
        DataTable myDataTable = new DataTable();

       
        try
        {
            con.Open();
            myResults = myCommand.ExecuteReader();

            if (myResults.HasRows == true)
            {
                myDataTable.Load(myResults);
            }

            return myDataTable;
        }

   
        catch (Exception e)
        {
            return myDataTable;
        }

       
        finally
        {
            con.Close();
            myCommand.Dispose();
        }

    }

    public void loadUserdata() {
        DataTable UsersTable;

        UsersTable = this.getAllUserData();

        for (int i = 0; i <= UsersTable.Rows.Count - 1; i++)
        {
            string username = Convert.ToString(UsersTable.Rows[i][1]);
            string password = Convert.ToString(UsersTable.Rows[i][2]);
            string firstname = Convert.ToString(UsersTable.Rows[i][3]);
            string lastname = Convert.ToString(UsersTable.Rows[i][4]);
            string email = Convert.ToString(UsersTable.Rows[i][5]);
            string role = Convert.ToString(UsersTable.Rows[i][6]);
           
                 if (role.Equals("C"))
            {
                //create a new Customer 
                Customer cust = new Customer(username, password, firstname, lastname, email);

                //add customer to the dictionary
                Customers.Add(username, cust);
            }

                  else if (role == "S")
            {
                //create a new Staff
                Staff staff = new Staff(username, password, firstname, lastname, email);

                //add to staff dictionary
                allStaff.Add(username, staff);

            }
        }
    }

    public DataTable getAllProducts()
    {


        string myQuery = "SELECT * FROM Products";
        var myCommand = new SqlCommand(myQuery, con);
        SqlDataReader myResults;
        DataTable myDataTable = new DataTable();


        try
        {
            con.Open();
            myResults = myCommand.ExecuteReader();

            if (myResults.HasRows == true)
            {
                myDataTable.Load(myResults);
            }

            return myDataTable;
        }


        catch (Exception e)
        {
            return myDataTable;
        }


        finally
        {
            con.Close();
            myCommand.Dispose();
        }

    }

    public DataTable getAllOrders()
    {


        string myQuery = "SELECT * FROM Orders";
        var myCommand = new SqlCommand(myQuery, con);
        SqlDataReader myResults;
        DataTable myDataTable = new DataTable();


        try
        {
            con.Open();
            myResults = myCommand.ExecuteReader();

            if (myResults.HasRows == true)
            {
                myDataTable.Load(myResults);
            }

            return myDataTable;
        }


        catch (Exception e)
        {
            return myDataTable;
        }


        finally
        {
            con.Close();
            myCommand.Dispose();
        }

    }

    public DataTable getCustomerOrders(String customer)
    {


        string myQuery = "SELECT * FROM Orders where customerid=@customerid ";
        var myCommand = new SqlCommand(myQuery, con);
        myCommand.Parameters.AddWithValue("@customerid", customer);
        SqlDataReader myResults;
        DataTable myDataTable = new DataTable();


        try
        {
            con.Open();
            myResults = myCommand.ExecuteReader();

            if (myResults.HasRows == true)
            {
                myDataTable.Load(myResults);
            }

            return myDataTable;
        }


        catch (Exception e)
        {
            return myDataTable;
        }


        finally
        {
            con.Close();
            myCommand.Dispose();
        }

    }

    public DataTable getOrderOrderlines(int orderid)
    {


        string myQuery = "SELECT * FROM Orderlines where orderid=@orderid ";
        var myCommand = new SqlCommand(myQuery, con);
        myCommand.Parameters.AddWithValue("@orderid", orderid);
        SqlDataReader myResults;
        DataTable myDataTable = new DataTable();


        try
        {
            con.Open();
            myResults = myCommand.ExecuteReader();

            if (myResults.HasRows == true)
            {
                myDataTable.Load(myResults);
            }

            return myDataTable;
        }


        catch (Exception e)
        {
            return myDataTable;
        }


        finally
        {
            con.Close();
            myCommand.Dispose();
        }

    }



    public string retrieveStaffRole(string username)
    {
        string sql = "select * from StaffRoles where username=@username";
        string role = "";
        try
        {
            con.Open();
            SqlCommand com = new SqlCommand(sql,con);

           
            com.Parameters.AddWithValue("@username", username);
        
            SqlDataReader rdr = com.ExecuteReader();
            if (rdr.Read())
            {
                role = rdr["role"].ToString();
            }
        }
        catch (Exception e)
        {
            String error = e.Message;
           
        } finally
        {
            con.Close();
           
        }

        return "";

    }

    public Customer checkCustomerLogin (string username, string password)
    {
        if (customers.ContainsKey(username))
        {
            Customer cust = customers[username];
            if (cust.Password.Equals(password))
            {
                return cust;
            }
           
        }
        return null;
    }

    public Staff checkStaffLogin(string username, string password)
    {
        if (allStaff.ContainsKey(username))
        {
            Staff staff = allStaff[username];
            if (staff.Password.Equals(password))
            {
                return staff;
            }

        }
        return null;
    }
    //write methods to get & set customers

    //write methods to get & set staff

    public Boolean updateProduct(Product product) {

        Boolean successfulUpdate = false;
        //create code to update product
        return successfulUpdate;
    }

    public int insertOrder(Order order, String username)
    {

        con.Open();
        String sql = " INSERT into ORDERS output INSERTED.OrderId VALUES ( @orderdate , @ordertotal, @customerid);";
        SqlCommand com1 = new SqlCommand(sql,con);
        com1.Parameters.AddWithValue("@orderdate", order.OrderDate);
        com1.Parameters.AddWithValue("@ordertotal", order.getOrderTotal());
        com1.Parameters.AddWithValue("@customerid", username);

        //int rows = com1.ExecuteNonQuery();
        int insertedID = Convert.ToInt32(com1.ExecuteScalar());
        foreach (OrderLine item in order.OrderLines)
        {
            insertOrderLine(item, insertedID);
        }
        con.Close();
        
            return insertedID;

        
    }

    public void insertOrderLine(OrderLine orderline, int orderId)
    {
        String sql = " INSERT into ORDERLINES VALUES ( @productid , @orderid, @quantity)";
        SqlCommand com1 = new SqlCommand(sql, con);
        com1.Parameters.AddWithValue("@productid", orderline.SelectedProduct.ProductId);
        com1.Parameters.AddWithValue("@orderid", orderId);
        com1.Parameters.AddWithValue("@quantity", orderline.Quantity);
        com1.ExecuteNonQuery();
    }
}
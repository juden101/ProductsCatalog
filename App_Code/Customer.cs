using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
[Serializable]
public class Customer : User
{
    private string membershipType;
    private Dictionary<int, Order> customerOrders;

    public Customer():base()
    {
        //
        // TODO: Add constructor logic here
        //
        membershipType = "standard";
    }

    public Customer(string username, string password, string firstname, string lastname, string email) : base(username,password,firstname,lastname,email) {

        this.Username = username;
        this.Password = password;
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.Email = email;

        membershipType = "standard";




    }


}
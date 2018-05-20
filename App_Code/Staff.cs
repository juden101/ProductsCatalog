using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Staff
/// </summary>
public class Staff:User
{
    private string role;
    public Staff() : base()
    {
        //
        // TODO: Add constructor logic here
        //
        role = "";
    }

    public Staff(string username, string password, string firstname, string lastname, string email) : base(username,password,firstname,lastname,email) {

        role = "";
    }
}
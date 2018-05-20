using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
[Serializable]
public class User
{
    private string username;
    private string password;
    private string firstname;
    private string lastname;
    private string email;

    public string Username
    {
        get
        {
            return username;
        }

        set
        {
            username = value;
        }
    }

    public string Password
    {
        get
        {
            return password;
        }

        set
        {
            password = value;
        }
    }

    public string Firstname
    {
        get
        {
            return firstname;
        }

        set
        {
            firstname = value;
        }
    }

    public string Lastname
    {
        get
        {
            return lastname;
        }

        set
        {
            lastname = value;
        }
    }

    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            email = value;
        }
    }

    public User()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public User(string username, string password, string firstname, string lastname, string email)
    {
        this.Username = username;
        this.Password = password;
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.Email = email;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Login1.FailureText = "";
    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        DAL db = new DAL();
        db.loadUserdata();

        if (rdoUser.SelectedIndex != -1)
        {
            if (rdoUser.SelectedValue.Equals("Customer"))
            {
                Customer loggedinCustomer = db.checkCustomerLogin(Login1.UserName, Login1.Password);
                if (loggedinCustomer != null)
                {
                    //start session
                    Shop myShop = new Shop();
                    Session["myShop"] = myShop;
                    Session["loggedinCustomer"] = loggedinCustomer;
                    //redirect to customer home
                    Response.Redirect("~/CustomerArea/CustomerHome.aspx");
                    Login1.FailureText = "";

                    


                }
                else
                {
                    Login1.FailureText = "incorrect customer details";
                }
            } else if (rdoUser.SelectedValue.Equals("Staff")) { }
            {
                Staff loggedinStaff = db.checkStaffLogin(Login1.UserName, Login1.Password);
                if (loggedinStaff != null)
                {
                    //start session
                    Session["loggedinStaff"] = loggedinStaff;
                    //redirect to customer home
                    Response.Redirect("~/StaffArea/StaffHome.aspx");
                   Login1.FailureText = "";
                
                        }
                else
                {
                    Login1.FailureText = "incorrect staff details";
                }
            }
        }else
        {
            lblError.Text = "you must select a user type";
        }

       


    }
}
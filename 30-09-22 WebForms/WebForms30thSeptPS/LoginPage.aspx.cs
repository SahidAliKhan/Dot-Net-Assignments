using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms30thSeptPS
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Response.Write("Hi! This is a Login Page.");
            }
            else
            {
                if(txtuserid.Text == "Sahid" && txtpassword.Text=="Sahid@123")
                {
                    lblcheck.Text = "Logged in Successfully..";
                }
                else
                {
                    lblcheck2.Text = "Invalid ID or Password...";
                }
            }
        }

        protected void btncustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CustomerSignUp.aspx");
        }
    }
}
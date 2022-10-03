using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms30thSeptPS
{
    public partial class CustomerSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                CustomerBAL c = new CustomerBAL();
                c.FirstName = txtfname.Text;
                c.LastName = txtfname.Text;
                c.DOB = Convert.ToDateTime(dateDOB.Text);
                c.State = txtstate.Text;
                c.City = txtcity.Text;

                HttpCookie cookie = new HttpCookie("CustomerData");
                cookie.Expires = DateTime.Now.AddMinutes(10);
                cookie.Values.Add("FirstName", c.FirstName);
                cookie.Values.Add("LastName", c.LastName);
                cookie.Values.Add("DateOfBirth", c.DOB.ToLongDateString());
                cookie.Values.Add("State", c.State);
                cookie.Values.Add("City", c.City);

                Response.Cookies.Add(cookie);
                lbl1.Text = "Thanks for the input..";

                Response.Redirect("~/WelcomePage.aspx");
            }
            else
            {
                Response.Write("Hi! This is a Customer SignUp Page..");
            }

        }
    }
}
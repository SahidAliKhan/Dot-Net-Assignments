using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms30thSeptPS
{
    public partial class WelcomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie;
            cookie = Request.Cookies.Get("CustomerData");
            CustomerBAL c = new CustomerBAL();
            c.FirstName = cookie["FirstName"].ToString();
            c.LastName = cookie["LastName"].ToString();

            lblwlcome.Text = "Welcome " + c.FirstName + "." + " This is a Welcome Page..";
        }
    }
}
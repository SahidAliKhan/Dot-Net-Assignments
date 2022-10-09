using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms4thOctCachingDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Session["uname"] = txtuname.Text;
            //Session["pwd"] = txtpwd.Text;
            //Response.Redirect("~/sessionRedirect.aspx");

            UserLogin login = new UserLogin();
            login.username = txtuname.Text;
            login.password = txtpwd.Text;

            Cache.Add("userdata", login, null, DateTime.Now.AddSeconds(20), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
            //Cache["pwd"] = txtpwd.Text;



            Response.Redirect("~/sessionRedirect.aspx");
        }
    }
}
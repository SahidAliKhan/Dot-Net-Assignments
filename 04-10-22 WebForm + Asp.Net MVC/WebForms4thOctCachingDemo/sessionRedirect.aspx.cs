using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms4thOctCachingDemo
{
    public partial class sessionRedirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Cache["uname"]!=null && Cache["pwd"]!=null)
            //{
            //    Response.Write(Cache["uname"].ToString());
            //    Response.Write(Cache["pwd"].ToString());
            //}

            if (Cache["userdata"] != null)
            {
                Response.Write(Cache["userdata"].ToString());
                UserLogin logindata = (UserLogin)Cache["userdata"];

                Response.Write(logindata.username);
                Response.Write(logindata.password);

            }
            else
            {
                Response.Write("Cache is null");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms4thOctCachingDemo
{
    public partial class DataRetriever : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int dno = Convert.ToInt32(Request.QueryString["deptno"]);
            Response.Write(dno);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms4thOctCachingDemo
{
    public partial class CachingDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Cache["dt"] = DateTime.Now.ToLongTimeString();

                // Cache["username"] = "Aniket";
                // Cache.Insert("username", "Aniket");
                Cache.Add("username", "Aniket", null, DateTime.Now.AddSeconds(10), Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Label1.Text = DateTime.Now.ToLongTimeString();
                Label1.Text = Cache["dt"].ToString();
                Label2.Text = Cache.Get("username").ToString();
                //Label2.Text = Cache["username"].ToString();
            }
            catch (NullReferenceException ex)
            {

                Label2.Text = "Could'nt retrieve from the cache... cache expired";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms30thSeptPS
{
    public partial class AcceptProductID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngetprods_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindCNString"].ConnectionString);
            int i = Convert.ToInt32(txtprodid.Text);
            SqlCommand cmd = new SqlCommand($"Select * from Products where ProductID={i}", conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                txtprodname.Text = dr[1].ToString();
                txtprice.Text = dr[5].ToString();
                txtcategoryid.Text = dr[3].ToString();
                txtsupplierid.Text = dr[2].ToString();
            }
            conn.Close();
        }
    }
}
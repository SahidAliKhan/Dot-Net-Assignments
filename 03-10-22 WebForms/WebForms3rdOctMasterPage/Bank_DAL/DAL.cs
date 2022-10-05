using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Bank_BAL; 

namespace Bank_DAL
{
    public class BankProds
    {
        public List<Products> CalculatingInterest()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankDBCnString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[ProductList]()", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Products> plist = new List<Products>();

            while (dr.Read())
            {
                plist.Add(new Products { Prodid = Convert.ToInt32(dr[0]), Prodname = dr["productname"].ToString(), InterestRates = Convert.ToSingle(dr[2]) });

            }
            cn.Close();
            cn.Dispose();
            return plist;

        }




        public List<string> ProductNames()
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankDBCnString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[ProductList]()", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> plist = new List<string>();

            while (dr.Read())
            {
                plist.Add(dr["productname"].ToString());

            }
            cn.Close();
            cn.Dispose();
            return plist;

        }


        public List<Products> GetProducts()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["BankDBCnString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[ProductList]()", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Products> plist = new List<Products>();

            while (dr.Read())
            {
                plist.Add(new Products { Prodid = Convert.ToInt32(dr[0]), Prodname = dr["productname"].ToString(), InterestRates = Convert.ToSingle(dr[2]) });

            }
            cn.Close();
            cn.Dispose();
            return plist;

        }

    }
}

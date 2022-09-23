using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDay1PS
{
    class PS2
    {
        static void Main(string[] args)
        {
//            2)Create a view on the products table to select only productid, productname and unitprice.
//            Using the view access the data in the console app and print it.
//Use validations appropriately.

            string Connection = "Data Source=SAHID\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection conn = new SqlConnection(Connection);
            SqlCommand cmd = new SqlCommand("select * from ViewProducts", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Product ID: " + dr[0]);
                Console.WriteLine("Product Name: " + dr[1]);
                Console.WriteLine("Price: " + dr[2]);
                Console.WriteLine("----------------------");
            }
            conn.Close();
            Console.ReadLine();
        }
    }
}

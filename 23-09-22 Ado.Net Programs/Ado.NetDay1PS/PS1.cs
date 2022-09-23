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
     class PS1
    {
        static void Main(string[] args)
        {
//            1) Using Products table, access the data in the console app and print it. Use validations appropriately.

            string Connection = "Data Source=SAHID\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection conn = new SqlConnection(Connection);
            SqlCommand cmd = new SqlCommand("Select * from products", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("Product ID: " +dr["ProductID"]);
                Console.WriteLine("Product Name: " +dr["ProductName"]);
                Console.WriteLine("Supplier ID: " +dr[2]);
                Console.WriteLine("Quantity: " +dr[4]);
                Console.WriteLine("Price: " +dr[5]);
                Console.WriteLine("Stock Available:" +dr[6]);
                Console.WriteLine("----------------------");
            }
            conn.Close();
            Console.ReadLine();
        }
    }
}

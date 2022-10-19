using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CustomerOrderService
{
    public enum CustomerType
    {
        Basic, Premium, Gold
    }
    public class Customer
    {
        public int CustID { get; set; }
        public string CustName { get; set; }
        public CustomerType CustomerType { get; set; }
        public List<Customer> Customers { get; set; }
        public string Custid { get; set; }
    }
    
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
    }

    public class CustomerOrder
    {
        public void Discount(Customer c, Order o)
        {
            if (c.CustomerType == CustomerType.Premium)
            {
                o.Amount = o.Amount - ((o.Amount * 10)/100);
            }
            else if(c.CustomerType == CustomerType.Gold)
            {
                o.Amount = o.Amount - ((o.Amount * 20) / 100);
            }
        }
        public void GetCustomers(Customer c1)
        {
            SqlConnection sql = new SqlConnection("Data Source=SAHID\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Customers", sql);
            sql.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Customer> custList = new List<Customer>();
            // Customer c = new Customer();
            while (dr.Read())
            {
                Customer cust = new Customer();
                cust.CustName = dr["ContactName"].ToString();
                cust.Custid = dr[0].ToString();

                // cust.CustID = dr[0].ToString();
                custList.Add(cust);

            }
            sql.Close();
            c1.Customers = custList;
        }
    }
}

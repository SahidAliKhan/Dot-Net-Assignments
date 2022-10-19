using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrderService;

namespace CustomerOrderService.Tests
{
    //[TestFixture]
    [TestFixture(CustomerType.Basic, 100)]
    public class CustomerTest
    {
        CustomerType ctype;
        Order o = new Order();
        public CustomerTest(CustomerType ctype)
        {
            this.ctype = ctype; 
        }
        public CustomerTest(CustomerType ctype, int amt):this(ctype)
        {
            //this.ctype = ctype;
            o.Amount = amt;
        }
        [TestCase]
        public void TestMethod()
        {
            Assert.IsTrue(ctype == CustomerType.Basic);
        }
        [TestCase]
        public void TestMethod2()
        {
            Assert.IsTrue(ctype == CustomerType.Basic && o.Amount == 100);
        }

        [Test]
        public void test1()
        {
            Assert.That(1 == 1);
        }

        [TestCase]
        public void When_Premium_10Percent()
        {
            Customer c = new Customer();
            c.CustID = 101;
            c.CustName = "Ramy";
            c.CustomerType = CustomerType.Premium;

            Order o = new Order();
            o.OrderID = 23;
            o.ProductID = 4;
            o.Quantity = 10;
            o.Amount = 1000;

            CustomerOrder co = new CustomerOrder();
            co.Discount(c,o);

            Assert.AreEqual(o.Amount,900);
        }
        [TestCase]
        public void When_Gold_20Percent()
        {
            Customer c = new Customer();
            c.CustID = 101;
            c.CustName = "Ramy";
            c.CustomerType = CustomerType.Gold;

            Order o = new Order();
            o.OrderID = 23;
            o.ProductID = 4;
            o.Quantity = 10;
            o.Amount = 1000;

            CustomerOrder co = new CustomerOrder();
            co.Discount(c, o);

            Assert.AreEqual(o.Amount, 800);
        }

        [TestCase]
        public void FetchList()
        {
            CustomerOrder customerOrder = new CustomerOrder();
            Customer c1 = new Customer();

            customerOrder.GetCustomers(c1);
            List<Customer> custList1 = new List<Customer>();
            custList1.Add(new Customer() { Custid = "sk", CustName = "sk" });
            custList1.Add(new Customer() { Custid = "ab", CustName = "ab" });
            Assert.AreEqual(custList1, c1.Customers);
        }


    }
}

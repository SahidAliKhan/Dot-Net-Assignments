using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Products p = new Products();

            // ElectronicProducts p2 = new ElectronicProducts();//base of ElectronicsProductClass ie. Default constructor of Product
            ElectronicProducts ep = new ElectronicProducts(1, "Battery", 4000.00f);

            ElectronicProducts p1 = new ElectronicProducts(1);
            //base of Electronics ie Products Parameterised
            p1.AcceptData();
            p1.AcceptData();

            List<Products> plist = new List<Products>();
            plist = p1.ProductList();

            foreach (var item in plist)
            {
                Console.WriteLine(item.ProductID);
                Console.WriteLine(item.ProductName);
            }


            Console.WriteLine("---------------");

            Customer c = new Customer();
            c.InsertData(5, 101, "Pune");
            CustomerOperations operations = new CustomerOperations();
            operations.InsertData(5, 101, "Pune");
            operations.InsertData(19, "Ahsish", "Mumbai");
            SpecialCustomer special = new SpecialCustomer();
            special.InsertData(5, 101, "Pune");

            //ElectronicProducts p2 = (ElectronicProducts) new Products();

            Console.ReadKey();


        }
    }
}

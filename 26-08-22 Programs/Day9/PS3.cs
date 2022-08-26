using HRLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Day9
{
    internal class PS3
    {
        static void Main(string[] args)
        {
            List<Products> product = new List<Products>();
            product.Add( new Products {Pid= 1, Pname= "Toy", Price = 100} );
            product.Add(new Products { Pid = 2, Pname = "Mobile", Price = 21100 });
            product.Add(new Products { Pid = 3, Pname = "Bottle", Price = 20 });
            Console.WriteLine("All Product Details: ");
            foreach (var item in product)
            {
                Console.WriteLine("Product ID: " +item.Pid);
                Console.WriteLine("Product Name: " +item.Pname);
                Console.WriteLine("Product Price: " +item.Price);
            }
            Console.WriteLine("-------------------");
           
            Console.WriteLine("After Removing Product Mobile: ");
            product.Remove(new Products { Pid = 2, Pname = "Mobile", Price = 21100 });
            foreach (var item2 in product)
            {
                Console.WriteLine("Product ID: " + item2.Pid);
                Console.WriteLine("Product Name: " + item2.Pname);
                Console.WriteLine("Product Price: " + item2.Price);
            }

            Console.ReadLine();
        }
    }
}

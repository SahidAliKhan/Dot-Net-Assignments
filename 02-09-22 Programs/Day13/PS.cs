using HRLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class PS
    {
        static void Main(string[] args)
        {
            Category c = new Category();
            c.CatID = 121;
            c.CatName = "Mobile";
            c.Description = "Electronic Items";
            
            Console.WriteLine("Category ID: " + c.CatID);
            Console.WriteLine("Category Name: " + c.CatName);
            Console.WriteLine("Category Description: " + c.Description);
            Console.WriteLine("------------------------------");

            Products p1 = new Products();
            p1.ProductID = 1;
            p1.ProductName = "Samsung";
            p1.QTYSold = 200;
            p1.UnitPrice = 50000;
            p1.UnitOFMeasurement = "6.9 inch";
            p1.QtyInHand = 150;
            p1.ReorderLevel = 10;

            Products p2 = new Products();
            p2.ProductID = 2;
            p2.ProductName = "Apple";
            p2.QTYSold = 90;
            p2.UnitPrice = 109000;
            p2.UnitOFMeasurement = "6.3 inch";
            p2.QtyInHand = 110;
            p2.ReorderLevel = 7;

            Products p3 = new Products();
            p3.ProductID = 3;
            p3.ProductName = "OnePlus";
            p3.QTYSold = 360;
            p3.UnitPrice = 35000;
            p3.UnitOFMeasurement = "6.7 inch";
            p3.QtyInHand = 230;
            p3.ReorderLevel = 30;

            List<Products> prodlist = new List<Products>();
            prodlist.Add(p1);
            prodlist.Add(p2);
            prodlist.Add(p3);
            c.ProductsList = prodlist;

            foreach (var i in c.ProductsList)
            {
                Console.WriteLine("Product ID: " + i.ProductID);
                Console.WriteLine("Product Name: " + i.ProductName);
                Console.WriteLine("QTY to Sold: " + i.QTYSold);
                Console.WriteLine("Unit Price: " + i.UnitPrice);
                Console.WriteLine("Unit of Measurement: " + i.UnitOFMeasurement);
                Console.WriteLine("Qty in Hand: " + i.QtyInHand);
                Console.WriteLine("Reorder Level: " + i.ReorderLevel);
                Console.WriteLine("---------------");
                Category c1 = new Category();
                c1.CountProduct();
            }

            Console.WriteLine("-----DisplayDetails()-----");
            c.DisplayDetails();

            Console.ReadLine();
        }
    }
}

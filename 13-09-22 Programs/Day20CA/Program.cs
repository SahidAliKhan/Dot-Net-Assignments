using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day20GAClib;

namespace Day20CA
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Products products = new Products();
            products.CalculatePrice();
            products.OfferPrice();
            Console.ReadLine();
        }
    }
}

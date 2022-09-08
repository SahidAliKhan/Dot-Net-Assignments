using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter Two Numbers: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if Both are Positive or Not:");
            Console.WriteLine(x > 0 && y > 0);
            Console.WriteLine("-------------------");

         
            string name= string.Empty; ;
            Console.WriteLine("Enter a String or Press Enter Only to Check Empty:");
            name = Console.ReadLine();
            bool ans = string.IsNullOrEmpty(name);
            Console.WriteLine(ans);
            Console.WriteLine("-------------------");


            float m,km;
            Console.WriteLine("Enter Metre: ");
            m = Convert.ToInt32(Console.ReadLine());
            km = m / 1000;
            Console.WriteLine("Kilometer is: " + km);
            Console.WriteLine("-------------------");


            int c, f;
            Console.WriteLine("Enter Celsius: ");
            c = Convert.ToInt32(Console.ReadLine());
            f = c * (9 / 5) + 32;
            Console.WriteLine("In Fahrenheit: " + f);
            Console.WriteLine("-------------------");


            float usd, inr;
            Console.WriteLine("Enter USD: ");
            usd = Convert.ToInt32(Console.ReadLine());
            inr = usd * 79.64f;
            Console.WriteLine("INR is: "+inr);
            Console.WriteLine("-------------------");
            Console.ReadLine();
        }
    }
}


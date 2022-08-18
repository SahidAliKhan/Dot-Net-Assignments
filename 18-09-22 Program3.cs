using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rectangle of {0}:", a);
            Console.WriteLine("{0}{1}{2}", a, a, a);
            Console.WriteLine("{0} {1}", a, a);
            Console.WriteLine("{0} {1}", a, a);
            Console.WriteLine("{0} {1}", a, a);
            Console.WriteLine("{0}{1}{2}", a, a, a);
            Console.WriteLine("-------------------");

            int c,f;
            Console.WriteLine("Enter Celsius: ");
            c = Convert.ToInt32(Console.ReadLine());
            f = c * (9 / 5) + 32;
            Console.WriteLine("In Fahrenheit: "+f);
            Console.WriteLine("-------------------");

            int x, y;
            Console.WriteLine("Enter Two Numbers: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if One is Negative and One is Positive:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            Console.WriteLine("-------------------");


            Console.ReadLine();

        }
    }
}

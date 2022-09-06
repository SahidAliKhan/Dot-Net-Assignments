using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter i: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter j:");
            j = Convert.ToInt32(Console.ReadLine());
            SwapByValue(i, j);
            SwapByRef(ref i, ref j);
            Console.WriteLine("----------------------");

            int a,b,c;
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            c = Convert.ToInt32(Console.ReadLine());
            int d = a * b * c;
            Console.WriteLine("Multiplication of a,b,c is: "+d);
            Console.WriteLine("----------------------");
            int e, f;
            Console.WriteLine("Enter e: ");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter f: ");
            f = Convert.ToInt32(Console.ReadLine());
            int c1 = e + f;
            Console.WriteLine("Addition of e,f is: " + c1);
            int c2 = e - f;
            Console.WriteLine("Subtraction of e,f is: " + c2);
            int c3 = e * f;
            Console.WriteLine("Multiplication of e,f is: " + c3);
            int c4 = e / f;
            Console.WriteLine("Division of e,f is: " + c4);
            Console.WriteLine("----------------------");
            int e1, f1,g1,h1;
            Console.WriteLine("Enter e1: ");
            e1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter f1: ");
            f1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter g1: ");
            g1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter h1: ");
            h1 = Convert.ToInt32(Console.ReadLine());
            int avg = (e1 + f1 + g1 + h1) / 4;
            Console.WriteLine("Average of Four nos: "+avg);
            Console.WriteLine("----------------------");

            int x, y, z;
            Console.WriteLine("Enter x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter z: ");
            z = Convert.ToInt32(Console.ReadLine());
            int q, w;
            q = (x + y) * z;
            w = x * y + y * z;
            Console.WriteLine("(x + y) * z: "+q);
            Console.WriteLine("x * y + y * z: "+w);
            Console.WriteLine("----------------------");

            int age;
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            if(age>20)
            {
                Console.WriteLine("You are older than 20");
            }
            else
            {
                Console.WriteLine("You are elder than 20");
            }
            Console.WriteLine("----------------------");

            int z1;
            Console.WriteLine("Enter a Number");
            z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} {2} {3}",z1,z1,z1,z1);
            Console.WriteLine("{0}{1}{2}{3}",z1,z1,z1,z1);
            Console.WriteLine("{0} {1} {2} {3}",z1,z1,z1,z1);
            Console.WriteLine("{0}{1}{2}{3}",z1,z1,z1,z1);
            Console.WriteLine("----------------------");



            Console.ReadLine(); 
        }
        static void SwapByValue(int i, int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("SwapByValue of i = "+i);
            Console.WriteLine("SwapByValue of j = " + j);
        }
        static void SwapByRef(ref int i, ref int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("SwapByRef of i = " + i);
            Console.WriteLine("SwapByRef of j = " + j);
        }
    }
}


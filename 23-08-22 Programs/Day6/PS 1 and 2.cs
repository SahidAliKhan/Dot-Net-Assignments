using System;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter value of i:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of j:");
            j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Return type as void:");
            add(i, j);
            Console.WriteLine("------------------------");

            Console.WriteLine("Return type as int:");
            int c;
            c = Sum(i, j);
            Console.WriteLine("Sum: " +c);
            Console.WriteLine("------------------------");


            Console.ReadLine();
        }
        static void add(int a, int b)
        {
            int i = a + b;
            Console.WriteLine("Sum: " + i);
        }
        static int Sum( int a, int b)
        {
            return a + b;
        }
    }
}

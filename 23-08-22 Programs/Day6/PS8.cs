using System;

namespace Day6
{
    internal class PS8
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter 1st Number:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number:");
            j = Convert.ToInt32(Console.ReadLine());
            try
            { 
                int k = i / j;
                Console.WriteLine("Division: " + k);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            add(i, j);
            Console.ReadLine();
        }
        public static void add(int a, int b)
        {
            int i;
            try
            {
                i = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }
    
    }
}


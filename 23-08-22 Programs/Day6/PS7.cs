using System;

namespace Day6
{
    internal class PS7
    {
        static void Main(string[] args)
        {
            int i, j;
            try
            {
                Console.WriteLine("Enter 1st Number:");
                i =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number:");
                j = Convert.ToInt32(Console.ReadLine());
                int k = i / j;
                Console.WriteLine("Division: " + k);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}

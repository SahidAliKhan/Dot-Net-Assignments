using System;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 20, k = i + j;
            Console.WriteLine(k);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter i:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter j:");
            j = Convert.ToInt32(Console.ReadLine());
            k = i * j;
            int l = i / j;
            Console.WriteLine("Multiplication of {0} and {1}: {2} ", i, j, k);
            Console.WriteLine("Division of {0} and {1}: {2} ", i, j, l);
            Console.WriteLine("-----------------------------");
            int a = 0, b = 0, c = 0, userchoice;
            char ch = '+';
            Console.WriteLine("Menu: \n 1.ADD \n 2.SUB \n 3.Exit");
            userchoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter two numbers:");
            if (userchoice != 3)
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            switch (userchoice)
            {

                case 1:
                    ch = '+';
                    c = a + b;
                    break;
                case 2:
                    ch = '-';
                    c = a - b;
                    break;
                case 3:
                    Environment.Exit(1);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
            Console.WriteLine("The Answer of {0} {1} {2} = {3}", a, ch, b, c);
            Console.ReadLine();
        }
    }
}

using System;

namespace Day4b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter an Integer:");
            a = Convert.ToInt32(Console.ReadLine());
            if(a == 0)
                Console.WriteLine("{0} is zero.",a);
            else if (a % 2 != 0 && a < 100)
                Console.WriteLine("{0} is odd.", a);
            else if (a % 2 == 0 && a < 100)
                Console.WriteLine("{0} is even.", a);
            else if (a % 10 == 0 && a < 100)
                Console.WriteLine("{0} is Multiple of 10.", a);
            else if (a > 100)
                Console.WriteLine("{0} is too large.", a);
            Console.WriteLine("--------------------");

            int b;
            Console.WriteLine("Enter an Integer:");
            b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 0:
                    Console.WriteLine("{0} is zero.", b);
                    break;
                case int n when n % 2 != 0 && b < 100:
                    Console.WriteLine("{0} is odd.", b);
                    break;
                case int n when n % 2 == 0 && b < 100:
                    Console.WriteLine("{0} is even.", b);
                    break;
                case int n when n % 10 == 0 && b < 100:
                    Console.WriteLine("{0} is multiple of 10.", b);
                    break;
                case int n when n > 100:
                    Console.WriteLine("{0} is too large.", b);
                    break;
                default:
                    break;
            }
            Console.WriteLine("--------------------");

            int i = 0, j = 25;
            for(i=0,j=25; i<25 && j>=0 ;i++,j--)
            {
                if(i>j)
                {
                    Console.WriteLine("Crossed Over!");
                    break;
                }
                Console.WriteLine("{0} {1}",i,j);
            }
            Console.WriteLine("--------------------");

            string c;
            int s = 100;
            Console.WriteLine("Enter 'HIT' or 'MISS':");
            for (int q = 0; q < 4; q++)
            {
                c = Console.ReadLine();
                if (c == "HIT" || c == "hit")
                {
                    s += 10;  
                }
                else if (c == "MISS" || c == "miss")
                {
                    s -= 20;   
                }
            }
            Console.WriteLine("Score: " + s);
            Console.WriteLine("--------------------");
            Console.ReadLine();
        }
    }
}


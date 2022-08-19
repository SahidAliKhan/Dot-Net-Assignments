using System;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            if(a>b)
                Console.WriteLine("{0} is Maximum and {1} is Minimum.",a,b);
            else
                Console.WriteLine("{0} is Maximum and {1} is Minimum.",b,a);
            Console.WriteLine("----------------------");

            int c, d, e;
            Console.WriteLine("Enter three numbers:");
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            if (c != 0 || d != 0 || e != 0)
            {
                if (c > d && c > e)
                {
                    Console.WriteLine("{0} is largest", c);
                }
                else if (d > c && d > e)
                {
                    Console.WriteLine("{0} is largest", d);
                }
                else
                {
                    Console.WriteLine("{0} is largest", e);
                }
            }
            Console.WriteLine("----------------------");

            char n1, n2;
            Console.WriteLine("Enter Two char:");
            n1 = Convert.ToChar(Console.ReadLine());
            n2 = Convert.ToChar(Console.ReadLine());
            if(n1 == n2)
                Console.WriteLine("Both are Equal");
            else
                Console.WriteLine("Both are Not Equal");
            Console.WriteLine("----------------------");

            String s1, s2;
            Console.WriteLine("Enter two String:");
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            if (s1 == s2)
                Console.WriteLine("Both are Equal");
            else
                Console.WriteLine("Both are Not Equal");
            Console.WriteLine("----------------------");

            int a1, b1;
            Console.WriteLine("Enter two numbers:");
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            if (a1 > b1)
                Console.WriteLine("{0} is Biggest and {1} is Smallest.", a1, b1);
            else
                Console.WriteLine("{0} is Biggest and {1} is Smallest.", b1, a1);
            Console.WriteLine("----------------------");

            int y;
            Console.WriteLine("Enter a year to check Leap year:");
            y = Convert.ToInt32(Console.ReadLine());
            if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
                Console.WriteLine("{0} is a Leap year.", y);
            else
                Console.WriteLine("{0} is not a Leap year.", y);
            Console.WriteLine("----------------------");

            int m1, m2, m3;
            Console.WriteLine("Enter marks for three subjects:");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            int t = m1 + m2 + m3;
            Console.WriteLine("Total Marks: "+t);
            int p = t / 3;
            Console.WriteLine("Percentage: " + p);
            if (p>=60)
                Console.WriteLine("First");
            else if(p>=45 && p<60)
                Console.WriteLine("Second");
            else if(p >= 35 && p < 45)
                Console.WriteLine("Third");
            else if (p < 35)
                Console.WriteLine("Fail");
            else
                Console.WriteLine("Invalid");
            Console.WriteLine("----------------------");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");


            int n, i1, sum = 0;
            Console.WriteLine("Enter the value of n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Odd numbers between 1 to {0}:", n);
            for (i1 = 1; i1 <= n; i1++)
            {
                if ((i1 % 2) != 0)
                {
                    sum += i1;
                    Console.WriteLine(i1);
                }
            }
            Console.WriteLine("Sum of odd numbers from 1 to {0} is {1}.", n, sum);
            Console.WriteLine("----------------------");


            int num, r = 0, rem;
            Console.WriteLine("Enter a Number to display in reverse:");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                r = r * 10 + rem;
                num /= 10;
            }
           Console.WriteLine("Reversed number: "+r);
           Console.WriteLine("----------------------");


            int i2, sum1 = 0;
            Console.WriteLine("Integers between 100 to 200:");
            for (i2 = 100; i2 <= 200; i2++)
            {
                sum1 += i2;
                Console.WriteLine(i2);
            }
            Console.WriteLine("Sum of integers numbers from 100 to 200: " +sum1);
            Console.WriteLine("----------------------");

            int  i3, sum2 = 0;
            Console.WriteLine("Numbers between 100 and 200 which is divisible by 9:");
            for (i3 = 100; i3 <= 200; i3++)
            {
                if ((i3 % 9) == 0)
                {
                    sum2 += i3;
                    Console.WriteLine(i3);
                }
            }
            Console.WriteLine("Sum of number bw 100 and 200 which is divisible by 9: " +sum2);
            Console.WriteLine("----------------------");
            Console.ReadLine();
        }
    }
}

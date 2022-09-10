using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day18
{
    public class PS1
    {
        public static void Method1()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    Thread.Sleep(1000);
                } 
            }
        }
        static void Main(string[] args)
        {
            Thread t5 = new Thread(Method1);
            t5.Start();
            Thread t3 = new Thread(new ThreadStart(Method1));
            t3.Start();
            Console.ReadLine();
        }
    }
}

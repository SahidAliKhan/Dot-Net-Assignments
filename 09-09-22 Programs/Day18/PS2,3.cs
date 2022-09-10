using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day18
{
    public class PS2
    {
        public static void Method1()
        {
          
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    Console.WriteLine("Thread name for Method1: " + Thread.CurrentThread.Name);
                    Thread.Sleep(1000);
                }
            }
        }
        public static void Method2()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
                if (i == 2)
                {
                    Console.WriteLine("Thread name for Method2: " + Thread.CurrentThread.Name);
                    Thread.Sleep(1000);
                }
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Method1));
            t1.Name = "First Thread";

            Thread t2 = new Thread(new ThreadStart(Method2));
            t2.Name = "Second Thread";

            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Highest;

            Console.WriteLine(" Is Thread t1 is alive before start: " + t1.IsAlive);
            Console.WriteLine(" Is Thread t2 is alive before start: " + t2.IsAlive);
            Console.WriteLine("Thread state T1 before start: " + t1.ThreadState);
            Console.WriteLine("Thread state T2 before start: " + t2.ThreadState);

            t2.Start();
            t1.Start();


            Console.WriteLine(" Is Thread t1 is alive after start: " + t1.IsAlive);
            Console.WriteLine(" Is Thread t2 is alive after start: " + t2.IsAlive);
            Console.WriteLine("Thread state T1 after start: " + t1.ThreadState);
            Console.WriteLine("Thread state T2 after start: " + t2.ThreadState);
            //t1.Abort();
            //t2.Abort();

            Console.ReadLine();
        }
    }
}

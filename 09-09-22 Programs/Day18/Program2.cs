using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day18
{
    class ISAliveDemo
    {
        static void M1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Sleep State =" + Thread.CurrentThread.ThreadState);
        }

        static void M2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Print  i{0} ", i);
                Console.WriteLine("Thread name " + Thread.CurrentThread.Name);

                Thread.Sleep(200);
            }

        }
        static void Main(string[] args)
        {
            //ThreadAliveAndStates();


            Thread t1 = new Thread(new ThreadStart(M2));
            t1.Name = "T1 Thread";

            Thread t2 = new Thread(M2);
            t2.Name = "T2 Thread";
            Thread t3 = new Thread(M2);
            t3.Name = "T3 Thread";
            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Normal;
            t3.Priority = ThreadPriority.Lowest;
            t2.Start();
            t1.Start();
            //t1.Join();

            t3.Start();



            Console.ReadLine();



        }

        private static void ThreadAliveAndStates()
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M1);
            Console.WriteLine("----Before Start---- ");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Start();
            t2.Start();
            Console.WriteLine("----After Start----");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Abort();
            t2.Abort();
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);
        }
    }
}

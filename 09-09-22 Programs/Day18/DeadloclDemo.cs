using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day18
{
    class DeadlockDemo
    {
        static object lock1 = new object();
        static object lock2 = new object();
        static void Job1()
        {
            lock (lock1)
            {
                Job2();
                Console.WriteLine("This is job1");
                lock (lock2)
                {
                    Job2();
                    Console.WriteLine("Job2 locked");
                }
            }
        }
        static void Job2()
        {
            lock (lock2)
            {
                Job1();
                Console.WriteLine("This is Job2");
            }



        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Job1);
            Thread t2 = new Thread(Job2);
            t1.Start();
            t2.Start();
            t2.Abort();
            Console.WriteLine("Aborted");
            Console.Read();
        }
    }
}
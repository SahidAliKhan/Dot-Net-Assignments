using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day18
{
    class SemaphoreDemo
    {
        static Thread[] threads = new Thread[10];
        static Semaphore sem = new Semaphore(3, 3);
        static void M1()
        {
            Console.WriteLine("{0} is waiting in line...", Thread.CurrentThread.Name);
            sem.WaitOne();
            Console.WriteLine("{0} enters the code", Thread.CurrentThread.Name);
            Thread.Sleep(300);
            Console.WriteLine("{0} is leaving the code", Thread.CurrentThread.Name);
            sem.Release();
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(M1);
                threads[i].Name = "thread_" + i;
                threads[i].Start();
            }
            Console.Read();
        }
    }
}

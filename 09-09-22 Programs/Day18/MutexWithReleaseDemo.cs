using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day18
{
    class MutexWithReleaseDemo
    {
        private static Mutex mutex = new Mutex();
        const int limits = 1;
        const int threads = 4;

        static void ThreadsDemo()
        {
            for (int i = 0; i < limits; i++)
            {
                UseCode();
            }
        }
        static void UseCode()
        {
            mutex.WaitOne();   // Wait until it is safe to enter.  
            Console.WriteLine("{0} has entered in the code",
                Thread.CurrentThread.Name);
            // Place code to access non-reentrant resources here.  
            Thread.Sleep(500);    // Wait until it is safe to enter.  
            Console.WriteLine("{0} is leaving the code\r\n",
                Thread.CurrentThread.Name);
            mutex.ReleaseMutex();    // Release the Mutex.  


        }


        static void Main(string[] args)
        {
            for (int i = 0; i < threads; i++)
            {
                Thread t = new Thread(new ThreadStart(ThreadsDemo));
                t.Name = String.Format("Thread{0}", i + 1);
                t.Start();
            }
            Console.Read();

        }
    }
}

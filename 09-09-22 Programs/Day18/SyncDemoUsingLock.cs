using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingDemo
{
    class SyncDemoUsingLock
    {
        void PrintTable()
        {
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i);

                }
            }
        }
        static void Main(string[] args)
        {
            SyncDemoUsingLock l = new SyncDemoUsingLock();
            Thread t1 = new Thread(l.PrintTable);
            Thread t2 = new Thread(l.PrintTable);
            t1.Start();
            t2.Start();
            Console.Read();


        }
    }
}

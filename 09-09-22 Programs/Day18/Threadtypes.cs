using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day18
{
    class Threadtypes
    {
        static void MyThreadMethod()
        {
            Console.WriteLine("The current thread which is running = " + Thread.CurrentThread.Name);
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Method {0} =", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("My thread Method ends");
        }
        static void Main(string[] args)
        {

            Thread t1 = new Thread(MyThreadMethod);
            t1.Name = "MyThread";
            //  t1.IsBackground = true;
            t1.Start();
            Console.WriteLine("Main thread ends");
            Thread.Sleep(2000);
            t1.Abort();
            Console.WriteLine("thread aborted");
            Console.ReadLine();
        }
    }
}

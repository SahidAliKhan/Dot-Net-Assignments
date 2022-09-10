using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Day18
{
    class MonitorDemo
    {
        static object l1 = new object();
        static void PrintTable()
        {

            Thread.Sleep(800);
            WriteToFile();
        }
        static void WriteToFile()
        {
            string threadname = Thread.CurrentThread.Name;
            Console.WriteLine(threadname);
            Monitor.Enter(l1);
            try
            {
                using (FileStream fs = new FileStream("tables.txt", FileMode.Append, FileAccess.Write))
                {
                    StreamWriter wr = new StreamWriter(fs);
                    wr.WriteLine(threadname);
                    wr.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Monitor.Exit(l1);
                Console.WriteLine("Releasing the thread " + threadname);
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Thread thread = new Thread(PrintTable);
                thread.Name = string.Concat("thread ", i);
                thread.Start();
            }
            Console.Read();
        }
    }
}

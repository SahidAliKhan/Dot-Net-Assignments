using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackDemo s = new StackDemo();
            Console.WriteLine("IEmpty= " + s.isStackEmpty());
            Console.WriteLine("------------");
            s.Push(10);
            s.Push(100);
            s.Push(20);
            s.Push(40);
            Console.WriteLine("Pop ");
            s.Pop();
            Console.WriteLine("---------------------");
            Console.WriteLine("Peek");
            s.Peek();
            Console.WriteLine("---------------------");
            s.PrintStackElements();
            Console.WriteLine("IEmpty= " + s.isStackEmpty());

            Console.WriteLine("--------------------Generic Stack Ex---------------------");


            UserDataStore<string> stringdata = new UserDataStore<string>();
            stringdata.AddOrEdit(0, "Hello");
            string printdata = stringdata.ReturnData(0);
            Console.WriteLine(printdata);
            Console.WriteLine("-------------------");
            stringdata.AddOrEdit(0, "Welcome");

            stringdata.ShowData(0);
            Console.ReadLine();
        }
    }
}

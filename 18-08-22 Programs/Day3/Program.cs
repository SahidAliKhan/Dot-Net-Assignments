using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f = 100.0f;
            double d = f;
            int i = 10;
            string s = Convert.ToString(i);
            object obj = s;
            Console.WriteLine("Boxing of Double: "+d);
            Console.WriteLine("Boxing of String: "+s);
            Console.WriteLine("Boxing of Object: "+obj);
            Console.WriteLine("--------------------------");

            float f1 = (float)d;
            int i1 = Convert.ToInt32(s);
            string s1 = (string)obj;
            Console.WriteLine("Unboxing of Double: " + f1);
            Console.WriteLine("Unboxing of String: " + i1);
            Console.WriteLine("Unboxing of Object: " + s1);
            Console.WriteLine("--------------------------");

            int k = 90;
            object o = new object();
            o = 90;
            bool res = o.Equals(k);
            Console.WriteLine(res);
            Console.WriteLine("--------------------------");

            int k1 = 90;
            object o1 = "90";
            bool res1 = o1.Equals(k1);
            Console.WriteLine(res1);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Swapping Numbers:");
            Console.WriteLine("Enter First number:");
            Console.ReadLine();


        }
    }
}

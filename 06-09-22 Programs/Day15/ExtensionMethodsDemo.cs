using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    //extending functionality of existing methods
    //Features:
    //1.static methods
    //2.  class containing extension methods must be public
    //3. the parameter which it needs to extend the functionality to, must be the first parameter in the parameter list and it must be prefixed with "this" keyword.
    //4. cannot be used with properties,fields etc, can only be used with methods
    public static class ExtensionMethodsDemo
    {
        public static void newmethod()
        {
            Console.WriteLine("called new method...");

        }

        public static void method1(this Indexer_this_Demo p)
        {
            Console.WriteLine("Calling method1 on person class");

        }
        public static void LengthOfString(this string p)
        {
            //Console.WriteLine("Calling method1 on string class");
            int len = p.Length;
            Console.WriteLine(len);

        }

        public static int calculateArea(this int len)
        {
            int area = len * 4;
            return area;
        }

        public static float calculateArea(this int b, int h)
        {
            float area = (b * h) / 2;
            return area;
        }
        static void Main(string[] args)
        {
            string s = "hello";

            s.LengthOfString();

            int i = 10;
            int areaOFSq = i.calculateArea();
            Console.WriteLine(areaOFSq);

            int j = 20;
            float area = j.calculateArea(15);
            Console.WriteLine(area);


            List<int> list = new List<int>();
            list.Add(1);
            list.Add(101);
            list.Add(12);
            list.Add(31);
            list.Add(33);
            list.Add(43);
            list.Add(19);
            list.Add(5);

            double avgOfNos = list.Average();
            Console.WriteLine("Average=" + avgOfNos);
            int a = list.ElementAt(2);
            Console.WriteLine("Elemnet at=" + a);

            int[] arr = new int[] { 3, 13, 4, 322, 22 };


            Console.Read();
        }
    }
}

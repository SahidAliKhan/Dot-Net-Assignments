using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReusuableCodeLibrary
{
    public class UnderstandingStrings
    {
        public static void StringLength(string s1, string s2)
        {
            int len = s1.Length;
            Console.WriteLine("Length of the String: " +len);
            Console.WriteLine("----------------------");

            if (s1 == s2)
            {
                Console.WriteLine("Both Strings are equal.");
            }
            else
            {
                Console.WriteLine("Both Strings are not equal.");
            }
            Console.WriteLine("----------------------");

            Console.WriteLine("Before Copy string:{0} {1} ",s1,s2 );
            s2 = String.Copy(s1);
            Console.WriteLine("After Copy string:{0} {1} ", s1, s2);
            int i = s1.IndexOf('h');
            Console.WriteLine("----------------------");

            Console.WriteLine("Index of 'h' in 1st String: ");
            Console.WriteLine(i);
            Console.WriteLine("----------------------");

            string newStr = "Welcome to the world of C# Programming";
            Console.WriteLine("Before Spliting '#': " +newStr);
            string[] sep = { "#", "," };
            //char[] sep = { ' ' };
            int cnt = 2;
            string[] result = newStr.Split(sep, cnt, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("After Spliting '#':");
            foreach (var i1 in result)
            {
                Console.WriteLine(i1);
            }
            Console.WriteLine("----------------------");

            string newStr1 = newStr.ToUpper();
            Console.WriteLine("String after Uppercase: " +newStr1);
            Console.WriteLine("----------------------");

            Console.WriteLine("Enter a Date: ");
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Day:  " + dt.Day);
            Console.WriteLine("Month:  " + dt.Month);
            Console.WriteLine("Year: " + dt.Year);
            Console.WriteLine("Hour: " + dt.Hour);
            Console.WriteLine("Minute: " + dt.Minute);
            Console.WriteLine("Second: " + dt.Second);
            Console.WriteLine("Millisecond: " + dt.Millisecond);

        }
        public static void MakeFirstFile()
        {
            string path = @"S:\Apps\Dot Net\MyApp\firstFile.txt";
            File.Create(path);
        }
    }
}

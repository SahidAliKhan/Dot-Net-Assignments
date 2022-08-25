using ReusuableCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReusuableCodeLibrary;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1.PrintString();
            Console.WriteLine("----------------------");

            Console.WriteLine("Enter 1st String:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd String:");
            string s2 = Console.ReadLine();
            UnderstandingStrings.StringLength(s1,s2);

            Console.WriteLine("----------------------");
            UnderstandingStrings.MakeFirstFile();
            Console.WriteLine("firstFile.txt got Created in MyApp Console.");
            
            Console.ReadLine();
        }
    }
}

using System;
using System.IO;

namespace Day8
{
    internal class PS1
    {
        static void Main(string[] args)
        {
            string path = @"S:\Apps\Dot Net\Day8\";
            string p;
            Console.WriteLine("Enter File Name: ");
            p = Console.ReadLine();
            Console.WriteLine("Menu: \n1.Add a File \n2.Append a File \n3.Truncate a File");
            Console.WriteLine("Enter a Number:");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    
                    Console.WriteLine("Enter your file contents: ");
                    string con = Console.ReadLine();
                    File.WriteAllText(path + p, con);
                    Console.WriteLine("File Created with contents..");
                    break;
                case 2:
                    Console.WriteLine("Enter Contents to Append: ");
                    string con2 = Console.ReadLine();
                    File.AppendAllText(path + p, con2);
                    Console.WriteLine("Appended..");
                    break;
                case 3:
                    FileStream fs = new FileStream(path + p, FileMode.Truncate);
                    Console.WriteLine("Truncated...");
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
            Console.ReadLine();
        }
    }
}       

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Incremental_Assignmnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Fname, Lname;
            Console.WriteLine("Enter First Name which is User ID:");
            Fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name which is Password:");
            Lname = Console.ReadLine();
            if (!string.IsNullOrEmpty(Fname) && !string.IsNullOrEmpty(Lname))
            {
                Console.WriteLine("Successfully logged in");
                Console.WriteLine("Welcome to my app");
            }
            else
            {
                Console.WriteLine("Not successfully logged in");
            }
            Console.ReadLine();
        }
    }
}

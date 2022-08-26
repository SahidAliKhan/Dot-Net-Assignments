
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace Day9
{
    internal class PS2
    {
        static void Main(string[] args)
        {
            Students[] s2 = new Students[2];
            for (int i = 0; i < s2.Length; i++)
            {
                s2[i] = new Students();
                Console.WriteLine("Enter Detals of Student {0}: ", i);
                Console.WriteLine("Enter Student ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Student Department Number:");
                int dept = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter College Name:");
                string cname1 = Console.ReadLine();
                Console.WriteLine("---------------------------");
                s2[i].AcceptData(id, name, dept, cname1);
            }

            for (int i = 0; i < s2.Length; i++)
            {
                Console.WriteLine("Details of Students {0}:", i);
                s2[i].Display();
                Console.WriteLine("---------------------------");
            }
            Console.ReadLine();
        }
    }
   
}

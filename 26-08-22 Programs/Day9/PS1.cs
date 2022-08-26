using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class PS1
    {
        static void Main(string[] args)
        {
            Students[] s1 = new Students[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Detals of Student {0}: ", i);
                Console.WriteLine("Enter Student ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Student Department Number:");
                int dept = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter College Name:");
                string cname1  = Console.ReadLine();
                Console.WriteLine("---------------------------");
                s1[i].AcceptData(id, name, dept, cname1);
            }

            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Details of Students {0}:", j);
                s1[j].Display();
                Console.WriteLine("---------------------------");
            }
            Console.ReadLine();
        }

        struct Students
        {
            int Sno, Deptno;
            string Sname, Cname;
            public void AcceptData(int sno, string sname, int deptno, string cname)
            {
                Sno = sno;
                Sname = sname;
                Deptno = deptno;
                Cname = cname;
            }
            public void Display()
            {
                Console.WriteLine("Student ID: " + Sno);
                Console.WriteLine("Student Name: " + Sname);
                Console.WriteLine("Student Department Number: " + Deptno);
                Console.WriteLine("College Name: " + Cname);
            }
        }
    }
}

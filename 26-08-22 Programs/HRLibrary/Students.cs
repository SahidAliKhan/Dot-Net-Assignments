using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Students
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

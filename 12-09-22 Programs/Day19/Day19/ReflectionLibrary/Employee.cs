using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLibrary
{
    public class Employee
    {

        public int empid { get; set; }
        public string ename { get; set; }
        public void AcceptData(int employeeid, string employeename)
        {
            empid = employeeid;
            ename = employeename;

        }
        public void DisplayData()
        {
            Console.WriteLine(empid);
            Console.WriteLine(ename);

        }

    }
}

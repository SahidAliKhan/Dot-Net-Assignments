using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace Day9
{
    class EmployeeDetailsUsingArrayOfObjects
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[2];

            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employee();
                Console.WriteLine("Enter {0} Empid" ,i);
                emp[i].EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter {0} Empname", i);
                emp[i].EmpName = Console.ReadLine();
                Console.WriteLine("Enter {0} Deptno", i);
                emp[i].DeptNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter {0} City", i);
                emp[i].City = Console.ReadLine();
                Console.WriteLine("Enter {0} basic salary", i);
                int bs = Convert.ToInt32(Console.ReadLine());
                emp[i].CalculateSalary(bs);
            }
            Console.WriteLine("----------------------");

            foreach (var item in emp)
            {
                Console.WriteLine("Following are the details");
                Console.WriteLine(item.EmpID);
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.DeptNo);
                Console.WriteLine(item.City);
                Console.WriteLine(item.GrossSalary);

            }
            Console.Read();

        }
    }
}

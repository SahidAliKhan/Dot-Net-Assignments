using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace Day9
{
    internal class EmployeeDetailsUsingListOfObjects
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee {EmpID = 1, EmpName = "Sahid", City = "Pune", DeptNo = 10});

            Employee emp1 = new Employee();
            emp1.EmpID = 2;
            emp1.EmpName = "Khan";
            emp1.City = "RKL";
            emp1.DeptNo = 19;
            emp1.CalculateSalary(10000);
            Console.WriteLine(emp1.GrossSalary);
            emplist.Add(emp1);

            foreach (var item in emplist)
            {
                Console.WriteLine(item.EmpID);
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.City);
                Console.WriteLine(item.DeptNo);
            }
            Console.ReadLine();
        }
    }
}

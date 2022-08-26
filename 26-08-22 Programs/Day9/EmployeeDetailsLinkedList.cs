using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace Day9
{
    class EmployeeDetailsLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<Employee> emp = new LinkedList<Employee>();
            emp.AddFirst(new Employee {EmpName = "Jack"});
            emp.AddLast(new Employee { EmpName = "Jim" });
            emp.AddAfter(emp.First,new Employee { EmpName = "Jill" });
            emp.AddBefore(emp.Last, new Employee { EmpName = "Hari" });
            emp.AddBefore(emp.Last.Previous, new Employee { EmpName = "Pari" });

            Console.WriteLine("Before:");
            foreach (var i in emp)
            {
                Console.WriteLine(i.EmpName);
            }
            emp.Remove(emp.Last.Previous);

            Console.WriteLine("After Remove Pari:");
            foreach (var i in emp)
            {
                Console.WriteLine(i.EmpName);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101);
            Address addr = new Address();
            //emp.Employeeid = 101;
            emp.Title = "Dr.";
            emp.FirstName = "Anisha";
            emp.LastName = "K";
            emp.JoiningDate = new DateTime(2022, 06, 11);
            emp.EmpAddress = addr;
            emp.EmpAddress.StreetNo = 21;
            emp.EmpAddress.ApartmentName = "ABC";
            emp.EmpAddress.HouseNo = 101;
            emp.EmpAddress.Area = "HHH";
            emp.EmpAddress.City = "RKL";
            emp.EmpAddress.State = "Odisha";
            emp.EmpAddress.PinCode = 769004;

            Console.WriteLine(emp.Employeeid);
            Console.Write(emp.Title + " ");
            Console.Write(emp.FirstName+ " ");
            Console.WriteLine(emp.LastName);
            Console.WriteLine(emp.JoiningDate);
            Console.WriteLine(emp.EmpAddress.StreetNo);
            Console.WriteLine(emp.EmpAddress.ApartmentName);
            Console.WriteLine(emp.EmpAddress.HouseNo);
            Console.WriteLine(emp.EmpAddress.Area);
            Console.WriteLine(emp.EmpAddress.City);
            Console.WriteLine(emp.EmpAddress.State);
            Console.WriteLine(emp.EmpAddress.PinCode);
            Console.WriteLine("-------------------------");

            Employee emp1 = new Employee();
            emp1.Employeeid = 102;
            emp1.Title = "Mr";
            emp1.FirstName = "Keshav";
            emp1.LastName = "P";
            emp1.JoiningDate = new DateTime(2019, 01, 10);

            Address address1 = new Address();
            address1.StreetNo = 13;
            address1.ApartmentName = "Ajay Apts";
            address1.HouseNo = 456;
            address1.Area = "Some Area";

            //IMPORTANT
            emp1.EmpAddress = address1;
            List<Employee> emplist = new List<Employee>();
            emplist.Add(emp);
            emplist.Add(emp1);

            Console.WriteLine("-------One Dept many employees-------");
            Dept d = new Dept();
            d.Deptnumber = 100;
            d.DepartmentName = "Research";
            d.Location = "Hyderabad";
            d.DeptEmployees = emplist;


            Console.WriteLine("Dept details");
            Console.WriteLine("Deptno= " + d.Deptnumber);
            Console.WriteLine("Deptname" + d.DepartmentName);
            Console.WriteLine("Location of Dept=" + d.Location);
            Console.WriteLine("-------------");
            foreach (var item in d.DeptEmployees)
            {
                Console.WriteLine(item.Employeeid);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.JoiningDate);
                Console.WriteLine(item.EmpAddress.StreetNo);
                Console.WriteLine(item.EmpAddress.HouseNo);
                Console.WriteLine(item.EmpAddress.ApartmentName);
                Console.WriteLine(item.EmpAddress.Area);
                Console.WriteLine("--------------------------");
            }

            //  EmployeeDemo();
            //Student.Initialize();
            //Student.Initialize();
            Student s1 = new Student();
            s1.AddStudent();
            Console.WriteLine("--------");
            Student s2 = new Student();

            s2.AddStudent();
            Console.WriteLine("--------");
            Student s3 = new Student();
            s3.AddStudent();

            //Student stud = new Student();
            //stud.AddStudent(); //1
            //stud.AddStudent();
            //Console.WriteLine("----------------");
            //Student s1 = new Student();
            //s1.AddStudent();
            //Student s2 = new Student();
            //s2.AddStudent();
            //stud.AddStudent(); //2
            //stud.AddStudent();  //3
            //stud.DeleteStudent(); //2
            //stud.AddStudent(); //3

            Console.ReadLine();

        }
    }
}

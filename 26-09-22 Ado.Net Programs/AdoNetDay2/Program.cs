using System;
using System.Collections.Generic;
using HelperLibrary;
using BusinessLogicLayerLibrary;
namespace AdoNetDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Management System");
            Console.WriteLine("--------------------------------");
            Employee_Helper helper = new Employee_Helper();
            repeat:
            Console.WriteLine("Menu");
            Console.WriteLine("-----");
            Console.WriteLine("1. Add New Employee \n 2. Update Employee \n 3. Find Employee \n 4. Show All \n 5.Delete \n  6. Employee count \n 7. Exit ");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            Employee_BAL emp = new Employee_BAL();
            switch (userchoice)
            {
                case 1:

                    Console.WriteLine("Enter firstname");
                    emp.FirstName = Console.ReadLine().Trim();

                    Console.WriteLine("Enter lastname");
                    emp.LastName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter title");
                    emp.Title = Console.ReadLine().Trim();
                    Console.WriteLine("Enter birthdate");
                    emp.BirthDate = Convert.ToDateTime(Console.ReadLine());

                    bool queryStatus = helper.AddEmployee(emp);
                    if (queryStatus)
                    {
                        Console.WriteLine("Employee added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 2:

                    Console.WriteLine("Enter Employeeid ");
                    emp.EmployeeID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter firstname");
                    emp.FirstName = Console.ReadLine().Trim();

                    Console.WriteLine("Enter lastname");
                    emp.LastName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter title");
                    emp.Title = Console.ReadLine().Trim();
                    Console.WriteLine("Enter birthdate");
                    emp.BirthDate = Convert.ToDateTime(Console.ReadLine());

                    queryStatus = helper.EditEmployee(emp);
                    if (queryStatus)
                    {
                        Console.WriteLine("Employee updated successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }

                    break;
                case 3:
                    //WithoutOutParameter(helper, emp);
                    WithOutParameter(helper, emp);

                    break;
                case 4:
                    List<Employee_BAL> list = new List<Employee_BAL>();
                    list = helper.ShowEmployeeList();
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.EmployeeID);
                        Console.WriteLine(item.FirstName);
                        Console.WriteLine(item.LastName);
                        Console.WriteLine(item.Title);
                        Console.WriteLine(item.BirthDate);
                        Console.WriteLine();
                    }
                    break;
                case 5:

                    Console.WriteLine("Enter Employeeid ");
                    emp.EmployeeID = Convert.ToInt32(Console.ReadLine());
                    queryStatus = helper.RemvoeEmployee(emp.EmployeeID);
                    if (queryStatus)
                    {
                        Console.WriteLine("Employee deleted successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }

                    break;
                case 6:
                    int cnt = helper.countEmployees();
                    Console.WriteLine("Total employees=" + cnt);
                    break;

                case 7:
                    Environment.Exit(1);
                    break;
            }
            goto repeat;
            Console.ReadLine();
        }

        private static void WithOutParameter(Employee_Helper helper, Employee_BAL emp)
        {
            Console.WriteLine("Enter Employeeid ");
            emp.EmployeeID = Convert.ToInt32(Console.ReadLine());
            Employee_BAL bal = new Employee_BAL();
            helper.SearchEmployee(emp.EmployeeID, out bal);
            if (bal != null)
            {
                bal.EmployeeID = emp.EmployeeID;
                Console.WriteLine("following were the details found in the db");
                Console.WriteLine(bal.EmployeeID);
                Console.WriteLine(bal.FirstName);
                Console.WriteLine(bal.LastName);
                Console.WriteLine(bal.Title);
                Console.WriteLine(bal.BirthDate);
            }
            else
            {
                Console.WriteLine("empid not found");
            }
        }
        private static void WithoutOutParameter(Employee_Helper helper, Employee_BAL emp)
        {
            Console.WriteLine("Enter Employeeid ");
            emp.EmployeeID = Convert.ToInt32(Console.ReadLine());
            Employee_BAL bal = new Employee_BAL();
            bal = helper.SearchEmployee(emp.EmployeeID);
            if (bal != null)
            {
                bal.EmployeeID = emp.EmployeeID;
                Console.WriteLine("following were the details found in the db");
                Console.WriteLine(bal.EmployeeID);
                Console.WriteLine(bal.FirstName);
                Console.WriteLine(bal.LastName);
                Console.WriteLine(bal.Title);
                Console.WriteLine(bal.BirthDate);
            }
            else
            {
                Console.WriteLine("empid not found");
            }
        }
    }
}

using System;
using System.Xml.Linq;

namespace Day6
{
    internal class PS9
    {
        static void Main(string[] args)
        {
            
            Employees e1 = new Employees();
            Console.WriteLine("Enter Employee number:");
            e1.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            e1.ename = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            int sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Department Number:");
            e1.deptno = Convert.ToInt32(Console.ReadLine());

            e1.AcceptData(e1.empno, e1.ename, sal, e1.deptno);
            Console.WriteLine("Employee Details:");
            e1.Display();

            Console.ReadLine();
        }

        struct Employees
        {
            int Empno, Sal, Deptno;
            string Ename;
            public void AcceptData(int empno, string ename, int sal, int deptno)
            {
                Empno = empno;
                Ename = ename;
                Sal = sal;
                Deptno = deptno;
            }
            public int empno
            {
                set
                {
                    if (Empno == 0)
                    {
                        Console.WriteLine("Employee number cannot be null");
                    }
                    
                }
                get
                {
                    return Empno;
                }
            }
            public int deptno
            {
                set
                {
                    if (Deptno == 0)
                    {
                        Console.WriteLine("Department number cannot be null");
                    }
                    else
                    {
                        Deptno = value;
                    }
                }
                get
                {
                    return Deptno;
                }
            }
            public string ename
            {
                set
                {
                    if (string.IsNullOrEmpty(Ename))
                    {
                        Console.WriteLine("Employee Name cannot be valid.");
                    }
                    else
                    {
                        Ename = value;

                    }
                }
                get
                {
                    return Ename;
                }


            }
            public void Display()
            {
                Console.WriteLine("Employee Number: " + Empno);
                Console.WriteLine("Employee Name: " + Ename);
                Console.WriteLine("Employee Salary: " + Sal);
                Console.WriteLine("Department Number: " + Deptno);
            }
        }
    }
}

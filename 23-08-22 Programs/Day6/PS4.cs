using System;

namespace Day6
{
    internal class PS4
    {
        static void Main(string[] args)
        {
            Employees e1 = new Employees();
            Console.WriteLine("Enter Employee number:");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            int sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Department Number:");
            int dept = Convert.ToInt32(Console.ReadLine());

            e1.AcceptData(no, name, sal, dept);
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
            public void Display()
            {
                Console.WriteLine("Employee Number: " +Empno);
                Console.WriteLine("Employee Name: " +Ename);
                Console.WriteLine("Employee Salary: " +Sal);
                Console.WriteLine("Department Number: " +Deptno);
            }
        }
    }
}

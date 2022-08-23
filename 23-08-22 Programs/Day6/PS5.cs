using System;


namespace Day6
{
    internal class PS5
    {
        static void Main(string[] args)
        {
            Employees[] e1 = new Employees[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter Detals of Employee {0}: ",i);
                Console.WriteLine("Enter Employee number:");
                int no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                int sal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Department Number:");
                int dept = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------");
                e1[i].AcceptData(no, name, sal, dept);
            }
            Console.WriteLine("---------------------------");
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("Details of Employee {0}:" ,j);
                e1[j].Display();
                Console.WriteLine("---------------------------");
            }
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
                Console.WriteLine("Employee Number: " + Empno);
                Console.WriteLine("Employee Name: " + Ename);
                Console.WriteLine("Employee Salary: " + Sal);
                Console.WriteLine("Department Number: " + Deptno);
            }
        }
    }
}

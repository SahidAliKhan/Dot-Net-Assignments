using System;

namespace Day6
{
    internal class PS3
    {
        static void Main(string[] args)
        {
            Employees e1 = new Employees();

            Console.WriteLine("Enter Employee Number:");
            e1.prop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            e1.ename = Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            e1.prop2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Department Number:");
            e1.prop3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Employee Details:");
            e1.display();
            Console.ReadLine();

        }
        struct Employees
        {
            int Empno, Sal, Deptno;
            string Ename;
            public int prop
            {
                get
                {
                    return Empno;
                }
                set
                {
                    Empno = value;
                }
            }
            public int prop2
            {
                get
                {
                    return Sal;
                }
                set
                {
                    Sal = value;
                }
            }
            public int prop3
            {
                get
                {
                    return Deptno;
                }
                set
                {
                    Deptno = value;
                }
            }
            public string ename
            {
                get
                {
                    return Ename;
                }
                set
                {
                    Ename = value;
                }
            }
            public void display()
            {
                Console.WriteLine("Employee Number: " + Empno);
                Console.WriteLine("Employee Name: " + Ename);
                Console.WriteLine("Employee Salary: " + Sal);
                Console.WriteLine("Department Number: " + Deptno);
            }
        }
        

     }
}

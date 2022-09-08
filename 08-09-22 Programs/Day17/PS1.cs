using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Day17
{
    public class PS1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Name as userid: ");
            string a1 = Console.ReadLine();
            Console.WriteLine("Enter password as Password: ");
            string a2 = Console.ReadLine();
            Action<string, string> Check = (u, p) =>
            {
                if (u != null && u == "userid" && p != null && p == "Password")
                {
                    Console.WriteLine("You are logged in.");
                    Console.WriteLine("-------------------");
                    Dept d = new Dept();
                    Employee e = new Employee();
                    d.ShowMenu();
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Enter Number of Employees in Dept: ");
                    int no = Convert.ToInt32(Console.ReadLine());
                    if (no <= 10)
                    {
                        for (int i = 0; i < no; i++)
                        {
                            Console.WriteLine("Enter Emplyoyee ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Delegate1 s = new Delegate1(e.Add);
                            s(id);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Number of Employees can't be more than 10");
                    }
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Do you want to Update/Delete an Employee, Enter: 'u' or 'd'");
                    string s1 = Console.ReadLine();
                    if (s1 == "u")
                    {
                        Console.WriteLine("Enter ID to Update Employee details...");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Delegate1 s2 = new Delegate1(e.Update);
                        s2(id1);
                        Console.WriteLine("-------------------");
                        Delegate1 s3 = new Delegate1(e.UpdateShow);
                        s3(id1);
                    }
                    else if (s1 == "d")
                    {
                        Console.WriteLine("Enter ID to Delete Employee details...");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Delegate1 s2 = new Delegate1(e.Delete);
                        s2(id1);
                        Console.WriteLine("-------------------");
                        Delegate1 s3 = new Delegate1(e.DeleteShow);
                        s3(id1);
                    }
                    else
                    {
                        Console.WriteLine("Please Enter 'u'' or 'd' Only...");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Details. Try Again!!!");
                }
            };
            Check(a1,a2);

            Console.ReadLine();
        }

    }
}

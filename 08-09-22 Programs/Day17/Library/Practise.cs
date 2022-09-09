using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    //    public delegate Dept numb(Dept p);
    //    public delegate void numb1(List<Employee> m);
    //    public delegate List<Employee> numb2(int i, List<Employee> p);
    //    public class Deptt
    //    {
    //        public int DeptNo
    //        {
    //            get;
    //            set;
    //        }
    //        public string DeptName
    //        {
    //            get;
    //            set;
    //        }
    //        public string Location
    //        {
    //            get;
    //            set;
    //        }
    //        public List<Employee> prod
    //        {
    //            get;
    //            set;

    //        }

    //        public List<Dept> Addition(List<Dept> me, List<Employee> m)
    //        {

    //            Deptt mot = new Deptt();
    //            Console.WriteLine("Enter the Department No");
    //            mot.DeptNo = Convert.ToInt32(Console.ReadLine());
    //            Func<List<Deptt>, int, Boolean> K = (i, j) =>
    //            {
    //                bool status = false;
    //                foreach (var item in i)
    //                {
    //                    if (item.DeptNo == j)
    //                    {
    //                        status = true;
    //                        break;
    //                    }
    //                }
    //                return status;
    //            };
    //            if (!K(me, mot.DeptNo))
    //            {
    //                Console.WriteLine("Enter department name");
    //                mot.DeptName = Console.ReadLine();
    //                Console.WriteLine("Enter the location");
    //                mot.Location = Console.ReadLine();
    //                mot.prod = m.Where(x => x.Deptno == mot.DeptNo).ToList();
    //                me.Add(mot);
    //                return me;
    //            }
    //            else
    //            {
    //                mot.prod = m.Where(x => x.Deptno == mot.DeptNo).ToList();
    //                return me;
    //            }

    //        }

    //        public void display(List<Dept> p)
    //        {
    //            Console.WriteLine("Enter the dept number you want to see");
    //            int f = Convert.ToInt32(Console.ReadLine());
    //            foreach (var item in p)
    //            {
    //                if (item.DeptNo == f)
    //                {
    //                    Console.WriteLine($"Dept no is {item.DeptNo}  name is {item.DeptName} and Location is {item.Location}\n");
    //                    Console.WriteLine("Employees working under this department");
    //                    foreach (var ite in item.prod)
    //                    {
    //                        Console.WriteLine($"{ite.Empname}\n");
    //                    }
    //                }
    //            }
    //        }



    //    }
    //    public class Employeee
    //    {


    //        public int EmployeeNo
    //        {
    //            get;
    //            set;
    //        }
    //        public string Empname
    //        {
    //            get;
    //            set;
    //        }
    //        public int Deptno
    //        {
    //            get;
    //            set;
    //        }
    //        public int Salary
    //        {
    //            get;
    //            set;

    //        }
    //        public string Manager
    //        {
    //            get;
    //            set;
    //        }
    //        public List<Employee> Adding(List<Employee> m)
    //        {

    //            Employeee mp = new Employeee();
    //            Console.WriteLine("enter the employee no");
    //            mp.EmployeeNo = Convert.ToInt32(Console.ReadLine());
    //            Console.WriteLine("Enter the name");
    //            mp.Empname = Console.ReadLine();
    //            Console.WriteLine("Enter the dept no");
    //            mp.Deptno = Convert.ToInt32(Console.ReadLine());
    //            Console.WriteLine("Enter the salary");
    //            mp.Salary = Convert.ToInt32(Console.ReadLine());
    //            Console.WriteLine("Enter the manager");
    //            mp.Manager = Console.ReadLine();
    //            int yup = m.Where(x => x.Deptno == mp.Deptno).Count();
    //            if (yup < 10)
    //            {
    //                m.Add(mp);
    //                return m;
    //            }
    //            else
    //            {
    //                Console.WriteLine("You cannot add more than 10 persons in 1 department");
    //                return m;

    //            }

    //        }
    //        public List<Employeee> Edit(int EmpId, List<Employeee> m)
    //        {
    //            Console.WriteLine("Which part you want to modify?\n 1.Empname\n  2.Salary\n 3.Manager");
    //            int w = Convert.ToInt32(Console.ReadLine());
    //            switch (w)
    //            {
    //                case 1:
    //                    foreach (var item in m)
    //                    {
    //                        if (item.EmployeeNo == EmpId)
    //                        {

    //                            Console.WriteLine("Enter the new name which is to modify");
    //                            item.Empname = Console.ReadLine();

    //                        }
    //                    }

    //                    break;

    //                case 2:
    //                    foreach (var item in m)
    //                    {
    //                        if (item.EmployeeNo == EmpId)
    //                        {

    //                            Console.WriteLine("Enter the salary which is to modify");
    //                            item.Salary = Convert.ToInt32(Console.ReadLine());

    //                        }
    //                    }

    //                    break;
    //                case 3:
    //                    foreach (var item in m)
    //                    {
    //                        if (item.EmployeeNo == EmpId)
    //                        {

    //                            Console.WriteLine("Enter the new manager which is to modify");
    //                            item.Manager = Console.ReadLine();


    //                        }
    //                    }

    //                    break;
    //                default:
    //                    break;
    //            }

    //            return m;
    //        }
    //        public List<Employeee> Delete(int id, List<Employeee> m)
    //        {
    //            m = m.Where(m1 => m1.EmployeeNo != id).ToList();
    //            return m;

    //        }
    //        public void Displaybymgr(List<Employeee> m)
    //        {
    //            Console.WriteLine("Enter the name of the manager whom name of employees you want to see ");
    //            string s = Console.ReadLine();
    //            var ti = m.Where(mi => mi.Manager == s).ToList();
    //            if (ti.Count > 0)
    //            {
    //                foreach (var item in ti)
    //                    Console.WriteLine(item.Empname);
    //            }
    //            else
    //            {
    //                Console.WriteLine("No employees is working under him");
    //            }
    //        }
    //        public void Display(List<Employeee> m)
    //        {
    //            foreach (var item in m)
    //            {
    //                Console.WriteLine($"{item.EmployeeNo} {item.Empname} {item.Deptno} {item.Salary} {item.Manager}\n");
    //            }

    //        }

    //    }
}

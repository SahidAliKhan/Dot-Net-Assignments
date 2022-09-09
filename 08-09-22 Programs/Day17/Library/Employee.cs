using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public delegate void Delegate1(int id);
    public class Employee
    {
		//employee id, empname, deptno, sal, mgr
		private int _id;

		public int EmpID
		{
			get { return _id; }
			set { _id = value; }
		}
		private string _empname;
		public string EmpName
		{
			get { return _empname; }
			set { _empname = value; }
		}
		private int _deptno;

		public int DeptNo
		{
			get { return _deptno; }
			set { _deptno = value; }
		}
		private int _sal;

		public int Salary
		{
			get { return _sal; }
			set { _sal = value; }
		}
		private int mgr;

		public int MGR
		{
			get { return mgr; }
			set { mgr = value; }
		}
		public static event Delegate1 Event1;	
		public void Add(int id)
		{
			EmpID = id;
			Console.WriteLine("Add Details of Employee ID: " + EmpID);
			Console.WriteLine("Enter Employee Name: ");
			EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee DeptNo: ");
			DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee MGR: ");
            MGR = Convert.ToInt32(Console.ReadLine());
        }
		public void Update(int id)
		{
			Console.WriteLine("Update Details of an Employee");
			Console.WriteLine("Edit Employee ID:");
			id = Convert.ToInt32(Console.ReadLine());
            EmpID = id;
            Console.WriteLine("Edit Employee Name: ");
            EmpName = Console.ReadLine();
            Console.WriteLine("Edit Employee DeptNo: ");
            DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Edit Employee Salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Edit Employee MGR: ");
            MGR = Convert.ToInt32(Console.ReadLine());
        }
		public void Delete(int id)
		{
			EmpID = id;
            Console.WriteLine("Details of Employee ID {0} got deleted...", EmpID);
            EmpID = 0;
			EmpName = string.Empty;
			DeptNo = 0;
			Salary = 0;
			MGR = 0;
		}
		public void UpdateShow(int id)
		{
			Console.WriteLine("Employee Details after Update");
			Console.WriteLine(EmpID);
			Console.WriteLine(EmpName);
			Console.WriteLine(DeptNo);
			Console.WriteLine(Salary);
			Console.WriteLine(MGR);
		}
		public void DeleteShow(int id)
		{
			Console.WriteLine("");
		}
	}
}

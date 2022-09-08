using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Dept
	{
        //deptno,dname and location
        private int _deptno;

		public int DeptNo
		{
			get { return _deptno; }
			set { _deptno = value; }
		}
		private string _dname;

		public string DeptName
		{
			get { return _dname; }
			set { _dname = value; }
		}
		private string _location;

		public string Location
		{
			get { return _location; }
			set { _location = value; }
		}

		public void ShowMenu()
		{
            int a, userchoice;
            string b,c;
            Console.WriteLine("Menu: \n 1.Add Department \n 2.Exit");
            userchoice = Convert.ToInt32(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    Console.WriteLine("Enter Dept No, DeptName, Location: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    b= Console.ReadLine();
                    c= Console.ReadLine();
                    break;
                case 2:
                    Environment.Exit(1);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
            Console.WriteLine();
        }
	}
}

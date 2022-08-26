using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Employee
    {
        private int _empid;

        public int EmpID
        {
            get { return _empid; }
            set { _empid = value; }
        }


        private string _ename;

        public string EmpName
        {
            get { return _ename; }
            set { _ename = value; }
        }

        //fully implemented property----do any validations
        private int _deptno;

        public int DeptNo
        {
            get { return _deptno; }
            set
            {
                try
                {

                    if (value != 0)
                    {
                        _deptno = value;
                    }
                    else
                    {
                        //Console.WriteLine("Deptno cannot be 0 or null");
                        throw new ArgumentNullException("Deptno cannot be zero or null");
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }


            }
        }


        //Auto-implemented property
        public string City { get; set; }

        public double GrossSalary { get; private set; }

        public void CalculateSalary(int bs)
        {

            double grosssSal = 0;
            if (City == "Pune" || City == "Bangalore" || City == "Hyderabad")
            {
                grosssSal = bs + (bs * .10);
            }
            else
            {
                grosssSal = bs + (bs * .05);
            }
            //Console.WriteLine("Gross Salary=" +  grosssSal);
            GrossSalary = grosssSal;

        }

    }
}

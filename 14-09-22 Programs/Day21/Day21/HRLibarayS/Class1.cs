using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibarayS
{
    [Serializable()]
    public class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }

        public double Salary { get; set; }

        [NonSerialized()]
        private string _pwd;
        public string Password
        {
            get { return _pwd; }
            set { _pwd = value; }
        }

        public double GrossSal { get; set; }


        public double CalculateSalary()
        {
            double da = Salary * .10;
            double ta = Salary * .20;
            double grossSal = ta + da + Salary;
            GrossSal = grossSal;
            return grossSal;


        }

    }
}

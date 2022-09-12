using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19PSLibrary
{
    public class Calculator
    {
        private double _no;

        public double No
        {
            get { return _no; }
            set { _no = value; }
        }
        public double Cube(double No)
        {
            double n = No * No * No;
            return n;
        }
        public double Sqrt(double number)
        {
            double nu = Math.Sqrt(number);
            return nu;
        }
    }
}

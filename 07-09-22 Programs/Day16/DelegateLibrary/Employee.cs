using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLibrary
{
    public delegate void Delegate5(DateTime calculateYearsOfService);
    public class Employee
    {
        int currentDate = DateTime.Now.Year;
        int year, year2;
        private DateTime _joiningYear;

		public DateTime JoiningYear
        {
			get { return _joiningYear; }
			set { _joiningYear = value; }
		}
		public void CalculateYear(DateTime calculateYearsOfService)
		{
            year = calculateYearsOfService.Year;
            year2 = currentDate - year;
            Console.WriteLine("Total Years of Service: " +year2);
        }

	}
}

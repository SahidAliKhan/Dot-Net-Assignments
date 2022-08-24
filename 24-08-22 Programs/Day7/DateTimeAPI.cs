using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class DateTimeAPI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Birth Date:");
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(Console.ReadLine());
            int age = DateTime.Now.Year - dt.Year;
            Console.WriteLine("Your Age: " + age);
            int months = age * 12;
            Console.WriteLine("Your Age in Months: " + months);
            Console.WriteLine("Day of the Year: " + dt.DayOfYear);
            bool leap = DateTime.IsLeapYear(dt.Year);   
            Console.WriteLine("Leap Year: " + leap);
            Console.WriteLine("Day of the Week: " + dt.DayOfWeek);
            Console.ReadLine();

        }
    }
}

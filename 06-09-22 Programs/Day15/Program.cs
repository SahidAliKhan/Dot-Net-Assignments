using Library1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.Empid = 101;
            //emp.Password = "abc@123";

            ATMdemo machine = new ATMdemo();
            machine.ShowMenu();
            Console.Read();
        }
    }
}

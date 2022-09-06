using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    public abstract class Person
    {
        public abstract void Work();
        public void workplace()
        {
            Console.WriteLine("Woking Location: Pune");
        }
    }
    public class Employee: Person
    {
        public override void Work()
        {
            Console.WriteLine("Employee: XYZ");
        }
    }
    public class Manager : Person
    {
        public override void Work()
        {
            Console.WriteLine("Manager: ABC");
        }
    }
    public class Clerk : Person
    {
        public override void Work()
        {
            Console.WriteLine("Clerk: ERS");
        }
    }
}

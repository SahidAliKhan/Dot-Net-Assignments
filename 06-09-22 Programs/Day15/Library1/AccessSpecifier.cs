using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    //public----->If the assembly(class library) code  is to be used across another(console app) assembly then the access specifiers to use the class must be public (classes and methods of classes)

    //private---- will only be accessible to that particular class only.
    //protected---allowed only for a child class
    //internal---- accessible only to the containing assembly
    //protected internal---allowed only for a child class and 
    //accessible only to the containing assembly
    public class Employee
    {
        public int Empid { get; set; }
        public string Password { private get; set; }
        private string p;

        protected int Salary { get; set; }
        internal string NickName { get; set; }
        protected internal string City { get; set; }
    }

    public class Manager : Employee
    {
        private void UseOfProtected()
        {
            base.Salary = 1000;
            base.City = "Pune";
        }
    }

    class Supervisor
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void MethodToInternalCall()
        {
            Employee emp = new Employee();



        }
    }
    interface IA1
    {
        int M1();

    }

    abstract class MyClass : Supervisor, IA1
    {
        private int i;
        private int MyProperty { get; set; }
        static int j;
        public int M1()
        {
            throw new NotImplementedException();
        }
        public sealed override void MethodToInternalCall()
        {

        }
    }
}

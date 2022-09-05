using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CustomerOperations : Customer
    {

        public new void InsertData(int custid, string cname, string city)
        {
            Console.WriteLine("NEW Method of Insert Data Called from Customer Operations Class");
        }
        //changing the functionality by reusing the  base  class functionlaity
        public override void InsertData(int rating, int custid, string city)
        {
            Console.WriteLine("Overridden Method of Insert Data Called from Customer Operations Class");

        }


    }
    public class SpecialCustomer : CustomerOperations
    {
        public sealed override void InsertData(int rating, int custid, string city)
        {
            Console.WriteLine("Sealed Overridden Method of Insert Data Called from Customer Operations Class");
        }
    }

    public class MyClass : SpecialCustomer
    {
        //public  override void InsertData(int rating, int custid, string city)
        //{
        //}
    }
}
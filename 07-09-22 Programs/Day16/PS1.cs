using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateLibrary;

namespace Day16
{
    public class PS1
    {
        static void Main(string[] args)
        {
            PS1Library a = new PS1Library();
            Delegate1 s = new Delegate1(a.FindStringLength);
            s.Invoke();
            Console.WriteLine("-------------------");

            Console.WriteLine("Enter a string to greet User: ");
            string n = Console.ReadLine();
            Delegate2 s1 = new Delegate2(a.Accept);
            s1(n);
            Console.WriteLine("-------------------");

            Console.WriteLine("Enter 2 nos to Add, Subtract and Multiply: ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());
            Delegate3[] s2 = new Delegate3[3] { a.Add, a.Sub, a.Mul};
            Delegate3 s3 = (Delegate3)MulticastDelegate.Combine(s2);
            s3(no1, no2);
            Console.WriteLine("-------------------");

            Products p = new Products();
            Console.WriteLine("Enter ProductID and Product Name: ");
            int pi = Convert.ToInt32(Console.ReadLine());
            string pn = Console.ReadLine();
            Delegate4 s4 = new Delegate4(p.ProductDetails);
            s4(pi, pn);
            Console.WriteLine("-------------------");

            Employee e = new Employee();
            Console.WriteLine("Enter your Joining Date:");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Delegate5 s5 = new Delegate5(e.CalculateYear);
            s5(date);
            Console.WriteLine("-------------------");

            Console.WriteLine("Enter 2 strings: ");
            string n5 = Console.ReadLine();
            string n6 = Console.ReadLine();
            Delegate6 s6 = new Delegate6(a.Concatenate);
            s6(n5,n6);
            Console.WriteLine("-------------------");

            Console.WriteLine("Enter a strings to make its 1st letter Uppercase: ");
            string n7 = Console.ReadLine();
            Delegate7 s7 = new Delegate7(a.Upper);
            s7(n7);


            Console.ReadLine();
        }
    }
}

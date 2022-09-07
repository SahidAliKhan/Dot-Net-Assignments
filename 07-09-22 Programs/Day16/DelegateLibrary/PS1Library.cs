using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLibrary
{
    public delegate void Delegate1();
    public delegate void Delegate2(string user);
    public delegate void Delegate3(int a, int b);
    public delegate void Delegate6(string user1, string user2);
    public delegate void Delegate7(string user);
    public class PS1Library
    {
        int c;
        public string name { get; set; }
        public void FindStringLength()
        {
            Console.WriteLine("Enter a string to find its length: ");
            name = Console.ReadLine();
            Console.WriteLine("Length of string is: " +name.Length);
        }
        public void Accept(string user)
        {
            Console.WriteLine("Hello " + user);
        }
        public void Add(int a, int b)
        {
            c = a + b;
           Console.WriteLine("Add : " +c);
        }
        public void Sub(int a, int b)
        {
            c = a - b;
            Console.WriteLine("Subtract : " +c);
        }
        public void Mul(int a, int b)
        {
            c = a * b;
            Console.WriteLine("Multiplty : " +c);
        }
        public void Concatenate(string user1, string user2)
        {
            Console.WriteLine("After Concatenating 2 strings: {0}{1}",user1,user2);
        }
        public void Upper(string user)
        {
            char[] a = user.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            Console.WriteLine(a);
        }
    }
}

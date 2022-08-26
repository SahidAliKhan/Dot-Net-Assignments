using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class PS4
    {
        static void Main(string[] args)
        {
            LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddFirst("Sahid");
            mylist.AddLast("Khan");
            mylist.AddAfter(mylist.First, "Ali");
            mylist.AddBefore(mylist.Last, "Hi");
            mylist.AddBefore(mylist.Last.Previous, "1830121");
            mylist.AddAfter(mylist.First.Next, "Bye");

            foreach (var item in mylist)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("--------After Removing 1830121:-------- ");
            mylist.Remove("1830121");
            foreach (var item in mylist)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("--------After Finding Bye and Replacing with Khan:-------- ");
            LinkedListNode<string> found = mylist.Find("Bye");
            found.Value = "Khan";
            foreach (var item in mylist)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;


namespace Day9
{
    internal class LinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> mylist = new LinkedList<int>();
            mylist.AddFirst(10);
            mylist.AddLast(100);
            mylist.AddAfter(mylist.First, 20);
            mylist.AddBefore(mylist.Last, 90);
            mylist.AddBefore(mylist.Last.Previous, 80);
            mylist.AddAfter(mylist.First.Next, 30);
            LinkedListNode<int> foundnode = mylist.Find(20);
            foundnode.Value = 200;

            mylist.Remove(mylist.First.Next);

            foreach (var item in mylist)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("---------------------");

            LinkedList<string> mylist1 = new LinkedList<string>();
            mylist1.AddFirst("Hi");
            mylist1.AddLast("Hello");
            mylist1.AddAfter(mylist1.First, "Hye");
            mylist1.AddBefore(mylist1.Last, "This");
            mylist1.AddBefore(mylist1.Last.Previous, "1830121");
            mylist1.AddAfter(mylist1.First.Next, "Bye");
            mylist1.RemoveFirst();

            foreach (var item in mylist1)
            {
                Console.WriteLine(item);

            }


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class PS3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue with array:");
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(30);
            q.Enqueue(45);
            q.Enqueue(112);
            q.Enqueue(92);
            
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("Queue elements with array:");
            int[] arr = q.ToArray();
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

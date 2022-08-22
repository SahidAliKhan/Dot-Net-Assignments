using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i=0; i< arr.Length; i++)
            {
                Console.Write("element - {0}:", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in array are:");
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------");


            int[] arr1 = new int[3];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("element - {0}:", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are:");
            foreach (var i2 in arr1)
            {
                Console.WriteLine(i2);
            }
            Console.WriteLine("The values store into the array in reverse are:");
            Array.Reverse(arr1);
            foreach (var i1 in arr1)
            {
                Console.WriteLine(i1);
            }
            Console.WriteLine("---------------------------");


            int n;
            Console.WriteLine("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} number of elements in the array :",n);
            int[] arr3 = new int[n];
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("element - {0}:", i);
                arr3[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (var i1 in arr3)
            {
                sum += i1;
            }
            Console.WriteLine("Sum of all elements stored in the array is : " +sum);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Array list of 5 elements:");
            ArrayList al = new ArrayList(5);
            al.Add(10);
            al.Add("Hello");
            al.Add(800);
            al.Add("Bye");
            al.Add(1100);
            foreach (var i4 in al)
            {
                Console.WriteLine(i4);
            }
            al.Remove(10);
            al.Remove("Bye");
            Console.WriteLine("After removing '10' and 'Bye':");
            foreach (var i4 in al)
            {
                Console.WriteLine(i4);
            }
            int cnt = al.Count;
            Console.WriteLine("Count of remaining elements: " +cnt);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Jagged Array:");
            int[][] jagged_arr = new int[4][];
            jagged_arr[0] = new int[4] { 1 , 2, 3, 4 };
            jagged_arr[1] = new int[] { 1, 2, 3};
            jagged_arr[2] = new int[] { 1, 2, 3, 4, 5, 6 };
            jagged_arr[3] = new int[] { 1, 2, 3 };
            for(int n1 = 0; n1 < jagged_arr.Length ; n1++)
            {
                Console.WriteLine("Classroom {0}: ",n1);
                for (int i5 = 0; i5 < jagged_arr[n1].Length ; i5++)
                {
                    Console.Write("Student " + jagged_arr[n1][i5] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------");

            Console.WriteLine("Stack:");
            Stack s = new Stack();
            s.Push(10);
            s.Push(13);
            s.Push(22);
            s.Push(45);
            s.Push(12);
            s.Push(121);
            Console.WriteLine("Before Pop:");
            foreach (var i7 in s)
            {
                Console.WriteLine(i7);
            }
            s.Pop();
            s.Pop();
            Console.WriteLine("After Pop:");
            foreach (var i6 in s)
            {
                Console.WriteLine(i6);
            }
            int cnt1 = s.Count;
            Console.WriteLine("Count of remaining elements: " + cnt1);
            Console.WriteLine("Top Most element on the Stack: " + s.Peek() );
            Console.WriteLine("---------------------------");

            Console.WriteLine("Queue:");
            Queue q = new Queue(5);
            q.Enqueue(10);
            q.Enqueue(30);
            q.Enqueue(45);
            q.Enqueue(112);
            q.Enqueue(92);
;
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("Q elements are:");
            foreach (var i7 in q)
            {
                Console.WriteLine(i7);
            }
            Console.WriteLine("Top Most element of the Queue: " + q.Peek());
            Console.WriteLine("---------------------------");

            Console.WriteLine("Hashtable:");
            Hashtable h = new Hashtable();
            h.Add(1, "Coffee");
            h.Add(2, "Tea");
            h.Add(3, "Mocktail");
            h.Add(4, "Cocktail");
            Console.WriteLine("Elements in Hashtable: ");
            foreach (DictionaryEntry i8 in h)
            {
                Console.WriteLine(i8.Key + " " + i8.Value);
            }
            h.Remove(3);
            Console.WriteLine("After removing 'Mocktail' in Hashtable:");
            foreach (DictionaryEntry i9 in h)
            {
                Console.WriteLine(i9.Key + " " + i9.Value);
            }
            Console.WriteLine("---------------------------");
            Console.ReadLine();
        }
    }
}

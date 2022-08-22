using System;
using System.Collections;
using System.Collections.Generic;

namespace Day5b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> f = new List<float>();
            f.Add(44.01f);
            f.Add(22.41f);
            f.Add(664.031f);
            f.Add(20.121f);
            Console.WriteLine("All float numbers in List:");
            foreach (var i1 in f)
            {
                Console.WriteLine(i1);
            }
            Console.WriteLine("Assending List:");
            f.Sort();
            foreach (var i1 in f)
            {
                Console.WriteLine(i1);
            }
            Console.WriteLine("Descending List:");
            f.Reverse();
            foreach (var i1 in f)
            {
                Console.WriteLine(i1);
            }
            Console.WriteLine("---------------------------");

            Console.WriteLine("Dictionary:");
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(4, "Coffee");
            d.Add(1, "Tea");
            d.Add(3, "Cocktail");
            d.Add(2, "Mocktail");
            foreach (var i in d)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine("---------------------------");

            Console.WriteLine("Sorted List:");
            SortedList <int, string> d1 = new SortedList<int, string>();
            d1.Add(4, "Coffee");
            d1.Add(1, "Tea");
            d1.Add(3, "Cocktail");
            d1.Add(2, "Mocktail");
            foreach (var i in d1)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine("---------------------------");

            int n;
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} elements:", n);
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("element-{0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = arr[0];
            int max = arr[0];
            foreach (var i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine("Maximum element:" +max);
            Console.WriteLine("Minimum element:" +min);
            Console.WriteLine("---------------------------");

            int [] arr2 = { 1, 3, 5, 200, 22, 2244, 213, 111 };
            Console.WriteLine("Elements greater than 100 are:");
            foreach (var i in arr2)
            {
                if (i > 100)
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.WriteLine("---------------------------");
            Console.ReadLine();
        }
    }
}

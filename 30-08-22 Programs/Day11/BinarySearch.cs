using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    class BinarySearchDemo
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];

            AcceptSortPrintSortedArray(arr);
            Console.WriteLine("Find element to search");
            int f = Convert.ToInt32(Console.ReadLine());

            BinarySearch(arr, 1, arr.Length, f);
            Console.Read();

        }

        internal static void BinarySearch(int[] a, int i, int j, int k)
        {

            int mid;
            while (i <= j)
            {
                mid = (i + j) / 2;
                if (a[mid] == k)
                {
                    Console.WriteLine("Value found at the middle =  " + mid);
                    break;
                }
                else if (a[mid] > k)
                {
                    j = mid - 1;
                    Console.WriteLine("Value found at =  " + j);
                    break;
                }
                else
                    i = mid + 1;
                Console.WriteLine("Value found at  =  " + i);
                break;
            }
        }

        internal static void AcceptSortPrintSortedArray(int[] arr)
        {
            int x, temp, t;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter element");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                t = i - 1;
                while (t >= 0 && temp < arr[i])
                {
                    arr[i + 1] = arr[t];
                    t--;
                }
                arr[t + 1] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

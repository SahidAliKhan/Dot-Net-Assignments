using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class MergeSortDemo
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 31, 41, 77, 25, 8, 32, 17, 40, 42 };
            Console.WriteLine("Before Sort :");
            printarray(arr);
            Console.WriteLine("-------");
            int end = arr.Length - 1;

            mergeSort(arr, 0, end);
            Console.WriteLine("after Sort :");
            printarray(arr);

            Console.ReadLine();
        }
        static void printarray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void mergeSort(int[] arr, int beg, int end)
        {
            if (beg < end)
            {
                int mid = (beg + end) / 2;
                mergeSort(arr, beg, mid);
                mergeSort(arr, mid + 1, end);
                MergeSubsets(arr, beg, mid, end);
            }
        }
        static void MergeSubsets(int[] arr, int beg, int mid, int end)
        {
            int i, j, k;
            int n1 = mid - beg + 1;
            int n2 = end - mid;

            int[] leftArr = new int[n1];
            int[] RightArr = new int[n2];

            for (int i1 = 0; i1 < n1; i1++)
            {
                leftArr[i1] = arr[beg + i1];
                for (int j1 = 0; j1 < n2; j1++)
                {
                    RightArr[j1] = arr[mid + 1 + j1];
                }
            }
            i = 0;
            j = 0;
            k = beg;

            while (i < n1 && j < n2)
            {
                if (leftArr[i] <= RightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = RightArr[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = RightArr[j];
                j++;
                k++;
            }

        }
    }
}

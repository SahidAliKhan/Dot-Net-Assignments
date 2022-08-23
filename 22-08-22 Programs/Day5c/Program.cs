using System;
using System.Linq;

namespace Day5c
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = { 1, 2, 3 };
            int m1 = arr1.Length;
            Console.Write("Possible ways are: ");
            Console.WriteLine(count(arr1, m1, 4));
            Console.WriteLine("----------------------");

            int n;
            Console.Write("Input:n = ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int m = 0, k = 0;
            int flag = 0, cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        m = i;
                        k = arr[i];
                        
                        flag = 1;
                        break;
                    }
                }
                cnt++;
                if (flag != 0)
                {
                    break;
                }
            }
            Console.WriteLine("Output: " + cnt);
            Console.WriteLine("----------------------");

            Console.ReadLine();
        }
        static int count(int[] S, int m1, int n1)
        {
            if (n1 == 0)
                return 1;
            if (n1 < 0)
                return 0;
            if (m1 <= 0)
                return 0;
            return count(S, m1 - 1, n1) +
                count(S, m1, n1 - S[m1 - 1]);
        }
    }
}
using System;

namespace Day5c
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3 };
            int m = arr.Length;
            Console.Write("Possible ways are: ");
            Console.Write(count(arr, m, 4));
            Console.ReadLine();
        }
        static int count(int[] S, int m, int n)
        {
            if (n == 0)
                return 1;
            if (n < 0)
                return 0;
            if (m <= 0)
                return 0;
            return count(S, m - 1, n) +
                count(S, m, n - S[m - 1]);
        }
    }
}
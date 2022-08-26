using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class MultiDimArrayDemo
    {
        static void Main(string[] args)
        {
            //int[] ar2 = new int[4];//Single Dimension
            //int[,] arr = new int[3, 3];//Multi-dimension/Rectangular Arrays
            //  int[][] arr1 = new int[3][];//Jagged
            //9 values
            //arr[0, 1] = 10;
            //arr[1, 2] = 20;
            //arr[2, 0] = 30;

            //int[,] arr = new int[3, 3] { { 100, 200, 300 }, { 1000, 2000, 3000 }, { 1, 2, 3 } };
            int[,] arr = { { 100, 200, 300 }, { 1000, 2000, 3000 }, { 1, 2, 3 } };

            //int len = arr.GetLength(0);
            //Console.WriteLine(len);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(" {0} ", arr[i, j]);
                }
                Console.WriteLine();
            }


            //for (int i = 0; i < 3; i++)//Row
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(arr[i,j] + "\t");
            //    }
            //    Console.WriteLine();

            //}
            Console.ReadLine();
        }
    }
}

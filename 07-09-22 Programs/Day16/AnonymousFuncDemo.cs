using DelegateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    public class AnonymousFuncDemo
    {
        static void Main(string[] args)
        {
            //public delegate int DoCalculations(int i, int j);
            Maths m = new Maths();
            DoCalculations del = new DoCalculations(m.add);
            int ans = del(100, 20);
            Console.WriteLine(ans);
            Console.WriteLine("------------------------");
            DoCalculations del1 = delegate (int i, int j)
            {
                int ans1 = i + i + j + j;
                return ans1;
            };

            int ans2 = del1(100, 20);
            Console.WriteLine(ans2);
            Console.WriteLine("--------");


            DoCalculations del2 = delegate (int no1, int no2)
            {
                int addans = no1 + no2;
                Console.WriteLine(addans);
                if (no2 != 0 && no2 > 0)
                {
                    int subans = no1 - no2;
                    Console.WriteLine(subans);
                }
                else
                {
                    Console.WriteLine("subtraction not possible");
                }
                int multans = no1 * no2;
                return multans;

            };
            int mAns = del2(20, 2);
            Console.WriteLine(mAns);

            Console.ReadKey();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17
{
    public class LambdaTypes
    {
        public delegate double SquareRoot(double number);
        static void Main(string[] args)
        {
            //Anonymous
            SquareRoot sqrt = (j) => { return Math.Sqrt(j); };
            double ans1 = sqrt(64);

            Console.WriteLine(ans1);


            Console.WriteLine("---------------------");

            //FunctionLambdaDemo Lambda
            Func<double, double> fun1 = (i) => Math.Sqrt(i);
            double ans = fun1(100);


            //Func lambda
            //public delegate int stringlen(string s);
            Func<string, int> fun2 = (s) => s.Length;
            int len = fun2("Hello");
            Console.WriteLine(len);
            Console.WriteLine("--------------------------------------");

            Func<string, string, string> concatString = (s1, s2) => string.Concat(s1, s2);
            string ts = concatString("Hello ", "World!!!");
            Console.WriteLine(ts);

            Console.WriteLine("----------------------------");

            Func<string, string> uppercase = (s1) => s1.ToUpper();

            string ucase = uppercase("hello");
            Console.WriteLine(ucase);


            Console.WriteLine("---------------------------------");
            //public delegate void DisplayTime();
            Console.WriteLine("Now the time = ");
            Action action = () => Console.WriteLine(DateTime.Now.ToLongTimeString());
            action();

            //    public delegate void GreetUser(string username);
            Console.WriteLine();
            Action<string> greet = (s1) => Console.WriteLine("Good morning " + s1);
            greet("Geeta!!");

            //    public delegate void GreetUser(string username,string pwd);
            Action<string, string> checkcredentials = (u, p) =>
            {
                if (u != "" && u == "bac" && p != "" && p == "abc@123")
                {
                    Console.WriteLine("U are logged in successfully");
                }
                else
                {
                    Console.WriteLine("Pls check userid/pwd");
                }
            };
            checkcredentials("bac", "aBc@123");
            Console.WriteLine("---------------------------");

            Predicate<string> p1 = (u) =>
            {
                bool status = false;
                if (u != "" && u == "bac")
                {
                    Console.WriteLine("U are logged in successfully");
                    status = true;
                }
                else
                {
                    Console.WriteLine("Pls check userid/pwd");

                }
                return status;
            };
            bool ans2 = p1("bac");
            Console.WriteLine(ans);

            Console.WriteLine("-------------------");
            Predicate<Tuple<string, string>> tuplePredicate = (v1) =>
            {
                bool status = false;
                if (v1.Item1 != "" && v1.Item1 == "bac" && v1.Item2 != "" && v1.Item2 == "abc@123")
                {
                    Console.WriteLine("U are logged in successfully");
                    status = true;
                }
                else
                {
                    Console.WriteLine("Pls check userid/pwd");
                }
                return status;
            };
            var data = Tuple.Create<string, string>("bac", "abc@123");
            bool userans = tuplePredicate(data);
            Console.WriteLine("USe of Tuples");
            Console.WriteLine(userans);


            Console.WriteLine();



            Console.WriteLine("--------------");


            List<int> list = new List<int>() { 1, 3, 2, 34, 2, 11, 1, 31, 45, 13, 5, 4 };
            List<int> newlist = list.Select(x => x * 2).ToList();
            foreach (var item in newlist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

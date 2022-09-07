using DelegateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    delegate bool isTeenAger(Student s);
    delegate bool isYounger(Student obj, int age);
    class PredicateLambda
    {
        static void Main(string[] args)
        {

            Student s3 = new Student { Studid = 1, Studname = "Ajay", Age = 10 };
            Student s1 = new Student { Studid = 2, Studname = "Vijay", Age = 18 };
            Student s2 = new Student { Studid = 3, Studname = "Sujay", Age = 19 };

            //isTeenAger ager = delegate (Student s) { return s.Age >= 13 && s.Age <= 19; };
            isTeenAger ager = (Student s) => s.Age >= 13 && s.Age <= 19;

            isTeenAger ager1 = s => s.Age >= 13 && s.Age <= 19;

            isTeenAger ager2 = (s) => { return s.Age >= 13 && s.Age <= 19; };

            isTeenAger ager3 = s => { return s.Age >= 13 && s.Age <= 19; };

            bool ans = ager(s3);
            Console.WriteLine(ans);
            Console.WriteLine("------");
            ans = ager(s1);
            Console.WriteLine(ans);
            Console.WriteLine("---------");
            ans = ager(s2);
            Console.WriteLine(ans);
            Console.WriteLine("----------");

            // isYounger del = delegate (Student sn, int a) { return a < 13; };
            isYounger del = (Student sn, int a) => { return a < 13; };

            bool isY = del(s2, s2.Age);
            if (isY)
            {
                Console.WriteLine(s2.Studid + " " + s2.Studname + " is younger and not teenager");
            }
            else
            {
                Console.WriteLine(s2.Studid + " " + s2.Studname + " is not younger and a teenager");

            }

            //List<int> list = new List<int>();
            //list.Add(2);
            //list.Add(23);
            //list.Add(45);
            //list.Add(100);
            //list.Add(10);
            //int fndValue = 2;
            //int ans=list.Find(x => x == fndValue);
            ////////////////////expression---false/true---boolean
            /////Predicate expression
            //Console.WriteLine(ans);
            //Console.WriteLine("-------");
            //List<int> evenList = new List<int>();
            //evenList=list.FindAll(x => x % 2 == 0);
            //foreach (var item in evenList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------");


            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Student
    {
        //static means no other copy of this variable will exists/
        //whatever are the changes will be made to this single cnt variable
        static int cnt;
        int i = 0;

        public static int studNo = 1;
        public void AddStudent()
        {
            //Can access static variable in non static method
            //Can access static variable in a static method also
            cnt = cnt + 1;
            Console.WriteLine("You added student no= " + cnt);
            //i = i + 1;
            //Console.WriteLine("Value of I= " + i);

        }
        //Default constructor can be called multiple times,
        //but static constructor is called only once in the lifetime of the class
        //static constructor is used for initialization purposes.
        //can use only static variables
        //For example: Setting the connectionstring
        static Student()
        {
            cnt = 0;
            Console.WriteLine(cnt);
            //Console.WriteLine(OtherVar);
            //Non stataic variable is not allowed in static constructor
            Console.WriteLine("Only called once in the lifetime of the class, before the first object is created....");
        }
        public Student()
        {
            Console.WriteLine("Default constructor called...");
        }
        int OtherVar = 100;
        public static void Initialize()
        {
            Console.WriteLine(cnt);
            Student s1 = new Student();
            s1.OtherVar += 1;
            Console.WriteLine(s1.OtherVar);
        }

        public void DeleteStudent()
        {
            cnt = cnt - 1;
            Console.WriteLine("You just deleted a student, now the total number of studnets u have =" + cnt);
        }

    }
}

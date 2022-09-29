using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityDAL;

namespace AdoNetDay5_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            //context.StudentsTable.Add(new Student { Rollno = 1, Studname = "Amit", City = "Pune", DOB = new DateTime(2022, 11, 11) });
            //context.StudentsTable.Add(new Student { Rollno = 2, Studname = "Aman", City = "Mumbai", DOB = new DateTime(2002, 08, 04) });
            //context.StudentsTable.Add(new Student { Rollno = 3, Studname = "Basu", City = "RKL", DOB = new DateTime(2010, 12, 01) });

            //context.CoursesTable.Add(new Course { CourseID = 1, CourseName = "Java", Fees = 10050 });

            context.EnrollmentsTable.Add(new Enrollments { EnrollmentID = 1, CourseID = 1, Rollno = 2 });
            context.SaveChanges();
            Console.WriteLine("done");
            Console.Read();
        }
    }
}

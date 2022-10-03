using BAL;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDay3PS
{
    public class Program
    {
        static void Main(string[] args)
        {
            CourseHelper helper = new CourseHelper();
            CourseBAL c = new CourseBAL();

            StudentHelper h = new StudentHelper();
            StudentBAL s = new StudentBAL();

            Console.WriteLine("Institute Management System");
            Console.WriteLine("---------------------------------");
            repeat:
            Console.WriteLine("Menu");
            Console.WriteLine("---------");
            Console.WriteLine("1.Insert Course \n2.Update Course \n3.Find Course \n4.Delete Course \n5.Show All Courses \n6.Insert Student \n7.Update Student \n8.Find Student \n9.Delete Student \n10. Show All Students");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Enter Course ID:");
                    c.CourseID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Course Name:");
                    c.CourseName = Console.ReadLine().Trim();

                    Console.WriteLine("Enter Dept ID:");
                    c.DeptID = Console.ReadLine().Trim();

                    Console.WriteLine("Enter Duration");
                    c.Duration = Convert.ToInt32(Console.ReadLine());

                    bool queryStatus = helper.AddNewCourse(c);
                    if (queryStatus)
                    {
                        Console.WriteLine("Course added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }

                    break;
                case 2:
                    Console.WriteLine("Enter Original Course ID:");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Course ID:");
                    c.CourseID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Course Name:");
                    c.CourseName = Console.ReadLine().Trim();

                    Console.WriteLine("Enter Dept ID:");
                    c.DeptID = Console.ReadLine().Trim();

                    Console.WriteLine("Enter Duration");
                    c.Duration = Convert.ToInt32(Console.ReadLine());

                    queryStatus = helper.EditEmployeeData(id, c);
                    if (queryStatus)
                    {
                        Console.WriteLine("Course updated successfully....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }

                    break;
                case 3:

                    Console.WriteLine("Enter Course ID:");
                    c.CourseID = Convert.ToInt32(Console.ReadLine());

                    CourseBAL data = helper.LocateCourse(c.CourseID);
                    if (data != null)
                    {
                        Console.WriteLine("Following are the details:");
                        Console.WriteLine(data.CourseID);
                        Console.WriteLine(data.CourseName);
                        Console.WriteLine(data.DeptID);
                        Console.WriteLine(data.Duration);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Course ID...");
                    }

                    break;
                case 4:
                    Console.WriteLine("Enter Course ID to delete:");
                    c.CourseID = Convert.ToInt32(Console.ReadLine());
                    queryStatus = helper.RemoveEmployeeData(c.CourseID);
                    if (queryStatus)
                    {
                        Console.WriteLine("Course Deleted successfully...");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 5:
                    List<CourseBAL> list = new List<CourseBAL>();
                    list = helper.CourseList();

                    Console.WriteLine("CourseID" + "    " + "Course Name" + "    " + "DeptID" + "    " + "Duration(hrs)");

                    foreach (var item in list)
                    {
                        Console.WriteLine(item.CourseID + "           " + item.CourseName + "             " + item.DeptID + "       " + item.Duration);
                        Console.WriteLine();
                    }
                    break;

                case 6:
                    Console.WriteLine("Enter Student ID:");
                    s.StudentID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Student Name:");
                    s.StudentName = Console.ReadLine().Trim();

                    Console.WriteLine("Enter Course ID:");
                    s.CourseID = Convert.ToInt32(Console.ReadLine());

                    bool queryStatuss = h.AddNewStudent(s);
                    if (queryStatuss)
                    {
                        Console.WriteLine("Student added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 7:
                    Console.WriteLine("Enter Original Course ID:");
                    int id1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Student ID:");
                    s.StudentID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Student Name:");
                    s.StudentName = Console.ReadLine().Trim();

                    Console.WriteLine("Enter Course ID:");
                    s.CourseID = Convert.ToInt32(Console.ReadLine());

                    queryStatus = h.EditStudentData(id1, s);
                    if (queryStatus)
                    {
                        Console.WriteLine("Student updated successfully....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }

                    break;
                case 8:
                    Console.WriteLine("Enter Student ID:");
                    s.StudentID = Convert.ToInt32(Console.ReadLine());

                    StudentBAL data1 = h.LocateStudent(s.StudentID);
                    if (data1 != null)
                    {
                        Console.WriteLine("Following are the details:");
                        
                        Console.WriteLine(data1.StudentID);
                        Console.WriteLine(data1.StudentName);
                        Console.WriteLine(data1.CourseID);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Student ID...");
                    }
                    break;
                case 9:
                    Console.WriteLine("Enter Student ID to delete:");
                    s.StudentID = Convert.ToInt32(Console.ReadLine());
                    queryStatus = h.RemoveStudentData(s.StudentID);
                    if (queryStatus)
                    {
                        Console.WriteLine("Student Deleted successfully...");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }

                    break;
                case 10:

                    List<StudentBAL> list1 = new List<StudentBAL>();
                    list1 = h.StudentList();

                    Console.WriteLine("StudentID" + "    " + "Student Name" + "    " + "CourseID");

                    foreach (var item in list1)
                    {
                        Console.WriteLine(item.StudentID+ "           " + item.StudentName + "             " + item.CourseID);
                        Console.WriteLine();
                    }

                    break;


                default:
                    Console.WriteLine("Invalid Input...");
                    break;
            }

            goto repeat;
            Console.ReadLine();
        }
    }
}

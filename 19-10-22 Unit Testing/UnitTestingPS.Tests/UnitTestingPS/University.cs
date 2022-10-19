using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPS
{
    public enum CourseName
    {
        AIML, DotNet, Java
    }
    public class Student
    {
        public int RollNo { get; set; }
        public string StudName { get; set; }
        public CourseName CourseName { get; set; }
    }
    public class Enrollments
    {
        public int EnrollNo { get; set; }
        public int Fees { get; set; }
    }

    public class StudentEnrollment
    {
        public bool EnrollStudents(Student s, Enrollments e)
        {
            if(e.Fees>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

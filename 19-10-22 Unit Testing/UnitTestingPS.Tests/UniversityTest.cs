using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingPS;

namespace UnitTestingPS.Tests
{
    [TestFixture]
    public class UniversityTest
    {
        [TestCase]
        public void CheckFees()
        {
            Student s1 = new Student();
            s1.RollNo = 10;
            s1.StudName = "Ramy";
            s1.CourseName = CourseName.DotNet;

            Enrollments e = new Enrollments();
            e.EnrollNo = 11;
            e.Fees = 1000;
            StudentEnrollment s = new StudentEnrollment();
            bool ans = s.EnrollStudents(s1,e);
            Assert.IsTrue(ans);
        }
    }
}

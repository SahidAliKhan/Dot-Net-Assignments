using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BAL;

namespace Helper
{
    public class CourseHelper
    {
        CourseDAL dal = null;
        public CourseHelper()
        {
            dal = new CourseDAL();
        }
        public bool AddNewCourse(CourseBAL c)
        {
            return dal.InsertCourse(c);
        }
        public CourseBAL LocateCourse(int c)
        {
            return dal.FindCourse(c);
        }

        public List<CourseBAL> CourseList()
        {
            return dal.ShowAllCourses();
        }

        public bool RemoveEmployeeData(int c)
        {
            return dal.DeleteCourse(c);
        }

        public bool EditEmployeeData(int id, CourseBAL c)
        {
            return dal.UpdateCourse(id, c);
        }
    }

    public class StudentHelper
    {
        StudentDAL dal = null;
        public StudentHelper()
        {
            dal = new StudentDAL();
        }
        public bool AddNewStudent(StudentBAL c)
        {
            return dal.InsertStudent(c);
        }
        public StudentBAL LocateStudent(int c)
        {
            return dal.FindStudent(c);
        }

        public List<StudentBAL> StudentList()
        {
            return dal.ShowAllStudent();
        }

        public bool RemoveStudentData(int c)
        {
            return dal.DeleteStudent(c);
        }

        public bool EditStudentData(int id, StudentBAL c)
        {
            return dal.UpdateStudent(id, c);
        }
    }
}

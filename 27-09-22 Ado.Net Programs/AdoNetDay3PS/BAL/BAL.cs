using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class CourseBAL
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string DeptID { get; set; }
        public int Duration { get; set; }
    }

    public class StudentBAL
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int CourseID { get; set; }
    }
}

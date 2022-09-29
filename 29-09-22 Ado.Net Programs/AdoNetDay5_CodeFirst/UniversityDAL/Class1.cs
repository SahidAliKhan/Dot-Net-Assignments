using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDAL
{
    public class Student
    {
        [Key]
        [Required]
        public int Rollno { get; set; }
        [MaxLength(20, ErrorMessage = "Not allowed above 20 chars")]
        [MinLength(2, ErrorMessage = "Not allowed below 2 chars")]
        public string Studname { get; set; }

        public string City { get; set; }
        //1 Student---M Enrollments
        public virtual ICollection<Enrollments> enrollments { get; set; }
        //  [DataType(DataType.DateTime,ErrorMessage ="not valid date")]
        public DateTime DOB { get; set; }

    }

    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        public string CourseName { get; set; }

        [Range(10000, 200000, ErrorMessage = "not in range")]
        public int Fees { get; set; }
        //1 course---- M enrollments
        public virtual ICollection<Enrollments> enrollments { get; set; }

    }

    public class Enrollments
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int Rollno { get; set; }

        [ForeignKey("CourseID")]
        public virtual Course CourseDetails { get; set; }
        [ForeignKey("Rollno")]
        public virtual Student StudentDetails { get; set; }


    }

    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
            //createdatabase if not exists
            //drop create always
            //drop create if model changes

            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }

        public virtual DbSet<Student> StudentsTable { get; set; }
        public virtual DbSet<Course> CoursesTable { get; set; }
        public virtual DbSet<Enrollments> EnrollmentsTable { get; set; }

    }
}

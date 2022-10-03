using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BAL;

namespace DAL
{
    public class CourseDAL
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public CourseDAL()
        {
            ds = new DataSet();
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["IMS"].ConnectionString); 
        }
        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from Course", cn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "Course");                                   
            DataTable dt_empdata = ds.Tables["Course"];
            return dt_empdata;
        }
        public bool InsertCourse(CourseBAL c)
        {
            DataTable dt_empdata = Connect();

            DataRow drow = ds.Tables["Course"].NewRow();
            drow["CourseID"] = c.CourseID;
            drow["CourseName"] = c.CourseName;
            drow["DeptID"] = c.DeptID;
            drow["Duration"] = c.Duration;

            ds.Tables["Course"].Rows.Add(drow);
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["Course"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateCourse(int courseid, CourseBAL c)
        {
            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["Course"].Rows.Find(courseid);


            drow["CourseID"] = c.CourseID;
            drow["CourseName"] = c.CourseName;
            drow["DeptID"] = c.DeptID;
            drow["Duration"] = c.Duration;

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["Course"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }

        public bool DeleteCourse(int courseid)
        {

            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["Course"].Rows.Find(courseid);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["Course"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }

        public CourseBAL FindCourse(int courseid)
        {
            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["Course"].Rows.Find(courseid);
            CourseBAL c = new CourseBAL();
            c.CourseID = Convert.ToInt32(drow["CourseID"]);
            c.CourseName = drow["CourseName"].ToString();
            c.DeptID = drow["DeptID"].ToString();
            c.Duration = Convert.ToInt32(drow["Duration"]);
            return c;
        }

        public List<CourseBAL> ShowAllCourses()
        {
            DataTable dt_empdata = Connect();
            List<CourseBAL> c = new List<CourseBAL>();
            for (int i = 0; i < dt_empdata.Rows.Count; i++)
            {
                DataRow drow = dt_empdata.Rows[i];
                CourseBAL c1 = new CourseBAL();
                c1.CourseID = Convert.ToInt32(drow["CourseID"]);
                c1.CourseName = drow["CourseName"].ToString();
                c1.DeptID = drow["DeptID"].ToString();
                c1.Duration = Convert.ToInt32(drow["Duration"]);
                c.Add(c1);

            }
            return c;
        }
    }

    public class StudentDAL
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public StudentDAL()
        {
            ds = new DataSet();
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["IMS"].ConnectionString);
        }
        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from Student", cn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "Student");
            DataTable dt_empdata = ds.Tables["Student"];
            return dt_empdata;
        }
        public bool InsertStudent(StudentBAL s)
        {
            DataTable dt_empdata = Connect();

            DataRow drow = ds.Tables["Student"].NewRow();
            drow["StudentID"] = s.StudentID;
            drow["StudentName"] = s.StudentName;
            drow["CourseID"] = s.CourseID;

            ds.Tables["Student"].Rows.Add(drow);
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["Student"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateStudent(int id, StudentBAL s)
        {
            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["Student"].Rows.Find(id);

            drow["StudentID"] = s.StudentID;
            drow["StudentName"] = s.StudentName;
            drow["CourseID"] = s.CourseID;

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["Student"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }

        public bool DeleteStudent(int id)
        {

            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["Student"].Rows.Find(id);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["Student"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }

        public StudentBAL FindStudent(int id)
        {
            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["Student"].Rows.Find(id);
            StudentBAL c = new StudentBAL();
            c.StudentID = Convert.ToInt32(drow["StudentID"]);
            c.StudentName = drow["StudentName"].ToString();
            c.CourseID = Convert.ToInt32(drow["CourseID"]);
            return c;
        }

        public List<StudentBAL> ShowAllStudent()
        {
            DataTable dt_empdata = Connect();
            List<StudentBAL> c = new List<StudentBAL>();
            for (int i = 0; i < dt_empdata.Rows.Count; i++)
            {
                DataRow drow = dt_empdata.Rows[i];
                StudentBAL c1 = new StudentBAL();

                c1.StudentID= Convert.ToInt32(drow["StudentID"]);
                c1.StudentName = drow["StudentName"].ToString();
                c1.CourseID = Convert.ToInt32(drow["CourseID"]);
                c.Add(c1);
            }
            return c;
        }

    }
}

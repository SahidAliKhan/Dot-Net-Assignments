using BusinessLogicLayerLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
namespace DataAccessLayerLibrary
{
    public class Employee_DAL
    {
        /// <summary>
        /// Insert into employee table the data for firstname,lastname,title,birthdate
        /// Empid is identity field so not inserting
        /// </summary>
        /// <param name="employee"></param>
        public bool InsertEmployee(Employee_BAL employee)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into employees(lastname,firstname,title,birthdate) values(@lastname,@firstname,@title,@birthdate)", cn);
            cmdInsert.Parameters.AddWithValue("@lastname", employee.LastName);
            cmdInsert.Parameters.AddWithValue("@firstname", employee.FirstName);
            cmdInsert.Parameters.AddWithValue("@title", employee.Title);
            cmdInsert.Parameters.AddWithValue("@birthdate", employee.BirthDate);
            cn.Open();
            int i = cmdInsert.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;
        }
        public int EmployeeCount()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            // SqlCommand cmd1 = new SqlCommand("select * from [dbo].[fn_EmpCount]()", cn);
            // cn.Open();
            //SqlDataReader dr=cmd1.ExecuteReader();
            // int cnt = 0;
            // if (dr.HasRows)
            // {
            //     dr.Read();
            //    cnt=Convert.ToInt32(dr[0]);

            // }
            // return cnt;
            SqlCommand cmd = new SqlCommand("select count(*) from employees", cn);
            cn.Open();

            int cnt = (int)cmd.ExecuteScalar();
            cn.Close();
            cn.Dispose();
            return cnt;
        }
        public bool UpdateEmployee(Employee_BAL employee)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            SqlCommand cmdUpdate = new SqlCommand("[dbo].[sp_UpdateEmployee]", cn);

            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUpdate.Parameters.AddWithValue("@p_empid", employee.EmployeeID);
            cmdUpdate.Parameters.AddWithValue("@p_lname", employee.LastName);
            cmdUpdate.Parameters.AddWithValue("@p_fname", employee.FirstName);
            cmdUpdate.Parameters.AddWithValue("@p_title", employee.Title);
            cmdUpdate.Parameters.AddWithValue("@p_birthdate", employee.BirthDate);
            cn.Open();
            int i = cmdUpdate.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;
        }
        public bool DeleteEmployee(int employee_id)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            SqlCommand cmdDelete = new SqlCommand("[dbo].[sp_DeleteEmployee]", cn);
            cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;
            cmdDelete.Parameters.AddWithValue("@p_empid", employee_id);
            cn.Open();
            int i = cmdDelete.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;
        }
        public Employee_BAL FindEmployee(int empid)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);
            SqlCommand cmdSelect = new SqlCommand("[dbo].[sp_FindEmployee]", cn);
            cmdSelect.CommandType = System.Data.CommandType.StoredProcedure;
            cmdSelect.Parameters.AddWithValue("@p_empid", empid);
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@p_firstname";
            p1.SqlDbType = System.Data.SqlDbType.NVarChar;
            p1.Size = 10;
            p1.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@p_lastname";
            p2.SqlDbType = System.Data.SqlDbType.NVarChar;
            p2.Size = 20;
            p2.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@p_title";
            p3.SqlDbType = System.Data.SqlDbType.NVarChar;
            p3.Size = 30;
            p3.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@p_bdate";
            p4.SqlDbType = System.Data.SqlDbType.DateTime;
            p4.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p4);

            cn.Open();
            cmdSelect.ExecuteNonQuery();

            Employee_BAL empfound = new Employee_BAL();

            empfound.FirstName = p1.Value.ToString();
            empfound.LastName = p2.Value.ToString();
            empfound.Title = p3.Value.ToString();
            empfound.BirthDate = Convert.ToDateTime(p4.Value);
            cn.Close();
            cn.Dispose();
            return empfound;
        }
        public void FindEmployee(int empid, out Employee_BAL empdata)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);
            SqlCommand cmdSelect = new SqlCommand("[dbo].[sp_FindEmployee]", cn);
            cmdSelect.CommandType = System.Data.CommandType.StoredProcedure;
            cmdSelect.Parameters.AddWithValue("@p_empid", empid);
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@p_firstname";
            p1.SqlDbType = System.Data.SqlDbType.NVarChar;
            p1.Size = 10;
            p1.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@p_lastname";
            p2.SqlDbType = System.Data.SqlDbType.NVarChar;
            p2.Size = 20;
            p2.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@p_title";
            p3.SqlDbType = System.Data.SqlDbType.NVarChar;
            p3.Size = 30;
            p3.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@p_bdate";
            p4.SqlDbType = System.Data.SqlDbType.DateTime;
            p4.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p4);

            cn.Open();
            cmdSelect.ExecuteNonQuery();

            empdata = new Employee_BAL();

            empdata.FirstName = p1.Value.ToString();
            empdata.LastName = p2.Value.ToString();
            empdata.Title = p3.Value.ToString();
            empdata.BirthDate = Convert.ToDateTime(p4.Value);
            Employee_BAL edata = new Employee_BAL();
            edata = empdata;

            cn.Close();
            cn.Dispose();
        }
        public List<Employee_BAL> EmployeeList()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            SqlCommand cmdlist = new SqlCommand("select * from  [dbo].[fn_Emplist]()", cn);
            cn.Open();
            SqlDataReader dr = cmdlist.ExecuteReader();
            List<Employee_BAL> emplist = new List<Employee_BAL>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Employee_BAL bal = new Employee_BAL();
                    bal.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                    bal.FirstName = dr["FirstName"].ToString();
                    bal.LastName = dr["LastName"].ToString();
                    bal.Title = dr["Title"].ToString();
                    bal.BirthDate = Convert.ToDateTime(dr["BirthDate"]);
                    emplist.Add(bal);
                }
            }
            cn.Close();
            cn.Dispose();
            return emplist;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Book_BAL;
using static Book_BAL.BLL;
using System.ComponentModel;

namespace Book_DAL
{
    public class DAL
    {
        public bool InsertBook(BLL book)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into Book(book_no,book_name,author,cost,category) values(@bookno,@bookname,@author,@cost,@category)", cn);

            cmdInsert.Parameters.AddWithValue("@bookno", book.Book_No);
            cmdInsert.Parameters.AddWithValue("@bookname", book.Book_Name);
            cmdInsert.Parameters.AddWithValue("@author", book.Author);
            cmdInsert.Parameters.AddWithValue("@cost", book.Cost);
            cmdInsert.Parameters.AddWithValue("@category", book.Category);
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
        public bool InsertMember(MemberBLL m)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into Member(member_id,member_name) values(@memberid,@membername)", cn);
            cmdInsert.Parameters.AddWithValue("@memberid", m.Member_ID);
            cmdInsert.Parameters.AddWithValue("@membername", m.Member_Name);
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

        public bool UpdateMember(MemberBLL m)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);

            SqlCommand cmdUpdate = new SqlCommand("[dbo].sp_UpdateMember", cn);

            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUpdate.Parameters.AddWithValue("@p_memberid", m.Member_ID);
            cmdUpdate.Parameters.AddWithValue("@p_membername", m.Member_Name);
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
        public bool InsertUser(UserBLL u)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into Users(Userid,Password) values(@userid,@password)", cn);
            cmdInsert.Parameters.AddWithValue("@userid", u.User_ID);
            cmdInsert.Parameters.AddWithValue("@password", u.Password);
            cn.Open();
            int i = cmdInsert.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();
            cn.Dispose();
            return status;
        }
        public List<BLL> BookList()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);

            SqlCommand cmdlist = new SqlCommand("select * from            [dbo].[BookList]()", cn);
            cn.Open();
            SqlDataReader dr = cmdlist.ExecuteReader();
            List<BLL> BookList = new List<BLL>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    BLL bal = new BLL();
                    bal.Book_No = Convert.ToInt32(dr["Book_No"]);
                    bal.Book_Name = dr["Book_Name"].ToString();
                    bal.Author = dr["Author"].ToString();
                    bal.Cost = Convert.ToInt32(dr["Cost"]);
                    bal.Category = dr["Category"].ToString();
                    BookList.Add(bal);
                }
            }
            cn.Close();
            cn.Dispose();
            return BookList;
        }

        public void Users(UserBLL user, BLL Books)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);
            SqlCommand Logincmd = new SqlCommand("[dbo].sp_FindUsers", con);
            Logincmd.CommandType = System.Data.CommandType.StoredProcedure;
            Logincmd.Parameters.AddWithValue("@id", user.User_ID);
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@id";
            p1.SqlDbType = System.Data.SqlDbType.VarChar;
            p1.Size = 10;
            p1.Direction = System.Data.ParameterDirection.Input;

            Logincmd.Parameters.AddWithValue("@pass", user.Password);
            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@pass";
            p2.SqlDbType = System.Data.SqlDbType.VarChar;
            p2.Size = 20;
            p2.Direction = System.Data.ParameterDirection.Input;

            Logincmd.Parameters.AddWithValue("@book_no", Books.Book_No);
            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@book_no";
            p3.SqlDbType = System.Data.SqlDbType.Int;
            p3.Size = 5;
            p3.Direction = System.Data.ParameterDirection.Output;

            Logincmd.Parameters.AddWithValue("@book_name", Books.Book_Name);
            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@book_name";
            p4.SqlDbType = System.Data.SqlDbType.VarChar;
            p4.Size = 30;
            p4.Direction = System.Data.ParameterDirection.Output;

            Logincmd.Parameters.AddWithValue("@Author", Books.Author);
            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@Author";
            p5.SqlDbType = System.Data.SqlDbType.VarChar;
            p5.Size = 30;
            p5.Direction = System.Data.ParameterDirection.Output;

            Logincmd.Parameters.AddWithValue("@cost", Books.Cost);
            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@cost";
            p6.SqlDbType = System.Data.SqlDbType.Int;
            p6.Size = 5;
            p6.Direction = System.Data.ParameterDirection.Output;

            Logincmd.Parameters.AddWithValue("@category", Books.Category);
            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@category";
            p7.SqlDbType = System.Data.SqlDbType.VarChar;
            p7.Size = 10;
            p7.Direction = System.Data.ParameterDirection.Output;

        }

        public List<BLL> booklist(UserBLL user)
        {
            List<BLL> Booklist = new List<BLL>();
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);
                SqlCommand cmdlist = new SqlCommand("select * from  [dbo].fn_Booklist(@id,@pass)", con);
                cmdlist.Parameters.AddWithValue("@id", user.User_ID);
                cmdlist.Parameters.AddWithValue("@pass", user.Password);
                con.Open();
                SqlDataReader dr = cmdlist.ExecuteReader();

                if (dr.HasRows)
                {
                    Console.WriteLine("Logged in sucessfully");
                    Console.WriteLine("The List of Books are here");
                    while (dr.Read())
                    {

                        BLL Books = new BLL();
                        Books.Book_No = Convert.ToInt32(dr[0]);
                        Books.Book_Name = Convert.ToString(dr[1]);
                        Books.Author = Convert.ToString(dr[2]);
                        Books.Cost = Convert.ToInt32(dr[3]);
                        Books.Category = Convert.ToString(dr[4]);
                        Booklist.Add(Books);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Username or Password");
                }
                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Booklist;
        }

        public void BorrowBooks()
        {
            Issue issue1 = new Issue();
            try
            {
                Console.WriteLine("Enter the Book_Id to Borrrow");
                BLL books = new BLL();
                books.Book_No = Convert.ToInt32(Console.ReadLine());
                issue1.Book_No = books.Book_No;
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);
                SqlCommand Issuecommand = new SqlCommand("Insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date," +
                    "Return_Date,Comments) Values(@id,@bookno,@memberid,@isedate,@redate,@comments)", con);
                Console.WriteLine("Enter Library Issue Id");
                issue1.Lib_Issue_Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Member Id");
                issue1.Member_Id = Convert.ToInt32(Console.ReadLine());
                issue1.Issue_Date = DateTime.Now;
                issue1.Return_Date = issue1.Issue_Date.AddDays(15);
                issue1.Comments = "Borrowed";
                Issuecommand.Parameters.AddWithValue("@id", issue1.Lib_Issue_Id);
                Issuecommand.Parameters.AddWithValue("@bookno", issue1.Book_No);
                Issuecommand.Parameters.AddWithValue("@memberid", issue1.Member_Id);
                Issuecommand.Parameters.AddWithValue("@isedate", issue1.Issue_Date);
                Issuecommand.Parameters.AddWithValue("@redate", issue1.Return_Date);
                Issuecommand.Parameters.AddWithValue("@comments", issue1.Comments);
                con.Open();
                Issuecommand.ExecuteNonQuery();
                con.Close();
                con.Dispose();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void returnbook()
        {
            try
            {
                Issue issue1 = new Issue();
                Console.WriteLine("Enter the Issue Id");
                issue1.Lib_Issue_Id = Convert.ToInt32(Console.ReadLine());
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);
                SqlCommand returnb = new SqlCommand("[dbo].[change_return_statuss]", con);
                returnb.CommandType = System.Data.CommandType.StoredProcedure;
                returnb.Parameters.AddWithValue("@id", issue1.Lib_Issue_Id);
                con.Open();
                returnb.ExecuteNonQuery();
                con.Close();
                con.Dispose();



            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
        }

    }
}

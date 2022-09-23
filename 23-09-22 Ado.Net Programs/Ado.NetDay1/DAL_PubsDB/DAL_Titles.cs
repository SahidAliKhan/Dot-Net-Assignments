using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;
namespace DAL_PubsDB
{
    public class DAL_Titles
    {
        public List<BL_Titles> ShowAllBooks()
        {
            string connectionString = "Data Source=SAHID\\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand("select * from  titles where pub_id='" + bl.PubId + "'", cn);

            SqlCommand cmd = new SqlCommand("select * from titles", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            //reads the data--- forward only direction 
            //dr.Read();//first row---
            //Multiple columns---- 

            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["title_id"]);
            //    Console.WriteLine(dr["title"]);
            //    Console.WriteLine(dr["type"]);
            //    Console.WriteLine(dr["pub_id"]);
            //    Console.WriteLine(dr["price"]);
            //    Console.WriteLine("-----------------------");
            //}
            List<BL_Titles> books = new List<BL_Titles>();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    BL_Titles title = new BL_Titles();
                    title.Title_id = dr[0].ToString();
                    title.TitleName = dr[1].ToString();
                    title.PubId = dr[3].ToString();

                    books.Add(title);
                    //Console.WriteLine(dr[0]);
                    //Console.WriteLine(dr[1]);
                    //Console.WriteLine(dr[2]);
                    //Console.WriteLine(dr[3]);
                    //Console.WriteLine(dr[4]);
                    //Console.WriteLine("-----------------------");
                }
            }
            else
            {
                Console.WriteLine("No records found");
            }
            cn.Close();
            return books;

        }

    }
}

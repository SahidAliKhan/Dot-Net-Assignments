using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessLogicLibrary;
using HelperLibrary;
namespace AdoNetDay1
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
              //Console.WriteLine("enter the publication id to search the books for:");
                //BL_Titles bl = new BL_Titles();
                //bl.PubId = Console.ReadLine();

                Helper_Titles titles = new Helper_Titles();

                List<BL_Titles> books = new List<BL_Titles>();

                books = titles.Get_Titles();

                foreach (var item in books)
                {
                    Console.WriteLine(item.PubId);
                    Console.WriteLine(item.TitleName);
                    Console.WriteLine(item.PubId);

                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}

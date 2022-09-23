using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;
using DAL_PubsDB;
namespace HelperLibrary
{
    public class Helper_Titles
    {
        public List<BL_Titles> Get_Titles()
        {
            DAL_Titles titles = new DAL_Titles();
            List<BL_Titles> booksList = new List<BL_Titles>();
            booksList = titles.ShowAllBooks();
            return booksList;


        }

    }
}

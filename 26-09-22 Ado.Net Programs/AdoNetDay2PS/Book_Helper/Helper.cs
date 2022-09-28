using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_BAL;
using Book_DAL;
using Book_Helper;
using static Book_BAL.BLL;

namespace Book_Helper
{
    public class Helper
    {
        DAL dal = null;
        public Helper()
        {
            dal = new DAL();
        }

        public bool AddBook(BLL book)
        {
            return dal.InsertBook(book);

        }
        public bool AddMember(MemberBLL m)
        {
            return dal.InsertMember(m);

        }
        public bool EditMember(MemberBLL m)
        {
            return dal.UpdateMember(m);
        }
        public bool AddUser(UserBLL u)
        {
            return dal.InsertUser(u);

        }
        public List<BLL> ShowBookList()
        {
            return dal.BookList();
        }

        public void Login(UserBLL User)
        {
            DAL Library = new DAL();
            List<BLL> BookL = Library.booklist(User);

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (BLL LibraryL in BookL)
            {
                Console.WriteLine("Book_No: " + LibraryL.Book_No);
                Console.WriteLine("Book_Name: " + LibraryL.Book_Name);
                Console.WriteLine("Book Author: " + LibraryL.Author);
                Console.WriteLine("Book_Price: " + LibraryL.Cost);
                Console.WriteLine("Book_Category: " + LibraryL.Category);
                Console.WriteLine();
            }
            Console.WriteLine("Do you want to Borrow Books (Y/N)? ");
            Char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'Y' || ch == 'y')
            {
                Library.BorrowBooks();
                Console.WriteLine("Book issued Now");
            }

        }

        public void ReturnBooks()
        {
            DAL Library = new DAL();
            Library.returnbook();
            Console.WriteLine("Book returned Sucessfully");

        }



    }
}

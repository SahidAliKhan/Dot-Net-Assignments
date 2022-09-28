using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BookBAL
    {
        public int Book_No { get; set; }
        public string Book_Name { get; set; }
        public string Author { get; set; }
        public int Cost { get; set; }
        public string Category { get; set; }
    }

    public class BookOperation 
    {
        public List<BookBAL> ShowAllBooks()
        {
            LibraryDB context = new LibraryDB();

            List<Book> clist = context.Books.ToList();
            List<BookBAL> cblist = new List<BookBAL>();
            foreach (var item in clist)
            {
                cblist.Add(new BookBAL {Book_No = (int)item.Book_No, Book_Name = item.Book_Name, Author = item.Author, Cost = (int)item.Cost, Category = item.Category });

            }
            return cblist;
        }

        public void InsertBook(BookBAL bal)
        {
            LibraryDB context = new LibraryDB();
            Book c = new Book();
            c.Book_No = bal.Book_No;
            c.Book_Name = bal.Book_Name;
            c.Author = bal.Author;
            c.Cost = bal.Cost;
            c.Category = bal.Category;

            context.Books.Add(c);
            context.SaveChanges();
        }

        public void DeleteBook(int BookNo)
        {

            LibraryDB context = new LibraryDB();
            context.sp_deletebook(BookNo);
            context.SaveChanges();
        }

        public void UpdateBook(BookBAL bal)
        {
            LibraryDB context = new LibraryDB();
            List<Book> customers = context.Books.ToList();
            Book obj = customers.Find(id => id.Book_No == bal.Book_No);
            obj.Book_Name = bal.Book_Name;
            obj.Author = bal.Author;
            obj.Cost = bal.Cost;
            obj.Category = bal.Category;
            context.SaveChanges();
        }

    }
}

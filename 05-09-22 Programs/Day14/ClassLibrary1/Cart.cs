using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cart: Book
    {
		//customerid,bookid,price as properties
		private int _customerid;

		public int CustomerID
        {
			get { return _customerid; }
			set { _customerid = value; }
		}
		private int _bookid;

		public new int BookID
		{
			get { return _bookid; }
			set { _bookid = value; }
		}
		private int _price;

		public int Price
		{
			get { return _price; }
			set { _price = value; }
		}
		public void AddToCart(int customerid, int bookid, int price)
		{
			this.CustomerID = customerid;
	        this.BookID = bookid;
			this.Price = price;
		}
        int _bid, _p;
        private string _bname;
        public static List<Book> BookList = new List<Book>();
        public void DisplayBook()
        {
            _bid = base.BookID;
            _bname = base.BookName;
			_p = base.BookPrice;
            Console.WriteLine(_bid);
            Console.WriteLine(_bname);
			Console.WriteLine(_p);
        }
        public void AcceptData()
        {
            Book p = new Book();

            Console.WriteLine("Enter Book ID: ");
            p.BookID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Name: ");
            p.BookName = Console.ReadLine();

			Console.WriteLine("Enter Book Price: ");
            p.BookPrice= Convert.ToInt32(Console.ReadLine());

            InsertBook(p);
            Console.WriteLine("Book added successfully...");
        }
        public void InsertBook(Book BookData)
        {
            BookList.Add(BookData);
        }
        public List<Book> BooksList()
        {
            return BookList;
        }
        static int count;
        public void BookCount()
        {
            count = count + 1;
            Console.WriteLine("You added total Nos of Books: " + count);
        }
    }
}

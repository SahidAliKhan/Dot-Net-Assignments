using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Book
    {
		//Bookid,bookname, price,author
		private int _bookid;
		public int BookID
		{
			get { return _bookid; }
			set { _bookid = value; }
		}

		private string _bookname;

		public string BookName
		{
			get { return _bookname; }
			set { _bookname = value; }
		}


		private int _bookprice;
        public int BookPrice
        {
            get { return _bookprice; }
            set { _bookprice = value; }
        }

		private string _author;

		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}

		public Book() { }
		public Book(int id, string name, int price, string author)
		{
		}
		//method InsertBook(bookid, bookname, price)
		public void InsertBook(int id, string name, int price)
		{
			this.BookID = id;
			this.BookName = name;
			this.BookPrice = price;
		}
        //method InsertBook(bookid, bookname, price, author)
        public void InsertBook(int id, string name, int price, string author)
        {
            this.BookID = id;
            this.BookName = name;
            this.BookPrice = price;
			this.Author = author;
        }
        //InsertBook(bookid, bookname)
        public void InsertBook(int id, string name)
        {
            this.BookID = id;
            this.BookName = name;
        }
	}
	public class Novel: Book
	{
		int NoOfPages;
        public void InsertBook(int id, string name,int price, int noofpages)
        {
            this.BookID = id;
            this.BookName = name;
            this.BookPrice = price;
            this.NoOfPages = noofpages;
        }
    }
}

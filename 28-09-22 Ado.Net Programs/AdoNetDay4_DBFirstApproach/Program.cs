using BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDay4_DBFirstApproach
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookOperation co = new BookOperation();
            List<BookBAL> Books = null;

            Console.WriteLine("Library Management System Using Entity Framework");
            Console.WriteLine("---------------------------------------------------");
            go:
            Console.WriteLine("Menu");
            Console.WriteLine("---------");
            Console.WriteLine("1.Show All Books \n2.Insert a Book \n3.Update a Book \n4.Delete a Book \n5.Count Books \n6.Exit");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Books = co.ShowAllBooks();
                    foreach (var item in Books)
                    {
                        Console.WriteLine(item.Book_No);
                        Console.WriteLine(item.Book_Name);
                        Console.WriteLine(item.Author);
                        Console.WriteLine(item.Cost);
                        Console.WriteLine(item.Category);
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    BookBAL bal = new BookBAL();

                    Console.WriteLine("Enter Book No:");
                    bal.Book_No = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Book Name:");
                    bal.Book_Name = Console.ReadLine();
                    Console.WriteLine("Enter Author:");
                    bal.Author = Console.ReadLine();
                    Console.WriteLine("Enter Book Cost:");
                    bal.Cost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Book Category:");
                    bal.Category = Console.ReadLine();
                    co.InsertBook(bal);
                    Console.WriteLine("Book Inserted Successfully...");
                    break;

                case 3:

                    BookBAL bal1 = new BookBAL();
                    Console.WriteLine("Enter Book No:");
                    bal1.Book_No = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Book Name:");
                    bal1.Book_Name = Console.ReadLine();
                    Console.WriteLine("Enter Author:");
                    bal1.Author = Console.ReadLine();
                    Console.WriteLine("Enter Book Cost:");
                    bal1.Cost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Book Category:");
                    bal1.Category = Console.ReadLine();
                    co.UpdateBook(bal1);
                    Console.WriteLine("Book updated Successfully...");

                    break;

                case 4:
                    Console.WriteLine("Enter Book No to Delete:");
                    int BookNo = Convert.ToInt32(Console.ReadLine());
                    co.DeleteBook(BookNo);
                    Console.WriteLine("Book Deleted Successfully....");
                    break;

                case 5:
                    Books = co.ShowAllBooks();
                    Console.WriteLine("Count of Books:");
                    Console.WriteLine(Books.Count);
                    break;

                case 6:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid Input...");
                    break;

            }
            goto go;
            Console.ReadLine();
        }
    }
}

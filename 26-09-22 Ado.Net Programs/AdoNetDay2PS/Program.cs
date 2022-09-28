using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Book_BAL;
using Book_Helper;
using static Book_BAL.BLL;

namespace AdoNetDay2PS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book Management System");
            Console.WriteLine("------------------------");
            Helper helper = new Helper();
            repeat:
            Console.WriteLine("Menu");
            Console.WriteLine("-------");
            Console.WriteLine("1.Insert a Book \n2.Add a Member \n3.Update a Member \n4.Insert User ID and Password \n5.Login User and Borrow Books \n6.Return Book \n7.Show All Books \n8.Exit");
            int ch = Convert.ToInt32(Console.ReadLine());
            BLL b = new BLL();
            MemberBLL m = new MemberBLL();
            UserBLL u = new UserBLL();
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Book No:");
                    b.Book_No = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Book Name:");
                    b.Book_Name = Console.ReadLine();
                    Console.WriteLine("Enter Author Name:");
                    b.Author = Console.ReadLine();
                    Console.WriteLine("Enter Cost of Book:");
                    b.Cost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Category of the Book:");
                    b.Category = Console.ReadLine();

                    bool queryStatus = helper.AddBook(b);
                    if (queryStatus)
                    {
                        Console.WriteLine("Book added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter Member ID:");
                    m.Member_ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Member Name:");
                    m.Member_Name = Console.ReadLine();

                    bool queryStat = helper.AddMember(m);
                    if (queryStat)
                    {
                        Console.WriteLine("User added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter Member ID:");
                    m.Member_ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Member Name:");
                    m.Member_Name = Console.ReadLine();

                    queryStatus = helper.EditMember(m);
                    if (queryStatus)
                    {
                        Console.WriteLine("Book updated successfully...");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;

                case 4:
                    Console.WriteLine("Enter User ID:");
                    u.User_ID = Console.ReadLine();
                    Console.WriteLine("Enter Password:");
                    u.Password =  Console.ReadLine();   
                    queryStatus = helper.AddUser(u);
                    if (queryStatus)
                    {
                        Console.WriteLine("User added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;

                case 5:
                    UserBLL users = new UserBLL();
                    Console.WriteLine("Enter User ID:");
                    users.User_ID = Console.ReadLine();
                    Console.WriteLine("Enter Password:");
                    users.Password = Console.ReadLine();
                    helper.Login(users);
                    break;

                case 6:
                    helper.ReturnBooks();
                    break;

                case 7:
                    List<BLL> list = new List<BLL>();
                    list = helper.ShowBookList();
                    Console.WriteLine("-------");
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.Book_No);
                        Console.WriteLine(item.Book_Name);
                        Console.WriteLine(item.Author);
                        Console.WriteLine(item.Cost);
                        Console.WriteLine(item.Category);
                        Console.WriteLine("-------");
                    }
                    break;
                case 8:
                    Environment.Exit(1);
                    break;
                    default:
                    Console.WriteLine("Invalid Input...");
                    break;
            }
            goto repeat;
            Console.ReadLine();
        }
    }
}

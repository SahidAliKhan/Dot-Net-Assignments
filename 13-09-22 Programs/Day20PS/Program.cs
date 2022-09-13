using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Lib1;

namespace Sep13
{
    internal class Program
    {
        static void Main(string[] args)
        {
        testc:
            Console.WriteLine("Enter the username as user");
            string p = Console.ReadLine();
            Console.WriteLine("Enter the password as pass");
            string ps = Console.ReadLine();
            Tuple<string, string> t = Tuple.Create<string, string>(p, ps);

            Predicate<Tuple<string, string>> ki = (i) =>
            {
                if (i.Item1 == "user" && i.Item2 == "pass")
                {

                    return true;
                }
                else
                {
                    return false;
                }

            };
            bool ko = ki.Invoke(t);
            if (ko)
            {
                Console.WriteLine("Logged in successfully");
                User u = new User();
                Console.WriteLine("Enter user");
                p = Console.ReadLine();
                u.Username = p;
                Console.WriteLine("Enter type");
                u.Type = Console.ReadLine();
                u.initiate();
                List<Movie> s = new List<Movie>();
                double total = 0;
                int Count1 = 0;
            sed:
                Console.WriteLine("Adding");
                s = u.adding(s, u.Type);
                Count1++;
                u.rented = s;
                if (s.Count == Count1)
                {
                    Console.WriteLine("Enter the rental year");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the rental month");
                    int mi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the rental date");
                    int min = Convert.ToInt32(Console.ReadLine());
                    DateTime top = new DateTime(m, mi, min);
                    u.rentaldate = top;
                    Console.WriteLine("Enter the releasing year");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the releasing month");
                    int im = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the releasing date");
                    int imn = Convert.ToInt32(Console.ReadLine());
                    DateTime pot = new DateTime(i, im, imn);
                    u.releasingdate = pot;
                    Console.WriteLine("Enter the cost");
                    u.Cost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Total cost for this movie", +u.TotalCost());
                    total += u.TotalCost();
                    Console.WriteLine("Enter Yes to further rental");
                    string u1 = Console.ReadLine();
                    if (u1 == "Yes")
                    {
                        goto sed;
                    }
                }
                Console.WriteLine("Stocks after rented");

                foreach (var item in u.dbmovies)
                {
                    Console.WriteLine($"{item.Name} {item.stock}");
                }

                s = u.releasing(s);
                u.rented = s;
                Console.WriteLine("Total cost" + total);
                foreach (var item in u.rented)
                {
                    Console.WriteLine(item.Name);
                }

                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Try again");
                goto testc;
            }
        }
    }
}

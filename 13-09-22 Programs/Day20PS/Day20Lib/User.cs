using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib1
{
    public class Movie
    {
        private string _name;
        private string _language;
        private string _genre;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public int stock
        {
            get;
            set;
        }
        public Movie(string name, string language, string genre, int stock)
        {
            _name = name;
            _language = language;
            _genre = genre;
            this.stock = stock;

        }
        public Movie()
        {

        }

    }

    public class User : Movie
    {

        public User()
        {

        }
        public string Username
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public List<Movie> rented
        {
            get;
            set;
        }
        public DateTime rentaldate
        {
            get;
            set;
        }
        public DateTime releasingdate
        {
            get;
            set;
        }
        public int Cost
        {
            get;
            set;
        }
        public List<Movie> dbmovies = new List<Movie>();



        public void initiate()
        {
            Movie m = new Movie("Chandramukhi", "tamil", "Action", 20);
            dbmovies.Add(m);
            Movie k = new Movie("Ambikavthy", "telugu", "Romance", 30);
            dbmovies.Add(k);
            Movie t = new Movie("Anjana", "tamil", "Romance", 30);
            dbmovies.Add(t);
            Movie n = new Movie("Anupama", "Kannada", "Romance", 30);
            dbmovies.Add(n);
            foreach (var item in dbmovies)
            {
                Console.WriteLine($"{item.Name}  {item.Language} {item.Genre} {item.stock}");
            }



        }

        public void Addition(Movie p)
        {
            dbmovies.Add(p);
        }
        public void Removing(Movie p)
        {
            dbmovies.Remove(p);
        }
        public void Display()
        {
            foreach (var item in dbmovies)
            {
                Console.WriteLine($"{item.Name}  {item.Language} {item.Genre} {item.stock}");
            }
        }




        public List<Movie> adding(List<Movie> rented1, string Type1)
        {
            string s = Console.ReadLine();
            if (Type1.Equals("Gold") && rented1.Count > 3)
            {
                Console.WriteLine("You cannot add");
                return rented1;
            }
            else if (Type1.Equals("Silver") && rented1.Count > 1)
            {
                Console.WriteLine("You cannot add");
                return rented1;
            }
            else if (Type1.Equals("Platinum") && rented1.Count > 5)
            {
                Console.WriteLine("You cannot add");
                return rented1;
            }
            else
            {

                var pi = dbmovies.Where(p => p.Name == s).ToList();
                if (pi != null)
                {
                    foreach (Movie item in pi)
                    {

                        Console.WriteLine(item.Name);

                        dbmovies.Remove(item);
                        item.stock = item.stock - 1;
                        rented1.Add(item);
                        dbmovies.Add(item);


                    }
                    return rented1;
                }
                else
                {
                    Console.WriteLine("Asked one is not available");
                    return rented1;
                }


            }


        }
        public List<Movie> releasing(List<Movie> rented1)
        {

            string cp = Console.ReadLine();
            var po = dbmovies.Where(p => p.Name == cp).ToList();

            foreach (var item in po)
            {
                dbmovies.Remove(item);
                item.stock = item.stock + 1;
                rented1.Remove(item);
                dbmovies.Add(item);

            }
            return rented1;

        }
        public double TotalCost()
        {
            TimeSpan ts = releasingdate - rentaldate;
            int to = ts.Days;
            double k = 0.18 * Cost;
            double ty = to * 0.01 * Cost;
            double yt = k + ty + Cost;
            Console.WriteLine($"GST is {k}");
            Console.WriteLine($"Bluray cost is {ty}");
            Console.WriteLine("Total cost is" + " " + yt);
            return yt;
        }
    }
}

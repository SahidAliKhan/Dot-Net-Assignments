using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int Customerid)
        {
            _custid = Customerid;
        }

        private int _custid;

        public int CustomerID
        {
            get { return _custid; }
            set { _custid = value; }
        }
        private string _cname;

        public string CustomerName
        {
            get { return _cname; }
            set { _cname = value; }
        }

        private string _city;

        public string CustomerCity
        {
            get { return _city; }
            set { _city = value; }
        }

        private int _rating;

        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }



        //Overloading/OverLoaded Method-->same method name with different number,  types and sequneces of parameter and in the single class
        public void InsertData(int custid, string cname)
        {
            this.CustomerID = custid;
            this.CustomerName = cname;

        }
        public void InsertData(string cname, int custid, string city)
        {
            this.CustomerName = cname;
            this.CustomerID = custid;
            this.CustomerCity = city;
        }

        public virtual void InsertData(int rating, int custid, string city)
        {
            Console.WriteLine("Virtual Insert Data from customer class");
            this.CustomerID = custid;
            this.CustomerCity = city;
            this.Rating = rating;

        }


        public void InsertData(int custid, string cname, string city)
        {

            this.CustomerID = custid;
            this.CustomerName = cname;
            this.CustomerCity = city;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ElectronicProducts : Products, IProducts
    {
        
        public ElectronicProducts()
        {

        }
        public ElectronicProducts(int pid)
        {
            Console.WriteLine("Executed pid");
        }
        public ElectronicProducts(int pid, string pname) : this(pid)
        {
            //code her must execute
            Console.WriteLine("Executed pid and pname");
        }


        public ElectronicProducts(int pid, string pname, float price) : this(pid, pname)
        {
            Console.WriteLine("All executed except price , which is called here");
        }
        int _pid;
        private string _pname;
        public static List<Products> prodList = new List<Products>();
        public void DisplayProductInfo()
        {
            _pid = base.ProductID;
            _pname = base.ProductName;
            Console.WriteLine(_pid);
            Console.WriteLine(_pname);

        }
        public void AcceptData()
        {
            Products p = new Products();

            Console.WriteLine("Enter productid");
            p.ProductID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter productname");
            p.ProductName = Console.ReadLine();

            InsertProduct(p);
            Console.WriteLine("Product added successfully...");
        }
        public void InsertProduct(Products proddata)
        {

            prodList.Add(proddata);


        }
        public void UpdateProduct()
        {
            // throw new NotImplementedException();
        }

        public void InsertProduct()
        {
            throw new NotImplementedException();
        }

        public List<Products> ProductList()
        {
            // throw new NotImplementedException();
            return prodList;
        }

        private int _warranty;

        public int Warranty
        {
            get { return _warranty; }
            set { _warranty = value; }
        }




    }
}

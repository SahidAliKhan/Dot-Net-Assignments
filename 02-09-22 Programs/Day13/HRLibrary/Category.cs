using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRLibrary
{
    public class Category
    {
        private int _catid;
        public int CatID
        {
            get { return _catid; }
            set { _catid = value; }
        }
        private string _catname;
        public string CatName
        {
            get { return _catname; }
            set { _catname = value; }
        }
        private string _desc;
        public string Description
        {
            get { return _desc; }
            set { _desc = value; }
        }
        private List<Products> _prodlist;
        public List<Products> ProductsList
        {
            get { return _prodlist; }
            set { _prodlist = value; }
        }

        static int Productcount;
        public void CountProduct()
        {
            Productcount = Productcount + 1;
            Console.WriteLine("You added total Nos of Products: " + Productcount);
        }

        public void AddCategory(int _catid, string _catname, string _desc)
        {
            this.CatID = _catid;
            this.CatName = _catname;
            this.Description = _desc;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Category ID: " + CatID);
            Console.WriteLine("Category Name: " + CatName);
            Console.WriteLine("Description: " + Description);
           
            foreach (var i in ProductsList)
            {
                Console.WriteLine("Product ID: " + i.ProductID);
                Console.WriteLine("Product Name: " + i.ProductName);
            }
        }
 
    }
}

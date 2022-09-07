using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLibrary
{
    public delegate void Delegate4(int i, string n);
    public class Products
    {
		private int _productid;

		public int ProductID
		{
			get { return _productid; }
			set { _productid = value; }
		}
		private string _productname;

		public string ProductName
		{
			get { return _productname; }
			set { _productname = value; }
		}
		public void ProductDetails(int i, string n)
		{
			this.ProductID = i;
			this.ProductName = n;
			Console.WriteLine("Product Details:");
			Console.WriteLine("Product ID: "  +this.ProductID);
			Console.WriteLine("Product Name: " +this.ProductName);
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Products
    {
		private int _id;

		public int Pid
		{
			get { return _id; }
			set { _id = value; }
		}
		private string _pname;

		public string Pname
		{
			get { return _pname; }
			set { _pname = value; }
		}
		private int _price;

		public int Price
		{
			get { return _price; }
			set { _price = value; }
		}

	}
}

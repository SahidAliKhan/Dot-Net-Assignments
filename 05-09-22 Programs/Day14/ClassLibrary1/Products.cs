using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Products
    {
        public Products()
        {

        }
        public Products(int id)
        {

        }
        private int _prodid;

        public int ProductID
        {
            get { return _prodid; }
            set { _prodid = value; }
        }

        private string _prodname;

        public string ProductName
        {
            get { return _prodname; }
            set { _prodname = value; }
        }

    }
}

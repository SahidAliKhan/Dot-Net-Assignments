using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Products
    {
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
        private int _qtysold;
        public int QTYSold
        {
            get { return _qtysold; }
            set { _qtysold = value; }
        }
        private int _unitprice;
        public int UnitPrice
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }

        private string _unirofm;
        public string UnitOFMeasurement
        {
            get { return _unirofm; }
            set { _unirofm = value; }
        }
        private int _qtyInHand;
        public int QtyInHand
        {
            get { return _qtyInHand; }
            set { _qtyInHand = value; }
        }
        private int _reorder;
        public int ReorderLevel
        {
            get { return _reorder; }
            set { _reorder = value; }
        }

        public void AddProduct(int _prodid, string _prodname)
        {
            this.ProductID = _prodid;
            this.ProductName = _prodname;
        }

    }
}

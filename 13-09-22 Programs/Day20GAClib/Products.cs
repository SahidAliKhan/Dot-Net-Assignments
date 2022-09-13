using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20GAClib
{
    public delegate double PriceCalculation();

    public class Products
    {
        public int Prodid { get; set; }
        public string Prodname { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }

        public double OfferPrice()
        {
            double amt = Qty * Price;
            double bdis = amt;
            double dis = amt * .10;
            double actualPrice = bdis - dis;
            return actualPrice;

        }


        public double CalculatePrice()
        {
            return Qty * Price;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms30thSeptPS
{
    public class CustomerBAL
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }

    public class ProductBAL
    {
        public int ProdID { get; set; }
    }
}
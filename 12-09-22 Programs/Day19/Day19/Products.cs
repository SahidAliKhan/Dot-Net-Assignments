using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19
{
    [Developer("name", DeveloperName = "Ankit")]
    public class Products
    {
        [Developer("name", DeveloperName = "Ananth")]
        public int Prodid { get; set; }

        [Developer("name", DeveloperName = "Ankit")]
        public string Prodname { get; set; }

        [Developer("name", DeveloperName = "Vinit")]
        public Products()
        {

        }
        [Developer("name", DeveloperName = "Ananth")]
        public Products(int pid, string pname)
        {
            Prodid = pid;
            Prodname = pname;
        }
    }
}

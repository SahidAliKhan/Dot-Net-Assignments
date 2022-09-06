using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    public class Indexer_this_Demo
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string City { get; set; }
        //property with the name "this", it will make the class behave like a array
        private string[] stateNames = new string[5] { "MH", "KA", "KE", "PB", "UP" };

        //indexer
        public string this[int h]
        {
            get { return stateNames[h]; }
            set { stateNames[h] = value; }
        }
        static void Main(string[] args)
        {
            Indexer_this_Demo p = new Indexer_this_Demo();
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);
            Console.WriteLine(p[2]);
            Console.WriteLine(p[3]);
            Console.WriteLine(p[4]);
            Console.WriteLine("-----After----");
            p[0] = "CH";
            p[2] = "OD";
            p[4] = "ND";
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);
            Console.WriteLine(p[2]);
            Console.WriteLine(p[3]);
            Console.WriteLine(p[4]);

            Console.Read();
        }
    }
}

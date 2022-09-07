using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateLibrary;

namespace Day16
{
    public class Program
    {

        static void Main(string[] args)
        {

            //Person p = new Person();
            ////p.Walk();

            //WalkDelegate d = new WalkDelegate(p.Walk);//Target of invocation
            //d.Invoke();
            //d();


            Trekking t = new Trekking();
            // d = new WalkDelegate(t.StartTrek);

            //WalkDelegate d1 = new WalkDelegate(t.StartTrek);
            //WalkDelegate d2 = new WalkDelegate(t.EndTrek);
            //WalkDelegate d3=(WalkDelegate)MulticastDelegate.Combine(d1, d2);

            ////d3.Invoke();
            //d3();

            WalkDelegate[] del = new WalkDelegate[3] { t.StartTrek, t.TrekRules, t.EndTrek };

            WalkDelegate d3 = (WalkDelegate)MulticastDelegate.Combine(del);
            d3();




            Console.WriteLine("---------------------");

            TrekHeightDelegate th = new TrekHeightDelegate(t.TrekHeight);
            DateTime dt = new DateTime(2000, 09, 10);
            int h = th(dt);
            int h1 = th.Invoke(dt);

            //d.Invoke();

            Console.Read();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    public delegate void WalkDelegate();
    public delegate void PersonWalkDelegate(int cal);
    public delegate int TrekHeightDelegate(DateTime d1);

    public class Trekking
    {

        public int TrekHeight(DateTime d)
        {
            return 1000;
        }

        public void StartTrek()
        {
            Console.WriteLine("Trek started.....");
        }

        public void TrekRules()
        {
            Console.WriteLine("Follow the following rules");
            Console.WriteLine("rule 1");
            Console.WriteLine("rule 2");
            Console.WriteLine("rule 3");
        }

        public void EndTrek()
        {
            Console.WriteLine("Trek ended.....");

        }


    }

    public class Person
    {
        public static event PersonWalkDelegate Hunger;
        //event delegatename eventname



        public int Calories { get; set; }
        public void Walk(int Calories)
        {
            Hunger += Person_Hunger;
            for (int i = 0; i < 1000; i = i + 100)
            {
                Console.WriteLine("Walking....");
                Calories = Calories - 10;

                if (Calories <= 50)
                {

                    Hunger(Calories);
                    break;
                }

            }
            Console.WriteLine("U have walked 1000 steps");

        }

        private void Person_Hunger(int cal)
        {
            //throw new NotImplementedException();
            PersonWalkDelegate del = new PersonWalkDelegate(Eat);
            del.Invoke(Calories);


        }


        //        public delegate void PersonWalkDelegate(int cal);

        public void Eat(int calories)
        {
            if (calories <= 50)
            {
                Calories = 100;

            }
            Console.WriteLine("Calories refilled......");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Bk1
    {
        void a();
        void S(int i, int j);
        void M(int j);
    }
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}

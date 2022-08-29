using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class GenericStack<T>
    {
        T[] _data = new T[10];
        public void AddOrEdit(int index, T item)
        {

            if (index >= 0 && index <= 10)
            {
                _data[index] = item;
            }
        }

        public T ReturnData(int index)
        {

            if (index >= 0 && index <= 10)
            {
                return _data[index];
            }
            else
            {

                return default(T);
            }


        }

        public void ShowData(int index)
        {

            Console.WriteLine(_data[index]);
        }

        static void Main(string[] args)
        {
            GenericStack<string> stringdata = new GenericStack<string>();
            stringdata.AddOrEdit(0, "Hello");
            string printdata = stringdata.ReturnData(0);
            Console.WriteLine(printdata);
            Console.WriteLine("-------------------");
            stringdata.AddOrEdit(0, "Welcome");

            stringdata.ShowData(0);
            Console.ReadLine();
        }
    }
}

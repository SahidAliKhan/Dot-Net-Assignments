using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class UserDataStore<T>
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


    }
}
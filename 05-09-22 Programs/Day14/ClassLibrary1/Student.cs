using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface I1
    {
        void Add(int i, int j);
        void Subtract(int i, int j);
        void Multiply(int i, int j);
    }

    public interface I3
    {
        int divide(int i, int j);
    }

    public interface I2
    {
        void Add(int i, int j);
        void Subtract(int i, int j);
    }
    public class Maths : I1
    {
        //void Add(int i,int j) { }
        //void Subtract(int i,int j) { }
        public void Add(int i, int j)
        {
            // throw new NotImplementedException();
            int k = i + j;
        }

        public void Multiply(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void Subtract(int i, int j)
        {
            //throw new NotImplementedException();
            if (i > 0)
            {
                int k = i - j;
            }
        }
    }

    public class AdvancedMaths : Maths
    {
        public void Multiply(int i, int j) { }
        public void Divide(int i, int j) { }

    }

    public class SimpleMaths
    {
        void Add(int i, int j) { }
        void Subtract(int i, int j) { }

    }


    public class TrignometricMaths : I2, I1, I3
    {
        public void Add(int i, int j)
        {
            throw new NotImplementedException();
        }
        public void calculateSin() { }
        public void calculateTan() { }

        public int divide(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void Multiply(int i, int j)
        {
            throw new NotImplementedException();
        }
        public void Subtract(int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}

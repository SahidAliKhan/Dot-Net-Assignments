using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLibrary
{
    public delegate int DoCalculations(int i, int j);

    public class Maths
    {
        public int add(int i, int j)
        {
            return i + j;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasicDemo
{
    public class Calculate
    {
        public int Add(int i, int j)
        {
            return i + i;
        }

        public bool ValidateUser(string u, string p)
        {
            if (u == "testuser_1" && p == "Test@123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

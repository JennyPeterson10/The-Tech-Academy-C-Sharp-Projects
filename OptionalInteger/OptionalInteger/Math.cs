using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalInteger
{
    class Math
    {
        public static int multiply(int num1, int num2 = 11)
        {
            int total = num1 * num2;
            return total;
        }
    }
}

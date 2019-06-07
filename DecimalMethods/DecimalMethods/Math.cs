using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalMethods
{
    class Math
    {
        //add 5 to integer input
        public static int sum(int num1)
        {
            int total = num1 + 5;
            return total;
        }

        //add 10 to decimal input and rounds to nearest integer
        public static int sum(decimal num1)
        {
            int answer = Convert.ToInt32(num1) + 10;
            return answer;
        }

        //convert string to integer and add 8
        public static int sum(string num1)
        {
            int answer = Convert.ToInt32(num1) + 8;
            return answer;
        }

    }
}

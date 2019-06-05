using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Math
    {
        //method that adds 2 to user input
        public static int addTwo(int num1)
        {
            int total;
            total = 2 + num1;
            return total;

        }

        //method that multiplies user input by 3
        public static int timesThree(int num2)
        {
            int total;
            total = 3 * num2;
            return total;
        }

        //method that subtracts 5 from user input
        public static int subtractFive(int num3)
        {
            int total;
            total = num3 - 5;
            return total;
        }

    }
}

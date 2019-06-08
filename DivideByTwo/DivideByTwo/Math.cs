using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByTwo
{
    class Math
    {
        //divide the user input by 2 
        public void divide(int num1, out double num2)
        {
            num2 = (double)num1 / 2;
            Console.WriteLine(num1 + " divided by 2 equals " + num2 + ".");
        }

        //overloading the method divide using decimal input
        public void divide(decimal num1, out decimal num2)
        {
            num2 = num1 / 2;
            Console.WriteLine(num1 + " divided by 2 equals " + num2 + ".");
        }
    }
}

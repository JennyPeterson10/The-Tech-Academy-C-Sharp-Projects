using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //call method with two parameters
            Math math1 = new Math();
            math1.twoIntegers(3, 8);
            Console.ReadLine();

            //specify parameters by name
            Math math2 = new Math();
            math2.twoIntegers(num1: 4, num2: 7);
            Console.ReadLine();
        }
    }
}

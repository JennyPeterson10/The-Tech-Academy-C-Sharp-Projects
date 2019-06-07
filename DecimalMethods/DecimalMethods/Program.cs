using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please type a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input + " plus 5 equals {0}.", Math.sum(input));
            Console.ReadLine();

            Console.WriteLine("Please type a decimal.");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(input2 + " plus 10 equals {0}, rounded to the nearest integer.", Math.sum(input2));
            Console.ReadLine();

            Console.WriteLine("Please type another number.");
            string input3 = Console.ReadLine();
            Console.WriteLine(input3 + " plus 8 equals {0}.", Math.sum(input3));
            Console.ReadLine();
        }
    }
}

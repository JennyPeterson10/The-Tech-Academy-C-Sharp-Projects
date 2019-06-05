using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer.");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now performing some math...");
            Console.ReadLine();

            // Calls methods from Math class
            Console.WriteLine(input + " plus 2 equals {0}.", Math.addTwo(input));
            Console.WriteLine(input + " times 3 equals {0}.", Math.timesThree(input));
            Console.WriteLine(input + " minus 5 equals {0}.", Math.subtractFive(input));
            Console.ReadLine();


        }
    }
}

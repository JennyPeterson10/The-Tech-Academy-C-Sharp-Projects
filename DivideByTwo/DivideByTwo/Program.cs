using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            double output;

            math.divide(input, out output);
            Console.ReadLine();

            Console.WriteLine("Please enter a decimal.");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());
            decimal output2;

            math.divide(input2, out output2);
            Console.ReadLine();

            //call method from static class
            Console.WriteLine(Words.congrats());
            Console.ReadLine();
        }
    }
}

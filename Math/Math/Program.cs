using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ready for some math problems? Let's get started!");

            //Add 25
            Console.WriteLine("Please enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double add25 = num1 + 25;
            Console.WriteLine(num1 + " plus 25 is " + add25 + ".");
            Console.ReadLine();

            //Divide by 12.5
            Console.WriteLine("Please enter another number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double divide = num2 / 12.5;
            Console.WriteLine(num2 + " divided by 12.5 is " + divide + ".");
            Console.ReadLine();

            //Greater than 50?
            Console.WriteLine("And another number:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            bool greaterThan50 = num3 > 50;
            Console.WriteLine(num3 + " is greater than 50?: " + greaterThan50 + ".");
            Console.ReadLine();

            //Remainder after dividing by 7
            Console.WriteLine("And finally one more number:");
            double num4 = Convert.ToDouble(Console.ReadLine());
            double remainder7 = num4 % 7;
            Console.WriteLine("The remainder of " + num4 + " after dividing by 7 is " + remainder7 + ".");
            Console.ReadLine();

        }
    }
}


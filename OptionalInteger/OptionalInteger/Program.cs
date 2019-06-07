using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number. You can choose to skip this step.");
            int num2;

            //checks to see if the user enters an integer
            bool success = Int32.TryParse(Console.ReadLine(), out num2);
            if (success)
            {
                int answer = Math.multiply(num1, num2);
                Console.WriteLine(num1 + " times " + num2 + " equals " + answer + ".");
                Console.ReadLine();
            }
            else
            {
                int answer = Math.multiply(num1);
                Console.WriteLine(num1 + " times 11 is " + answer + ".");
                Console.ReadLine();
            }
        }
    }
}

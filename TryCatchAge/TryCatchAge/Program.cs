using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            Console.WriteLine("What is your age?");
            try
            {
                validAnswer = int.TryParse(Console.ReadLine(), out int age);
                if (validAnswer && age > 0)
                {
                    int yearBorn1 = DateTime.Now.Year - age - 1;
                    int yearBorn2 = DateTime.Now.Year - age;
                    Console.WriteLine("You were born in {0} or {1}.", yearBorn1, yearBorn2);
                    Console.ReadLine();
                }
                if (validAnswer && age <= 0)
                {
                    Console.WriteLine("You cannot enter zero or negative numbers.");
                    Console.ReadLine();
                }
                else throw new Exception();     
            }
            // Anything that is not an integer is caught here
            catch (Exception)
            {
                Console.WriteLine("You did not enter a valid number.");
                Console.ReadLine();
                return;
            }
        }
    }
}

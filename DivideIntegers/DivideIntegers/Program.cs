using System;
using System.Collections.Generic;


namespace DivideIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 76, 804, 55, 123, 42 };

            try
            {
                Console.WriteLine("Ready for some math? \nPlease choose a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    double answer = (double)number / numberOne;
                    Console.WriteLine(number + " divided by " + numberOne + " equals " + answer + ".");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("This opperation cannot be performed. " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

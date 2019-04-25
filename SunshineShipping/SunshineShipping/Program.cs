using System;

namespace SunshineShipping
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Sunshine Shipping. Please follow the instructions below.");
            Console.ReadKey();

            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Sunshine Shipping. Have a good day.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please enter the package width:");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                double length = Convert.ToDouble(Console.ReadLine());

                double total = (width + height + length) * weight / 100;

                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Sunshine Shipping. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + total.ToString("F2") + ". \nThank you.");
                    Console.ReadLine();
                }
            }

              

            

        }
    }
}

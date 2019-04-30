using System;

namespace WhileSleeping
{
    class Program
    {
        static void Main()
        {
            //while loop to determine multiples of a number
            Console.WriteLine("Please enter a number to determine the first 10 multplies of that number.");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i < 10)
            {
                int multiple = num * i;
                i++;
                Console.WriteLine(multiple);
            }
            Console.ReadLine();

            //do while loop to guess cups of coffee
            Console.WriteLine("How many cups of coffee is the perfect amount in one day? Take a guess:");
            int cups = Convert.ToInt32(Console.ReadLine());
            bool coffee = cups == 4;

            do
            {
                switch (cups)
                {
                    case 1:
                        Console.WriteLine("Nope, not " + cups + " cup. Guess again.");
                        cups = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Yes, 4 cups is the perfect amount of coffee in one day!");
                        coffee = true;
                        break;
                    default:
                        Console.WriteLine("Nope, not " + cups + " cups. Guess again.");
                        cups = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!coffee);
            Console.ReadLine();
        }
    }
}

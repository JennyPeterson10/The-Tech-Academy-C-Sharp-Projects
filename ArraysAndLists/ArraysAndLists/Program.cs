using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] beverageArray = { "coffee", "water", "lemonade", "beer", "hot chocolate" };

            //Beverage selection
            Console.WriteLine("So you're thirsty, huh? \nPlease make a selection from 0-4 to determine your drink of choice.");

        beverageLoop:
            string beverageSelection = Console.ReadLine();
            string beverage;

            try
            {
                int bevInt = Convert.ToInt32(beverageSelection);
                beverage = beverageArray[bevInt];
                Console.WriteLine("Your drink choice is: " + beverage + ".");
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("That is not a valid selection. Please select a number from 0-4.");
                goto beverageLoop;
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid selection. Please select a number from 0-4.");
                goto beverageLoop;
            }

            //Size selection
            Console.WriteLine("To determine the size of " + beverage + " you will get, please select a number from 0-5.");

        sizeLoop:
            int[] flozArray = { 4, 8, 12, 16, 32, 64 };
            string flozSelection = Console.ReadLine();

            try
            {
                int flozInt = Convert.ToInt32(flozSelection);
                Console.WriteLine("You will get: " + flozArray[flozInt] + " fl oz of " + beverage + ".");
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("That is not a valid selection. Please select a number from 0-5.");
                goto sizeLoop;
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid selection. Please select a number from 0-5.");
                goto sizeLoop;
            }

            //Snack list selection
            List<string> snackList = new List<string>();
            snackList.Add("cookie");
            snackList.Add("croisant");
            snackList.Add("sandwich");
            snackList.Add("french fries");

            Console.WriteLine("What would you like to eat with your " + beverage + "? Please select a number from 0-3.");
            
        snackLoop:
            string snackSelection = Console.ReadLine();
            try
            {
                int snackInt = Convert.ToInt32(snackSelection);
                Console.WriteLine("Your snack choice is: " + snackList[snackInt] + ".");
                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("That is not a valid selection. Please select a number from 0-3.");
                goto snackLoop;
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid selection. Please select a number from 0-3.");
                goto snackLoop;
            }

        }
    }
}

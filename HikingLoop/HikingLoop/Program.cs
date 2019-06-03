using System;
using System.Collections.Generic;
using System.Linq;



namespace HikingLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. appends each string in the array with user input
            string[] hikes = { "fried", "sauted", "barbequed", "braised" };
            Console.WriteLine("Please input a type of meat to see a list of all the ways it can be prepared for you.");
            string text = Console.ReadLine();
            for (int i = 0; i < hikes.Length; i++)
            {  
                Console.WriteLine(hikes[i] + " " + text);
            }
            Console.ReadLine();


            // 2. infinite loop
            //Console.WriteLine("Do you like to hike? Please type true or false.");
            //Boolean hikingResponse = Convert.ToBoolean(Console.ReadLine());
            //while (hikingResponse == true)
            //{
            //    Console.WriteLine("I like to hike.");
            //}
            //Console.ReadLine();


            // 3. infinite loop fixed
            Console.WriteLine("Do you like to hike? Please type true or false.");
            Boolean hikingResponse;
            if (Boolean.TryParse(Console.ReadLine(), out hikingResponse))
            {
                if (hikingResponse == true)
                {
                    Console.WriteLine("You like to hike.");
                }
                if (hikingResponse == false)
                {
                    Console.WriteLine("You don't like to hike.");
                }
            }
            else
            {
                Console.WriteLine("You did not type true or false.");

            }
            Console.ReadLine();


            // 4. loop using <
            int[] mountainHeights = { 8366, 11250, 12280, 14409, 10781, 10495 };
            Console.WriteLine("The mountain heights less than 11,000 feet are:");
            for (int j = 0; j < mountainHeights.Length; j++)
            {
                if (mountainHeights[j] < 11000)
                {
                    Console.WriteLine(mountainHeights[j]);
                }
            }
            Console.ReadLine();


            // 5. loop using <=
            Console.WriteLine("The mountain heights less than or equal to 11,250 feet are:");
            for (int j = 0; j < mountainHeights.Length; j++)
            {
                if (mountainHeights[j] <= 11250)
                {
                    Console.WriteLine(mountainHeights[j]);
                }
            }
            Console.ReadLine();


            // 6. 7. and 8. unique string search
            List<string> hikingTrails = new List<string>() { "Timberline", "Three Sisters", "Wonderland", "Shale Lake" };
            Console.WriteLine("Please select a hike from the following: Timberline, Three Sisters, Wonderland, Shale Lake");
            string hikeSelection = Console.ReadLine();

            while (!hikingTrails.Contains(hikeSelection))
            {
                Console.WriteLine("Sorry, you did not select a hike in the list. Please try again.");
                hikeSelection = Console.ReadLine();
            }

            Console.WriteLine("The index of " + hikeSelection + " is: " + hikingTrails.IndexOf(hikeSelection) + ".");
            Console.ReadLine();


            // 9. 10. and 11. string search with multiple matches
            List<string> mountains = new List<string>() { "Mount St. Helens", "Mount Hood", "Mount Adams", "Mount Rainier", "Mount Hood", "Mount Baker", "Mount Jefferson", "Mount Adams" };
            Console.WriteLine("Please select a mountain in the Pacific Northwest. \nIf you correctly guess one on the list, the index if that mountain will display.");
            string mountainSelection = Console.ReadLine();
            var mountainIndex = new List<int>() { };

            while (mountainIndex.Count == 0)
            {
                for (int i = 0; i < mountains.Count; i++)
                {
                    if (mountains[i] == mountainSelection)
                    {
                        mountainIndex.Add(i);
                    }
                }
                if (mountainIndex.Count == 0)
                {
                    Console.WriteLine("Sorry, you did not select a mountain in the list. Please try again.");
                    mountainSelection = Console.ReadLine();
                }
            }
            Console.WriteLine("The index of " + mountainSelection + " is: " + String.Join(", ", mountainIndex) + ".");
            Console.ReadLine();


            // 12. foreach loop showing if item has appeared in the list
            Console.WriteLine("Displayed below are all of the mountains from that list and if they appear more than once.");
            List<string> newMountains = new List<string>() { };

            foreach (string mountain in mountains)
            {
                if (!newMountains.Contains(mountain))
                {
                    Console.WriteLine(mountain);
                    newMountains.Add(mountain);
                }
                else
                {
                    Console.WriteLine(mountain + " has already appeared in the list.");
                }
            }
            Console.ReadLine();
        }
    }
}

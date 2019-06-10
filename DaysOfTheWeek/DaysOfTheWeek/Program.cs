using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            string day = Console.ReadLine();
            bool answerAgain = true;
            while (answerAgain)
            {
                try
                {
                    Days dayvalue = (Days)Enum.Parse(typeof(Days), day);
                    if (Enum.IsDefined(typeof(Days), dayvalue))
                        Console.WriteLine("Yes, it is " + day + ".");
                    answerAgain = false;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                    day = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}

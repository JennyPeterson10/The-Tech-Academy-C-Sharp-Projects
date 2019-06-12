using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Current date and time: " + today);
            Console.WriteLine("Please select a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            // converts the number to a timespan
            TimeSpan hoursFromNow = new TimeSpan(number, 0, 0);
            // calculates the time in that many hours from now
            DateTime future = today.Add(hoursFromNow);
            Console.WriteLine("In {0} hours from now it will be: " + future, number);
            Console.ReadLine();
        }
    }
}

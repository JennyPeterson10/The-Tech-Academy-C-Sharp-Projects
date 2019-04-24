using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine().ToUpper();
            bool duiBoolean;
            if (dui == "YES" || dui == "Y" || dui == "TRUE" || dui == "T")
                duiBoolean = true;
            else
                duiBoolean = false;
      
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && duiBoolean == false && speedingTickets < 4);
            Console.ReadLine();
        }
    }
}

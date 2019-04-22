using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.ReadKey();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool needHelp;
            while (!bool.TryParse(help, out needHelp))
            {
                Console.WriteLine("Please answer \"true\" or \"false\".");
                help = Console.ReadLine();
            }
            needHelp = Convert.ToBoolean(help);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string study = Console.ReadLine();
            int hoursStudied;
            while (!int.TryParse(study, out hoursStudied))
            {
                Console.WriteLine("Please type a number from 0 to 24.");
                study = Console.ReadLine();
            }
            hoursStudied = Convert.ToInt32(study);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}

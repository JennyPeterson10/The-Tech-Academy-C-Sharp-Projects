using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("In which city were you born?");
            string birthCity = Console.ReadLine();
            string upperName = (firstName.ToUpper() + " " + lastName.ToUpper());
            Console.WriteLine("HELLO " + upperName + "! you were born in " + birthCity + ".");

            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Ready to write your life story? If so, press enter.");
            Console.ReadKey(true);
            Console.WriteLine("Okay. After you were born in " + birthCity + ", where did you go next and what did you do?");
            sb.Append(Console.ReadLine() + " ");
            Console.WriteLine("What was the most memerable event of your childhood?");
            sb.Append(Console.ReadLine() + " ");
            Console.WriteLine("How about those fabulous teenage years?");
            sb.Append(Console.ReadLine() + " ");
            Console.WriteLine("Then what?");
            sb.Append(Console.ReadLine());
            Console.WriteLine("Here is the story of your life: ");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

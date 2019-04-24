using System;


namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1
            Console.WriteLine("Person 1 \nHourly Rate?");
            int rate1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hours1 = Convert.ToInt16(Console.ReadLine());

            //Person 2
            Console.WriteLine("Person 2 \nHourly Rate?");
            int rate2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hours2 = Convert.ToInt16(Console.ReadLine());

            //Salary
            Console.WriteLine("Weekly salary of Person 1:");
            float salary1 = rate1 * hours1;
            Console.WriteLine(salary1);
            Console.ReadKey();

            Console.WriteLine("Weekly salary of Person 2:");
            float salary2 = rate2 * hours2;
            Console.WriteLine(salary2);
            Console.ReadKey();

            bool salaryComparison = salary1 > salary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(salaryComparison);
            Console.ReadLine();



        }
    }
}

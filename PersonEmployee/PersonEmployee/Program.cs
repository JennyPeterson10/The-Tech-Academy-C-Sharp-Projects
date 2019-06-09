using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.WriteLine("Do you like your job? Please choose true or false.");
            bool answer = Convert.ToBoolean(Console.ReadLine());
            if (answer == true)
            {
                Console.WriteLine("Glad to hear.");
            }
            else
            {
                employee.Quit();
            }
            Console.ReadLine();
        }
    }
}

﻿using System;
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
            //Employee employee = new Employee() { FirstName = "Sample", LastName = "Student"};
            //employee.SayName();
            //Console.WriteLine("Do you like your job? Please choose true or false.");
            //bool answer = Convert.ToBoolean(Console.ReadLine());
            //if (answer == true)
            //{
            //    Console.WriteLine("Glad to hear.");
            //}
            //else
            //{
            //    employee.Quit();
            //}
            //Console.ReadLine();

            //using the overload comparison operator
            //Employee emp1 = new Employee() { FirstName = "Sally", LastName = "Jones", Id = 1 };
            //Employee emp2 = new Employee() { FirstName = "Larry", LastName = "Smith", Id = 2 };

            //if(emp1 == emp2)
            //{
            //    Console.WriteLine(emp1.FirstName + " " + emp1.LastName + " and " + emp2.FirstName + " " + emp2.LastName + " are the same person.");
            //    Console.ReadLine();
            //}
            //if (emp1 != emp2)
            //{
            //    Console.WriteLine(emp1.FirstName + " " + emp1.LastName + " and " + emp2.FirstName + " " + emp2.LastName + " are not the same person.");
            //    Console.ReadLine();
            //}
            //if (emp1 == emp1)
            //{
            //    Console.WriteLine(emp1.FirstName + " " + emp1.LastName + " and " + emp1.FirstName + " " + emp1.LastName + " are the same person.");
            //    Console.ReadLine();
            //}

            //instantiate employee with type Things
            Employee<string> employee1 = new Employee<string> { Things = new List<string> { "desk", "computer", "pencil", "paper" } };
            Employee<int> employee2 = new Employee<int> { Things = new List<int> { 1, 4, 65, 3, 8 } };

            foreach(string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { FirstName = "Joe", LastName = "Johnson", Id = 1 };
            Employee employee2 = new Employee { FirstName = "Susan", LastName = "Smith", Id = 2 };
            Employee employee3 = new Employee { FirstName = "Nancy", LastName = "Nelson", Id = 3 };
            Employee employee4 = new Employee { FirstName = "Joe", LastName = "Jacobson", Id = 4 };
            Employee employee5 = new Employee { FirstName = "Garth", LastName = "Green", Id = 5 };
            Employee employee6 = new Employee { FirstName = "Olivia", LastName = "Orville", Id = 6 };
            Employee employee7 = new Employee { FirstName = "Jane", LastName = "Jackson", Id = 7 };
            Employee employee8 = new Employee { FirstName = "Billy", LastName = "Barton", Id = 8 };
            Employee employee9 = new Employee { FirstName = "Joe", LastName = "Jacobs", Id = 9 };
            Employee employee10 = new Employee { FirstName = "Lenny", LastName = "Larson", Id = 10 };

            List<Employee> employeeList = new List<Employee>() { employee1, employee2, employee3, employee4,
                employee5, employee6, employee7, employee8, employee9, employee10};

            // foreach loop to find all employees in employeeList with first name "Joe"
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee emp in employeeList)
            {
                if (emp.FirstName == "Joe")
                {
                    JoeList.Add(emp);
                    Console.WriteLine(emp.FirstName + " " + emp.LastName);
                }  
            }
            Console.WriteLine("These are all of employees with the name Joe found using a foreach loop.");
            Console.ReadLine();

            // lambda expression to accomplish same task
            List<Employee> JoeLambdaList = employeeList.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee emp in JoeLambdaList)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }
            Console.WriteLine("These are all of employees with the name Joe found using a lambda expression.");
            Console.ReadLine();

            // lambda expression to find all employees with Id greater than 5
            List<Employee> overFiveList = employeeList.Where(x => x.Id > 5).ToList();
            foreach (Employee emp in overFiveList)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }
            Console.WriteLine("These are all of employees with an ID greater than 5.");
            Console.ReadLine();
        }
    }
}

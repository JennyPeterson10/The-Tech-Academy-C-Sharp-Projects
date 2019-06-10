using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEmployee
{
    public class Employee<T> : Person, IQuitable
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }

        //include method Quit() from IQuitable interface
        public void Quit()
        {
            Console.WriteLine("You should quit.");
        }

        //overload "==" operator
        public static bool operator == (Employee<T> emp1, Employee<T> emp2)
        {
            bool status = false;
            if (emp1.Id == emp2.Id)
            {
                status = true;
            }
            return status;
        }

        //overload "!=" operator
        public static bool operator != (Employee<T> emp1, Employee<T> emp2)
        {
            bool status = false;
            if (emp1.Id != emp2.Id)
            {
                status = true;
            }
            return status;
        }
    }
}

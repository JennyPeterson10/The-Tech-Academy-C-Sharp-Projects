using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEmployee
{
    public class Employee : Person, IQuitable
    {
        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("You should quit.");
        }
    }
}

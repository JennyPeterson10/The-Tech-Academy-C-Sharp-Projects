using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAmount
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 4.32M};
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}

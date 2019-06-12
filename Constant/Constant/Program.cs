using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            const string coffee = "I always start the day with coffee.";
            // It is possible to create a new instance of Coffee using var
            var drink = new Coffee("latte");
            Console.WriteLine(coffee + " My morning coffe today is a {0} oz {1}.", drink.Amount, drink.Type);
            Console.ReadLine();
        }
    }
}

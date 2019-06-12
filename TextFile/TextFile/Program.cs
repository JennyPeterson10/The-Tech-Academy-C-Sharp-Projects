using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please select a number.");
            string number = Console.ReadLine();
            File.WriteAllText(@"..\..\log.txt", number);
            Console.WriteLine("The number you selected is: " + File.ReadAllText(@"..\..\log.txt") + ".");
            Console.ReadLine();
        }
    }
}

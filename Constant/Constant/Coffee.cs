using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    public class Coffee
    {
        // Constructor call chain with a default coffee size 12
        public Coffee(string name) : this(12, name)
        {
        }
        public Coffee(int amount, string type)
        {
            Amount = amount;
            Type = type;
        }
        public int Amount { get; set; }
        public string Type { get; set; }
    }
}

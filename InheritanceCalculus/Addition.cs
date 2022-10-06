using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCalculus
{
    internal class Addition : CalculusActions
    {
        public string Addsum { get; set; }
        public Addition(string addsum) : base(addsum)
        {
            Addsum = addsum;
        }
        static void AddAction(decimal number1, decimal number2, decimal number3)
        {
            decimal addsum = number1 + number2 * number3;
            Console.WriteLine($"Addition result: {addsum}");
            
        }
    }
}

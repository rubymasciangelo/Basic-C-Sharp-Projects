using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("You totally don't have to but you may add a second number: ");
            string input2 = Console.ReadLine();
            Console.WriteLine(Okurrr.SomeMath(input1, input2));
            Console.ReadKey();
        }
    }
}

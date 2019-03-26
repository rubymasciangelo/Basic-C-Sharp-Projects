using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.DoMath(inputX:12));
            Console.ReadKey();
            Console.WriteLine(Math.DoMath(decimalX:3.2));
            Console.ReadKey();
        }
    }
}

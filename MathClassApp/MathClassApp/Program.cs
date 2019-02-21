using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an integer to do some math to:");
            Int16 inputNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(inputNum + " multiplied by 3 is " + Math.Multiply(inputNum));


            Console.ReadLine();
        }
    }
}

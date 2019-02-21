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
            int input1 = Math.Mult3(inputNum);
            Console.WriteLine(inputNum + " multiplied by 3 is " + input1 );
            int input2 = Math.Add3(input1);
            Console.WriteLine(input1 + " plus 3 is " + input2 );


            Console.ReadLine();
        }
    }
}

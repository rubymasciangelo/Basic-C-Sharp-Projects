using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer: ");
            string input1 = Console.ReadLine();

            BigStaticClass printResult = new BigStaticClass();
            printResult.HalfIt(input1);

            Console.ReadKey();
        }
    }
}

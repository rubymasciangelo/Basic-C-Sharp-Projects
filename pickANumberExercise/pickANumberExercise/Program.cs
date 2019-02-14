using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pickANumberExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write any number: ");
            string numResponse = Console.ReadLine();
            int inputNum = Convert.ToInt32(numResponse);
            int multiply = inputNum * 50;
            Console.WriteLine("Your number multiplied by 50 is " + multiply);
        }
    }
}

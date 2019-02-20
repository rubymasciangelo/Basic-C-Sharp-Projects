using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Pick a number");
                int number = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Pick a second number");
                int numberTwo = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = number / numberTwo;
                Console.WriteLine(number + " divided by " + numberTwo + " = " + numberThree);
            }
        }
    }
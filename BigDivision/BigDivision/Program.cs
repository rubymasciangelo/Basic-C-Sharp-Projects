using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 8, 15, 16, 23, 32 };
            Console.WriteLine("Choose a number to divide a list of numbers by:");
            int numChoice = Convert.ToInt16(Console.ReadLine());
            foreach (int number in numbers)
            {
                int numAnswer = number / numChoice;
                Console.WriteLine(number + " divided by " + numChoice + " = " + numAnswer);
            }
            Console.ReadLine();

        }
    }
}

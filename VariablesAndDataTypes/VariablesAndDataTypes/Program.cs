using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine(yourName + " is a dumb name!");
            //Console.Read();

            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            int faveNum = Convert.ToInt32(favoriteNumber);
            int total = faveNum + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine();
        }
    }
}

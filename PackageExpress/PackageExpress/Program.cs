using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.Read();

            Console.WriteLine("What is the weight of the package?");
            int weight = Convert.ToInt16(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("What is the width of the package?");
                int width = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("What is the height of the package?");
                int height = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("What is the length of the package?");
                int length = Convert.ToInt16(Console.WriteLine());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _156_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please input an integer:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} hours it will be " + DateTime.Now.AddHours(input), input);
            //adds the integer input in hours to the current dateTime and writes to console
            Console.Read();
        }
    }
}

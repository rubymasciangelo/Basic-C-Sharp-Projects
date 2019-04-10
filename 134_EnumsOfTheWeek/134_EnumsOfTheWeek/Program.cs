using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _134_EnumsOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("What day is it today?");
                string today = Console.ReadLine();
                Days day = (Days)Enum.Parse(typeof(Days), today, true); //coverts input string to its corresponding enum value
                
                int inputInt;
                bool intException = Int32.TryParse(today, out inputInt); //uses a bool to check if a tryparse to convert string input to an integer would be true
                if (intException) //catches that potential integer input and returns an error message.
                {
                    Console.WriteLine("That's not an actual day of the week");
                }
                else
                {
                    Console.WriteLine("You think today is " + today + "?");
                    Console.WriteLine("Maybe it is!");
                }
            }
            catch (ArgumentException) //catches anything that isn't an enumeration
            {
                Console.WriteLine("That's not an actual day of the week");
            }
            Console.Read();
        }

        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

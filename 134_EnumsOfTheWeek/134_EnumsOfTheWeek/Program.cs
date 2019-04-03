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
            }
            catch(ArgumentException) //catches anything that isn't an enumeration
            {
                Console.WriteLine("Please write an actual day of the week");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemp = 80;
            int roomTemp = 70;

            if (currentTemp == roomTemp)
            {
                Console.WriteLine("yes it it room temp");
            }
            else if (currentTemp > roomTemp)
            {
                Console.WriteLine("it is warmer");
            }
            else
            {
                Console.WriteLine("not exactly room temp");
            }
        }
    }
}

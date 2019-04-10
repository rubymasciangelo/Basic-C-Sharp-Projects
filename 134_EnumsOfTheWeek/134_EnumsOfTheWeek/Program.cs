﻿using System;
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
            //Console.WriteLine("What day is it today?");
            //string today = Console.ReadLine();
            

            try
            {
                string[] dayStrings = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                Console.WriteLine("What day is it today?");
                string today = Console.ReadLine();
                Days day = (Days)Enum.Parse(typeof(Days), today, true); //coverts input string to its corresponding enum value
                
                foreach (string dayString in dayStrings)
                {
                    try
                    {
                        Days dayValue = (Days)Enum.Parse(typeof(Days), dayString);

                        if //(today == dayString)//(Enum.IsDefined(typeof(Days), dayValue))
                        {
                            Console.WriteLine("You think today is " + today + "?");
                        }
                        else
                        {
                            Console.WriteLine("That's not an actual day of the week");
                        }
                    }
                    finally
                    {
                        Console.WriteLine("Maybe it is!");
                    }
                    break;
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

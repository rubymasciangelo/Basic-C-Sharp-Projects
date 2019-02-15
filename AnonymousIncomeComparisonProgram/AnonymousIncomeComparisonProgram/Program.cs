using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.Read();
            Console.WriteLine("Person 1");
            Console.Read();
            Console.WriteLine("What is your hourly rate?");
            string rateResponse1 = Console.ReadLine();
            decimal rate1 = Convert.ToDecimal(rateResponse1);
            Console.WriteLine("How many hours do you work per week?");
            string hoursResponse1 = Console.ReadLine();
            int hours1 = Convert.ToInt16(hoursResponse1);
            decimal salary1 = rate1 * hours1;
            Console.Read();
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string rateResponse2 = Console.ReadLine();
            decimal rate2 = Convert.ToDecimal(rateResponse2);
            Console.WriteLine("How many hours do you work per week?");
            string hoursResponse2 = Console.ReadLine();
            int hours2 = Convert.ToInt16(hoursResponse2);
            Console.Read();
            
            Console.WriteLine("Weekly salary of Person 1: " + salary1);
            Console.Read();
            decimal salary2 = rate2 * hours2;
            Console.WriteLine("Weekly salary of Person 2: " + salary2);
            Console.Read();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salaryCompare = salary1 > salary2;
            Console.WriteLine(salaryCompare.ToString());
            


        }
    }
}

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
            string rateResponseOne = Console.ReadLine();
            decimal rateOne = Convert.ToDecimal(rateResponseOne);
            Console.WriteLine("How many hours do you work per week?");
            string hoursResponseOne = Console.ReadLine();
            int hoursOne = Convert.ToInt16(hoursResponseOne);
            decimal salaryOne = rateOne * hoursOne;
            Console.Read();

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string rateResponseTwo = Console.ReadLine();
            decimal rateTwo = Convert.ToDecimal(rateResponseTwo);
            Console.Read();
            Console.WriteLine("How many hours do you work per week?");
            string hoursResponseTwo = Console.ReadLine();
            int hoursTwo = Convert.ToInt16(hoursResponseTwo);
            decimal salaryTwo = rateTwo * hoursTwo;
            Console.Read();
            
            Console.WriteLine("Weekly salary of Person 1: " + salaryOne);
            Console.Read();
            
            Console.WriteLine("Weekly salary of Person 2: " + salaryTwo);
            Console.Read();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salaryCompare = salaryOne > salaryTwo;
            Console.WriteLine(salaryCompare.ToString());
            Console.Read();
            


        }
    }
}

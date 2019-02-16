using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application Survey:");
            Console.WriteLine("Have you ever had a DUI? Please answer with either " + '"' + "true" + '"' + "or" + '"' + "false" + '"');
            string duiResponse = Console.ReadLine();
            bool duiStatus = Convert.ToBoolean(duiResponse);
            Console.Read();


            Console.WriteLine("How old are you?");
            string ageResponse = Console.ReadLine();
            int age = Convert.ToInt16(ageResponse);
            Console.Read();

            

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsResponse = Console.ReadLine();
            int tickets = Convert.ToInt16(ticketsResponse);
            Console.Read();

            Console.WriteLine("Have you qualified for car insurance with us?");
            Console.Read();
            Console.WriteLine(age > 15 && duiStatus == false && tickets <= 3);
            Console.Read();
        }
    }
}

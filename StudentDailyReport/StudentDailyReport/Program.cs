using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageResponse = Console.ReadLine();
            int currentPage = Convert.ToInt16(pageResponse);
            Console.WriteLine("Do you need help  with anything? Please answer " + '"' + "true" + '"' + " or " + '"' + "false" + '"');
            //string helpResponse = "true";
            //bool yesHelp = bool.Parse(helpResponse);
            string helpResponse = Console.ReadLine();
            bool helpValue = Convert.ToBoolean(helpResponse);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveResponse = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedbackResponse = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
